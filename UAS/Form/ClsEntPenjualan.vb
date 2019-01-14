Public Class ClsEntPenjualan
    Private idjual As String
    Private idop As String
    Private idkasir As String
    Private tgl As Date
    Private tot As Integer

    Public Property id_jual() As String
        Get
            Return idjual
        End Get
        Set(value As String)
            idjual = value
        End Set
    End Property

    Public Property id_operator() As String
        Get
            Return idop
        End Get
        Set(value As String)
            idop = value
        End Set
    End Property

    Public Property id_kasir() As String
        Get
            Return idkasir
        End Get
        Set(value As String)
            idkasir = value
        End Set
    End Property
    Public Property tanggal() As Date
        Get
            Return tgl
        End Get
        Set(value As Date)
            tgl = value
        End Set
    End Property

    Public Property total() As Integer
        Get
            Return tot
        End Get
        Set(value As Integer)
            tot = value
        End Set
    End Property
End Class
