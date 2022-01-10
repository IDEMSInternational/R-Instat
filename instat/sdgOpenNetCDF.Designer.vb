<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgOpenNetCDF
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
        Me.tbNetCDF = New System.Windows.Forms.TabControl()
        Me.tbSubset = New System.Windows.Forms.TabPage()
        Me.ucrSelectorPoints = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lblPointsID = New System.Windows.Forms.Label()
        Me.ucrReceiverPointsID = New instat.ucrReceiverSingle()
        Me.rdoSinglePoint = New System.Windows.Forms.RadioButton()
        Me.rdoPoints = New System.Windows.Forms.RadioButton()
        Me.rdoRange = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverPointsY = New instat.ucrReceiverSingle()
        Me.ucrReceiverPointsX = New instat.ucrReceiverSingle()
        Me.ucrInputPointY = New instat.ucrInputTextBox()
        Me.ucrInputPointX = New instat.ucrInputTextBox()
        Me.ucrPnlLocation = New instat.UcrPanel()
        Me.lblX = New System.Windows.Forms.Label()
        Me.ucrInputMinX = New instat.ucrInputTextBox()
        Me.ucrInputMinY = New instat.ucrInputTextBox()
        Me.lblMinY = New System.Windows.Forms.Label()
        Me.ucrInputMaxX = New instat.ucrInputTextBox()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblMaxX = New System.Windows.Forms.Label()
        Me.lblMinX = New System.Windows.Forms.Label()
        Me.ucrInputMaxY = New instat.ucrInputTextBox()
        Me.lblMaxY = New System.Windows.Forms.Label()
        Me.lblMaxS = New System.Windows.Forms.Label()
        Me.lblMinS = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.dtpMinT = New System.Windows.Forms.DateTimePicker()
        Me.dtpMaxT = New System.Windows.Forms.DateTimePicker()
        Me.lblMaxT = New System.Windows.Forms.Label()
        Me.ucrInputFileDetails = New instat.ucrInputTextBox()
        Me.lblMinT = New System.Windows.Forms.Label()
        Me.ucrInputMaxS = New instat.ucrInputTextBox()
        Me.lblMaxZ = New System.Windows.Forms.Label()
        Me.ucrInputMaxZ = New instat.ucrInputTextBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.ucrInputMinS = New instat.ucrInputTextBox()
        Me.lblMinZ = New System.Windows.Forms.Label()
        Me.ucrInputMinZ = New instat.ucrInputTextBox()
        Me.tbOptions = New System.Windows.Forms.TabPage()
        Me.ucrChkGreatCircleDist = New instat.ucrCheck()
        Me.ucrChkIncludeRequestedPoints = New instat.ucrCheck()
        Me.ucrChkOnlyDataVariables = New instat.ucrCheck()
        Me.ucrChkKeepRawTime = New instat.ucrCheck()
        Me.ucrChkIncludeMetadata = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbNetCDF.SuspendLayout()
        Me.tbSubset.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.tbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNetCDF
        '
        Me.tbNetCDF.Controls.Add(Me.tbSubset)
        Me.tbNetCDF.Controls.Add(Me.tbOptions)
        Me.tbNetCDF.Location = New System.Drawing.Point(8, 8)
        Me.tbNetCDF.Name = "tbNetCDF"
        Me.tbNetCDF.SelectedIndex = 0
        Me.tbNetCDF.Size = New System.Drawing.Size(719, 423)
        Me.tbNetCDF.TabIndex = 0
        '
        'tbSubset
        '
        Me.tbSubset.Controls.Add(Me.ucrSelectorPoints)
        Me.tbSubset.Controls.Add(Me.grpLocation)
        Me.tbSubset.Controls.Add(Me.lblMaxS)
        Me.tbSubset.Controls.Add(Me.lblMinS)
        Me.tbSubset.Controls.Add(Me.lblS)
        Me.tbSubset.Controls.Add(Me.lblZ)
        Me.tbSubset.Controls.Add(Me.dtpMinT)
        Me.tbSubset.Controls.Add(Me.dtpMaxT)
        Me.tbSubset.Controls.Add(Me.lblMaxT)
        Me.tbSubset.Controls.Add(Me.ucrInputFileDetails)
        Me.tbSubset.Controls.Add(Me.lblMinT)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxS)
        Me.tbSubset.Controls.Add(Me.lblMaxZ)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxZ)
        Me.tbSubset.Controls.Add(Me.lblT)
        Me.tbSubset.Controls.Add(Me.ucrInputMinS)
        Me.tbSubset.Controls.Add(Me.lblMinZ)
        Me.tbSubset.Controls.Add(Me.ucrInputMinZ)
        Me.tbSubset.Location = New System.Drawing.Point(4, 22)
        Me.tbSubset.Name = "tbSubset"
        Me.tbSubset.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSubset.Size = New System.Drawing.Size(711, 397)
        Me.tbSubset.TabIndex = 0
        Me.tbSubset.Text = "Subset"
        Me.tbSubset.UseVisualStyleBackColor = True
        '
        'ucrSelectorPoints
        '
        Me.ucrSelectorPoints.AutoSize = True
        Me.ucrSelectorPoints.bDropUnusedFilterLevels = False
        Me.ucrSelectorPoints.bShowHiddenColumns = False
        Me.ucrSelectorPoints.bUseCurrentFilter = True
        Me.ucrSelectorPoints.Location = New System.Drawing.Point(486, 197)
        Me.ucrSelectorPoints.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPoints.Name = "ucrSelectorPoints"
        Me.ucrSelectorPoints.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorPoints.TabIndex = 27
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lblPointsID)
        Me.grpLocation.Controls.Add(Me.ucrReceiverPointsID)
        Me.grpLocation.Controls.Add(Me.rdoSinglePoint)
        Me.grpLocation.Controls.Add(Me.rdoPoints)
        Me.grpLocation.Controls.Add(Me.rdoRange)
        Me.grpLocation.Controls.Add(Me.ucrReceiverPointsY)
        Me.grpLocation.Controls.Add(Me.ucrReceiverPointsX)
        Me.grpLocation.Controls.Add(Me.ucrInputPointY)
        Me.grpLocation.Controls.Add(Me.ucrInputPointX)
        Me.grpLocation.Controls.Add(Me.ucrPnlLocation)
        Me.grpLocation.Controls.Add(Me.lblX)
        Me.grpLocation.Controls.Add(Me.ucrInputMinX)
        Me.grpLocation.Controls.Add(Me.ucrInputMinY)
        Me.grpLocation.Controls.Add(Me.lblMinY)
        Me.grpLocation.Controls.Add(Me.ucrInputMaxX)
        Me.grpLocation.Controls.Add(Me.lblY)
        Me.grpLocation.Controls.Add(Me.lblMaxX)
        Me.grpLocation.Controls.Add(Me.lblMinX)
        Me.grpLocation.Controls.Add(Me.ucrInputMaxY)
        Me.grpLocation.Controls.Add(Me.lblMaxY)
        Me.grpLocation.Location = New System.Drawing.Point(11, 174)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(434, 106)
        Me.grpLocation.TabIndex = 26
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Location"
        '
        'lblPointsID
        '
        Me.lblPointsID.AutoSize = True
        Me.lblPointsID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPointsID.Location = New System.Drawing.Point(296, 62)
        Me.lblPointsID.Name = "lblPointsID"
        Me.lblPointsID.Size = New System.Drawing.Size(59, 13)
        Me.lblPointsID.TabIndex = 23
        Me.lblPointsID.Text = "ID/Station:"
        '
        'ucrReceiverPointsID
        '
        Me.ucrReceiverPointsID.AutoSize = True
        Me.ucrReceiverPointsID.frmParent = Nothing
        Me.ucrReceiverPointsID.Location = New System.Drawing.Point(296, 77)
        Me.ucrReceiverPointsID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPointsID.Name = "ucrReceiverPointsID"
        Me.ucrReceiverPointsID.Selector = Nothing
        Me.ucrReceiverPointsID.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPointsID.strNcFilePath = ""
        Me.ucrReceiverPointsID.TabIndex = 22
        Me.ucrReceiverPointsID.ucrSelector = Nothing
        '
        'rdoSinglePoint
        '
        Me.rdoSinglePoint.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSinglePoint.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSinglePoint.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSinglePoint.FlatAppearance.BorderSize = 2
        Me.rdoSinglePoint.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSinglePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSinglePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSinglePoint.Location = New System.Drawing.Point(286, 13)
        Me.rdoSinglePoint.Name = "rdoSinglePoint"
        Me.rdoSinglePoint.Size = New System.Drawing.Size(104, 27)
        Me.rdoSinglePoint.TabIndex = 21
        Me.rdoSinglePoint.TabStop = True
        Me.rdoSinglePoint.Text = "Single Point"
        Me.rdoSinglePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSinglePoint.UseVisualStyleBackColor = False
        '
        'rdoPoints
        '
        Me.rdoPoints.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPoints.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPoints.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoints.FlatAppearance.BorderSize = 2
        Me.rdoPoints.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPoints.Location = New System.Drawing.Point(184, 13)
        Me.rdoPoints.Name = "rdoPoints"
        Me.rdoPoints.Size = New System.Drawing.Size(104, 27)
        Me.rdoPoints.TabIndex = 20
        Me.rdoPoints.TabStop = True
        Me.rdoPoints.Text = "Points"
        Me.rdoPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPoints.UseVisualStyleBackColor = False
        '
        'rdoRange
        '
        Me.rdoRange.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRange.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRange.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRange.FlatAppearance.BorderSize = 2
        Me.rdoRange.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRange.Location = New System.Drawing.Point(82, 13)
        Me.rdoRange.Name = "rdoRange"
        Me.rdoRange.Size = New System.Drawing.Size(104, 27)
        Me.rdoRange.TabIndex = 19
        Me.rdoRange.TabStop = True
        Me.rdoRange.Text = "Range"
        Me.rdoRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRange.UseVisualStyleBackColor = False
        '
        'ucrReceiverPointsY
        '
        Me.ucrReceiverPointsY.AutoSize = True
        Me.ucrReceiverPointsY.frmParent = Nothing
        Me.ucrReceiverPointsY.Location = New System.Drawing.Point(119, 77)
        Me.ucrReceiverPointsY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPointsY.Name = "ucrReceiverPointsY"
        Me.ucrReceiverPointsY.Selector = Nothing
        Me.ucrReceiverPointsY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPointsY.strNcFilePath = ""
        Me.ucrReceiverPointsY.TabIndex = 18
        Me.ucrReceiverPointsY.ucrSelector = Nothing
        '
        'ucrReceiverPointsX
        '
        Me.ucrReceiverPointsX.AutoSize = True
        Me.ucrReceiverPointsX.frmParent = Nothing
        Me.ucrReceiverPointsX.Location = New System.Drawing.Point(119, 50)
        Me.ucrReceiverPointsX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPointsX.Name = "ucrReceiverPointsX"
        Me.ucrReceiverPointsX.Selector = Nothing
        Me.ucrReceiverPointsX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPointsX.strNcFilePath = ""
        Me.ucrReceiverPointsX.TabIndex = 17
        Me.ucrReceiverPointsX.ucrSelector = Nothing
        '
        'ucrInputPointY
        '
        Me.ucrInputPointY.AddQuotesIfUnrecognised = True
        Me.ucrInputPointY.AutoSize = True
        Me.ucrInputPointY.IsMultiline = False
        Me.ucrInputPointY.IsReadOnly = False
        Me.ucrInputPointY.Location = New System.Drawing.Point(119, 77)
        Me.ucrInputPointY.Name = "ucrInputPointY"
        Me.ucrInputPointY.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputPointY.TabIndex = 16
        '
        'ucrInputPointX
        '
        Me.ucrInputPointX.AddQuotesIfUnrecognised = True
        Me.ucrInputPointX.AutoSize = True
        Me.ucrInputPointX.IsMultiline = False
        Me.ucrInputPointX.IsReadOnly = False
        Me.ucrInputPointX.Location = New System.Drawing.Point(119, 50)
        Me.ucrInputPointX.Name = "ucrInputPointX"
        Me.ucrInputPointX.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputPointX.TabIndex = 15
        '
        'ucrPnlLocation
        '
        Me.ucrPnlLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlLocation.Location = New System.Drawing.Point(60, 11)
        Me.ucrPnlLocation.Name = "ucrPnlLocation"
        Me.ucrPnlLocation.Size = New System.Drawing.Size(354, 33)
        Me.ucrPnlLocation.TabIndex = 11
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblX.Location = New System.Drawing.Point(5, 53)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(0, 13)
        Me.lblX.TabIndex = 1
        '
        'ucrInputMinX
        '
        Me.ucrInputMinX.AddQuotesIfUnrecognised = True
        Me.ucrInputMinX.AutoSize = True
        Me.ucrInputMinX.IsMultiline = False
        Me.ucrInputMinX.IsReadOnly = False
        Me.ucrInputMinX.Location = New System.Drawing.Point(146, 50)
        Me.ucrInputMinX.Name = "ucrInputMinX"
        Me.ucrInputMinX.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMinX.TabIndex = 3
        '
        'ucrInputMinY
        '
        Me.ucrInputMinY.AddQuotesIfUnrecognised = True
        Me.ucrInputMinY.AutoSize = True
        Me.ucrInputMinY.IsMultiline = False
        Me.ucrInputMinY.IsReadOnly = False
        Me.ucrInputMinY.Location = New System.Drawing.Point(146, 77)
        Me.ucrInputMinY.Name = "ucrInputMinY"
        Me.ucrInputMinY.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMinY.TabIndex = 8
        '
        'lblMinY
        '
        Me.lblMinY.AutoSize = True
        Me.lblMinY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinY.Location = New System.Drawing.Point(117, 80)
        Me.lblMinY.Name = "lblMinY"
        Me.lblMinY.Size = New System.Drawing.Size(27, 13)
        Me.lblMinY.TabIndex = 7
        Me.lblMinY.Text = "Min:"
        '
        'ucrInputMaxX
        '
        Me.ucrInputMaxX.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxX.AutoSize = True
        Me.ucrInputMaxX.IsMultiline = False
        Me.ucrInputMaxX.IsReadOnly = False
        Me.ucrInputMaxX.Location = New System.Drawing.Point(325, 50)
        Me.ucrInputMaxX.Name = "ucrInputMaxX"
        Me.ucrInputMaxX.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMaxX.TabIndex = 5
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblY.Location = New System.Drawing.Point(5, 80)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(0, 13)
        Me.lblY.TabIndex = 6
        '
        'lblMaxX
        '
        Me.lblMaxX.AutoSize = True
        Me.lblMaxX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxX.Location = New System.Drawing.Point(293, 53)
        Me.lblMaxX.Name = "lblMaxX"
        Me.lblMaxX.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxX.TabIndex = 4
        Me.lblMaxX.Text = "Max:"
        '
        'lblMinX
        '
        Me.lblMinX.AutoSize = True
        Me.lblMinX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinX.Location = New System.Drawing.Point(117, 53)
        Me.lblMinX.Name = "lblMinX"
        Me.lblMinX.Size = New System.Drawing.Size(27, 13)
        Me.lblMinX.TabIndex = 2
        Me.lblMinX.Text = "Min:"
        '
        'ucrInputMaxY
        '
        Me.ucrInputMaxY.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxY.AutoSize = True
        Me.ucrInputMaxY.IsMultiline = False
        Me.ucrInputMaxY.IsReadOnly = False
        Me.ucrInputMaxY.Location = New System.Drawing.Point(325, 77)
        Me.ucrInputMaxY.Name = "ucrInputMaxY"
        Me.ucrInputMaxY.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMaxY.TabIndex = 10
        '
        'lblMaxY
        '
        Me.lblMaxY.AutoSize = True
        Me.lblMaxY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxY.Location = New System.Drawing.Point(293, 80)
        Me.lblMaxY.Name = "lblMaxY"
        Me.lblMaxY.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxY.TabIndex = 9
        Me.lblMaxY.Text = "Max:"
        '
        'lblMaxS
        '
        Me.lblMaxS.AutoSize = True
        Me.lblMaxS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxS.Location = New System.Drawing.Point(303, 332)
        Me.lblMaxS.Name = "lblMaxS"
        Me.lblMaxS.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxS.TabIndex = 19
        Me.lblMaxS.Text = "Max:"
        '
        'lblMinS
        '
        Me.lblMinS.AutoSize = True
        Me.lblMinS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinS.Location = New System.Drawing.Point(127, 331)
        Me.lblMinS.Name = "lblMinS"
        Me.lblMinS.Size = New System.Drawing.Size(27, 13)
        Me.lblMinS.TabIndex = 17
        Me.lblMinS.Text = "Min:"
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblS.Location = New System.Drawing.Point(15, 332)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(0, 13)
        Me.lblS.TabIndex = 16
        '
        'lblZ
        '
        Me.lblZ.AutoSize = True
        Me.lblZ.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblZ.Location = New System.Drawing.Point(15, 305)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(0, 13)
        Me.lblZ.TabIndex = 11
        '
        'dtpMinT
        '
        Me.dtpMinT.Location = New System.Drawing.Point(161, 357)
        Me.dtpMinT.Name = "dtpMinT"
        Me.dtpMinT.Size = New System.Drawing.Size(133, 20)
        Me.dtpMinT.TabIndex = 23
        '
        'dtpMaxT
        '
        Me.dtpMaxT.Location = New System.Drawing.Point(340, 356)
        Me.dtpMaxT.Name = "dtpMaxT"
        Me.dtpMaxT.Size = New System.Drawing.Size(133, 20)
        Me.dtpMaxT.TabIndex = 25
        '
        'lblMaxT
        '
        Me.lblMaxT.AutoSize = True
        Me.lblMaxT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxT.Location = New System.Drawing.Point(303, 359)
        Me.lblMaxT.Name = "lblMaxT"
        Me.lblMaxT.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxT.TabIndex = 24
        Me.lblMaxT.Text = "Max:"
        '
        'ucrInputFileDetails
        '
        Me.ucrInputFileDetails.AddQuotesIfUnrecognised = True
        Me.ucrInputFileDetails.AutoSize = True
        Me.ucrInputFileDetails.IsMultiline = True
        Me.ucrInputFileDetails.IsReadOnly = True
        Me.ucrInputFileDetails.Location = New System.Drawing.Point(11, 9)
        Me.ucrInputFileDetails.Name = "ucrInputFileDetails"
        Me.ucrInputFileDetails.Size = New System.Drawing.Size(450, 159)
        Me.ucrInputFileDetails.TabIndex = 0
        '
        'lblMinT
        '
        Me.lblMinT.AutoSize = True
        Me.lblMinT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinT.Location = New System.Drawing.Point(127, 359)
        Me.lblMinT.Name = "lblMinT"
        Me.lblMinT.Size = New System.Drawing.Size(27, 13)
        Me.lblMinT.TabIndex = 22
        Me.lblMinT.Text = "Min:"
        '
        'ucrInputMaxS
        '
        Me.ucrInputMaxS.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxS.AutoSize = True
        Me.ucrInputMaxS.IsMultiline = False
        Me.ucrInputMaxS.IsReadOnly = False
        Me.ucrInputMaxS.Location = New System.Drawing.Point(340, 329)
        Me.ucrInputMaxS.Name = "ucrInputMaxS"
        Me.ucrInputMaxS.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMaxS.TabIndex = 20
        '
        'lblMaxZ
        '
        Me.lblMaxZ.AutoSize = True
        Me.lblMaxZ.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxZ.Location = New System.Drawing.Point(303, 305)
        Me.lblMaxZ.Name = "lblMaxZ"
        Me.lblMaxZ.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxZ.TabIndex = 14
        Me.lblMaxZ.Text = "Max:"
        '
        'ucrInputMaxZ
        '
        Me.ucrInputMaxZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxZ.AutoSize = True
        Me.ucrInputMaxZ.IsMultiline = False
        Me.ucrInputMaxZ.IsReadOnly = False
        Me.ucrInputMaxZ.Location = New System.Drawing.Point(340, 302)
        Me.ucrInputMaxZ.Name = "ucrInputMaxZ"
        Me.ucrInputMaxZ.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMaxZ.TabIndex = 15
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblT.Location = New System.Drawing.Point(15, 359)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(0, 13)
        Me.lblT.TabIndex = 21
        '
        'ucrInputMinS
        '
        Me.ucrInputMinS.AddQuotesIfUnrecognised = True
        Me.ucrInputMinS.AutoSize = True
        Me.ucrInputMinS.IsMultiline = False
        Me.ucrInputMinS.IsReadOnly = False
        Me.ucrInputMinS.Location = New System.Drawing.Point(161, 329)
        Me.ucrInputMinS.Name = "ucrInputMinS"
        Me.ucrInputMinS.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMinS.TabIndex = 18
        '
        'lblMinZ
        '
        Me.lblMinZ.AutoSize = True
        Me.lblMinZ.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinZ.Location = New System.Drawing.Point(127, 305)
        Me.lblMinZ.Name = "lblMinZ"
        Me.lblMinZ.Size = New System.Drawing.Size(27, 13)
        Me.lblMinZ.TabIndex = 12
        Me.lblMinZ.Text = "Min:"
        '
        'ucrInputMinZ
        '
        Me.ucrInputMinZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMinZ.AutoSize = True
        Me.ucrInputMinZ.IsMultiline = False
        Me.ucrInputMinZ.IsReadOnly = False
        Me.ucrInputMinZ.Location = New System.Drawing.Point(161, 302)
        Me.ucrInputMinZ.Name = "ucrInputMinZ"
        Me.ucrInputMinZ.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMinZ.TabIndex = 13
        '
        'tbOptions
        '
        Me.tbOptions.Controls.Add(Me.ucrChkGreatCircleDist)
        Me.tbOptions.Controls.Add(Me.ucrChkIncludeRequestedPoints)
        Me.tbOptions.Controls.Add(Me.ucrChkOnlyDataVariables)
        Me.tbOptions.Controls.Add(Me.ucrChkKeepRawTime)
        Me.tbOptions.Controls.Add(Me.ucrChkIncludeMetadata)
        Me.tbOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbOptions.Name = "tbOptions"
        Me.tbOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOptions.Size = New System.Drawing.Size(711, 397)
        Me.tbOptions.TabIndex = 1
        Me.tbOptions.Text = "Options"
        Me.tbOptions.UseVisualStyleBackColor = True
        '
        'ucrChkGreatCircleDist
        '
        Me.ucrChkGreatCircleDist.AutoSize = True
        Me.ucrChkGreatCircleDist.Checked = False
        Me.ucrChkGreatCircleDist.Location = New System.Drawing.Point(11, 122)
        Me.ucrChkGreatCircleDist.Name = "ucrChkGreatCircleDist"
        Me.ucrChkGreatCircleDist.Size = New System.Drawing.Size(464, 23)
        Me.ucrChkGreatCircleDist.TabIndex = 4
        '
        'ucrChkIncludeRequestedPoints
        '
        Me.ucrChkIncludeRequestedPoints.AutoSize = True
        Me.ucrChkIncludeRequestedPoints.Checked = False
        Me.ucrChkIncludeRequestedPoints.Location = New System.Drawing.Point(11, 96)
        Me.ucrChkIncludeRequestedPoints.Name = "ucrChkIncludeRequestedPoints"
        Me.ucrChkIncludeRequestedPoints.Size = New System.Drawing.Size(501, 23)
        Me.ucrChkIncludeRequestedPoints.TabIndex = 3
        '
        'ucrChkOnlyDataVariables
        '
        Me.ucrChkOnlyDataVariables.AutoSize = True
        Me.ucrChkOnlyDataVariables.Checked = False
        Me.ucrChkOnlyDataVariables.Location = New System.Drawing.Point(11, 18)
        Me.ucrChkOnlyDataVariables.Name = "ucrChkOnlyDataVariables"
        Me.ucrChkOnlyDataVariables.Size = New System.Drawing.Size(464, 23)
        Me.ucrChkOnlyDataVariables.TabIndex = 0
        '
        'ucrChkKeepRawTime
        '
        Me.ucrChkKeepRawTime.AutoSize = True
        Me.ucrChkKeepRawTime.Checked = False
        Me.ucrChkKeepRawTime.Location = New System.Drawing.Point(11, 44)
        Me.ucrChkKeepRawTime.Name = "ucrChkKeepRawTime"
        Me.ucrChkKeepRawTime.Size = New System.Drawing.Size(501, 23)
        Me.ucrChkKeepRawTime.TabIndex = 1
        '
        'ucrChkIncludeMetadata
        '
        Me.ucrChkIncludeMetadata.AutoSize = True
        Me.ucrChkIncludeMetadata.Checked = False
        Me.ucrChkIncludeMetadata.Location = New System.Drawing.Point(11, 70)
        Me.ucrChkIncludeMetadata.Name = "ucrChkIncludeMetadata"
        Me.ucrChkIncludeMetadata.Size = New System.Drawing.Size(501, 23)
        Me.ucrChkIncludeMetadata.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(295, 433)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(229, 30)
        Me.ucrBase.TabIndex = 1
        '
        'sdgOpenNetCDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(733, 468)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.tbNetCDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOpenNetCDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NetCDF Options"
        Me.tbNetCDF.ResumeLayout(False)
        Me.tbSubset.ResumeLayout(False)
        Me.tbSubset.PerformLayout()
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.tbOptions.ResumeLayout(False)
        Me.tbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbNetCDF As TabControl
    Friend WithEvents tbOptions As TabPage
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrChkOnlyDataVariables As ucrCheck
    Friend WithEvents ucrChkKeepRawTime As ucrCheck
    Friend WithEvents ucrChkIncludeMetadata As ucrCheck
    Friend WithEvents tbSubset As TabPage
    Friend WithEvents lblMaxS As Label
    Friend WithEvents lblMinS As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblZ As Label
    Friend WithEvents lblY As Label
    Friend WithEvents lblMinX As Label
    Friend WithEvents dtpMinT As DateTimePicker
    Friend WithEvents dtpMaxT As DateTimePicker
    Friend WithEvents lblMaxT As Label
    Friend WithEvents ucrInputFileDetails As ucrInputTextBox
    Friend WithEvents lblMinT As Label
    Friend WithEvents ucrInputMaxS As ucrInputTextBox
    Friend WithEvents lblMaxZ As Label
    Friend WithEvents ucrInputMaxZ As ucrInputTextBox
    Friend WithEvents lblMaxY As Label
    Friend WithEvents ucrInputMaxY As ucrInputTextBox
    Friend WithEvents lblMaxX As Label
    Friend WithEvents ucrInputMaxX As ucrInputTextBox
    Friend WithEvents lblT As Label
    Friend WithEvents ucrInputMinS As ucrInputTextBox
    Friend WithEvents lblMinZ As Label
    Friend WithEvents ucrInputMinZ As ucrInputTextBox
    Friend WithEvents lblMinY As Label
    Friend WithEvents ucrInputMinY As ucrInputTextBox
    Friend WithEvents lblX As Label
    Friend WithEvents ucrInputMinX As ucrInputTextBox
    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents ucrPnlLocation As UcrPanel
    Friend WithEvents ucrReceiverPointsY As ucrReceiverSingle
    Friend WithEvents ucrReceiverPointsX As ucrReceiverSingle
    Friend WithEvents ucrInputPointY As ucrInputTextBox
    Friend WithEvents ucrInputPointX As ucrInputTextBox
    Friend WithEvents ucrSelectorPoints As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoSinglePoint As RadioButton
    Friend WithEvents rdoPoints As RadioButton
    Friend WithEvents rdoRange As RadioButton
    Friend WithEvents ucrChkIncludeRequestedPoints As ucrCheck
    Friend WithEvents lblPointsID As Label
    Friend WithEvents ucrReceiverPointsID As ucrReceiverSingle
    Friend WithEvents ucrChkGreatCircleDist As ucrCheck
End Class
