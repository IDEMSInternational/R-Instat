﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDefineCRI
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
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAddComponent = New System.Windows.Forms.Button()
        Me.lblReceiverRedFlag = New System.Windows.Forms.Label()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.lblIndexComponentsList = New System.Windows.Forms.Label()
        Me.lstIndexComponents = New System.Windows.Forms.ListView()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.ucrSaveCRI = New instat.ucrSave()
        Me.ucrInputCRIPreview = New instat.ucrInputTextBox()
        Me.ucrNudWeights = New instat.ucrNud()
        Me.ucrGridWeights = New instat.ucrFactor()
        Me.ucrReceiverRedFlag = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorCRI = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkScaleNumeric = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(533, 158)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(58, 23)
        Me.cmdEdit.TabIndex = 4
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(597, 158)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(58, 23)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAddComponent
        '
        Me.cmdAddComponent.Location = New System.Drawing.Point(396, 92)
        Me.cmdAddComponent.Name = "cmdAddComponent"
        Me.cmdAddComponent.Size = New System.Drawing.Size(133, 23)
        Me.cmdAddComponent.TabIndex = 6
        Me.cmdAddComponent.Text = "Add Component of Index"
        Me.cmdAddComponent.UseVisualStyleBackColor = True
        '
        'lblReceiverRedFlag
        '
        Me.lblReceiverRedFlag.AutoSize = True
        Me.lblReceiverRedFlag.Location = New System.Drawing.Point(237, 44)
        Me.lblReceiverRedFlag.Name = "lblReceiverRedFlag"
        Me.lblReceiverRedFlag.Size = New System.Drawing.Size(64, 13)
        Me.lblReceiverRedFlag.TabIndex = 7
        Me.lblReceiverRedFlag.Text = "Component:"
        '
        'lblWeights
        '
        Me.lblWeights.AutoSize = True
        Me.lblWeights.Location = New System.Drawing.Point(237, 98)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(49, 13)
        Me.lblWeights.TabIndex = 8
        Me.lblWeights.Text = "Weights:"
        '
        'lblIndexComponentsList
        '
        Me.lblIndexComponentsList.AutoSize = True
        Me.lblIndexComponentsList.Location = New System.Drawing.Point(535, 42)
        Me.lblIndexComponentsList.Name = "lblIndexComponentsList"
        Me.lblIndexComponentsList.Size = New System.Drawing.Size(98, 13)
        Me.lblIndexComponentsList.TabIndex = 9
        Me.lblIndexComponentsList.Text = "Index Components:"
        '
        'lstIndexComponents
        '
        Me.lstIndexComponents.FullRowSelect = True
        Me.lstIndexComponents.Location = New System.Drawing.Point(534, 59)
        Me.lstIndexComponents.Name = "lstIndexComponents"
        Me.lstIndexComponents.Size = New System.Drawing.Size(122, 93)
        Me.lstIndexComponents.TabIndex = 14
        Me.lstIndexComponents.UseCompatibleStateImageBehavior = False
        Me.lstIndexComponents.View = System.Windows.Forms.View.Details
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(8, 295)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(80, 13)
        Me.lblModelPreview.TabIndex = 15
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'ucrSaveCRI
        '
        Me.ucrSaveCRI.Location = New System.Drawing.Point(10, 320)
        Me.ucrSaveCRI.Name = "ucrSaveCRI"
        Me.ucrSaveCRI.Size = New System.Drawing.Size(276, 24)
        Me.ucrSaveCRI.TabIndex = 17
        '
        'ucrInputCRIPreview
        '
        Me.ucrInputCRIPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputCRIPreview.IsMultiline = False
        Me.ucrInputCRIPreview.IsReadOnly = False
        Me.ucrInputCRIPreview.Location = New System.Drawing.Point(92, 292)
        Me.ucrInputCRIPreview.Name = "ucrInputCRIPreview"
        Me.ucrInputCRIPreview.Size = New System.Drawing.Size(437, 21)
        Me.ucrInputCRIPreview.TabIndex = 16
        '
        'ucrNudWeights
        '
        Me.ucrNudWeights.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWeights.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWeights.Location = New System.Drawing.Point(292, 95)
        Me.ucrNudWeights.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWeights.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWeights.Name = "ucrNudWeights"
        Me.ucrNudWeights.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWeights.TabIndex = 13
        Me.ucrNudWeights.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrGridWeights
        '
        Me.ucrGridWeights.AutoSize = True
        Me.ucrGridWeights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrGridWeights.clsReceiver = Nothing
        Me.ucrGridWeights.Location = New System.Drawing.Point(239, 114)
        Me.ucrGridWeights.Name = "ucrGridWeights"
        Me.ucrGridWeights.shtCurrSheet = Nothing
        Me.ucrGridWeights.Size = New System.Drawing.Size(290, 141)
        Me.ucrGridWeights.TabIndex = 12
        '
        'ucrReceiverRedFlag
        '
        Me.ucrReceiverRedFlag.frmParent = Me
        Me.ucrReceiverRedFlag.Location = New System.Drawing.Point(239, 59)
        Me.ucrReceiverRedFlag.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRedFlag.Name = "ucrReceiverRedFlag"
        Me.ucrReceiverRedFlag.Selector = Nothing
        Me.ucrReceiverRedFlag.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRedFlag.TabIndex = 11
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 350)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrSelectorCRI
        '
        Me.ucrSelectorCRI.bShowHiddenColumns = False
        Me.ucrSelectorCRI.bUseCurrentFilter = True
        Me.ucrSelectorCRI.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorCRI.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCRI.Name = "ucrSelectorCRI"
        Me.ucrSelectorCRI.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCRI.TabIndex = 2
        '
        'ucrChkScaleNumeric
        '
        Me.ucrChkScaleNumeric.Checked = False
        Me.ucrChkScaleNumeric.Location = New System.Drawing.Point(535, 187)
        Me.ucrChkScaleNumeric.Name = "ucrChkScaleNumeric"
        Me.ucrChkScaleNumeric.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkScaleNumeric.TabIndex = 1
        '
        'dlgDefineCRI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 414)
        Me.Controls.Add(Me.ucrSaveCRI)
        Me.Controls.Add(Me.ucrInputCRIPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.lstIndexComponents)
        Me.Controls.Add(Me.ucrNudWeights)
        Me.Controls.Add(Me.ucrGridWeights)
        Me.Controls.Add(Me.ucrReceiverRedFlag)
        Me.Controls.Add(Me.lblIndexComponentsList)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.lblReceiverRedFlag)
        Me.Controls.Add(Me.cmdAddComponent)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorCRI)
        Me.Controls.Add(Me.ucrChkScaleNumeric)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineCRI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define CRI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkScaleNumeric As ucrCheck
    Friend WithEvents ucrSelectorCRI As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdAddComponent As Button
    Friend WithEvents lblReceiverRedFlag As Label
    Friend WithEvents lblWeights As Label
    Friend WithEvents lblIndexComponentsList As Label
    Friend WithEvents ucrReceiverRedFlag As ucrReceiverSingle
    Friend WithEvents ucrNudWeights As ucrNud
    Friend WithEvents ucrGridWeights As ucrFactor
    Friend WithEvents lstIndexComponents As ListView
    Friend WithEvents ucrInputCRIPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrSaveCRI As ucrSave
End Class
