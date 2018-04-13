Imports DataEntityTier

Public Class FormStation
    Private currentUserDataRow As DataRowView

    Public Sub New(currentUserDataRow As DataRowView)
        Me.currentUserDataRow = currentUserDataRow
    End Sub

    Private Sub frmScanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        Me.CenterToScreen()
    End Sub

    Private Sub ButtonScanningNext_Click(sender As Object, e As EventArgs) Handles ButtonScanningNext.Click
        Close()
        Dim txtScanningHeading As Double

        If txtScanningHeading = vbEmpty Then
        Else
            ButtonScanningPass.BackColor = Color.Green
            Static n As Integer
            n = n + 1
            Me.LblPass.Text = n.ToString()
            Application.DoEvents()
            Dim ThirdForm As New FormFinal
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

    Private Sub ButtonScanningFail_Click(sender As Object, e As EventArgs) Handles ButtonScanningFail.Click
        MsgBox("Please Scan A valid Barcode!", MsgBoxStyle.Critical, "Error")
        TxtScanningHeading.Focus()
        Static n As Integer
        n = n + 1
        TxtScanningHeading.ResetText()
        TxtScanningHeading.Focus()

    End Sub

    Private Sub ButtonScanningPass_Click(sender As Object, e As EventArgs) Handles ButtonScanningPass.Click
    End Sub
End Class