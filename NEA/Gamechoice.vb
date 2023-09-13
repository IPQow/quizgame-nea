Imports System.IO
Imports System.Net


Public Class Gamechoice
    Dim req As Boolean = False
    Private Sub Gamechoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cat = 0
        diff = 0
        num = 0
        selectchoice = 0
        numOfQleftTotal = 0
        numOfQleft = 0
        numOfQleftForLabel = "0"
        score = 0
        scoreForLabel = "0"
        finalscore = "0"
    End Sub

    Private Sub picquit_Click(sender As Object, e As EventArgs) Handles picquit.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub piccontinue_Click(sender As Object, e As EventArgs) Handles piccontinue.Click
        'Select Case cbCat.SelectedItem
        '    Case "Computer Science"
        '        selectchoices = "18,"
        'End Select
        If cbCat.SelectedItem = "Computer Science" Then
            selectchoices = "18,"
        ElseIf cbCat.SelectedItem = "Geography" Then
            selectchoices = "22,"
        ElseIf cbCat.SelectedItem = "History" Then
            selectchoices = "23,"
        ElseIf cbCat.SelectedItem = "Politics" Then
            selectchoices = "24,"
        Else
            req = True
        End If
        If cbDiff.SelectedItem = "Easy" Then
            selectchoices = selectchoices + "easy,"
        ElseIf cbDiff.SelectedItem = "Medium" Then
            selectchoices = selectchoices + "medium,"
        ElseIf cbDiff.SelectedItem = "Hard" Then
            selectchoices = selectchoices + "hard,"
        Else
            req = True
        End If
        If cbNOQ.SelectedItem = "5" Then
            selectchoices = selectchoices + "5"
        ElseIf cbNOQ.SelectedItem = "10" Then
            selectchoices = selectchoices + "10,"
        ElseIf cbNOQ.SelectedItem = "15" Then
            selectchoices = selectchoices + "15"
        ElseIf cbNOQ.SelectedItem = "20" Then
            selectchoices = selectchoices + "20"
        Else
            req = True
        End If

        'If cbCat.SelectedItem = "Computer Science" Then
        '    cat = 10
        'ElseIf cbCat.SelectedItem = "Geography" Then
        '    cat = 20
        'ElseIf cbCat.SelectedItem = "History" Then
        '    cat = 30
        'ElseIf cbCat.SelectedItem = "Politics" Then
        '    cat = 40
        'End If

        'If cbDiff.SelectedItem = "Easy" Then
        '    diff = 1
        'ElseIf cbDiff.SelectedItem = "Medium" Then
        '    diff = 2
        'ElseIf cbDiff.SelectedItem = "Hard" Then
        '    diff = 3
        'End If

        'If cbNOQ.SelectedItem = "5" Then
        '    num = 100
        'ElseIf cbNOQ.SelectedItem = "10" Then
        '    num = 200
        'ElseIf cbNOQ.SelectedItem = "15" Then
        '    num = 300
        'ElseIf cbNOQ.SelectedItem = "20" Then
        '    num = 400
        'End If

        'selectchoice = cat + diff + num
        If req = True Then
            MsgBox("Make sure that all fields are filled")
            req = False
        ElseIf req = False Then
            Dim split = selectchoices.Split(",")
            gameoptions(0) = split(0)
            gameoptions(1) = split(1)
            gameoptions(2) = split(2)
            req = False
            Quiz.Show()
            Me.Close()
        End If
    End Sub

    Private Sub cbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCat.SelectedIndexChanged

    End Sub
End Class


'https://www.guru99.com/vb-net-combobox-control.html
'https://docs.microsoft.com/en-us/aspnet/web-forms/overview/ajax-control-toolkit/combobox/how-do-i-use-the-combobox-control-vb
'http://vb.net-informations.com/gui/vb.net-combobox.html
'https://www.daniweb.com/programming/software-development/threads/42758/how-do-i-get-value-selected-from-combobox