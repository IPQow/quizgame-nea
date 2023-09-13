Imports System.Data.OleDb
Imports System.Data

Public Class Signup
    Dim databasecon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=loginsystem.mdb")
    Dim testnum As Integer = 0
    Dim testrnd As Integer
    Private Sub registertodatabase()
        Using command As New OleDbCommand("select count(*) from userdetails where [Username] = @username and [Password] = @Password", databasecon)
            Try
                If txtPassword.Text.Length > 3 Then
                    If txtPassword.Text.Length < 12 Then
                        Dim cmd2 As New OleDbCommand("insert into userdetails(username, password) values(?,?)", databasecon)
                        Using create As New OleDbCommand("INSERT INTO userdetails([Username], [Password]) VALUES(@Username, @Password)", databasecon)
                            create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
                            create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim

                            If create.ExecuteNonQuery Then
                                MsgBox("Account created, please login", MsgBoxStyle.Information, "Successfully created an account")
                            Else
                                MsgBox("Creation error")

                            End If

                        End Using
                    Else
                        MsgBox("Your password must be between 3 and 12 characters", MsgBoxStyle.Exclamation)
                    End If

                Else
                        MsgBox("Your password must be between 3 and 12 characters", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("There is already an account with the name " & txtUsername.Text & vbCrLf & vbCrLf & "Please Choose another name or click login", MsgBoxStyle.Exclamation, "Oops!")
            Finally
            End Try
        End Using
    End Sub

    Private Sub picregister_Click(sender As Object, e As EventArgs) Handles picregister.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Make sure to enter all the required credentials", MsgBoxStyle.Exclamation)
        End If

        If databasecon.State = ConnectionState.Closed Then
            databasecon.Open()
        End If
        registertodatabase()
    End Sub

    Private Sub piclogin_Click(sender As Object, e As EventArgs) Handles piclogin.Click
        login.txtUsername.Text = txtUsername.Text
        login.txtPassword.Text = txtPassword.Text
        login.Show()
        Me.Hide()
    End Sub

    Private Sub picmainmenu_Click(sender As Object, e As EventArgs) Handles picmainmenu.Click
        Form1.lblloggedinas.Text = ("Logged in as: " + playername)
        Form1.Show()
        login.Close()
        Me.Close()
    End Sub

    Private Sub picquit_Click(sender As Object, e As EventArgs) Handles picquit.Click
        login.Close()
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub btnTestmultipleregister_Click(sender As Object, e As EventArgs) Handles btnTestmultipleregister.Click
        If databasecon.State = ConnectionState.Closed Then
            databasecon.Open()
        End If

        Using command As New OleDbCommand("select count(*) from userdetails where [Username] = @username and [Password] = @Password", databasecon)

            If txtPassword.Text.Length > 3 Then
                Dim cmd2 As New OleDbCommand("insert into userdetails(username, password) values(?,?)", databasecon)
                Using create As New OleDbCommand("INSERT INTO userdetails([Username], [Password]) VALUES(@Username, @Password)", databasecon)
                    create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
                    create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim

                    If create.ExecuteNonQuery Then
                        MsgBox("Account created, please login", MsgBoxStyle.Information, "Successfully created an account")
                    Else
                        MsgBox("Creation error")
                    End If
                End Using
            Else
                MsgBox("Your password needs to be more than 3 charactersr", MsgBoxStyle.Exclamation)
            End If
        End Using
    End Sub

    Private Sub signup_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
                MsgBox("Make sure to enter credentials ", MsgBoxStyle.Exclamation)
            Else
                registertodatabase()
            End If
        End If
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        If databasecon.State = ConnectionState.Closed Then
            databasecon.Open()
        End If

        Dim testu As String
        Dim testp As String

        For i As Integer = 1 To 100
            Using command As New OleDbCommand("select count(*) from userdetails where [Username] = @username and [Password] = @Password", databasecon)
                testrnd = CInt(Math.Floor((100 - 0 + 1) * Rnd())) + 0
                If txtPassword.Text.Length = 0 Then
                    Dim cmd2 As New OleDbCommand("insert into userdetails(username, password) values(?,?)", databasecon)
                    Using create As New OleDbCommand("INSERT INTO userdetails([Username], [Password], [Score]) VALUES(@Username, @Password, @Score)", databasecon)
                        testu = ("test" + testnum.ToString + "u")
                        testp = ("test" + testnum.ToString + "p")
                        create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = testu
                        create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = testp
                        create.Parameters.AddWithValue("@Score", OleDbType.Integer).Value = testrnd

                        testnum = testnum + 1
                        If create.ExecuteNonQuery Then
                            'MsgBox("Account created, please login", MsgBoxStyle.Information, "Successfully created an account")
                        Else
                            MsgBox("Creation error")
                        End If
                    End Using
                Else
                    MsgBox("Your password needs to be more than 3 charactersr", MsgBoxStyle.Exclamation)
                End If
            End Using
        Next
        MsgBox("done")
    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = login.txtUsername.Text
        txtPassword.Text = login.txtPassword.Text
    End Sub
End Class