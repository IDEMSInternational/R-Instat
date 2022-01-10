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
        Me.btnSaveDataframe = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rdoGetObject = New System.Windows.Forms.RadioButton()
        Me.lblGet = New System.Windows.Forms.Label()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.ucrReceiverGet = New instat.ucrReceiverSingle()
        Me.rdoGetDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoGetColumn = New System.Windows.Forms.RadioButton()
        Me.rdoGetPackage = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetData = New instat.UcrPanel()
        Me.rdoGetTable = New System.Windows.Forms.RadioButton()
        Me.rdoGetModel = New System.Windows.Forms.RadioButton()
        Me.rdoGetGraph = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetObject = New instat.UcrPanel()
        Me.ucrDataFrameGet = New instat.ucrDataFrame()
        Me.ucrComboGetPackage = New instat.ucrInputComboBox()
        Me.lblGetPackage = New System.Windows.Forms.Label()
        Me.ucrSelectorGet = New instat.ucrSelectorByDataFrameAddRemove()
        Me.btnGetPackage = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnSaveModel = New System.Windows.Forms.Button()
        Me.btnSaveTable = New System.Windows.Forms.Button()
        Me.lblSaveDataFrame = New System.Windows.Forms.Label()
        Me.btnSaveGraph = New System.Windows.Forms.Button()
        Me.rdoSaveObject = New System.Windows.Forms.RadioButton()
        Me.rdoSaveDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSaveColumn = New System.Windows.Forms.RadioButton()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrDataFrameSave = New instat.ucrDataFrame()
        Me.ucrInputSaveDataFrame = New instat.ucrInputTextBox()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrPnlSaveData = New instat.UcrPanel()
        Me.btnSaveColumn = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnRemoveObjects = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.ucrBase = New instat.ucrButtons()
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
        'btnSaveDataframe
        '
        Me.btnSaveDataframe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveDataframe.Location = New System.Drawing.Point(276, 59)
        Me.btnSaveDataframe.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveDataframe.Name = "btnSaveDataframe"
        Me.btnSaveDataframe.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveDataframe.TabIndex = 32
        Me.btnSaveDataframe.Text = "Add"
        Me.btnSaveDataframe.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(8, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(446, 455)
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
        Me.TabPage2.Size = New System.Drawing.Size(438, 429)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Get Data"
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
        Me.ucrReceiverGet.AutoSize = True
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
        Me.ucrPnlGetData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGetData.Location = New System.Drawing.Point(6, 10)
        Me.ucrPnlGetData.Name = "ucrPnlGetData"
        Me.ucrPnlGetData.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlGetData.TabIndex = 42
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
        Me.ucrPnlGetObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGetObject.Location = New System.Drawing.Point(19, 51)
        Me.ucrPnlGetObject.Name = "ucrPnlGetObject"
        Me.ucrPnlGetObject.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlGetObject.TabIndex = 30
        '
        'ucrDataFrameGet
        '
        Me.ucrDataFrameGet.AutoSize = True
        Me.ucrDataFrameGet.bDropUnusedFilterLevels = False
        Me.ucrDataFrameGet.bUseCurrentFilter = True
        Me.ucrDataFrameGet.Location = New System.Drawing.Point(19, 51)
        Me.ucrDataFrameGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameGet.Name = "ucrDataFrameGet"
        Me.ucrDataFrameGet.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataFrameGet.TabIndex = 31
        '
        'ucrComboGetPackage
        '
        Me.ucrComboGetPackage.AddQuotesIfUnrecognised = True
        Me.ucrComboGetPackage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboGetPackage.GetSetSelectedIndex = -1
        Me.ucrComboGetPackage.IsReadOnly = False
        Me.ucrComboGetPackage.Location = New System.Drawing.Point(19, 68)
        Me.ucrComboGetPackage.Name = "ucrComboGetPackage"
        Me.ucrComboGetPackage.Size = New System.Drawing.Size(137, 21)
        Me.ucrComboGetPackage.TabIndex = 40
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
        'ucrSelectorGet
        '
        Me.ucrSelectorGet.AutoSize = True
        Me.ucrSelectorGet.bDropUnusedFilterLevels = False
        Me.ucrSelectorGet.bShowHiddenColumns = False
        Me.ucrSelectorGet.bUseCurrentFilter = True
        Me.ucrSelectorGet.Location = New System.Drawing.Point(19, 55)
        Me.ucrSelectorGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGet.Name = "ucrSelectorGet"
        Me.ucrSelectorGet.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorGet.TabIndex = 34
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnSaveModel)
        Me.TabPage3.Controls.Add(Me.btnSaveTable)
        Me.TabPage3.Controls.Add(Me.lblSaveDataFrame)
        Me.TabPage3.Controls.Add(Me.btnSaveGraph)
        Me.TabPage3.Controls.Add(Me.rdoSaveObject)
        Me.TabPage3.Controls.Add(Me.btnSaveDataframe)
        Me.TabPage3.Controls.Add(Me.rdoSaveDataFrame)
        Me.TabPage3.Controls.Add(Me.rdoSaveColumn)
        Me.TabPage3.Controls.Add(Me.ucrSaveModel)
        Me.TabPage3.Controls.Add(Me.ucrSaveTable)
        Me.TabPage3.Controls.Add(Me.ucrSaveColumn)
        Me.TabPage3.Controls.Add(Me.ucrDataFrameSave)
        Me.TabPage3.Controls.Add(Me.ucrInputSaveDataFrame)
        Me.TabPage3.Controls.Add(Me.ucrSaveGraph)
        Me.TabPage3.Controls.Add(Me.ucrPnlSaveData)
        Me.TabPage3.Controls.Add(Me.btnSaveColumn)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(438, 429)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Save Results"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnSaveModel
        '
        Me.btnSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveModel.Location = New System.Drawing.Point(291, 168)
        Me.btnSaveModel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveModel.Name = "btnSaveModel"
        Me.btnSaveModel.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveModel.TabIndex = 33
        Me.btnSaveModel.Text = "Add"
        Me.btnSaveModel.UseVisualStyleBackColor = True
        '
        'btnSaveTable
        '
        Me.btnSaveTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveTable.Location = New System.Drawing.Point(290, 134)
        Me.btnSaveTable.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveTable.Name = "btnSaveTable"
        Me.btnSaveTable.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveTable.TabIndex = 31
        Me.btnSaveTable.Text = "Add"
        Me.btnSaveTable.UseVisualStyleBackColor = True
        '
        'lblSaveDataFrame
        '
        Me.lblSaveDataFrame.AutoSize = True
        Me.lblSaveDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveDataFrame.Location = New System.Drawing.Point(14, 64)
        Me.lblSaveDataFrame.Name = "lblSaveDataFrame"
        Me.lblSaveDataFrame.Size = New System.Drawing.Size(96, 13)
        Me.lblSaveDataFrame.TabIndex = 21
        Me.lblSaveDataFrame.Tag = ""
        Me.lblSaveDataFrame.Text = "Data Frame Name:"
        '
        'btnSaveGraph
        '
        Me.btnSaveGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveGraph.Location = New System.Drawing.Point(291, 100)
        Me.btnSaveGraph.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveGraph.Name = "btnSaveGraph"
        Me.btnSaveGraph.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveGraph.TabIndex = 27
        Me.btnSaveGraph.Text = "Add"
        Me.btnSaveGraph.UseVisualStyleBackColor = True
        '
        'rdoSaveObject
        '
        Me.rdoSaveObject.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSaveObject.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveObject.FlatAppearance.BorderSize = 2
        Me.rdoSaveObject.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSaveObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSaveObject.Location = New System.Drawing.Point(235, 14)
        Me.rdoSaveObject.Name = "rdoSaveObject"
        Me.rdoSaveObject.Size = New System.Drawing.Size(80, 30)
        Me.rdoSaveObject.TabIndex = 51
        Me.rdoSaveObject.TabStop = True
        Me.rdoSaveObject.Text = "Object"
        Me.rdoSaveObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveObject.UseVisualStyleBackColor = True
        '
        'rdoSaveDataFrame
        '
        Me.rdoSaveDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSaveDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoSaveDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSaveDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSaveDataFrame.Location = New System.Drawing.Point(79, 14)
        Me.rdoSaveDataFrame.Name = "rdoSaveDataFrame"
        Me.rdoSaveDataFrame.Size = New System.Drawing.Size(80, 30)
        Me.rdoSaveDataFrame.TabIndex = 49
        Me.rdoSaveDataFrame.TabStop = True
        Me.rdoSaveDataFrame.Text = "Data Frame"
        Me.rdoSaveDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSaveColumn
        '
        Me.rdoSaveColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSaveColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveColumn.FlatAppearance.BorderSize = 2
        Me.rdoSaveColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSaveColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSaveColumn.Location = New System.Drawing.Point(157, 14)
        Me.rdoSaveColumn.Name = "rdoSaveColumn"
        Me.rdoSaveColumn.Size = New System.Drawing.Size(80, 30)
        Me.rdoSaveColumn.TabIndex = 50
        Me.rdoSaveColumn.TabStop = True
        Me.rdoSaveColumn.Text = "Column"
        Me.rdoSaveColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveColumn.UseVisualStyleBackColor = True
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModel.Location = New System.Drawing.Point(13, 169)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(271, 22)
        Me.ucrSaveModel.TabIndex = 32
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(12, 135)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(272, 22)
        Me.ucrSaveTable.TabIndex = 30
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveColumn.Location = New System.Drawing.Point(12, 102)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(274, 22)
        Me.ucrSaveColumn.TabIndex = 35
        '
        'ucrDataFrameSave
        '
        Me.ucrDataFrameSave.AutoSize = True
        Me.ucrDataFrameSave.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSave.bUseCurrentFilter = True
        Me.ucrDataFrameSave.Location = New System.Drawing.Point(13, 49)
        Me.ucrDataFrameSave.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSave.Name = "ucrDataFrameSave"
        Me.ucrDataFrameSave.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataFrameSave.TabIndex = 29
        '
        'ucrInputSaveDataFrame
        '
        Me.ucrInputSaveDataFrame.AddQuotesIfUnrecognised = True
        Me.ucrInputSaveDataFrame.AutoSize = True
        Me.ucrInputSaveDataFrame.IsMultiline = False
        Me.ucrInputSaveDataFrame.IsReadOnly = False
        Me.ucrInputSaveDataFrame.Location = New System.Drawing.Point(127, 59)
        Me.ucrInputSaveDataFrame.Name = "ucrInputSaveDataFrame"
        Me.ucrInputSaveDataFrame.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSaveDataFrame.TabIndex = 31
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(13, 101)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(271, 22)
        Me.ucrSaveGraph.TabIndex = 26
        '
        'ucrPnlSaveData
        '
        Me.ucrPnlSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSaveData.Location = New System.Drawing.Point(13, 12)
        Me.ucrPnlSaveData.Name = "ucrPnlSaveData"
        Me.ucrPnlSaveData.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlSaveData.TabIndex = 47
        '
        'btnSaveColumn
        '
        Me.btnSaveColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveColumn.Location = New System.Drawing.Point(292, 102)
        Me.btnSaveColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSaveColumn.Name = "btnSaveColumn"
        Me.btnSaveColumn.Size = New System.Drawing.Size(74, 23)
        Me.btnSaveColumn.TabIndex = 36
        Me.btnSaveColumn.Text = "Add"
        Me.btnSaveColumn.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnRemoveObjects)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(438, 429)
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
        'txtScript
        '
        Me.txtScript.Location = New System.Drawing.Point(456, 29)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtScript.Size = New System.Drawing.Size(576, 429)
        Me.txtScript.TabIndex = 32
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(287, 464)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 16
        '
        'dlgScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1042, 529)
        Me.Controls.Add(Me.txtScript)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
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
    Friend WithEvents ucrInputSaveDataFrame As ucrInputTextBox
    Friend WithEvents btnGetDataFrame As Button
    Friend WithEvents btnSaveDataframe As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveColumn As Button
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ucrDataFrameSave As ucrDataFrame
    Friend WithEvents btnSaveGraph As Button
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents btnSaveModel As Button
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents btnSaveTable As Button
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
    Friend WithEvents rdoSaveObject As RadioButton
    Friend WithEvents rdoSaveDataFrame As RadioButton
    Friend WithEvents rdoSaveColumn As RadioButton
    Friend WithEvents ucrPnlSaveData As UcrPanel
    Friend WithEvents txtScript As TextBox
End Class
