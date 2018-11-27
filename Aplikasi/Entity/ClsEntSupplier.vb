Public Class ClsEntSupplier
    Private Kode As String
    Private Nama As String
    Private Alamat As String
    Private Telp As String
    Private Email As String

    Public Property KodeSupplier As String
        Get
            Return Kode
        End Get
        Set(value As String)
            Kode = value
        End Set
    End Property

    Public Property NamaSupplier As String
        Get
            Return Nama
        End Get
        Set(value As String)
            Nama = value
        End Set
    End Property

    Public Property AlamatSupplier As String
        Get
            Return Alamat
        End Get
        Set(value As String)
            Alamat = value
        End Set
    End Property

    Public Property TelpSupplier As String
        Get
            Return Telp
        End Get
        Set(value As String)
            Telp = value
        End Set
    End Property

    Public Property EmailSupplier As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property
End Class
