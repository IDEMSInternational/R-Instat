﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSplitText
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
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.lblSplitBy = New System.Windows.Forms.Label()
        Me.lblNumberofPiecesToReturn = New System.Windows.Forms.Label()
        Me.ucrInputPattern = New instat.ucrInputComboBox()
        Me.ucrReceiverSplitTextColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorSplitTextColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudPieces = New instat.ucrNud()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.Location = New System.Drawing.Point(271, 37)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(140, 23)
        Me.lblSelectedFactor.TabIndex = 1
        Me.lblSelectedFactor.Tag = "Selected_Factor"
        Me.lblSelectedFactor.Text = "Selected Factor:"
        '
        'lblSplitBy
        '
        Me.lblSplitBy.Location = New System.Drawing.Point(271, 81)
        Me.lblSplitBy.Name = "lblSplitBy"
        Me.lblSplitBy.Size = New System.Drawing.Size(140, 23)
        Me.lblSplitBy.TabIndex = 3
        Me.lblSplitBy.Tag = ""
        Me.lblSplitBy.Text = "Split by:"
        '
        'lblNumberofPiecesToReturn
        '
        Me.lblNumberofPiecesToReturn.Location = New System.Drawing.Point(269, 131)
        Me.lblNumberofPiecesToReturn.Name = "lblNumberofPiecesToReturn"
        Me.lblNumberofPiecesToReturn.Size = New System.Drawing.Size(149, 23)
        Me.lblNumberofPiecesToReturn.TabIndex = 5
        Me.lblNumberofPiecesToReturn.Tag = "Number_of_Pieces_to_Return"
        Me.lblNumberofPiecesToReturn.Text = "Number of Pieces to Return:"
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.bAddRemoveParameter = True
        Me.ucrInputPattern.bChangeParameterValue = True
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(272, 96)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPattern.TabIndex = 4
        '
        'ucrReceiverSplitTextColumn
        '
        Me.ucrReceiverSplitTextColumn.bAddRemoveParameter = True
        Me.ucrReceiverSplitTextColumn.bChangeParameterValue = True
        Me.ucrReceiverSplitTextColumn.frmParent = Me
        Me.ucrReceiverSplitTextColumn.Location = New System.Drawing.Point(272, 53)
        Me.ucrReceiverSplitTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSplitTextColumn.Name = "ucrReceiverSplitTextColumn"
        Me.ucrReceiverSplitTextColumn.Selector = Nothing
        Me.ucrReceiverSplitTextColumn.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverSplitTextColumn.TabIndex = 2
        '
        'ucrSelectorSplitTextColumn
        '
        Me.ucrSelectorSplitTextColumn.bAddRemoveParameter = True
        Me.ucrSelectorSplitTextColumn.bChangeParameterValue = True
        Me.ucrSelectorSplitTextColumn.bShowHiddenColumns = False
        Me.ucrSelectorSplitTextColumn.bUseCurrentFilter = True
        Me.ucrSelectorSplitTextColumn.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorSplitTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSplitTextColumn.Name = "ucrSelectorSplitTextColumn"
        Me.ucrSelectorSplitTextColumn.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorSplitTextColumn.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 230)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrNudPieces
        '
        Me.ucrNudPieces.bAddRemoveParameter = True
        Me.ucrNudPieces.bChangeParameterValue = True
        Me.ucrNudPieces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPieces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPieces.Location = New System.Drawing.Point(274, 153)
        Me.ucrNudPieces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPieces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPieces.Name = "ucrNudPieces"
        Me.ucrNudPieces.Size = New System.Drawing.Size(41, 20)
        Me.ucrNudPieces.TabIndex = 6
        Me.ucrNudPieces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.bAddRemoveParameter = True
        Me.ucrSaveColumn.bChangeParameterValue = True
        Me.ucrSaveColumn.Location = New System.Drawing.Point(10, 200)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(305, 24)
        Me.ucrSaveColumn.TabIndex = 7
        '
        'dlgSplitText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 288)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrNudPieces)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.ucrReceiverSplitTextColumn)
        Me.Controls.Add(Me.lblNumberofPiecesToReturn)
        Me.Controls.Add(Me.lblSplitBy)
        Me.Controls.Add(Me.lblSelectedFactor)
        Me.Controls.Add(Me.ucrSelectorSplitTextColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSplitText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Split_Text_Column"
        Me.Text = "Split Text Column"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorSplitTextColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedFactor As Label
    Friend WithEvents lblSplitBy As Label
    Friend WithEvents lblNumberofPiecesToReturn As Label
    Friend WithEvents ucrReceiverSplitTextColumn As ucrReceiverSingle
    Friend WithEvents ucrInputPattern As ucrInputComboBox
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents ucrNudPieces As ucrNud
End Class