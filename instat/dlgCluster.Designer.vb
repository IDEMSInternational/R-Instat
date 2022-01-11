<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCluster
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
        Me.rdoWholeDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedColumn = New System.Windows.Forms.RadioButton()
        Me.rdoDistanceData = New System.Windows.Forms.RadioButton()
        Me.rdoScaleData = New System.Windows.Forms.RadioButton()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrChkCenterEachVariable = New instat.ucrCheck()
        Me.ucrChkScaleEachVariable = New instat.ucrCheck()
        Me.ucrChkOmitMissingRows = New instat.ucrCheck()
        Me.ucrReceiverPrepareData = New instat.ucrReceiverMultiple()
        Me.ucrSelectorPrepareData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.ucrPnlPrepareData = New instat.UcrPanel()
        Me.ucrChkMatrix = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'rdoWholeDataFrame
        '
        Me.rdoWholeDataFrame.AutoSize = True
        Me.rdoWholeDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWholeDataFrame.Location = New System.Drawing.Point(265, 96)
        Me.rdoWholeDataFrame.Name = "rdoWholeDataFrame"
        Me.rdoWholeDataFrame.Size = New System.Drawing.Size(114, 17)
        Me.rdoWholeDataFrame.TabIndex = 6
        Me.rdoWholeDataFrame.TabStop = True
        Me.rdoWholeDataFrame.Text = "Whole Data Frame"
        Me.rdoWholeDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSelectedColumn
        '
        Me.rdoSelectedColumn.AutoSize = True
        Me.rdoSelectedColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSelectedColumn.Location = New System.Drawing.Point(265, 73)
        Me.rdoSelectedColumn.Name = "rdoSelectedColumn"
        Me.rdoSelectedColumn.Size = New System.Drawing.Size(113, 17)
        Me.rdoSelectedColumn.TabIndex = 7
        Me.rdoSelectedColumn.TabStop = True
        Me.rdoSelectedColumn.Text = "Selected Variables"
        Me.rdoSelectedColumn.UseVisualStyleBackColor = True
        '
        'rdoDistanceData
        '
        Me.rdoDistanceData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDistanceData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDistanceData.FlatAppearance.BorderSize = 2
        Me.rdoDistanceData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDistanceData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDistanceData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDistanceData.Location = New System.Drawing.Point(200, 10)
        Me.rdoDistanceData.Name = "rdoDistanceData"
        Me.rdoDistanceData.Size = New System.Drawing.Size(100, 28)
        Me.rdoDistanceData.TabIndex = 16
        Me.rdoDistanceData.Text = "Distance"
        Me.rdoDistanceData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDistanceData.UseVisualStyleBackColor = True
        '
        'rdoScaleData
        '
        Me.rdoScaleData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoScaleData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScaleData.FlatAppearance.BorderSize = 2
        Me.rdoScaleData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScaleData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoScaleData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoScaleData.Location = New System.Drawing.Point(102, 10)
        Me.rdoScaleData.Name = "rdoScaleData"
        Me.rdoScaleData.Size = New System.Drawing.Size(100, 28)
        Me.rdoScaleData.TabIndex = 17
        Me.rdoScaleData.Text = "Scale"
        Me.rdoScaleData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoScaleData.UseVisualStyleBackColor = True
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMethod.Location = New System.Drawing.Point(280, 262)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(43, 13)
        Me.lblMethod.TabIndex = 21
        Me.lblMethod.Text = "Method"
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(280, 279)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMethod.TabIndex = 22
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 371)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 19
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(8, 338)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(403, 34)
        Me.ucrSaveNewDataFrame.TabIndex = 13
        '
        'ucrChkCenterEachVariable
        '
        Me.ucrChkCenterEachVariable.AutoSize = True
        Me.ucrChkCenterEachVariable.Checked = False
        Me.ucrChkCenterEachVariable.Location = New System.Drawing.Point(7, 286)
        Me.ucrChkCenterEachVariable.Name = "ucrChkCenterEachVariable"
        Me.ucrChkCenterEachVariable.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkCenterEachVariable.TabIndex = 12
        '
        'ucrChkScaleEachVariable
        '
        Me.ucrChkScaleEachVariable.AutoSize = True
        Me.ucrChkScaleEachVariable.Checked = False
        Me.ucrChkScaleEachVariable.Location = New System.Drawing.Point(7, 312)
        Me.ucrChkScaleEachVariable.Name = "ucrChkScaleEachVariable"
        Me.ucrChkScaleEachVariable.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkScaleEachVariable.TabIndex = 11
        '
        'ucrChkOmitMissingRows
        '
        Me.ucrChkOmitMissingRows.AutoSize = True
        Me.ucrChkOmitMissingRows.Checked = False
        Me.ucrChkOmitMissingRows.Location = New System.Drawing.Point(7, 259)
        Me.ucrChkOmitMissingRows.Name = "ucrChkOmitMissingRows"
        Me.ucrChkOmitMissingRows.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkOmitMissingRows.TabIndex = 10
        '
        'ucrReceiverPrepareData
        '
        Me.ucrReceiverPrepareData.AutoSize = True
        Me.ucrReceiverPrepareData.frmParent = Me
        Me.ucrReceiverPrepareData.Location = New System.Drawing.Point(267, 125)
        Me.ucrReceiverPrepareData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPrepareData.Name = "ucrReceiverPrepareData"
        Me.ucrReceiverPrepareData.Selector = Nothing
        Me.ucrReceiverPrepareData.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverPrepareData.strNcFilePath = ""
        Me.ucrReceiverPrepareData.TabIndex = 9
        Me.ucrReceiverPrepareData.ucrSelector = Nothing
        '
        'ucrSelectorPrepareData
        '
        Me.ucrSelectorPrepareData.AutoSize = True
        Me.ucrSelectorPrepareData.bDropUnusedFilterLevels = False
        Me.ucrSelectorPrepareData.bShowHiddenColumns = False
        Me.ucrSelectorPrepareData.bUseCurrentFilter = True
        Me.ucrSelectorPrepareData.Location = New System.Drawing.Point(10, 51)
        Me.ucrSelectorPrepareData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPrepareData.Name = "ucrSelectorPrepareData"
        Me.ucrSelectorPrepareData.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorPrepareData.TabIndex = 5
        '
        'ucrPnlSelectData
        '
        Me.ucrPnlSelectData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSelectData.Location = New System.Drawing.Point(255, 65)
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        Me.ucrPnlSelectData.Size = New System.Drawing.Size(135, 48)
        Me.ucrPnlSelectData.TabIndex = 8
        '
        'ucrPnlPrepareData
        '
        Me.ucrPnlPrepareData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPrepareData.Location = New System.Drawing.Point(102, 10)
        Me.ucrPnlPrepareData.Name = "ucrPnlPrepareData"
        Me.ucrPnlPrepareData.Size = New System.Drawing.Size(199, 30)
        Me.ucrPnlPrepareData.TabIndex = 18
        '
        'ucrChkMatrix
        '
        Me.ucrChkMatrix.AutoSize = True
        Me.ucrChkMatrix.Checked = False
        Me.ucrChkMatrix.Location = New System.Drawing.Point(7, 259)
        Me.ucrChkMatrix.Name = "ucrChkMatrix"
        Me.ucrChkMatrix.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMatrix.TabIndex = 20
        '
        'dlgCluster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(421, 425)
        Me.Controls.Add(Me.ucrInputMethod)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoScaleData)
        Me.Controls.Add(Me.rdoDistanceData)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.ucrChkCenterEachVariable)
        Me.Controls.Add(Me.ucrChkScaleEachVariable)
        Me.Controls.Add(Me.ucrReceiverPrepareData)
        Me.Controls.Add(Me.rdoSelectedColumn)
        Me.Controls.Add(Me.rdoWholeDataFrame)
        Me.Controls.Add(Me.ucrSelectorPrepareData)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.Controls.Add(Me.ucrPnlPrepareData)
        Me.Controls.Add(Me.ucrChkOmitMissingRows)
        Me.Controls.Add(Me.ucrChkMatrix)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCluster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scale/Distance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorPrepareData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoWholeDataFrame As RadioButton
    Friend WithEvents rdoSelectedColumn As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
    Friend WithEvents ucrReceiverPrepareData As ucrReceiverMultiple
    Friend WithEvents ucrChkCenterEachVariable As ucrCheck
    Friend WithEvents ucrChkScaleEachVariable As ucrCheck
    Friend WithEvents ucrChkOmitMissingRows As ucrCheck
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents rdoScaleData As RadioButton
    Friend WithEvents rdoDistanceData As RadioButton
    Friend WithEvents ucrPnlPrepareData As UcrPanel
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrChkMatrix As ucrCheck
End Class
