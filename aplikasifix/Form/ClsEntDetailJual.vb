Public Class ClsEntDetailJual
    Private idjual As String
    Private idmenu As String
    Private jum As Integer
    Private harga As Integer
    Private subtot As Integer

    Public Property id_jual() As String
        Get
            Return idjual
        End Get
        Set(value As String)
            idjual = value
        End Set
    End Property
    Public Property id_menu() As String
        Get
            Return idmenu
        End Get
        Set(value As String)
            idmenu = value
        End Set
    End Property

    Public Property harga_jual() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property

    Public Property qty() As Integer
        Get
            Return jum
        End Get
        Set(value As Integer)
            jum = value
        End Set
    End Property

    Public Property sub_total() As Integer
        Get
            Return subtot
        End Get
        Set(value As Integer)
            subtot = value
        End Set
    End Property
End Class
