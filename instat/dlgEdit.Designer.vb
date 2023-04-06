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
        Me.ucrNewName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectValues = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblCurrentName
        '
        Me.lblCurrentName.Location = New System.Drawing.Point(219, 104)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(100, 15)
        Me.lblCurrentName.TabIndex = 15
        Me.lblCurrentName.Text = "New Name:"
        '
        'ucrNewName
        '
        Me.ucrNewName.AddQuotesIfUnrecognised = True
        Me.ucrNewName.AutoSize = True
        Me.ucrNewName.IsMultiline = False
        Me.ucrNewName.IsReadOnly = False
        Me.ucrNewName.Location = New System.Drawing.Point(219, 122)
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
        'ucrSelectValues
        '
        Me.ucrSelectValues.AutoSize = True
        Me.ucrSelectValues.bDropUnusedFilterLevels = False
        Me.ucrSelectValues.bShowHiddenColumns = False
        Me.ucrSelectValues.bUseCurrentFilter = True
        Me.ucrSelectValues.Location = New System.Drawing.Point(3, 9)
        Me.ucrSelectValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectValues.Name = "ucrSelectValues"
        Me.ucrSelectValues.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectValues.TabIndex = 17
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(219, 73)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(148, 21)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 18
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'dlgEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 244)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrNewName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrSelectValues)
        Me.Name = "dlgEdit"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents ucrNewName As ucrInputTextBox
    Friend WithEvents ucrSelectValues As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverName As ucrReceiverSingle
End Class
