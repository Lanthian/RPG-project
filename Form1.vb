Public Class frmRPGproject

    '****Defines variables used universally****
    Dim exp, lvl, expToLvl, taskFreq As Integer
    'TODO Dim cash as Integer
    Dim task, diff As String
    'TODO Dim db As Database = New Database()
    Dim taskFreqArray() As Integer = {0, 0, 0, 0} 'TODO - 3,4? Skip variable set if possible

    Private Sub frmRPGProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '****Sets variables to default or null****
        lvl = 1
        exp = 0
        expToLvl = 5
        'TODO cash = 0
        task = ""
        diff = ""
        taskFreq = 0
        'TODO Skip the below bit earlier if possible
        taskFreqArray(0) = 0
        taskFreqArray(1) = 0
        taskFreqArray(2) = 0
        taskFreqArray(3) = 0
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '****Saves level, experience and currency to a text document through a function****
    End Sub


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        '****Retrieves level, experience and currency from a text document through a function****
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '****Tests if inputs are empty****
        If (String.IsNullOrEmpty(cboTask.Text)) Or (String.IsNullOrEmpty(cboDiff.Text)) Then
            MsgBox("A section has been left blank.")
        Else
            '****Adds EXP depending on difficulty and task****
            task = cboTask.Text
            diff = cboDiff.Text
            If task = "Homework" Or task = "Exercise" Then
                exp += 3
                If task = "Homework" Then
                    taskFreq = 0
                Else
                    taskFreq = 1
                End If
            ElseIf task = "Study" Then
                exp += 4
                taskFreq = 2
            Else
                exp += 5
                taskFreq = 3
            End If
            If diff = "Difficult" Then
                exp += 1
            ElseIf diff = "Easy" Then
                exp -= 1
            End If
            '****Checks task frequency And deducts EXP if applicable****
            For i = 0 To 3
                If taskFreq = i Then
                    For n = 0 To 3 And Not i
                        taskFreqArray(n) = 0
                    Next
                End If
            Next
            For i = 0 To 3 'TODO <- Needed?
                If taskFreqArray(i) >= 4 Then
                    exp -= 1
                End If
            Next
            '****Converts EXP to level if applicable****
            If exp >= expToLvl Then
                exp -= expToLvl
                lvl += 1
                expToLvl += 5
                'TODO cash += x
            End If
            '****Displays Output****
            lblExp.Text = ("EXP: " & exp)
            lblLvl.Text = ("LVL: " & lvl)
            'TODO lblCash.text = ("$$$: " & cash)
        End If
    End Sub

End Class
