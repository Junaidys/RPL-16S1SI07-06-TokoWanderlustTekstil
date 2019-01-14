Imports System.Data.OleDb
Imports WindowsApp1

Public Class ClsCtlKain : Implements InfProses
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from Kain where kode_kain " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_kain")
            Dim grid As New DataView(DTS.Tables("Cari_kain"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from Kain", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kain")
            Dim grid As New DataView(DTS.Tables("Tabel_kain"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntKain
        data = Ob

        CMD = New OleDbCommand("insert into kain values('" & data.KodeKain & "','" & data.IdDetail & "','" _
                               & data.NamaKain & "','" & data.HargaKain & "','" & data.StokKain & "','" _
                               & data.Warnakain1 & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntKain
        data = Ob
        CMD = New OleDbCommand("update kain set kode_kain='" _
                               & data.KodeKain & "',id_detail='" & data.IdDetail _
                               & "',nama_kain='" & data.NamaKain _
                               & "',harga='" & data.HargaKain _
                               & "',stok='" & data.StokKain _
                               & "',warna='" & data.Warnakain1 _
                               & "' where kode_kain='" & data.KodeKain & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function
End Class

