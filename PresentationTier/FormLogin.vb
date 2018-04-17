Imports WindowsApplication1

Public Class FormLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.UsersTableAdapter.Fill(Me.AqualocDataSet.Users)
        Me.StationsTableAdapter.Fill(Me.AqualocDataSet.Stations)
    End Sub

    Private Sub cmbLoginOk_Click(sender As Object, e As EventArgs) Handles cmbLoginOk.Click

        Dim currentUserDataRow As DataRowView = cboLogin.SelectedItem
        Dim currentUserStation As DataRowView = cboLoginStation.SelectedItem
        Dim enteredPassword As String = txtLoginPassword.Text
        '#todo salt and hash passwords
        If (DataEntityTier.AqualocDataSet.login(currentUserDataRow, enteredPassword)) Then
            Dim currentUserRole As String = currentUserDataRow(3)
            Select Case currentUserRole
                Case "A"
                    Dim FormAdmin As New FormAdmin()
                    Visible = False
                    FormAdmin.ShowDialog()
                    Me.Close()
                Case "Q"
                Case "C"
                    Dim FormStation As New FormStation(currentUserDataRow, currentUserStation)
                    'Dim formStation As New FormStation(cboLogin.SelectedValue, cboLoginStation.SelectedValue)                                                       )
                    Visible = False
                    FormStation.ShowDialog()
                    Me.Dispose()
            End Select
            'userStation = cboLoginStation.SelectedText
        Else
            MsgBox("Password Incorrect, Please Try again")
        End If
    End Sub
    Private Sub cmbLoginCancel_Click(sender As Object, e As EventArgs) Handles cmbLoginCancel.Click
        End
    End Sub
End Class