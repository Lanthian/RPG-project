Public Class frmRPGProject

    '****Defines variables used universally****
    Dim exp, lvl, expToLvl As Integer
    Dim task As String
    Dim diff As String

    Private Sub frmRPGProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '****Sets variables to null****
        lvl = 1
        exp = 0
        expToLvl = 10
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
                expToLvl += 10
            End If
            '****Displays Output****
            lblExp.text = exp
            lblLvl.text = lvl
        End If
    End Sub
End Class
