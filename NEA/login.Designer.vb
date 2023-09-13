<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.picregister = New System.Windows.Forms.PictureBox()
        Me.picquit = New System.Windows.Forms.PictureBox()
        Me.picmainmenu = New System.Windows.Forms.PictureBox()
        Me.piclogin = New System.Windows.Forms.PictureBox()
        CType(Me.picregister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picmainmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(1036, 547)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(146, 70)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        Me.btnRegister.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogin.Location = New System.Drawing.Point(1036, 623)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(146, 68)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.btnLogin.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(755, 481)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 27)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Poppins SemiBold", 28.0!, System.Drawing.FontStyle.Bold)
        Me.txtUsername.Location = New System.Drawing.Point(582, 302)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(436, 56)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Poppins SemiBold", 28.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.Location = New System.Drawing.Point(582, 408)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(436, 56)
        Me.txtPassword.TabIndex = 5
        '
        'picregister
        '
        Me.picregister.BackColor = System.Drawing.Color.Transparent
        Me.picregister.Location = New System.Drawing.Point(570, 652)
        Me.picregister.Name = "picregister"
        Me.picregister.Size = New System.Drawing.Size(460, 60)
        Me.picregister.TabIndex = 6
        Me.picregister.TabStop = False
        '
        'picquit
        '
        Me.picquit.BackColor = System.Drawing.Color.Transparent
        Me.picquit.Location = New System.Drawing.Point(1390, 790)
        Me.picquit.Name = "picquit"
        Me.picquit.Size = New System.Drawing.Size(200, 100)
        Me.picquit.TabIndex = 8
        Me.picquit.TabStop = False
        '
        'picmainmenu
        '
        Me.picmainmenu.BackColor = System.Drawing.Color.Transparent
        Me.picmainmenu.Location = New System.Drawing.Point(982, 790)
        Me.picmainmenu.Name = "picmainmenu"
        Me.picmainmenu.Size = New System.Drawing.Size(398, 100)
        Me.picmainmenu.TabIndex = 9
        Me.picmainmenu.TabStop = False
        '
        'piclogin
        '
        Me.piclogin.BackColor = System.Drawing.Color.Transparent
        Me.piclogin.Location = New System.Drawing.Point(570, 514)
        Me.piclogin.Name = "piclogin"
        Me.piclogin.Size = New System.Drawing.Size(460, 70)
        Me.piclogin.TabIndex = 10
        Me.piclogin.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.piclogin)
        Me.Controls.Add(Me.picmainmenu)
        Me.Controls.Add(Me.picquit)
        Me.Controls.Add(Me.picregister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.picregister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picmainmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents picregister As PictureBox
    Friend WithEvents picquit As PictureBox
    Friend WithEvents picmainmenu As PictureBox
    Friend WithEvents piclogin As PictureBox
End Class
