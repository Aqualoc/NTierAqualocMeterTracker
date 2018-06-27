Public Class FormAdmin
    'Private currentUserDataRow As DataRowView
    'Private currentUserStation As DataRowView

    Public Sub New(currentUserDataRow As DataRowView, currentUserStation As DataRowView)
        'Me.currentUserDataRow = currentUserDataRow
        'Me.currentUserStation = currentUserStation
    End Sub

    'Public Property stationRow As DataRowView
    'Public Property userRow As DataRowView

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        CenterToScreen()
        Me.UsersTableAdapter1.Fill(Me.AqualocDataSet.Users)
        Me.StationsTableAdapter1.Fill(Me.AqualocDataSet.Stations)
        Me.PartTableAdapter1.Fill(Me.AqualocDataSet.Part)
        btnCreateStation.Enabled = False
        btnCreateUser.Enabled = False
        btnDeleteUser.Enabled = False
        ControlBox = False
    End Sub

    Private Sub btnCreateStickers_Click(sender As Object, e As EventArgs) Handles btnCreateStickers.Click
        Dim Valid As Boolean = False
        Dim newParts As String
        While (Valid = False)
            newParts = InputBox("Enter number of Parts to process ")
            If newParts = Nothing Then
                Exit Sub
            End If
            If IsNumeric(newParts) Then
                Valid = True
            Else
                Valid = False
                MsgBox("Please enter a valid number of Parts")
            End If
        End While
        For newParts1 = CType(newParts, Integer) To 1 Step -1
            Dim newPartRow As DataEntityTier.AqualocDataSet.PartRow = AqualocDataSet.Part.NewPartRow
            newPartRow.PartManufacturedDate = Date.Now()
            Dim lastRow = AqualocDataSet.Part.Rows(AqualocDataSet.Part.Rows.Count() - 1)
            newPartRow.PartNumber = CType(lastRow(1), Integer) + 1
            AqualocDataSet.Part.AddPartRow(newPartRow)
            PartBindingSource.EndEdit()
        Next newParts1
        Try
            UseWaitCursor = True
            Validate()
            PartBindingSource.EndEdit()
            TableAdapterManager1.UpdateAll(AqualocDataSet)
            UseWaitCursor = False
        Catch
        End Try
        MsgBox("Parts Added")
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        End
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub
End Class