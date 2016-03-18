﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgUnstack
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
        Me.lblFactorToUnstackBy = New System.Windows.Forms.Label()
        Me.lblColumnToUnstack = New System.Windows.Forms.Label()
        Me.chkKeepUnusedFactorLevels = New System.Windows.Forms.CheckBox()
        Me.lblDataFrameForUnstack = New System.Windows.Forms.Label()
        Me.chkCarryAllColumns = New System.Windows.Forms.CheckBox()
        Me.ucrColumnsToCarry = New instat.ucrReceiverMultiple()
        Me.ucrDataFrameForunstack = New instat.ucrVariableName()
        Me.ucrColumnTounstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorTounstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorForunstack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactorToUnstackBy
        '
        Me.lblFactorToUnstackBy.AutoSize = True
        Me.lblFactorToUnstackBy.Location = New System.Drawing.Point(258, 16)
        Me.lblFactorToUnstackBy.Name = "lblFactorToUnstackBy"
        Me.lblFactorToUnstackBy.Size = New System.Drawing.Size(107, 13)
        Me.lblFactorToUnstackBy.TabIndex = 1
        Me.lblFactorToUnstackBy.Tag = "Factor_to_Unstack_By"
        Me.lblFactorToUnstackBy.Text = "Factor to Unstack By"
        '
        'lblColumnToUnstack
        '
        Me.lblColumnToUnstack.AutoSize = True
        Me.lblColumnToUnstack.Location = New System.Drawing.Point(255, 69)
        Me.lblColumnToUnstack.Name = "lblColumnToUnstack"
        Me.lblColumnToUnstack.Size = New System.Drawing.Size(97, 13)
        Me.lblColumnToUnstack.TabIndex = 3
        Me.lblColumnToUnstack.Tag = "Column_to_Unstack"
        Me.lblColumnToUnstack.Text = "Column to Unstack"
        '
        'chkKeepUnusedFactorLevels
        '
        Me.chkKeepUnusedFactorLevels.AutoSize = True
        Me.chkKeepUnusedFactorLevels.Location = New System.Drawing.Point(12, 197)
        Me.chkKeepUnusedFactorLevels.Name = "chkKeepUnusedFactorLevels"
        Me.chkKeepUnusedFactorLevels.Size = New System.Drawing.Size(158, 17)
        Me.chkKeepUnusedFactorLevels.TabIndex = 7
        Me.chkKeepUnusedFactorLevels.Tag = "Keep_Unused_Factor_Levels"
        Me.chkKeepUnusedFactorLevels.Text = "Keep Unused Factor Levels"
        Me.chkKeepUnusedFactorLevels.UseVisualStyleBackColor = True
        '
        'lblDataFrameForUnstack
        '
        Me.lblDataFrameForUnstack.AutoSize = True
        Me.lblDataFrameForUnstack.Location = New System.Drawing.Point(-2, 293)
        Me.lblDataFrameForUnstack.Name = "lblDataFrameForUnstack"
        Me.lblDataFrameForUnstack.Size = New System.Drawing.Size(118, 13)
        Me.lblDataFrameForUnstack.TabIndex = 10
        Me.lblDataFrameForUnstack.Tag = "New_Data_Frame_Name"
        Me.lblDataFrameForUnstack.Text = "New Data Frame Name"
        '
        'chkCarryAllColumns
        '
        Me.chkCarryAllColumns.AutoSize = True
        Me.chkCarryAllColumns.Location = New System.Drawing.Point(258, 120)
        Me.chkCarryAllColumns.Name = "chkCarryAllColumns"
        Me.chkCarryAllColumns.Size = New System.Drawing.Size(106, 17)
        Me.chkCarryAllColumns.TabIndex = 11
        Me.chkCarryAllColumns.Tag = "Carry_All_Columns"
        Me.chkCarryAllColumns.Text = "Carry all Columns"
        Me.chkCarryAllColumns.UseVisualStyleBackColor = True
        '
        'ucrColumnsToCarry
        '
        Me.ucrColumnsToCarry.Location = New System.Drawing.Point(256, 143)
        Me.ucrColumnsToCarry.Name = "ucrColumnsToCarry"
        Me.ucrColumnsToCarry.Selector = Nothing
        Me.ucrColumnsToCarry.Size = New System.Drawing.Size(121, 104)
        Me.ucrColumnsToCarry.TabIndex = 12
        '
        'ucrDataFrameForunstack
        '
        Me.ucrDataFrameForunstack.Location = New System.Drawing.Point(140, 283)
        Me.ucrDataFrameForunstack.Name = "ucrDataFrameForunstack"
        Me.ucrDataFrameForunstack.Size = New System.Drawing.Size(149, 23)
        Me.ucrDataFrameForunstack.TabIndex = 9
        '
        'ucrColumnTounstackReceiver
        '
        Me.ucrColumnTounstackReceiver.Location = New System.Drawing.Point(256, 87)
        Me.ucrColumnTounstackReceiver.Name = "ucrColumnTounstackReceiver"
        Me.ucrColumnTounstackReceiver.Selector = Nothing
        Me.ucrColumnTounstackReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrColumnTounstackReceiver.TabIndex = 4
        '
        'ucrFactorTounstackReceiver
        '
        Me.ucrFactorTounstackReceiver.Location = New System.Drawing.Point(256, 40)
        Me.ucrFactorTounstackReceiver.Name = "ucrFactorTounstackReceiver"
        Me.ucrFactorTounstackReceiver.Selector = Nothing
        Me.ucrFactorTounstackReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorTounstackReceiver.TabIndex = 2
        '
        'ucrSelectorForunstack
        '
        Me.ucrSelectorForunstack.Location = New System.Drawing.Point(1, 12)
        Me.ucrSelectorForunstack.Name = "ucrSelectorForunstack"
        Me.ucrSelectorForunstack.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForunstack.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 312)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 8
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 380)
        Me.Controls.Add(Me.ucrColumnsToCarry)
        Me.Controls.Add(Me.chkCarryAllColumns)
        Me.Controls.Add(Me.lblDataFrameForUnstack)
        Me.Controls.Add(Me.ucrDataFrameForunstack)
        Me.Controls.Add(Me.ucrColumnTounstackReceiver)
        Me.Controls.Add(Me.ucrFactorTounstackReceiver)
        Me.Controls.Add(Me.chkKeepUnusedFactorLevels)
        Me.Controls.Add(Me.lblColumnToUnstack)
        Me.Controls.Add(Me.lblFactorToUnstackBy)
        Me.Controls.Add(Me.ucrSelectorForunstack)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgUnstack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Unstack_Columns"
        Me.Text = "Unstack Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForunstack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorToUnstackBy As Label
    Friend WithEvents lblColumnToUnstack As Label
    Friend WithEvents chkKeepUnusedFactorLevels As CheckBox
    Friend WithEvents ucrFactorTounstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrColumnTounstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrDataFrameForunstack As ucrVariableName
    Friend WithEvents lblDataFrameForUnstack As Label
    Friend WithEvents chkCarryAllColumns As CheckBox
    Friend WithEvents ucrColumnsToCarry As ucrReceiverMultiple
End Class
