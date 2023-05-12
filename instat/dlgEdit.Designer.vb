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
        Me.lblCurrentName = New System.Windows.Forms.Label()
        Me.ucrRowNumber = New instat.ucrReceiverSingle()
        Me.ucrSelectValues = New instat.ucrDataFrame()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.ucrNewName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblCurrentRow = New System.Windows.Forms.Label()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCurrentName
        '
        Me.lblCurrentName.Location = New System.Drawing.Point(220, 115)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(100, 15)
        Me.lblCurrentName.TabIndex = 15
        Me.lblCurrentName.Text = "New Value:"
        '
        'ucrRowNumber
        '
        Me.ucrRowNumber.AutoSize = True
        Me.ucrRowNumber.frmParent = Me
        Me.ucrRowNumber.Location = New System.Drawing.Point(219, 84)
        Me.ucrRowNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRowNumber.Name = "ucrRowNumber"
        Me.ucrRowNumber.Selector = Nothing
        Me.ucrRowNumber.Size = New System.Drawing.Size(148, 21)
        Me.ucrRowNumber.strNcFilePath = ""
        Me.ucrRowNumber.TabIndex = 20
        Me.ucrRowNumber.ucrSelector = Nothing
        '
        'ucrSelectValues
        '
        Me.ucrSelectValues.AutoSize = True
        Me.ucrSelectValues.bDropUnusedFilterLevels = False
        Me.ucrSelectValues.bUseCurrentFilter = True
        Me.ucrSelectValues.Location = New System.Drawing.Point(29, 52)
        Me.ucrSelectValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectValues.Name = "ucrSelectValues"
        Me.ucrSelectValues.Size = New System.Drawing.Size(153, 43)
        Me.ucrSelectValues.TabIndex = 19
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(219, 33)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(148, 21)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 18
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'ucrNewName
        '
        Me.ucrNewName.AddQuotesIfUnrecognised = True
        Me.ucrNewName.AutoSize = True
        Me.ucrNewName.IsMultiline = False
        Me.ucrNewName.IsReadOnly = False
        Me.ucrNewName.Location = New System.Drawing.Point(219, 133)
        Me.ucrNewName.Name = "ucrNewName"
        Me.ucrNewName.Size = New System.Drawing.Size(186, 21)
        Me.ucrNewName.TabIndex = 16
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(3, 192)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 13
        '
        'lblCurrentRow
        '
        Me.lblCurrentRow.Location = New System.Drawing.Point(220, 69)
        Me.lblCurrentRow.Name = "lblCurrentRow"
        Me.lblCurrentRow.Size = New System.Drawing.Size(100, 15)
        Me.lblCurrentRow.TabIndex = 21
        Me.lblCurrentRow.Text = "Current Value:"
        '
        'lblColumnName
        '
        Me.lblColumnName.Location = New System.Drawing.Point(220, 18)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(100, 15)
        Me.lblColumnName.TabIndex = 22
        Me.lblColumnName.Text = "Column Name:"
        '
        'dlgEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 244)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.lblCurrentRow)
        Me.Controls.Add(Me.ucrRowNumber)
        Me.Controls.Add(Me.ucrSelectValues)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrNewName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Name = "dlgEdit"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents ucrNewName As ucrInputTextBox
    Friend WithEvents ucrReceiverName As ucrReceiverSingle
    Friend WithEvents ucrSelectValues As ucrDataFrame
    Friend WithEvents ucrRowNumber As ucrReceiverSingle
    Friend WithEvents lblColumnName As Label
    Friend WithEvents lblCurrentRow As Label
End Class
