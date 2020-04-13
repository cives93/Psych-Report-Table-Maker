<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddScoreType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddScoreType))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.txtScoreType = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtSD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstStandardScore = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(273, 126)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 35)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(133, 126)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(134, 35)
        Me.btnOkay.TabIndex = 4
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(273, 50)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.Size = New System.Drawing.Size(94, 29)
        Me.txtMean.TabIndex = 2
        '
        'txtScoreType
        '
        Me.txtScoreType.Location = New System.Drawing.Point(133, 13)
        Me.txtScoreType.Name = "txtScoreType"
        Me.txtScoreType.Size = New System.Drawing.Size(234, 29)
        Me.txtScoreType.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(42, 16)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(85, 21)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "Score Type"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(218, 53)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(49, 21)
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "Mean"
        '
        'txtSD
        '
        Me.txtSD.Location = New System.Drawing.Point(273, 88)
        Me.txtSD.Name = "txtSD"
        Me.txtSD.Size = New System.Drawing.Size(94, 29)
        Me.txtSD.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SD"
        '
        'lstStandardScore
        '
        Me.lstStandardScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstStandardScore.FormattingEnabled = True
        Me.lstStandardScore.ItemHeight = 21
        Me.lstStandardScore.Items.AddRange(New Object() {"Yes", "No"})
        Me.lstStandardScore.Location = New System.Drawing.Point(133, 50)
        Me.lstStandardScore.Name = "lstStandardScore"
        Me.lstStandardScore.Size = New System.Drawing.Size(66, 44)
        Me.lstStandardScore.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Standard Score"
        '
        'AddScoreType
        '
        Me.AcceptButton = Me.btnOkay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(382, 175)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstStandardScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.txtMean)
        Me.Controls.Add(Me.txtScoreType)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtSD)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddScoreType"
        Me.Text = "AddScoreType"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents txtMean As System.Windows.Forms.TextBox
    Friend WithEvents txtScoreType As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtSD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstStandardScore As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
