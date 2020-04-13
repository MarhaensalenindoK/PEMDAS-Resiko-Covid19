Imports System.Data
Imports System.Data.OleDb
Module dbhealter
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasidata As String

    Public Sub connection()
        lokasidata = "provider=microsoft.ace.oledb.12.0;data source=batabase1.mdb"
        conn = New OleDbConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()


        End If



    End Sub



End Module
