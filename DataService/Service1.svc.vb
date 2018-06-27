' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function
    Public Function GetPart() As DataEntityTier.AqualocDataSet.PartDataTable Implements IService1.GetParts
        Dim PartTableAdapter1 As New DataAccessTier.AqualocDataSetTableAdapters.PartTableAdapter
        Return PartTableAdapter1.GetParts()
    End Function

    Public Function GetStations() As DataEntityTier.AqualocDataSet.StationsDataTable Implements IService1.GetStations
        Dim StationsTableAdapter1 As New DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter
        Return StationsTableAdapter1.GetStations()
    End Function

    Public Function GetUsers() As DataEntityTier.AqualocDataSet.UsersDataTable Implements IService1.GetUsers
        Dim UsersTableAdapter1 As New DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter
        Return UsersTableAdapter1.GetUsers()
    End Function

    Public Function GetMeterQCPoints() As DataEntityTier.AqualocDataSet.PartQcPointDataTable Implements IService1.GetMeterQCPoint
        Dim MeterQCPointTableAdapter1 As New DataAccessTier.AqualocDataSetTableAdapters.PartQcPointTableAdapter
        Return MeterQCPointTableAdapter1.GetPartQCPoints()
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
