Public Class frmRPGproject

    '****Defines variables used universally****
    Dim exp, prevExp, lvl, prevLvl, expToLvl, taskFreq, turn, expCurve, cash, cashCurve, flashCost As Integer
    Dim task, diff As String
    Dim db As DataBase = New DataBase()
    Dim taskFreqArray() As Integer = {0, 0, 0, 0} 'TODO - 3,4? Skip variable set if possible


    Private Sub btnFlash_Click(sender As Object, e As EventArgs) Handles btnFlash.Click
        '****Spends cash to level up****
        If cash >= flashCost Then
            prevLvl = lvl
            lvl += 1
            expToLvl += expCurve
            lboTask.Items.Add("CASH SPENT: " & flashCost)
            lboTask.Items.Add("LEVEL UP ($): " & prevLvl & " -> " & lvl)
            flashCost += 2
            lblFlashCost.Text = ("COST: $" & flashCost)
            cash -= 12
            '****Displays Output****
            lblLvl.Text = ("LVL: " & lvl)
            pgbExp.Maximum = expToLvl
            pgbExp.Value = exp
            lblCash.Text = ("CASH: $" & cash)
        Else
            MsgBox("You need at least $" & flashCost & " to used this feature.")
        End If
    End Sub


    Private Sub frmRPGProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '****Sets variables to default or null****
        lvl = 1
        exp = 0
        expToLvl = 5
        prevExp = 0
        prevLvl = 0
        turn = 0
        expCurve = 2
        cash = 0
        cashCurve = 2
        task = ""
        diff = ""
        taskFreq = 0
        flashCost = 10
        'TODO Skip the below bit earlier if possible
        taskFreqArray(0) = 0
        taskFreqArray(1) = 0
        taskFreqArray(2) = 0
        taskFreqArray(3) = 0

        frmRPGshop.Hide()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'TODO ****Saves level, experience and currency to a text document through a function****
    End Sub


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'TODO ****Retrieves level, experience and currency from a text document through a function****
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '****Tests if inputs are empty****
        If (String.IsNullOrEmpty(cboTask.Text)) Or (String.IsNullOrEmpty(cboDiff.Text)) Then
            MsgBox("A section has been left blank.")
        Else
            '****Prepares variables for output display****
            prevExp = exp
            turn += 1
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
            '****Checks task frequency and deducts EXP if applicable****
            For i = 0 To 3
                If taskFreq = i Then
                    taskFreqArray(i) += 1
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
            '****Displays inputs in listbox****
            lboTask.items.add("[T" & turn & "] " & task & " @ " & diff & " for " & (exp - prevExp))
            '****Converts EXP to level and displays if applicable****
            If exp >= expToLvl Then
                prevLvl = lvl
                exp -= expToLvl
                lvl += 1
                expToLvl += expCurve
                lboTask.items.add("LEVEL UP: " & prevLvl & " -> " & lvl)
                cash += cashCurve
            End If
            '****Displays Output****
            lblExp.Text = ("EXP: " & exp)
            lblLvl.Text = ("LVL: " & lvl)
            pgbExp.Maximum = expToLvl
            pgbExp.Value = exp
            lblCash.Text = ("CASH: $" & cash)
        End If
    End Sub


    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Dim result As Integer = MessageBox.Show("Do you want to save before exiting?", "Unsaved progress will be lost", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Thanks for playing.")
            End
        ElseIf result = DialogResult.Yes Then
            'TODO - Save level, experience and currency to a text document through a function
            MessageBox.Show("Progress saved. Thanks for playing.")
            End
        End If
    End Sub

End Class
