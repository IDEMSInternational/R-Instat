<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSubset
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSubset))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSubset = New instat.ucrReceiverMultiple()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lblDrop = New System.Windows.Forms.Label()
        Me.cboDrop = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrDataFrameAddRemove
        '
        Me.ucrDataFrameAddRemove.bShowHiddenColumns = False
        Me.ucrDataFrameAddRemove.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrDataFrameAddRemove, "ucrDataFrameAddRemove")
        Me.ucrDataFrameAddRemove.Name = "ucrDataFrameAddRemove"
        '
        'ucrReceiverSubset
        '
        resources.ApplyResources(Me.ucrReceiverSubset, "ucrReceiverSubset")
        Me.ucrReceiverSubset.Name = "ucrReceiverSubset"
        Me.ucrReceiverSubset.Selector = Nothing
        '
        'lblSelectedVariables
        '
        resources.ApplyResources(Me.lblSelectedVariables, "lblSelectedVariables")
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Tag = "Selected_variables"
        '
        'lblDrop
        '
        resources.ApplyResources(Me.lblDrop, "lblDrop")
        Me.lblDrop.Name = "lblDrop"
        Me.lblDrop.Tag = "Drop"
        '
        'cboDrop
        '
        Me.cboDrop.FormattingEnabled = True
        resources.ApplyResources(Me.cboDrop, "cboDrop")
        Me.cboDrop.Name = "cboDrop"
        '
        'dlgSubset
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboDrop)
        Me.Controls.Add(Me.lblDrop)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverSubset)
        Me.Controls.Add(Me.ucrDataFrameAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSubset"
        Me.Tag = "Subset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSubset As ucrReceiverMultiple
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lblDrop As Label
    Friend WithEvents cboDrop As ComboBox
End Class
