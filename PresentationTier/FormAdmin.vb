﻿Public Class FormAdmin
    Public Property station As DataRowView
    Public Property user As DataRowView

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsersTableAdapter1.Fill(Me.AqualocDataSet.Users)
        'StationsTableAdapter.Fill(Me.AqualocDataSet.Stations)
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
            MsgBox("Nothing")
            Exit Sub
        Else
            For newMeters1 = newMeters To 1 Step -1
                Dim newMeterRow As DataEntityTier.AqualocDataSet.MetersRow = AqualocDataSet.Meters.NewMetersRow
                newMeterRow.MeterManufacturedDate = Date.Now()
                'newMeterRow.MeterID = newMeters
                AqualocDataSet.Meters.AddMetersRow(newMeterRow)
            Next newMeters1
            Try
                UseWaitCursor = True
                Validate()
                UsersBindingSource.EndEdit()
                TableAdapterManager1.UpdateAll(AqualocDataSet)
                UseWaitCursor = False
            Catch
                ' UseWaitCursor = False
            End Try

        End If
        MsgBox("Done")
    End Sub

    Private Sub MetersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        UseWaitCursor = True
        Validate()
        MetersBindingSource.EndEdit()
        TableAdapterManager1.UpdateAll(AqualocDataSet)
        'UseWaitCursor = False
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