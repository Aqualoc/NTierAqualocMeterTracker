Public Class frmLogin
    Dim Val As String = String.Empty
    Private Sub cmbLoginOk_Click(sender As Object, e As EventArgs) Handles cmbLoginOk.Click
        Dim SecondForm As New frmScanning
        SecondForm.TxtScanningOperator.Text = Val
        If txtLoginPassword.Text = "a" And
            cboLogin.SelectedIndex <> -1 And
            cboLoginStation.SelectedIndex <> -1 Then
            SecondForm.Show()
            Me.Hide()
        Else
            If txtLoginPassword.Text = "" Then
                MsgBox("No Password found!", MsgBoxStyle.Critical, "Error")
            Else
                If cboLogin.SelectedItem = "" Then
                    MsgBox("No Login Selected!", MsgBoxStyle.Critical, "Error")
                Else
                    If cboLoginStation.SelectedItem = "" Then
                        MsgBox("No Station Selected!", MsgBoxStyle.Critical, "Error")
                    Else
                        If cboLoginStation.SelectedItem = "" And cboLogin.SelectedItem = "" Then

                            MsgBox("No Login & Station Selected!", MsgBoxStyle.Critical, "Error")

                        Else
                            MsgBox("Invalid Password!", MsgBoxStyle.Critical, "Error")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmbLoginCancel_Click(sender As Object, e As EventArgs) Handles cmbLoginCancel.Click
        End
    End Sub


    Private Sub cboLoginStation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoginStation.SelectedIndexChanged

    End Sub

    Private Sub cboLogin_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLogin.SelectedValueChanged
        'Val = cboLogin.SelectedItem
    End Sub

    Private Sub cmdLoginReset_Click(sender As Object, e As EventArgs)
        cboLogin.ResetText()
        cboLoginStation.ResetText()
        txtLoginPassword.ResetText()
        cboLogin.Focus()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLoginPassword.PasswordChar = "*"
        Dim DataSvc As New ServiceReference1.Service1Client
        AqualocDataSet.Users.Merge(DataSvc.GetUsers)
        cboLogin.DataSource = AqualocDataSet.Users
        cboLogin.DisplayMember = "FirstName"




    End Sub

    Private Sub LblloginHeading_Click(sender As Object, e As EventArgs) Handles LblloginHeading.Click

    End Sub
End Class