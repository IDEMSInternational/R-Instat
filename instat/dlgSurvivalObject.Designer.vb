﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSurvivalObject
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
        Me.lblEntryTime = New System.Windows.Forms.Label()
        Me.lblExitTime2 = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.rdoInterval = New System.Windows.Forms.RadioButton()
        Me.rdoCounting = New System.Windows.Forms.RadioButton()
        Me.rdoMstate = New System.Windows.Forms.RadioButton()
        Me.rdoInterval2 = New System.Windows.Forms.RadioButton()
        Me.ucrInputOrigin = New instat.ucrInputTextBox()
        Me.ucrPnlType = New instat.UcrPanel()
        Me.ucrSaveObject = New instat.ucrSave()
        Me.ucrReceiverEvent = New instat.ucrReceiverSingle()
        Me.ucrReceiverTime2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverTime1 = New instat.ucrReceiverSingle()
        Me.ucrSelectorFitObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkModifyEvent = New instat.ucrCheck()
        Me.ucrModifyEventNumeric = New instat.ucrInputTextBox()
        Me.lblSelectLevels = New System.Windows.Forms.Label()
        Me.ucrModifyEventFactor = New instat.ucrFactor()
        Me.SuspendLayout()
        '
        'lblEntryTime
        '
        Me.lblEntryTime.Location = New System.Drawing.Point(281, 60)
        Me.lblEntryTime.Name = "lblEntryTime"
        Me.lblEntryTime.Size = New System.Drawing.Size(83, 15)
        Me.lblEntryTime.TabIndex = 1
        Me.lblEntryTime.Text = "Entry Time:"
        '
        'lblExitTime2
        '
        Me.lblExitTime2.Location = New System.Drawing.Point(281, 107)
        Me.lblExitTime2.Name = "lblExitTime2"
        Me.lblExitTime2.Size = New System.Drawing.Size(83, 15)
        Me.lblExitTime2.TabIndex = 3
        Me.lblExitTime2.Text = "Exit Time:"
        '
        'lblEvent
        '
        Me.lblEvent.Location = New System.Drawing.Point(281, 154)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(83, 15)
        Me.lblEvent.TabIndex = 5
        Me.lblEvent.Text = "Event:"
        '
        'lblOrigin
        '
        Me.lblOrigin.Location = New System.Drawing.Point(281, 213)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(83, 15)
        Me.lblOrigin.TabIndex = 9
        Me.lblOrigin.Text = "Origin:"
        '
        'rdoRight
        '
        Me.rdoRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRight.FlatAppearance.BorderSize = 2
        Me.rdoRight.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRight.Location = New System.Drawing.Point(7, 14)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(71, 27)
        Me.rdoRight.TabIndex = 14
        Me.rdoRight.TabStop = True
        Me.rdoRight.Text = "Right"
        Me.rdoRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'rdoLeft
        '
        Me.rdoLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLeft.FlatAppearance.BorderSize = 2
        Me.rdoLeft.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeft.Location = New System.Drawing.Point(76, 14)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(71, 27)
        Me.rdoLeft.TabIndex = 16
        Me.rdoLeft.TabStop = True
        Me.rdoLeft.Text = "Left"
        Me.rdoLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'rdoInterval
        '
        Me.rdoInterval.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInterval.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInterval.FlatAppearance.BorderSize = 2
        Me.rdoInterval.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInterval.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoInterval.Location = New System.Drawing.Point(214, 14)
        Me.rdoInterval.Name = "rdoInterval"
        Me.rdoInterval.Size = New System.Drawing.Size(71, 27)
        Me.rdoInterval.TabIndex = 18
        Me.rdoInterval.TabStop = True
        Me.rdoInterval.Text = "Interval"
        Me.rdoInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInterval.UseVisualStyleBackColor = True
        '
        'rdoCounting
        '
        Me.rdoCounting.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCounting.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCounting.FlatAppearance.BorderSize = 2
        Me.rdoCounting.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCounting.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCounting.Location = New System.Drawing.Point(145, 14)
        Me.rdoCounting.Name = "rdoCounting"
        Me.rdoCounting.Size = New System.Drawing.Size(71, 27)
        Me.rdoCounting.TabIndex = 17
        Me.rdoCounting.TabStop = True
        Me.rdoCounting.Text = "Counting Process"
        Me.rdoCounting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCounting.UseVisualStyleBackColor = True
        '
        'rdoMstate
        '
        Me.rdoMstate.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMstate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMstate.FlatAppearance.BorderSize = 2
        Me.rdoMstate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMstate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMstate.Location = New System.Drawing.Point(352, 14)
        Me.rdoMstate.Name = "rdoMstate"
        Me.rdoMstate.Size = New System.Drawing.Size(71, 27)
        Me.rdoMstate.TabIndex = 20
        Me.rdoMstate.TabStop = True
        Me.rdoMstate.Text = "Multistate"
        Me.rdoMstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMstate.UseVisualStyleBackColor = True
        '
        'rdoInterval2
        '
        Me.rdoInterval2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInterval2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInterval2.FlatAppearance.BorderSize = 2
        Me.rdoInterval2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInterval2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInterval2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoInterval2.Location = New System.Drawing.Point(283, 14)
        Me.rdoInterval2.Name = "rdoInterval2"
        Me.rdoInterval2.Size = New System.Drawing.Size(71, 27)
        Me.rdoInterval2.TabIndex = 19
        Me.rdoInterval2.TabStop = True
        Me.rdoInterval2.Text = "Interval2"
        Me.rdoInterval2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rdoInterval2.UseVisualStyleBackColor = True
        '
        'ucrInputOrigin
        '
        Me.ucrInputOrigin.AddQuotesIfUnrecognised = True
        Me.ucrInputOrigin.IsMultiline = False
        Me.ucrInputOrigin.IsReadOnly = False
        Me.ucrInputOrigin.Location = New System.Drawing.Point(281, 231)
        Me.ucrInputOrigin.Name = "ucrInputOrigin"
        Me.ucrInputOrigin.Size = New System.Drawing.Size(73, 21)
        Me.ucrInputOrigin.TabIndex = 21
        '
        'ucrPnlType
        '
        Me.ucrPnlType.Location = New System.Drawing.Point(0, 10)
        Me.ucrPnlType.Name = "ucrPnlType"
        Me.ucrPnlType.Size = New System.Drawing.Size(437, 36)
        Me.ucrPnlType.TabIndex = 13
        '
        'ucrSaveObject
        '
        Me.ucrSaveObject.Location = New System.Drawing.Point(10, 247)
        Me.ucrSaveObject.Name = "ucrSaveObject"
        Me.ucrSaveObject.Size = New System.Drawing.Size(266, 24)
        Me.ucrSaveObject.TabIndex = 11
        '
        'ucrReceiverEvent
        '
        Me.ucrReceiverEvent.frmParent = Me
        Me.ucrReceiverEvent.Location = New System.Drawing.Point(281, 170)
        Me.ucrReceiverEvent.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvent.Name = "ucrReceiverEvent"
        Me.ucrReceiverEvent.Selector = Nothing
        Me.ucrReceiverEvent.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverEvent.strNcFilePath = ""
        Me.ucrReceiverEvent.TabIndex = 6
        Me.ucrReceiverEvent.ucrSelector = Nothing
        '
        'ucrReceiverTime2
        '
        Me.ucrReceiverTime2.frmParent = Me
        Me.ucrReceiverTime2.Location = New System.Drawing.Point(281, 123)
        Me.ucrReceiverTime2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTime2.Name = "ucrReceiverTime2"
        Me.ucrReceiverTime2.Selector = Nothing
        Me.ucrReceiverTime2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTime2.strNcFilePath = ""
        Me.ucrReceiverTime2.TabIndex = 4
        Me.ucrReceiverTime2.ucrSelector = Nothing
        '
        'ucrReceiverTime1
        '
        Me.ucrReceiverTime1.frmParent = Me
        Me.ucrReceiverTime1.Location = New System.Drawing.Point(281, 76)
        Me.ucrReceiverTime1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTime1.Name = "ucrReceiverTime1"
        Me.ucrReceiverTime1.Selector = Nothing
        Me.ucrReceiverTime1.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTime1.strNcFilePath = ""
        Me.ucrReceiverTime1.TabIndex = 2
        Me.ucrReceiverTime1.ucrSelector = Nothing
        '
        'ucrSelectorFitObject
        '
        Me.ucrSelectorFitObject.bDropUnusedFilterLevels = False
        Me.ucrSelectorFitObject.bShowHiddenColumns = False
        Me.ucrSelectorFitObject.bUseCurrentFilter = True
        Me.ucrSelectorFitObject.Location = New System.Drawing.Point(9, 49)
        Me.ucrSelectorFitObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFitObject.Name = "ucrSelectorFitObject"
        Me.ucrSelectorFitObject.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFitObject.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 277)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrChkModifyEvent
        '
        Me.ucrChkModifyEvent.Checked = False
        Me.ucrChkModifyEvent.Location = New System.Drawing.Point(319, 193)
        Me.ucrChkModifyEvent.Name = "ucrChkModifyEvent"
        Me.ucrChkModifyEvent.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkModifyEvent.TabIndex = 22
        '
        'ucrModifyEventNumeric
        '
        Me.ucrModifyEventNumeric.AddQuotesIfUnrecognised = True
        Me.ucrModifyEventNumeric.IsMultiline = False
        Me.ucrModifyEventNumeric.IsReadOnly = False
        Me.ucrModifyEventNumeric.Location = New System.Drawing.Point(440, 213)
        Me.ucrModifyEventNumeric.Name = "ucrModifyEventNumeric"
        Me.ucrModifyEventNumeric.Size = New System.Drawing.Size(120, 26)
        Me.ucrModifyEventNumeric.TabIndex = 25
        '
        'lblSelectLevels
        '
        Me.lblSelectLevels.AutoSize = True
        Me.lblSelectLevels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectLevels.Location = New System.Drawing.Point(439, 197)
        Me.lblSelectLevels.Name = "lblSelectLevels"
        Me.lblSelectLevels.Size = New System.Drawing.Size(176, 13)
        Me.lblSelectLevels.TabIndex = 24
        Me.lblSelectLevels.Text = "Event occurs when variable equals:"
        '
        'ucrModifyEventFactor
        '
        Me.ucrModifyEventFactor.AutoSize = True
        Me.ucrModifyEventFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrModifyEventFactor.clsReceiver = Nothing
        Me.ucrModifyEventFactor.Location = New System.Drawing.Point(440, 213)
        Me.ucrModifyEventFactor.Name = "ucrModifyEventFactor"
        Me.ucrModifyEventFactor.shtCurrSheet = Nothing
        Me.ucrModifyEventFactor.Size = New System.Drawing.Size(197, 116)
        Me.ucrModifyEventFactor.TabIndex = 23
        Me.ucrModifyEventFactor.ucrChkLevels = Nothing
        '
        'dlgSurvivalObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 339)
        Me.Controls.Add(Me.ucrModifyEventNumeric)
        Me.Controls.Add(Me.lblSelectLevels)
        Me.Controls.Add(Me.ucrModifyEventFactor)
        Me.Controls.Add(Me.ucrChkModifyEvent)
        Me.Controls.Add(Me.ucrInputOrigin)
        Me.Controls.Add(Me.rdoMstate)
        Me.Controls.Add(Me.rdoInterval2)
        Me.Controls.Add(Me.rdoInterval)
        Me.Controls.Add(Me.rdoCounting)
        Me.Controls.Add(Me.rdoLeft)
        Me.Controls.Add(Me.rdoRight)
        Me.Controls.Add(Me.ucrPnlType)
        Me.Controls.Add(Me.ucrSaveObject)
        Me.Controls.Add(Me.lblOrigin)
        Me.Controls.Add(Me.lblEvent)
        Me.Controls.Add(Me.lblExitTime2)
        Me.Controls.Add(Me.ucrReceiverEvent)
        Me.Controls.Add(Me.lblEntryTime)
        Me.Controls.Add(Me.ucrReceiverTime2)
        Me.Controls.Add(Me.ucrReceiverTime1)
        Me.Controls.Add(Me.ucrSelectorFitObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSurvivalObject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Survival Object"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverTime2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverTime1 As ucrReceiverSingle
    Friend WithEvents ucrSelectorFitObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverEvent As ucrReceiverSingle
    Friend WithEvents ucrSaveObject As ucrSave
    Friend WithEvents lblOrigin As Label
    Friend WithEvents lblEvent As Label
    Friend WithEvents lblExitTime2 As Label
    Friend WithEvents lblEntryTime As Label
    Friend WithEvents rdoMstate As RadioButton
    Friend WithEvents rdoInterval2 As RadioButton
    Friend WithEvents rdoInterval As RadioButton
    Friend WithEvents rdoCounting As RadioButton
    Friend WithEvents rdoLeft As RadioButton
    Friend WithEvents rdoRight As RadioButton
    Friend WithEvents ucrPnlType As UcrPanel
    Friend WithEvents ucrInputOrigin As ucrInputTextBox
    Friend WithEvents ucrChkModifyEvent As ucrCheck
    Friend WithEvents ucrModifyEventNumeric As ucrInputTextBox
    Friend WithEvents lblSelectLevels As Label
    Friend WithEvents ucrModifyEventFactor As ucrFactor
End Class
