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
        resources.ApplyResources(Me.lblColumn, "lblColumn")
        Me.lblColumn.Name = "lblColumn"
        '
        'ucrChkFilterNonumerics
        '
        Me.ucrChkFilterNonumerics.Checked = False
        resources.ApplyResources(Me.ucrChkFilterNonumerics, "ucrChkFilterNonumerics")
        Me.ucrChkFilterNonumerics.Name = "ucrChkFilterNonumerics"
        '
        'ucrChkShowSummary
        '
        Me.ucrChkShowSummary.Checked = False
        resources.ApplyResources(Me.ucrChkShowSummary, "ucrChkShowSummary")
        Me.ucrChkShowSummary.Name = "ucrChkShowSummary"
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
        'ucrSaveColumn
        '
        resources.ApplyResources(Me.ucrSaveColumn, "ucrSaveColumn")
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        '
        'dlgFindNonnumericValues
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
