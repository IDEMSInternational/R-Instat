<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgMerge
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFirstDataFrame = New System.Windows.Forms.Label()
        Me.lblSecondDataFrame = New System.Windows.Forms.Label()
        Me.rdoMergeByAllColumns = New System.Windows.Forms.RadioButton()
        Me.rdoChooseMergeColumns = New System.Windows.Forms.RadioButton()
        Me.grpKeys = New System.Windows.Forms.GroupBox()
        Me.cmdAddAnotherPair = New System.Windows.Forms.Button()
        Me.lblThirdKeyMatch = New System.Windows.Forms.Label()
        Me.lblSecondKeyMatch = New System.Windows.Forms.Label()
        Me.lblFirstKeyMatch = New System.Windows.Forms.Label()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.grpMergeOptions = New System.Windows.Forms.GroupBox()
        Me.rdoRightJoin = New System.Windows.Forms.RadioButton()
        Me.rdoFullJoin = New System.Windows.Forms.RadioButton()
        Me.rdoLeftJoin = New System.Windows.Forms.RadioButton()
        Me.rdoInnerJoin = New System.Windows.Forms.RadioButton()
        Me.ucrNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrReceiverSecondDFKey3 = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstDFKey3 = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondDFKey2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstDFKey2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondDFKey1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstDFKey1 = New instat.ucrReceiverSingle()
        Me.ucrSelectorSecondDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorFirstDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpKeys.SuspendLayout()
        Me.grpMergeOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstDataFrame
        '
        Me.lblFirstDataFrame.AutoSize = True
        Me.lblFirstDataFrame.Location = New System.Drawing.Point(9, 11)
        Me.lblFirstDataFrame.Name = "lblFirstDataFrame"
        Me.lblFirstDataFrame.Size = New System.Drawing.Size(133, 13)
        Me.lblFirstDataFrame.TabIndex = 3
        Me.lblFirstDataFrame.Text = "First Data Frame To Merge"
        '
        'lblSecondDataFrame
        '
        Me.lblSecondDataFrame.AutoSize = True
        Me.lblSecondDataFrame.Location = New System.Drawing.Point(264, 11)
        Me.lblSecondDataFrame.Name = "lblSecondDataFrame"
        Me.lblSecondDataFrame.Size = New System.Drawing.Size(151, 13)
        Me.lblSecondDataFrame.TabIndex = 4
        Me.lblSecondDataFrame.Text = "Second Data Frame To Merge"
        '
        'rdoMergeByAllColumns
        '
        Me.rdoMergeByAllColumns.AutoSize = True
        Me.rdoMergeByAllColumns.Location = New System.Drawing.Point(221, 238)
        Me.rdoMergeByAllColumns.Name = "rdoMergeByAllColumns"
        Me.rdoMergeByAllColumns.Size = New System.Drawing.Size(221, 17)
        Me.rdoMergeByAllColumns.TabIndex = 5
        Me.rdoMergeByAllColumns.TabStop = True
        Me.rdoMergeByAllColumns.Text = "Merge by all columns with the same name"
        Me.rdoMergeByAllColumns.UseVisualStyleBackColor = True
        '
        'rdoChooseMergeColumns
        '
        Me.rdoChooseMergeColumns.AutoSize = True
        Me.rdoChooseMergeColumns.Location = New System.Drawing.Point(12, 238)
        Me.rdoChooseMergeColumns.Name = "rdoChooseMergeColumns"
        Me.rdoChooseMergeColumns.Size = New System.Drawing.Size(192, 17)
        Me.rdoChooseMergeColumns.TabIndex = 6
        Me.rdoChooseMergeColumns.TabStop = True
        Me.rdoChooseMergeColumns.Text = "Choose which columns to merge by"
        Me.rdoChooseMergeColumns.UseVisualStyleBackColor = True
        '
        'grpKeys
        '
        Me.grpKeys.Controls.Add(Me.cmdAddAnotherPair)
        Me.grpKeys.Controls.Add(Me.lblThirdKeyMatch)
        Me.grpKeys.Controls.Add(Me.ucrReceiverSecondDFKey3)
        Me.grpKeys.Controls.Add(Me.ucrReceiverFirstDFKey3)
        Me.grpKeys.Controls.Add(Me.lblSecondKeyMatch)
        Me.grpKeys.Controls.Add(Me.ucrReceiverSecondDFKey2)
        Me.grpKeys.Controls.Add(Me.ucrReceiverFirstDFKey2)
        Me.grpKeys.Controls.Add(Me.lblFirstKeyMatch)
        Me.grpKeys.Controls.Add(Me.ucrReceiverSecondDFKey1)
        Me.grpKeys.Controls.Add(Me.ucrReceiverFirstDFKey1)
        Me.grpKeys.Location = New System.Drawing.Point(12, 268)
        Me.grpKeys.Name = "grpKeys"
        Me.grpKeys.Size = New System.Drawing.Size(390, 158)
        Me.grpKeys.TabIndex = 8
        Me.grpKeys.TabStop = False
        Me.grpKeys.Text = "Key Columns"
        '
        'cmdAddAnotherPair
        '
        Me.cmdAddAnotherPair.Location = New System.Drawing.Point(12, 129)
        Me.cmdAddAnotherPair.Name = "cmdAddAnotherPair"
        Me.cmdAddAnotherPair.Size = New System.Drawing.Size(118, 23)
        Me.cmdAddAnotherPair.TabIndex = 16
        Me.cmdAddAnotherPair.Text = "Add Another Pair"
        Me.cmdAddAnotherPair.UseVisualStyleBackColor = True
        '
        'lblThirdKeyMatch
        '
        Me.lblThirdKeyMatch.AutoSize = True
        Me.lblThirdKeyMatch.Location = New System.Drawing.Point(154, 104)
        Me.lblThirdKeyMatch.Name = "lblThirdKeyMatch"
        Me.lblThirdKeyMatch.Size = New System.Drawing.Size(74, 13)
        Me.lblThirdKeyMatch.TabIndex = 15
        Me.lblThirdKeyMatch.Text = "Matched With"
        '
        'lblSecondKeyMatch
        '
        Me.lblSecondKeyMatch.AutoSize = True
        Me.lblSecondKeyMatch.Location = New System.Drawing.Point(154, 69)
        Me.lblSecondKeyMatch.Name = "lblSecondKeyMatch"
        Me.lblSecondKeyMatch.Size = New System.Drawing.Size(74, 13)
        Me.lblSecondKeyMatch.TabIndex = 12
        Me.lblSecondKeyMatch.Text = "Matched With"
        '
        'lblFirstKeyMatch
        '
        Me.lblFirstKeyMatch.AutoSize = True
        Me.lblFirstKeyMatch.Location = New System.Drawing.Point(154, 35)
        Me.lblFirstKeyMatch.Name = "lblFirstKeyMatch"
        Me.lblFirstKeyMatch.Size = New System.Drawing.Size(74, 13)
        Me.lblFirstKeyMatch.TabIndex = 9
        Me.lblFirstKeyMatch.Text = "Matched With"
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(9, 453)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(118, 13)
        Me.lblNewDataFrameName.TabIndex = 9
        Me.lblNewDataFrameName.Text = "New Data Frame Name"
        '
        'grpMergeOptions
        '
        Me.grpMergeOptions.Controls.Add(Me.rdoRightJoin)
        Me.grpMergeOptions.Controls.Add(Me.rdoFullJoin)
        Me.grpMergeOptions.Controls.Add(Me.rdoLeftJoin)
        Me.grpMergeOptions.Controls.Add(Me.rdoInnerJoin)
        Me.grpMergeOptions.Location = New System.Drawing.Point(455, 236)
        Me.grpMergeOptions.Name = "grpMergeOptions"
        Me.grpMergeOptions.Size = New System.Drawing.Size(304, 158)
        Me.grpMergeOptions.TabIndex = 11
        Me.grpMergeOptions.TabStop = False
        Me.grpMergeOptions.Text = "Merge Options"
        '
        'rdoRightJoin
        '
        Me.rdoRightJoin.Location = New System.Drawing.Point(6, 109)
        Me.rdoRightJoin.Name = "rdoRightJoin"
        Me.rdoRightJoin.Size = New System.Drawing.Size(254, 39)
        Me.rdoRightJoin.TabIndex = 15
        Me.rdoRightJoin.TabStop = True
        Me.rdoRightJoin.Text = "Include all observations in the second data frame and matching observations from " &
    "the first data frame"
        Me.rdoRightJoin.UseVisualStyleBackColor = True
        '
        'rdoFullJoin
        '
        Me.rdoFullJoin.AutoSize = True
        Me.rdoFullJoin.Location = New System.Drawing.Point(6, 58)
        Me.rdoFullJoin.Name = "rdoFullJoin"
        Me.rdoFullJoin.Size = New System.Drawing.Size(229, 17)
        Me.rdoFullJoin.TabIndex = 14
        Me.rdoFullJoin.TabStop = True
        Me.rdoFullJoin.Text = "Include all observations in both data frames"
        Me.rdoFullJoin.UseVisualStyleBackColor = True
        '
        'rdoLeftJoin
        '
        Me.rdoLeftJoin.Location = New System.Drawing.Point(6, 19)
        Me.rdoLeftJoin.Name = "rdoLeftJoin"
        Me.rdoLeftJoin.Size = New System.Drawing.Size(254, 39)
        Me.rdoLeftJoin.TabIndex = 13
        Me.rdoLeftJoin.TabStop = True
        Me.rdoLeftJoin.Text = "Include all observations in the first data frame and matching observations from t" &
    "he second data frame"
        Me.rdoLeftJoin.UseVisualStyleBackColor = True
        '
        'rdoInnerJoin
        '
        Me.rdoInnerJoin.AutoSize = True
        Me.rdoInnerJoin.Location = New System.Drawing.Point(6, 84)
        Me.rdoInnerJoin.Name = "rdoInnerJoin"
        Me.rdoInnerJoin.Size = New System.Drawing.Size(292, 17)
        Me.rdoInnerJoin.TabIndex = 12
        Me.rdoInnerJoin.TabStop = True
        Me.rdoInnerJoin.Text = "Only include observations that match in both data frames"
        Me.rdoInnerJoin.UseVisualStyleBackColor = True
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.IsReadOnly = False
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(135, 450)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(280, 21)
        Me.ucrNewDataFrameName.TabIndex = 10
        '
        'ucrReceiverSecondDFKey3
        '
        Me.ucrReceiverSecondDFKey3.Location = New System.Drawing.Point(255, 100)
        Me.ucrReceiverSecondDFKey3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondDFKey3.Name = "ucrReceiverSecondDFKey3"
        Me.ucrReceiverSecondDFKey3.Selector = Nothing
        Me.ucrReceiverSecondDFKey3.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondDFKey3.TabIndex = 14
        '
        'ucrReceiverFirstDFKey3
        '
        Me.ucrReceiverFirstDFKey3.Location = New System.Drawing.Point(12, 100)
        Me.ucrReceiverFirstDFKey3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstDFKey3.Name = "ucrReceiverFirstDFKey3"
        Me.ucrReceiverFirstDFKey3.Selector = Nothing
        Me.ucrReceiverFirstDFKey3.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstDFKey3.TabIndex = 13
        '
        'ucrReceiverSecondDFKey2
        '
        Me.ucrReceiverSecondDFKey2.Location = New System.Drawing.Point(255, 66)
        Me.ucrReceiverSecondDFKey2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondDFKey2.Name = "ucrReceiverSecondDFKey2"
        Me.ucrReceiverSecondDFKey2.Selector = Nothing
        Me.ucrReceiverSecondDFKey2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondDFKey2.TabIndex = 11
        '
        'ucrReceiverFirstDFKey2
        '
        Me.ucrReceiverFirstDFKey2.Location = New System.Drawing.Point(12, 66)
        Me.ucrReceiverFirstDFKey2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstDFKey2.Name = "ucrReceiverFirstDFKey2"
        Me.ucrReceiverFirstDFKey2.Selector = Nothing
        Me.ucrReceiverFirstDFKey2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstDFKey2.TabIndex = 10
        '
        'ucrReceiverSecondDFKey1
        '
        Me.ucrReceiverSecondDFKey1.Location = New System.Drawing.Point(255, 32)
        Me.ucrReceiverSecondDFKey1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondDFKey1.Name = "ucrReceiverSecondDFKey1"
        Me.ucrReceiverSecondDFKey1.Selector = Nothing
        Me.ucrReceiverSecondDFKey1.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondDFKey1.TabIndex = 8
        '
        'ucrReceiverFirstDFKey1
        '
        Me.ucrReceiverFirstDFKey1.Location = New System.Drawing.Point(12, 32)
        Me.ucrReceiverFirstDFKey1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstDFKey1.Name = "ucrReceiverFirstDFKey1"
        Me.ucrReceiverFirstDFKey1.Selector = Nothing
        Me.ucrReceiverFirstDFKey1.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstDFKey1.TabIndex = 7
        '
        'ucrSelectorSecondDataFrame
        '
        Me.ucrSelectorSecondDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorSecondDataFrame.Location = New System.Drawing.Point(267, 24)
        Me.ucrSelectorSecondDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSecondDataFrame.Name = "ucrSelectorSecondDataFrame"
        Me.ucrSelectorSecondDataFrame.Size = New System.Drawing.Size(240, 180)
        Me.ucrSelectorSecondDataFrame.TabIndex = 2
        '
        'ucrSelectorFirstDataFrame
        '
        Me.ucrSelectorFirstDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorFirstDataFrame.Location = New System.Drawing.Point(10, 24)
        Me.ucrSelectorFirstDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFirstDataFrame.Name = "ucrSelectorFirstDataFrame"
        Me.ucrSelectorFirstDataFrame.Size = New System.Drawing.Size(240, 180)
        Me.ucrSelectorFirstDataFrame.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 495)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'dlgMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 549)
        Me.Controls.Add(Me.grpMergeOptions)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.grpKeys)
        Me.Controls.Add(Me.rdoChooseMergeColumns)
        Me.Controls.Add(Me.rdoMergeByAllColumns)
        Me.Controls.Add(Me.lblSecondDataFrame)
        Me.Controls.Add(Me.lblFirstDataFrame)
        Me.Controls.Add(Me.ucrSelectorSecondDataFrame)
        Me.Controls.Add(Me.ucrSelectorFirstDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Merge"
        Me.Text = "Merge"
        Me.grpKeys.ResumeLayout(False)
        Me.grpKeys.PerformLayout()
        Me.grpMergeOptions.ResumeLayout(False)
        Me.grpMergeOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFirstDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorSecondDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFirstDataFrame As Label
    Friend WithEvents lblSecondDataFrame As Label
    Friend WithEvents rdoMergeByAllColumns As RadioButton
    Friend WithEvents rdoChooseMergeColumns As RadioButton
    Friend WithEvents ucrReceiverFirstDFKey1 As ucrReceiverSingle
    Friend WithEvents grpKeys As GroupBox
    Friend WithEvents ucrReceiverSecondDFKey1 As ucrReceiverSingle
    Friend WithEvents cmdAddAnotherPair As Button
    Friend WithEvents lblThirdKeyMatch As Label
    Friend WithEvents ucrReceiverSecondDFKey3 As ucrReceiverSingle
    Friend WithEvents ucrReceiverFirstDFKey3 As ucrReceiverSingle
    Friend WithEvents lblSecondKeyMatch As Label
    Friend WithEvents ucrReceiverSecondDFKey2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverFirstDFKey2 As ucrReceiverSingle
    Friend WithEvents lblFirstKeyMatch As Label
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrNewDataFrameName As ucrInputTextBox
    Friend WithEvents grpMergeOptions As GroupBox
    Friend WithEvents rdoFullJoin As RadioButton
    Friend WithEvents rdoLeftJoin As RadioButton
    Friend WithEvents rdoInnerJoin As RadioButton
    Friend WithEvents rdoRightJoin As RadioButton
End Class
