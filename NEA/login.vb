Imports System.Data.OleDb
Imports System.Data
Public Class login
    Dim databasecon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\loginsystem.mdb")
    Private Sub picregister_Click(sender As Object, e As EventArgs) Handles picregister.Click
        Signup.Show()
        Me.Hide()
    End Sub

    Private Sub picquit_Click(sender As Object, e As EventArgs) Handles picquit.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub picmainmenu_Click(sender As Object, e As EventArgs) Handles picmainmenu.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub logintodatabase()
        If databasecon.State = ConnectionState.Closed Then
            databasecon.Open()
        End If
        Dim cmd As New OleDbCommand("select count(*) from userdetails where username=? and password=?", databasecon)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtPassword.Text
        Dim count = Convert.ToUInt32(cmd.ExecuteScalar())
        databasecon.Close()

        isloggedin = count

        If (isloggedin > 0) Then
            MsgBox("Login successful", MsgBoxStyle.Information)
            playername = txtUsername.Text 'logs username for keeping score
            loginprocess = True
            Form1.lblloggedinas.Text = ("Logged in as: " + playername)
            Form1.picLoginReminder.Visible = False
            Form1.picstartgrey.Visible = False
            Form1.picstart.Visible = True
            Form1.pichowtoplay.Visible = True
            Form1.picBannerarrow1.Visible = False
            Form1.picBannerarrow2.Visible = False
            Form1.picBannerarrow3.Visible = False
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Account not found try again or sign up to continue")
        End If
    End Sub

    Private Sub piclogin_Click_1(sender As Object, e As EventArgs) Handles piclogin.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Make sure to enter credentials ", MsgBoxStyle.Exclamation)
        Else
            logintodatabase()
        End If
    End Sub

    Private Sub login_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
                MsgBox("Make sure to enter credentials ", MsgBoxStyle.Exclamation)
            Else
                logintodatabase()
            End If
        End If
    End Sub
End Class

'https://www.youtube.com/watch?v=qlKAyKEfqHg