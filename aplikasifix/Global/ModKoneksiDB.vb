﻿
Imports System.Data.OleDb
    Imports System.Data.SqlClient
    Module ModKoneksiDB
        Public DTR As OleDbDataReader
        Public CMD As New OleDbCommand
        Public DTA As New OleDbDataAdapter
        Public DTS As New DataSet
        Public DTT As New DataTable
        Public DTGrid As New DataTable
    Public strKon = "Provider=SQLNCLI11;Data Source=HIGHFIVE\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Penjualan"
    Public koneksi As New OleDbConnection(strKon)

        Public Function BUKAKONEKSI() As OleDbConnection
            Try
                If koneksi.State = ConnectionState.Closed Then koneksi.Open()
            Catch ex As Exception

            End Try
            Return koneksi
        End Function

        Public Function TUTUPKONEKSI() As OleDbConnection
            koneksi.Close()
            Return koneksi
        End Function
    End Module


