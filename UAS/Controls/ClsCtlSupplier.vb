Imports System.Data.OleDb
Imports WindowsApp1

Public Class ClsCtlSupplier : Implements InfProses
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from Supplier where kode_supplier " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_supplier")
            Dim grid As New DataView(DTS.Tables("Cari_supplier"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_Supplier,4)) from Supplier", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "SP" & Strings.Right("0" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from supplier", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kasir")
            Dim grid As New DataView(DTS.Tables("Tabel_kasir"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntSupplier
        data = Ob

        CMD = New OleDbCommand("insert into supplier values('" & data.KodeSupplier & "','" & data.NamaSupplier & "','" _
                               & data.AlamatSupplier & "','" & data.TelpSupplier & "','" _
                               & data.EmailSupplier & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntSupplier
        data = Ob
        CMD = New OleDbCommand("update Supplier set kode_Supplier='" _
                               & data.KodeSupplier & "',nama_supplier='" & data.NamaSupplier _
                               & "',alamat='" & data.AlamatSupplier _
                               & "',telp='" & data.TelpSupplier _
                               & "',email='" & data.EmailSupplier _
                               & "' where kode_supplier='" & data.KodeSupplier & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from supplier " _
                                      & "where kode_supplier ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
End Class

