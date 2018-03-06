Module Module2
    Friend objForm3 As New frmScanning
    Public Sub forms(ByRef Val As String)
        Val = String.Empty
    End Sub
    Sub Main()
        objForm3.ShowDialog()
    End Sub
End Module
