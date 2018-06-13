Public Class Counter
    Private mValue As Integer
    Public Event countChanged(ByVal mvalue As Integer)
    Public Property count() As Integer
        Get
            count = mValue
        End Get
        Set(ByVal value As Integer)
            mValue = value
            RaiseEvent countChanged(mValue)
        End Set
    End Property
End Class