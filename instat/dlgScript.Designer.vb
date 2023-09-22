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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnGetPackage = New System.Windows.Forms.Button()
        Me.lblGetPackage = New System.Windows.Forms.Label()
        Me.ucrComboGetPackage = New instat.ucrInputComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.btnDataframe = New System.Windows.Forms.Button()
        Me.ucrInputDataFrame = New instat.ucrInputTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rdoGetObject = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.lblGet = New System.Windows.Forms.Label()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.rdoGetDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoGetColumn = New System.Windows.Forms.RadioButton()
        Me.rdoGetTable = New System.Windows.Forms.RadioButton()
        Me.rdoGetModel = New System.Windows.Forms.RadioButton()
        Me.rdoGetGraph = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverGet = New instat.ucrReceiverSingle()
        Me.ucrPnlGetData = New instat.UcrPanel()
        Me.ucrPnlGetObject = New instat.UcrPanel()
        Me.ucrDataFrameGet = New instat.ucrDataFrame()
        Me.ucrSelectorGet = New instat.ucrSelectorByDataFrameAddRemove()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblSaveDataFrame = New System.Windows.Forms.Label()
        Me.btnSaveDataframe = New System.Windows.Forms.Button()
        Me.btnSaveModel = New System.Windows.Forms.Button()
        Me.btnSaveTable = New System.Windows.Forms.Button()
        Me.btnSaveGraph = New System.Windows.Forms.Button()
        Me.rdoSaveObject = New System.Windows.Forms.RadioButton()
        Me.rdoSaveDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSaveColumn = New System.Windows.Forms.RadioButton()
        Me.btnSaveColumn = New System.Windows.Forms.Button()
        Me.ucrInputSaveDataFrame = New instat.ucrInputTextBox()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrDataFrameSave = New instat.ucrDataFrame()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrPnlSaveData = New instat.UcrPanel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnRemoveObjects = New System.Windows.Forms.Button()
        Me.ucrChkPreviewLibrary = New instat.ucrCheck()
        Me.ucrChkEditLibrary = New instat.ucrCheck()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrInputPreviewLibrary = New instat.ucrInputTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetDataFrame
        '
        Me.btnGetDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetDataFrame.Location = New System.Drawing.Point(267, 104)
        Me.btnGetDataFrame.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGetDataFrame.Name = "btnGetDataFrame"
        Me.btnGetDataFrame.Size = New System.Drawing.Size(111, 34)
        Me.btnGetDataFrame.TabIndex = 32
        Me.btnGetDataFrame.Text = "Add"
        Me.btnGetDataFrame.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 10)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(669, 393)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnGetPackage)
        Me.TabPage1.Controls.Add(Me.lblGetPackage)
        Me.TabPage1.Controls.Add(Me.ucrComboGetPackage)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(661, 360)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Library"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnGetPackage
        '
        Me.btnGetPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetPackage.Location = New System.Drawing.Point(255, 56)
        Me.btnGetPackage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGetPackage.Name = "btnGetPackage"
        Me.btnGetPackage.Size = New System.Drawing.Size(111, 34)
        Me.btnGetPackage.TabIndex = 43
        Me.btnGetPackage.Text = "Add"
        Me.btnGetPackage.UseVisualStyleBackColor = True
        '
        'lblGetPackage
        '
        Me.lblGetPackage.AutoSize = True
        Me.lblGetPackage.Location = New System.Drawing.Point(11, 35)
        Me.lblGetPackage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGetPackage.Name = "lblGetPackage"
        Me.lblGetPackage.Size = New System.Drawing.Size(106, 20)
        Me.lblGetPackage.TabIndex = 42
        Me.lblGetPackage.Text = "Get Package:"
        '
        'ucrComboGetPackage
        '
        Me.ucrComboGetPackage.AddQuotesIfUnrecognised = True
        Me.ucrComboGetPackage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboGetPackage.GetSetSelectedIndex = -1
        Me.ucrComboGetPackage.IsReadOnly = False
        Me.ucrComboGetPackage.Location = New System.Drawing.Point(11, 60)
        Me.ucrComboGetPackage.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrComboGetPackage.Name = "ucrComboGetPackage"
        Me.ucrComboGetPackage.Size = New System.Drawing.Size(206, 32)
        Me.ucrComboGetPackage.TabIndex = 41
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lblDataFrame)
        Me.TabPage5.Controls.Add(Me.btnDataframe)
        Me.TabPage5.Controls.Add(Me.ucrInputDataFrame)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(661, 360)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Dataframe"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lblDataFrame
        '
        Me.lblDataFrame.AutoSize = True
        Me.lblDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFrame.Location = New System.Drawing.Point(7, 33)
        Me.lblDataFrame.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(144, 20)
        Me.lblDataFrame.TabIndex = 53
        Me.lblDataFrame.Tag = ""
        Me.lblDataFrame.Text = "Data Frame Name:"
        '
        'btnDataframe
        '
        Me.btnDataframe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDataframe.Location = New System.Drawing.Point(428, 25)
        Me.btnDataframe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDataframe.Name = "btnDataframe"
        Me.btnDataframe.Size = New System.Drawing.Size(111, 34)
        Me.btnDataframe.TabIndex = 34
        Me.btnDataframe.Text = "Add"
        Me.btnDataframe.UseVisualStyleBackColor = True
        '
        'ucrInputDataFrame
        '
        Me.ucrInputDataFrame.AddQuotesIfUnrecognised = True
        Me.ucrInputDataFrame.AutoSize = True
        Me.ucrInputDataFrame.IsMultiline = False
        Me.ucrInputDataFrame.IsReadOnly = False
        Me.ucrInputDataFrame.Location = New System.Drawing.Point(205, 29)
        Me.ucrInputDataFrame.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDataFrame.Name = "ucrInputDataFrame"
        Me.ucrInputDataFrame.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputDataFrame.TabIndex = 33
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rdoGetObject)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtScript)
        Me.TabPage2.Controls.Add(Me.lblGet)
        Me.TabPage2.Controls.Add(Me.btnGet)
        Me.TabPage2.Controls.Add(Me.rdoGetDataFrame)
        Me.TabPage2.Controls.Add(Me.rdoGetColumn)
        Me.TabPage2.Controls.Add(Me.rdoGetTable)
        Me.TabPage2.Controls.Add(Me.rdoGetModel)
        Me.TabPage2.Controls.Add(Me.rdoGetGraph)
        Me.TabPage2.Controls.Add(Me.btnGetDataFrame)
        Me.TabPage2.Controls.Add(Me.ucrReceiverGet)
        Me.TabPage2.Controls.Add(Me.ucrPnlGetData)
        Me.TabPage2.Controls.Add(Me.ucrPnlGetObject)
        Me.TabPage2.Controls.Add(Me.ucrDataFrameGet)
        Me.TabPage2.Controls.Add(Me.ucrSelectorGet)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(661, 360)
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
        Me.rdoGetObject.Location = New System.Drawing.Point(400, 18)
        Me.rdoGetObject.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoGetObject.Name = "rdoGetObject"
        Me.rdoGetObject.Size = New System.Drawing.Size(120, 45)
        Me.rdoGetObject.TabIndex = 46
        Me.rdoGetObject.TabStop = True
        Me.rdoGetObject.Text = "Object"
        Me.rdoGetObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetObject.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(8, 365)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Script:"
        '
        'txtScript
        '
        Me.txtScript.Location = New System.Drawing.Point(9, 389)
        Me.txtScript.Margin = New System.Windows.Forms.Padding(4)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtScript.Size = New System.Drawing.Size(644, 184)
        Me.txtScript.TabIndex = 32
        '
        'lblGet
        '
        Me.lblGet.AutoSize = True
        Me.lblGet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGet.Location = New System.Drawing.Point(389, 162)
        Me.lblGet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGet.Name = "lblGet"
        Me.lblGet.Size = New System.Drawing.Size(126, 20)
        Me.lblGet.TabIndex = 26
        Me.lblGet.Text = "Selected Object:"
        '
        'btnGet
        '
        Me.btnGet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGet.Location = New System.Drawing.Point(390, 234)
        Me.btnGet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(111, 34)
        Me.btnGet.TabIndex = 28
        Me.btnGet.Text = "Add"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'rdoGetDataFrame
        '
        Me.rdoGetDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoGetDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetDataFrame.Location = New System.Drawing.Point(166, 18)
        Me.rdoGetDataFrame.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoGetDataFrame.Name = "rdoGetDataFrame"
        Me.rdoGetDataFrame.Size = New System.Drawing.Size(120, 45)
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
        Me.rdoGetColumn.Location = New System.Drawing.Point(284, 18)
        Me.rdoGetColumn.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoGetColumn.Name = "rdoGetColumn"
        Me.rdoGetColumn.Size = New System.Drawing.Size(120, 45)
        Me.rdoGetColumn.TabIndex = 45
        Me.rdoGetColumn.TabStop = True
        Me.rdoGetColumn.Text = "Column"
        Me.rdoGetColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetColumn.UseVisualStyleBackColor = True
        '
        'rdoGetTable
        '
        Me.rdoGetTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetTable.FlatAppearance.BorderSize = 2
        Me.rdoGetTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetTable.Location = New System.Drawing.Point(216, 82)
        Me.rdoGetTable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoGetTable.Name = "rdoGetTable"
        Me.rdoGetTable.Size = New System.Drawing.Size(120, 45)
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
        Me.rdoGetModel.Location = New System.Drawing.Point(333, 82)
        Me.rdoGetModel.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoGetModel.Name = "rdoGetModel"
        Me.rdoGetModel.Size = New System.Drawing.Size(120, 45)
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
        Me.rdoGetGraph.Location = New System.Drawing.Point(90, 82)
        Me.rdoGetGraph.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoGetGraph.Name = "rdoGetGraph"
        Me.rdoGetGraph.Size = New System.Drawing.Size(129, 45)
        Me.rdoGetGraph.TabIndex = 31
        Me.rdoGetGraph.TabStop = True
        Me.rdoGetGraph.Text = "Graph"
        Me.rdoGetGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetGraph.UseVisualStyleBackColor = True
        '
        'ucrReceiverGet
        '
        Me.ucrReceiverGet.AutoSize = True
        Me.ucrReceiverGet.frmParent = Nothing
        Me.ucrReceiverGet.Location = New System.Drawing.Point(385, 186)
        Me.ucrReceiverGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGet.Name = "ucrReceiverGet"
        Me.ucrReceiverGet.Selector = Nothing
        Me.ucrReceiverGet.Size = New System.Drawing.Size(237, 30)
        Me.ucrReceiverGet.strNcFilePath = ""
        Me.ucrReceiverGet.TabIndex = 27
        Me.ucrReceiverGet.ucrSelector = Nothing
        '
        'ucrPnlGetData
        '
        Me.ucrPnlGetData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGetData.Location = New System.Drawing.Point(115, 15)
        Me.ucrPnlGetData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlGetData.Name = "ucrPnlGetData"
        Me.ucrPnlGetData.Size = New System.Drawing.Size(497, 54)
        Me.ucrPnlGetData.TabIndex = 42
        '
        'ucrPnlGetObject
        '
        Me.ucrPnlGetObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGetObject.Location = New System.Drawing.Point(71, 76)
        Me.ucrPnlGetObject.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlGetObject.Name = "ucrPnlGetObject"
        Me.ucrPnlGetObject.Size = New System.Drawing.Size(405, 54)
        Me.ucrPnlGetObject.TabIndex = 30
        '
        'ucrDataFrameGet
        '
        Me.ucrDataFrameGet.AutoSize = True
        Me.ucrDataFrameGet.bDropUnusedFilterLevels = False
        Me.ucrDataFrameGet.bUseCurrentFilter = True
        Me.ucrDataFrameGet.Location = New System.Drawing.Point(13, 76)
        Me.ucrDataFrameGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameGet.Name = "ucrDataFrameGet"
        Me.ucrDataFrameGet.Size = New System.Drawing.Size(238, 88)
        Me.ucrDataFrameGet.TabIndex = 31
        '
        'ucrSelectorGet
        '
        Me.ucrSelectorGet.AutoSize = True
        Me.ucrSelectorGet.bDropUnusedFilterLevels = False
        Me.ucrSelectorGet.bShowHiddenColumns = False
        Me.ucrSelectorGet.bUseCurrentFilter = True
        Me.ucrSelectorGet.Location = New System.Drawing.Point(13, 82)
        Me.ucrSelectorGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGet.Name = "ucrSelectorGet"
        Me.ucrSelectorGet.Size = New System.Drawing.Size(480, 308)
        Me.ucrSelectorGet.TabIndex = 34
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblSaveDataFrame)
        Me.TabPage3.Controls.Add(Me.btnSaveDataframe)
        Me.TabPage3.Controls.Add(Me.btnSaveModel)
        Me.TabPage3.Controls.Add(Me.btnSaveTable)
        Me.TabPage3.Controls.Add(Me.btnSaveGraph)
        Me.TabPage3.Controls.Add(Me.rdoSaveObject)
        Me.TabPage3.Controls.Add(Me.rdoSaveDataFrame)
        Me.TabPage3.Controls.Add(Me.rdoSaveColumn)
        Me.TabPage3.Controls.Add(Me.btnSaveColumn)
        Me.TabPage3.Controls.Add(Me.ucrInputSaveDataFrame)
        Me.TabPage3.Controls.Add(Me.ucrSaveModel)
        Me.TabPage3.Controls.Add(Me.ucrSaveTable)
        Me.TabPage3.Controls.Add(Me.ucrSaveColumn)
        Me.TabPage3.Controls.Add(Me.ucrDataFrameSave)
        Me.TabPage3.Controls.Add(Me.ucrSaveGraph)
        Me.TabPage3.Controls.Add(Me.ucrPnlSaveData)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(661, 360)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Save Results"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblSaveDataFrame
        '
        Me.lblSaveDataFrame.AutoSize = True
        Me.lblSaveDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveDataFrame.Location = New System.Drawing.Point(22, 88)
        Me.lblSaveDataFrame.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaveDataFrame.Name = "lblSaveDataFrame"
        Me.lblSaveDataFrame.Size = New System.Drawing.Size(144, 20)
        Me.lblSaveDataFrame.TabIndex = 56
        Me.lblSaveDataFrame.Tag = ""
        Me.lblSaveDataFrame.Text = "Data Frame Name:"
        '
        'btnSaveDataframe
        '
        Me.btnSaveDataframe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveDataframe.Location = New System.Drawing.Point(443, 80)
        Me.btnSaveDataframe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveDataframe.Name = "btnSaveDataframe"
        Me.btnSaveDataframe.Size = New System.Drawing.Size(111, 34)
        Me.btnSaveDataframe.TabIndex = 55
        Me.btnSaveDataframe.Text = "Add"
        Me.btnSaveDataframe.UseVisualStyleBackColor = True
        '
        'btnSaveModel
        '
        Me.btnSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveModel.Location = New System.Drawing.Point(436, 252)
        Me.btnSaveModel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveModel.Name = "btnSaveModel"
        Me.btnSaveModel.Size = New System.Drawing.Size(111, 34)
        Me.btnSaveModel.TabIndex = 33
        Me.btnSaveModel.Text = "Add"
        Me.btnSaveModel.UseVisualStyleBackColor = True
        '
        'btnSaveTable
        '
        Me.btnSaveTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveTable.Location = New System.Drawing.Point(435, 201)
        Me.btnSaveTable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveTable.Name = "btnSaveTable"
        Me.btnSaveTable.Size = New System.Drawing.Size(111, 34)
        Me.btnSaveTable.TabIndex = 31
        Me.btnSaveTable.Text = "Add"
        Me.btnSaveTable.UseVisualStyleBackColor = True
        '
        'btnSaveGraph
        '
        Me.btnSaveGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveGraph.Location = New System.Drawing.Point(436, 150)
        Me.btnSaveGraph.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveGraph.Name = "btnSaveGraph"
        Me.btnSaveGraph.Size = New System.Drawing.Size(111, 34)
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
        Me.rdoSaveObject.Location = New System.Drawing.Point(352, 21)
        Me.rdoSaveObject.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSaveObject.Name = "rdoSaveObject"
        Me.rdoSaveObject.Size = New System.Drawing.Size(120, 45)
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
        Me.rdoSaveDataFrame.Location = New System.Drawing.Point(118, 21)
        Me.rdoSaveDataFrame.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSaveDataFrame.Name = "rdoSaveDataFrame"
        Me.rdoSaveDataFrame.Size = New System.Drawing.Size(120, 45)
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
        Me.rdoSaveColumn.Location = New System.Drawing.Point(236, 21)
        Me.rdoSaveColumn.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSaveColumn.Name = "rdoSaveColumn"
        Me.rdoSaveColumn.Size = New System.Drawing.Size(120, 45)
        Me.rdoSaveColumn.TabIndex = 50
        Me.rdoSaveColumn.TabStop = True
        Me.rdoSaveColumn.Text = "Column"
        Me.rdoSaveColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveColumn.UseVisualStyleBackColor = True
        '
        'btnSaveColumn
        '
        Me.btnSaveColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveColumn.Location = New System.Drawing.Point(438, 153)
        Me.btnSaveColumn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveColumn.Name = "btnSaveColumn"
        Me.btnSaveColumn.Size = New System.Drawing.Size(111, 34)
        Me.btnSaveColumn.TabIndex = 36
        Me.btnSaveColumn.Text = "Add"
        Me.btnSaveColumn.UseVisualStyleBackColor = True
        '
        'ucrInputSaveDataFrame
        '
        Me.ucrInputSaveDataFrame.AddQuotesIfUnrecognised = True
        Me.ucrInputSaveDataFrame.AutoSize = True
        Me.ucrInputSaveDataFrame.IsMultiline = False
        Me.ucrInputSaveDataFrame.IsReadOnly = False
        Me.ucrInputSaveDataFrame.Location = New System.Drawing.Point(220, 84)
        Me.ucrInputSaveDataFrame.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSaveDataFrame.Name = "ucrInputSaveDataFrame"
        Me.ucrInputSaveDataFrame.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputSaveDataFrame.TabIndex = 54
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModel.Location = New System.Drawing.Point(20, 254)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(406, 33)
        Me.ucrSaveModel.TabIndex = 32
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(18, 202)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(408, 33)
        Me.ucrSaveTable.TabIndex = 30
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveColumn.Location = New System.Drawing.Point(18, 153)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(411, 33)
        Me.ucrSaveColumn.TabIndex = 35
        '
        'ucrDataFrameSave
        '
        Me.ucrDataFrameSave.AutoSize = True
        Me.ucrDataFrameSave.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSave.bUseCurrentFilter = True
        Me.ucrDataFrameSave.Location = New System.Drawing.Point(20, 74)
        Me.ucrDataFrameSave.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSave.Name = "ucrDataFrameSave"
        Me.ucrDataFrameSave.Size = New System.Drawing.Size(252, 59)
        Me.ucrDataFrameSave.TabIndex = 29
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(20, 152)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(406, 33)
        Me.ucrSaveGraph.TabIndex = 26
        '
        'ucrPnlSaveData
        '
        Me.ucrPnlSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSaveData.Location = New System.Drawing.Point(20, 18)
        Me.ucrPnlSaveData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlSaveData.Name = "ucrPnlSaveData"
        Me.ucrPnlSaveData.Size = New System.Drawing.Size(603, 54)
        Me.ucrPnlSaveData.TabIndex = 47
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnRemoveObjects)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(661, 360)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Finally"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnRemoveObjects
        '
        Me.btnRemoveObjects.Location = New System.Drawing.Point(20, 44)
        Me.btnRemoveObjects.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveObjects.Name = "btnRemoveObjects"
        Me.btnRemoveObjects.Size = New System.Drawing.Size(112, 34)
        Me.btnRemoveObjects.TabIndex = 1
        Me.btnRemoveObjects.Text = "Remove Objects"
        Me.btnRemoveObjects.UseVisualStyleBackColor = True
        '
        'ucrChkPreviewLibrary
        '
        Me.ucrChkPreviewLibrary.AutoSize = True
        Me.ucrChkPreviewLibrary.Checked = False
        Me.ucrChkPreviewLibrary.Location = New System.Drawing.Point(15, 414)
        Me.ucrChkPreviewLibrary.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkPreviewLibrary.Name = "ucrChkPreviewLibrary"
        Me.ucrChkPreviewLibrary.Size = New System.Drawing.Size(118, 34)
        Me.ucrChkPreviewLibrary.TabIndex = 49
        '
        'ucrChkEditLibrary
        '
        Me.ucrChkEditLibrary.AutoSize = True
        Me.ucrChkEditLibrary.Checked = False
        Me.ucrChkEditLibrary.Location = New System.Drawing.Point(15, 450)
        Me.ucrChkEditLibrary.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkEditLibrary.Name = "ucrChkEditLibrary"
        Me.ucrChkEditLibrary.Size = New System.Drawing.Size(118, 34)
        Me.ucrChkEditLibrary.TabIndex = 48
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(157, 494)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(336, 45)
        Me.ucrBaseSubdialog.TabIndex = 33
        '
        'ucrInputPreviewLibrary
        '
        Me.ucrInputPreviewLibrary.AddQuotesIfUnrecognised = True
        Me.ucrInputPreviewLibrary.AutoSize = True
        Me.ucrInputPreviewLibrary.IsMultiline = True
        Me.ucrInputPreviewLibrary.IsReadOnly = True
        Me.ucrInputPreviewLibrary.Location = New System.Drawing.Point(140, 414)
        Me.ucrInputPreviewLibrary.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputPreviewLibrary.Name = "ucrInputPreviewLibrary"
        Me.ucrInputPreviewLibrary.Size = New System.Drawing.Size(531, 70)
        Me.ucrInputPreviewLibrary.TabIndex = 47
        '
        'dlgScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(689, 547)
        Me.Controls.Add(Me.ucrChkPreviewLibrary)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ucrChkEditLibrary)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.ucrInputPreviewLibrary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScript"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Line"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrDataFrameGet As ucrDataFrame
    Friend WithEvents btnGetDataFrame As Button
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
    Friend WithEvents ucrPnlGetData As UcrPanel
    Friend WithEvents rdoGetDataFrame As RadioButton
    Friend WithEvents rdoGetColumn As RadioButton
    Friend WithEvents rdoGetObject As RadioButton
    Friend WithEvents rdoSaveObject As RadioButton
    Friend WithEvents rdoSaveDataFrame As RadioButton
    Friend WithEvents rdoSaveColumn As RadioButton
    Friend WithEvents ucrPnlSaveData As UcrPanel
    Friend WithEvents txtScript As TextBox
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lblGetPackage As Label
    Friend WithEvents ucrComboGetPackage As ucrInputComboBox
    Friend WithEvents btnGetPackage As Button
    Friend WithEvents ucrInputPreviewLibrary As ucrInputTextBox
    Friend WithEvents ucrChkPreviewLibrary As ucrCheck
    Friend WithEvents ucrChkEditLibrary As ucrCheck
    Friend WithEvents btnDataframe As Button
    Friend WithEvents ucrInputDataFrame As ucrInputTextBox
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents lblSaveDataFrame As Label
    Friend WithEvents btnSaveDataframe As Button
    Friend WithEvents ucrInputSaveDataFrame As ucrInputTextBox
End Class
