Public Class frmScanning
    Dim Keyascii As Double


    Private Sub ButtonScanningNext_Click(sender As Object, e As EventArgs) Handles ButtonScanningNext.Click

        Dim txtScanningHeading As Double

        If TxtScanningHeading = vbEmpty Then

            MsgBox("Scan Barcode Here!", MsgBoxStyle.Critical, "Stupid")

        Else
            ButtonScanningPass.BackColor = Color.Green

            Static n As Integer



            n = n + 1
            Me.LblPass.Text = n.ToString()

            Application.DoEvents()


            Dim ThirdForm As New frmFinal
            ThirdForm.Show()
            Me.Hide()


        End If




    End Sub

    Private Sub TxtScanningHeading_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtScanningHeading.KeyPress
        TxtScanningHeading.Focus()
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True




        End If



    End Sub

    Public Sub forms(ByRef Val As String)

        Val = String.Empty


    End Sub



    Private Sub ButtonScanningPass_Click(sender As Object, e As EventArgs) Handles ButtonScanningPass.Click















    End Sub





    Private Sub ButtonScanningFail_Click(sender As Object, e As EventArgs) Handles ButtonScanningFail.Click
        TxtScanningHeading.Focus()

        Static n As Integer
        n = n + 1
        'Me.LblFail.Text = n.ToString()

        TxtScanningHeading.ResetText()
        TxtScanningHeading.Focus()

    End Sub
End Class




