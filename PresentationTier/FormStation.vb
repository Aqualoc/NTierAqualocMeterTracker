Imports DataEntityTier

Public Class FormStation

    Private currentUser As DataRowView
    Private currentStation As DataRowView

    Dim strClear As String = "$C$"
    Dim strExit As String = "$E$"
    Dim strRestart As String = "$R$"
    Dim strFail As String = "$F$"
    Dim strOverrideFail As String = "$OF$"
    Dim strOverridePass As String = "$OP$"
    Dim PartLength As Integer = 8

    Private WithEvents pass As New Counter
    Private WithEvents fail As New Counter
    Private WithEvents passOverride As New Counter
    Private WithEvents failOverride As New Counter

    Public Sub New(currentUser As DataRowView, currentStation As DataRowView)
        Me.currentUser = currentUser
        Me.currentStation = currentStation
    End Sub

    Private Sub frmScanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeComponent()

        'Intialize Dataset
        UsersTableAdapter1.Fill(AqualocDataSet.Users)
        StationsTableAdapter1.Fill(AqualocDataSet.Stations)
        PartTableAdapter1.Fill(AqualocDataSet.Part)
        PartQcPointTableAdapter1.Fill(AqualocDataSet.PartQcPoint)

        TextBoxCurrentOperator.Text = currentUser(2) & " " & currentUser(1)
        TextBoxCurrentStation.Text = currentStation(2)
        Me.Text = "Station: " & currentStation(2)
        ControlBox = False
        Me.CenterToScreen()
        TxtScanBox.Select()
        pass.count = 0
        fail.count = 0
        passOverride.count = 0
        failOverride.count = 0
        ButtonScanFeedback.BackColor = DefaultBackColor 'fix up later effected no one ever

    End Sub

    Private Sub TxtScanBox_TextChanged(sender As Object, e As EventArgs) Handles TxtScanBox.TextChanged
        Dim scannedTxt As String = TxtScanBox.Text.Split(",")(0)

        If (scannedTxt.Contains("$")) Then
            If (scannedTxt.Contains(strClear)) Then
                TxtScanBox.Text = ""
            End If
            If (scannedTxt.Contains(strExit)) Then
                End
            End If
            If (scannedTxt.Contains(strRestart)) Then
                Application.Restart()
            End If
            If (scannedTxt.Contains(strFail) And scannedTxt.Length = strFail.Length + PartLength) Then
                'FAIL
                scannedTxt = scannedTxt.Replace(strFail, "")
                If (toDb(scannedTxt, False)) Then
                    ButtonScanFeedback.Text = "Last Part: " & scannedTxt
                    fail.count = fail.count + 1
                Else
                    MsgBox("Error: Part Has already been scanned at this Station" & vbNewLine & "DuplicateError")
                    ButtonScanFeedback.BackColor = Color.Maroon
                End If
                TxtScanBox.Text = ""
            End If
            If (scannedTxt.Contains(strOverrideFail) And scannedTxt.Length = strOverrideFail.Length + PartLength) Then
                'OVERRIDE FAIL
                scannedTxt = scannedTxt.Replace(strOverrideFail, "")
                If override(scannedTxt, False) Then
                    failOverride.count = fail.count + 1
                    ButtonScanFeedback.Text = "Last Fail Override: " & scannedTxt
                End If
                TxtScanBox.Text = ""
            End If
            If (scannedTxt.Contains(strOverridePass) And scannedTxt.Length = strOverridePass.Length + PartLength) Then
                'OVERRIDE PASS
                scannedTxt = scannedTxt.Replace(strOverridePass, "")
                If override(scannedTxt, True) Then
                    passOverride.count = passOverride.count + 1
                End If
                TxtScanBox.Text = ""
            End If
        ElseIf (scannedTxt.Length = PartLength) Then
            'PASS
            If toDb(scannedTxt, True) Then
                pass.count = pass.count + 1
                ButtonScanFeedback.Text = "Last Part: " & scannedTxt
            Else
                MsgBox("Error: Part Has already been scanned at this Station" & vbNewLine & "DuplicateError")
                ButtonScanFeedback.BackColor = Color.Maroon
            End If
            TxtScanBox.Text = ""
        End If
    End Sub

    Private Function getPartRowFromPartNumber(ByVal Partnumber As String) As AqualocDataSet.PartRow
        Dim result() As AqualocDataSet.PartRow = AqualocDataSet.Part.Select("PartNumber = '" & Partnumber & "'")
        If result.Count = 1 Then
            Return result(0)
        ElseIf result.Count > 1 Then
            Return result(0)
            MsgBox("More than one result found for getPartID() : " & Partnumber & ". Please report error 3 to IT")
        ElseIf result.Count = 0 Then
            MsgBox("Part: " & Partnumber & " not found in the Database")
        Else
            MsgBox("Unknown Error for getPartID() :" & Partnumber & ". Please Report error 4 to IT")
        End If
        Return Nothing
    End Function

    Private Function toDb(ByVal scannedPartNumber As String, ByVal stat As Boolean) As Boolean
        Dim result As AqualocDataSet.PartRow = getPartRowFromPartNumber(scannedPartNumber)
        If (result IsNot Nothing) Then
            Dim newQC As AqualocDataSet.PartQcPointRow = AqualocDataSet.PartQcPoint.NewPartQcPointRow
            newQC = addData(stat, result.PartID, newQC)
            Try
                push(newQC)
                Return True
            Catch e As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    Private Sub push(newQC As AqualocDataSet.PartQcPointRow)
        AqualocDataSet.PartQcPoint.AddPartQcPointRow(newQC)
        PartQcPointBindingSource.EndEdit()
        Validate()
        TableAdapterManager1.UpdateAll(AqualocDataSet)
    End Sub

    Private Function addData(stat As Boolean, PartID As String, newQC As AqualocDataSet.PartQcPointRow) As AqualocDataSet.PartQcPointRow
        newQC.stationId = currentStation(0)
        newQC.PartId = PartID
        newQC.userID = currentUser(0)
        newQC.qcPointPass = stat
        newQC.qcPointPassDate = Now
        newQC.qcPointPassTime = Date.Now.TimeOfDay() 'change db to datetime
        Return newQC
    End Function

    Private Function override(ByVal scannedPartNumber As String, ByVal stat As Boolean) As Boolean
        Dim PartNo As AqualocDataSet.PartRow = getPartRowFromPartNumber(scannedPartNumber)
        If (PartNo IsNot Nothing) Then
            Dim urow As AqualocDataSet.PartQcPointRow = AqualocDataSet.PartQcPoint.FindBystationIdPartId(currentStation(0), PartNo.PartID)
            urow.qcPointPass = stat
            push(urow)
            Return True
        Else
            MsgBox("Could Not Override " & scannedPartNumber)
            Return False
        End If
        Return False
    End Function

    Private Sub passChanged(ByVal NewValue As Integer) Handles pass.countChanged
        LabelPassCount.Text = "Pass Count: " & NewValue
        ButtonScanFeedback.BackColor = Color.Green
    End Sub

    Private Sub failChanged(ByVal NewValue As Integer) Handles fail.countChanged
        LabelFailCount.Text = "Fail Count: " & NewValue
        ButtonScanFeedback.BackColor = Color.Red
    End Sub

    Private Sub passOverrideChanged(ByVal NewValue As Integer) Handles passOverride.countChanged
        ButtonScanFeedback.BackColor = Color.DarkGreen
    End Sub

    Private Sub failOverrideChanged(ByVal NewValue As Integer) Handles passOverride.countChanged
        ButtonScanFeedback.BackColor = Color.DarkRed
    End Sub

End Class