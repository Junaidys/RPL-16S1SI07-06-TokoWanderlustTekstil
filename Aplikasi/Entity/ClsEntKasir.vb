Public Class ClsEntKasir
    Private id As String
    Private nama As String
    Private password As String
    Private no_telp As String
    Private alamat As String

    Public Property Idkasir As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property Namakasir As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property Passwordkasir As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property No_telplkasir As String
        Get
            Return no_telp
        End Get
        Set(value As String)
            no_telp = value
        End Set
    End Property

    Public Property Alamatkasir As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property
End Class