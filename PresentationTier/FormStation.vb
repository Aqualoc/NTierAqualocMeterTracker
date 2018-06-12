Imports DataEntityTier

Public Class FormStation
    Dim SessionPassCount As Integer = 0
    Dim SessionFailCount As Integer = 0
    Private currentUser As DataRowView
    Private currentStation As DataRowView

    Public Sub New(currentUser As DataRowView, currentStation As DataRowView)
        Me.currentUser = currentUser
        Me.currentStation = currentStation
    End Sub

    Private Sub frmScanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        UsersTableAdapter1.Fill(Me.AqualocDataSet.Users)
        StationsTableAdapter1.Fill(Me.AqualocDataSet.Stations)
        MetersTableAdapter1.Fill(Me.AqualocDataSet.Meters)
        MeterQcPointTableAdapter1.Fill(Me.AqualocDataSet.meterQcPoint)
        TxtScanningOperator.Text = currentUser(2) & " " & currentUser(1)
        TextBox1.Text = currentStation(2)
        Me.CenterToScreen()
        TxtScanBox.Select()
        ButtonScanningNext.Text = "Last Meter: "
        LabelPassCount.Text = "Pass Count: " & SessionPassCount
        LabelFailCount.Text = "Fail Count: " & SessionFailCount
        ControlBox = False
        Me.Text = "Station: " & currentStation(2)
    End Sub

    Sub toDb(ByVal scannedMeterNumber As String, ByVal stat As Boolean)
        Dim result As AqualocDataSet.MetersRow = getMeterIDFromMeterNumber(scannedMeterNumber)
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
                TxtScanBox.Text = ""
                MeterQcPointBindingSource.EndEdit()
                Validate()
                TableAdapterManager1.UpdateAll(AqualocDataSet)
                If (stat) Then
                    SessionPassCount = SessionPassCount + 1
                    ButtonScanningNext.BackColor = Color.Green
                Else
                    SessionFailCount = SessionFailCount + 1
                    ButtonScanningNext.BackColor = Color.Red
                End If
            Catch e As Exception
                MsgBox("Error: Meter Has already been scanned at this Station" & vbNewLine & "DuplicateError")
                'AqualocDataSet.meterQcPoint.RemovemeterQcPointRow(newQC)
                ButtonScanningNext.BackColor = Color.Maroon
            End Try
        End If
        LabelPassCount.Text = "Pass Count: " & SessionPassCount
        LabelFailCount.Text = "Fail Count: " & SessionFailCount
    End Sub

    Sub overrride(ByVal scannedMeterNumber As String, ByVal stat As Boolean)
        Dim meterNo As AqualocDataSet.MetersRow = getMeterIDFromMeterNumber(scannedMeterNumber)
        If (meterNo IsNot Nothing) Then
            Dim urow As AqualocDataSet.meterQcPointRow = AqualocDataSet.meterQcPoint.FindBystationIdmeterId(currentStation(0), meterNo.MeterID)
            urow.qcPointPass = False
            MeterQcPointBindingSource.EndEdit()
            Validate()
            TableAdapterManager1.UpdateAll(AqualocDataSet)
            TxtScanBox.Text = ""
            ButtonScanningNext.BackColor = Color.DarkRed
        ElseIf (meterNo Is Nothing) Then
            MsgBox("Error 15")
        End If
    End Sub
    Private Sub TxtScanBox_TextChanged(sender As Object, e As EventArgs) Handles TxtScanBox.TextChanged
        Dim stxt As String = TxtScanBox.Text
        If (stxt.Contains("$")) Then
            If (stxt.Contains("$C$")) Then
                TxtScanBox.Text = ""
            End If
            If (stxt.Contains("$E$")) Then
                End
            End If
            If (stxt.Contains("$R$")) Then
                Application.Restart()
            End If
            If (stxt.Contains("$F$") And stxt.Length = 11) Then
                toDb(stxt.Substring(3), False)
                ButtonScanningNext.Text = "Last Meter: " & stxt.Substring(3)
                TxtScanBox.Text = ""
            End If
            If (stxt.Contains("$OF$") And stxt.Length = 12) Then
                overrride(stxt.Substring(4), False)
                TxtScanBox.Text = ""
            End If
            If (stxt.Contains("$OP$") And stxt.Length = 12) Then
                overrride(stxt.Substring(4), True)
                TxtScanBox.Text = ""
            End If
        ElseIf (stxt.Length = 8) Then
            TxtScanBox.Text = ""
            toDb(stxt, True)
            ButtonScanningNext.Text = "Last Meter: " & stxt
        End If
    End Sub

    Private Function getMeterIDFromMeterNumber(ByVal meternumber As String) As AqualocDataSet.MetersRow
        Dim result() As AqualocDataSet.MetersRow = AqualocDataSet.Meters.Select("MeterNumber = '" & meternumber & "'")
        If result.Count = 1 Then
            Return result(0)
        ElseIf result.Count > 1 Then
            Return result(0)
            MsgBox("More than one result found for getMeterID() : " & meternumber & ". Please Report error 3 to IT")
        ElseIf result.Count = 0 Then
            MsgBox("Meter: " & meternumber & " not found in the Database")
        Else
            MsgBox("Unknown Error for getMeterID() :" & meternumber & ". Please Report error 4 to IT")
        End If
        Return Nothing
    End Function
End Class