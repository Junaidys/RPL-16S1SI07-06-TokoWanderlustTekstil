Imports System.Data.OleDb
Public Class ClsCtlPenjualan
    Dim SQL As String

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_nota,3)) from penjualan1", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "N-" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntPenjualan1, ByVal _item As List(Of ClsEntDetailJual)) As String
        Dim IDJ As String
        IDJ = ""
        TUTUPKONEKSI()

        With _pbl
            SQL = "SPinsertPenjualan'" & .KodeOPerator & "','" & Format(.Tanggaljual, "yyyy/MM/dd") & "'," & .Qtyj
            'MsgBox(SQL)
            Try
                DTA = New OleDbDataAdapter(SQL, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_ID_JUAL")
                IDJ = DTS.Tables("TABEL_ID_JUAL").Rows(0)(0).ToString
                ' MsgBox(IDP)'
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End With
        TUTUPKONEKSI()
        For i = 0 To _item.Count - 1
            With _item(i)
                SQL = "insert into Detail_Jual values ('" _
                    & IDJ & "','" & .Kodekain _
                    & "'," & .Jumlah & "," & .Hargaj & "," & .Subtotal & ")"

                CMD = New OleDbCommand(SQL, BUKAKONEKSI)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OleDbCommand("", TUTUPKONEKSI)
                'MsgBox(SQL)
            End With
        Next
        Return IDJ
    End Function
End Class
