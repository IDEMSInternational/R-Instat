﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSort
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
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.rdoDescending = New System.Windows.Forms.RadioButton()
        Me.rdoAscending = New System.Windows.Forms.RadioButton()
        Me.lblColumnsToSort = New System.Windows.Forms.Label()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.ucrSelectForSort = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSort = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOrder.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOrder
        '
        Me.grpOrder.Controls.Add(Me.rdoDescending)
        Me.grpOrder.Controls.Add(Me.rdoAscending)
        Me.grpOrder.Location = New System.Drawing.Point(13, 197)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(181, 47)
        Me.grpOrder.TabIndex = 3
        Me.grpOrder.TabStop = False
        Me.grpOrder.Tag = "Order"
        Me.grpOrder.Text = "Order"
        '
        'rdoDescending
        '
        Me.rdoDescending.AutoSize = True
        Me.rdoDescending.Location = New System.Drawing.Point(88, 20)
        Me.rdoDescending.Name = "rdoDescending"
        Me.rdoDescending.Size = New System.Drawing.Size(82, 17)
        Me.rdoDescending.TabIndex = 1
        Me.rdoDescending.TabStop = True
        Me.rdoDescending.Tag = "Descending"
        Me.rdoDescending.Text = "Descending"
        Me.rdoDescending.UseVisualStyleBackColor = True
        '
        'rdoAscending
        '
        Me.rdoAscending.AutoSize = True
        Me.rdoAscending.Location = New System.Drawing.Point(7, 20)
        Me.rdoAscending.Name = "rdoAscending"
        Me.rdoAscending.Size = New System.Drawing.Size(75, 17)
        Me.rdoAscending.TabIndex = 0
        Me.rdoAscending.TabStop = True
        Me.rdoAscending.Tag = "Ascending"
        Me.rdoAscending.Text = "Ascending"
        Me.rdoAscending.UseVisualStyleBackColor = True
        '
        'lblColumnsToSort
        '
        Me.lblColumnsToSort.AutoSize = True
        Me.lblColumnsToSort.Location = New System.Drawing.Point(274, 34)
        Me.lblColumnsToSort.Name = "lblColumnsToSort"
        Me.lblColumnsToSort.Size = New System.Drawing.Size(103, 13)
        Me.lblColumnsToSort.TabIndex = 1
        Me.lblColumnsToSort.Tag = "Columns_To_Sort"
        Me.lblColumnsToSort.Text = "Columns To Sort By:"
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.rdoLast)
        Me.grpMissingValues.Controls.Add(Me.rdoFirst)
        Me.grpMissingValues.Location = New System.Drawing.Point(200, 197)
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.Size = New System.Drawing.Size(215, 47)
        Me.grpMissingValues.TabIndex = 4
        Me.grpMissingValues.TabStop = False
        Me.grpMissingValues.Tag = "Missing_values"
        Me.grpMissingValues.Text = "Missing values"
        '
        'rdoLast
        '
        Me.rdoLast.AutoSize = True
        Me.rdoLast.Location = New System.Drawing.Point(114, 20)
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.Size = New System.Drawing.Size(45, 17)
        Me.rdoLast.TabIndex = 1
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.Text = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        Me.rdoFirst.AutoSize = True
        Me.rdoFirst.Location = New System.Drawing.Point(17, 20)
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.Size = New System.Drawing.Size(44, 17)
        Me.rdoFirst.TabIndex = 0
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.Text = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'ucrSelectForSort
        '
        Me.ucrSelectForSort.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectForSort.Name = "ucrSelectForSort"
        Me.ucrSelectForSort.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectForSort.TabIndex = 0
        '
        'ucrReceiverSort
        '
        Me.ucrReceiverSort.Location = New System.Drawing.Point(277, 50)
        Me.ucrReceiverSort.Name = "ucrReceiverSort"
        Me.ucrReceiverSort.Selector = Nothing
        Me.ucrReceiverSort.Size = New System.Drawing.Size(125, 117)
        Me.ucrReceiverSort.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 250)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 56)
        Me.ucrBase.TabIndex = 5
        '
        'dlgSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 305)
        Me.Controls.Add(Me.ucrSelectForSort)
        Me.Controls.Add(Me.grpMissingValues)
        Me.Controls.Add(Me.lblColumnsToSort)
        Me.Controls.Add(Me.ucrReceiverSort)
        Me.Controls.Add(Me.grpOrder)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSort"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Sort"
        Me.Text = "Sort"
        Me.grpOrder.ResumeLayout(False)
        Me.grpOrder.PerformLayout()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpMissingValues.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpOrder As GroupBox
    Friend WithEvents rdoDescending As RadioButton
    Friend WithEvents rdoAscending As RadioButton
    Friend WithEvents ucrReceiverSort As ucrReceiverMultiple
    Friend WithEvents lblColumnsToSort As Label
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents ucrSelectForSort As ucrSelectorByDataFrameAddRemove
End Class
