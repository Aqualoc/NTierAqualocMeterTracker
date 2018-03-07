' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in both code and config file together.
Public Class Service1
    Implements IService1

    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetUsers() As DataEntityTier.AqualocDataSet.UsersDataTable Implements IService1.GetUsers
        Dim UsersTableAdapter1 As New DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter
        Return UsersTableAdapter1.GetUsers()
    End Function

    Public Function GetStations() As DataEntityTier.AqualocDataSet.StationsDataTable Implements IService1.GetStations
        Dim UsersTableAdapter2 As New DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter
        Return UsersTableAdapter2.GetStations()
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

End Class
