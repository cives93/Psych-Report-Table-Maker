<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDisplayTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDisplayTable))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTableName = New System.Windows.Forms.TextBox()
        Me.txtFirstColumn = New System.Windows.Forms.TextBox()
        Me.cbxScore = New System.Windows.Forms.CheckBox()
        Me.cbxPercentile = New System.Windows.Forms.CheckBox()
        Me.cbxRange = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.txtTableTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Table Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "1st Column"
        '
        'txtTableName
        '
        Me.txtTableName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTableName.Location = New System.Drawing.Point(129, 6)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(571, 29)
        Me.txtTableName.TabIndex = 0
        '
        'txtFirstColumn
        '
        Me.txtFirstColumn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirstColumn.Location = New System.Drawing.Point(129, 73)
        Me.txtFirstColumn.Name = "txtFirstColumn"
        Me.txtFirstColumn.Size = New System.Drawing.Size(571, 29)
        Me.txtFirstColumn.TabIndex = 3
        Me.txtFirstColumn.Text = "Scale"
        '
        'cbxScore
        '
        Me.cbxScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxScore.AutoSize = True
        Me.cbxScore.Checked = True
        Me.cbxScore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxScore.Location = New System.Drawing.Point(129, 256)
        Me.cbxScore.Name = "cbxScore"
        Me.cbxScore.Size = New System.Drawing.Size(68, 25)
        Me.cbxScore.TabIndex = 5
        Me.cbxScore.Text = "Score"
        Me.cbxScore.UseVisualStyleBackColor = True
        '
        'cbxPercentile
        '
        Me.cbxPercentile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxPercentile.AutoSize = True
        Me.cbxPercentile.Checked = True
        Me.cbxPercentile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxPercentile.Location = New System.Drawing.Point(231, 256)
        Me.cbxPercentile.Name = "cbxPercentile"
        Me.cbxPercentile.Size = New System.Drawing.Size(96, 25)
        Me.cbxPercentile.TabIndex = 6
        Me.cbxPercentile.Text = "Percentile"
        Me.cbxPercentile.UseVisualStyleBackColor = True
        '
        'cbxRange
        '
        Me.cbxRange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxRange.AutoSize = True
        Me.cbxRange.Checked = True
        Me.cbxRange.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxRange.Location = New System.Drawing.Point(357, 256)
        Me.cbxRange.Name = "cbxRange"
        Me.cbxRange.Size = New System.Drawing.Size(73, 25)
        Me.cbxRange.TabIndex = 7
        Me.cbxRange.Text = "Range"
        Me.cbxRange.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(580, 251)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 35)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOkay.Location = New System.Drawing.Point(454, 251)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(120, 35)
        Me.btnOkay.TabIndex = 8
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'txtTableTitle
        '
        Me.txtTableTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTableTitle.Location = New System.Drawing.Point(129, 40)
        Me.txtTableTitle.Name = "txtTableTitle"
        Me.txtTableTitle.Size = New System.Drawing.Size(571, 29)
        Me.txtTableTitle.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Table Title"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.Location = New System.Drawing.Point(129, 107)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(571, 137)
        Me.txtNote.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Note"
        '
        'AddDisplayTable
        '
        Me.AcceptButton = Me.btnOkay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(710, 298)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.txtTableTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.cbxRange)
        Me.Controls.Add(Me.cbxPercentile)
        Me.Controls.Add(Me.cbxScore)
        Me.Controls.Add(Me.txtFirstColumn)
        Me.Controls.Add(Me.txtTableName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddDisplayTable"
        Me.Text = "AddDisplayTable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTableName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstColumn As System.Windows.Forms.TextBox
    Friend WithEvents cbxScore As System.Windows.Forms.CheckBox
    Friend WithEvents cbxPercentile As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRange As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents txtTableTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
