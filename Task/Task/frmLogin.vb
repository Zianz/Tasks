Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        AuthenticateLogin()
        If gUserId > 0 Then
            Dim frmNew As New frmTaskDescriptions()
            Me.Hide()
            frmNew.ShowDialog()
        Else
            MsgBox("Invalid User name or Password ", 1, "Task")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConnections()
        txtUserName.Select()
    End Sub
    Private Sub AuthenticateLogin()
        Dim sSQL As String = String.Empty
        Dim cmd As SqlCommand
        Try
            sSQL = "SELECT DBO.GetUserAuthResults(@UserName,@password)"
            cmd = New SqlCommand(sSQL, gSqlCon)
            cmd.Parameters.AddWithValue("@UserName", Trim(txtUserName.Text))
            cmd.Parameters.AddWithValue("@password", Trim(txtPassword.Text))
            gUserId = Val(cmd.ExecuteScalar() & "")
        Catch ex As Exception

        End Try

        cmd.Dispose()
    End Sub

    Private Sub txtUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub
End Class