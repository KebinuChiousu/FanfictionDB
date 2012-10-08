﻿Imports System.Configuration

Public Class SQLite
    Inherits DAL

    Public Overrides _
    Function GetCategories() As System.Data.DataTable

    End Function

    Public Overrides _
    Function GetData(Category_ID As Integer, Optional ALL As Boolean = False) As System.Data.DataTable

    End Function

    Public Overrides _
    Function UpdateData(dt As System.Data.DataTable) As Integer

    End Function

    Protected Overrides _
    Function GetConnectionString(ConnStr As String) As String

        Dim Conn() As String
        Dim path As String = ""
        Dim index As Integer

        Try
            Conn = Split(ConnStr, ";")

            For index = 0 To UBound(Conn)
                If InStr(Conn(index), "Data Source") Then
                    Conn = Split(Conn(index), "=")
                    path = Conn(1)
                    path = Replace(path, """", "")
                    Exit For
                End If
            Next

        Catch
            path = ""
        End Try

        Return path

    End Function

    Protected Overrides _
    Function SetConnectionString( _
                                  csName As String, _
                                  Path As String _
                                ) As ConnectionStringSettings

        Dim connstr As String = ""

        connstr = "Data Source="
        connstr += """" & Path & """"
        connstr += ";"
        connstr += "Version=3"
        connstr += ";"
        connstr += "New=False"
        connstr += ";"
        connstr += "Compress=True"
        connstr += ";"

        ' Create a connection string element and
        ' save it to the configuration file.
        ' Create a connection string element.
        Dim csSettings As New  _
        ConnectionStringSettings( _
                                  csName, _
                                  connstr, _
                                  "System.Data.SQLite" _
                                )

        Return csSettings

    End Function

End Class
