'***************************** Module Header *******************************
' Module Name:  frmRPGproject.vb
' Project:      RPG Projcet
' Authors:      Liam Anthian, Scott Daisley
' 
' A program/game with the intent of motivating users to complete tasks such 
' as homework and exercise for the reward of receiving experience and
' levelling up.
'***************************************************************************


''' <summary>
''' The below Class handles all the input, processing, storage and outputing of variables.
''' </summary>
Public Class frmRPGproject

    '****Defines variables used universally****
    Dim exp, prevExp, lvl, prevLvl, expToLvl, taskFreq, turn, expCurve, cash, cashCurve, flashCost As Integer
    Dim task, diff As String
    Dim taskFreqArray() As Integer = {0, 0, 0, 0}


    Private Sub btnFlash_Click(sender As Object, e As EventArgs) Handles btnFlash.Click
        '****Spends cash to level up****
        If cash >= flashCost Then
            prevLvl = lvl
            lvl += 1
            expToLvl += expCurve
            lboTask.Items.Add("CASH SPENT: " & flashCost)
            lboTask.Items.Add("LEVEL UP ($): " & prevLvl & " -> " & lvl)
            cash -= flashCost
            flashCost += 2
            '****Displays Output****
            lblFlashCost.Text = ("COST: $" & flashCost)
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
        expCurve = 1
        cash = 0
        cashCurve = 2
        task = ""
        diff = ""
        taskFreq = 0
        flashCost = 4
        ''TODO Skip the below bit earlier if possible
        'taskFreqArray(0) = 0
        'taskFreqArray(1) = 0
        'taskFreqArray(2) = 0
        'taskFreqArray(3) = 0
        lblFlashCost.Text = ("COST: $" & flashCost)
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '****Saves variables to a text document****
        Dim Save1 As String = My.Application.Info.DirectoryPath + "\RPGsaveFile.txt"
        '****Check for savefile existence****
        If System.IO.File.Exists(Save1) = True Then
            Dim objWriter As New System.IO.StreamWriter(Save1)
            '****Write variables to file****
            objWriter.Write(lvl)
            objWriter.WriteLine()
            objWriter.Write(exp)
            objWriter.WriteLine()
            objWriter.Write(expToLvl)
            objWriter.WriteLine()
            objWriter.Write(turn)
            objWriter.WriteLine()
            objWriter.Write(cash)
            objWriter.WriteLine()
            objWriter.Write(expCurve)
            objWriter.WriteLine()
            objWriter.Write(taskFreq)
            objWriter.WriteLine()
            objWriter.Write(flashCost)
            objWriter.Close()
            MessageBox.Show("File saved.")
        Else
            '****Create RPGsaveFile if file does not exist****
            MessageBox.Show("File could not be found.")
            System.IO.File.Create(My.Application.Info.DirectoryPath + "\RPGsaveFile.txt").Dispose()
            MessageBox.Show("Blank RPGsaveFile created.")
        End If
        'NOTE: Save system credit to Connor Anthian
    End Sub


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        '****Retrieves variables from a text document****
        Dim Load1 As String = My.Application.Info.DirectoryPath + "\RPGsaveFile.txt"
        '****Check file existence****
        If System.IO.File.Exists(Load1) = True Then
            Load1 = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\RPGsaveFile.txt")
            Dim array() As String
            '****Setting Defined Variables****
            array = Load1.Split(vbNewLine)
            lvl = array(0)
            exp = array(1)
            expToLvl = array(2)
            turn = array(3)
            cash = array(4)
            expCurve = array(5)
            taskFreq = array(6)
            flashCost = array(7)
            MessageBox.Show("File loaded.")
            '****Displays Output****
            lblFlashCost.Text = ("COST: $" & flashCost)
            lblExp.Text = ("EXP: " & exp)
            lblLvl.Text = ("LVL: " & lvl)
            pgbExp.Maximum = expToLvl
            pgbExp.Value = exp
            lblCash.Text = ("CASH: $" & cash)
            '****Clears Listbox****
            lboTask.Items.Clear()
        Else
            MessageBox.Show("File could not be found.")
        End If
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
                    For n = 0 To 3
                        If n = i Then
                        Else taskFreqArray(n) = 0
                        End If
                    Next
                End If
            Next
            For i = 0 To 3
                If taskFreqArray(i) >= 4 Then
                    exp -= 1
                End If
            Next
            '****Displays inputs in listbox****
            lboTask.Items.Add("[T" & turn & "] " & task & " @ " & diff & " for " & (exp - prevExp))
            '****Converts EXP to level and displays if applicable****
            If exp >= expToLvl Then
                prevLvl = lvl
                exp -= expToLvl
                lvl += 1
                expToLvl += expCurve
                lboTask.Items.Add("LEVEL UP: " & prevLvl & " -> " & lvl)
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
            '****Check btnSave code for comments on below code****
            Dim Save1 As String = My.Application.Info.DirectoryPath + "\RPGsaveFile.txt"
            If System.IO.File.Exists(Save1) = True Then
                Dim objWriter As New System.IO.StreamWriter(Save1)
                objWriter.Write(lvl)
                objWriter.WriteLine()
                objWriter.Write(exp)
                objWriter.WriteLine()
                objWriter.Write(expToLvl)
                objWriter.WriteLine()
                objWriter.Write(turn)
                objWriter.WriteLine()
                objWriter.Write(cash)
                objWriter.WriteLine()
                objWriter.Write(expCurve)
                objWriter.WriteLine()
                objWriter.Write(taskFreq)
                objWriter.WriteLine()
                objWriter.Write(flashCost)
                objWriter.Close()
                MessageBox.Show("Progress saved. Thanks for playing.")
                End
            Else
                MessageBox.Show("File could not be found.")
                System.IO.File.Create(My.Application.Info.DirectoryPath + "\RPGsaveFile.txt").Dispose()
                MessageBox.Show("Blank RPGsaveFile created.")
            End If
        End If
    End Sub

End Class
