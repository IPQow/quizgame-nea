Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions


Public Class Quiz
    Private rnd As New Random()
    Private correcta As String
    Private numOq As Decimal
    Private answered As Boolean = False
    Dim request As WebRequest

    Private Sub quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayername.Text = playername
        ' Keeps track of the logged in user throughout the game for score keeping
        If retrying = False Then
            lblscore.Text = ("Score: " + "0" + "/" + "0")
        ElseIf retrying = True Then
            lblscore.Text = ("(Retry) Score: " + "0" + "/" + "0")
        End If
        ' Resets the lable that keeps track of the score when in the game

        picanswerhighlight1.Visible = False
        picanswerhighlight2.Visible = False
        picanswerhighlight3.Visible = False
        picanswerhighlight4.Visible = False

        picanswerhighlight1.BringToFront()
        picanswerhighlight2.BringToFront()
        picanswerhighlight3.BringToFront()
        picanswerhighlight4.BringToFront()
        lbla1.BringToFront()
        lbla2.BringToFront()
        lbla3.BringToFront()
        lbla4.BringToFront()
        picstart.BringToFront()
        ' makes sure the pictures show up in the right order

        numOfQleft = gameoptions(2)
        numOfQleftTotal = Convert.ToInt32(gameoptions(2))

    End Sub

    Private Sub loopquestions()
        If numOfQleft < 1 Then
            finalscore = (score.ToString + "/" + numOfQleftTotal.ToString)
            EndScreen.Show()
            Me.Close()
        Else
            FetchQuestions()
        End If
    End Sub

    Private Sub FetchQuestions()
        If selectchoices = Nothing Then
            MsgBox("Error", MsgBoxStyle.Exclamation)
        Else
            request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=" + gameoptions(0) + "&difficulty=" + gameoptions(1) + "&type=multiple")
        End If

        Dim array(3)

        Dim response As WebResponse = request.GetResponse()
        ' Display the status.
        txtstatus.Text = CType(response, HttpWebResponse).StatusDescription
        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.
        txtTest.Text = responseFromServer
        ' Clean up the streams and the response.
        reader.Close()
        response.Close()

        Dim sSource As String = responseFromServer 'String that is being searched
        Dim sDelimStart As String = "correct_answer" 'First delimiting word
        Dim sDelimEnd As String = "incorrect_answers" 'Second delimiting word
        Dim nIndexStart As Integer = sSource.IndexOf(sDelimStart) 'Find the first occurrence of f1
        Dim nIndexEnd As Integer = sSource.IndexOf(sDelimEnd) 'Find the first occurrence of f2

        Dim wsDelimStart As String = "incorrect_answers" 'First delimiting word
        Dim wsDelimEnd As String = "]" 'Second delimiting word
        Dim wnIndexStart As Integer = sSource.IndexOf(wsDelimStart) 'Find the first occurrence of f1
        Dim wnIndexEnd As Integer = sSource.IndexOf(wsDelimEnd) 'Find the first occurrence of f2

        Dim qsDelimStart As String = "question" 'First delimiting word
        Dim qsDelimEnd As String = "correct_answer" 'Second delimiting word
        Dim qnIndexStart As Integer = sSource.IndexOf(qsDelimStart) 'Find the first occurrence of f1
        Dim qnIndexEnd As Integer = sSource.IndexOf(qsDelimEnd) 'Find the first occurrence of f2

        If nIndexStart > -1 AndAlso nIndexEnd > -1 Then '-1 means the word was not found.
            Dim resC As String = Strings.Mid(sSource, nIndexStart + sDelimStart.Length + 1, nIndexEnd - nIndexStart - sDelimStart.Length) 'Crop the text between
            Dim resW As String = Strings.Mid(sSource, wnIndexStart + wsDelimStart.Length + 1, wnIndexEnd - wnIndexStart - wsDelimStart.Length) 'Crop the text between
            Dim resQ As String = Strings.Mid(sSource, qnIndexStart + qsDelimStart.Length + 1, qnIndexEnd - qnIndexStart - qsDelimStart.Length) 'Crop the text between

            Dim acceptedChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&1234567890#*' <>".ToCharArray
            Dim acceptedWrongChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&,1234567890#*' <>".ToCharArray
            Dim acceptedQuestionChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&1234567890#*' <>".ToCharArray
            Dim correctanswer As String
            Dim wronganswers As String
            Dim question As String
            correctanswer = (From ch As Char In resC Select ch Where acceptedChars.Contains(ch)).ToArray
            wronganswers = (From ch As Char In resW Select ch Where acceptedWrongChars.Contains(ch)).ToArray
            question = (From ch As Char In resQ Select ch Where acceptedQuestionChars.Contains(ch)).ToArray
            lblquestion.Text = question
            Dim split = wronganswers.Split(",")
            array(0) = correctanswer
            array(1) = split(0)
            array(2) = split(1)
            array(3) = split(2)
            correcta = correctanswer

            Dim j As Int32
            Dim temp As String

            For n As Int32 = array.Length - 1 To 0 Step -1
                j = rnd.Next(0, n + 1)
                ' Swap them.
                temp = array(n)
                array(n) = array(j)
                array(j) = temp
            Next n

            lbla1.Text = array(0)
            lbla2.Text = array(1)
            lbla3.Text = array(2)
            lbla4.Text = array(3)
        Else
            MessageBox.Show("Error")
        End If
    End Sub

    Private Sub picbuttonanswers(sender As Object, e As EventArgs) Handles pica1.Click, pica2.Click, pica3.Click, pica4.Click
        If answered = False Then
            Dim PicButton = CType(sender, PictureBox)
            Dim Picbuttontag = Val(PicButton.Tag)
            Dim choice As String
            Dim a As String
            Dim b As String
            Dim c As String
            Dim d As String

            a = lbla1.Text
            b = lbla2.Text
            c = lbla3.Text
            d = lbla4.Text

            If a = correcta Then
                picanswerhighlight1.Visible = True
                picanswerhighlightskip.Visible = True
            End If
            If b = correcta Then
                picanswerhighlight2.Visible = True
                picanswerhighlightskip.Visible = True
            End If
            If c = correcta Then
                picanswerhighlight3.Visible = True
                picanswerhighlightskip.Visible = True
            End If
            If d = correcta Then
                picanswerhighlight4.Visible = True
                picanswerhighlightskip.Visible = True
            End If

            If Picbuttontag = 1 Then
                choice = lbla1.Text
            End If
            If Picbuttontag = 2 Then
                choice = lbla2.Text
            End If
            If Picbuttontag = 3 Then
                choice = lbla3.Text
            End If
            If Picbuttontag = 4 Then
                choice = lbla4.Text
            End If

            If choice = correcta Then
                lblquestion.Font = New Font("Montserrat", 72, FontStyle.Bold)
                lblquestion.ForeColor = Color.Lime
                lblquestion.Text = ("Correct!")
                numOfQleft = numOfQleft - 1
                numOfQleftForLabel = numOfQleftForLabel + 1
                score = score + 1
                scoreForLabel = score
                If retrying = False Then
                    lblscore.Text = ("Score: " + scoreForLabel + "/" + numOfQleftForLabel)
                ElseIf retrying = True Then
                    lblscore.Text = ("(Retry) Score: " + scoreForLabel + "/" + numOfQleftForLabel)
                End If

            Else
                lblquestion.Font = New Font("Montserrat", 72, FontStyle.Bold)
                lblquestion.ForeColor = Color.Red
                lblquestion.Text = ("Wrong.")
                numOfQleft = numOfQleft - 1
                numOfQleftForLabel = numOfQleftForLabel + 1
                scoreForLabel = score
                If retrying = False Then
                    lblscore.Text = ("Score: " + scoreForLabel + "/" + numOfQleftForLabel)
                ElseIf retrying = True Then
                    lblscore.Text = ("(Retry) Score: " + scoreForLabel + "/" + numOfQleftForLabel)
                End If
            End If
            answered = True
        ElseIf answered = True Then
            MsgBox("Click on the yellow box below to continue")
        End If
    End Sub

    Private Sub lblbuttonanswers(sender As Object, e As EventArgs) Handles lbla1.Click, lbla2.Click, lbla3.Click, lbla4.Click

        If answered = False Then
            Dim lblButton = CType(sender, Label)
            Dim lblbuttontag = Val(lblButton.Tag)
            Dim choice As String
            Dim a As String
            Dim b As String
            Dim c As String
            Dim d As String

            a = lbla1.Text
            b = lbla2.Text
            c = lbla3.Text
            d = lbla4.Text

            If a = correcta Then
                picanswerhighlight1.Visible = True
                picanswerhighlightskip.Visible = True
            End If
            If b = correcta Then
                picanswerhighlight2.Visible = True
                picanswerhighlightskip.Visible = True
            End If
            If c = correcta Then
                picanswerhighlight3.Visible = True
                picanswerhighlightskip.Visible = True
            End If
            If d = correcta Then
                picanswerhighlight4.Visible = True
                picanswerhighlightskip.Visible = True
            End If

            If lblbuttontag = 1 Then
                choice = lbla1.Text
            End If
            If lblbuttontag = 2 Then
                choice = lbla2.Text
            End If
            If lblbuttontag = 3 Then
                choice = lbla3.Text
            End If
            If lblbuttontag = 4 Then
                choice = lbla4.Text
            End If

            If choice = correcta Then
                lblquestion.Font = New Font("Montserrat", 72, FontStyle.Bold)
                lblquestion.ForeColor = Color.Lime
                lblquestion.Text = ("Correct!")
                numOfQleft = numOfQleft - 1
                numOfQleftForLabel = numOfQleftForLabel + 1
                score = score + 1
                scoreForLabel = score
                If retrying = False Then
                    lblscore.Text = ("Score: " + scoreForLabel + "/" + numOfQleftForLabel)
                ElseIf retrying = True Then
                    lblscore.Text = ("(Retry) Score: " + scoreForLabel + "/" + numOfQleftForLabel)
                End If
            Else
                lblquestion.Font = New Font("Montserrat", 72, FontStyle.Bold)
                lblquestion.ForeColor = Color.Red
                lblquestion.Text = ("Wrong.")
                numOfQleft = numOfQleft - 1
                numOfQleftForLabel = numOfQleftForLabel + 1
                scoreForLabel = score
                If retrying = False Then
                    lblscore.Text = ("Score: " + scoreForLabel + "/" + numOfQleftForLabel)
                ElseIf retrying = True Then
                    lblscore.Text = ("(Retry) Score: " + scoreForLabel + "/" + numOfQleftForLabel)
                End If
            End If
            answered = True
        ElseIf answered = True Then
            MsgBox("Click on the yellow box below to continue")
        End If
    End Sub

    Private Sub picquit_Click(sender As Object, e As EventArgs) Handles picquit.Click
        Select Case MsgBox("Are you sure you would like to quit? Your current progress will be lost", MsgBoxStyle.YesNo, "Remember, winners never quit and quitters never win.")
            Case MsgBoxResult.No
                'MessageBox.Show("Yes button")
            Case MsgBoxResult.Yes
                Form1.Close()
                Me.Close()
        End Select
    End Sub

    Private Sub picskip_Click(sender As Object, e As EventArgs) Handles picskip.Click
        Select Case MsgBox("Are you sure you would like to skip this question? If you do, 1 will be deducted from your score", MsgBoxStyle.YesNo, "Skip?")
            Case MsgBoxResult.No
                'MessageBox.Show("Yes button")
            Case MsgBoxResult.Yes
                scoreForLabel = scoreForLabel + 1
                score = score - 1
                scoreForLabel = score
                numOfQleft = numOfQleft - 1
                numOfQleftForLabel = numOfQleftForLabel + 1
                lblscore.Text = ("Score: " + scoreForLabel + "/" + numOfQleftForLabel)
                loopquestions()
        End Select
    End Sub

    Private Sub picstart_Click(sender As Object, e As EventArgs) Handles picstart.Click
        picstart.Hide()
        loopquestions()
    End Sub

    Private Sub picanswerhighlightskip_Click(sender As Object, e As EventArgs) Handles picanswerhighlightskip.Click
        answered = False
        picanswerhighlight1.Visible = False
        picanswerhighlight2.Visible = False
        picanswerhighlight3.Visible = False
        picanswerhighlight4.Visible = False
        picanswerhighlightskip.Visible = False
        lblquestion.Font = New Font("Montserrat", 36, FontStyle.Bold)
        lblquestion.ForeColor = Color.White
        loopquestions()
    End Sub
End Class


'Private Sub categorise()

'numOq = selectchoice / 100
''MsgBox(numOq) [FOR TESTING]
'selectchoice = selectchoice Mod 100
''MsgBox(selectchoice) [FOR TESTING]
'selectchoice = selectchoice / 100
''MsgBox(selectchoice) [FOR TESTING]
'numOq = numOq - selectchoice
''MsgBox(numOq) [FOR TESTING]
'selectchoice = selectchoice * 100
''MsgBox(selectchoice) [FOR TESTING]

'If numOq = 1 Then
'    numOfQleft = 5
'ElseIf numOq = 2 Then
'    numOfQleft = 10
'ElseIf numOq = 3 Then
'    numOfQleft = 15
'ElseIf numOq = 4 Then
'    numOfQleft = 20
'End If

'If selectchoice < 1 Then
'    MsgBox("Error", MsgBoxStyle.Exclamation)
'ElseIf selectchoice = 11 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=18&difficulty=easy&type=multiple")
'ElseIf selectchoice = 12 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=18&difficulty=medium&type=multiple")
'ElseIf selectchoice = 13 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=18&difficulty=hard&type=multiple")
'ElseIf selectchoice = 21 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=22&difficulty=easy&type=multiple")
'ElseIf selectchoice = 22 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=22&difficulty=medium&type=multiple")
'ElseIf selectchoice = 23 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=22&difficulty=hard&type=multiple")
'ElseIf selectchoice = 31 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=23&difficulty=easy&type=multiple")
'ElseIf selectchoice = 32 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=23&difficulty=medium&type=multiple")
'ElseIf selectchoice = 33 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=23&difficulty=hard&type=multiple")
'ElseIf selectchoice = 41 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=24&difficulty=easy&type=multiple")
'ElseIf selectchoice = 42 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=24&difficulty=medium&type=multiple")
'ElseIf selectchoice = 43 Then
'    request = WebRequest.Create("https://opentdb.com/api.php?amount=1&category=24&difficulty=hard&type=multiple")
'End If

'Dim array(3)

'Dim response As WebResponse = request.GetResponse()
'' Display the status.
'txtstatus.Text = CType(response, HttpWebResponse).StatusDescription
'' Get the stream containing content returned by the server.
'Dim dataStream As Stream = response.GetResponseStream()
'' Open the stream using a StreamReader for easy access.
'Dim reader As New StreamReader(dataStream)
'' Read the content.
'Dim responseFromServer As String = reader.ReadToEnd()
'' Display the content.
'txtTest.Text = responseFromServer
'' Clean up the streams and the response.
'reader.Close()
'response.Close()

'Dim sSource As String = responseFromServer 'String that is being searched
'Dim sDelimStart As String = "correct_answer" 'First delimiting word
'Dim sDelimEnd As String = "incorrect_answers" 'Second delimiting word
'Dim nIndexStart As Integer = sSource.IndexOf(sDelimStart) 'Find the first occurrence of f1
'Dim nIndexEnd As Integer = sSource.IndexOf(sDelimEnd) 'Find the first occurrence of f2

'Dim wsDelimStart As String = "incorrect_answers" 'First delimiting word
'Dim wsDelimEnd As String = "]" 'Second delimiting word
'Dim wnIndexStart As Integer = sSource.IndexOf(wsDelimStart) 'Find the first occurrence of f1
'Dim wnIndexEnd As Integer = sSource.IndexOf(wsDelimEnd) 'Find the first occurrence of f2

'If nIndexStart > -1 AndAlso nIndexEnd > -1 Then '-1 means the word was not found.
'    Dim resC As String = Strings.Mid(sSource, nIndexStart + sDelimStart.Length + 1, nIndexEnd - nIndexStart - sDelimStart.Length) 'Crop the text between
'    Dim resW As String = Strings.Mid(sSource, wnIndexStart + wsDelimStart.Length + 1, wnIndexEnd - wnIndexStart - wsDelimStart.Length) 'Crop the text between


'    Dim acceptedChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&,' <>".ToCharArray
'    Dim acceptedWrongChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&,' <>".ToCharArray
'    Dim correctanswer As String
'    Dim wronganswers As String
'    correctanswer = (From ch As Char In resC Select ch Where acceptedChars.Contains(ch)).ToArray
'    wronganswers = (From ch As Char In resW Select ch Where acceptedWrongChars.Contains(ch)).ToArray
'    Dim split = wronganswers.Split(",")
'    array(0) = correctanswer
'    array(1) = split(0)
'    array(2) = split(1)
'    array(3) = split(2)
'    correcta = correctanswer

'    Dim j As Int32
'    Dim temp As String

'    For n As Int32 = array.Length - 1 To 0 Step -1
'        j = rnd.Next(0, n + 1)
'        ' Swap them.
'        temp = array(n)
'        array(n) = array(j)
'        array(j) = temp
'    Next n

'    btna2.Text = array(1)
'    btna3.Text = array(2)
'    btna4.Text = array(3)
'    btna1.Text = array(0)
'Else
'    MessageBox.Show("Error")
'End If
'End Sub

'Private Sub apicall()
'    Dim array(3)

'    Dim response As WebResponse = request.GetResponse()
'    ' Display the status.
'    txtstatus.Text = CType(response, HttpWebResponse).StatusDescription
'    ' Get the stream containing content returned by the server.
'    Dim dataStream As Stream = response.GetResponseStream()
'    ' Open the stream using a StreamReader for easy access.
'    Dim reader As New StreamReader(dataStream)
'    ' Read the content.
'    Dim responseFromServer As String = reader.ReadToEnd()
'    ' Display the content.
'    txtTest.Text = responseFromServer
'    ' Clean up the streams and the response.
'    reader.Close()
'    response.Close()

'    Dim sSource As String = responseFromServer 'String that is being searched
'    Dim sDelimStart As String = "correct_answer" 'First delimiting word
'    Dim sDelimEnd As String = "incorrect_answers" 'Second delimiting word
'    Dim nIndexStart As Integer = sSource.IndexOf(sDelimStart) 'Find the first occurrence of f1
'    Dim nIndexEnd As Integer = sSource.IndexOf(sDelimEnd) 'Find the first occurrence of f2

'    Dim wsDelimStart As String = "incorrect_answers" 'First delimiting word
'    Dim wsDelimEnd As String = "]" 'Second delimiting word
'    Dim wnIndexStart As Integer = sSource.IndexOf(wsDelimStart) 'Find the first occurrence of f1
'    Dim wnIndexEnd As Integer = sSource.IndexOf(wsDelimEnd) 'Find the first occurrence of f2

'    If nIndexStart > -1 AndAlso nIndexEnd > -1 Then '-1 means the word was not found.
'        Dim resC As String = Strings.Mid(sSource, nIndexStart + sDelimStart.Length + 1, nIndexEnd - nIndexStart - sDelimStart.Length) 'Crop the text between
'        Dim resW As String = Strings.Mid(sSource, wnIndexStart + wsDelimStart.Length + 1, wnIndexEnd - wnIndexStart - wsDelimStart.Length) 'Crop the text between


'        Dim acceptedChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&,' <>".ToCharArray
'        Dim acceptedWrongChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&,' <>".ToCharArray
'        Dim correctanswer As String
'        Dim wronganswers As String
'        correctanswer = (From ch As Char In resC Select ch Where acceptedChars.Contains(ch)).ToArray
'        wronganswers = (From ch As Char In resW Select ch Where acceptedWrongChars.Contains(ch)).ToArray
'        Dim split = wronganswers.Split(",")
'        array(0) = correctanswer
'        array(1) = split(0)
'        array(2) = split(1)
'        array(3) = split(2)
'        correcta = correctanswer

'        Dim j As Int32
'        Dim temp As String

'        For n As Int32 = array.Length - 1 To 0 Step -1
'            j = rnd.Next(0, n + 1)
'            ' Swap them.
'            temp = array(n)
'            array(n) = array(j)
'            array(j) = temp
'        Next n

'        btna2.Text = array(1)
'        btna3.Text = array(2)
'        btna4.Text = array(3)
'        btna1.Text = array(0)
'    Else
'        MessageBox.Show("Error")
'    End If
'End Sub







'Dim request As WebRequest =
'        WebRequest.Create("https://opentdb.com/api.php?amount=10&category=18&difficulty=easy&type=multiple")
'Dim response As WebResponse = request.GetResponse()
'' Display the status.
'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
'' Get the stream containing content returned by the server.
'Dim dataStream As Stream = response.GetResponseStream()
'' Open the stream using a StreamReader for easy access.
'Dim reader As New StreamReader(dataStream)
'' Read the content.
'Dim responseFromServer As String = reader.ReadToEnd()
'' Display the content.
'Console.WriteLine(responseFromServer)
'' Clean up the streams and the response.
'reader.Close()
'response.Close()



'Dim sSource As String = "Hi my name is Homer Simpson." 'String that is being searched
'Dim sDelimStart As String = "my" 'First delimiting word - Starts after this but not including
'Dim sDelimEnd As String = "Simpson" 'Second delimiting word - End before this not including
'Dim nIndexStart As Integer = sSource.IndexOf(sDelimStart) 'Find the first occurrence of f1
'Dim nIndexEnd As Integer = sSource.IndexOf(sDelimEnd) 'Find the first occurrence of f2

'If nIndexStart > -1 AndAlso nIndexEnd > -1 Then '-1 means the word was not found.
'Dim res As String = Strings.Mid(sSource, nIndexStart + sDelimStart.Length + 1, nIndexEnd - nIndexStart - sDelimStart.Length) 'Crop the text between
'MessageBox.Show(res) 'Display
'Else
'MessageBox.Show("One or both of the delimiting words were not found!")
'End If


'Dim acceptedChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&' <>".ToCharArray

'Dim testString As String
'testString = "abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ¬!£$%^&*()_+{}:@~<>?|123456790-=[];'#,./\€ÁÉÍÓÚÝáéíóúý€"

'Dim result As String
'result = (From ch As Char In testString Select ch Where acceptedChars.Contains(ch)).ToArray
'MessageBox.Show(result)