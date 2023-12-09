Imports System.Data.SqlClient
Module General
    Public gSqlCon As SqlConnection
    Public gSqlConStr As String
    Public gUserId As Integer = 0


    Public Function LoadConnections() As Boolean
        LoadConnections = False
        Dim sServer As String, sDB As String, sUserId As String, sPassword As String
        sServer = "DESKTOP-04D19O1\SQLEXPRESS"
        sDB = "Task"
        sUserId = "Sa"
        sPassword = "123"
        gsqlConStr = "Data Source=" & sServer & ";Initial Catalog=" &
            sDB & ";Integrated Security=False;MultipleActiveResultSets=True;User Id='" &
            sUserId & "';Password='" & sPassword & "';Connection Timeout=60"
        Try
            gSqlCon = New SqlConnection(gSqlConStr)
            gSqlCon.Open()
            LoadConnections = True
        Catch ex As Exception
            LoadConnections = False
        End Try
    End Function

End Module