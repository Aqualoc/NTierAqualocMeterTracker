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
    Dim meterLength As Integer = 8

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
        UsersTableAdapter1.Fill(Me.AqualocDataSet.Users)
        StationsTableAdapter1.Fill(Me.AqualocDataSet.Stations)
        MetersTableAdapter1.Fill(Me.AqualocDataSet.Meters)
        MeterQcPointTableAdapter1.Fill(Me.AqualocDataSet.meterQcPoint)

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
        Dim scannedTxt As String = TxtScanBox.Text
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
            If (scannedTxt.Contains(strFail) And scannedTxt.Length = strFail.Length + meterLength) Then
                'FAIL
                scannedTxt = scannedTxt.Replace(strFail, "")
                If (toDb(scannedTxt, False)) Then
                    ButtonScanFeedback.Text = "Last Meter: " & scannedTxt
                    fail.count = fail.count + 1
                Else
                    MsgBox("Error: Meter Has already been scanned at this Station" & vbNewLine & "DuplicateError")
                    ButtonScanFeedback.BackColor = Color.Maroon
                End If
                TxtScanBox.Text = ""
            End If
            If (scannedTxt.Contains(strOverrideFail) And scannedTxt.Length = strOverrideFail.Length + meterLength) Then
                'OVERRIDE FAIL
                scannedTxt = scannedTxt.Replace(strOverrideFail, "")
                If overrride(scannedTxt, False) Then
                    ButtonScanFeedback.Text = "Last Fail Override: " & scannedTxt
                    MsgBox("Override " & scannedTxt)
                    ButtonScanFeedback.BackColor = Color.DarkRed
                End If
                TxtScanBox.Text = ""
            End If
            If (scannedTxt.Contains(strOverridePass) And scannedTxt.Length = strOverridePass.Length + meterLength) Then
                scannedTxt = scannedTxt.Replace(strOverridePass, "")
                If overrride(scannedTxt, True) Then
                    ButtonScanFeedback.Text = "Last Pass Override: " & scannedTxt
                    MsgBox("Override " & scannedTxt)
                    ButtonScanFeedback.BackColor = Color.DarkGreen
                End If
                TxtScanBox.Text = ""
            End If
        ElseIf (scannedTxt.Length = meterLength) Then
            If toDb(scannedTxt, True) Then
                'PASS
                pass.count = pass.count + 1
                ButtonScanFeedback.Text = "Last Meter: " & scannedTxt
            Else
                MsgBox("Error: Meter Has already been scanned at this Station" & vbNewLine & "DuplicateError")
                ButtonScanFeedback.BackColor = Color.Maroon
            End If
            TxtScanBox.Text = ""
        End If
    End Sub

    Private Function getMeterRowFromMeterNumber(ByVal meternumber As String) As AqualocDataSet.MetersRow
        Dim result() As AqualocDataSet.MetersRow = AqualocDataSet.Meters.Select("MeterNumber = '" & meternumber & "'")
        If result.Count = 1 Then
            Return result(0)
        ElseIf result.Count > 1 Then
            Return result(0)
            MsgBox("More than one result found for getMeterID() : " & meternumber & ". Please report error 3 to IT")
        ElseIf result.Count = 0 Then
            MsgBox("Meter: " & meternumber & " not found in the Database")
        Else
            MsgBox("Unknown Error for getMeterID() :" & meternumber & ". Please Report error 4 to IT")
        End If
        Return Nothing
    End Function

    Private Function toDb(ByVal scannedMeterNumber As String, ByVal stat As Boolean) As Boolean
        Dim result As AqualocDataSet.MetersRow = getMeterRowFromMeterNumber(scannedMeterNumber)
        If (result IsNot Nothing) Then
            Dim newQC As DataEntityTier.AqualocDataSet.meterQcPointRow = AqualocDataSet.meterQcPoint.NewmeterQcPointRow
            newQC.stationId = currentStation(0)
            newQC.meterId = result.MeterID
            newQC.userID = currentUser(0)
            newQC.qcPointPass = stat
            newQC.qcPointPassDate = Now
            newQC.qcPointPassTime = Date.Now.TimeOfDay()
            Try
                AqualocDataSet.meterQcPoint.AddmeterQcPointRow(newQC)
                MeterQcPointBindingSource.EndEdit()
                Validate()
                TableAdapterManager1.UpdateAll(AqualocDataSet)
                Return True
            Catch e As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    Private Function overrride(ByVal scannedMeterNumber As String, ByVal stat As Boolean) As Boolean
        Dim meterNo As AqualocDataSet.MetersRow = getMeterRowFromMeterNumber(scannedMeterNumber)
        If (meterNo IsNot Nothing) Then
            Dim urow As AqualocDataSet.meterQcPointRow = AqualocDataSet.meterQcPoint.FindBystationIdmeterId(currentStation(0), meterNo.MeterID)
            urow.qcPointPass = False
            MeterQcPointBindingSource.EndEdit()
            Validate()
            TableAdapterManager1.UpdateAll(AqualocDataSet)
            Return True
        Else
            MsgBox("Could Not Override " & scannedMeterNumber)
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

    End Sub

    Private Sub failOverrideChanged(ByVal NewValue As Integer) Handles passOverride.countChanged

    End Sub
End Class