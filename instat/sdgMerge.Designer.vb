<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgMerge
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
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.pnlKeyColumns = New System.Windows.Forms.Panel()
        Me.lstKeyColumns = New System.Windows.Forms.ListView()
        Me.lblKeyColumns = New System.Windows.Forms.Label()
        Me.cmdRemoveSelectedPair = New System.Windows.Forms.Button()
        Me.grpKeys = New System.Windows.Forms.GroupBox()
        Me.cmdAddAnotherPair = New System.Windows.Forms.Button()
        Me.lblFirstKeyMatch = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondDF = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstDF = New instat.ucrReceiverSingle()
        Me.lblSecondDataFrame = New System.Windows.Forms.Label()
        Me.lblFirstDataFrame = New System.Windows.Forms.Label()
        Me.ucrSelectorSecondDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorFirstDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.pnlKeyColumns.SuspendLayout()
        Me.grpKeys.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(289, 381)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 0
        '
        'pnlKeyColumns
        '
        Me.pnlKeyColumns.Controls.Add(Me.lstKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.lblKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveSelectedPair)
        Me.pnlKeyColumns.Location = New System.Drawing.Point(449, 159)
        Me.pnlKeyColumns.Name = "pnlKeyColumns"
        Me.pnlKeyColumns.Size = New System.Drawing.Size(298, 230)
        Me.pnlKeyColumns.TabIndex = 20
        '
        'lstKeyColumns
        '
        Me.lstKeyColumns.FullRowSelect = True
        Me.lstKeyColumns.Location = New System.Drawing.Point(6, 21)
        Me.lstKeyColumns.Name = "lstKeyColumns"
        Me.lstKeyColumns.Size = New System.Drawing.Size(280, 167)
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
        Me.cmdRemoveSelectedPair.Size = New System.Drawing.Size(118, 23)
        Me.cmdRemoveSelectedPair.TabIndex = 17
        Me.cmdRemoveSelectedPair.Text = "Remove Selected"
        Me.cmdRemoveSelectedPair.UseVisualStyleBackColor = True
        '
        'grpKeys
        '
        Me.grpKeys.Controls.Add(Me.cmdAddAnotherPair)
        Me.grpKeys.Controls.Add(Me.lblFirstKeyMatch)
        Me.grpKeys.Controls.Add(Me.ucrReceiverSecondDF)
        Me.grpKeys.Controls.Add(Me.ucrReceiverFirstDF)
        Me.grpKeys.Location = New System.Drawing.Point(11, 216)
        Me.grpKeys.Name = "grpKeys"
        Me.grpKeys.Size = New System.Drawing.Size(390, 105)
        Me.grpKeys.TabIndex = 21
        Me.grpKeys.TabStop = False
        Me.grpKeys.Text = "Key Columns"
        '
        'cmdAddAnotherPair
        '
        Me.cmdAddAnotherPair.Location = New System.Drawing.Point(12, 74)
        Me.cmdAddAnotherPair.Name = "cmdAddAnotherPair"
        Me.cmdAddAnotherPair.Size = New System.Drawing.Size(118, 23)
        Me.cmdAddAnotherPair.TabIndex = 16
        Me.cmdAddAnotherPair.Text = "Add Another Pair"
        Me.cmdAddAnotherPair.UseVisualStyleBackColor = True
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
        'ucrReceiverSecondDF
        '
        Me.ucrReceiverSecondDF.Location = New System.Drawing.Point(255, 32)
        Me.ucrReceiverSecondDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondDF.Name = "ucrReceiverSecondDF"
        Me.ucrReceiverSecondDF.Selector = Nothing
        Me.ucrReceiverSecondDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondDF.TabIndex = 8
        '
        'ucrReceiverFirstDF
        '
        Me.ucrReceiverFirstDF.Location = New System.Drawing.Point(12, 32)
        Me.ucrReceiverFirstDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstDF.Name = "ucrReceiverFirstDF"
        Me.ucrReceiverFirstDF.Selector = Nothing
        Me.ucrReceiverFirstDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstDF.TabIndex = 7
        '
        'lblSecondDataFrame
        '
        Me.lblSecondDataFrame.AutoSize = True
        Me.lblSecondDataFrame.Location = New System.Drawing.Point(228, 10)
        Me.lblSecondDataFrame.Name = "lblSecondDataFrame"
        Me.lblSecondDataFrame.Size = New System.Drawing.Size(151, 13)
        Me.lblSecondDataFrame.TabIndex = 25
        Me.lblSecondDataFrame.Text = "Second Data Frame To Merge"
        '
        'lblFirstDataFrame
        '
        Me.lblFirstDataFrame.AutoSize = True
        Me.lblFirstDataFrame.Location = New System.Drawing.Point(10, 8)
        Me.lblFirstDataFrame.Name = "lblFirstDataFrame"
        Me.lblFirstDataFrame.Size = New System.Drawing.Size(133, 13)
        Me.lblFirstDataFrame.TabIndex = 24
        Me.lblFirstDataFrame.Text = "First Data Frame To Merge"
        '
        'ucrSelectorSecondDataFrame
        '
        Me.ucrSelectorSecondDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorSecondDataFrame.bUseCurrentFilter = False
        Me.ucrSelectorSecondDataFrame.Location = New System.Drawing.Point(231, 23)
        Me.ucrSelectorSecondDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSecondDataFrame.Name = "ucrSelectorSecondDataFrame"
        Me.ucrSelectorSecondDataFrame.Size = New System.Drawing.Size(217, 180)
        Me.ucrSelectorSecondDataFrame.TabIndex = 23
        '
        'ucrSelectorFirstDataFrame
        '
        Me.ucrSelectorFirstDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorFirstDataFrame.bUseCurrentFilter = False
        Me.ucrSelectorFirstDataFrame.Location = New System.Drawing.Point(11, 21)
        Me.ucrSelectorFirstDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFirstDataFrame.Name = "ucrSelectorFirstDataFrame"
        Me.ucrSelectorFirstDataFrame.Size = New System.Drawing.Size(240, 180)
        Me.ucrSelectorFirstDataFrame.TabIndex = 22
        '
        'sdgMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 413)
        Me.Controls.Add(Me.lblSecondDataFrame)
        Me.Controls.Add(Me.lblFirstDataFrame)
        Me.Controls.Add(Me.ucrSelectorSecondDataFrame)
        Me.Controls.Add(Me.ucrSelectorFirstDataFrame)
        Me.Controls.Add(Me.grpKeys)
        Me.Controls.Add(Me.pnlKeyColumns)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMerge"
        Me.Text = "sdgMerge"
        Me.pnlKeyColumns.ResumeLayout(False)
        Me.pnlKeyColumns.PerformLayout()
        Me.grpKeys.ResumeLayout(False)
        Me.grpKeys.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents pnlKeyColumns As Panel
    Friend WithEvents lstKeyColumns As ListView
    Friend WithEvents lblKeyColumns As Label
    Friend WithEvents cmdRemoveSelectedPair As Button
    Friend WithEvents grpKeys As GroupBox
    Friend WithEvents cmdAddAnotherPair As Button
    Friend WithEvents lblFirstKeyMatch As Label
    Friend WithEvents ucrReceiverSecondDF As ucrReceiverSingle
    Friend WithEvents ucrReceiverFirstDF As ucrReceiverSingle
    Friend WithEvents lblSecondDataFrame As Label
    Friend WithEvents lblFirstDataFrame As Label
    Friend WithEvents ucrSelectorSecondDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorFirstDataFrame As ucrSelectorByDataFrameAddRemove
End Class
