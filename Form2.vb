Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Save Button

        Dim Save1 As String = My.Application.Info.DirectoryPath + "\RPGsaveFile.txt"

        If System.IO.File.Exists(Save1) = True Then
            Dim objWriter As New System.IO.StreamWriter(Save1)
            Dim lvl, exp, expToLvl, turn, cash, expCurve, taskFreq, flashCost As Integer



            'lvl = 1
            'exp = 9999
            'expToLvl = 5
            'turn = 0
            'cash = 0
            'expCurve = 2
            'taskFreq = 0
            'flashCost = 4


            'objWriter.Write(TextBox1.Text + vbNewLine)
            'objWriter.Write(ListBox1.Items)
            'objWriter.Write(space)
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
            MessageBox.Show("File Saved")
        Else
            MessageBox.Show("File could not be found")
        End If
        'Save system credit to Connor Anthian
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Load1 As String = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\RPGsaveFile.txt")
        'Dim objWriter As New System.IO.StreamWriter(Load1)
        Dim lvl, exp, expToLvl, turn, cash, expCurve, taskFreq, flashCost As Integer

        Dim array() As String
        array = Load1.Split(vbNewLine)

        lvl = array(0)
        exp = array(1)
        expToLvl = array(2)
        turn = array(3)
        cash = array(4)
        expCurve = array(5)
        taskFreq = array(6)
        flashCost = array(7)

        'MsgBox(lvl & exp)
    End Sub
