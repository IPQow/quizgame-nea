Public Class RevisionTips
    Private Sub picquit_Click(sender As Object, e As EventArgs) Handles picquit.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub picmainmenu_Click(sender As Object, e As EventArgs) Handles picmainmenu.Click
        Me.Close()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        picBack.Visible = False
        Me.Hide()
    End Sub
End Class