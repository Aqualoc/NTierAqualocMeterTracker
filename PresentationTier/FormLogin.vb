Imports WindowsApplication1

Public Class FormLogin
    'Public str As String
    'Public Property STR
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.UsersTableAdapter.Fill(Me.AqualocDataSet.Users)
        Me.StationsTableAdapter.Fill(Me.AqualocDataSet.Stations)
    End Sub

    Private Sub cmbLoginOk_Click(sender As Object, e As EventArgs) Handles cmbLoginOk.Click
        Dim currentUserDataRow As DataRowView = cboLogin.SelectedItem
        Dim enteredPassword As String = txtLoginPassword.Text
        '#todo salt and hash passwords
        If (DataEntityTier.AqualocDataSet.login(currentUserDataRow, enteredPassword)) Then
            Dim currentUserRole As String = currentUserDataRow(3)
            Select Case currentUserRole
                Case "A"
                    Dim FormAdmin As New FormAdmin()
                    Visible = False
                    FormAdmin.ShowDialog()
                    Me.Dispose()
                Case "Q"
                Case "C"
                    'FormStation.Visible = True
                    Dim FormStation As New FormStation(currentUserDataRow) 'currentUserStation
                    'Dim formStation As New FormStation(cboLogin.SelectedValue, cboLoginStation.SelectedValue)                                                       )
                    Visible = False
                    FormStation.ShowDialog()
                    '#todo move this to after select when done implementing 
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'move to admin section
        Dim newRow As DataEntityTier.AqualocDataSet.UsersRow
        newRow = AqualocDataSet.Users.NewUsersRow
        newRow.PersonID = 101
        newRow.FirstName = "me"
        newRow.LastName = "Vadia"
        newRow.Perms = "a"
        newRow.City = "Durban"
        newRow.UserPassword = 7791
        AqualocDataSet.Users.AddUsersRow(newRow)
        Try
            UseWaitCursor = True
            Validate()
            UsersBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(AqualocDataSet)
            UseWaitCursor = False
        Catch
            UseWaitCursor = False
        End Try
    End Sub
End Class
'Dim DataSvc As New ServiceReference1.Service1Client
'AqualocDataSet.Users.Merge(DataSvc.GetUsers)
'AqualocDataSet.Stations.Merge(DataSvc.GetStations)
'cboLogin.DataSource = AqualocDataSet.Users
'cboLogin.DisplayMember = "FirstName"
'cboLoginStation.DataSource = AqualocDataSet.Stations
'cboLoginStation.DisplayMember = "StationFunctions"