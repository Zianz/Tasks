Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices


Public Class frmWorkLog
    Private SW As New Stopwatch
    Dim nTaskId As Integer
    Dim sTaskName As String
    Public Sub New(ByVal pTaskId As Integer, ByVal pTaskName As String)

        nTaskId = pTaskId
        sTaskName = pTaskName


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        SW.Start()
        tmrCount.Start()
        btnStart.Enabled = False
        btnStop.Enabled = True
        btnPause.Enabled = True
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        SW.Stop()
        tmrCount.Stop()
        btnStart.Enabled = True
        btnStop.Enabled = True
        btnPause.Enabled = False
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        SW.Stop()
        tmrCount.Stop()
        WriteLog()
        SW.Reset()
        lblTimer.Text = SW.Elapsed.Days.ToString & ":" & SW.Elapsed.Hours & ":" & SW.Elapsed.Minutes
        Me.Close()
        btnStart.Enabled = True
        btnStop.Enabled = False
        btnPause.Enabled = False

    End Sub
    Private Sub WriteLog()
        Using sqlCmd As New SqlCommand
            With sqlCmd
                .Connection = gSqlCon
                .CommandText = "SP_WRITE_LOG"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@TaskName", sTaskName)
                .Parameters.AddWithValue("@TaskId", nTaskId)
                .Parameters.AddWithValue("@UserId", gUserId)
                .Parameters.AddWithValue("@Days", SW.Elapsed.Days)
                .Parameters.AddWithValue("@Hours", SW.Elapsed.Hours)
                .Parameters.AddWithValue("@Minutes", SW.Elapsed.Minutes)
                .ExecuteNonQuery()
            End With
        End Using
    End Sub
    Private Sub tmrCount_Tick(sender As Object, e As EventArgs) Handles tmrCount.Tick
        lblTimer.Text = SW.Elapsed.Days.ToString & ":" & SW.Elapsed.Hours & ":" & SW.Elapsed.Minutes
        nfyWorklog.Text = SW.Elapsed.Days.ToString & ":" & SW.Elapsed.Hours & ":" & SW.Elapsed.Minutes
        lblTimer.Refresh()

    End Sub

    Private Sub frmWorkLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTaskName.Text = sTaskName
    End Sub

    Private Sub frmWorkLog_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = WindowState.Minimized Then
            nfyWorklog.Visible = True
            ChangeVisiblity(False)
            Me.BringToFront()
            Me.Refresh()
        End If
    End Sub
    Public Sub ChangeVisiblity(ByVal pVisible As Boolean)
        Dim frm As Form
        Dim openForms As System.Windows.Forms.FormCollection = Application.OpenForms
        For Each frm In openForms
            If frm.Name <> frmLogin.Name Then
                frm.Visible = pVisible
            End If
        Next
        ' frmTaskDescriptions.Visible = pVisible
        ''Me.Visible = pVisible
    End Sub
    Private Sub nfyWorklog_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nfyWorklog.MouseDoubleClick
        nfyWorklog.Visible = False
        ChangeVisiblity(True)
    End Sub

    Private Sub frmWorkLog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmTaskDescriptions.Show()

    End Sub
End Class