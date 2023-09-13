Public Class howtoplay
    Private Sub picmainmenu_Click(sender As Object, e As EventArgs) Handles picmainmenu.Click
        Me.Hide()
    End Sub

    Private Sub picquit_Click(sender As Object, e As EventArgs) Handles picquit.Click
        Form1.Close()
        Me.Close()
    End Sub
End Class