Public Class FormAdmin
    Public Property station As DataRowView
    Public Property user As DataRowView

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsersTableAdapter1.Fill(Me.AqualocDataSet.Users)
        StationsTableAdapter1.Fill(Me.AqualocDataSet.Stations)
        MetersTableAdapter1.Fill(Me.AqualocDataSet.Meters)
        CenterToScreen()
    End Sub

    Private Sub btnCreateStickers_Click(sender As Object, e As EventArgs) Handles btnCreateStickers.Click
        'Get number of stickers V
        'find last sticker number in db
        'allocate spaces for next V meters in the database
        'print out the appropriate V stickers for each meter
        Dim newMeters As Integer
        newMeters = InputBox("How many stickers do you want to create?", "Enter Number of Meters", "0")
        If newMeters < 1 Then
            MessageBox.Show("You must enter the number of meters to continue.")
            Exit Sub
        ElseIf newMeters = Nothing Then
            MsgBox("newMeters = Nothing, Report to Ahmed")
            Exit Sub
        Else
            For newMeters1 = newMeters To 1 Step -1
                Dim newMeterRow As DataEntityTier.AqualocDataSet.MetersRow = AqualocDataSet.Meters.NewMetersRow
                newMeterRow.MeterManufacturedDate = Date.Now()
                Dim lastRow = AqualocDataSet.Meters.Rows(AqualocDataSet.Meters.Rows.Count() - 1)
                newMeterRow.MeterNumber = CType(lastRow(1), Integer) + 1
                AqualocDataSet.Meters.AddMetersRow(newMeterRow)
                MetersBindingSource.EndEdit()
            Next newMeters1
            Try
                UseWaitCursor = True
                Validate()
                MetersBindingSource.EndEdit()
                TableAdapterManager1.UpdateAll(AqualocDataSet)
                UseWaitCursor = False
            Catch
                'UseWaitCursor = False
            End Try
        End If
        MsgBox("Meters Added")
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click

    End Sub
End Class
'Dim newrow As DataEntityTier.AqualocDataSet.UsersRow = AqualocDataSet.Users.NewUsersRow
'newrow.UserFirstName = "test"
'newrow.UserLastName = "test"
'newrow.UserPerms = "a"
'newrow.UserCity = "jhb"
'newrow.UserPassword = 2222
'AqualocDataSet.Users.AddUsersRow(newrow)
'Try
'    UseWaitCursor = True
'    Validate()
'    UsersBindingSource.EndEdit()
'    TableAdapterManager1.UpdateAll(AqualocDataSet)
'    UseWaitCursor = False
'Catch
'    UseWaitCursor = False
'End Try

'Private Sub metersbindingnavigatorsaveitem_click_1(sender As Object, e As EventArgs)
'    UseWaitCursor = True
'    Validate()
'    MetersBindingSource.EndEdit()
'    TableAdapterManager1.UpdateAll(AqualocDataSet)
'    UseWaitCursor = False
'End Sub