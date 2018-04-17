Partial Class AqualocDataSet
    Partial Public Class UsersDataTable

        Private Sub UsersDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
        End Sub

    End Class

    Public Shared Function login(ByRef userRow As DataRowView, ByRef enteredPassword As String)
        Dim currentUserPwd As String = userRow(3)
        If enteredPassword = currentUserPwd Then
            Return True
        End If
        Return False
    End Function

End Class
