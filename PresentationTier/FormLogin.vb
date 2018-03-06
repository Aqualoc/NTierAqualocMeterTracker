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

    Private Sub cboLogin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLogin.SelectedIndexChanged
        If cboLogin.SelectedItem = "Thabo" Then
        Else
            If cboLogin.SelectedItem = "Morena" Then
            Else
                If cboLogin.SelectedItem = "Rachel" Then
                Else
                    If cboLogin.SelectedItem = "Preshen" Then
                    Else cboLogin.SelectedItem = "Ahmed"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cboLoginStation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoginStation.SelectedIndexChanged
        If cboLoginStation.SelectedItem = "Test1" Then
        Else
            If cboLoginStation.SelectedItem = "Test2" Then
            Else
                If cboLoginStation.SelectedItem = "Test3" Then
                Else
                    If cboLoginStation.SelectedItem = "Test4" Then
                    Else cboLoginStation.SelectedItem = "Test5"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cboLogin_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLogin.SelectedValueChanged
        Val = cboLogin.SelectedItem
    End Sub

    Private Sub cmdLoginReset_Click(sender As Object, e As EventArgs) Handles cmdLoginReset.Click
        cboLogin.ResetText()
        cboLoginStation.ResetText()
        txtLoginPassword.ResetText()
        cboLogin.Focus()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLoginPassword.PasswordChar = "*"
        txtLoginPassword.MaxLength = 9
        Dim DataSvc As New ServiceReference1.Service1Client
        AqualocDataSet.Users.Merge(DataSvc.GetUsers)
    End Sub
End Class