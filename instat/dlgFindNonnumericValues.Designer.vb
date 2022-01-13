<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFindNonnumericValues
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
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.ucrChkFilterNonumerics = New instat.ucrCheck()
        Me.ucrChkShowSummary = New instat.ucrCheck()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorShowNonNumericValues = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumn.Location = New System.Drawing.Point(240, 45)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(94, 13)
        Me.lblColumn.TabIndex = 1
        Me.lblColumn.Text = "Character Column:"
        '
        'ucrChkFilterNonumerics
        '
        Me.ucrChkFilterNonumerics.AutoSize = True
        Me.ucrChkFilterNonumerics.Checked = False
        Me.ucrChkFilterNonumerics.Location = New System.Drawing.Point(10, 221)
        Me.ucrChkFilterNonumerics.Name = "ucrChkFilterNonumerics"
        Me.ucrChkFilterNonumerics.Size = New System.Drawing.Size(314, 23)
        Me.ucrChkFilterNonumerics.TabIndex = 4
        '
        'ucrChkShowSummary
        '
        Me.ucrChkShowSummary.AutoSize = True
        Me.ucrChkShowSummary.Checked = False
        Me.ucrChkShowSummary.Location = New System.Drawing.Point(10, 196)
        Me.ucrChkShowSummary.Name = "ucrChkShowSummary"
        Me.ucrChkShowSummary.Size = New System.Drawing.Size(350, 23)
        Me.ucrChkShowSummary.TabIndex = 3
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.AutoSize = True
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(240, 60)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 2
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrSelectorShowNonNumericValues
        '
        Me.ucrSelectorShowNonNumericValues.AutoSize = True
        Me.ucrSelectorShowNonNumericValues.bDropUnusedFilterLevels = False
        Me.ucrSelectorShowNonNumericValues.bShowHiddenColumns = False
        Me.ucrSelectorShowNonNumericValues.bUseCurrentFilter = True
        Me.ucrSelectorShowNonNumericValues.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorShowNonNumericValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorShowNonNumericValues.Name = "ucrSelectorShowNonNumericValues"
        Me.ucrSelectorShowNonNumericValues.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorShowNonNumericValues.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 274)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveColumn.Location = New System.Drawing.Point(10, 247)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(288, 21)
        Me.ucrSaveColumn.TabIndex = 8
        '
        'dlgFindNonnumericValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 333)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrChkFilterNonumerics)
        Me.Controls.Add(Me.ucrChkShowSummary)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.ucrSelectorShowNonNumericValues)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "dlgFindNonnumericValues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Non-Numeric Values"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorShowNonNumericValues As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblColumn As Label
    Friend WithEvents ucrChkShowSummary As ucrCheck
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents ucrChkFilterNonumerics As ucrCheck
    Friend WithEvents ucrSaveColumn As ucrSave
End Class
