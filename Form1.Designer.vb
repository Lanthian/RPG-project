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
        'frmRPGProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 358)
        Me.Controls.Add(Me.cboDiff)
        Me.Controls.Add(Me.cboTask)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmRPGProject"
        Me.Text = "RPG-Project"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents cboTask As ComboBox
    Friend WithEvents cboDiff As ComboBox
End Class
