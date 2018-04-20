Public Class FormLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.UsersTableAdapter.Fill(Me.AqualocDataSet.Users)
        Me.StationsTableAdapter.Fill(Me.AqualocDataSet.Stations)
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
                                           ByVal keyData As System.Windows.Forms.Keys) _
                                           As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            cmbLoginOk.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub cmbLoginOk_Click(sender As Object, e As EventArgs) Handles cmbLoginOk.Click
        Dim currentUserDataRow As DataRowView = cboLogin.SelectedItem
        Dim currentUserStation As DataRowView = cboLoginStation.SelectedItem
        Dim enteredPassword As String = txtLoginPassword.Text
        '#todo salt and hash passwords
        If (DataEntityTier.AqualocDataSet.login(currentUserDataRow, enteredPassword)) Then
            Dim currentUserRole As String = currentUserDataRow(4)
            Select Case currentUserRole
                Case "A"
                    Dim FormAdmin As New FormAdmin(currentUserDataRow, currentUserStation)
                    Visible = False
                    FormAdmin.ShowDialog()
                    Me.Close()
                Case "Q"
                Case "C"
                    Dim FormStation As New FormStation(currentUserDataRow, currentUserStation)
                    Visible = False
                    FormStation.ShowDialog()
                    Me.Dispose()
            End Select
        Else
            MsgBox("Password Incorrect, Please Try again")
        End If
    End Sub
    Private Sub cmbLoginCancel_Click(sender As Object, e As EventArgs) Handles cmbLoginCancel.Click
        End
    End Sub
End Class