Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DataSvc As New ServiceReference1.Service1Client
        AqualocDataSet.Users.Merge(DataSvc.GetUsers)
    End Sub
End Class
