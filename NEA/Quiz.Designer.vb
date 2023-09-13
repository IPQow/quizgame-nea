<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Quiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quiz))
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.btnskip = New System.Windows.Forms.Button()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.lblPlayername = New System.Windows.Forms.Label()
        Me.picskip = New System.Windows.Forms.PictureBox()
        Me.pica3 = New System.Windows.Forms.PictureBox()
        Me.pica4 = New System.Windows.Forms.PictureBox()
        Me.pica2 = New System.Windows.Forms.PictureBox()
        Me.pica1 = New System.Windows.Forms.PictureBox()
        Me.picquit = New System.Windows.Forms.PictureBox()
        Me.picstart = New System.Windows.Forms.PictureBox()
        Me.lbla1 = New System.Windows.Forms.Label()
        Me.lbla2 = New System.Windows.Forms.Label()
        Me.lbla3 = New System.Windows.Forms.Label()
        Me.lbla4 = New System.Windows.Forms.Label()
        Me.picanswerhighlight1 = New System.Windows.Forms.PictureBox()
        Me.picanswerhighlight2 = New System.Windows.Forms.PictureBox()
        Me.picanswerhighlight3 = New System.Windows.Forms.PictureBox()
        Me.picanswerhighlight4 = New System.Windows.Forms.PictureBox()
        Me.picanswerhighlightskip = New System.Windows.Forms.PictureBox()
        CType(Me.picskip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pica3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pica4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pica2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pica1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picstart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picanswerhighlight1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picanswerhighlight2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picanswerhighlight3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picanswerhighlight4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picanswerhighlightskip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblquestion
        '
        Me.lblquestion.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblquestion, "lblquestion")
        Me.lblquestion.ForeColor = System.Drawing.Color.White
        Me.lblquestion.Name = "lblquestion"
        '
        'btnskip
        '
        resources.ApplyResources(Me.btnskip, "btnskip")
        Me.btnskip.Name = "btnskip"
        Me.btnskip.Tag = "5"
        Me.btnskip.UseVisualStyleBackColor = True
        '
        'lblscore
        '
        Me.lblscore.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblscore, "lblscore")
        Me.lblscore.ForeColor = System.Drawing.Color.Gray
        Me.lblscore.Name = "lblscore"
        '
        'txtTest
        '
        Me.txtTest.Cursor = System.Windows.Forms.Cursors.Cross
        resources.ApplyResources(Me.txtTest, "txtTest")
        Me.txtTest.Name = "txtTest"
        '
        'txtstatus
        '
        resources.ApplyResources(Me.txtstatus, "txtstatus")
        Me.txtstatus.Name = "txtstatus"
        '
        'lblPlayername
        '
        Me.lblPlayername.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblPlayername, "lblPlayername")
        Me.lblPlayername.ForeColor = System.Drawing.Color.Gray
        Me.lblPlayername.Name = "lblPlayername"
        '
        'picskip
        '
        Me.picskip.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picskip, "picskip")
        Me.picskip.Name = "picskip"
        Me.picskip.TabStop = False
        '
        'pica3
        '
        Me.pica3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.pica3, "pica3")
        Me.pica3.Name = "pica3"
        Me.pica3.TabStop = False
        Me.pica3.Tag = "3"
        '
        'pica4
        '
        Me.pica4.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.pica4, "pica4")
        Me.pica4.Name = "pica4"
        Me.pica4.TabStop = False
        Me.pica4.Tag = "4"
        '
        'pica2
        '
        Me.pica2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.pica2, "pica2")
        Me.pica2.Name = "pica2"
        Me.pica2.TabStop = False
        Me.pica2.Tag = "2"
        '
        'pica1
        '
        Me.pica1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.pica1, "pica1")
        Me.pica1.Name = "pica1"
        Me.pica1.TabStop = False
        Me.pica1.Tag = "1"
        '
        'picquit
        '
        Me.picquit.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picquit, "picquit")
        Me.picquit.Name = "picquit"
        Me.picquit.TabStop = False
        '
        'picstart
        '
        resources.ApplyResources(Me.picstart, "picstart")
        Me.picstart.Name = "picstart"
        Me.picstart.TabStop = False
        '
        'lbla1
        '
        Me.lbla1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbla1, "lbla1")
        Me.lbla1.ForeColor = System.Drawing.Color.White
        Me.lbla1.Name = "lbla1"
        Me.lbla1.Tag = "1"
        '
        'lbla2
        '
        Me.lbla2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbla2, "lbla2")
        Me.lbla2.ForeColor = System.Drawing.Color.White
        Me.lbla2.Name = "lbla2"
        Me.lbla2.Tag = "2"
        '
        'lbla3
        '
        Me.lbla3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbla3, "lbla3")
        Me.lbla3.ForeColor = System.Drawing.Color.White
        Me.lbla3.Name = "lbla3"
        Me.lbla3.Tag = "3"
        '
        'lbla4
        '
        Me.lbla4.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbla4, "lbla4")
        Me.lbla4.ForeColor = System.Drawing.Color.White
        Me.lbla4.Name = "lbla4"
        Me.lbla4.Tag = "4"
        '
        'picanswerhighlight1
        '
        Me.picanswerhighlight1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picanswerhighlight1, "picanswerhighlight1")
        Me.picanswerhighlight1.Name = "picanswerhighlight1"
        Me.picanswerhighlight1.TabStop = False
        '
        'picanswerhighlight2
        '
        Me.picanswerhighlight2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picanswerhighlight2, "picanswerhighlight2")
        Me.picanswerhighlight2.Name = "picanswerhighlight2"
        Me.picanswerhighlight2.TabStop = False
        '
        'picanswerhighlight3
        '
        Me.picanswerhighlight3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picanswerhighlight3, "picanswerhighlight3")
        Me.picanswerhighlight3.Name = "picanswerhighlight3"
        Me.picanswerhighlight3.TabStop = False
        '
        'picanswerhighlight4
        '
        Me.picanswerhighlight4.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picanswerhighlight4, "picanswerhighlight4")
        Me.picanswerhighlight4.Name = "picanswerhighlight4"
        Me.picanswerhighlight4.TabStop = False
        '
        'picanswerhighlightskip
        '
        Me.picanswerhighlightskip.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picanswerhighlightskip, "picanswerhighlightskip")
        Me.picanswerhighlightskip.Name = "picanswerhighlightskip"
        Me.picanswerhighlightskip.TabStop = False
        '
        'Quiz
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.picanswerhighlightskip)
        Me.Controls.Add(Me.lbla3)
        Me.Controls.Add(Me.lbla4)
        Me.Controls.Add(Me.lbla2)
        Me.Controls.Add(Me.lbla1)
        Me.Controls.Add(Me.picquit)
        Me.Controls.Add(Me.pica1)
        Me.Controls.Add(Me.pica2)
        Me.Controls.Add(Me.pica4)
        Me.Controls.Add(Me.pica3)
        Me.Controls.Add(Me.picskip)
        Me.Controls.Add(Me.lblPlayername)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.btnskip)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.picanswerhighlight2)
        Me.Controls.Add(Me.picstart)
        Me.Controls.Add(Me.picanswerhighlight1)
        Me.Controls.Add(Me.picanswerhighlight4)
        Me.Controls.Add(Me.picanswerhighlight3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Quiz"
        CType(Me.picskip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pica3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pica4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pica2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pica1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picquit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picstart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picanswerhighlight1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picanswerhighlight2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picanswerhighlight3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picanswerhighlight4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picanswerhighlightskip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblquestion As Label
    Friend WithEvents btnskip As Button
    Friend WithEvents lblscore As Label
    Friend WithEvents txtTest As TextBox
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents lblPlayername As Label
    Friend WithEvents picskip As PictureBox
    Friend WithEvents pica3 As PictureBox
    Friend WithEvents pica4 As PictureBox
    Friend WithEvents pica2 As PictureBox
    Friend WithEvents pica1 As PictureBox
    Friend WithEvents picquit As PictureBox
    Friend WithEvents picstart As PictureBox
    Friend WithEvents lbla1 As Label
    Friend WithEvents lbla2 As Label
    Friend WithEvents lbla3 As Label
    Friend WithEvents lbla4 As Label
    Friend WithEvents picanswerhighlight1 As PictureBox
    Friend WithEvents picanswerhighlight2 As PictureBox
    Friend WithEvents picanswerhighlight3 As PictureBox
    Friend WithEvents picanswerhighlight4 As PictureBox
    Friend WithEvents picanswerhighlightskip As PictureBox
End Class
