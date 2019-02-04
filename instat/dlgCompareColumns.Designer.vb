<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCompareColumns
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCompareColumns))
        Me.lblFirstColumn = New System.Windows.Forms.Label()
        Me.lblSecondColumn = New System.Windows.Forms.Label()
        Me.grpComparisions = New System.Windows.Forms.GroupBox()
        Me.ucrSaveLogical = New instat.ucrSave()
        Me.ucrChkSort = New instat.ucrCheck()
        Me.ucrChkUnique = New instat.ucrCheck()
        Me.ucrChkAllValues = New instat.ucrCheck()
        Me.ucrChkUnion = New instat.ucrCheck()
        Me.ucrChkIntersection = New instat.ucrCheck()
        Me.ucrChkSecondNotFirst = New instat.ucrCheck()
        Me.ucrChkFirstNotSecond = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSecond = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirst = New instat.ucrReceiverSingle()
        Me.ucrSelectorCompareColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpComparisions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstColumn
        '
        resources.ApplyResources(Me.lblFirstColumn, "lblFirstColumn")
        Me.lblFirstColumn.Name = "lblFirstColumn"
        '
        'lblSecondColumn
        '
        resources.ApplyResources(Me.lblSecondColumn, "lblSecondColumn")
        Me.lblSecondColumn.Name = "lblSecondColumn"
        '
        'grpComparisions
        '
        Me.grpComparisions.Controls.Add(Me.ucrChkAllValues)
        Me.grpComparisions.Controls.Add(Me.ucrChkUnion)
        Me.grpComparisions.Controls.Add(Me.ucrChkIntersection)
        Me.grpComparisions.Controls.Add(Me.ucrChkSecondNotFirst)
        Me.grpComparisions.Controls.Add(Me.ucrChkFirstNotSecond)
        resources.ApplyResources(Me.grpComparisions, "grpComparisions")
        Me.grpComparisions.Name = "grpComparisions"
        Me.grpComparisions.TabStop = False
        '
        'ucrSaveLogical
        '
        resources.ApplyResources(Me.ucrSaveLogical, "ucrSaveLogical")
        Me.ucrSaveLogical.Name = "ucrSaveLogical"
        '
        'ucrChkSort
        '
        Me.ucrChkSort.Checked = False
        resources.ApplyResources(Me.ucrChkSort, "ucrChkSort")
        Me.ucrChkSort.Name = "ucrChkSort"
        '
        'ucrChkUnique
        '
        Me.ucrChkUnique.Checked = False
        resources.ApplyResources(Me.ucrChkUnique, "ucrChkUnique")
        Me.ucrChkUnique.Name = "ucrChkUnique"
        '
        'ucrChkAllValues
        '
        Me.ucrChkAllValues.Checked = False
        resources.ApplyResources(Me.ucrChkAllValues, "ucrChkAllValues")
        Me.ucrChkAllValues.Name = "ucrChkAllValues"
        '
        'ucrChkUnion
        '
        Me.ucrChkUnion.Checked = False
        resources.ApplyResources(Me.ucrChkUnion, "ucrChkUnion")
        Me.ucrChkUnion.Name = "ucrChkUnion"
        '
        'ucrChkIntersection
        '
        Me.ucrChkIntersection.Checked = False
        resources.ApplyResources(Me.ucrChkIntersection, "ucrChkIntersection")
        Me.ucrChkIntersection.Name = "ucrChkIntersection"
        '
        'ucrChkSecondNotFirst
        '
        Me.ucrChkSecondNotFirst.Checked = False
        resources.ApplyResources(Me.ucrChkSecondNotFirst, "ucrChkSecondNotFirst")
        Me.ucrChkSecondNotFirst.Name = "ucrChkSecondNotFirst"
        '
        'ucrChkFirstNotSecond
        '
        Me.ucrChkFirstNotSecond.Checked = False
        resources.ApplyResources(Me.ucrChkFirstNotSecond, "ucrChkFirstNotSecond")
        Me.ucrChkFirstNotSecond.Name = "ucrChkFirstNotSecond"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverSecond
        '
        Me.ucrReceiverSecond.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSecond, "ucrReceiverSecond")
        Me.ucrReceiverSecond.Name = "ucrReceiverSecond"
        Me.ucrReceiverSecond.Selector = Nothing
        Me.ucrReceiverSecond.strNcFilePath = ""
        Me.ucrReceiverSecond.ucrSelector = Nothing
        '
        'ucrReceiverFirst
        '
        Me.ucrReceiverFirst.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirst, "ucrReceiverFirst")
        Me.ucrReceiverFirst.Name = "ucrReceiverFirst"
        Me.ucrReceiverFirst.Selector = Nothing
        Me.ucrReceiverFirst.strNcFilePath = ""
        Me.ucrReceiverFirst.ucrSelector = Nothing
        '
        'ucrSelectorCompareColumns
        '
        Me.ucrSelectorCompareColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorCompareColumns.bShowHiddenColumns = False
        Me.ucrSelectorCompareColumns.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorCompareColumns, "ucrSelectorCompareColumns")
        Me.ucrSelectorCompareColumns.Name = "ucrSelectorCompareColumns"
        '
        'dlgCompareColumns
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveLogical)
        Me.Controls.Add(Me.ucrChkSort)
        Me.Controls.Add(Me.ucrChkUnique)
        Me.Controls.Add(Me.grpComparisions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSecondColumn)
        Me.Controls.Add(Me.lblFirstColumn)
        Me.Controls.Add(Me.ucrReceiverSecond)
        Me.Controls.Add(Me.ucrReceiverFirst)
        Me.Controls.Add(Me.ucrSelectorCompareColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompareColumns"
        Me.ShowIcon = False
        Me.grpComparisions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorCompareColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFirst As ucrReceiverSingle
    Friend WithEvents lblSecondColumn As Label
    Friend WithEvents lblFirstColumn As Label
    Friend WithEvents ucrReceiverSecond As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkUnique As ucrCheck
    Friend WithEvents grpComparisions As GroupBox
    Friend WithEvents ucrChkSort As ucrCheck
    Friend WithEvents ucrChkFirstNotSecond As ucrCheck
    Friend WithEvents ucrChkSecondNotFirst As ucrCheck
    Friend WithEvents ucrChkIntersection As ucrCheck
    Friend WithEvents ucrChkUnion As ucrCheck
    Friend WithEvents ucrChkAllValues As ucrCheck
    Friend WithEvents ucrSaveLogical As ucrSave
End Class
