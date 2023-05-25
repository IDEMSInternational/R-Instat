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
        Me.ucrInputRows = New instat.ucrInputFactorLevels()
        Me.ucrNewName = New instat.ucrInputTextBox()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectValues = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.lblCurrentValue = New System.Windows.Forms.Label()
        Me.lblNewValue = New System.Windows.Forms.Label()
        Me.ucrRowNumber = New instat.ucrInputTextBox()
        Me.ucrReceiverRow = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrInputRows
        '
        Me.ucrInputRows.AddQuotesIfUnrecognised = True
        Me.ucrInputRows.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputRows.GetSetSelectedIndex = -1
        Me.ucrInputRows.IsReadOnly = False
        Me.ucrInputRows.Location = New System.Drawing.Point(242, 209)
        Me.ucrInputRows.Name = "ucrInputRows"
        Me.ucrInputRows.Size = New System.Drawing.Size(120, 23)
        Me.ucrInputRows.TabIndex = 92
        '
        'ucrNewName
        '
        Me.ucrNewName.AddQuotesIfUnrecognised = True
        Me.ucrNewName.AutoSize = True
        Me.ucrNewName.IsMultiline = False
        Me.ucrNewName.IsReadOnly = False
        Me.ucrNewName.Location = New System.Drawing.Point(242, 209)
        Me.ucrNewName.Name = "ucrNewName"
        Me.ucrNewName.Size = New System.Drawing.Size(231, 21)
        Me.ucrNewName.TabIndex = 17
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(242, 62)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(148, 21)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 14
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(34, 256)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 13
        '
        'ucrSelectValues
        '
        Me.ucrSelectValues.AutoSize = True
        Me.ucrSelectValues.bDropUnusedFilterLevels = False
        Me.ucrSelectValues.bShowHiddenColumns = False
        Me.ucrSelectValues.bUseCurrentFilter = True
        Me.ucrSelectValues.Location = New System.Drawing.Point(9, 43)
        Me.ucrSelectValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectValues.Name = "ucrSelectValues"
        Me.ucrSelectValues.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectValues.TabIndex = 4
        '
        'lblColumns
        '
        Me.lblColumns.Location = New System.Drawing.Point(239, 39)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(100, 13)
        Me.lblColumns.TabIndex = 93
        Me.lblColumns.Tag = "New_Name"
        Me.lblColumns.Text = "Column:"
        '
        'lblRows
        '
        Me.lblRows.Location = New System.Drawing.Point(239, 92)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(100, 14)
        Me.lblRows.TabIndex = 94
        Me.lblRows.Tag = "New_Name"
        Me.lblRows.Text = "Rows:"
        '
        'lblCurrentValue
        '
        Me.lblCurrentValue.Location = New System.Drawing.Point(242, 144)
        Me.lblCurrentValue.Name = "lblCurrentValue"
        Me.lblCurrentValue.Size = New System.Drawing.Size(100, 15)
        Me.lblCurrentValue.TabIndex = 95
        Me.lblCurrentValue.Tag = "Current_Value"
        Me.lblCurrentValue.Text = "Current Value:"
        '
        'lblNewValue
        '
        Me.lblNewValue.Location = New System.Drawing.Point(240, 189)
        Me.lblNewValue.Name = "lblNewValue"
        Me.lblNewValue.Size = New System.Drawing.Size(100, 14)
        Me.lblNewValue.TabIndex = 96
        Me.lblNewValue.Tag = "New_Value"
        Me.lblNewValue.Text = "New Value:"
        '
        'ucrRowNumber
        '
        Me.ucrRowNumber.AddQuotesIfUnrecognised = True
        Me.ucrRowNumber.AutoSize = True
        Me.ucrRowNumber.IsMultiline = False
        Me.ucrRowNumber.IsReadOnly = False
        Me.ucrRowNumber.Location = New System.Drawing.Point(242, 109)
        Me.ucrRowNumber.Name = "ucrRowNumber"
        Me.ucrRowNumber.Size = New System.Drawing.Size(148, 21)
        Me.ucrRowNumber.TabIndex = 97
        '
        'ucrReceiverRow
        '
        Me.ucrReceiverRow.AutoSize = True
        Me.ucrReceiverRow.frmParent = Me
        Me.ucrReceiverRow.Location = New System.Drawing.Point(242, 163)
        Me.ucrReceiverRow.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRow.Name = "ucrReceiverRow"
        Me.ucrReceiverRow.Selector = Nothing
        Me.ucrReceiverRow.Size = New System.Drawing.Size(231, 21)
        Me.ucrReceiverRow.strNcFilePath = ""
        Me.ucrReceiverRow.TabIndex = 98
        Me.ucrReceiverRow.ucrSelector = Nothing
        '
        'dlgEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 320)
        Me.Controls.Add(Me.ucrNewName)
        Me.Controls.Add(Me.ucrReceiverRow)
        Me.Controls.Add(Me.ucrRowNumber)
        Me.Controls.Add(Me.lblNewValue)
        Me.Controls.Add(Me.lblCurrentValue)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrInputRows)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectValues)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEdit"
        Me.ShowIcon = False
        Me.Text = "Edit Cell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectValues As ucrSelectorByDataFrameAddRemove
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
End Class
