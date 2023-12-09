Imports System.Data.SqlClient

Public Class frmTaskDescriptions
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Val(txtTaskId.Text & "") > 0 Then
            Dim frm As New frmWorkLog(Val(txtTaskId.Text & ""), txtTask.Text)
            frm.Show()
            Me.Close()
        End If
    End Sub
    Public Sub Loaddata()
        Dim sSQL As String = String.Empty
        Dim da As SqlDataAdapter
        Dim dt As New DataTable

        sSQL = "SELECT * FROM FUN_TASK_DATA(" & gUserId.ToString & ")"
        dt.Rows.Clear()
        da = New SqlDataAdapter(sSQL, gSqlCon)
        da.Fill(dt)
        With dgvList
            .Columns.Clear()
            .DataSource = dt
            .DefaultCellStyle.Font = New Font("tahoma", 9)
            .ColumnHeadersDefaultCellStyle.Font = New Font("tahoma", 10, FontStyle.Bold)
            .Columns("TASK_DESCRIPTION").HeaderText = "Task Description"
            .Columns("TASK_DESCRIPTION").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("TOTAL_TIME").Width = 80
            .Columns("TOTAL_TIME").HeaderText = "Total Time"
            .Columns("USER_ID").Visible = False
            .Columns("TASK_ID").Visible = False
        End With

    End Sub

    Private Sub frmTaskDescriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddata()
        Try
            txtTaskId.Text = Val(dgvList.Rows(0).Cells("TASK_ID").Value & "")
            txtTask.Text = dgvList.Rows(0).Cells("TASK_DESCRIPTION").Value
        Catch ex As Exception

        End Try

    End Sub
    Private Sub SelectData()
        Try
            If Val(dgvList.CurrentRow.Cells("TASK_ID").Value & "") <> 0 Then
                txtTaskId.Text = Val(dgvList.CurrentRow.Cells("TASK_ID").Value & "")
                txtTask.Text = dgvList.CurrentRow.Cells("TASK_DESCRIPTION").Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellClick
        SelectData()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class