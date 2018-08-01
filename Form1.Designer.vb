<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRPGproject
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboTask = New System.Windows.Forms.ComboBox()
        Me.cboDiff = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExp = New System.Windows.Forms.Label()
        Me.lblLvl = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lboTask = New System.Windows.Forms.ListBox()
        Me.pgbExp = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnFlash = New System.Windows.Forms.Button()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblFlashCost = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(36, 97)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Complete Task"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboTask
        '
        Me.cboTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTask.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTask.FormattingEnabled = True
        Me.cboTask.Items.AddRange(New Object() {"Exercise", "Homework", "Study", "Work"})
        Me.cboTask.Location = New System.Drawing.Point(72, 19)
        Me.cboTask.Name = "cboTask"
        Me.cboTask.Size = New System.Drawing.Size(115, 23)
        Me.cboTask.TabIndex = 1
        '
        'cboDiff
        '
        Me.cboDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiff.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiff.FormattingEnabled = True
        Me.cboDiff.Items.AddRange(New Object() {"Easy", "Medium", "Difficult"})
        Me.cboDiff.Location = New System.Drawing.Point(72, 48)
        Me.cboDiff.Name = "cboDiff"
        Me.cboDiff.Size = New System.Drawing.Size(115, 23)
        Me.cboDiff.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Task"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Difficulty"
        '
        'lblExp
        '
        Me.lblExp.AutoSize = True
        Me.lblExp.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExp.Location = New System.Drawing.Point(9, 31)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Size = New System.Drawing.Size(45, 18)
        Me.lblExp.TabIndex = 5
        Me.lblExp.Text = "EXP: 0"
        '
        'lblLvl
        '
        Me.lblLvl.AutoSize = True
        Me.lblLvl.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLvl.Location = New System.Drawing.Point(9, 13)
        Me.lblLvl.Name = "lblLvl"
        Me.lblLvl.Size = New System.Drawing.Size(42, 18)
        Me.lblLvl.TabIndex = 6
        Me.lblLvl.Text = "LVL: 1"
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(12, 264)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(95, 23)
        Me.btnLoad.TabIndex = 7
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(111, 264)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 34)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "RPG Task Manager"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 47)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.LightCoral
        Me.btnEnd.Location = New System.Drawing.Point(397, 19)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(67, 40)
        Me.btnEnd.TabIndex = 11
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lboTask
        '
        Me.lboTask.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboTask.FormattingEnabled = True
        Me.lboTask.HorizontalScrollbar = True
        Me.lboTask.ItemHeight = 15
        Me.lboTask.Location = New System.Drawing.Point(212, 118)
        Me.lboTask.Name = "lboTask"
        Me.lboTask.Size = New System.Drawing.Size(252, 229)
        Me.lboTask.TabIndex = 12
        '
        'pgbExp
        '
        Me.pgbExp.BackColor = System.Drawing.SystemColors.Control
        Me.pgbExp.Location = New System.Drawing.Point(72, 10)
        Me.pgbExp.Name = "pgbExp"
        Me.pgbExp.Size = New System.Drawing.Size(374, 37)
        Me.pgbExp.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbExp.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblExp)
        Me.GroupBox2.Controls.Add(Me.pgbExp)
        Me.GroupBox2.Controls.Add(Me.lblLvl)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 53)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cboTask)
        Me.GroupBox3.Controls.Add(Me.cboDiff)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 145)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'btnFlash
        '
        Me.btnFlash.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlash.Location = New System.Drawing.Point(93, 21)
        Me.btnFlash.Name = "btnFlash"
        Me.btnFlash.Size = New System.Drawing.Size(94, 23)
        Me.btnFlash.TabIndex = 5
        Me.btnFlash.Text = "Cash Level Up"
        Me.btnFlash.UseVisualStyleBackColor = True
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(9, 16)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(62, 18)
        Me.lblCash.TabIndex = 14
        Me.lblCash.Text = "CASH: $0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblFlashCost)
        Me.GroupBox4.Controls.Add(Me.btnFlash)
        Me.GroupBox4.Controls.Add(Me.lblCash)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 290)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(194, 59)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'lblFlashCost
        '
        Me.lblFlashCost.AutoSize = True
        Me.lblFlashCost.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlashCost.Location = New System.Drawing.Point(9, 34)
        Me.lblFlashCost.Name = "lblFlashCost"
        Me.lblFlashCost.Size = New System.Drawing.Size(60, 18)
        Me.lblFlashCost.TabIndex = 15
        Me.lblFlashCost.Text = "COST: $4"
        '
        'frmRPGproject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 359)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lboTask)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "frmRPGproject"
        Me.Text = "RPG-Project"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents cboTask As ComboBox
    Friend WithEvents cboDiff As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblExp As Label
    Friend WithEvents lblLvl As Label
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEnd As Button
    Friend WithEvents lboTask As ListBox
    Friend WithEvents pgbExp As ProgressBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnFlash As Button
    Friend WithEvents lblCash As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblFlashCost As Label
End Class
