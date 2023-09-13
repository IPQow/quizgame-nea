<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RevisionTips
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RevisionTips))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picmainmenu = New System.Windows.Forms.PictureBox()
        Me.picquit = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        CType(Me.picmainmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(491, 702)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.Visible = False
        '
        'picmainmenu
        '
        Me.picmainmenu.BackColor = System.Drawing.Color.Transparent
        Me.picmainmenu.Location = New System.Drawing.Point(937, 46)
        Me.picmainmenu.Name = "picmainmenu"
        Me.picmainmenu.Size = New System.Drawing.Size(398, 100)
        Me.picmainmenu.TabIndex = 11
        Me.picmainmenu.TabStop = False
        '
        'picquit
        '
        Me.picquit.BackColor = System.Drawing.Color.Transparent
        Me.picquit.Location = New System.Drawing.Point(1345, 46)
        Me.picquit.Name = "picquit"
        Me.picquit.Size = New System.Drawing.Size(200, 100)
        Me.picquit.TabIndex = 12
        Me.picquit.TabStop = False
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.Transparent
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(707, 46)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(220, 100)
        Me.picBack.TabIndex = 13
        Me.picBack.TabStop = False
        Me.picBack.Visible = False
        '
        'RevisionTips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.picquit)
        Me.Controls.Add(Me.picmainmenu)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RevisionTips"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RevisionTips"
        CType(Me.picmainmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents picmainmenu As PictureBox
    Friend WithEvents picquit As PictureBox
    Friend WithEvents picBack As PictureBox
End Class
