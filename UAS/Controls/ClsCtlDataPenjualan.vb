Imports System.Data.OleDb
Imports WindowsApp1


Public Class ClsCtlDataPenjualan : Implements InfProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("SELECT P.tanggal, D.kode_nota, K.nama_kain, D.jumlah, D.harga, D.sub_total

FROM penjualan1 P Right join detail_jual D
On P.kode_nota = D.kode_nota
join Kain k
on D.kode_kain = K.KODE_KAIN", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Penjualan")
            Dim grid As New DataView(DTS.Tables("Tabel_Penjualan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
