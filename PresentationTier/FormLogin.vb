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

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLogin.DataSource = AqualocDataSet.Users
        cboLogin.DisplayMember = "FirstName"
        cboLoginStation.DataSource = AqualocDataSet.Stations
        cboLoginStation.DisplayMember = "Stations"
    End Sub
End Class