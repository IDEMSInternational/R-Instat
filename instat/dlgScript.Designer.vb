<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgScript
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
        Me.btnGetDataFrame = New System.Windows.Forms.Button()
        Me.btnSaveNewDataframe = New System.Windows.Forms.Button()
        Me.lblGetColumn = New System.Windows.Forms.Label()
        Me.btnGetColumn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rdoGetObject = New System.Windows.Forms.RadioButton()
        Me.rdoGetDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoGetColumn = New System.Windows.Forms.RadioButton()
        Me.rdoGetPackage = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetData = New instat.UcrPanel()
        Me.lblGetPackage = New System.Windows.Forms.Label()
        Me.ucrComboGetPackage = New instat.ucrInputComboBox()
        Me.btnGetPackage = New System.Windows.Forms.Button()
        Me.ucrDataFrameGet = New instat.ucrDataFrame()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoModel = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetObject = New instat.UcrPanel()
        Me.lblGetSelectedObject = New System.Windows.Forms.Label()
        Me.btnGetObject = New System.Windows.Forms.Button()
        Me.ucrReceiverGetObject = New instat.ucrReceiverSingle()
        Me.ucrSelectorGet = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverGetCol = New instat.ucrReceiverSingle()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ucrInputNewDataFrame = New instat.ucrInputTextBox()
        Me.grpBoxNewObject = New System.Windows.Forms.GroupBox()
        Me.btnSaveNewModel = New System.Windows.Forms.Button()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.btSaveNewTable = New System.Windows.Forms.Button()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrDataFrameObject = New instat.ucrDataFrame()
        Me.btnSaveNewGraph = New System.Windows.Forms.Button()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.grpBoxNewColumn = New System.Windows.Forms.GroupBox()
        Me.ucrDataFrameColumn = New instat.ucrDataFrame()
        Me.btnSaveNewColumn = New System.Windows.Forms.Button()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnRemoveObjects = New System.Windows.Forms.Button()
        Me.btnDetachPackage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputCommand = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpBoxNewObject.SuspendLayout()
        Me.grpBoxNewColumn.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetDataFrame
        '
        Me.btnGetDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetDataFrame.Location = New System.Drawing.Point(188, 169)
        Me.btnGetDataFrame.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGetDataFrame.Name = "btnGetDataFrame"
        Me.btnGetDataFrame.Size = New System.Drawing.Size(74, 23)
        Me.btnGetDataFrame.TabIndex = 32
        Me.btnGetDataFrame.Text = "Add"
        Me.btnGetDataFrame.UseVisualStyleBackColor = True
        '
        'btnSaveNewDataframe
        '
        Me.btnSaveNewDataframe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveNewDataframe.Location = New System.Drawing.Point(268, 29)
        Me.btnSaveNewDataframe.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveNewDataframe.Name = "btnSaveNewDataframe"
        Me.btnSaveNewDataframe.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveNewDataframe.TabIndex = 32
        Me.btnSaveNewDataframe.Text = "Add"
        Me.btnSaveNewDataframe.UseVisualStyleBackColor = True
        '
        'lblGetColumn
        '
        Me.lblGetColumn.AutoSize = True
        Me.lblGetColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGetColumn.Location = New System.Drawing.Point(265, 214)
        Me.lblGetColumn.Name = "lblGetColumn"
        Me.lblGetColumn.Size = New System.Drawing.Size(90, 13)
        Me.lblGetColumn.TabIndex = 35
        Me.lblGetColumn.Text = "Selected Column:"
        '
        'btnGetColumn
        '
        Me.btnGetColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetColumn.Location = New System.Drawing.Point(266, 262)
        Me.btnGetColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGetColumn.Name = "btnGetColumn"
        Me.btnGetColumn.Size = New System.Drawing.Size(74, 23)
        Me.btnGetColumn.TabIndex = 37
        Me.btnGetColumn.Text = "Add"
        Me.btnGetColumn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(8, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(446, 688)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(438, 662)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Preliminary"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rdoTable)
        Me.TabPage2.Controls.Add(Me.lblGetColumn)
        Me.TabPage2.Controls.Add(Me.rdoModel)
        Me.TabPage2.Controls.Add(Me.btnGetColumn)
        Me.TabPage2.Controls.Add(Me.rdoGraph)
        Me.TabPage2.Controls.Add(Me.ucrSelectorGet)
        Me.TabPage2.Controls.Add(Me.ucrPnlGetObject)
        Me.TabPage2.Controls.Add(Me.rdoGetObject)
        Me.TabPage2.Controls.Add(Me.lblGetSelectedObject)
        Me.TabPage2.Controls.Add(Me.btnGetObject)
        Me.TabPage2.Controls.Add(Me.ucrReceiverGetCol)
        Me.TabPage2.Controls.Add(Me.ucrReceiverGetObject)
        Me.TabPage2.Controls.Add(Me.rdoGetDataFrame)
        Me.TabPage2.Controls.Add(Me.rdoGetColumn)
        Me.TabPage2.Controls.Add(Me.rdoGetPackage)
        Me.TabPage2.Controls.Add(Me.ucrPnlGetData)
        Me.TabPage2.Controls.Add(Me.lblGetPackage)
        Me.TabPage2.Controls.Add(Me.ucrComboGetPackage)
        Me.TabPage2.Controls.Add(Me.btnGetPackage)
        Me.TabPage2.Controls.Add(Me.ucrDataFrameGet)
        Me.TabPage2.Controls.Add(Me.btnGetDataFrame)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(438, 662)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data From R-Instat"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'rdoGetObject
        '
        Me.rdoGetObject.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetObject.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetObject.FlatAppearance.BorderSize = 2
        Me.rdoGetObject.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetObject.Location = New System.Drawing.Point(267, 12)
        Me.rdoGetObject.Name = "rdoGetObject"
        Me.rdoGetObject.Size = New System.Drawing.Size(80, 30)
        Me.rdoGetObject.TabIndex = 46
        Me.rdoGetObject.TabStop = True
        Me.rdoGetObject.Text = "Object"
        Me.rdoGetObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetObject.UseVisualStyleBackColor = True
        '
        'rdoGetDataFrame
        '
        Me.rdoGetDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoGetDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetDataFrame.Location = New System.Drawing.Point(111, 12)
        Me.rdoGetDataFrame.Name = "rdoGetDataFrame"
        Me.rdoGetDataFrame.Size = New System.Drawing.Size(80, 30)
        Me.rdoGetDataFrame.TabIndex = 44
        Me.rdoGetDataFrame.TabStop = True
        Me.rdoGetDataFrame.Text = "Data Frame"
        Me.rdoGetDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetDataFrame.UseVisualStyleBackColor = True
        '
        'rdoGetColumn
        '
        Me.rdoGetColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetColumn.FlatAppearance.BorderSize = 2
        Me.rdoGetColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetColumn.Location = New System.Drawing.Point(189, 12)
        Me.rdoGetColumn.Name = "rdoGetColumn"
        Me.rdoGetColumn.Size = New System.Drawing.Size(80, 30)
        Me.rdoGetColumn.TabIndex = 45
        Me.rdoGetColumn.TabStop = True
        Me.rdoGetColumn.Text = "Column"
        Me.rdoGetColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetColumn.UseVisualStyleBackColor = True
        '
        'rdoGetPackage
        '
        Me.rdoGetPackage.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetPackage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetPackage.FlatAppearance.BorderSize = 2
        Me.rdoGetPackage.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetPackage.Location = New System.Drawing.Point(27, 12)
        Me.rdoGetPackage.Name = "rdoGetPackage"
        Me.rdoGetPackage.Size = New System.Drawing.Size(86, 30)
        Me.rdoGetPackage.TabIndex = 43
        Me.rdoGetPackage.TabStop = True
        Me.rdoGetPackage.Text = "Package"
        Me.rdoGetPackage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetPackage.UseVisualStyleBackColor = True
        '
        'ucrPnlGetData
        '
        Me.ucrPnlGetData.Location = New System.Drawing.Point(6, 10)
        Me.ucrPnlGetData.Name = "ucrPnlGetData"
        Me.ucrPnlGetData.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlGetData.TabIndex = 42
        '
        'lblGetPackage
        '
        Me.lblGetPackage.AutoSize = True
        Me.lblGetPackage.Location = New System.Drawing.Point(16, 103)
        Me.lblGetPackage.Name = "lblGetPackage"
        Me.lblGetPackage.Size = New System.Drawing.Size(73, 13)
        Me.lblGetPackage.TabIndex = 39
        Me.lblGetPackage.Text = "Get Package:"
        '
        'ucrComboGetPackage
        '
        Me.ucrComboGetPackage.AddQuotesIfUnrecognised = True
        Me.ucrComboGetPackage.GetSetSelectedIndex = -1
        Me.ucrComboGetPackage.IsReadOnly = False
        Me.ucrComboGetPackage.Location = New System.Drawing.Point(19, 119)
        Me.ucrComboGetPackage.Name = "ucrComboGetPackage"
        Me.ucrComboGetPackage.Size = New System.Drawing.Size(137, 21)
        Me.ucrComboGetPackage.TabIndex = 40
        '
        'btnGetPackage
        '
        Me.btnGetPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetPackage.Location = New System.Drawing.Point(186, 119)
        Me.btnGetPackage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGetPackage.Name = "btnGetPackage"
        Me.btnGetPackage.Size = New System.Drawing.Size(74, 23)
        Me.btnGetPackage.TabIndex = 41
        Me.btnGetPackage.Text = "Add"
        Me.btnGetPackage.UseVisualStyleBackColor = True
        '
        'ucrDataFrameGet
        '
        Me.ucrDataFrameGet.bDropUnusedFilterLevels = False
        Me.ucrDataFrameGet.bUseCurrentFilter = True
        Me.ucrDataFrameGet.Location = New System.Drawing.Point(19, 151)
        Me.ucrDataFrameGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameGet.Name = "ucrDataFrameGet"
        Me.ucrDataFrameGet.Size = New System.Drawing.Size(148, 50)
        Me.ucrDataFrameGet.TabIndex = 31
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTable.Location = New System.Drawing.Point(154, 55)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(80, 30)
        Me.rdoTable.TabIndex = 32
        Me.rdoTable.TabStop = True
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoModel
        '
        Me.rdoModel.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoModel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoModel.FlatAppearance.BorderSize = 2
        Me.rdoModel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoModel.Location = New System.Drawing.Point(232, 55)
        Me.rdoModel.Name = "rdoModel"
        Me.rdoModel.Size = New System.Drawing.Size(80, 30)
        Me.rdoModel.TabIndex = 33
        Me.rdoModel.TabStop = True
        Me.rdoModel.Text = "Model"
        Me.rdoModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoModel.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGraph.Location = New System.Drawing.Point(70, 55)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(86, 30)
        Me.rdoGraph.TabIndex = 31
        Me.rdoGraph.TabStop = True
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'ucrPnlGetObject
        '
        Me.ucrPnlGetObject.Location = New System.Drawing.Point(19, 51)
        Me.ucrPnlGetObject.Name = "ucrPnlGetObject"
        Me.ucrPnlGetObject.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlGetObject.TabIndex = 30
        '
        'lblGetSelectedObject
        '
        Me.lblGetSelectedObject.AutoSize = True
        Me.lblGetSelectedObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGetSelectedObject.Location = New System.Drawing.Point(269, 329)
        Me.lblGetSelectedObject.Name = "lblGetSelectedObject"
        Me.lblGetSelectedObject.Size = New System.Drawing.Size(86, 13)
        Me.lblGetSelectedObject.TabIndex = 26
        Me.lblGetSelectedObject.Text = "Selected Object:"
        '
        'btnGetObject
        '
        Me.btnGetObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetObject.Location = New System.Drawing.Point(270, 377)
        Me.btnGetObject.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGetObject.Name = "btnGetObject"
        Me.btnGetObject.Size = New System.Drawing.Size(74, 23)
        Me.btnGetObject.TabIndex = 28
        Me.btnGetObject.Text = "Add"
        Me.btnGetObject.UseVisualStyleBackColor = True
        '
        'ucrReceiverGetObject
        '
        Me.ucrReceiverGetObject.frmParent = Me
        Me.ucrReceiverGetObject.Location = New System.Drawing.Point(267, 344)
        Me.ucrReceiverGetObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGetObject.Name = "ucrReceiverGetObject"
        Me.ucrReceiverGetObject.Selector = Nothing
        Me.ucrReceiverGetObject.Size = New System.Drawing.Size(158, 20)
        Me.ucrReceiverGetObject.strNcFilePath = ""
        Me.ucrReceiverGetObject.TabIndex = 27
        Me.ucrReceiverGetObject.ucrSelector = Nothing
        '
        'ucrSelectorGet
        '
        Me.ucrSelectorGet.bDropUnusedFilterLevels = False
        Me.ucrSelectorGet.bShowHiddenColumns = False
        Me.ucrSelectorGet.bUseCurrentFilter = True
        Me.ucrSelectorGet.Location = New System.Drawing.Point(19, 203)
        Me.ucrSelectorGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGet.Name = "ucrSelectorGet"
        Me.ucrSelectorGet.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorGet.TabIndex = 34
        '
        'ucrReceiverGetCol
        '
        Me.ucrReceiverGetCol.frmParent = Me
        Me.ucrReceiverGetCol.Location = New System.Drawing.Point(263, 229)
        Me.ucrReceiverGetCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGetCol.Name = "ucrReceiverGetCol"
        Me.ucrReceiverGetCol.Selector = Nothing
        Me.ucrReceiverGetCol.Size = New System.Drawing.Size(158, 20)
        Me.ucrReceiverGetCol.strNcFilePath = ""
        Me.ucrReceiverGetCol.TabIndex = 36
        Me.ucrReceiverGetCol.ucrSelector = Nothing
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.grpBoxNewObject)
        Me.TabPage3.Controls.Add(Me.grpBoxNewColumn)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(438, 662)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Save Results"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblNewDataFrameName)
        Me.GroupBox3.Controls.Add(Me.ucrInputNewDataFrame)
        Me.GroupBox3.Controls.Add(Me.btnSaveNewDataframe)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 70)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Write new data frame"
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(6, 34)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(96, 13)
        Me.lblNewDataFrameName.TabIndex = 21
        Me.lblNewDataFrameName.Tag = ""
        Me.lblNewDataFrameName.Text = "Data Frame Name:"
        '
        'ucrInputNewDataFrame
        '
        Me.ucrInputNewDataFrame.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrame.IsMultiline = False
        Me.ucrInputNewDataFrame.IsReadOnly = False
        Me.ucrInputNewDataFrame.Location = New System.Drawing.Point(119, 29)
        Me.ucrInputNewDataFrame.Name = "ucrInputNewDataFrame"
        Me.ucrInputNewDataFrame.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNewDataFrame.TabIndex = 31
        '
        'grpBoxNewObject
        '
        Me.grpBoxNewObject.Controls.Add(Me.btnSaveNewModel)
        Me.grpBoxNewObject.Controls.Add(Me.ucrSaveModel)
        Me.grpBoxNewObject.Controls.Add(Me.btSaveNewTable)
        Me.grpBoxNewObject.Controls.Add(Me.ucrSaveTable)
        Me.grpBoxNewObject.Controls.Add(Me.ucrDataFrameObject)
        Me.grpBoxNewObject.Controls.Add(Me.btnSaveNewGraph)
        Me.grpBoxNewObject.Controls.Add(Me.ucrSaveGraph)
        Me.grpBoxNewObject.Location = New System.Drawing.Point(13, 216)
        Me.grpBoxNewObject.Name = "grpBoxNewObject"
        Me.grpBoxNewObject.Size = New System.Drawing.Size(373, 218)
        Me.grpBoxNewObject.TabIndex = 37
        Me.grpBoxNewObject.TabStop = False
        Me.grpBoxNewObject.Text = "Write new object"
        '
        'btnSaveNewModel
        '
        Me.btnSaveNewModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveNewModel.Location = New System.Drawing.Point(286, 162)
        Me.btnSaveNewModel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveNewModel.Name = "btnSaveNewModel"
        Me.btnSaveNewModel.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveNewModel.TabIndex = 33
        Me.btnSaveNewModel.Text = "Add"
        Me.btnSaveNewModel.UseVisualStyleBackColor = True
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(8, 163)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(271, 22)
        Me.ucrSaveModel.TabIndex = 32
        '
        'btSaveNewTable
        '
        Me.btSaveNewTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btSaveNewTable.Location = New System.Drawing.Point(285, 118)
        Me.btSaveNewTable.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btSaveNewTable.Name = "btSaveNewTable"
        Me.btSaveNewTable.Size = New System.Drawing.Size(74, 23)
        Me.btSaveNewTable.TabIndex = 31
        Me.btSaveNewTable.Text = "Add"
        Me.btSaveNewTable.UseVisualStyleBackColor = True
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.Location = New System.Drawing.Point(7, 119)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(272, 22)
        Me.ucrSaveTable.TabIndex = 30
        '
        'ucrDataFrameObject
        '
        Me.ucrDataFrameObject.bDropUnusedFilterLevels = False
        Me.ucrDataFrameObject.bUseCurrentFilter = True
        Me.ucrDataFrameObject.Location = New System.Drawing.Point(8, 19)
        Me.ucrDataFrameObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameObject.Name = "ucrDataFrameObject"
        Me.ucrDataFrameObject.Size = New System.Drawing.Size(148, 50)
        Me.ucrDataFrameObject.TabIndex = 29
        '
        'btnSaveNewGraph
        '
        Me.btnSaveNewGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveNewGraph.Location = New System.Drawing.Point(286, 73)
        Me.btnSaveNewGraph.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveNewGraph.Name = "btnSaveNewGraph"
        Me.btnSaveNewGraph.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveNewGraph.TabIndex = 27
        Me.btnSaveNewGraph.Text = "Add"
        Me.btnSaveNewGraph.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(8, 74)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(271, 22)
        Me.ucrSaveGraph.TabIndex = 26
        '
        'grpBoxNewColumn
        '
        Me.grpBoxNewColumn.Controls.Add(Me.ucrDataFrameColumn)
        Me.grpBoxNewColumn.Controls.Add(Me.btnSaveNewColumn)
        Me.grpBoxNewColumn.Controls.Add(Me.ucrSaveColumn)
        Me.grpBoxNewColumn.Location = New System.Drawing.Point(13, 93)
        Me.grpBoxNewColumn.Name = "grpBoxNewColumn"
        Me.grpBoxNewColumn.Size = New System.Drawing.Size(373, 109)
        Me.grpBoxNewColumn.TabIndex = 33
        Me.grpBoxNewColumn.TabStop = False
        Me.grpBoxNewColumn.Text = "Write new column"
        '
        'ucrDataFrameColumn
        '
        Me.ucrDataFrameColumn.bDropUnusedFilterLevels = False
        Me.ucrDataFrameColumn.bUseCurrentFilter = True
        Me.ucrDataFrameColumn.Location = New System.Drawing.Point(8, 19)
        Me.ucrDataFrameColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameColumn.Name = "ucrDataFrameColumn"
        Me.ucrDataFrameColumn.Size = New System.Drawing.Size(148, 50)
        Me.ucrDataFrameColumn.TabIndex = 34
        '
        'btnSaveNewColumn
        '
        Me.btnSaveNewColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveNewColumn.Location = New System.Drawing.Point(288, 74)
        Me.btnSaveNewColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveNewColumn.Name = "btnSaveNewColumn"
        Me.btnSaveNewColumn.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveNewColumn.TabIndex = 36
        Me.btnSaveNewColumn.Text = "Add"
        Me.btnSaveNewColumn.UseVisualStyleBackColor = True
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.Location = New System.Drawing.Point(8, 74)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(274, 22)
        Me.ucrSaveColumn.TabIndex = 35
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnRemoveObjects)
        Me.TabPage4.Controls.Add(Me.btnDetachPackage)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(438, 662)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Finally"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnRemoveObjects
        '
        Me.btnRemoveObjects.Location = New System.Drawing.Point(13, 79)
        Me.btnRemoveObjects.Name = "btnRemoveObjects"
        Me.btnRemoveObjects.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveObjects.TabIndex = 1
        Me.btnRemoveObjects.Text = "Remove Objects"
        Me.btnRemoveObjects.UseVisualStyleBackColor = True
        '
        'btnDetachPackage
        '
        Me.btnDetachPackage.Location = New System.Drawing.Point(13, 24)
        Me.btnDetachPackage.Name = "btnDetachPackage"
        Me.btnDetachPackage.Size = New System.Drawing.Size(75, 23)
        Me.btnDetachPackage.TabIndex = 0
        Me.btnDetachPackage.Text = "Detach Packages"
        Me.btnDetachPackage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(460, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Script:"
        '
        'ucrInputCommand
        '
        Me.ucrInputCommand.AddQuotesIfUnrecognised = True
        Me.ucrInputCommand.IsMultiline = True
        Me.ucrInputCommand.IsReadOnly = False
        Me.ucrInputCommand.Location = New System.Drawing.Point(460, 29)
        Me.ucrInputCommand.Name = "ucrInputCommand"
        Me.ucrInputCommand.Size = New System.Drawing.Size(576, 589)
        Me.ucrInputCommand.TabIndex = 18
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(600, 626)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(416, 57)
        Me.ucrBase.TabIndex = 16
        '
        'dlgScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 694)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ucrInputCommand)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScript"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Script"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpBoxNewObject.ResumeLayout(False)
        Me.grpBoxNewColumn.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameGet As ucrDataFrame
    Friend WithEvents ucrInputCommand As ucrInputTextBox
    Friend WithEvents ucrInputNewDataFrame As ucrInputTextBox
    Friend WithEvents btnGetDataFrame As Button
    Friend WithEvents btnSaveNewDataframe As Button
    Friend WithEvents ucrReceiverGetCol As ucrReceiverSingle
    Friend WithEvents btnGetColumn As Button
    Friend WithEvents lblGetColumn As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveNewColumn As Button
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents ucrDataFrameColumn As ucrDataFrame
    Friend WithEvents grpBoxNewColumn As GroupBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents grpBoxNewObject As GroupBox
    Friend WithEvents ucrDataFrameObject As ucrDataFrame
    Friend WithEvents btnSaveNewGraph As Button
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents btnSaveNewModel As Button
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents btSaveNewTable As Button
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrSelectorGet As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorGetObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblGetSelectedObject As Label
    Friend WithEvents btnGetObject As Button
    Friend WithEvents ucrReceiverGetObject As ucrReceiverSingle
    Friend WithEvents ucrPnlGetObject As UcrPanel
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoModel As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents btnRemoveObjects As Button
    Friend WithEvents btnDetachPackage As Button
    Friend WithEvents lblGetPackage As Label
    Friend WithEvents ucrComboGetPackage As ucrInputComboBox
    Friend WithEvents btnGetPackage As Button
    Friend WithEvents ucrPnlGetData As UcrPanel
    Friend WithEvents rdoGetDataFrame As RadioButton
    Friend WithEvents rdoGetColumn As RadioButton
    Friend WithEvents rdoGetPackage As RadioButton
    Friend WithEvents rdoGetObject As RadioButton
End Class
