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
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ucrNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.pnlKeyColumns = New System.Windows.Forms.Panel()
        Me.cmdRemoveAll = New System.Windows.Forms.Button()
        Me.lstKeyColumns = New System.Windows.Forms.ListView()
        Me.lblKeyColumns = New System.Windows.Forms.Label()
        Me.cmdRemoveSelectedPair = New System.Windows.Forms.Button()
        Me.rdoByAllMatching = New System.Windows.Forms.RadioButton()
        Me.rdoChooseColumns = New System.Windows.Forms.RadioButton()
        Me.grpKeys = New System.Windows.Forms.GroupBox()
        Me.cmdAddPair = New System.Windows.Forms.Button()
        Me.lblFirstKeyMatch = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondDF = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstDF = New instat.ucrReceiverSingle()
        Me.ucrSelectorFirstDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorSecondDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdJoinOptions = New System.Windows.Forms.Button()
        Me.pnlKeyColumns.SuspendLayout()
        Me.grpKeys.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstDataFrame
        '
        Me.lblFirstDataFrame.AutoSize = True
        Me.lblFirstDataFrame.Location = New System.Drawing.Point(10, 11)
        Me.lblFirstDataFrame.Name = "lblFirstDataFrame"
        Me.lblFirstDataFrame.Size = New System.Drawing.Size(133, 13)
        Me.lblFirstDataFrame.TabIndex = 3
        Me.lblFirstDataFrame.Text = "First Data Frame To Merge"
        '
        'lblSecondDataFrame
        '
        Me.lblSecondDataFrame.AutoSize = True
        Me.lblSecondDataFrame.Location = New System.Drawing.Point(224, 13)
        Me.lblSecondDataFrame.Name = "lblSecondDataFrame"
        Me.lblSecondDataFrame.Size = New System.Drawing.Size(151, 13)
        Me.lblSecondDataFrame.TabIndex = 4
        Me.lblSecondDataFrame.Text = "Second Data Frame To Merge"
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(5, 364)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(118, 13)
        Me.lblNewDataFrameName.TabIndex = 9
        Me.lblNewDataFrameName.Text = "New Data Frame Name"
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.IsReadOnly = False
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(129, 361)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(277, 21)
        Me.ucrNewDataFrameName.TabIndex = 10
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 388)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'pnlKeyColumns
        '
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveAll)
        Me.pnlKeyColumns.Controls.Add(Me.lstKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.lblKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveSelectedPair)
        Me.pnlKeyColumns.Location = New System.Drawing.Point(431, 185)
        Me.pnlKeyColumns.Name = "pnlKeyColumns"
        Me.pnlKeyColumns.Size = New System.Drawing.Size(194, 256)
        Me.pnlKeyColumns.TabIndex = 21
        '
        'cmdRemoveAll
        '
        Me.cmdRemoveAll.Location = New System.Drawing.Point(6, 223)
        Me.cmdRemoveAll.Name = "cmdRemoveAll"
        Me.cmdRemoveAll.Size = New System.Drawing.Size(99, 23)
        Me.cmdRemoveAll.TabIndex = 18
        Me.cmdRemoveAll.Text = "Remove All Pairs"
        Me.cmdRemoveAll.UseVisualStyleBackColor = True
        '
        'lstKeyColumns
        '
        Me.lstKeyColumns.FullRowSelect = True
        Me.lstKeyColumns.Location = New System.Drawing.Point(6, 21)
        Me.lstKeyColumns.Name = "lstKeyColumns"
        Me.lstKeyColumns.Size = New System.Drawing.Size(185, 167)
        Me.lstKeyColumns.TabIndex = 12
        Me.lstKeyColumns.UseCompatibleStateImageBehavior = False
        Me.lstKeyColumns.View = System.Windows.Forms.View.Details
        '
        'lblKeyColumns
        '
        Me.lblKeyColumns.AutoSize = True
        Me.lblKeyColumns.Location = New System.Drawing.Point(3, 5)
        Me.lblKeyColumns.Name = "lblKeyColumns"
        Me.lblKeyColumns.Size = New System.Drawing.Size(68, 13)
        Me.lblKeyColumns.TabIndex = 17
        Me.lblKeyColumns.Text = "Key Columns"
        '
        'cmdRemoveSelectedPair
        '
        Me.cmdRemoveSelectedPair.Location = New System.Drawing.Point(6, 194)
        Me.cmdRemoveSelectedPair.Name = "cmdRemoveSelectedPair"
        Me.cmdRemoveSelectedPair.Size = New System.Drawing.Size(130, 23)
        Me.cmdRemoveSelectedPair.TabIndex = 17
        Me.cmdRemoveSelectedPair.Text = "Remove Selected Pair"
        Me.cmdRemoveSelectedPair.UseVisualStyleBackColor = True
        '
        'rdoByAllMatching
        '
        Me.rdoByAllMatching.AutoSize = True
        Me.rdoByAllMatching.Location = New System.Drawing.Point(8, 226)
        Me.rdoByAllMatching.Name = "rdoByAllMatching"
        Me.rdoByAllMatching.Size = New System.Drawing.Size(221, 17)
        Me.rdoByAllMatching.TabIndex = 22
        Me.rdoByAllMatching.TabStop = True
        Me.rdoByAllMatching.Text = "Merge by all columns with the same name"
        Me.rdoByAllMatching.UseVisualStyleBackColor = True
        '
        'rdoChooseColumns
        '
        Me.rdoChooseColumns.AutoSize = True
        Me.rdoChooseColumns.Location = New System.Drawing.Point(230, 226)
        Me.rdoChooseColumns.Name = "rdoChooseColumns"
        Me.rdoChooseColumns.Size = New System.Drawing.Size(192, 17)
        Me.rdoChooseColumns.TabIndex = 23
        Me.rdoChooseColumns.TabStop = True
        Me.rdoChooseColumns.Text = "Choose which columns to merge by"
        Me.rdoChooseColumns.UseVisualStyleBackColor = True
        '
        'grpKeys
        '
        Me.grpKeys.Controls.Add(Me.cmdAddPair)
        Me.grpKeys.Controls.Add(Me.lblFirstKeyMatch)
        Me.grpKeys.Controls.Add(Me.ucrReceiverSecondDF)
        Me.grpKeys.Controls.Add(Me.ucrReceiverFirstDF)
        Me.grpKeys.Location = New System.Drawing.Point(9, 251)
        Me.grpKeys.Name = "grpKeys"
        Me.grpKeys.Size = New System.Drawing.Size(335, 76)
        Me.grpKeys.TabIndex = 24
        Me.grpKeys.TabStop = False
        Me.grpKeys.Text = "Key Columns"
        '
        'cmdAddPair
        '
        Me.cmdAddPair.Location = New System.Drawing.Point(4, 46)
        Me.cmdAddPair.Name = "cmdAddPair"
        Me.cmdAddPair.Size = New System.Drawing.Size(118, 23)
        Me.cmdAddPair.TabIndex = 16
        Me.cmdAddPair.Text = "Add Pair"
        Me.cmdAddPair.UseVisualStyleBackColor = True
        '
        'lblFirstKeyMatch
        '
        Me.lblFirstKeyMatch.AutoSize = True
        Me.lblFirstKeyMatch.Location = New System.Drawing.Point(128, 22)
        Me.lblFirstKeyMatch.Name = "lblFirstKeyMatch"
        Me.lblFirstKeyMatch.Size = New System.Drawing.Size(74, 13)
        Me.lblFirstKeyMatch.TabIndex = 9
        Me.lblFirstKeyMatch.Text = "Matched With"
        '
        'ucrReceiverSecondDF
        '
        Me.ucrReceiverSecondDF.Location = New System.Drawing.Point(205, 20)
        Me.ucrReceiverSecondDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondDF.Name = "ucrReceiverSecondDF"
        Me.ucrReceiverSecondDF.Selector = Nothing
        Me.ucrReceiverSecondDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondDF.TabIndex = 8
        '
        'ucrReceiverFirstDF
        '
        Me.ucrReceiverFirstDF.Location = New System.Drawing.Point(4, 20)
        Me.ucrReceiverFirstDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstDF.Name = "ucrReceiverFirstDF"
        Me.ucrReceiverFirstDF.Selector = Nothing
        Me.ucrReceiverFirstDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstDF.TabIndex = 7
        '
        'ucrSelectorFirstDF
        '
        Me.ucrSelectorFirstDF.bShowHiddenColumns = False
        Me.ucrSelectorFirstDF.bUseCurrentFilter = True
        Me.ucrSelectorFirstDF.Location = New System.Drawing.Point(10, 34)
        Me.ucrSelectorFirstDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFirstDF.Name = "ucrSelectorFirstDF"
        Me.ucrSelectorFirstDF.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFirstDF.TabIndex = 25
        '
        'ucrSelectorSecondDF
        '
        Me.ucrSelectorSecondDF.bShowHiddenColumns = False
        Me.ucrSelectorSecondDF.bUseCurrentFilter = True
        Me.ucrSelectorSecondDF.Location = New System.Drawing.Point(226, 34)
        Me.ucrSelectorSecondDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSecondDF.Name = "ucrSelectorSecondDF"
        Me.ucrSelectorSecondDF.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorSecondDF.TabIndex = 26
        '
        'cmdJoinOptions
        '
        Me.cmdJoinOptions.Location = New System.Drawing.Point(9, 333)
        Me.cmdJoinOptions.Name = "cmdJoinOptions"
        Me.cmdJoinOptions.Size = New System.Drawing.Size(115, 23)
        Me.cmdJoinOptions.TabIndex = 27
        Me.cmdJoinOptions.Text = "Join Options"
        Me.cmdJoinOptions.UseVisualStyleBackColor = True
        '
        'dlgMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.cmdJoinOptions)
        Me.Controls.Add(Me.ucrSelectorSecondDF)
        Me.Controls.Add(Me.ucrSelectorFirstDF)
        Me.Controls.Add(Me.grpKeys)
        Me.Controls.Add(Me.rdoChooseColumns)
        Me.Controls.Add(Me.rdoByAllMatching)
        Me.Controls.Add(Me.pnlKeyColumns)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.lblSecondDataFrame)
        Me.Controls.Add(Me.lblFirstDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Merge"
        Me.Text = "Merge"
        Me.pnlKeyColumns.ResumeLayout(False)
        Me.pnlKeyColumns.PerformLayout()
        Me.grpKeys.ResumeLayout(False)
        Me.grpKeys.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFirstDataFrame As Label
    Friend WithEvents lblSecondDataFrame As Label
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrNewDataFrameName As ucrInputTextBox
    Friend WithEvents pnlKeyColumns As Panel
    Friend WithEvents lstKeyColumns As ListView
    Friend WithEvents lblKeyColumns As Label
    Friend WithEvents cmdRemoveSelectedPair As Button
    Friend WithEvents rdoByAllMatching As RadioButton
    Friend WithEvents rdoChooseColumns As RadioButton
    Friend WithEvents grpKeys As GroupBox
    Friend WithEvents cmdAddPair As Button
    Friend WithEvents lblFirstKeyMatch As Label
    Friend WithEvents ucrReceiverSecondDF As ucrReceiverSingle
    Friend WithEvents ucrReceiverFirstDF As ucrReceiverSingle
    Friend WithEvents ucrSelectorFirstDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorSecondDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdRemoveAll As Button
    Friend WithEvents cmdJoinOptions As Button
End Class
