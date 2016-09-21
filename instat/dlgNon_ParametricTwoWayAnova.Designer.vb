<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgNon_ParametricTwoWayAnova
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgNon_ParametricTwoWayAnova))
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.lblFirstFactor = New System.Windows.Forms.Label()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.ucrSelectorDataFrameAndVars = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSecondFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverDataColumn = New instat.ucrReceiverSingle()
        Me.ucrBaseNPTwoWayANOVA = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblDataColumn
        '
        resources.ApplyResources(Me.lblDataColumn, "lblDataColumn")
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Tag = "Data_column"
        '
        'lblFirstFactor
        '
        resources.ApplyResources(Me.lblFirstFactor, "lblFirstFactor")
        Me.lblFirstFactor.Name = "lblFirstFactor"
        Me.lblFirstFactor.Tag = "First_factor"
        '
        'lblSecondFactor
        '
        resources.ApplyResources(Me.lblSecondFactor, "lblSecondFactor")
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Tag = "Second_factor"
        '
        'ucrSelectorDataFrameAndVars
        '
        Me.ucrSelectorDataFrameAndVars.bShowHiddenColumns = False
        Me.ucrSelectorDataFrameAndVars.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorDataFrameAndVars, "ucrSelectorDataFrameAndVars")
        Me.ucrSelectorDataFrameAndVars.Name = "ucrSelectorDataFrameAndVars"
        '
        'ucrReceiverSecondFactor
        '
        resources.ApplyResources(Me.ucrReceiverSecondFactor, "ucrReceiverSecondFactor")
        Me.ucrReceiverSecondFactor.Name = "ucrReceiverSecondFactor"
        Me.ucrReceiverSecondFactor.Selector = Nothing
        '
        'ucrReceiverFirstFactor
        '
        resources.ApplyResources(Me.ucrReceiverFirstFactor, "ucrReceiverFirstFactor")
        Me.ucrReceiverFirstFactor.Name = "ucrReceiverFirstFactor"
        Me.ucrReceiverFirstFactor.Selector = Nothing
        '
        'ucrReceiverDataColumn
        '
        resources.ApplyResources(Me.ucrReceiverDataColumn, "ucrReceiverDataColumn")
        Me.ucrReceiverDataColumn.Name = "ucrReceiverDataColumn"
        Me.ucrReceiverDataColumn.Selector = Nothing
        '
        'ucrBaseNPTwoWayANOVA
        '
        resources.ApplyResources(Me.ucrBaseNPTwoWayANOVA, "ucrBaseNPTwoWayANOVA")
        Me.ucrBaseNPTwoWayANOVA.Name = "ucrBaseNPTwoWayANOVA"
        '
        'dlgNon_ParametricTwoWayAnova
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSelectorDataFrameAndVars)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFirstFactor)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.ucrReceiverSecondFactor)
        Me.Controls.Add(Me.ucrReceiverFirstFactor)
        Me.Controls.Add(Me.ucrReceiverDataColumn)
        Me.Controls.Add(Me.ucrBaseNPTwoWayANOVA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNon_ParametricTwoWayAnova"
        Me.Tag = "Non-Parametric_Two_Way_ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseNPTwoWayANOVA As ucrButtons
    Friend WithEvents ucrReceiverDataColumn As ucrReceiverSingle
    Friend WithEvents ucrReceiverFirstFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondFactor As ucrReceiverSingle
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents lblFirstFactor As Label
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents ucrSelectorDataFrameAndVars As ucrSelectorByDataFrameAddRemove
End Class
