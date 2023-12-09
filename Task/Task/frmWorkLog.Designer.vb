<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkLog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkLog))
        lblTaskName = New Label()
        btnStart = New Button()
        btnPause = New Button()
        btnStop = New Button()
        lblTimer = New Label()
        tmrCount = New Timer(components)
        nfyWorklog = New NotifyIcon(components)
        SuspendLayout()
        ' 
        ' lblTaskName
        ' 
        lblTaskName.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTaskName.Location = New Point(24, 24)
        lblTaskName.Name = "lblTaskName"
        lblTaskName.Size = New Size(374, 37)
        lblTaskName.TabIndex = 0
        lblTaskName.Text = "Task Name"
        lblTaskName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(85, 85)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(75, 38)
        btnStart.TabIndex = 1
        btnStart.Text = "START"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnPause
        ' 
        btnPause.Location = New Point(261, 85)
        btnPause.Name = "btnPause"
        btnPause.Size = New Size(75, 38)
        btnPause.TabIndex = 1
        btnPause.Text = "PAUSE"
        btnPause.UseVisualStyleBackColor = True
        ' 
        ' btnStop
        ' 
        btnStop.Location = New Point(171, 138)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(75, 39)
        btnStop.TabIndex = 1
        btnStop.Text = "STOP"
        btnStop.UseVisualStyleBackColor = True
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimer.Location = New Point(182, 89)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(55, 25)
        lblTimer.TabIndex = 2
        lblTimer.Text = "0:0:0"
        ' 
        ' tmrCount
        ' 
        ' 
        ' nfyWorklog
        ' 
        nfyWorklog.Icon = CType(resources.GetObject("nfyWorklog.Icon"), Icon)
        nfyWorklog.Text = "NotifyIcon"
        ' 
        ' frmWorkLog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(428, 220)
        Controls.Add(lblTimer)
        Controls.Add(btnStop)
        Controls.Add(btnPause)
        Controls.Add(btnStart)
        Controls.Add(lblTaskName)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmWorkLog"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Work Log"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTaskName As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents tmrCount As Timer
    Private WithEvents nfyWorklog As NotifyIcon
End Class
