Public Class ClsEntAdmin
    Private kodeadmin As String
    Private pass As String
    Private username As String
    Private nama As String

    Public Property Kode_admin As String
        Get
            Return kodeadmin
        End Get
        Set(value As String)
            kodeadmin = value
        End Set
    End Property

    Public Property Nama_admin As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property User_name As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property
End Class
