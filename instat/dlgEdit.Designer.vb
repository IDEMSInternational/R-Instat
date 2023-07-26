<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEdit
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
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.lblCurrentValue = New System.Windows.Forms.Label()
        Me.lblNewValue = New System.Windows.Forms.Label()
        Me.ucrSelectValues = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrDate = New instat.ucrDateTimePicker()
        Me.ucrReceiverRow = New instat.ucrReceiverSingle()
        Me.ucrRowNumber = New instat.ucrInputTextBox()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNewName = New instat.ucrInputTextBox()
        Me.ucrInputRows = New instat.ucrInputFactorLevels()
        Me.ucrInputLogical = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'lblColumns
        '
        Me.lblColumns.Location = New System.Drawing.Point(235, 15)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(100, 13)
        Me.lblColumns.TabIndex = 1
        Me.lblColumns.Tag = "New_Name"
        Me.lblColumns.Text = "Column:"
        '
        'lblRows
        '
        Me.lblRows.Location = New System.Drawing.Point(235, 57)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(100, 14)
        Me.lblRows.TabIndex = 3
        Me.lblRows.Tag = "New_Name"
        Me.lblRows.Text = "Rows:"
        '
        'lblCurrentValue
        '
        Me.lblCurrentValue.Location = New System.Drawing.Point(235, 101)
        Me.lblCurrentValue.Name = "lblCurrentValue"
        Me.lblCurrentValue.Size = New System.Drawing.Size(100, 15)
        Me.lblCurrentValue.TabIndex = 5
        Me.lblCurrentValue.Tag = "Current_Value"
        Me.lblCurrentValue.Text = "Current Value:"
        '
        'lblNewValue
        '
        Me.lblNewValue.Location = New System.Drawing.Point(235, 145)
        Me.lblNewValue.Name = "lblNewValue"
        Me.lblNewValue.Size = New System.Drawing.Size(100, 14)
        Me.lblNewValue.TabIndex = 7
        Me.lblNewValue.Tag = "New_Value"
        Me.lblNewValue.Text = "New Value:"
        '
        'ucrSelectValues
        '
        Me.ucrSelectValues.AutoSize = True
        Me.ucrSelectValues.bDropUnusedFilterLevels = False
        Me.ucrSelectValues.bShowHiddenColumns = False
        Me.ucrSelectValues.bUseCurrentFilter = True
        Me.ucrSelectValues.Location = New System.Drawing.Point(10, 6)
        Me.ucrSelectValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectValues.Name = "ucrSelectValues"
        Me.ucrSelectValues.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectValues.TabIndex = 0
        '
        'ucrDate
        '
        Me.ucrDate.AutoSize = True
        Me.ucrDate.DateValue = New Date(2021, 3, 27, 16, 14, 1, 567)
        Me.ucrDate.Format = "dd MMM yyyy"
        Me.ucrDate.Location = New System.Drawing.Point(238, 159)
        Me.ucrDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDate.Name = "ucrDate"
        Me.ucrDate.Size = New System.Drawing.Size(132, 21)
        Me.ucrDate.TabIndex = 10
        '
        'ucrReceiverRow
        '
        Me.ucrReceiverRow.AutoSize = True
        Me.ucrReceiverRow.frmParent = Me
        Me.ucrReceiverRow.Location = New System.Drawing.Point(237, 116)
        Me.ucrReceiverRow.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRow.Name = "ucrReceiverRow"
        Me.ucrReceiverRow.Selector = Nothing
        Me.ucrReceiverRow.Size = New System.Drawing.Size(231, 21)
        Me.ucrReceiverRow.strNcFilePath = ""
        Me.ucrReceiverRow.TabIndex = 6
        Me.ucrReceiverRow.ucrSelector = Nothing
        '
        'ucrRowNumber
        '
        Me.ucrRowNumber.AddQuotesIfUnrecognised = True
        Me.ucrRowNumber.AutoSize = True
        Me.ucrRowNumber.IsMultiline = False
        Me.ucrRowNumber.IsReadOnly = True
        Me.ucrRowNumber.Location = New System.Drawing.Point(237, 71)
        Me.ucrRowNumber.Name = "ucrRowNumber"
        Me.ucrRowNumber.Size = New System.Drawing.Size(148, 21)
        Me.ucrRowNumber.TabIndex = 4
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(237, 28)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(148, 21)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 2
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(20, 208)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrNewName
        '
        Me.ucrNewName.AddQuotesIfUnrecognised = True
        Me.ucrNewName.AutoSize = True
        Me.ucrNewName.IsMultiline = False
        Me.ucrNewName.IsReadOnly = False
        Me.ucrNewName.Location = New System.Drawing.Point(237, 160)
        Me.ucrNewName.Name = "ucrNewName"
        Me.ucrNewName.Size = New System.Drawing.Size(231, 21)
        Me.ucrNewName.TabIndex = 8
        '
        'ucrInputRows
        '
        Me.ucrInputRows.AddQuotesIfUnrecognised = True
        Me.ucrInputRows.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputRows.GetSetSelectedIndex = -1
        Me.ucrInputRows.IsReadOnly = False
        Me.ucrInputRows.Location = New System.Drawing.Point(237, 159)
        Me.ucrInputRows.Name = "ucrInputRows"
        Me.ucrInputRows.Size = New System.Drawing.Size(120, 23)
        Me.ucrInputRows.TabIndex = 0
        '
        'ucrInputLogical
        '
        Me.ucrInputLogical.AddQuotesIfUnrecognised = True
        Me.ucrInputLogical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLogical.GetSetSelectedIndex = -1
        Me.ucrInputLogical.IsReadOnly = False
        Me.ucrInputLogical.Location = New System.Drawing.Point(237, 159)
        Me.ucrInputLogical.Name = "ucrInputLogical"
        Me.ucrInputLogical.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputLogical.TabIndex = 46
        '
        'dlgEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(479, 274)
        Me.Controls.Add(Me.ucrInputLogical)
        Me.Controls.Add(Me.ucrSelectValues)
        Me.Controls.Add(Me.ucrDate)
        Me.Controls.Add(Me.ucrReceiverRow)
        Me.Controls.Add(Me.ucrRowNumber)
        Me.Controls.Add(Me.lblNewValue)
        Me.Controls.Add(Me.lblCurrentValue)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrNewName)
        Me.Controls.Add(Me.ucrInputRows)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEdit"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Edit_Cell"
        Me.Text = "Edit Cell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverName As ucrReceiverSingle
    Friend WithEvents ucrNewName As ucrInputTextBox
    Friend WithEvents ucrInputRows As ucrInputFactorLevels
    Friend WithEvents lblNewValue As Label
    Friend WithEvents lblCurrentValue As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrReceiverRow As ucrReceiverSingle
    Friend WithEvents ucrRowNumber As ucrInputTextBox
    Friend WithEvents ucrDate As ucrDateTimePicker
    Friend WithEvents ucrSelectValues As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputLogical As ucrInputComboBox
End Class
