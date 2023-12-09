<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskDescriptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaskDescriptions))
        dgvList = New DataGridView()
        btnStart = New Button()
        txtTask = New TextBox()
        txtTaskId = New TextBox()
        btnClose = New Button()
        CType(dgvList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvList
        ' 
        dgvList.AllowUserToAddRows = False
        dgvList.AllowUserToDeleteRows = False
        dgvList.AllowUserToResizeColumns = False
        dgvList.AllowUserToResizeRows = False
        dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvList.Location = New Point(10, 85)
        dgvList.Name = "dgvList"
        dgvList.RowHeadersVisible = False
        dgvList.Size = New Size(626, 170)
        dgvList.TabIndex = 0
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(319, 45)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(75, 23)
        btnStart.TabIndex = 2
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' txtTask
        ' 
        txtTask.Location = New Point(12, 45)
        txtTask.Name = "txtTask"
        txtTask.Size = New Size(301, 23)
        txtTask.TabIndex = 3
        ' 
        ' txtTaskId
        ' 
        txtTaskId.Location = New Point(279, 46)
        txtTaskId.Name = "txtTaskId"
        txtTaskId.Size = New Size(34, 23)
        txtTaskId.TabIndex = 3
        txtTaskId.Visible = False
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(561, 261)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmTaskDescriptions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(646, 291)
        Controls.Add(txtTaskId)
        Controls.Add(txtTask)
        Controls.Add(btnClose)
        Controls.Add(btnStart)
        Controls.Add(dgvList)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmTaskDescriptions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Task Descriptions"
        CType(dgvList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvList As DataGridView
    Friend WithEvents btnStart As Button
    Friend WithEvents txtTask As TextBox
    Friend WithEvents txtTaskId As TextBox
    Friend WithEvents btnClose As Button
End Class
