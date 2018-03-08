Public Class frmLogin
    Public Shared currentUserDataRow As DataRowView
    Public Shared userStation As String
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DataSvc As New ServiceReference1.Service1Client
        AqualocDataSet.Users.Merge(DataSvc.GetUsers)
        AqualocDataSet.Stations.Merge(DataSvc.GetStations)
        cboLogin.DataSource = AqualocDataSet.Users
        cboLogin.DisplayMember = "FirstName"
        cboLoginStation.DataSource = AqualocDataSet.Stations
        cboLoginStation.DisplayMember = "StationName"
    End Sub

    Private Sub cmbLoginOk_Click(sender As Object, e As EventArgs) Handles cmbLoginOk.Click
        currentUserDataRow = cboLogin.SelectedItem
        Dim currentUserPwd As String = currentUserDataRow(6)
        Dim currentUserRole As String = currentUserDataRow(3)
        If txtLoginPassword.Text = currentUserPwd Then
            Select Case currentUserRole
                Case "A"
                    'FormAdmin.Visible = True
                Case "Q"
                    'FormQC.Visible = True
                Case "C"
                    FormStation.Visible = True
            End Select
            userStation = cboLoginStation.SelectedText
            Me.Visible = False
        Else
            MsgBox("Password Incorrect, Please Try again")
        End If
    End Sub
    Private Sub cmbLoginCancel_Click(sender As Object, e As EventArgs) Handles cmbLoginCancel.Click
        End
    End Sub
End Class