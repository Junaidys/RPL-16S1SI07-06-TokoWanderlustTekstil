Public Class ClsEntKain
    Private kode As String
    Private id As String
    Private nama As String
    Private harga As Integer
    Private stok As Integer
    Private hargajual As Integer
    Private warna As String

    Public Property KodeKain As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property

    Public Property IdDetail As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property NamaKain As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property HargaKain As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property

    Public Property StokKain As Integer
        Get
            Return stok
        End Get
        Set(value As Integer)
            stok = value
        End Set
    End Property

    Public Property HargajualKain As Integer
        Get
            Return hargajual
        End Get
        Set(value As Integer)
            hargajual = value
        End Set
    End Property

    Public Property Warnakain1 As String
        Get
            Return warna
        End Get
        Set(value As String)
            warna = value
        End Set
    End Property
End Class
