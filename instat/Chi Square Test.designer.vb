﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgChiSquareTest
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
        Me.lblLayoutOfData = New System.Windows.Forms.Label()
        Me.cboLayoutOfData = New System.Windows.Forms.ComboBox()
        Me.chkContinuityCorrection = New System.Windows.Forms.CheckBox()
        Me.chkSaveValues = New System.Windows.Forms.CheckBox()
        Me.lblDataColumns = New System.Windows.Forms.Label()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblLayoutOfData
        '
        Me.lblLayoutOfData.AutoSize = True
        Me.lblLayoutOfData.Location = New System.Drawing.Point(13, 183)
        Me.lblLayoutOfData.Name = "lblLayoutOfData"
        Me.lblLayoutOfData.Size = New System.Drawing.Size(75, 13)
        Me.lblLayoutOfData.TabIndex = 0
        Me.lblLayoutOfData.Tag = "Layout_of_data"
        Me.lblLayoutOfData.Text = "Layout of data"
        '
        'cboLayoutOfData
        '
        Me.cboLayoutOfData.FormattingEnabled = True
        Me.cboLayoutOfData.Items.AddRange(New Object() {"Multiple Data Columns", "Data Column and Two Factors", "Column of TABLE Counts"})
        Me.cboLayoutOfData.Location = New System.Drawing.Point(16, 209)
        Me.cboLayoutOfData.Name = "cboLayoutOfData"
        Me.cboLayoutOfData.Size = New System.Drawing.Size(121, 21)
        Me.cboLayoutOfData.TabIndex = 1
        '
        'chkContinuityCorrection
        '
        Me.chkContinuityCorrection.AutoSize = True
        Me.chkContinuityCorrection.Location = New System.Drawing.Point(224, 179)
        Me.chkContinuityCorrection.Name = "chkContinuityCorrection"
        Me.chkContinuityCorrection.Size = New System.Drawing.Size(122, 17)
        Me.chkContinuityCorrection.TabIndex = 4
        Me.chkContinuityCorrection.Tag = "Continuity_correction"
        Me.chkContinuityCorrection.Text = "Continuity correction"
        Me.chkContinuityCorrection.UseVisualStyleBackColor = True
        '
        'chkSaveValues
        '
        Me.chkSaveValues.AutoSize = True
        Me.chkSaveValues.Location = New System.Drawing.Point(224, 237)
        Me.chkSaveValues.Name = "chkSaveValues"
        Me.chkSaveValues.Size = New System.Drawing.Size(85, 17)
        Me.chkSaveValues.TabIndex = 5
        Me.chkSaveValues.Tag = "Save_values"
        Me.chkSaveValues.Text = "Save values"
        Me.chkSaveValues.UseVisualStyleBackColor = True
        '
        'lblDataColumns
        '
        Me.lblDataColumns.AutoSize = True
        Me.lblDataColumns.Location = New System.Drawing.Point(221, 9)
        Me.lblDataColumns.Name = "lblDataColumns"
        Me.lblDataColumns.Size = New System.Drawing.Size(73, 13)
        Me.lblDataColumns.TabIndex = 6
        Me.lblDataColumns.Tag = "Data_Columns"
        Me.lblDataColumns.Text = "Data Columns"
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(16, 13)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrAddRemove.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(1, 315)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 3
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(224, 30)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(91, 101)
        Me.ucrReceiverMultiple.TabIndex = 2
        '
        'dlgChiSquareTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 349)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.lblDataColumns)
        Me.Controls.Add(Me.chkSaveValues)
        Me.Controls.Add(Me.chkContinuityCorrection)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.cboLayoutOfData)
        Me.Controls.Add(Me.lblLayoutOfData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgChiSquareTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chi-Square Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLayoutOfData As Label
    Friend WithEvents cboLayoutOfData As ComboBox
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkContinuityCorrection As CheckBox
    Friend WithEvents chkSaveValues As CheckBox
    Friend WithEvents lblDataColumns As Label
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
End Class
