<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCluster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCluster))
        Me.rdoWholeDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedColumn = New System.Windows.Forms.RadioButton()
        Me.rdoDistanceData = New System.Windows.Forms.RadioButton()
        Me.rdoScaleData = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrChkCenterEachVariable = New instat.ucrCheck()
        Me.ucrChkScaleEachVariable = New instat.ucrCheck()
        Me.ucrChkOmitMissingRows = New instat.ucrCheck()
        Me.ucrReceiverPrepareData = New instat.ucrReceiverMultiple()
        Me.ucrSelectorPrepareData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.ucrPnlPrepareData = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'rdoWholeDataFrame
        '
        resources.ApplyResources(Me.rdoWholeDataFrame, "rdoWholeDataFrame")
        Me.rdoWholeDataFrame.Name = "rdoWholeDataFrame"
        Me.rdoWholeDataFrame.TabStop = True
        Me.rdoWholeDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSelectedColumn
        '
        resources.ApplyResources(Me.rdoSelectedColumn, "rdoSelectedColumn")
        Me.rdoSelectedColumn.Name = "rdoSelectedColumn"
        Me.rdoSelectedColumn.TabStop = True
        Me.rdoSelectedColumn.UseVisualStyleBackColor = True
        '
        'rdoDistanceData
        '
        resources.ApplyResources(Me.rdoDistanceData, "rdoDistanceData")
        Me.rdoDistanceData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDistanceData.FlatAppearance.BorderSize = 2
        Me.rdoDistanceData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDistanceData.Name = "rdoDistanceData"
        Me.rdoDistanceData.UseVisualStyleBackColor = True
        '
        'rdoScaleData
        '
        resources.ApplyResources(Me.rdoScaleData, "rdoScaleData")
        Me.rdoScaleData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScaleData.FlatAppearance.BorderSize = 2
        Me.rdoScaleData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScaleData.Name = "rdoScaleData"
        Me.rdoScaleData.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSaveNewDataFrame
        '
        resources.ApplyResources(Me.ucrSaveNewDataFrame, "ucrSaveNewDataFrame")
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        '
        'ucrChkCenterEachVariable
        '
        Me.ucrChkCenterEachVariable.Checked = False
        resources.ApplyResources(Me.ucrChkCenterEachVariable, "ucrChkCenterEachVariable")
        Me.ucrChkCenterEachVariable.Name = "ucrChkCenterEachVariable"
        '
        'ucrChkScaleEachVariable
        '
        Me.ucrChkScaleEachVariable.Checked = False
        resources.ApplyResources(Me.ucrChkScaleEachVariable, "ucrChkScaleEachVariable")
        Me.ucrChkScaleEachVariable.Name = "ucrChkScaleEachVariable"
        '
        'ucrChkOmitMissingRows
        '
        Me.ucrChkOmitMissingRows.Checked = False
        resources.ApplyResources(Me.ucrChkOmitMissingRows, "ucrChkOmitMissingRows")
        Me.ucrChkOmitMissingRows.Name = "ucrChkOmitMissingRows"
        '
        'ucrReceiverPrepareData
        '
        Me.ucrReceiverPrepareData.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPrepareData, "ucrReceiverPrepareData")
        Me.ucrReceiverPrepareData.Name = "ucrReceiverPrepareData"
        Me.ucrReceiverPrepareData.Selector = Nothing
        Me.ucrReceiverPrepareData.strNcFilePath = ""
        Me.ucrReceiverPrepareData.ucrSelector = Nothing
        '
        'ucrSelectorPrepareData
        '
        Me.ucrSelectorPrepareData.bDropUnusedFilterLevels = False
        Me.ucrSelectorPrepareData.bShowHiddenColumns = False
        Me.ucrSelectorPrepareData.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorPrepareData, "ucrSelectorPrepareData")
        Me.ucrSelectorPrepareData.Name = "ucrSelectorPrepareData"
        '
        'ucrPnlSelectData
        '
        resources.ApplyResources(Me.ucrPnlSelectData, "ucrPnlSelectData")
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        '
        'ucrPnlPrepareData
        '
        resources.ApplyResources(Me.ucrPnlPrepareData, "ucrPnlPrepareData")
        Me.ucrPnlPrepareData.Name = "ucrPnlPrepareData"
        '
        'dlgCluster
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoScaleData)
        Me.Controls.Add(Me.rdoDistanceData)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.ucrChkCenterEachVariable)
        Me.Controls.Add(Me.ucrChkScaleEachVariable)
        Me.Controls.Add(Me.ucrChkOmitMissingRows)
        Me.Controls.Add(Me.ucrReceiverPrepareData)
        Me.Controls.Add(Me.rdoSelectedColumn)
        Me.Controls.Add(Me.rdoWholeDataFrame)
        Me.Controls.Add(Me.ucrSelectorPrepareData)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.Controls.Add(Me.ucrPnlPrepareData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCluster"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorPrepareData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoWholeDataFrame As RadioButton
    Friend WithEvents rdoSelectedColumn As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
    Friend WithEvents ucrReceiverPrepareData As ucrReceiverMultiple
    Friend WithEvents ucrChkCenterEachVariable As ucrCheck
    Friend WithEvents ucrChkScaleEachVariable As ucrCheck
    Friend WithEvents ucrChkOmitMissingRows As ucrCheck
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents rdoScaleData As RadioButton
    Friend WithEvents rdoDistanceData As RadioButton
    Friend WithEvents ucrPnlPrepareData As UcrPanel
    Friend WithEvents ucrBase As ucrButtons
End Class
