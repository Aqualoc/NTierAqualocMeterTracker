Imports DataEntityTier

Public Class FormStation
    Private currentUser As DataRowView
    Private currentStation As DataRowView

    Public Sub New(currentUserDataRow As DataRowView, currentUserStation As DataRowView)
        Me.currentUser = currentUserDataRow
        Me.currentStation = currentUserStation
    End Sub

    Private Sub frmScanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        TxtScanningOperator.Text = currentUser(2) & " " & currentUser(1)
        Me.CenterToScreen()
    End Sub


End Class

'Private Sub ButtonScanningFail_Click(sender As Object, e As EventArgs) Handles ButtonScanningFail.Click
'MsgBox("Please Scan A valid Barcode!", MsgBoxStyle.Critical, "Error")
'TxtScanningHeading.Focus()
'Static n As Integer
'n = n + 1
'TxtScanningHeading.ResetText()
'TxtScanningHeading.Focus()
'End Sub
'Private Sub ButtonScanningNext_Click(sender As Object, e As EventArgs) Handles ButtonScanningNext.Click
'    Dim txtScanningHeading As Double
'    If txtScanningHeading = vbEmpty Then
'    Else
'        ButtonScanningPass.BackColor = Color.Green
'        Static n As Integer
'        n = n + 1
'        Me.LblPass.Text = n.ToString()
'        Application.DoEvents()
'    End If
'End Sub

'Private Sub TxtScanningHeading_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtScanningHeading.KeyPress
'    TxtScanningHeading.Focus()
'    If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
'        e.Handled = True
'    End If
'End Sub