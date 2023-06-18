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
        Me.lblSalt = New System.Windows.Forms.Label()
        Me.lblAlgorithm = New System.Windows.Forms.Label()
        Me.ucrInputAlgorithm = New instat.ucrInputComboBox()
        Me.ucrInputTextSalt = New instat.ucrInputTextBox()
        Me.ucrSelectorAnonymiseIDColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveAnonymisedColumn = New instat.ucrSave()
        Me.ucrReceiverIDColumn = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblIDColumn
        '
        Me.lblIDColumn.AutoSize = True
        Me.lblIDColumn.Location = New System.Drawing.Point(254, 45)
        Me.lblIDColumn.Name = "lblIDColumn"
        Me.lblIDColumn.Size = New System.Drawing.Size(59, 13)
        Me.lblIDColumn.TabIndex = 1
        Me.lblIDColumn.Text = "ID Column:"
        '
        'lblSalt
        '
        Me.lblSalt.AutoSize = True
        Me.lblSalt.Location = New System.Drawing.Point(254, 89)
        Me.lblSalt.Name = "lblSalt"
        Me.lblSalt.Size = New System.Drawing.Size(107, 13)
        Me.lblSalt.TabIndex = 3
        Me.lblSalt.Text = "Random String (Salt):"
        '
        'lblAlgorithm
        '
        Me.lblAlgorithm.AutoSize = True
        Me.lblAlgorithm.Location = New System.Drawing.Point(254, 134)
        Me.lblAlgorithm.Name = "lblAlgorithm"
        Me.lblAlgorithm.Size = New System.Drawing.Size(56, 13)
        Me.lblAlgorithm.TabIndex = 5
        Me.lblAlgorithm.Text = "Algorithm :"
        '
        'ucrInputAlgorithm
        '
        Me.ucrInputAlgorithm.AddQuotesIfUnrecognised = True
        Me.ucrInputAlgorithm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAlgorithm.GetSetSelectedIndex = -1
        Me.ucrInputAlgorithm.IsReadOnly = False
        Me.ucrInputAlgorithm.Location = New System.Drawing.Point(253, 149)
        Me.ucrInputAlgorithm.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputAlgorithm.Name = "ucrInputAlgorithm"
        Me.ucrInputAlgorithm.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputAlgorithm.TabIndex = 6
        '
        'ucrInputTextSalt
        '
        Me.ucrInputTextSalt.AddQuotesIfUnrecognised = True
        Me.ucrInputTextSalt.AutoSize = True
        Me.ucrInputTextSalt.IsMultiline = False
        Me.ucrInputTextSalt.IsReadOnly = False
        Me.ucrInputTextSalt.Location = New System.Drawing.Point(253, 104)
        Me.ucrInputTextSalt.Name = "ucrInputTextSalt"
        Me.ucrInputTextSalt.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTextSalt.TabIndex = 4
        '
        'ucrSelectorAnonymiseIDColumn
        '
        Me.ucrSelectorAnonymiseIDColumn.AutoSize = True
        Me.ucrSelectorAnonymiseIDColumn.bDropUnusedFilterLevels = False
        Me.ucrSelectorAnonymiseIDColumn.bShowHiddenColumns = False
        Me.ucrSelectorAnonymiseIDColumn.bUseCurrentFilter = True
        Me.ucrSelectorAnonymiseIDColumn.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorAnonymiseIDColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorAnonymiseIDColumn.Name = "ucrSelectorAnonymiseIDColumn"
        Me.ucrSelectorAnonymiseIDColumn.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorAnonymiseIDColumn.TabIndex = 0
        '
        'ucrSaveAnonymisedColumn
        '
        Me.ucrSaveAnonymisedColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveAnonymisedColumn.Location = New System.Drawing.Point(10, 205)
        Me.ucrSaveAnonymisedColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveAnonymisedColumn.Name = "ucrSaveAnonymisedColumn"
        Me.ucrSaveAnonymisedColumn.Size = New System.Drawing.Size(321, 22)
        Me.ucrSaveAnonymisedColumn.TabIndex = 7
        '
        'ucrReceiverIDColumn
        '
        Me.ucrReceiverIDColumn.AutoSize = True
        Me.ucrReceiverIDColumn.frmParent = Me
        Me.ucrReceiverIDColumn.Location = New System.Drawing.Point(253, 60)
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
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 237)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 8
        '
        'dlgAnonymiseIDColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 296)
        Me.Controls.Add(Me.lblAlgorithm)
        Me.Controls.Add(Me.ucrInputAlgorithm)
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
    Friend WithEvents lblAlgorithm As Label
    Friend WithEvents ucrInputAlgorithm As ucrInputComboBox
End Class
