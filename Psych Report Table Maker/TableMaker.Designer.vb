<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableMaker
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
        Dim FirstColumnHeaderLabel As System.Windows.Forms.Label
        Dim DisplayTableTitleLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim LevelLabel As System.Windows.Forms.Label
        Dim SizeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableMaker))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tcTableMaker = New System.Windows.Forms.TabControl()
        Me.tpPeople = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PersonDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SexBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tmDataSet = New Psych_Report_Table_Maker.tmDataSet()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDeletePerson = New System.Windows.Forms.Button()
        Me.btnAddPerson = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.BatteryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatteryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.dtpPersonBattery = New System.Windows.Forms.DateTimePicker()
        Me.PersonBatteryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDeleteTestGiven = New System.Windows.Forms.Button()
        Me.PersonBatteryDataGridView = New System.Windows.Forms.DataGridView()
        Me.BatteryID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AdministrationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonBatteryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddTestGiven = New System.Windows.Forms.Button()
        Me.PersonBatteryScaleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScaleID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ScaleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonBatteryScaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpTable = New System.Windows.Forms.TabPage()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer()
        Me.cbxHiddenTable = New System.Windows.Forms.CheckBox()
        Me.btnDeleteDisplayMarker = New System.Windows.Forms.Button()
        Me.btnAddDisplayMarker = New System.Windows.Forms.Button()
        Me.DisplayTableMarkerDataGridView = New System.Windows.Forms.DataGridView()
        Me.MarkerSymbol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayTableMarkerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DisplayTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDeleteDisplayTable = New System.Windows.Forms.Button()
        Me.btnAddDisplayTable = New System.Windows.Forms.Button()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.RangeCheckBox = New System.Windows.Forms.CheckBox()
        Me.PercentileCheckBox = New System.Windows.Forms.CheckBox()
        Me.ScoreCheckBox = New System.Windows.Forms.CheckBox()
        Me.DisplayTableTitleTextBox = New System.Windows.Forms.TextBox()
        Me.FirstColumnHeaderTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hide = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbxAbbreviation = New System.Windows.Forms.CheckBox()
        Me.DisplayTableItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnMakeTable = New System.Windows.Forms.Button()
        Me.RangeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.RangeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FullNameComboBox = New System.Windows.Forms.ComboBox()
        Me.btnAddAllDisplayItems = New System.Windows.Forms.Button()
        Me.cbxAllCaps = New System.Windows.Forms.CheckBox()
        Me.cbxFont = New System.Windows.Forms.ComboBox()
        Me.btnUnmarkItem = New System.Windows.Forms.Button()
        Me.btnMarkItem = New System.Windows.Forms.Button()
        Me.DisplayTableItemMarkerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DisplayTableMarkerID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DisplayTableItemMarkerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayTableItemMarkerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDownDisplayItem = New System.Windows.Forms.Button()
        Me.btnUpDisplayItem = New System.Windows.Forms.Button()
        Me.SizeTextBox = New System.Windows.Forms.TextBox()
        Me.BoldCheckBox = New System.Windows.Forms.CheckBox()
        Me.ItalicCheckBox = New System.Windows.Forms.CheckBox()
        Me.LevelListBox = New System.Windows.Forms.ListBox()
        Me.btnDeleteDisplayTableItem = New System.Windows.Forms.Button()
        Me.btnAddDisplayTableItem = New System.Windows.Forms.Button()
        Me.DisplayTableItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.Marker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayItemScore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentileColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RangeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayTableItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.BatteryDataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.scTableScale = New System.Windows.Forms.SplitContainer()
        Me.ScaleDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ScoreTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonBatteryListBox = New System.Windows.Forms.ListBox()
        Me.FilteredPersonBatteryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpBattery = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.cbxHide = New System.Windows.Forms.CheckBox()
        Me.btnDeleteBattery = New System.Windows.Forms.Button()
        Me.BatteryDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Abbreviation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HideBattery = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnAddBattery = New System.Windows.Forms.Button()
        Me.btnDownScale = New System.Windows.Forms.Button()
        Me.btnUpScale = New System.Windows.Forms.Button()
        Me.btnDeleteScale = New System.Windows.Forms.Button()
        Me.ScaleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScoreTypeID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ScoreTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Level = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ScaleTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddScale = New System.Windows.Forms.Button()
        Me.tpRangeLabel = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer9 = New System.Windows.Forms.SplitContainer()
        Me.btnDeleteRange = New System.Windows.Forms.Button()
        Me.btnAddRange = New System.Windows.Forms.Button()
        Me.RangeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScoreTypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StandardScore = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteScoreType = New System.Windows.Forms.Button()
        Me.btnAddScoreType = New System.Windows.Forms.Button()
        Me.btnDeleteRangeLabel = New System.Windows.Forms.Button()
        Me.btnAddRangeLabel = New System.Windows.Forms.Button()
        Me.RangeLabelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Upperbound = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RangeLabelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpImportExport = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnImportData = New System.Windows.Forms.Button()
        Me.btnSaveAllData = New System.Windows.Forms.Button()
        Me.PersonBatteryAdministrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DisplayTableItemScoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.PersonTableAdapter()
        Me.TableAdapterManager = New Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager()
        Me.BatteryTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.BatteryTableAdapter()
        Me.DisplayTableItemMarkerTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableItemMarkerTableAdapter()
        Me.DisplayTableItemTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableItemTableAdapter()
        Me.DisplayTableMarkerTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableMarkerTableAdapter()
        Me.DisplayTableTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableTableAdapter()
        Me.PersonBatteryAdministrationTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.PersonBatteryAdministrationTableAdapter()
        Me.PersonBatteryScaleTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.PersonBatteryScaleTableAdapter()
        Me.PersonBatteryTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.PersonBatteryTableAdapter()
        Me.RangeLabelTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.RangeLabelTableAdapter()
        Me.RangeTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.RangeTableAdapter()
        Me.ScaleTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.ScaleTableAdapter()
        Me.ScoreTypeTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.ScoreTypeTableAdapter()
        Me.DisplayTableItemScoreTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableItemScoreTableAdapter()
        Me.PersonBatteryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonBatteryBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.ReportTableAdapter()
        Me.ReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddReport = New System.Windows.Forms.Button()
        Me.btnDeleteReport = New System.Windows.Forms.Button()
        Me.ReportItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportItemTableAdapter = New Psych_Report_Table_Maker.tmDataSetTableAdapters.ReportItemTableAdapter()
        Me.ReportItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer10 = New System.Windows.Forms.SplitContainer()
        Me.tpConstruct = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        FirstColumnHeaderLabel = New System.Windows.Forms.Label()
        DisplayTableTitleLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        LevelLabel = New System.Windows.Forms.Label()
        SizeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.tcTableMaker.SuspendLayout()
        Me.tpPeople.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PersonDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.BatteryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatteryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.PersonBatteryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBatteryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBatteryScaleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScaleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBatteryScaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpTable.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        CType(Me.DisplayTableMarkerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayTableMarkerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayTableItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayTableItemMarkerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayTableItemMarkerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayTableItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        CType(Me.BatteryDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scTableScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scTableScale.Panel1.SuspendLayout()
        Me.scTableScale.Panel2.SuspendLayout()
        Me.scTableScale.SuspendLayout()
        CType(Me.ScaleDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilteredPersonBatteryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpBattery.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.BatteryDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScaleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScaleTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRangeLabel.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer9.Panel1.SuspendLayout()
        Me.SplitContainer9.Panel2.SuspendLayout()
        Me.SplitContainer9.SuspendLayout()
        CType(Me.RangeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeLabelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeLabelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpImportExport.SuspendLayout()
        CType(Me.PersonBatteryAdministrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayTableItemScoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBatteryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBatteryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer10.Panel1.SuspendLayout()
        Me.SplitContainer10.Panel2.SuspendLayout()
        Me.SplitContainer10.SuspendLayout()
        Me.tpConstruct.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstColumnHeaderLabel
        '
        FirstColumnHeaderLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        FirstColumnHeaderLabel.AutoSize = True
        FirstColumnHeaderLabel.Location = New System.Drawing.Point(3, 210)
        FirstColumnHeaderLabel.Name = "FirstColumnHeaderLabel"
        FirstColumnHeaderLabel.Size = New System.Drawing.Size(82, 17)
        FirstColumnHeaderLabel.TabIndex = 1
        FirstColumnHeaderLabel.Text = "First Header:"
        '
        'DisplayTableTitleLabel
        '
        DisplayTableTitleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DisplayTableTitleLabel.AutoSize = True
        DisplayTableTitleLabel.Location = New System.Drawing.Point(3, 108)
        DisplayTableTitleLabel.Name = "DisplayTableTitleLabel"
        DisplayTableTitleLabel.Size = New System.Drawing.Size(116, 17)
        DisplayTableTitleLabel.TabIndex = 3
        DisplayTableTitleLabel.Text = "Display Table Title:"
        '
        'NoteLabel
        '
        NoteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(3, 270)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(40, 17)
        NoteLabel.TabIndex = 8
        NoteLabel.Text = "Note:"
        '
        'LevelLabel
        '
        LevelLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LevelLabel.AutoSize = True
        LevelLabel.Location = New System.Drawing.Point(135, 364)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(40, 17)
        LevelLabel.TabIndex = 13
        LevelLabel.Text = "Level:"
        '
        'SizeLabel
        '
        SizeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        SizeLabel.AutoSize = True
        SizeLabel.Location = New System.Drawing.Point(4, 364)
        SizeLabel.Name = "SizeLabel"
        SizeLabel.Size = New System.Drawing.Size(34, 17)
        SizeLabel.TabIndex = 17
        SizeLabel.Text = "Size:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(155, 10)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(36, 17)
        Label1.TabIndex = 43
        Label1.Text = "Font:"
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(155, 41)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 17)
        Label2.TabIndex = 48
        Label2.Text = "Range:"
        '
        'tcTableMaker
        '
        Me.tcTableMaker.Controls.Add(Me.tpPeople)
        Me.tcTableMaker.Controls.Add(Me.tpTable)
        Me.tcTableMaker.Controls.Add(Me.tpBattery)
        Me.tcTableMaker.Controls.Add(Me.tpRangeLabel)
        Me.tcTableMaker.Controls.Add(Me.tpConstruct)
        Me.tcTableMaker.Controls.Add(Me.tpImportExport)
        Me.tcTableMaker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTableMaker.Location = New System.Drawing.Point(0, 0)
        Me.tcTableMaker.Margin = New System.Windows.Forms.Padding(4)
        Me.tcTableMaker.Name = "tcTableMaker"
        Me.tcTableMaker.SelectedIndex = 0
        Me.tcTableMaker.Size = New System.Drawing.Size(822, 570)
        Me.tcTableMaker.TabIndex = 0
        '
        'tpPeople
        '
        Me.tpPeople.AutoScroll = True
        Me.tpPeople.Controls.Add(Me.SplitContainer1)
        Me.tpPeople.Location = New System.Drawing.Point(4, 26)
        Me.tpPeople.Margin = New System.Windows.Forms.Padding(4)
        Me.tpPeople.Name = "tpPeople"
        Me.tpPeople.Padding = New System.Windows.Forms.Padding(4)
        Me.tpPeople.Size = New System.Drawing.Size(814, 540)
        Me.tpPeople.TabIndex = 0
        Me.tpPeople.Text = "People"
        Me.tpPeople.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PersonDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDeletePerson)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddPerson)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(806, 532)
        Me.SplitContainer1.SplitterDistance = 307
        Me.SplitContainer1.TabIndex = 8
        '
        'PersonDataGridView
        '
        Me.PersonDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonDataGridView.AutoGenerateColumns = False
        Me.PersonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.ClientID, Me.Sex})
        Me.PersonDataGridView.DataSource = Me.PersonBindingSource
        Me.PersonDataGridView.Location = New System.Drawing.Point(4, 4)
        Me.PersonDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PersonDataGridView.Name = "PersonDataGridView"
        Me.PersonDataGridView.Size = New System.Drawing.Size(295, 465)
        Me.PersonDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'ClientID
        '
        Me.ClientID.DataPropertyName = "ClientID"
        Me.ClientID.HeaderText = "ClientID"
        Me.ClientID.MinimumWidth = 75
        Me.ClientID.Name = "ClientID"
        Me.ClientID.Width = 75
        '
        'Sex
        '
        Me.Sex.DataPropertyName = "Sex"
        Me.Sex.DataSource = Me.SexBindingSource
        Me.Sex.DisplayMember = "Sex"
        Me.Sex.DisplayStyleForCurrentCellOnly = True
        Me.Sex.HeaderText = "Sex"
        Me.Sex.MinimumWidth = 75
        Me.Sex.Name = "Sex"
        Me.Sex.ValueMember = "SexID"
        Me.Sex.Width = 75
        '
        'SexBindingSource
        '
        Me.SexBindingSource.DataMember = "Sex"
        Me.SexBindingSource.DataSource = Me.tmDataSet
        '
        'tmDataSet
        '
        Me.tmDataSet.DataSetName = "tmDataSet"
        Me.tmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.AllowNew = False
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.tmDataSet
        '
        'btnDeletePerson
        '
        Me.btnDeletePerson.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeletePerson.Location = New System.Drawing.Point(184, 478)
        Me.btnDeletePerson.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeletePerson.Name = "btnDeletePerson"
        Me.btnDeletePerson.Size = New System.Drawing.Size(115, 34)
        Me.btnDeletePerson.TabIndex = 2
        Me.btnDeletePerson.Text = "Delete Person"
        Me.btnDeletePerson.UseVisualStyleBackColor = True
        '
        'btnAddPerson
        '
        Me.btnAddPerson.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPerson.Location = New System.Drawing.Point(4, 478)
        Me.btnAddPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddPerson.Name = "btnAddPerson"
        Me.btnAddPerson.Size = New System.Drawing.Size(172, 34)
        Me.btnAddPerson.TabIndex = 1
        Me.btnAddPerson.Text = "Add Person"
        Me.btnAddPerson.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.BatteryDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(495, 532)
        Me.SplitContainer2.SplitterDistance = 157
        Me.SplitContainer2.TabIndex = 0
        '
        'BatteryDataGridView
        '
        Me.BatteryDataGridView.AllowUserToAddRows = False
        Me.BatteryDataGridView.AllowUserToDeleteRows = False
        Me.BatteryDataGridView.AutoGenerateColumns = False
        Me.BatteryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatteryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1})
        Me.BatteryDataGridView.DataSource = Me.BatteryBindingSource
        Me.BatteryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.BatteryDataGridView.Name = "BatteryDataGridView"
        Me.BatteryDataGridView.Size = New System.Drawing.Size(491, 153)
        Me.BatteryDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "BatteryName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Test"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Abbreviation"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Abbreviation"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'BatteryBindingSource
        '
        Me.BatteryBindingSource.AllowNew = False
        Me.BatteryBindingSource.DataMember = "Battery"
        Me.BatteryBindingSource.DataSource = Me.tmDataSet
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.dtpPersonBattery)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnDeleteTestGiven)
        Me.SplitContainer3.Panel1.Controls.Add(Me.PersonBatteryDataGridView)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnAddTestGiven)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.PersonBatteryScaleDataGridView)
        Me.SplitContainer3.Size = New System.Drawing.Size(495, 371)
        Me.SplitContainer3.SplitterDistance = 155
        Me.SplitContainer3.TabIndex = 0
        '
        'dtpPersonBattery
        '
        Me.dtpPersonBattery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpPersonBattery.CustomFormat = ""
        Me.dtpPersonBattery.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBatteryBindingSource, "AdministrationDate", True))
        Me.dtpPersonBattery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPersonBattery.Location = New System.Drawing.Point(364, 109)
        Me.dtpPersonBattery.Name = "dtpPersonBattery"
        Me.dtpPersonBattery.Size = New System.Drawing.Size(120, 25)
        Me.dtpPersonBattery.TabIndex = 5
        Me.dtpPersonBattery.Value = New Date(2011, 12, 31, 14, 6, 1, 0)
        '
        'PersonBatteryBindingSource
        '
        Me.PersonBatteryBindingSource.DataMember = "PersonPersonBattery"
        Me.PersonBatteryBindingSource.DataSource = Me.PersonBindingSource
        '
        'btnDeleteTestGiven
        '
        Me.btnDeleteTestGiven.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteTestGiven.Location = New System.Drawing.Point(224, 106)
        Me.btnDeleteTestGiven.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteTestGiven.Name = "btnDeleteTestGiven"
        Me.btnDeleteTestGiven.Size = New System.Drawing.Size(134, 34)
        Me.btnDeleteTestGiven.TabIndex = 4
        Me.btnDeleteTestGiven.Text = "Delete Test"
        Me.btnDeleteTestGiven.UseVisualStyleBackColor = True
        '
        'PersonBatteryDataGridView
        '
        Me.PersonBatteryDataGridView.AllowUserToAddRows = False
        Me.PersonBatteryDataGridView.AllowUserToDeleteRows = False
        Me.PersonBatteryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonBatteryDataGridView.AutoGenerateColumns = False
        Me.PersonBatteryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonBatteryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BatteryID, Me.AdministrationDate, Me.PersonBatteryIDDataGridViewTextBoxColumn})
        Me.PersonBatteryDataGridView.DataSource = Me.PersonBatteryBindingSource
        Me.PersonBatteryDataGridView.Location = New System.Drawing.Point(4, 3)
        Me.PersonBatteryDataGridView.Name = "PersonBatteryDataGridView"
        Me.PersonBatteryDataGridView.Size = New System.Drawing.Size(479, 96)
        Me.PersonBatteryDataGridView.TabIndex = 7
        '
        'BatteryID
        '
        Me.BatteryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BatteryID.DataPropertyName = "BatteryID"
        Me.BatteryID.DataSource = Me.BatteryBindingSource
        Me.BatteryID.DisplayMember = "BatteryName"
        Me.BatteryID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.BatteryID.HeaderText = "Tests Given"
        Me.BatteryID.Name = "BatteryID"
        Me.BatteryID.ReadOnly = True
        Me.BatteryID.ValueMember = "BatteryID"
        '
        'AdministrationDate
        '
        Me.AdministrationDate.DataPropertyName = "AdministrationDate"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.AdministrationDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.AdministrationDate.HeaderText = "Date"
        Me.AdministrationDate.Name = "AdministrationDate"
        Me.AdministrationDate.ReadOnly = True
        '
        'PersonBatteryIDDataGridViewTextBoxColumn
        '
        Me.PersonBatteryIDDataGridViewTextBoxColumn.DataPropertyName = "PersonBatteryID"
        Me.PersonBatteryIDDataGridViewTextBoxColumn.HeaderText = "PersonBatteryID"
        Me.PersonBatteryIDDataGridViewTextBoxColumn.Name = "PersonBatteryIDDataGridViewTextBoxColumn"
        Me.PersonBatteryIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonBatteryIDDataGridViewTextBoxColumn.Visible = False
        '
        'btnAddTestGiven
        '
        Me.btnAddTestGiven.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTestGiven.Location = New System.Drawing.Point(4, 106)
        Me.btnAddTestGiven.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddTestGiven.Name = "btnAddTestGiven"
        Me.btnAddTestGiven.Size = New System.Drawing.Size(213, 34)
        Me.btnAddTestGiven.TabIndex = 3
        Me.btnAddTestGiven.Text = "Add Test"
        Me.btnAddTestGiven.UseVisualStyleBackColor = True
        '
        'PersonBatteryScaleDataGridView
        '
        Me.PersonBatteryScaleDataGridView.AllowUserToAddRows = False
        Me.PersonBatteryScaleDataGridView.AllowUserToDeleteRows = False
        Me.PersonBatteryScaleDataGridView.AutoGenerateColumns = False
        Me.PersonBatteryScaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonBatteryScaleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.ScaleID})
        Me.PersonBatteryScaleDataGridView.DataSource = Me.PersonBatteryScaleBindingSource
        Me.PersonBatteryScaleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonBatteryScaleDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PersonBatteryScaleDataGridView.Name = "PersonBatteryScaleDataGridView"
        Me.PersonBatteryScaleDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PersonBatteryScaleDataGridView.Size = New System.Drawing.Size(491, 208)
        Me.PersonBatteryScaleDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Score"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Score"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'ScaleID
        '
        Me.ScaleID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ScaleID.DataPropertyName = "ScaleID"
        Me.ScaleID.DataSource = Me.ScaleBindingSource1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ScaleID.DefaultCellStyle = DataGridViewCellStyle3
        Me.ScaleID.DisplayMember = "ScaleName"
        Me.ScaleID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ScaleID.HeaderText = "Scale"
        Me.ScaleID.Name = "ScaleID"
        Me.ScaleID.ReadOnly = True
        Me.ScaleID.ValueMember = "ScaleID"
        '
        'ScaleBindingSource1
        '
        Me.ScaleBindingSource1.DataMember = "Scale"
        Me.ScaleBindingSource1.DataSource = Me.tmDataSet
        '
        'PersonBatteryScaleBindingSource
        '
        Me.PersonBatteryScaleBindingSource.DataMember = "PersonBatteryPersonBatteryScale"
        Me.PersonBatteryScaleBindingSource.DataSource = Me.PersonBatteryBindingSource
        '
        'tpTable
        '
        Me.tpTable.Controls.Add(Me.SplitContainer6)
        Me.tpTable.Location = New System.Drawing.Point(4, 26)
        Me.tpTable.Name = "tpTable"
        Me.tpTable.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTable.Size = New System.Drawing.Size(814, 540)
        Me.tpTable.TabIndex = 3
        Me.tpTable.Text = "Tables"
        Me.tpTable.UseVisualStyleBackColor = True
        '
        'SplitContainer6
        '
        Me.SplitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.SplitContainer8)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.SplitContainer7)
        Me.SplitContainer6.Size = New System.Drawing.Size(808, 534)
        Me.SplitContainer6.SplitterDistance = 602
        Me.SplitContainer6.TabIndex = 0
        '
        'SplitContainer8
        '
        Me.SplitContainer8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer8.Name = "SplitContainer8"
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.AutoScroll = True
        Me.SplitContainer8.Panel1.Controls.Add(Me.cbxHiddenTable)
        Me.SplitContainer8.Panel1.Controls.Add(Me.btnDeleteDisplayMarker)
        Me.SplitContainer8.Panel1.Controls.Add(Me.btnAddDisplayMarker)
        Me.SplitContainer8.Panel1.Controls.Add(Me.DisplayTableMarkerDataGridView)
        Me.SplitContainer8.Panel1.Controls.Add(Me.btnDeleteDisplayTable)
        Me.SplitContainer8.Panel1.Controls.Add(Me.btnAddDisplayTable)
        Me.SplitContainer8.Panel1.Controls.Add(NoteLabel)
        Me.SplitContainer8.Panel1.Controls.Add(Me.NoteTextBox)
        Me.SplitContainer8.Panel1.Controls.Add(Me.RangeCheckBox)
        Me.SplitContainer8.Panel1.Controls.Add(Me.PercentileCheckBox)
        Me.SplitContainer8.Panel1.Controls.Add(Me.ScoreCheckBox)
        Me.SplitContainer8.Panel1.Controls.Add(Me.DisplayTableTitleTextBox)
        Me.SplitContainer8.Panel1.Controls.Add(FirstColumnHeaderLabel)
        Me.SplitContainer8.Panel1.Controls.Add(DisplayTableTitleLabel)
        Me.SplitContainer8.Panel1.Controls.Add(Me.FirstColumnHeaderTextBox)
        Me.SplitContainer8.Panel1.Controls.Add(Me.DisplayTableDataGridView)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.AutoScroll = True
        Me.SplitContainer8.Panel2.Controls.Add(Me.cbxAbbreviation)
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnMakeTable)
        Me.SplitContainer8.Panel2.Controls.Add(Label2)
        Me.SplitContainer8.Panel2.Controls.Add(Me.RangeNameComboBox)
        Me.SplitContainer8.Panel2.Controls.Add(Me.FullNameComboBox)
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnAddAllDisplayItems)
        Me.SplitContainer8.Panel2.Controls.Add(Me.cbxAllCaps)
        Me.SplitContainer8.Panel2.Controls.Add(Label1)
        Me.SplitContainer8.Panel2.Controls.Add(Me.cbxFont)
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnUnmarkItem)
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnMarkItem)
        Me.SplitContainer8.Panel2.Controls.Add(Me.DisplayTableItemMarkerDataGridView)
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnDownDisplayItem)
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnUpDisplayItem)
        Me.SplitContainer8.Panel2.Controls.Add(SizeLabel)
        Me.SplitContainer8.Panel2.Controls.Add(Me.SizeTextBox)
        Me.SplitContainer8.Panel2.Controls.Add(Me.BoldCheckBox)
        Me.SplitContainer8.Panel2.Controls.Add(Me.ItalicCheckBox)
        Me.SplitContainer8.Panel2.Controls.Add(LevelLabel)
        Me.SplitContainer8.Panel2.Controls.Add(Me.LevelListBox)
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnDeleteDisplayTableItem)
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnAddDisplayTableItem)
        Me.SplitContainer8.Panel2.Controls.Add(Me.DisplayTableItemDataGridView)
        Me.SplitContainer8.Size = New System.Drawing.Size(602, 534)
        Me.SplitContainer8.SplitterDistance = 240
        Me.SplitContainer8.TabIndex = 0
        '
        'cbxHiddenTable
        '
        Me.cbxHiddenTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxHiddenTable.AutoSize = True
        Me.cbxHiddenTable.Location = New System.Drawing.Point(161, 107)
        Me.cbxHiddenTable.Name = "cbxHiddenTable"
        Me.cbxHiddenTable.Size = New System.Drawing.Size(69, 21)
        Me.cbxHiddenTable.TabIndex = 15
        Me.cbxHiddenTable.Text = "Hidden"
        Me.cbxHiddenTable.UseVisualStyleBackColor = True
        '
        'btnDeleteDisplayMarker
        '
        Me.btnDeleteDisplayMarker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteDisplayMarker.Location = New System.Drawing.Point(123, 480)
        Me.btnDeleteDisplayMarker.Name = "btnDeleteDisplayMarker"
        Me.btnDeleteDisplayMarker.Size = New System.Drawing.Size(107, 34)
        Me.btnDeleteDisplayMarker.TabIndex = 14
        Me.btnDeleteDisplayMarker.Text = "Delete Marker"
        Me.btnDeleteDisplayMarker.UseVisualStyleBackColor = True
        '
        'btnAddDisplayMarker
        '
        Me.btnAddDisplayMarker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDisplayMarker.Location = New System.Drawing.Point(5, 480)
        Me.btnAddDisplayMarker.Name = "btnAddDisplayMarker"
        Me.btnAddDisplayMarker.Size = New System.Drawing.Size(113, 34)
        Me.btnAddDisplayMarker.TabIndex = 13
        Me.btnAddDisplayMarker.Text = "Add Marker"
        Me.btnAddDisplayMarker.UseVisualStyleBackColor = True
        '
        'DisplayTableMarkerDataGridView
        '
        Me.DisplayTableMarkerDataGridView.AllowUserToAddRows = False
        Me.DisplayTableMarkerDataGridView.AllowUserToDeleteRows = False
        Me.DisplayTableMarkerDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTableMarkerDataGridView.AutoGenerateColumns = False
        Me.DisplayTableMarkerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayTableMarkerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarkerSymbol, Me.DataGridViewTextBoxColumn17})
        Me.DisplayTableMarkerDataGridView.DataSource = Me.DisplayTableMarkerBindingSource
        Me.DisplayTableMarkerDataGridView.Location = New System.Drawing.Point(5, 392)
        Me.DisplayTableMarkerDataGridView.Name = "DisplayTableMarkerDataGridView"
        Me.DisplayTableMarkerDataGridView.Size = New System.Drawing.Size(225, 82)
        Me.DisplayTableMarkerDataGridView.TabIndex = 12
        '
        'MarkerSymbol
        '
        Me.MarkerSymbol.DataPropertyName = "MarkerSymbol"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MarkerSymbol.DefaultCellStyle = DataGridViewCellStyle4
        Me.MarkerSymbol.HeaderText = "Marker"
        Me.MarkerSymbol.MinimumWidth = 60
        Me.MarkerSymbol.Name = "MarkerSymbol"
        Me.MarkerSymbol.Width = 60
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "MarkerMeaning"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn17.HeaderText = "Marker Meaning"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DisplayTableMarkerBindingSource
        '
        Me.DisplayTableMarkerBindingSource.DataMember = "DisplayTableDisplayTableMarker"
        Me.DisplayTableMarkerBindingSource.DataSource = Me.DisplayTableBindingSource
        '
        'DisplayTableBindingSource
        '
        Me.DisplayTableBindingSource.AllowNew = False
        Me.DisplayTableBindingSource.DataMember = "DisplayTable"
        Me.DisplayTableBindingSource.DataSource = Me.tmDataSet
        '
        'btnDeleteDisplayTable
        '
        Me.btnDeleteDisplayTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteDisplayTable.Location = New System.Drawing.Point(123, 352)
        Me.btnDeleteDisplayTable.Name = "btnDeleteDisplayTable"
        Me.btnDeleteDisplayTable.Size = New System.Drawing.Size(107, 34)
        Me.btnDeleteDisplayTable.TabIndex = 11
        Me.btnDeleteDisplayTable.Text = "Delete Table"
        Me.btnDeleteDisplayTable.UseVisualStyleBackColor = True
        '
        'btnAddDisplayTable
        '
        Me.btnAddDisplayTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDisplayTable.Location = New System.Drawing.Point(5, 352)
        Me.btnAddDisplayTable.Name = "btnAddDisplayTable"
        Me.btnAddDisplayTable.Size = New System.Drawing.Size(113, 34)
        Me.btnAddDisplayTable.TabIndex = 10
        Me.btnAddDisplayTable.Text = "Add Table"
        Me.btnAddDisplayTable.UseVisualStyleBackColor = True
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DisplayTableBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(5, 298)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(225, 46)
        Me.NoteTextBox.TabIndex = 9
        '
        'RangeCheckBox
        '
        Me.RangeCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RangeCheckBox.AutoSize = True
        Me.RangeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DisplayTableBindingSource, "Range", True))
        Me.RangeCheckBox.Location = New System.Drawing.Point(168, 245)
        Me.RangeCheckBox.Name = "RangeCheckBox"
        Me.RangeCheckBox.Size = New System.Drawing.Size(64, 21)
        Me.RangeCheckBox.TabIndex = 8
        Me.RangeCheckBox.Text = "Range"
        Me.RangeCheckBox.UseVisualStyleBackColor = True
        '
        'PercentileCheckBox
        '
        Me.PercentileCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PercentileCheckBox.AutoSize = True
        Me.PercentileCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DisplayTableBindingSource, "Percentile", True))
        Me.PercentileCheckBox.Location = New System.Drawing.Point(76, 245)
        Me.PercentileCheckBox.Name = "PercentileCheckBox"
        Me.PercentileCheckBox.Size = New System.Drawing.Size(83, 21)
        Me.PercentileCheckBox.TabIndex = 7
        Me.PercentileCheckBox.Text = "Percentile"
        Me.PercentileCheckBox.UseVisualStyleBackColor = True
        '
        'ScoreCheckBox
        '
        Me.ScoreCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ScoreCheckBox.AutoSize = True
        Me.ScoreCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DisplayTableBindingSource, "Score", True))
        Me.ScoreCheckBox.Location = New System.Drawing.Point(5, 245)
        Me.ScoreCheckBox.Name = "ScoreCheckBox"
        Me.ScoreCheckBox.Size = New System.Drawing.Size(60, 21)
        Me.ScoreCheckBox.TabIndex = 6
        Me.ScoreCheckBox.Text = "Score"
        Me.ScoreCheckBox.UseVisualStyleBackColor = True
        '
        'DisplayTableTitleTextBox
        '
        Me.DisplayTableTitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTableTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DisplayTableBindingSource, "DisplayTableTitle", True))
        Me.DisplayTableTitleTextBox.Location = New System.Drawing.Point(5, 128)
        Me.DisplayTableTitleTextBox.Multiline = True
        Me.DisplayTableTitleTextBox.Name = "DisplayTableTitleTextBox"
        Me.DisplayTableTitleTextBox.Size = New System.Drawing.Size(225, 72)
        Me.DisplayTableTitleTextBox.TabIndex = 4
        '
        'FirstColumnHeaderTextBox
        '
        Me.FirstColumnHeaderTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirstColumnHeaderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DisplayTableBindingSource, "FirstColumnHeader", True))
        Me.FirstColumnHeaderTextBox.Location = New System.Drawing.Point(102, 207)
        Me.FirstColumnHeaderTextBox.Name = "FirstColumnHeaderTextBox"
        Me.FirstColumnHeaderTextBox.Size = New System.Drawing.Size(128, 25)
        Me.FirstColumnHeaderTextBox.TabIndex = 2
        '
        'DisplayTableDataGridView
        '
        Me.DisplayTableDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTableDataGridView.AutoGenerateColumns = False
        Me.DisplayTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.Hide})
        Me.DisplayTableDataGridView.DataSource = Me.DisplayTableBindingSource
        Me.DisplayTableDataGridView.Location = New System.Drawing.Point(5, 6)
        Me.DisplayTableDataGridView.Name = "DisplayTableDataGridView"
        Me.DisplayTableDataGridView.Size = New System.Drawing.Size(225, 99)
        Me.DisplayTableDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "DisplayTableName"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Table"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'Hide
        '
        Me.Hide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Hide.DataPropertyName = "Hide"
        Me.Hide.FillWeight = 50.0!
        Me.Hide.HeaderText = "Hide"
        Me.Hide.Name = "Hide"
        Me.Hide.Width = 41
        '
        'cbxAbbreviation
        '
        Me.cbxAbbreviation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxAbbreviation.AutoSize = True
        Me.cbxAbbreviation.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DisplayTableItemBindingSource, "Abbreviation", True))
        Me.cbxAbbreviation.Location = New System.Drawing.Point(69, 454)
        Me.cbxAbbreviation.Name = "cbxAbbreviation"
        Me.cbxAbbreviation.Size = New System.Drawing.Size(89, 21)
        Me.cbxAbbreviation.TabIndex = 50
        Me.cbxAbbreviation.Text = "Test Name"
        Me.cbxAbbreviation.UseVisualStyleBackColor = True
        '
        'DisplayTableItemBindingSource
        '
        Me.DisplayTableItemBindingSource.DataMember = "DisplayTableDisplayTableItem"
        Me.DisplayTableItemBindingSource.DataSource = Me.DisplayTableBindingSource
        '
        'btnMakeTable
        '
        Me.btnMakeTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMakeTable.ForeColor = System.Drawing.Color.Red
        Me.btnMakeTable.Location = New System.Drawing.Point(6, 38)
        Me.btnMakeTable.Name = "btnMakeTable"
        Me.btnMakeTable.Size = New System.Drawing.Size(143, 34)
        Me.btnMakeTable.TabIndex = 49
        Me.btnMakeTable.Text = "Make Word Tables"
        Me.btnMakeTable.UseVisualStyleBackColor = True
        '
        'RangeNameComboBox
        '
        Me.RangeNameComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RangeNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DisplayTableBindingSource, "RangeID", True))
        Me.RangeNameComboBox.DataSource = Me.RangeBindingSource
        Me.RangeNameComboBox.DisplayMember = "RangeName"
        Me.RangeNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RangeNameComboBox.FormattingEnabled = True
        Me.RangeNameComboBox.Location = New System.Drawing.Point(214, 38)
        Me.RangeNameComboBox.Name = "RangeNameComboBox"
        Me.RangeNameComboBox.Size = New System.Drawing.Size(137, 25)
        Me.RangeNameComboBox.TabIndex = 47
        Me.RangeNameComboBox.ValueMember = "RangeID"
        '
        'RangeBindingSource
        '
        Me.RangeBindingSource.AllowNew = False
        Me.RangeBindingSource.DataMember = "Range"
        Me.RangeBindingSource.DataSource = Me.tmDataSet
        '
        'FullNameComboBox
        '
        Me.FullNameComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "FullName", True))
        Me.FullNameComboBox.DataSource = Me.PersonBindingSource
        Me.FullNameComboBox.DisplayMember = "FullName"
        Me.FullNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FullNameComboBox.FormattingEnabled = True
        Me.FullNameComboBox.Location = New System.Drawing.Point(6, 6)
        Me.FullNameComboBox.Name = "FullNameComboBox"
        Me.FullNameComboBox.Size = New System.Drawing.Size(144, 25)
        Me.FullNameComboBox.TabIndex = 46
        '
        'btnAddAllDisplayItems
        '
        Me.btnAddAllDisplayItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAllDisplayItems.Location = New System.Drawing.Point(91, 480)
        Me.btnAddAllDisplayItems.Name = "btnAddAllDisplayItems"
        Me.btnAddAllDisplayItems.Size = New System.Drawing.Size(67, 34)
        Me.btnAddAllDisplayItems.TabIndex = 45
        Me.btnAddAllDisplayItems.Text = "Add All"
        Me.btnAddAllDisplayItems.UseVisualStyleBackColor = True
        '
        'cbxAllCaps
        '
        Me.cbxAllCaps.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxAllCaps.AutoSize = True
        Me.cbxAllCaps.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DisplayTableItemBindingSource, "AllCaps", True))
        Me.cbxAllCaps.Location = New System.Drawing.Point(68, 409)
        Me.cbxAllCaps.Name = "cbxAllCaps"
        Me.cbxAllCaps.Size = New System.Drawing.Size(74, 21)
        Me.cbxAllCaps.TabIndex = 44
        Me.cbxAllCaps.Text = "All Caps"
        Me.cbxAllCaps.UseVisualStyleBackColor = True
        '
        'cbxFont
        '
        Me.cbxFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFont.FormattingEnabled = True
        Me.cbxFont.Location = New System.Drawing.Point(214, 6)
        Me.cbxFont.Name = "cbxFont"
        Me.cbxFont.Size = New System.Drawing.Size(137, 25)
        Me.cbxFont.TabIndex = 42
        '
        'btnUnmarkItem
        '
        Me.btnUnmarkItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkItem.Location = New System.Drawing.Point(307, 480)
        Me.btnUnmarkItem.Name = "btnUnmarkItem"
        Me.btnUnmarkItem.Size = New System.Drawing.Size(44, 34)
        Me.btnUnmarkItem.TabIndex = 41
        Me.btnUnmarkItem.Text = "–"
        Me.btnUnmarkItem.UseVisualStyleBackColor = True
        '
        'btnMarkItem
        '
        Me.btnMarkItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMarkItem.Location = New System.Drawing.Point(256, 480)
        Me.btnMarkItem.Name = "btnMarkItem"
        Me.btnMarkItem.Size = New System.Drawing.Size(44, 34)
        Me.btnMarkItem.TabIndex = 40
        Me.btnMarkItem.Text = "+"
        Me.btnMarkItem.UseVisualStyleBackColor = True
        '
        'DisplayTableItemMarkerDataGridView
        '
        Me.DisplayTableItemMarkerDataGridView.AllowUserToAddRows = False
        Me.DisplayTableItemMarkerDataGridView.AllowUserToDeleteRows = False
        Me.DisplayTableItemMarkerDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTableItemMarkerDataGridView.AutoGenerateColumns = False
        Me.DisplayTableItemMarkerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayTableItemMarkerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DisplayTableMarkerID, Me.DisplayTableItemMarkerIDDataGridViewTextBoxColumn})
        Me.DisplayTableItemMarkerDataGridView.DataSource = Me.DisplayTableItemMarkerBindingSource
        Me.DisplayTableItemMarkerDataGridView.Location = New System.Drawing.Point(256, 364)
        Me.DisplayTableItemMarkerDataGridView.Name = "DisplayTableItemMarkerDataGridView"
        Me.DisplayTableItemMarkerDataGridView.Size = New System.Drawing.Size(94, 109)
        Me.DisplayTableItemMarkerDataGridView.TabIndex = 39
        '
        'DisplayTableMarkerID
        '
        Me.DisplayTableMarkerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DisplayTableMarkerID.DataPropertyName = "DisplayTableMarkerID"
        Me.DisplayTableMarkerID.DataSource = Me.DisplayTableMarkerBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DisplayTableMarkerID.DefaultCellStyle = DataGridViewCellStyle6
        Me.DisplayTableMarkerID.DisplayMember = "MarkerSymbol"
        Me.DisplayTableMarkerID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DisplayTableMarkerID.HeaderText = "Marker"
        Me.DisplayTableMarkerID.Name = "DisplayTableMarkerID"
        Me.DisplayTableMarkerID.ReadOnly = True
        Me.DisplayTableMarkerID.ValueMember = "DisplayTableMarkerID"
        '
        'DisplayTableItemMarkerIDDataGridViewTextBoxColumn
        '
        Me.DisplayTableItemMarkerIDDataGridViewTextBoxColumn.DataPropertyName = "DisplayTableItemMarkerID"
        Me.DisplayTableItemMarkerIDDataGridViewTextBoxColumn.HeaderText = "DisplayTableItemMarkerID"
        Me.DisplayTableItemMarkerIDDataGridViewTextBoxColumn.Name = "DisplayTableItemMarkerIDDataGridViewTextBoxColumn"
        Me.DisplayTableItemMarkerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DisplayTableItemMarkerIDDataGridViewTextBoxColumn.Visible = False
        '
        'DisplayTableItemMarkerBindingSource
        '
        Me.DisplayTableItemMarkerBindingSource.DataMember = "DisplayTableItemDisplayTableItemMarker"
        Me.DisplayTableItemMarkerBindingSource.DataSource = Me.DisplayTableItemBindingSource
        '
        'btnDownDisplayItem
        '
        Me.btnDownDisplayItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDownDisplayItem.Image = CType(resources.GetObject("btnDownDisplayItem.Image"), System.Drawing.Image)
        Me.btnDownDisplayItem.Location = New System.Drawing.Point(220, 421)
        Me.btnDownDisplayItem.Name = "btnDownDisplayItem"
        Me.btnDownDisplayItem.Size = New System.Drawing.Size(31, 53)
        Me.btnDownDisplayItem.TabIndex = 39
        '
        'btnUpDisplayItem
        '
        Me.btnUpDisplayItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpDisplayItem.Image = CType(resources.GetObject("btnUpDisplayItem.Image"), System.Drawing.Image)
        Me.btnUpDisplayItem.Location = New System.Drawing.Point(220, 364)
        Me.btnUpDisplayItem.Name = "btnUpDisplayItem"
        Me.btnUpDisplayItem.Size = New System.Drawing.Size(31, 53)
        Me.btnUpDisplayItem.TabIndex = 38
        '
        'SizeTextBox
        '
        Me.SizeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DisplayTableItemBindingSource, "Size", True))
        Me.SizeTextBox.Location = New System.Drawing.Point(51, 361)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.Size = New System.Drawing.Size(42, 25)
        Me.SizeTextBox.TabIndex = 18
        '
        'BoldCheckBox
        '
        Me.BoldCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BoldCheckBox.AutoSize = True
        Me.BoldCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DisplayTableItemBindingSource, "Bold", True))
        Me.BoldCheckBox.Location = New System.Drawing.Point(6, 409)
        Me.BoldCheckBox.Name = "BoldCheckBox"
        Me.BoldCheckBox.Size = New System.Drawing.Size(53, 21)
        Me.BoldCheckBox.TabIndex = 16
        Me.BoldCheckBox.Text = "Bold"
        Me.BoldCheckBox.UseVisualStyleBackColor = True
        '
        'ItalicCheckBox
        '
        Me.ItalicCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ItalicCheckBox.AutoSize = True
        Me.ItalicCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DisplayTableItemBindingSource, "Italic", True))
        Me.ItalicCheckBox.Location = New System.Drawing.Point(6, 454)
        Me.ItalicCheckBox.Name = "ItalicCheckBox"
        Me.ItalicCheckBox.Size = New System.Drawing.Size(53, 21)
        Me.ItalicCheckBox.TabIndex = 15
        Me.ItalicCheckBox.Text = "Italic"
        Me.ItalicCheckBox.UseVisualStyleBackColor = True
        '
        'LevelListBox
        '
        Me.LevelListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LevelListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedIndex", Me.DisplayTableItemBindingSource, "Level", True))
        Me.LevelListBox.FormattingEnabled = True
        Me.LevelListBox.ItemHeight = 17
        Me.LevelListBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.LevelListBox.Location = New System.Drawing.Point(187, 364)
        Me.LevelListBox.Name = "LevelListBox"
        Me.LevelListBox.Size = New System.Drawing.Size(28, 106)
        Me.LevelListBox.TabIndex = 14
        '
        'btnDeleteDisplayTableItem
        '
        Me.btnDeleteDisplayTableItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteDisplayTableItem.Location = New System.Drawing.Point(164, 480)
        Me.btnDeleteDisplayTableItem.Name = "btnDeleteDisplayTableItem"
        Me.btnDeleteDisplayTableItem.Size = New System.Drawing.Size(87, 34)
        Me.btnDeleteDisplayTableItem.TabIndex = 13
        Me.btnDeleteDisplayTableItem.Text = "Delete Item"
        Me.btnDeleteDisplayTableItem.UseVisualStyleBackColor = True
        '
        'btnAddDisplayTableItem
        '
        Me.btnAddDisplayTableItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDisplayTableItem.Location = New System.Drawing.Point(6, 480)
        Me.btnAddDisplayTableItem.Name = "btnAddDisplayTableItem"
        Me.btnAddDisplayTableItem.Size = New System.Drawing.Size(79, 34)
        Me.btnAddDisplayTableItem.TabIndex = 12
        Me.btnAddDisplayTableItem.Text = "Add Item"
        Me.btnAddDisplayTableItem.UseVisualStyleBackColor = True
        '
        'DisplayTableItemDataGridView
        '
        Me.DisplayTableItemDataGridView.AllowUserToAddRows = False
        Me.DisplayTableItemDataGridView.AllowUserToDeleteRows = False
        Me.DisplayTableItemDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTableItemDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DisplayTableItemDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DisplayTableItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayTableItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marker, Me.DisplayItemScore, Me.PercentileColumn, Me.RangeColumn, Me.DisplayTableItemIDDataGridViewTextBoxColumn})
        Me.DisplayTableItemDataGridView.DataSource = Me.DisplayTableItemBindingSource
        Me.DisplayTableItemDataGridView.Location = New System.Drawing.Point(6, 79)
        Me.DisplayTableItemDataGridView.Name = "DisplayTableItemDataGridView"
        Me.DisplayTableItemDataGridView.Size = New System.Drawing.Size(345, 267)
        Me.DisplayTableItemDataGridView.TabIndex = 0
        '
        'Marker
        '
        Me.Marker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Marker.DefaultCellStyle = DataGridViewCellStyle8
        Me.Marker.HeaderText = "Scale"
        Me.Marker.Name = "Marker"
        Me.Marker.ReadOnly = True
        '
        'DisplayItemScore
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DisplayItemScore.DefaultCellStyle = DataGridViewCellStyle9
        Me.DisplayItemScore.HeaderText = "Score"
        Me.DisplayItemScore.MinimumWidth = 70
        Me.DisplayItemScore.Name = "DisplayItemScore"
        Me.DisplayItemScore.ReadOnly = True
        Me.DisplayItemScore.Width = 70
        '
        'PercentileColumn
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PercentileColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.PercentileColumn.HeaderText = "%tile"
        Me.PercentileColumn.MinimumWidth = 60
        Me.PercentileColumn.Name = "PercentileColumn"
        Me.PercentileColumn.ReadOnly = True
        Me.PercentileColumn.Width = 60
        '
        'RangeColumn
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.RangeColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.RangeColumn.HeaderText = "Range"
        Me.RangeColumn.MinimumWidth = 130
        Me.RangeColumn.Name = "RangeColumn"
        Me.RangeColumn.ReadOnly = True
        Me.RangeColumn.Width = 130
        '
        'DisplayTableItemIDDataGridViewTextBoxColumn
        '
        Me.DisplayTableItemIDDataGridViewTextBoxColumn.DataPropertyName = "DisplayTableItemID"
        Me.DisplayTableItemIDDataGridViewTextBoxColumn.HeaderText = "DisplayTableItemID"
        Me.DisplayTableItemIDDataGridViewTextBoxColumn.Name = "DisplayTableItemIDDataGridViewTextBoxColumn"
        Me.DisplayTableItemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DisplayTableItemIDDataGridViewTextBoxColumn.Visible = False
        '
        'SplitContainer7
        '
        Me.SplitContainer7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        Me.SplitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.AutoScroll = True
        Me.SplitContainer7.Panel1.Controls.Add(Me.BatteryDataGridView2)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.AutoScroll = True
        Me.SplitContainer7.Panel2.Controls.Add(Me.scTableScale)
        Me.SplitContainer7.Size = New System.Drawing.Size(202, 534)
        Me.SplitContainer7.SplitterDistance = 219
        Me.SplitContainer7.TabIndex = 0
        '
        'BatteryDataGridView2
        '
        Me.BatteryDataGridView2.AutoGenerateColumns = False
        Me.BatteryDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatteryDataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13})
        Me.BatteryDataGridView2.DataSource = Me.BatteryBindingSource
        Me.BatteryDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryDataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.BatteryDataGridView2.Name = "BatteryDataGridView2"
        Me.BatteryDataGridView2.Size = New System.Drawing.Size(198, 215)
        Me.BatteryDataGridView2.TabIndex = 0
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "BatteryName"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Test"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'scTableScale
        '
        Me.scTableScale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.scTableScale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scTableScale.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.scTableScale.Location = New System.Drawing.Point(0, 0)
        Me.scTableScale.Name = "scTableScale"
        Me.scTableScale.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scTableScale.Panel1
        '
        Me.scTableScale.Panel1.Controls.Add(Me.ScaleDataGridView1)
        '
        'scTableScale.Panel2
        '
        Me.scTableScale.Panel2.AutoScroll = True
        Me.scTableScale.Panel2.Controls.Add(Me.PersonBatteryListBox)
        Me.scTableScale.Size = New System.Drawing.Size(202, 311)
        Me.scTableScale.SplitterDistance = 266
        Me.scTableScale.TabIndex = 1
        '
        'ScaleDataGridView1
        '
        Me.ScaleDataGridView1.AllowUserToAddRows = False
        Me.ScaleDataGridView1.AllowUserToDeleteRows = False
        Me.ScaleDataGridView1.AutoGenerateColumns = False
        Me.ScaleDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScaleDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.ScoreTypeIDDataGridViewTextBoxColumn})
        Me.ScaleDataGridView1.DataSource = Me.ScaleBindingSource
        Me.ScaleDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScaleDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.ScaleDataGridView1.Name = "ScaleDataGridView1"
        Me.ScaleDataGridView1.Size = New System.Drawing.Size(198, 262)
        Me.ScaleDataGridView1.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "ScaleID"
        Me.Column2.DataSource = Me.ScaleBindingSource1
        Me.Column2.DisplayMember = "ScaleName"
        Me.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column2.HeaderText = "Scale"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.ValueMember = "ScaleID"
        '
        'ScoreTypeIDDataGridViewTextBoxColumn
        '
        Me.ScoreTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ScoreTypeID"
        Me.ScoreTypeIDDataGridViewTextBoxColumn.HeaderText = "ScoreTypeID"
        Me.ScoreTypeIDDataGridViewTextBoxColumn.Name = "ScoreTypeIDDataGridViewTextBoxColumn"
        Me.ScoreTypeIDDataGridViewTextBoxColumn.Visible = False
        '
        'ScaleBindingSource
        '
        Me.ScaleBindingSource.DataMember = "BatteryScale"
        Me.ScaleBindingSource.DataSource = Me.BatteryBindingSource
        '
        'PersonBatteryListBox
        '
        Me.PersonBatteryListBox.DataSource = Me.FilteredPersonBatteryBindingSource
        Me.PersonBatteryListBox.DisplayMember = "AdministrationDate"
        Me.PersonBatteryListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonBatteryListBox.FormatString = "d"
        Me.PersonBatteryListBox.FormattingEnabled = True
        Me.PersonBatteryListBox.ItemHeight = 17
        Me.PersonBatteryListBox.Location = New System.Drawing.Point(0, 0)
        Me.PersonBatteryListBox.Name = "PersonBatteryListBox"
        Me.PersonBatteryListBox.Size = New System.Drawing.Size(198, 37)
        Me.PersonBatteryListBox.TabIndex = 0
        Me.PersonBatteryListBox.ValueMember = "PersonBatteryID"
        '
        'FilteredPersonBatteryBindingSource
        '
        Me.FilteredPersonBatteryBindingSource.DataMember = "PersonPersonBattery"
        Me.FilteredPersonBatteryBindingSource.DataSource = Me.PersonBindingSource
        '
        'tpBattery
        '
        Me.tpBattery.AutoScroll = True
        Me.tpBattery.Controls.Add(Me.SplitContainer4)
        Me.tpBattery.Location = New System.Drawing.Point(4, 26)
        Me.tpBattery.Margin = New System.Windows.Forms.Padding(4)
        Me.tpBattery.Name = "tpBattery"
        Me.tpBattery.Padding = New System.Windows.Forms.Padding(4)
        Me.tpBattery.Size = New System.Drawing.Size(814, 540)
        Me.tpBattery.TabIndex = 1
        Me.tpBattery.Text = "Tests"
        Me.tpBattery.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.cbxHide)
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnDeleteBattery)
        Me.SplitContainer4.Panel1.Controls.Add(Me.BatteryDataGridView1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnAddBattery)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.btnDownScale)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btnUpScale)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btnDeleteScale)
        Me.SplitContainer4.Panel2.Controls.Add(Me.ScaleDataGridView)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btnAddScale)
        Me.SplitContainer4.Size = New System.Drawing.Size(806, 532)
        Me.SplitContainer4.SplitterDistance = 347
        Me.SplitContainer4.TabIndex = 11
        '
        'cbxHide
        '
        Me.cbxHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxHide.AutoSize = True
        Me.cbxHide.Location = New System.Drawing.Point(272, 485)
        Me.cbxHide.Name = "cbxHide"
        Me.cbxHide.Size = New System.Drawing.Size(69, 21)
        Me.cbxHide.TabIndex = 9
        Me.cbxHide.Text = "Hidden"
        Me.cbxHide.UseVisualStyleBackColor = True
        '
        'btnDeleteBattery
        '
        Me.btnDeleteBattery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteBattery.Location = New System.Drawing.Point(138, 478)
        Me.btnDeleteBattery.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteBattery.Name = "btnDeleteBattery"
        Me.btnDeleteBattery.Size = New System.Drawing.Size(128, 34)
        Me.btnDeleteBattery.TabIndex = 8
        Me.btnDeleteBattery.Text = "Delete Test"
        Me.btnDeleteBattery.UseVisualStyleBackColor = True
        '
        'BatteryDataGridView1
        '
        Me.BatteryDataGridView1.AllowUserToAddRows = False
        Me.BatteryDataGridView1.AllowUserToDeleteRows = False
        Me.BatteryDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BatteryDataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BatteryDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.BatteryDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatteryDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Abbreviation, Me.HideBattery})
        Me.BatteryDataGridView1.DataSource = Me.BatteryBindingSource
        Me.BatteryDataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.BatteryDataGridView1.Name = "BatteryDataGridView1"
        Me.BatteryDataGridView1.Size = New System.Drawing.Size(336, 468)
        Me.BatteryDataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "BatteryName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Test"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Abbreviation
        '
        Me.Abbreviation.DataPropertyName = "Abbreviation"
        Me.Abbreviation.HeaderText = "Abbreviation"
        Me.Abbreviation.Name = "Abbreviation"
        '
        'HideBattery
        '
        Me.HideBattery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HideBattery.DataPropertyName = "HideBattery"
        Me.HideBattery.HeaderText = "Hide"
        Me.HideBattery.Name = "HideBattery"
        Me.HideBattery.Width = 41
        '
        'btnAddBattery
        '
        Me.btnAddBattery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddBattery.Location = New System.Drawing.Point(4, 478)
        Me.btnAddBattery.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddBattery.Name = "btnAddBattery"
        Me.btnAddBattery.Size = New System.Drawing.Size(128, 34)
        Me.btnAddBattery.TabIndex = 7
        Me.btnAddBattery.Text = "Add Test"
        Me.btnAddBattery.UseVisualStyleBackColor = True
        '
        'btnDownScale
        '
        Me.btnDownScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDownScale.Image = CType(resources.GetObject("btnDownScale.Image"), System.Drawing.Image)
        Me.btnDownScale.Location = New System.Drawing.Point(307, 478)
        Me.btnDownScale.Name = "btnDownScale"
        Me.btnDownScale.Size = New System.Drawing.Size(31, 34)
        Me.btnDownScale.TabIndex = 37
        '
        'btnUpScale
        '
        Me.btnUpScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpScale.Image = CType(resources.GetObject("btnUpScale.Image"), System.Drawing.Image)
        Me.btnUpScale.Location = New System.Drawing.Point(271, 478)
        Me.btnUpScale.Name = "btnUpScale"
        Me.btnUpScale.Size = New System.Drawing.Size(31, 34)
        Me.btnUpScale.TabIndex = 36
        '
        'btnDeleteScale
        '
        Me.btnDeleteScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteScale.Location = New System.Drawing.Point(137, 478)
        Me.btnDeleteScale.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteScale.Name = "btnDeleteScale"
        Me.btnDeleteScale.Size = New System.Drawing.Size(128, 34)
        Me.btnDeleteScale.TabIndex = 10
        Me.btnDeleteScale.Text = "Delete Test"
        Me.btnDeleteScale.UseVisualStyleBackColor = True
        '
        'ScaleDataGridView
        '
        Me.ScaleDataGridView.AllowUserToAddRows = False
        Me.ScaleDataGridView.AllowUserToDeleteRows = False
        Me.ScaleDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScaleDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ScaleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.ScaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScaleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.ScoreTypeID, Me.Level})
        Me.ScaleDataGridView.DataSource = Me.ScaleBindingSource
        Me.ScaleDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ScaleDataGridView.Name = "ScaleDataGridView"
        Me.ScaleDataGridView.Size = New System.Drawing.Size(442, 468)
        Me.ScaleDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ScaleName"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn5.HeaderText = "Scale"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ScoreTypeID
        '
        Me.ScoreTypeID.DataPropertyName = "ScoreTypeID"
        Me.ScoreTypeID.DataSource = Me.ScoreTypeBindingSource
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ScoreTypeID.DefaultCellStyle = DataGridViewCellStyle15
        Me.ScoreTypeID.DisplayMember = "ScoreTypeName"
        Me.ScoreTypeID.DisplayStyleForCurrentCellOnly = True
        Me.ScoreTypeID.HeaderText = "Score Type"
        Me.ScoreTypeID.MinimumWidth = 130
        Me.ScoreTypeID.Name = "ScoreTypeID"
        Me.ScoreTypeID.ValueMember = "ScoreTypeID"
        Me.ScoreTypeID.Width = 130
        '
        'ScoreTypeBindingSource
        '
        Me.ScoreTypeBindingSource.AllowNew = False
        Me.ScoreTypeBindingSource.DataMember = "ScoreType"
        Me.ScoreTypeBindingSource.DataSource = Me.tmDataSet
        '
        'Level
        '
        Me.Level.DataPropertyName = "Level"
        Me.Level.DataSource = Me.ScaleTypeBindingSource
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Level.DefaultCellStyle = DataGridViewCellStyle16
        Me.Level.DisplayMember = "ScaleTypeName"
        Me.Level.DisplayStyleForCurrentCellOnly = True
        Me.Level.HeaderText = "Scale Type"
        Me.Level.MinimumWidth = 120
        Me.Level.Name = "Level"
        Me.Level.ValueMember = "ScaleTypeID"
        Me.Level.Width = 120
        '
        'ScaleTypeBindingSource
        '
        Me.ScaleTypeBindingSource.DataMember = "ScaleType"
        Me.ScaleTypeBindingSource.DataSource = Me.tmDataSet
        '
        'btnAddScale
        '
        Me.btnAddScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddScale.Location = New System.Drawing.Point(3, 478)
        Me.btnAddScale.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddScale.Name = "btnAddScale"
        Me.btnAddScale.Size = New System.Drawing.Size(128, 34)
        Me.btnAddScale.TabIndex = 9
        Me.btnAddScale.Text = "Add Scale"
        Me.btnAddScale.UseVisualStyleBackColor = True
        '
        'tpRangeLabel
        '
        Me.tpRangeLabel.Controls.Add(Me.SplitContainer5)
        Me.tpRangeLabel.Location = New System.Drawing.Point(4, 26)
        Me.tpRangeLabel.Name = "tpRangeLabel"
        Me.tpRangeLabel.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRangeLabel.Size = New System.Drawing.Size(814, 540)
        Me.tpRangeLabel.TabIndex = 4
        Me.tpRangeLabel.Text = "Range Labels"
        Me.tpRangeLabel.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.SplitContainer9)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.btnDeleteRangeLabel)
        Me.SplitContainer5.Panel2.Controls.Add(Me.btnAddRangeLabel)
        Me.SplitContainer5.Panel2.Controls.Add(Me.RangeLabelDataGridView)
        Me.SplitContainer5.Size = New System.Drawing.Size(808, 534)
        Me.SplitContainer5.SplitterDistance = 336
        Me.SplitContainer5.TabIndex = 0
        '
        'SplitContainer9
        '
        Me.SplitContainer9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer9.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer9.Name = "SplitContainer9"
        Me.SplitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer9.Panel1
        '
        Me.SplitContainer9.Panel1.AutoScroll = True
        Me.SplitContainer9.Panel1.Controls.Add(Me.btnDeleteRange)
        Me.SplitContainer9.Panel1.Controls.Add(Me.btnAddRange)
        Me.SplitContainer9.Panel1.Controls.Add(Me.RangeDataGridView)
        '
        'SplitContainer9.Panel2
        '
        Me.SplitContainer9.Panel2.Controls.Add(Me.ScoreTypeDataGridView)
        Me.SplitContainer9.Panel2.Controls.Add(Me.btnDeleteScoreType)
        Me.SplitContainer9.Panel2.Controls.Add(Me.btnAddScoreType)
        Me.SplitContainer9.Size = New System.Drawing.Size(336, 534)
        Me.SplitContainer9.SplitterDistance = 241
        Me.SplitContainer9.TabIndex = 0
        '
        'btnDeleteRange
        '
        Me.btnDeleteRange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteRange.Location = New System.Drawing.Point(200, 192)
        Me.btnDeleteRange.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteRange.Name = "btnDeleteRange"
        Me.btnDeleteRange.Size = New System.Drawing.Size(128, 34)
        Me.btnDeleteRange.TabIndex = 14
        Me.btnDeleteRange.Text = "Delete Range"
        Me.btnDeleteRange.UseVisualStyleBackColor = True
        '
        'btnAddRange
        '
        Me.btnAddRange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddRange.Location = New System.Drawing.Point(4, 192)
        Me.btnAddRange.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddRange.Name = "btnAddRange"
        Me.btnAddRange.Size = New System.Drawing.Size(190, 34)
        Me.btnAddRange.TabIndex = 13
        Me.btnAddRange.Text = "Add Range"
        Me.btnAddRange.UseVisualStyleBackColor = True
        '
        'RangeDataGridView
        '
        Me.RangeDataGridView.AllowUserToAddRows = False
        Me.RangeDataGridView.AllowUserToDeleteRows = False
        Me.RangeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RangeDataGridView.AutoGenerateColumns = False
        Me.RangeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RangeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11})
        Me.RangeDataGridView.DataSource = Me.RangeBindingSource
        Me.RangeDataGridView.Location = New System.Drawing.Point(4, 3)
        Me.RangeDataGridView.Name = "RangeDataGridView"
        Me.RangeDataGridView.Size = New System.Drawing.Size(324, 183)
        Me.RangeDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "RangeName"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Range"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'ScoreTypeDataGridView
        '
        Me.ScoreTypeDataGridView.AllowUserToAddRows = False
        Me.ScoreTypeDataGridView.AllowUserToDeleteRows = False
        Me.ScoreTypeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScoreTypeDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ScoreTypeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.ScoreTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScoreTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.StandardScore, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.ScoreTypeDataGridView.DataSource = Me.ScoreTypeBindingSource
        Me.ScoreTypeDataGridView.Location = New System.Drawing.Point(4, 3)
        Me.ScoreTypeDataGridView.Name = "ScoreTypeDataGridView"
        Me.ScoreTypeDataGridView.Size = New System.Drawing.Size(324, 228)
        Me.ScoreTypeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ScoreTypeName"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn8.HeaderText = "Score Type"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'StandardScore
        '
        Me.StandardScore.DataPropertyName = "StandardScore"
        Me.StandardScore.HeaderText = "Standard Score"
        Me.StandardScore.MinimumWidth = 120
        Me.StandardScore.Name = "StandardScore"
        Me.StandardScore.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Mean"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mean"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SD"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn10.HeaderText = "SD"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'btnDeleteScoreType
        '
        Me.btnDeleteScoreType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteScoreType.Location = New System.Drawing.Point(200, 239)
        Me.btnDeleteScoreType.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteScoreType.Name = "btnDeleteScoreType"
        Me.btnDeleteScoreType.Size = New System.Drawing.Size(128, 34)
        Me.btnDeleteScoreType.TabIndex = 12
        Me.btnDeleteScoreType.Text = "Delete ScoreType"
        Me.btnDeleteScoreType.UseVisualStyleBackColor = True
        '
        'btnAddScoreType
        '
        Me.btnAddScoreType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddScoreType.Location = New System.Drawing.Point(4, 239)
        Me.btnAddScoreType.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddScoreType.Name = "btnAddScoreType"
        Me.btnAddScoreType.Size = New System.Drawing.Size(190, 34)
        Me.btnAddScoreType.TabIndex = 11
        Me.btnAddScoreType.Text = "Add Score Type"
        Me.btnAddScoreType.UseVisualStyleBackColor = True
        '
        'btnDeleteRangeLabel
        '
        Me.btnDeleteRangeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteRangeLabel.Location = New System.Drawing.Point(330, 479)
        Me.btnDeleteRangeLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteRangeLabel.Name = "btnDeleteRangeLabel"
        Me.btnDeleteRangeLabel.Size = New System.Drawing.Size(128, 34)
        Me.btnDeleteRangeLabel.TabIndex = 14
        Me.btnDeleteRangeLabel.Text = "Delete Range Label"
        Me.btnDeleteRangeLabel.UseVisualStyleBackColor = True
        '
        'btnAddRangeLabel
        '
        Me.btnAddRangeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddRangeLabel.Location = New System.Drawing.Point(4, 479)
        Me.btnAddRangeLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddRangeLabel.Name = "btnAddRangeLabel"
        Me.btnAddRangeLabel.Size = New System.Drawing.Size(319, 34)
        Me.btnAddRangeLabel.TabIndex = 13
        Me.btnAddRangeLabel.Text = "Add Range Label"
        Me.btnAddRangeLabel.UseVisualStyleBackColor = True
        '
        'RangeLabelDataGridView
        '
        Me.RangeLabelDataGridView.AllowUserToAddRows = False
        Me.RangeLabelDataGridView.AllowUserToDeleteRows = False
        Me.RangeLabelDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RangeLabelDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RangeLabelDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.RangeLabelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RangeLabelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn19, Me.Upperbound})
        Me.RangeLabelDataGridView.DataSource = Me.RangeLabelBindingSource
        Me.RangeLabelDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.RangeLabelDataGridView.Name = "RangeLabelDataGridView"
        Me.RangeLabelDataGridView.Size = New System.Drawing.Size(456, 468)
        Me.RangeLabelDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "RangeLabel"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn12.HeaderText = "Range Label"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "LowerBound"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn19.HeaderText = "Lower Bound"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 120
        '
        'Upperbound
        '
        Me.Upperbound.DataPropertyName = "Upperbound"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Upperbound.DefaultCellStyle = DataGridViewCellStyle24
        Me.Upperbound.HeaderText = "Upperbound"
        Me.Upperbound.Name = "Upperbound"
        '
        'RangeLabelBindingSource
        '
        Me.RangeLabelBindingSource.DataMember = "RangeRangeLabel"
        Me.RangeLabelBindingSource.DataSource = Me.RangeBindingSource
        '
        'tpImportExport
        '
        Me.tpImportExport.Controls.Add(Me.Label3)
        Me.tpImportExport.Controls.Add(Me.btnImportData)
        Me.tpImportExport.Controls.Add(Me.btnSaveAllData)
        Me.tpImportExport.Location = New System.Drawing.Point(4, 26)
        Me.tpImportExport.Name = "tpImportExport"
        Me.tpImportExport.Padding = New System.Windows.Forms.Padding(3)
        Me.tpImportExport.Size = New System.Drawing.Size(814, 540)
        Me.tpImportExport.TabIndex = 5
        Me.tpImportExport.Text = "Import/Export"
        Me.tpImportExport.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(802, 478)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'btnImportData
        '
        Me.btnImportData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportData.Location = New System.Drawing.Point(203, 6)
        Me.btnImportData.Name = "btnImportData"
        Me.btnImportData.Size = New System.Drawing.Size(187, 46)
        Me.btnImportData.TabIndex = 1
        Me.btnImportData.Text = "Import Data"
        Me.btnImportData.UseVisualStyleBackColor = True
        '
        'btnSaveAllData
        '
        Me.btnSaveAllData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAllData.Location = New System.Drawing.Point(7, 6)
        Me.btnSaveAllData.Name = "btnSaveAllData"
        Me.btnSaveAllData.Size = New System.Drawing.Size(187, 46)
        Me.btnSaveAllData.TabIndex = 0
        Me.btnSaveAllData.Text = "Export Data"
        Me.btnSaveAllData.UseVisualStyleBackColor = True
        '
        'PersonBatteryAdministrationBindingSource
        '
        Me.PersonBatteryAdministrationBindingSource.DataMember = "PersonPersonBatteryAdministration"
        Me.PersonBatteryAdministrationBindingSource.DataSource = Me.PersonBindingSource
        '
        'DisplayTableItemScoreBindingSource
        '
        Me.DisplayTableItemScoreBindingSource.DataMember = "DisplayTableDisplayTableItem"
        Me.DisplayTableItemScoreBindingSource.DataSource = Me.DisplayTableBindingSource
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatteryTableAdapter = Me.BatteryTableAdapter
        Me.TableAdapterManager.DisplayTableItemMarkerTableAdapter = Me.DisplayTableItemMarkerTableAdapter
        Me.TableAdapterManager.DisplayTableItemTableAdapter = Me.DisplayTableItemTableAdapter
        Me.TableAdapterManager.DisplayTableMarkerTableAdapter = Me.DisplayTableMarkerTableAdapter
        Me.TableAdapterManager.DisplayTableTableAdapter = Me.DisplayTableTableAdapter
        Me.TableAdapterManager.PersonBatteryAdministrationTableAdapter = Me.PersonBatteryAdministrationTableAdapter
        Me.TableAdapterManager.PersonBatteryScaleTableAdapter = Me.PersonBatteryScaleTableAdapter
        Me.TableAdapterManager.PersonBatteryTableAdapter = Me.PersonBatteryTableAdapter
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.RangeLabelTableAdapter = Me.RangeLabelTableAdapter
        Me.TableAdapterManager.RangeTableAdapter = Me.RangeTableAdapter
        Me.TableAdapterManager.ReportItemTableAdapter = Nothing
        Me.TableAdapterManager.ReportTableAdapter = Nothing
        Me.TableAdapterManager.ScaleTableAdapter = Me.ScaleTableAdapter
        Me.TableAdapterManager.ScoreTypeTableAdapter = Me.ScoreTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BatteryTableAdapter
        '
        Me.BatteryTableAdapter.ClearBeforeFill = True
        '
        'DisplayTableItemMarkerTableAdapter
        '
        Me.DisplayTableItemMarkerTableAdapter.ClearBeforeFill = True
        '
        'DisplayTableItemTableAdapter
        '
        Me.DisplayTableItemTableAdapter.ClearBeforeFill = True
        '
        'DisplayTableMarkerTableAdapter
        '
        Me.DisplayTableMarkerTableAdapter.ClearBeforeFill = True
        '
        'DisplayTableTableAdapter
        '
        Me.DisplayTableTableAdapter.ClearBeforeFill = True
        '
        'PersonBatteryAdministrationTableAdapter
        '
        Me.PersonBatteryAdministrationTableAdapter.ClearBeforeFill = True
        '
        'PersonBatteryScaleTableAdapter
        '
        Me.PersonBatteryScaleTableAdapter.ClearBeforeFill = True
        '
        'PersonBatteryTableAdapter
        '
        Me.PersonBatteryTableAdapter.ClearBeforeFill = True
        '
        'RangeLabelTableAdapter
        '
        Me.RangeLabelTableAdapter.ClearBeforeFill = True
        '
        'RangeTableAdapter
        '
        Me.RangeTableAdapter.ClearBeforeFill = True
        '
        'ScaleTableAdapter
        '
        Me.ScaleTableAdapter.ClearBeforeFill = True
        '
        'ScoreTypeTableAdapter
        '
        Me.ScoreTypeTableAdapter.ClearBeforeFill = True
        '
        'DisplayTableItemScoreTableAdapter
        '
        Me.DisplayTableItemScoreTableAdapter.ClearBeforeFill = True
        '
        'PersonBatteryBindingSource1
        '
        Me.PersonBatteryBindingSource1.DataMember = "PersonPersonBattery"
        Me.PersonBatteryBindingSource1.DataSource = Me.PersonBindingSource
        '
        'PersonBatteryBindingSource2
        '
        Me.PersonBatteryBindingSource2.DataMember = "PersonPersonBattery"
        Me.PersonBatteryBindingSource2.DataSource = Me.PersonBindingSource
        '
        'ReportBindingSource
        '
        Me.ReportBindingSource.AllowNew = False
        Me.ReportBindingSource.DataMember = "Report"
        Me.ReportBindingSource.DataSource = Me.tmDataSet
        '
        'ReportTableAdapter
        '
        Me.ReportTableAdapter.ClearBeforeFill = True
        '
        'ReportDataGridView
        '
        Me.ReportDataGridView.AllowUserToAddRows = False
        Me.ReportDataGridView.AllowUserToDeleteRows = False
        Me.ReportDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportDataGridView.AutoGenerateColumns = False
        Me.ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16})
        Me.ReportDataGridView.DataSource = Me.ReportBindingSource
        Me.ReportDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ReportDataGridView.Name = "ReportDataGridView"
        Me.ReportDataGridView.RowTemplate.Height = 24
        Me.ReportDataGridView.Size = New System.Drawing.Size(1151, 438)
        Me.ReportDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ReportName"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Report Style"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'btnAddReport
        '
        Me.btnAddReport.Location = New System.Drawing.Point(5, 456)
        Me.btnAddReport.Name = "btnAddReport"
        Me.btnAddReport.Size = New System.Drawing.Size(140, 36)
        Me.btnAddReport.TabIndex = 1
        Me.btnAddReport.Text = "Add"
        Me.btnAddReport.UseVisualStyleBackColor = True
        '
        'btnDeleteReport
        '
        Me.btnDeleteReport.Location = New System.Drawing.Point(151, 456)
        Me.btnDeleteReport.Name = "btnDeleteReport"
        Me.btnDeleteReport.Size = New System.Drawing.Size(148, 36)
        Me.btnDeleteReport.TabIndex = 2
        Me.btnDeleteReport.Text = "Delete"
        Me.btnDeleteReport.UseVisualStyleBackColor = True
        '
        'ReportItemBindingSource
        '
        Me.ReportItemBindingSource.DataMember = "ReportReportItem"
        Me.ReportItemBindingSource.DataSource = Me.ReportBindingSource
        '
        'ReportItemTableAdapter
        '
        Me.ReportItemTableAdapter.ClearBeforeFill = True
        '
        'ReportItemDataGridView
        '
        Me.ReportItemDataGridView.AutoGenerateColumns = False
        Me.ReportItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.ReportItemDataGridView.DataSource = Me.ReportItemBindingSource
        Me.ReportItemDataGridView.Location = New System.Drawing.Point(70, 182)
        Me.ReportItemDataGridView.Name = "ReportItemDataGridView"
        Me.ReportItemDataGridView.RowTemplate.Height = 24
        Me.ReportItemDataGridView.Size = New System.Drawing.Size(509, 241)
        Me.ReportItemDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "ItemText"
        Me.DataGridViewTextBoxColumn20.HeaderText = "ItemText"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Font"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Font"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "FontSize"
        Me.DataGridViewTextBoxColumn23.HeaderText = "FontSize"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Indent"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Indent"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Bold"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Bold"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Italic"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Italic"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Underline"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Underline"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "SmallCap"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "SmallCap"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "ReportID"
        Me.DataGridViewTextBoxColumn26.HeaderText = "ReportID"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'SplitContainer10
        '
        Me.SplitContainer10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer10.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer10.Name = "SplitContainer10"
        '
        'SplitContainer10.Panel1
        '
        Me.SplitContainer10.Panel1.AutoScroll = True
        Me.SplitContainer10.Panel1.Controls.Add(Me.btnDeleteReport)
        Me.SplitContainer10.Panel1.Controls.Add(Me.btnAddReport)
        Me.SplitContainer10.Panel1.Controls.Add(Me.ReportDataGridView)
        '
        'SplitContainer10.Panel2
        '
        Me.SplitContainer10.Panel2.Controls.Add(Me.ReportItemDataGridView)
        Me.SplitContainer10.Size = New System.Drawing.Size(612, 493)
        Me.SplitContainer10.SplitterDistance = 204
        Me.SplitContainer10.TabIndex = 1
        '
        'tpConstruct
        '
        Me.tpConstruct.BackColor = System.Drawing.SystemColors.Control
        Me.tpConstruct.Controls.Add(Me.TreeView1)
        Me.tpConstruct.Location = New System.Drawing.Point(4, 26)
        Me.tpConstruct.Name = "tpConstruct"
        Me.tpConstruct.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConstruct.Size = New System.Drawing.Size(814, 540)
        Me.tpConstruct.TabIndex = 6
        Me.tpConstruct.Text = "Constructs"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(51, 67)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(430, 266)
        Me.TreeView1.TabIndex = 0
        '
        'TableMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 570)
        Me.Controls.Add(Me.tcTableMaker)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TableMaker"
        Me.Text = "TableMaker for Psychological Evaluation Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tcTableMaker.ResumeLayout(False)
        Me.tpPeople.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PersonDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.BatteryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatteryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.PersonBatteryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBatteryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBatteryScaleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScaleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBatteryScaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpTable.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel1.PerformLayout()
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        Me.SplitContainer8.Panel2.PerformLayout()
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer8.ResumeLayout(False)
        CType(Me.DisplayTableMarkerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayTableMarkerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayTableItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayTableItemMarkerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayTableItemMarkerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayTableItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        CType(Me.BatteryDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scTableScale.Panel1.ResumeLayout(False)
        Me.scTableScale.Panel2.ResumeLayout(False)
        CType(Me.scTableScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scTableScale.ResumeLayout(False)
        CType(Me.ScaleDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilteredPersonBatteryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpBattery.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.BatteryDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScaleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScaleTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRangeLabel.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer9.Panel1.ResumeLayout(False)
        Me.SplitContainer9.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer9.ResumeLayout(False)
        CType(Me.RangeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeLabelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeLabelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpImportExport.ResumeLayout(False)
        CType(Me.PersonBatteryAdministrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayTableItemScoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBatteryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBatteryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer10.Panel1.ResumeLayout(False)
        Me.SplitContainer10.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer10.ResumeLayout(False)
        Me.tpConstruct.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcTableMaker As System.Windows.Forms.TabControl
    Friend WithEvents tpPeople As System.Windows.Forms.TabPage
    Friend WithEvents tpBattery As System.Windows.Forms.TabPage
    Friend WithEvents tmDataSet As Psych_Report_Table_Maker.tmDataSet
    Friend WithEvents PersonTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents TableAdapterManager As Psych_Report_Table_Maker.tmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnDeletePerson As System.Windows.Forms.Button
    Friend WithEvents btnAddPerson As System.Windows.Forms.Button
    Friend WithEvents PersonDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PersonBatteryTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.PersonBatteryTableAdapter
    Friend WithEvents PersonBatteryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatteryTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.BatteryTableAdapter
    Friend WithEvents BatteryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnDeleteTestGiven As System.Windows.Forms.Button
    Friend WithEvents btnAddTestGiven As System.Windows.Forms.Button
    Friend WithEvents BatteryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PersonBatteryScaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonBatteryScaleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PersonBatteryScaleTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.PersonBatteryScaleTableAdapter
    Friend WithEvents btnDeleteBattery As System.Windows.Forms.Button
    Friend WithEvents btnAddBattery As System.Windows.Forms.Button
    Friend WithEvents BatteryDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ScaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScaleTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.ScaleTableAdapter
    Friend WithEvents ScaleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ScoreTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScoreTypeTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.ScoreTypeTableAdapter
    Friend WithEvents btnDeleteScale As System.Windows.Forms.Button
    Friend WithEvents btnAddScale As System.Windows.Forms.Button
    Friend WithEvents tpTable As System.Windows.Forms.TabPage
    Friend WithEvents PersonBatteryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ScaleBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnDownScale As System.Windows.Forms.Button
    Friend WithEvents btnUpScale As System.Windows.Forms.Button
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents BatteryDataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ScaleDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer8 As System.Windows.Forms.SplitContainer
    Friend WithEvents DisplayTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisplayTableTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableTableAdapter
    Friend WithEvents FirstColumnHeaderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DisplayTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RangeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PercentileCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ScoreCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DisplayTableTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteDisplayTable As System.Windows.Forms.Button
    Friend WithEvents btnAddDisplayTable As System.Windows.Forms.Button
    Friend WithEvents DisplayTableMarkerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisplayTableMarkerTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableMarkerTableAdapter
    Friend WithEvents btnDeleteDisplayMarker As System.Windows.Forms.Button
    Friend WithEvents btnAddDisplayMarker As System.Windows.Forms.Button
    Friend WithEvents DisplayTableMarkerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DisplayTableItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisplayTableItemTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableItemTableAdapter
    Friend WithEvents DisplayTableItemDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteDisplayTableItem As System.Windows.Forms.Button
    Friend WithEvents btnAddDisplayTableItem As System.Windows.Forms.Button
    Friend WithEvents SizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BoldCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ItalicCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LevelListBox As System.Windows.Forms.ListBox
    Friend WithEvents btnDownDisplayItem As System.Windows.Forms.Button
    Friend WithEvents btnUpDisplayItem As System.Windows.Forms.Button
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ScoreTypeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisplayTableItemMarkerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisplayTableItemMarkerTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableItemMarkerTableAdapter
    Friend WithEvents btnUnmarkItem As System.Windows.Forms.Button
    Friend WithEvents btnMarkItem As System.Windows.Forms.Button
    Friend WithEvents DisplayTableItemMarkerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MarkerSymbol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScoreTypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddScoreType As System.Windows.Forms.Button
    Friend WithEvents btnDeleteScoreType As System.Windows.Forms.Button
    Friend WithEvents tpRangeLabel As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer9 As System.Windows.Forms.SplitContainer
    Friend WithEvents RangeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RangeTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.RangeTableAdapter
    Friend WithEvents RangeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteRange As System.Windows.Forms.Button
    Friend WithEvents btnAddRange As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RangeLabelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RangeLabelTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.RangeLabelTableAdapter
    Friend WithEvents btnDeleteRangeLabel As System.Windows.Forms.Button
    Friend WithEvents btnAddRangeLabel As System.Windows.Forms.Button
    Friend WithEvents RangeLabelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisplayTableMarkerID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DisplayTableItemMarkerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbxHide As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScaleID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Upperbound As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbxFont As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbxAllCaps As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddAllDisplayItems As System.Windows.Forms.Button
    Friend WithEvents ScaleTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisplayTableItemScoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DisplayTableItemScoreTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.DisplayTableItemScoreTableAdapter
    Friend WithEvents FullNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RangeNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnMakeTable As System.Windows.Forms.Button
    Friend WithEvents Marker As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisplayItemScore As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PercentileColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RangeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisplayTableItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbxAbbreviation As System.Windows.Forms.CheckBox
    Friend WithEvents FilteredPersonBatteryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents scTableScale As System.Windows.Forms.SplitContainer
    Friend WithEvents dtpPersonBattery As System.Windows.Forms.DateTimePicker
    Friend WithEvents BatteryID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents AdministrationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonBatteryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonBatteryListBox As System.Windows.Forms.ListBox
    Friend WithEvents PersonBatteryBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PersonBatteryAdministrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonBatteryAdministrationTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.PersonBatteryAdministrationTableAdapter
    Friend WithEvents PersonBatteryBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StandardScore As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpImportExport As System.Windows.Forms.TabPage
    Friend WithEvents btnSaveAllData As System.Windows.Forms.Button
    Friend WithEvents btnImportData As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScoreTypeID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Level As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SexBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.ReportTableAdapter
    Friend WithEvents btnAddReport As System.Windows.Forms.Button
    Friend WithEvents ReportDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteReport As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportItemTableAdapter As Psych_Report_Table_Maker.tmDataSetTableAdapters.ReportItemTableAdapter
    Friend WithEvents SplitContainer10 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportItemDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbxHiddenTable As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hide As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Abbreviation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HideBattery As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tpConstruct As System.Windows.Forms.TabPage
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
