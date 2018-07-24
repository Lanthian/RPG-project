Public Class frmRPGProject

    '****Defines variables used universally****
    Dim exp, lvl, expToLvl, cash As Integer
    Dim task, diff As String
    Dim db As Database = New Database()
    Dim taskFreq() As Integer = {0, 0, 0, 0}

    Private Sub frmRPGProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '****Sets variables to default or null****
        lvl = 1
        exp = 0
        expToLvl = 5
        cash = 0
        task = ""
        diff = ""

        taskFreq(0) = 0
        taskFreq(1) = 0
        taskFreq(2) = 0
        taskFreq(3) = 0
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
            ElseIf task = "Study" Then
                exp += 4
            Else
                exp += 5
            End If
            If diff = "Difficult" Then
                exp += 1
            ElseIf diff = "Easy" Then
                exp -= 1
            End If
            '****Converts EXP to level if applicable****
            If exp >= expToLvl Then
                exp -= expToLvl
                lvl += 1
                expToLvl += 5
            End If
            '****Displays Output****
            lblExp.text = exp
            lblLvl.text = lvl
        End If
    End Sub

End Class
