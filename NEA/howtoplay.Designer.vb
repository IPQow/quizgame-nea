<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class howtoplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(howtoplay))
        Me.picmainmenu = New System.Windows.Forms.PictureBox()
        Me.picquit = New System.Windows.Forms.PictureBox()
        CType(Me.picmainmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picmainmenu
        '
        Me.picmainmenu.BackColor = System.Drawing.Color.Transparent
        Me.picmainmenu.Location = New System.Drawing.Point(982, 790)
        Me.picmainmenu.Name = "picmainmenu"
        Me.picmainmenu.Size = New System.Drawing.Size(398, 100)
        Me.picmainmenu.TabIndex = 10
        Me.picmainmenu.TabStop = False
        '
        'picquit
        '
        Me.picquit.BackColor = System.Drawing.Color.Transparent
        Me.picquit.Location = New System.Drawing.Point(1390, 790)
        Me.picquit.Name = "picquit"
        Me.picquit.Size = New System.Drawing.Size(200, 100)
        Me.picquit.TabIndex = 11
        Me.picquit.TabStop = False
        '
        'howtoplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.picquit)
        Me.Controls.Add(Me.picmainmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "howtoplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "howtoplay"
        CType(Me.picmainmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picmainmenu As PictureBox
    Friend WithEvents picquit As PictureBox
End Class
