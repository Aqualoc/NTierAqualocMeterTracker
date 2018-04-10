Public Class frmFinal
    Dim KeyAscii As Double


    Private Sub ButtonFinalLogout_Click(sender As Object, e As EventArgs) Handles ButtonFinalLogout.Click

        If MsgBox("Are you sure, you want to exit ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If

    End Sub
    Private Sub txtFinalHeading_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFinalHeading.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub ButtonFinalBack_Click(sender As Object, e As EventArgs) Handles ButtonFinalBack.Click

        Dim SecondForm As New frmScanning

        SecondForm.Show()

        Me.Hide()



    End Sub

    Private Sub frmFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class




