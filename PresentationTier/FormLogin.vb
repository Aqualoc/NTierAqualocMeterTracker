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
        Dim selectedItemPwd As String = vrow(6)
        If txtLoginPassword.Text = selectedItemPwd Then
            MsgBox("Login Success")
            FormStation.Visible = True
            Me.Visible = False
        Else
            MsgBox("Password Incorrect, Please Try again")
        End If
    End Sub

    Private Sub cmbLoginCancel_Click(sender As Object, e As EventArgs) Handles cmbLoginCancel.Click
        End
    End Sub

End Class