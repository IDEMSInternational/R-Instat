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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFindNonnumericValues))
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.ucrSaveLogicalColumn = New instat.ucrSave()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorShowNonNumericValues = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblColumn
        '
        resources.ApplyResources(Me.lblColumn, "lblColumn")
        Me.lblColumn.Name = "lblColumn"
        '
        'ucrSaveLogicalColumn
        '
        resources.ApplyResources(Me.ucrSaveLogicalColumn, "ucrSaveLogicalColumn")
        Me.ucrSaveLogicalColumn.Name = "ucrSaveLogicalColumn"
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
        'ucrSelectorShowNonNumericValues
        '
        Me.ucrSelectorShowNonNumericValues.bDropUnusedFilterLevels = False
        Me.ucrSelectorShowNonNumericValues.bShowHiddenColumns = False
        Me.ucrSelectorShowNonNumericValues.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorShowNonNumericValues, "ucrSelectorShowNonNumericValues")
        Me.ucrSelectorShowNonNumericValues.Name = "ucrSelectorShowNonNumericValues"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgShowNonnumericValues
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveLogicalColumn)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.ucrSelectorShowNonNumericValues)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "dlgShowNonnumericValues"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorShowNonNumericValues As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents lblColumn As Label
    Friend WithEvents ucrSaveLogicalColumn As ucrSave
End Class
