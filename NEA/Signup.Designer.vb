<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        Me.picregister = New System.Windows.Forms.PictureBox()
        Me.piclogin = New System.Windows.Forms.PictureBox()
        Me.picmainmenu = New System.Windows.Forms.PictureBox()
        Me.picquit = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnTestmultipleregister = New System.Windows.Forms.Button()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.txttest = New System.Windows.Forms.TextBox()
        CType(Me.picregister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picmainmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picregister
        '
        Me.picregister.BackColor = System.Drawing.Color.Transparent
        Me.picregister.Location = New System.Drawing.Point(570, 514)
        Me.picregister.Name = "picregister"
        Me.picregister.Size = New System.Drawing.Size(460, 70)
        Me.picregister.TabIndex = 11
        Me.picregister.TabStop = False
        '
        'piclogin
        '
        Me.piclogin.BackColor = System.Drawing.Color.Transparent
        Me.piclogin.Location = New System.Drawing.Point(570, 652)
        Me.piclogin.Name = "piclogin"
        Me.piclogin.Size = New System.Drawing.Size(460, 60)
        Me.piclogin.TabIndex = 12
        Me.piclogin.TabStop = False
        '
        'picmainmenu
        '
        Me.picmainmenu.BackColor = System.Drawing.Color.Transparent
        Me.picmainmenu.Location = New System.Drawing.Point(982, 790)
        Me.picmainmenu.Name = "picmainmenu"
        Me.picmainmenu.Size = New System.Drawing.Size(398, 100)
        Me.picmainmenu.TabIndex = 13
        Me.picmainmenu.TabStop = False
        '
        'picquit
        '
        Me.picquit.BackColor = System.Drawing.Color.Transparent
        Me.picquit.Location = New System.Drawing.Point(1390, 790)
        Me.picquit.Name = "picquit"
        Me.picquit.Size = New System.Drawing.Size(200, 100)
        Me.picquit.TabIndex = 14
        Me.picquit.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Poppins SemiBold", 28.0!, System.Drawing.FontStyle.Bold)
        Me.txtUsername.Location = New System.Drawing.Point(582, 302)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(436, 56)
        Me.txtUsername.TabIndex = 15
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Poppins SemiBold", 28.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.Location = New System.Drawing.Point(582, 408)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(436, 56)
        Me.txtPassword.TabIndex = 16
        '
        'btnTestmultipleregister
        '
        Me.btnTestmultipleregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnTestmultipleregister.Location = New System.Drawing.Point(304, 514)
        Me.btnTestmultipleregister.Name = "btnTestmultipleregister"
        Me.btnTestmultipleregister.Size = New System.Drawing.Size(238, 198)
        Me.btnTestmultipleregister.TabIndex = 17
        Me.btnTestmultipleregister.Text = "test - adding multipler users to database without progressing the program"
        Me.btnTestmultipleregister.UseVisualStyleBackColor = True
        Me.btnTestmultipleregister.Visible = False
        '
        'btnFill
        '
        Me.btnFill.Location = New System.Drawing.Point(304, 176)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(238, 332)
        Me.btnFill.TabIndex = 18
        Me.btnFill.Text = "fill"
        Me.btnFill.UseVisualStyleBackColor = True
        Me.btnFill.Visible = False
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(61, 77)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(100, 20)
        Me.txtstatus.TabIndex = 19
        Me.txtstatus.Visible = False
        '
        'txttest
        '
        Me.txttest.Location = New System.Drawing.Point(61, 103)
        Me.txttest.Name = "txttest"
        Me.txttest.Size = New System.Drawing.Size(100, 20)
        Me.txttest.TabIndex = 20
        Me.txttest.Visible = False
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.txttest)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.btnFill)
        Me.Controls.Add(Me.btnTestmultipleregister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.picquit)
        Me.Controls.Add(Me.picmainmenu)
        Me.Controls.Add(Me.piclogin)
        Me.Controls.Add(Me.picregister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Signup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signup"
        CType(Me.picregister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picmainmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picregister As PictureBox
    Friend WithEvents piclogin As PictureBox
    Friend WithEvents picmainmenu As PictureBox
    Friend WithEvents picquit As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnTestmultipleregister As Button
    Friend WithEvents btnFill As Button
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents txttest As TextBox
End Class
