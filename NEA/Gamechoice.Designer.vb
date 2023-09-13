<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gamechoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gamechoice))
        Me.cbCat = New System.Windows.Forms.ComboBox()
        Me.cbDiff = New System.Windows.Forms.ComboBox()
        Me.cbNOQ = New System.Windows.Forms.ComboBox()
        Me.picquit = New System.Windows.Forms.PictureBox()
        Me.piccontinue = New System.Windows.Forms.PictureBox()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccontinue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCat
        '
        Me.cbCat.BackColor = System.Drawing.SystemColors.Window
        Me.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCat.Font = New System.Drawing.Font("Poppins SemiBold", 26.0!, System.Drawing.FontStyle.Bold)
        Me.cbCat.FormattingEnabled = True
        Me.cbCat.Items.AddRange(New Object() {"Computer Science", "History", "Geography", "Politics"})
        Me.cbCat.Location = New System.Drawing.Point(585, 289)
        Me.cbCat.Name = "cbCat"
        Me.cbCat.Size = New System.Drawing.Size(430, 70)
        Me.cbCat.TabIndex = 0
        '
        'cbDiff
        '
        Me.cbDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDiff.Font = New System.Drawing.Font("Poppins SemiBold", 26.0!, System.Drawing.FontStyle.Bold)
        Me.cbDiff.FormattingEnabled = True
        Me.cbDiff.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.cbDiff.Location = New System.Drawing.Point(585, 415)
        Me.cbDiff.Name = "cbDiff"
        Me.cbDiff.Size = New System.Drawing.Size(430, 70)
        Me.cbDiff.TabIndex = 4
        '
        'cbNOQ
        '
        Me.cbNOQ.BackColor = System.Drawing.Color.White
        Me.cbNOQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNOQ.Font = New System.Drawing.Font("Poppins SemiBold", 26.0!, System.Drawing.FontStyle.Bold)
        Me.cbNOQ.FormattingEnabled = True
        Me.cbNOQ.Items.AddRange(New Object() {"5", "10", "15", "20"})
        Me.cbNOQ.Location = New System.Drawing.Point(585, 541)
        Me.cbNOQ.Name = "cbNOQ"
        Me.cbNOQ.Size = New System.Drawing.Size(430, 70)
        Me.cbNOQ.TabIndex = 5
        '
        'picquit
        '
        Me.picquit.BackColor = System.Drawing.Color.Transparent
        Me.picquit.Location = New System.Drawing.Point(1390, 790)
        Me.picquit.Name = "picquit"
        Me.picquit.Size = New System.Drawing.Size(200, 100)
        Me.picquit.TabIndex = 12
        Me.picquit.TabStop = False
        '
        'piccontinue
        '
        Me.piccontinue.BackColor = System.Drawing.Color.Transparent
        Me.piccontinue.Location = New System.Drawing.Point(570, 694)
        Me.piccontinue.Name = "piccontinue"
        Me.piccontinue.Size = New System.Drawing.Size(460, 70)
        Me.piccontinue.TabIndex = 13
        Me.piccontinue.TabStop = False
        '
        'Gamechoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.piccontinue)
        Me.Controls.Add(Me.picquit)
        Me.Controls.Add(Me.cbNOQ)
        Me.Controls.Add(Me.cbDiff)
        Me.Controls.Add(Me.cbCat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gamechoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SelectForm"
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccontinue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbCat As ComboBox
    Friend WithEvents cbDiff As ComboBox
    Friend WithEvents cbNOQ As ComboBox
    Friend WithEvents picquit As PictureBox
    Friend WithEvents piccontinue As PictureBox
End Class
