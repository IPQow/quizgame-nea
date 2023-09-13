Imports System.Threading
Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim loggedin As Boolean
    Dim logincheck As Integer
    Dim databasecon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\loginsystem.mdb")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loggedin = False
        logincheck = 0
        picstart.Visible = False
        picstartgrey.Visible = True
        pichowtoplay.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (isloggedin > 0) Then
            loggedin = True
        ElseIf (isloggedin < 0) Then
            loggedin = False
        End If
        If loggedin = False Then
            MsgBox("You need to log in before you can continue")
        ElseIf loggedin = True Then
            Gamechoice.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Gamechoice.Show()
        Me.Hide()
    End Sub

    Private Sub picLoginReminder_Click(sender As Object, e As EventArgs) Handles picLoginReminder.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub picstart_Click(sender As Object, e As EventArgs) Handles picstart.Click
        Gamechoice.Show()
        Me.Hide()
    End Sub

    Private Sub picstartgrey_Click(sender As Object, e As EventArgs) Handles picstartgrey.Click
        MsgBox("You need to login first")
    End Sub

    Private Sub picquit_Click(sender As Object, e As EventArgs) Handles picquit.Click
        Me.Close()
    End Sub

    Private Sub pichowtoplay_Click(sender As Object, e As EventArgs) Handles pichowtoplay.Click
        howtoplay.Show()
    End Sub

    Private Sub picleaderboard_Click(sender As Object, e As EventArgs) Handles picleaderboard.Click
        MsgBox("No")
    End Sub

    Private Sub picrevisiontips_Click(sender As Object, e As EventArgs) Handles picrevisiontips.Click
        RevisionTips.Show()
    End Sub

    Private Sub brnFilldatabase_Click(sender As Object, e As EventArgs) Handles brnFilldatabase.Click
        If databasecon.State = ConnectionState.Closed Then
            databasecon.Open()
        End If
        Dim cmd As New OleDbCommand("select count(*) from userdetails where username=? and password=?", databasecon)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = "test1"
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = "test1pass"
        Dim count = Convert.ToUInt32(cmd.ExecuteScalar())
        databasecon.Close()
    End Sub
End Class
