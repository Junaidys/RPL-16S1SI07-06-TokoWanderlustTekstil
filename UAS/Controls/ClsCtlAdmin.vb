
Imports System.Data.OleDb
Imports WindowsApp1
Public Class ClsCtlAdmin : Implements InfProses
    Public Function LoginOperator(username As String) As DataView
        Try
            DTA = New OleDbDataAdapter("Select * from Operator where username = '" & username & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Operator")
            Dim grid As New DataView(DTS.Tables("Cari_Operator"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_op,4)) from Operator", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "OP-" & Strings.Right("0" & kodeakhir + 1, 5)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from operator where nama " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_kain")
            Dim grid As New DataView(DTS.Tables("Cari_kain"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from operator " _
                              & "where kode_op ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntAdmin
        data = Ob

        CMD = New OleDbCommand("insert into operator values('" & data.Kodeop & "','" & data.Namaop & "','" _
                               & data.Usernameop & "','" & data.Passwordop & "','" _
                               & data.Statusop & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from operator", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kain")
            Dim grid As New DataView(DTS.Tables("Tabel_kain"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntAdmin
        data = Ob
        CMD = New OleDbCommand("update operator set kode_op='" _
                               & data.Kodeop & "',nama='" & data.Namaop _
                               & "',username='" & data.Usernameop _
                               & "',pass='" & data.Passwordop _
                               & "',stts='" & data.Statusop _
                               & "' where kode_op='" & data.Kodeop & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
End Class
