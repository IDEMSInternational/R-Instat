﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgTransposeColumns
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
        Me.lblColumnsToTranspose = New System.Windows.Forms.Label()
        Me.ucrReceiverColumsToTranspose = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorTransposeColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrNewDataframe = New instat.ucrSave()
        Me.ucrChkNameNewColumns = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblColumnsToTranspose
        '
        Me.lblColumnsToTranspose.Location = New System.Drawing.Point(272, 30)
        Me.lblColumnsToTranspose.Name = "lblColumnsToTranspose"
        Me.lblColumnsToTranspose.Size = New System.Drawing.Size(133, 23)
        Me.lblColumnsToTranspose.TabIndex = 3
        Me.lblColumnsToTranspose.Tag = "Columns_to_Transpose"
        Me.lblColumnsToTranspose.Text = "Columns to Transpose:"
        '
        'ucrReceiverColumsToTranspose
        '
        Me.ucrReceiverColumsToTranspose.frmParent = Me
        Me.ucrReceiverColumsToTranspose.Location = New System.Drawing.Point(272, 47)
        Me.ucrReceiverColumsToTranspose.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumsToTranspose.Name = "ucrReceiverColumsToTranspose"
        Me.ucrReceiverColumsToTranspose.Selector = Nothing
        Me.ucrReceiverColumsToTranspose.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumsToTranspose.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 235)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrSelectorTransposeColumns
        '
        Me.ucrSelectorTransposeColumns.bShowHiddenColumns = False
        Me.ucrSelectorTransposeColumns.bUseCurrentFilter = True
        Me.ucrSelectorTransposeColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorTransposeColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTransposeColumns.Name = "ucrSelectorTransposeColumns"
        Me.ucrSelectorTransposeColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTransposeColumns.TabIndex = 5
        '
        'ucrNewDataframe
        '
        Me.ucrNewDataframe.Location = New System.Drawing.Point(10, 205)
        Me.ucrNewDataframe.Name = "ucrNewDataframe"
        Me.ucrNewDataframe.Size = New System.Drawing.Size(305, 24)
        Me.ucrNewDataframe.TabIndex = 12
        '
        'ucrChkNameNewColumns
        '
        Me.ucrChkNameNewColumns.Checked = False
        Me.ucrChkNameNewColumns.Location = New System.Drawing.Point(272, 154)
        Me.ucrChkNameNewColumns.Name = "ucrChkNameNewColumns"
        Me.ucrChkNameNewColumns.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkNameNewColumns.TabIndex = 13
        '
        'dlgTransposeColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 297)
        Me.Controls.Add(Me.ucrChkNameNewColumns)
        Me.Controls.Add(Me.ucrNewDataframe)
        Me.Controls.Add(Me.ucrReceiverColumsToTranspose)
        Me.Controls.Add(Me.ucrSelectorTransposeColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblColumnsToTranspose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransposeColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Transpose_Columns"
        Me.Text = "Transpose Columns"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTransposeColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumsToTranspose As ucrReceiverMultiple
    Friend WithEvents lblColumnsToTranspose As Label
    Friend WithEvents ucrNewDataframe As ucrSave
    Friend WithEvents ucrChkNameNewColumns As ucrCheck
End Class
