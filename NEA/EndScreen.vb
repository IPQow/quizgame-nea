Imports System.Data.OleDb
Imports System.Data
Public Class EndScreen
    Dim databasecon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=loginsystem.mdb")
    Private Sub EndScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picfacewiggo.BringToFront()
        picface1.BringToFront()
        picface2.BringToFront()
        picface3.BringToFront()
        picface4.BringToFront()
        picface5.BringToFront()

        picfacewiggo.Visible = False
        picface1.Visible = False
        picface2.Visible = False
        picface3.Visible = False
        picface4.Visible = False
        picface5.Visible = False

        lblFinaScore.Text = finalscore
        scoreforface = score / numOfQleftTotal
        scoreforface = scoreforface * 100

        scorestring = scoreforface.ToString

        If scorestring > 80 Then
            picface5.Visible = True
        ElseIf scorestring >= 60 Then
            picface4.Visible = True
        ElseIf scorestring > 40 Then
            picface3.Visible = True
        ElseIf scorestring > 20 Then
            picface2.Visible = True
        ElseIf scorestring > 0 Then
            picface1.Visible = True
        ElseIf scorestring > -200 Then
            picfacewiggo.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    'Private Sub picScoretoleaderboard_Click(sender As Object, e As EventArgs) Handles picScoretoleaderboard.Click
    '    'If databasecon.State = ConnectionState.Closed Then
    '    '    databasecon.Open()
    '    'End If
    '    'Dim cmd As New OleDbCommand("update userdetails set score="scorestring"' where username="playername, databasecon)
    '    'cmd.ExecuteNonQuery();
    '    ''https://www.youtube.com/watch?v=ZCs1vdwwl0o
    '    ''https://www.youtube.com/watch?v=k5ODy8oeIFU
    '    'databasecon.Close()
    '    'MsgBox("No")
    '    'Dim file As System.IO.StreamWriter
    '    'file = My.Computer.FileSystem.OpenTextFileWriter("D:\NEA\NEA\NEA\bin\Debug\Leaderboard.txt", True)
    '    'file.WriteLine(playername + "|" + finalscore + ",")
    '    'file.Close()
    'End Sub

    Private Sub picquit_Click(sender As Object, e As EventArgs) Handles picquit.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub picmainmenu_Click(sender As Object, e As EventArgs) Handles picmainmenu.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub picrevisiontips_Click(sender As Object, e As EventArgs) Handles picrevisiontips.Click
        RevisionTips.picBack.Visible = True
        RevisionTips.Show()
    End Sub

    Private Sub picretry_Click(sender As Object, e As EventArgs) Handles picretry.Click
        retrying = True
        Gamechoice.Show()
        Me.Hide()
    End Sub
End Class