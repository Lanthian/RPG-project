<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPGProject
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(358, 156)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Complete Task"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboTask
        '
        Me.cboTask.FormattingEnabled = True
        Me.cboTask.Items.AddRange(New Object() {"Exercise", "Homework", "Study", "Work"})
        Me.cboTask.Location = New System.Drawing.Point(44, 158)
        Me.cboTask.Name = "cboTask"
        Me.cboTask.Size = New System.Drawing.Size(121, 21)
        Me.cboTask.TabIndex = 1
        '
        'cboDiff
        '
        Me.cboDiff.FormattingEnabled = True
        Me.cboDiff.Items.AddRange(New Object() {"Easy", "Medium", "Difficult"})
        Me.cboDiff.Location = New System.Drawing.Point(194, 158)
        Me.cboDiff.Name = "cboDiff"
        Me.cboDiff.Size = New System.Drawing.Size(121, 21)
        Me.cboDiff.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Task"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Difficulty"
        '
        'lblExp
        '
        Me.lblExp.AutoSize = True
        Me.lblExp.Location = New System.Drawing.Point(93, 40)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Size = New System.Drawing.Size(40, 13)
        Me.lblExp.TabIndex = 5
        Me.lblExp.Text = "EXP: 0"
        '
        'lblLvl
        '
        Me.lblLvl.AutoSize = True
        Me.lblLvl.Location = New System.Drawing.Point(93, 66)
        Me.lblLvl.Name = "lblLvl"
        Me.lblLvl.Size = New System.Drawing.Size(38, 13)
        Me.lblLvl.TabIndex = 6
        Me.lblLvl.Text = "LVL: 1"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(211, 265)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(119, 23)
        Me.btnLoad.TabIndex = 7
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(358, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmRPGProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 358)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lblLvl)
        Me.Controls.Add(Me.lblExp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDiff)
        Me.Controls.Add(Me.cboTask)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmRPGProject"
        Me.Text = "RPG-Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
