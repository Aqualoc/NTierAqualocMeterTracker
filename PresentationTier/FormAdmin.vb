Public Class FormAdmin
    'Private currentUserDataRow As DataRowView
    'Private currentUserStation As DataRowView

    Public Sub New(currentUserDataRow As DataRowView, currentUserStation As DataRowView)
        'Me.currentUserDataRow = currentUserDataRow
        'Me.currentUserStation = currentUserStation
    End Sub

    'Public Property stationRow As DataRowView
    ' Public Property userRow As DataRowView

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        CenterToScreen()
        Me.UsersTableAdapter1.Fill(Me.AqualocDataSet.Users)
        Me.StationsTableAdapter1.Fill(Me.AqualocDataSet.Stations)
        Me.MetersTableAdapter1.Fill(Me.AqualocDataSet.Meters)
        btnCreateStation.Enabled = False
        btnCreateUser.Enabled = False
        btnDeleteUser.Enabled = False
    End Sub

    Private Sub btnCreateStickers_Click(sender As Object, e As EventArgs) Handles btnCreateStickers.Click
        Dim Valid As Boolean = False
        Dim newMeters As String
        While (Valid = False)
            newMeters = InputBox("Enter number of meters to process ")
            If newMeters = Nothing Then
                Exit Sub
            End If
            If IsNumeric(newMeters) Then
                Valid = True
            Else
                Valid = False
                MsgBox("Please enter a valid number of meters")
            End If
        End While
        For newMeters1 = CType(newMeters, Integer) To 1 Step -1
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
        End Try
        MsgBox("Meters Added")
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        End
    End Sub
End Class