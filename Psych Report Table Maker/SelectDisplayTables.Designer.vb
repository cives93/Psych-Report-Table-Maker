<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectDisplayTables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectDisplayTables))
        Me.tmDataSet = New Psych_Report_Table_Maker.tmDataSet()
        Me.DisplayTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DisplayTableTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableTableAdapter()
        Me.TableAdapterManager = New Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager()
        Me.dgvIncludeTable = New System.Windows.Forms.DataGridView()
        Me.DisplayTableNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxOmit = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.btnDownDisplayItem = New System.Windows.Forms.Button()
        Me.btnUpDisplayItem = New System.Windows.Forms.Button()
        Me.dvgExcludeTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExcludeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnExclude = New System.Windows.Forms.Button()
        Me.btnInclude = New System.Windows.Forms.Button()
        CType(Me.tmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIncludeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgExcludeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExcludeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmDataSet
        '
        Me.tmDataSet.DataSetName = "tmDataSet"
        Me.tmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DisplayTableBindingSource
        '
        Me.DisplayTableBindingSource.AllowNew = False
        Me.DisplayTableBindingSource.DataMember = "DisplayTable"
        Me.DisplayTableBindingSource.DataSource = Me.tmDataSet
        Me.DisplayTableBindingSource.Filter = "Include=True"
        Me.DisplayTableBindingSource.Sort = "OrderID"
        '
        'DisplayTableTableAdapter
        '
        Me.DisplayTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatteryTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableItemMarkerTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableItemTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableMarkerTableAdapter = Nothing
        Me.TableAdapterManager.DisplayTableTableAdapter = Me.DisplayTableTableAdapter
        Me.TableAdapterManager.PersonBatteryAdministrationTableAdapter = Nothing
        Me.TableAdapterManager.PersonBatteryScaleTableAdapter = Nothing
        Me.TableAdapterManager.PersonBatteryTableAdapter = Nothing
        Me.TableAdapterManager.PersonTableAdapter = Nothing
        Me.TableAdapterManager.RangeLabelTableAdapter = Nothing
        Me.TableAdapterManager.RangeTableAdapter = Nothing
        Me.TableAdapterManager.ReportItemTableAdapter = Nothing
        Me.TableAdapterManager.ReportTableAdapter = Nothing
        Me.TableAdapterManager.ScaleTableAdapter = Nothing
        Me.TableAdapterManager.ScoreTypeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dgvIncludeTable
        '
        Me.dgvIncludeTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvIncludeTable.AutoGenerateColumns = False
        Me.dgvIncludeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncludeTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DisplayTableNameDataGridViewTextBoxColumn})
        Me.dgvIncludeTable.DataSource = Me.DisplayTableBindingSource
        Me.dgvIncludeTable.Location = New System.Drawing.Point(13, 15)
        Me.dgvIncludeTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvIncludeTable.Name = "dgvIncludeTable"
        Me.dgvIncludeTable.Size = New System.Drawing.Size(396, 388)
        Me.dgvIncludeTable.TabIndex = 0
        '
        'DisplayTableNameDataGridViewTextBoxColumn
        '
        Me.DisplayTableNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DisplayTableNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayTableName"
        Me.DisplayTableNameDataGridViewTextBoxColumn.HeaderText = "Include"
        Me.DisplayTableNameDataGridViewTextBoxColumn.Name = "DisplayTableNameDataGridViewTextBoxColumn"
        '
        'cbxOmit
        '
        Me.cbxOmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxOmit.AutoSize = True
        Me.cbxOmit.Location = New System.Drawing.Point(479, 421)
        Me.cbxOmit.Name = "cbxOmit"
        Me.cbxOmit.Size = New System.Drawing.Size(207, 25)
        Me.cbxOmit.TabIndex = 6
        Me.cbxOmit.Text = "Omit rows without scores"
        Me.cbxOmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(177, 412)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOkay.Location = New System.Drawing.Point(13, 412)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(158, 40)
        Me.btnOkay.TabIndex = 1
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'btnDownDisplayItem
        '
        Me.btnDownDisplayItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDownDisplayItem.Image = CType(resources.GetObject("btnDownDisplayItem.Image"), System.Drawing.Image)
        Me.btnDownDisplayItem.Location = New System.Drawing.Point(374, 412)
        Me.btnDownDisplayItem.Name = "btnDownDisplayItem"
        Me.btnDownDisplayItem.Size = New System.Drawing.Size(35, 40)
        Me.btnDownDisplayItem.TabIndex = 4
        '
        'btnUpDisplayItem
        '
        Me.btnUpDisplayItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpDisplayItem.Image = CType(resources.GetObject("btnUpDisplayItem.Image"), System.Drawing.Image)
        Me.btnUpDisplayItem.Location = New System.Drawing.Point(333, 412)
        Me.btnUpDisplayItem.Name = "btnUpDisplayItem"
        Me.btnUpDisplayItem.Size = New System.Drawing.Size(35, 40)
        Me.btnUpDisplayItem.TabIndex = 3
        '
        'dvgExcludeTable
        '
        Me.dvgExcludeTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dvgExcludeTable.AutoGenerateColumns = False
        Me.dvgExcludeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgExcludeTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.dvgExcludeTable.DataSource = Me.ExcludeTableBindingSource
        Me.dvgExcludeTable.Location = New System.Drawing.Point(479, 15)
        Me.dvgExcludeTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dvgExcludeTable.Name = "dvgExcludeTable"
        Me.dvgExcludeTable.Size = New System.Drawing.Size(396, 388)
        Me.dvgExcludeTable.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DisplayTableName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Exclude"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ExcludeTableBindingSource
        '
        Me.ExcludeTableBindingSource.AllowNew = False
        Me.ExcludeTableBindingSource.DataMember = "DisplayTable"
        Me.ExcludeTableBindingSource.DataSource = Me.tmDataSet
        Me.ExcludeTableBindingSource.Filter = "Include=False"
        Me.ExcludeTableBindingSource.Sort = "DisplayTableName"
        '
        'btnExclude
        '
        Me.btnExclude.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExclude.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExclude.Image = CType(resources.GetObject("btnExclude.Image"), System.Drawing.Image)
        Me.btnExclude.Location = New System.Drawing.Point(416, 135)
        Me.btnExclude.Name = "btnExclude"
        Me.btnExclude.Size = New System.Drawing.Size(56, 35)
        Me.btnExclude.TabIndex = 8
        '
        'btnInclude
        '
        Me.btnInclude.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnInclude.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInclude.Image = CType(resources.GetObject("btnInclude.Image"), System.Drawing.Image)
        Me.btnInclude.Location = New System.Drawing.Point(416, 176)
        Me.btnInclude.Name = "btnInclude"
        Me.btnInclude.Size = New System.Drawing.Size(56, 35)
        Me.btnInclude.TabIndex = 9
        '
        'SelectDisplayTables
        '
        Me.AcceptButton = Me.btnOkay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(889, 455)
        Me.Controls.Add(Me.btnInclude)
        Me.Controls.Add(Me.btnExclude)
        Me.Controls.Add(Me.dvgExcludeTable)
        Me.Controls.Add(Me.btnDownDisplayItem)
        Me.Controls.Add(Me.btnUpDisplayItem)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.cbxOmit)
        Me.Controls.Add(Me.dgvIncludeTable)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SelectDisplayTables"
        Me.Text = "SelectDisplayTables"
        CType(Me.tmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIncludeTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgExcludeTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExcludeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmDataSet As Psych_Report_Table_Maker.tmDataSet
    Friend WithEvents DisplayTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisplayTableTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableTableAdapter
    Friend WithEvents TableAdapterManager As Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvIncludeTable As System.Windows.Forms.DataGridView
    Friend WithEvents cbxOmit As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents btnDownDisplayItem As System.Windows.Forms.Button
    Friend WithEvents btnUpDisplayItem As System.Windows.Forms.Button
    Friend WithEvents DisplayTableNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dvgExcludeTable As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExcludeTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnExclude As System.Windows.Forms.Button
    Friend WithEvents btnInclude As System.Windows.Forms.Button
End Class
