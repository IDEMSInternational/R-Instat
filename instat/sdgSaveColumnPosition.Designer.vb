<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgSaveColumnPosition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgSaveColumnPosition))
        Me.ucrSelectorSaveColumnPosition = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrPnlColumnPosition = New instat.UcrPanel()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.rdoStart = New System.Windows.Forms.RadioButton()
        Me.rdoEnd = New System.Windows.Forms.RadioButton()
        Me.rdoBeforeOrAfterColumn = New System.Windows.Forms.RadioButton()
        Me.ucrInputBeforeAfter = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'ucrSelectorSaveColumnPosition
        '
        Me.ucrSelectorSaveColumnPosition.bDropUnusedFilterLevels = False
        Me.ucrSelectorSaveColumnPosition.bShowHiddenColumns = False
        Me.ucrSelectorSaveColumnPosition.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSaveColumnPosition, "ucrSelectorSaveColumnPosition")
        Me.ucrSelectorSaveColumnPosition.Name = "ucrSelectorSaveColumnPosition"
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumn, "ucrReceiverColumn")
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrPnlColumnPosition
        '
        resources.ApplyResources(Me.ucrPnlColumnPosition, "ucrPnlColumnPosition")
        Me.ucrPnlColumnPosition.Name = "ucrPnlColumnPosition"
        '
        'ucrBaseSubdialog
        '
        resources.ApplyResources(Me.ucrBaseSubdialog, "ucrBaseSubdialog")
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        '
        'lblColumn
        '
        resources.ApplyResources(Me.lblColumn, "lblColumn")
        Me.lblColumn.Name = "lblColumn"
        '
        'rdoStart
        '
        resources.ApplyResources(Me.rdoStart, "rdoStart")
        Me.rdoStart.Name = "rdoStart"
        Me.rdoStart.TabStop = True
        Me.rdoStart.UseVisualStyleBackColor = True
        '
        'rdoEnd
        '
        resources.ApplyResources(Me.rdoEnd, "rdoEnd")
        Me.rdoEnd.Name = "rdoEnd"
        Me.rdoEnd.TabStop = True
        Me.rdoEnd.UseVisualStyleBackColor = True
        '
        'rdoBeforeOrAfterColumn
        '
        resources.ApplyResources(Me.rdoBeforeOrAfterColumn, "rdoBeforeOrAfterColumn")
        Me.rdoBeforeOrAfterColumn.Name = "rdoBeforeOrAfterColumn"
        Me.rdoBeforeOrAfterColumn.TabStop = True
        Me.rdoBeforeOrAfterColumn.UseVisualStyleBackColor = True
        '
        'ucrInputBeforeAfter
        '
        Me.ucrInputBeforeAfter.AddQuotesIfUnrecognised = True
        Me.ucrInputBeforeAfter.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBeforeAfter, "ucrInputBeforeAfter")
        Me.ucrInputBeforeAfter.Name = "ucrInputBeforeAfter"
        '
        'sdgSaveColumnPosition
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputBeforeAfter)
        Me.Controls.Add(Me.rdoBeforeOrAfterColumn)
        Me.Controls.Add(Me.rdoEnd)
        Me.Controls.Add(Me.rdoStart)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.ucrSelectorSaveColumnPosition)
        Me.Controls.Add(Me.ucrPnlColumnPosition)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSaveColumnPosition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorSaveColumnPosition As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents ucrPnlColumnPosition As UcrPanel
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents lblColumn As Label
    Friend WithEvents rdoBeforeOrAfterColumn As RadioButton
    Friend WithEvents rdoEnd As RadioButton
    Friend WithEvents rdoStart As RadioButton
    Friend WithEvents ucrInputBeforeAfter As ucrInputComboBox
End Class
