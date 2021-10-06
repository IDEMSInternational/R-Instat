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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ucrSelectorGet = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoGetObject = New System.Windows.Forms.RadioButton()
        Me.lblGet = New System.Windows.Forms.Label()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.ucrReceiverGet = New instat.ucrReceiverSingle()
        Me.rdoGetDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoGetColumn = New System.Windows.Forms.RadioButton()
        Me.rdoGetPackage = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetData = New instat.UcrPanel()
        Me.ucrDataFrameGet = New instat.ucrDataFrame()
        Me.lblGetPackage = New System.Windows.Forms.Label()
        Me.ucrComboGetPackage = New instat.ucrInputComboBox()
        Me.btnGetPackage = New System.Windows.Forms.Button()
        Me.rdoGetTable = New System.Windows.Forms.RadioButton()
        Me.rdoGetModel = New System.Windows.Forms.RadioButton()
        Me.rdoGetGraph = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetObject = New instat.UcrPanel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblSaveDataFrame = New System.Windows.Forms.Label()
        Me.ucrInputSaveDataFrame = New instat.ucrInputTextBox()
        Me.btnSaveNewModel = New System.Windows.Forms.Button()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.btSaveNewTable = New System.Windows.Forms.Button()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrDataFrameSaveObject = New instat.ucrDataFrame()
        Me.btnSaveNewGraph = New System.Windows.Forms.Button()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.btnSaveNewColumn = New System.Windows.Forms.Button()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnRemoveObjects = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputCommand = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSaveData = New instat.UcrPanel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetDataFrame
        '
        Me.btnGetDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetDataFrame.Location = New System.Drawing.Point(188, 69)
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
        Me.btnSaveNewDataframe.Location = New System.Drawing.Point(280, 59)
        Me.btnSaveNewDataframe.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveNewDataframe.Name = "btnSaveNewDataframe"
        Me.btnSaveNewDataframe.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveNewDataframe.TabIndex = 32
        Me.btnSaveNewDataframe.Text = "Add"
        Me.btnSaveNewDataframe.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(8, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(446, 486)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rdoGetObject)
        Me.TabPage2.Controls.Add(Me.lblGet)
        Me.TabPage2.Controls.Add(Me.btnGet)
        Me.TabPage2.Controls.Add(Me.ucrReceiverGet)
        Me.TabPage2.Controls.Add(Me.rdoGetDataFrame)
        Me.TabPage2.Controls.Add(Me.rdoGetColumn)
        Me.TabPage2.Controls.Add(Me.rdoGetPackage)
        Me.TabPage2.Controls.Add(Me.ucrPnlGetData)
        Me.TabPage2.Controls.Add(Me.rdoGetTable)
        Me.TabPage2.Controls.Add(Me.rdoGetModel)
        Me.TabPage2.Controls.Add(Me.rdoGetGraph)
        Me.TabPage2.Controls.Add(Me.ucrPnlGetObject)
        Me.TabPage2.Controls.Add(Me.ucrDataFrameGet)
        Me.TabPage2.Controls.Add(Me.ucrComboGetPackage)
        Me.TabPage2.Controls.Add(Me.lblGetPackage)
        Me.TabPage2.Controls.Add(Me.ucrSelectorGet)
        Me.TabPage2.Controls.Add(Me.btnGetDataFrame)
        Me.TabPage2.Controls.Add(Me.btnGetPackage)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(438, 460)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Get Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ucrSelectorGet
        '
        Me.ucrSelectorGet.bDropUnusedFilterLevels = False
        Me.ucrSelectorGet.bShowHiddenColumns = False
        Me.ucrSelectorGet.bUseCurrentFilter = True
        Me.ucrSelectorGet.Location = New System.Drawing.Point(19, 55)
        Me.ucrSelectorGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGet.Name = "ucrSelectorGet"
        Me.ucrSelectorGet.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorGet.TabIndex = 34
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
        'lblGet
        '
        Me.lblGet.AutoSize = True
        Me.lblGet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGet.Location = New System.Drawing.Point(269, 108)
        Me.lblGet.Name = "lblGet"
        Me.lblGet.Size = New System.Drawing.Size(86, 13)
        Me.lblGet.TabIndex = 26
        Me.lblGet.Text = "Selected Object:"
        '
        'btnGet
        '
        Me.btnGet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGet.Location = New System.Drawing.Point(270, 156)
        Me.btnGet.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(74, 23)
        Me.btnGet.TabIndex = 28
        Me.btnGet.Text = "Add"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'ucrReceiverGet
        '
        Me.ucrReceiverGet.frmParent = Nothing
        Me.ucrReceiverGet.Location = New System.Drawing.Point(267, 124)
        Me.ucrReceiverGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGet.Name = "ucrReceiverGet"
        Me.ucrReceiverGet.Selector = Nothing
        Me.ucrReceiverGet.Size = New System.Drawing.Size(158, 20)
        Me.ucrReceiverGet.strNcFilePath = ""
        Me.ucrReceiverGet.TabIndex = 27
        Me.ucrReceiverGet.ucrSelector = Nothing
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
        'ucrDataFrameGet
        '
        Me.ucrDataFrameGet.bDropUnusedFilterLevels = False
        Me.ucrDataFrameGet.bUseCurrentFilter = True
        Me.ucrDataFrameGet.Location = New System.Drawing.Point(19, 51)
        Me.ucrDataFrameGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameGet.Name = "ucrDataFrameGet"
        Me.ucrDataFrameGet.Size = New System.Drawing.Size(148, 50)
        Me.ucrDataFrameGet.TabIndex = 31
        '
        'lblGetPackage
        '
        Me.lblGetPackage.AutoSize = True
        Me.lblGetPackage.Location = New System.Drawing.Point(16, 52)
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
        Me.ucrComboGetPackage.Location = New System.Drawing.Point(19, 68)
        Me.ucrComboGetPackage.Name = "ucrComboGetPackage"
        Me.ucrComboGetPackage.Size = New System.Drawing.Size(137, 21)
        Me.ucrComboGetPackage.TabIndex = 40
        '
        'btnGetPackage
        '
        Me.btnGetPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetPackage.Location = New System.Drawing.Point(186, 68)
        Me.btnGetPackage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGetPackage.Name = "btnGetPackage"
        Me.btnGetPackage.Size = New System.Drawing.Size(74, 23)
        Me.btnGetPackage.TabIndex = 41
        Me.btnGetPackage.Text = "Add"
        Me.btnGetPackage.UseVisualStyleBackColor = True
        '
        'rdoGetTable
        '
        Me.rdoGetTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetTable.FlatAppearance.BorderSize = 2
        Me.rdoGetTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetTable.Location = New System.Drawing.Point(154, 55)
        Me.rdoGetTable.Name = "rdoGetTable"
        Me.rdoGetTable.Size = New System.Drawing.Size(80, 30)
        Me.rdoGetTable.TabIndex = 32
        Me.rdoGetTable.TabStop = True
        Me.rdoGetTable.Text = "Table"
        Me.rdoGetTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetTable.UseVisualStyleBackColor = True
        '
        'rdoGetModel
        '
        Me.rdoGetModel.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetModel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetModel.FlatAppearance.BorderSize = 2
        Me.rdoGetModel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetModel.Location = New System.Drawing.Point(232, 55)
        Me.rdoGetModel.Name = "rdoGetModel"
        Me.rdoGetModel.Size = New System.Drawing.Size(80, 30)
        Me.rdoGetModel.TabIndex = 33
        Me.rdoGetModel.TabStop = True
        Me.rdoGetModel.Text = "Model"
        Me.rdoGetModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetModel.UseVisualStyleBackColor = True
        '
        'rdoGetGraph
        '
        Me.rdoGetGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetGraph.FlatAppearance.BorderSize = 2
        Me.rdoGetGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetGraph.Location = New System.Drawing.Point(70, 55)
        Me.rdoGetGraph.Name = "rdoGetGraph"
        Me.rdoGetGraph.Size = New System.Drawing.Size(86, 30)
        Me.rdoGetGraph.TabIndex = 31
        Me.rdoGetGraph.TabStop = True
        Me.rdoGetGraph.Text = "Graph"
        Me.rdoGetGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetGraph.UseVisualStyleBackColor = True
        '
        'ucrPnlGetObject
        '
        Me.ucrPnlGetObject.Location = New System.Drawing.Point(19, 51)
        Me.ucrPnlGetObject.Name = "ucrPnlGetObject"
        Me.ucrPnlGetObject.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlGetObject.TabIndex = 30
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnSaveNewModel)
        Me.TabPage3.Controls.Add(Me.ucrSaveModel)
        Me.TabPage3.Controls.Add(Me.btnSaveNewColumn)
        Me.TabPage3.Controls.Add(Me.btSaveNewTable)
        Me.TabPage3.Controls.Add(Me.lblSaveDataFrame)
        Me.TabPage3.Controls.Add(Me.ucrSaveTable)
        Me.TabPage3.Controls.Add(Me.ucrSaveColumn)
        Me.TabPage3.Controls.Add(Me.ucrDataFrameSaveObject)
        Me.TabPage3.Controls.Add(Me.btnSaveNewGraph)
        Me.TabPage3.Controls.Add(Me.ucrInputSaveDataFrame)
        Me.TabPage3.Controls.Add(Me.ucrSaveGraph)
        Me.TabPage3.Controls.Add(Me.RadioButton1)
        Me.TabPage3.Controls.Add(Me.btnSaveNewDataframe)
        Me.TabPage3.Controls.Add(Me.RadioButton2)
        Me.TabPage3.Controls.Add(Me.RadioButton3)
        Me.TabPage3.Controls.Add(Me.ucrPnlSaveData)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(438, 460)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Save Results"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblSaveDataFrame
        '
        Me.lblSaveDataFrame.AutoSize = True
        Me.lblSaveDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveDataFrame.Location = New System.Drawing.Point(18, 64)
        Me.lblSaveDataFrame.Name = "lblSaveDataFrame"
        Me.lblSaveDataFrame.Size = New System.Drawing.Size(96, 13)
        Me.lblSaveDataFrame.TabIndex = 21
        Me.lblSaveDataFrame.Tag = ""
        Me.lblSaveDataFrame.Text = "Data Frame Name:"
        '
        'ucrInputSaveDataFrame
        '
        Me.ucrInputSaveDataFrame.AddQuotesIfUnrecognised = True
        Me.ucrInputSaveDataFrame.IsMultiline = False
        Me.ucrInputSaveDataFrame.IsReadOnly = False
        Me.ucrInputSaveDataFrame.Location = New System.Drawing.Point(131, 59)
        Me.ucrInputSaveDataFrame.Name = "ucrInputSaveDataFrame"
        Me.ucrInputSaveDataFrame.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSaveDataFrame.TabIndex = 31
        '
        'btnSaveNewModel
        '
        Me.btnSaveNewModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveNewModel.Location = New System.Drawing.Point(291, 249)
        Me.btnSaveNewModel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveNewModel.Name = "btnSaveNewModel"
        Me.btnSaveNewModel.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveNewModel.TabIndex = 33
        Me.btnSaveNewModel.Text = "Add"
        Me.btnSaveNewModel.UseVisualStyleBackColor = True
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(13, 250)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(271, 22)
        Me.ucrSaveModel.TabIndex = 32
        '
        'btSaveNewTable
        '
        Me.btSaveNewTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btSaveNewTable.Location = New System.Drawing.Point(290, 215)
        Me.btSaveNewTable.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btSaveNewTable.Name = "btSaveNewTable"
        Me.btSaveNewTable.Size = New System.Drawing.Size(74, 23)
        Me.btSaveNewTable.TabIndex = 31
        Me.btSaveNewTable.Text = "Add"
        Me.btSaveNewTable.UseVisualStyleBackColor = True
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.Location = New System.Drawing.Point(12, 216)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(272, 22)
        Me.ucrSaveTable.TabIndex = 30
        '
        'ucrDataFrameSaveObject
        '
        Me.ucrDataFrameSaveObject.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSaveObject.bUseCurrentFilter = True
        Me.ucrDataFrameSaveObject.Location = New System.Drawing.Point(13, 92)
        Me.ucrDataFrameSaveObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSaveObject.Name = "ucrDataFrameSaveObject"
        Me.ucrDataFrameSaveObject.Size = New System.Drawing.Size(148, 50)
        Me.ucrDataFrameSaveObject.TabIndex = 29
        '
        'btnSaveNewGraph
        '
        Me.btnSaveNewGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveNewGraph.Location = New System.Drawing.Point(291, 181)
        Me.btnSaveNewGraph.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveNewGraph.Name = "btnSaveNewGraph"
        Me.btnSaveNewGraph.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveNewGraph.TabIndex = 27
        Me.btnSaveNewGraph.Text = "Add"
        Me.btnSaveNewGraph.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(13, 182)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(271, 22)
        Me.ucrSaveGraph.TabIndex = 26
        '
        'btnSaveNewColumn
        '
        Me.btnSaveNewColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveNewColumn.Location = New System.Drawing.Point(292, 145)
        Me.btnSaveNewColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveNewColumn.Name = "btnSaveNewColumn"
        Me.btnSaveNewColumn.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveNewColumn.TabIndex = 36
        Me.btnSaveNewColumn.Text = "Add"
        Me.btnSaveNewColumn.UseVisualStyleBackColor = True
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.Location = New System.Drawing.Point(12, 145)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(274, 22)
        Me.ucrSaveColumn.TabIndex = 35
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnRemoveObjects)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(438, 585)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Finally"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnRemoveObjects
        '
        Me.btnRemoveObjects.Location = New System.Drawing.Point(13, 29)
        Me.btnRemoveObjects.Name = "btnRemoveObjects"
        Me.btnRemoveObjects.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveObjects.TabIndex = 1
        Me.btnRemoveObjects.Text = "Remove Objects"
        Me.btnRemoveObjects.UseVisualStyleBackColor = True
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
        Me.ucrInputCommand.Size = New System.Drawing.Size(576, 460)
        Me.ucrInputCommand.TabIndex = 18
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(292, 498)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(416, 57)
        Me.ucrBase.TabIndex = 16
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton1.FlatAppearance.BorderSize = 2
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton1.Location = New System.Drawing.Point(235, 14)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 30)
        Me.RadioButton1.TabIndex = 51
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Object"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton2.FlatAppearance.BorderSize = 2
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton2.Location = New System.Drawing.Point(79, 14)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 30)
        Me.RadioButton2.TabIndex = 49
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Data Frame"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton3.FlatAppearance.BorderSize = 2
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton3.Location = New System.Drawing.Point(157, 14)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(80, 30)
        Me.RadioButton3.TabIndex = 50
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Column"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'ucrPnlSaveData
        '
        Me.ucrPnlSaveData.Location = New System.Drawing.Point(13, 12)
        Me.ucrPnlSaveData.Name = "ucrPnlSaveData"
        Me.ucrPnlSaveData.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlSaveData.TabIndex = 47
        '
        'dlgScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 566)
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
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameGet As ucrDataFrame
    Friend WithEvents ucrInputCommand As ucrInputTextBox
    Friend WithEvents ucrInputSaveDataFrame As ucrInputTextBox
    Friend WithEvents btnGetDataFrame As Button
    Friend WithEvents btnSaveNewDataframe As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveNewColumn As Button
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ucrDataFrameSaveObject As ucrDataFrame
    Friend WithEvents btnSaveNewGraph As Button
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents btnSaveNewModel As Button
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents btSaveNewTable As Button
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents lblSaveDataFrame As Label
    Friend WithEvents ucrSelectorGet As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorGetObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblGet As Label
    Friend WithEvents btnGet As Button
    Friend WithEvents ucrReceiverGet As ucrReceiverSingle
    Friend WithEvents ucrPnlGetObject As UcrPanel
    Friend WithEvents rdoGetTable As RadioButton
    Friend WithEvents rdoGetModel As RadioButton
    Friend WithEvents rdoGetGraph As RadioButton
    Friend WithEvents btnRemoveObjects As Button
    Friend WithEvents lblGetPackage As Label
    Friend WithEvents ucrComboGetPackage As ucrInputComboBox
    Friend WithEvents btnGetPackage As Button
    Friend WithEvents ucrPnlGetData As UcrPanel
    Friend WithEvents rdoGetDataFrame As RadioButton
    Friend WithEvents rdoGetColumn As RadioButton
    Friend WithEvents rdoGetPackage As RadioButton
    Friend WithEvents rdoGetObject As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ucrPnlSaveData As UcrPanel
End Class
