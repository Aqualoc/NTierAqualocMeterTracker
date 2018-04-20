Imports DataEntityTier

Public Class FormStation
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
        TxtScanningOperator.Text = currentUser(2) & " " & currentUser(1)
        TextBox1.Text = currentStation(2)
        Me.CenterToScreen()
        TxtScanBox.Select()

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
                MeterQcPointBindingSource.EndEdit()
                UseWaitCursor = True
                Validate()
                TableAdapterManager1.UpdateAll(AqualocDataSet)
                UseWaitCursor = False
            Catch e As Exception
                MsgBox("Error updating to the Databse, please contact IT" & vbNewLine & e.Message)
                UseWaitCursor = False
            End Try
        ElseIf (rows.Count < 1) Then
            MsgBox("Meter Not found in the database")
        Else
            MsgBox("please use positive numbers only")
        End If
    End Sub

    Private Sub ButtonScanningNext_Click(sender As Object, e As EventArgs) Handles ButtonScanningNext.Click
        End
    End Sub

    Private Sub TxtScanBox_TextChanged(sender As Object, e As EventArgs) Handles TxtScanBox.TextChanged
        Dim stxt As String = TxtScanBox.Text
        If (stxt.Contains("$")) Then
            If (stxt.Contains("$C")) Then
                TxtScanBox.Text = ""
            End If
            If (stxt.Contains("$E")) Then
                End
            End If
            If (stxt.Contains("$R")) Then
                Application.Restart()
            End If
            If (stxt.Contains("$F")) Then
                If (stxt.Length = 13) Then
                    stxt = stxt.Substring(5)
                    toDb(stxt, False)
                    TxtScanBox.Text = ""
                End If
            End If
        ElseIf (stxt.Length = 8) Then
            toDb(stxt, True)
            TxtScanBox.Text = ""
        End If

    End Sub
End Class