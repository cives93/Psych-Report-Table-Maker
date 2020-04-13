<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRangeLabel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRangeLabel))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.txtLowerBound = New System.Windows.Forms.TextBox()
        Me.txtRangeLabel = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.tmDataSet = New Psych_Report_Table_Maker.tmDataSet()
        Me.ScoreTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScoreTypeTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.ScoreTypeTableAdapter()
        Me.TableAdapterManager = New Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager()
        Me.ScoreTypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtUpperBound = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.tmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(304, 355)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 35)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(140, 355)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(158, 35)
        Me.btnOkay.TabIndex = 4
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'txtLowerBound
        '
        Me.txtLowerBound.Location = New System.Drawing.Point(140, 50)
        Me.txtLowerBound.Name = "txtLowerBound"
        Me.txtLowerBound.Size = New System.Drawing.Size(314, 29)
        Me.txtLowerBound.TabIndex = 1
        '
        'txtRangeLabel
        '
        Me.txtRangeLabel.Location = New System.Drawing.Point(140, 13)
        Me.txtRangeLabel.Name = "txtRangeLabel"
        Me.txtRangeLabel.Size = New System.Drawing.Size(314, 29)
        Me.txtRangeLabel.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 16)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(47, 21)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "Label"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 54)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(102, 21)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Lower Bound"
        '
        'tmDataSet
        '
        Me.tmDataSet.DataSetName = "tmDataSet"
        Me.tmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScoreTypeBindingSource
        '
        Me.ScoreTypeBindingSource.AllowNew = False
        Me.ScoreTypeBindingSource.DataMember = "ScoreType"
        Me.ScoreTypeBindingSource.DataSource = Me.tmDataSet
        '
        'ScoreTypeTableAdapter
        '
        Me.ScoreTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatteryTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableItemMarkerTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableItemTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableMarkerTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableTableAdapter = Nothing
        Me.TableAdapterManager.PersonBatteryAdministrationTableAdapter = Nothing
        Me.TableAdapterManager.PersonBatteryScaleTableAdapter = Nothing
        Me.TableAdapterManager.PersonBatteryTableAdapter = Nothing
        Me.TableAdapterManager.PersonTableAdapter = Nothing
        Me.TableAdapterManager.RangeLabelTableAdapter = Nothing
        Me.TableAdapterManager.RangeTableAdapter = Nothing
        Me.TableAdapterManager.ReportItemTableAdapter = Nothing
        Me.TableAdapterManager.ReportTableAdapter = Nothing
        Me.TableAdapterManager.ScaleTableAdapter = Nothing
        Me.TableAdapterManager.ScoreTypeTableAdapter = Me.ScoreTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ScoreTypeDataGridView
        '
        Me.ScoreTypeDataGridView.AutoGenerateColumns = False
        Me.ScoreTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScoreTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.ScoreTypeDataGridView.DataSource = Me.ScoreTypeBindingSource
        Me.ScoreTypeDataGridView.Location = New System.Drawing.Point(140, 126)
        Me.ScoreTypeDataGridView.Name = "ScoreTypeDataGridView"
        Me.ScoreTypeDataGridView.Size = New System.Drawing.Size(314, 223)
        Me.ScoreTypeDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ScoreTypeName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Score Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'txtUpperBound
        '
        Me.txtUpperBound.Location = New System.Drawing.Point(140, 88)
        Me.txtUpperBound.Name = "txtUpperBound"
        Me.txtUpperBound.Size = New System.Drawing.Size(314, 29)
        Me.txtUpperBound.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Upper Bound"
        '
        'AddRangeLabel
        '
        Me.AcceptButton = Me.btnOkay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(467, 402)
        Me.Controls.Add(Me.txtUpperBound)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ScoreTypeDataGridView)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.txtLowerBound)
        Me.Controls.Add(Me.txtRangeLabel)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddRangeLabel"
        Me.Text = "AddRangeLabel"
        CType(Me.tmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents txtLowerBound As System.Windows.Forms.TextBox
    Friend WithEvents txtRangeLabel As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents tmDataSet As Psych_Report_Table_Maker.tmDataSet
    Friend WithEvents ScoreTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScoreTypeTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.ScoreTypeTableAdapter
    Friend WithEvents TableAdapterManager As Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ScoreTypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtUpperBound As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
