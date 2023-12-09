<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        txtUserName = New TextBox()
        txtPassword = New TextBox()
        lblUserName = New Label()
        lblPassword = New Label()
        btnOk = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(233, 126)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(175, 23)
        txtUserName.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(233, 166)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(175, 23)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(135, 129)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(65, 15)
        lblUserName.TabIndex = 1
        lblUserName.Text = "User Name"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(135, 169)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password"
        ' 
        ' btnOk
        ' 
        btnOk.Location = New Point(244, 209)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(75, 23)
        btnOk.TabIndex = 3
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(325, 209)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(527, 351)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        Controls.Add(lblPassword)
        Controls.Add(lblUserName)
        Controls.Add(txtPassword)
        Controls.Add(txtUserName)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
End Class
