Imports System.Data.OleDb
Imports WindowsApp1

Public Class ClsCtlKasir : Implements InfProses
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from Kasir where kode_kasir " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_kasir")
            Dim grid As New DataView(DTS.Tables("Cari_kasir"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_kasir,3)) from kasir", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "K-" & Strings.Right("00" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from Kasir", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kasir")
            Dim grid As New DataView(DTS.Tables("Tabel_kasir"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntKasir
        data = Ob

        CMD = New OleDbCommand("insert into kasir values('" & data.Kodekasir & "','" & data.Namakasir & "','" _
                               & data.Usernamekasir & "','" & data.Passwordkasir & "','" & data.Alamatkasir & "','" _
                               & data.Telpkasir & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntKasir
        data = Ob
        CMD = New OleDbCommand("update kasir set kode_kasir='" _
                               & data.Kodekasir & "',nama_kasir='" & data.Namakasir _
                               & "',username='" & data.Usernamekasir _
                               & "',password='" & data.Passwordkasir _
                               & "',alamat='" & data.Alamatkasir _
                               & "',telp='" & data.Telpkasir _
                               & "' where kode_kasir='" & data.Kodekasir & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from Kasir " _
                               & "where kode_kasir ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
End Class

