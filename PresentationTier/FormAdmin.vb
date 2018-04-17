Public Class FormAdmin
    Public Property station As DataRowView
    Public Property user As DataRowView

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsersTableAdapter.Fill(Me.AqualocDataSet.Users)
        StationsTableAdapter.Fill(Me.AqualocDataSet.Stations)
        MetersTableAdapter.Fill(Me.AqualocDataSet.Meters)
        CenterToScreen()
    End Sub

    Private Sub btnCreateStickers_Click(sender As Object, e As EventArgs) Handles btnCreateStickers.Click
        'Get number of stickers V
        'find last sticker number in db
        'allocate spaces for next V meters in the database
        'print out the appropriate V stickers for each meter
        Dim newMeters As String
        newMeters = InputBox("How many stickers do you want to create?", "Enter Number of Meters", "0")
        If newMeters = "0" Then
            MessageBox.Show("You must enter the number of meters to continue.")
            'Exit Sub
        ElseIf newMeters = "" Then
            'Exit Sub
        Else
            ' Dim newMeterRow As DataEntityTier.AqualocDataSet.MetersRow
        End If

        Dim newRow As DataEntityTier.AqualocDataSet.UsersRow = AqualocDataSet.Users.NewUsersRow
        'Dim newRow As DataEntityTier.AqualocDataSet.User
        'UsersTableAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        newRow.PersonID = "9"
        newRow.FirstName = "me"
        newRow.LastName = "Vadia"
        newRow.Perms = "a"
        newRow.City = "Durban"
        newRow.UserPassword = 7791
        AqualocDataSet.Users.AddUsersRow(newRow)
        'Dim dc As DataEntityTier.AqualocDataSet.
        'AqualocDataSet.Users.
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
    Public Sub SetValue(ByVal aValue As String)
        btnDeleteUser.Text = aValue
        ' Do something else
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        MsgBox("Test")
    End Sub

    Private Sub MetersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles MetersBindingNavigatorSaveItem.Click
        UseWaitCursor = True
        Validate()
        MetersBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(AqualocDataSet)
        'UseWaitCursor = False
    End Sub

    Private Sub MetersDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles MetersDataGridView.CellContentClick


    End Sub
End Class