Imports System.Text.RegularExpressions

Public Class FormLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ver As Version = Reflection.Assembly.GetExecutingAssembly().GetName().Version
        lblVersion.Text = String.Format(lblVersion.Text, ver.Major, ver.Minor, ver.Build, ver.Revision)
        Me.CenterToScreen()
        Me.UsersTableAdapter.Fill(Me.AqualocDataSet.Users)
        Me.StationsTableAdapter.Fill(Me.AqualocDataSet.Stations)
        ControlBox = False
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
                                           ByVal keyData As System.Windows.Forms.Keys) _
                                           As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            btnLogin.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim currentUserDataRow As DataRowView = cboUserName.SelectedItem
        Dim currentUserStation As DataRowView = cboStation.SelectedItem
        Dim enteredPassword As String = txtPassword.Text
        '#todo salt and hash passwords
        If (DataEntityTier.AqualocDataSet.login(currentUserDataRow, enteredPassword)) Then
            Dim currentUserRole As String = currentUserDataRow(4)
            Select Case currentUserRole
                Case "A"
                    Dim FormAdmin As New FormAdmin(currentUserDataRow, currentUserStation)
                    FormAdmin.Show()
                    Me.Close()
                Case "Q"

                Case "C"
                    Dim FormStation As New FormStation(currentUserDataRow, currentUserStation)
                    FormStation.Show()
                    Me.Close()
            End Select
        Else
            'MsgBox("Password Incorrect, Please Try again")
        End If
    End Sub
    Private Sub cmbLoginCancel_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub txtLoginPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim stxt As String = txtPassword.Text
        btnLogin.PerformClick()
        If (stxt.Contains("$")) Then
            If (stxt.Contains("$S")) Then
                cboStation.SelectedValue = CType(betweenString(stxt, "$S", "$S"), Integer)
                txtPassword.Text = ""
            End If
            If (stxt.Contains("$U")) Then
                cboUserName.SelectedValue = CType(betweenString(stxt, "$U", "$U"), Integer)
                If (stxt.Contains("$P")) Then
                    txtPassword.Text = betweenString(stxt, "$P", "$P")
                    btnLogin.PerformClick()
                End If
            End If
        End If
    End Sub

    Function betweenString(ByVal str As String, ByVal startString As String, ByVal endString As String) As String
        Dim strFrom As Integer = str.IndexOf(startString) + startString.Length
        Dim strTo = str.LastIndexOf(endString)
        betweenString = str.Substring(strFrom, strTo - strFrom)
    End Function
End Class