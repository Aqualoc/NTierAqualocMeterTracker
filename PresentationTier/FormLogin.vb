Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DataSvc As New ServiceReference1.Service1Client
        AqualocDataSet.Users.Merge(DataSvc.GetUsers)
        AqualocDataSet.Stations.Merge(DataSvc.GetStations)
        cboLogin.DataSource = AqualocDataSet.Users
        cboLogin.DisplayMember = "FirstName"
        cboLoginStation.DataSource = AqualocDataSet.Stations
        cboLoginStation.DisplayMember = "stationName"
    End Sub

    Private Sub cmbLoginOk_Click(sender As Object, e As EventArgs) Handles cmbLoginOk.Click
        Dim vrow As DataRowView
        vrow = cboLogin.SelectedItem
        If txtLoginPassword.Text = vrow(6) Then
            MsgBox("Fuck Yes")
        End If

    End Sub

    Private Sub cmbLoginCancel_Click(sender As Object, e As EventArgs) Handles cmbLoginCancel.Click
        End
    End Sub

End Class

'AqualocDataSet.Users.AddUsersRow(20, "Vadia", "Ahmed", "", "", "", "")
'AqualocDataSet.AcceptChanges()