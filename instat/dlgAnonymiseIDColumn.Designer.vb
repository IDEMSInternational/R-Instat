<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAnonymiseIDColumn
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
        Me.lblIDColumn = New System.Windows.Forms.Label()
        Me.ucrSelectorAnonymiseIDColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveAnonymisedColumn = New instat.ucrSave()
        Me.ucrReceiverIDColumn = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTextSalt = New instat.ucrInputTextBox()
        Me.lblSalt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIDColumn
        '
        Me.lblIDColumn.AutoSize = True
        Me.lblIDColumn.Location = New System.Drawing.Point(269, 49)
        Me.lblIDColumn.Name = "lblIDColumn"
        Me.lblIDColumn.Size = New System.Drawing.Size(59, 13)
        Me.lblIDColumn.TabIndex = 1
        Me.lblIDColumn.Text = "ID Column:"
        '
        'ucrSelectorAnonymiseIDColumn
        '
        Me.ucrSelectorAnonymiseIDColumn.bDropUnusedFilterLevels = False
        Me.ucrSelectorAnonymiseIDColumn.bShowHiddenColumns = False
        Me.ucrSelectorAnonymiseIDColumn.bUseCurrentFilter = True
        Me.ucrSelectorAnonymiseIDColumn.Location = New System.Drawing.Point(10, 33)
        Me.ucrSelectorAnonymiseIDColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorAnonymiseIDColumn.Name = "ucrSelectorAnonymiseIDColumn"
        Me.ucrSelectorAnonymiseIDColumn.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorAnonymiseIDColumn.TabIndex = 0
        '
        'ucrSaveAnonymisedColumn
        '
        Me.ucrSaveAnonymisedColumn.Location = New System.Drawing.Point(9, 255)
        Me.ucrSaveAnonymisedColumn.Name = "ucrSaveAnonymisedColumn"
        Me.ucrSaveAnonymisedColumn.Size = New System.Drawing.Size(250, 24)
        Me.ucrSaveAnonymisedColumn.TabIndex = 5
        '
        'ucrReceiverIDColumn
        '
        Me.ucrReceiverIDColumn.frmParent = Me
        Me.ucrReceiverIDColumn.Location = New System.Drawing.Point(266, 65)
        Me.ucrReceiverIDColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDColumn.Name = "ucrReceiverIDColumn"
        Me.ucrReceiverIDColumn.Selector = Nothing
        Me.ucrReceiverIDColumn.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverIDColumn.strNcFilePath = ""
        Me.ucrReceiverIDColumn.TabIndex = 2
        Me.ucrReceiverIDColumn.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 305)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrInputTextSalt
        '
        Me.ucrInputTextSalt.AddQuotesIfUnrecognised = True
        Me.ucrInputTextSalt.IsMultiline = False
        Me.ucrInputTextSalt.IsReadOnly = False
        Me.ucrInputTextSalt.Location = New System.Drawing.Point(266, 143)
        Me.ucrInputTextSalt.Name = "ucrInputTextSalt"
        Me.ucrInputTextSalt.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTextSalt.TabIndex = 4
        '
        'lblSalt
        '
        Me.lblSalt.AutoSize = True
        Me.lblSalt.Location = New System.Drawing.Point(269, 126)
        Me.lblSalt.Name = "lblSalt"
        Me.lblSalt.Size = New System.Drawing.Size(28, 13)
        Me.lblSalt.TabIndex = 3
        Me.lblSalt.Text = "Salt:"
        '
        'dlgAnonymiseIDColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 370)
        Me.Controls.Add(Me.lblSalt)
        Me.Controls.Add(Me.ucrInputTextSalt)
        Me.Controls.Add(Me.ucrSelectorAnonymiseIDColumn)
        Me.Controls.Add(Me.lblIDColumn)
        Me.Controls.Add(Me.ucrSaveAnonymisedColumn)
        Me.Controls.Add(Me.ucrReceiverIDColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgAnonymiseIDColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anonymise ID Column"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverIDColumn As ucrReceiverSingle
    Friend WithEvents ucrSaveAnonymisedColumn As ucrSave
    Friend WithEvents lblIDColumn As Label
    Friend WithEvents ucrSelectorAnonymiseIDColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputTextSalt As ucrInputTextBox
    Friend WithEvents lblSalt As Label
End Class
