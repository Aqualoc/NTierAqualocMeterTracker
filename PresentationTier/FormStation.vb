Imports DataEntityTier

Public Class FormStation
    Dim passcount As Integer = 0
    Dim failcount As Integer = 0
    Private currentUser As DataRowView
    Private currentStation As DataRowView

    Public Sub New(currentUserDataRow As DataRowView, currentUserStation As DataRowView)
        Me.currentUser = currentUserDataRow
        Me.currentStation = currentUserStation
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
        MinimizeBox = False
        ButtonScanningNext.Text = "Last Meter: "
        LabelPassCount.Text = "Pass Count: " & passcount
        LabelFailCount.Text = "Fail Count: " & failcount
        ControlBox = False
        Me.Text = "Station: " & currentStation(2)
    End Sub

    Sub toDb(ByVal scannedMeterNumber As String, ByVal stat As Boolean)
        Dim rows() As AqualocDataSet.MetersRow = AqualocDataSet.Meters.Select("MeterNumber = '" & scannedMeterNumber & "'")
        If (rows.Count = 1) Then
            Dim newQC As DataEntityTier.AqualocDataSet.meterQcPointRow = AqualocDataSet.meterQcPoint.NewmeterQcPointRow
            newQC.stationId = currentStation(0)
            newQC.meterId = rows(0).MeterID
            newQC.userID = currentUser(0)
            newQC.qcPointPass = stat
            newQC.qcPointPassDate = Now
            newQC.qcPointPassTime = Date.Now.TimeOfDay()
            Try
                AqualocDataSet.meterQcPoint.AddmeterQcPointRow(newQC)
                TxtScanBox.Text = ""
                MeterQcPointBindingSource.EndEdit()
                UseWaitCursor = True
                Validate()
                TableAdapterManager1.UpdateAll(AqualocDataSet)
                UseWaitCursor = False
                If (stat) Then
                    passcount = passcount + 1
                    ButtonScanningNext.BackColor = Color.Green
                Else
                    failcount = failcount + 1
                    ButtonScanningNext.BackColor = Color.Red
                End If
            Catch e As Exception
                MsgBox("Error: Meter Has already been scanned at this Station" & vbNewLine & "DuplicateError")
                UseWaitCursor = False
                'AqualocDataSet.meterQcPoint.RemovemeterQcPointRow(newQC)
                ButtonScanningNext.BackColor = Color.Maroon
            End Try
        ElseIf (rows.Count < 1) Then
            MsgBox("Meter not found in the database")
            ButtonScanningNext.BackColor = Color.Maroon
        Else
            MsgBox("Unknow Error, Please Report Error 01 to IT")
            ButtonScanningNext.BackColor = Color.Maroon
        End If
        LabelPassCount.Text = "Pass Count: " & passcount
        LabelFailCount.Text = "Fail Count: " & failcount
    End Sub

    Private Sub ButtonScanningNext_Click(sender As Object, e As EventArgs) Handles ButtonScanningNext.Click
        End
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
            If (stxt.Contains("$F$")) Then
                If (stxt.Length = 11) Then
                    stxt = stxt.Substring(3)
                    toDb(stxt, False)
                    ButtonScanningNext.Text = "Last Meter: " & stxt
                    TxtScanBox.Text = ""
                End If
            End If
            If (stxt.Contains("$O$")) Then
                'find the record

                Dim urow As AqualocDataSet.meterQcPointRow = AqualocDataSet.meterQcPoint.FindBystationIdmeterId(1, 5142)
                urow.qcPointPass = False
                MeterQcPointBindingSource.EndEdit()
                UseWaitCursor = True
                Validate()
                TableAdapterManager1.UpdateAll(AqualocDataSet)
                UseWaitCursor = False
                TxtScanBox.Text = ""
                'modify record
                'output record modified
                'git push

            End If
        ElseIf (stxt.Length = 8) Then
            TxtScanBox.Text = ""
            toDb(stxt, True)
            ButtonScanningNext.Text = "Last Meter: " & stxt
        End If
    End Sub
End Class