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
        Me.ucrSelectValues = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.ucrRowNumber = New instat.ucrInputTextBox()
        Me.ucrReceiverRow = New instat.ucrReceiverSingle()
        Me.ucrNewName = New instat.ucrInputTextBox()
        Me.ucrInputRows = New instat.ucrInputFactorLevels()
        Me.SuspendLayout()
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
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 333)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 13
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(249, 84)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(148, 21)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 14
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'ucrRowNumber
        '
        Me.ucrRowNumber.AddQuotesIfUnrecognised = True
        Me.ucrRowNumber.AutoSize = True
        Me.ucrRowNumber.IsMultiline = False
        Me.ucrRowNumber.IsReadOnly = False
        Me.ucrRowNumber.Location = New System.Drawing.Point(249, 131)
        Me.ucrRowNumber.Name = "ucrRowNumber"
        Me.ucrRowNumber.Size = New System.Drawing.Size(148, 21)
        Me.ucrRowNumber.TabIndex = 15
        '
        'ucrReceiverRow
        '
        Me.ucrReceiverRow.AutoSize = True
        Me.ucrReceiverRow.frmParent = Me
        Me.ucrReceiverRow.Location = New System.Drawing.Point(249, 184)
        Me.ucrReceiverRow.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRow.Name = "ucrReceiverRow"
        Me.ucrReceiverRow.Selector = Nothing
        Me.ucrReceiverRow.Size = New System.Drawing.Size(148, 21)
        Me.ucrReceiverRow.strNcFilePath = ""
        Me.ucrReceiverRow.TabIndex = 16
        Me.ucrReceiverRow.ucrSelector = Nothing
        '
        'ucrNewName
        '
        Me.ucrNewName.AddQuotesIfUnrecognised = True
        Me.ucrNewName.AutoSize = True
        Me.ucrNewName.IsMultiline = False
        Me.ucrNewName.IsReadOnly = False
        Me.ucrNewName.Location = New System.Drawing.Point(249, 231)
        Me.ucrNewName.Name = "ucrNewName"
        Me.ucrNewName.Size = New System.Drawing.Size(148, 21)
        Me.ucrNewName.TabIndex = 17
        '
        'ucrInputRows
        '
        Me.ucrInputRows.AddQuotesIfUnrecognised = True
        Me.ucrInputRows.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputRows.GetSetSelectedIndex = -1
        Me.ucrInputRows.IsReadOnly = False
        Me.ucrInputRows.Location = New System.Drawing.Point(249, 271)
        Me.ucrInputRows.Name = "ucrInputRows"
        Me.ucrInputRows.Size = New System.Drawing.Size(120, 23)
        Me.ucrInputRows.TabIndex = 92
        '
        'dlgEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 390)
        Me.Controls.Add(Me.ucrInputRows)
        Me.Controls.Add(Me.ucrReceiverRow)
        Me.Controls.Add(Me.ucrNewName)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrRowNumber)
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
    Friend WithEvents ucrReceiverRow As ucrReceiverSingle
    Friend WithEvents ucrNewName As ucrInputTextBox
    Friend WithEvents ucrRowNumber As ucrInputTextBox
    Friend WithEvents ucrInputRows As ucrInputFactorLevels
End Class
