﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStringDistance
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
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.rdoString = New System.Windows.Forms.RadioButton()
        Me.lblColumnString = New System.Windows.Forms.Label()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorStringDistance = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputComboBoxMethod = New instat.ucrInputComboBox()
        Me.ucrSaveStringDistance = New instat.ucrSave()
        Me.ucrInputPatternStringDistance = New instat.ucrInputTextBox()
        Me.ucrReceiverStringDistance = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlStringDist = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(250, 45)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 4
        Me.lblColumn.Text = "Column:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(250, 90)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(44, 13)
        Me.lblPattern.TabIndex = 3
        Me.lblPattern.Text = "Pattern:"
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Location = New System.Drawing.Point(250, 136)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 8
        Me.lblMethod.Text = "Method:"
        '
        'rdoColumn
        '
        Me.rdoColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumn.FlatAppearance.BorderSize = 2
        Me.rdoColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColumn.Location = New System.Drawing.Point(310, 10)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(61, 27)
        Me.rdoColumn.TabIndex = 3
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.Text = "Column"
        Me.rdoColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'rdoString
        '
        Me.rdoString.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoString.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoString.FlatAppearance.BorderSize = 2
        Me.rdoString.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoString.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoString.Location = New System.Drawing.Point(250, 10)
        Me.rdoString.Name = "rdoString"
        Me.rdoString.Size = New System.Drawing.Size(61, 27)
        Me.rdoString.TabIndex = 2
        Me.rdoString.TabStop = True
        Me.rdoString.Text = "String"
        Me.rdoString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoString.UseVisualStyleBackColor = True
        '
        'lblColumnString
        '
        Me.lblColumnString.AutoSize = True
        Me.lblColumnString.Location = New System.Drawing.Point(250, 91)
        Me.lblColumnString.Name = "lblColumnString"
        Me.lblColumnString.Size = New System.Drawing.Size(54, 13)
        Me.lblColumnString.TabIndex = 6
        Me.lblColumnString.Text = "Column 2:"
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(250, 105)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 7
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrSelectorStringDistance
        '
        Me.ucrSelectorStringDistance.bShowHiddenColumns = False
        Me.ucrSelectorStringDistance.bUseCurrentFilter = True
        Me.ucrSelectorStringDistance.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorStringDistance.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStringDistance.Name = "ucrSelectorStringDistance"
        Me.ucrSelectorStringDistance.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStringDistance.TabIndex = 0
        '
        'ucrInputComboBoxMethod
        '
        Me.ucrInputComboBoxMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMethod.IsReadOnly = False
        Me.ucrInputComboBoxMethod.Location = New System.Drawing.Point(250, 151)
        Me.ucrInputComboBoxMethod.Name = "ucrInputComboBoxMethod"
        Me.ucrInputComboBoxMethod.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputComboBoxMethod.TabIndex = 9
        '
        'ucrSaveStringDistance
        '
        Me.ucrSaveStringDistance.Location = New System.Drawing.Point(10, 197)
        Me.ucrSaveStringDistance.Name = "ucrSaveStringDistance"
        Me.ucrSaveStringDistance.Size = New System.Drawing.Size(247, 24)
        Me.ucrSaveStringDistance.TabIndex = 10
        '
        'ucrInputPatternStringDistance
        '
        Me.ucrInputPatternStringDistance.AddQuotesIfUnrecognised = True
        Me.ucrInputPatternStringDistance.IsMultiline = False
        Me.ucrInputPatternStringDistance.IsReadOnly = False
        Me.ucrInputPatternStringDistance.Location = New System.Drawing.Point(250, 105)
        Me.ucrInputPatternStringDistance.Name = "ucrInputPatternStringDistance"
        Me.ucrInputPatternStringDistance.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPatternStringDistance.TabIndex = 4
        '
        'ucrReceiverStringDistance
        '
        Me.ucrReceiverStringDistance.frmParent = Me
        Me.ucrReceiverStringDistance.Location = New System.Drawing.Point(250, 60)
        Me.ucrReceiverStringDistance.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStringDistance.Name = "ucrReceiverStringDistance"
        Me.ucrReceiverStringDistance.Selector = Nothing
        Me.ucrReceiverStringDistance.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverStringDistance.strNcFilePath = ""
        Me.ucrReceiverStringDistance.TabIndex = 5
        Me.ucrReceiverStringDistance.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 227)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(399, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrPnlStringDist
        '
        Me.ucrPnlStringDist.Location = New System.Drawing.Point(241, 6)
        Me.ucrPnlStringDist.Name = "ucrPnlStringDist"
        Me.ucrPnlStringDist.Size = New System.Drawing.Size(145, 36)
        Me.ucrPnlStringDist.TabIndex = 1
        '
        'dlgStringDistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 285)
        Me.Controls.Add(Me.lblColumnString)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.rdoString)
        Me.Controls.Add(Me.rdoColumn)
        Me.Controls.Add(Me.ucrSelectorStringDistance)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.ucrInputComboBoxMethod)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrSaveStringDistance)
        Me.Controls.Add(Me.ucrInputPatternStringDistance)
        Me.Controls.Add(Me.ucrReceiverStringDistance)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlStringDist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStringDistance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Distance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverStringDistance As ucrReceiverSingle
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrInputComboBoxMethod As ucrInputComboBox
    Friend WithEvents lblPattern As Label
    Friend WithEvents lblColumn As Label
    Friend WithEvents ucrSaveStringDistance As ucrSave
    Friend WithEvents ucrInputPatternStringDistance As ucrInputTextBox
    Friend WithEvents ucrSelectorStringDistance As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoString As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents ucrPnlStringDist As UcrPanel
    Friend WithEvents lblColumnString As Label
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
End Class
