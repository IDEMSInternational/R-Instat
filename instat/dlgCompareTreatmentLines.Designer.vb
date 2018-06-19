<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCompareTreatmentLines
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCompareTreatmentLines))
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblTreamtments = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.ucrReceiverID = New instat.ucrReceiverSingle()
        Me.ucrReceiverTreatments = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeasurement = New instat.ucrReceiverSingle()
        Me.ucrSelectorPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputFactorTreatment1 = New instat.ucrInputFactorLevels()
        Me.ucrInputFactorTreatment2 = New instat.ucrInputFactorLevels()
        Me.lblTreatment1 = New System.Windows.Forms.Label()
        Me.lblTreatment2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMeasurement
        '
        resources.ApplyResources(Me.lblMeasurement, "lblMeasurement")
        Me.lblMeasurement.Name = "lblMeasurement"
        '
        'lblTreamtments
        '
        resources.ApplyResources(Me.lblTreamtments, "lblTreamtments")
        Me.lblTreamtments.Name = "lblTreamtments"
        '
        'lblID
        '
        resources.ApplyResources(Me.lblID, "lblID")
        Me.lblID.Name = "lblID"
        '
        'ucrReceiverID
        '
        Me.ucrReceiverID.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverID, "ucrReceiverID")
        Me.ucrReceiverID.Name = "ucrReceiverID"
        Me.ucrReceiverID.Selector = Nothing
        Me.ucrReceiverID.strNcFilePath = ""
        Me.ucrReceiverID.ucrSelector = Nothing
        '
        'ucrReceiverTreatments
        '
        Me.ucrReceiverTreatments.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTreatments, "ucrReceiverTreatments")
        Me.ucrReceiverTreatments.Name = "ucrReceiverTreatments"
        Me.ucrReceiverTreatments.Selector = Nothing
        Me.ucrReceiverTreatments.strNcFilePath = ""
        Me.ucrReceiverTreatments.ucrSelector = Nothing
        '
        'ucrReceiverMeasurement
        '
        Me.ucrReceiverMeasurement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMeasurement, "ucrReceiverMeasurement")
        Me.ucrReceiverMeasurement.Name = "ucrReceiverMeasurement"
        Me.ucrReceiverMeasurement.Selector = Nothing
        Me.ucrReceiverMeasurement.strNcFilePath = ""
        Me.ucrReceiverMeasurement.ucrSelector = Nothing
        '
        'ucrSelectorPlot
        '
        Me.ucrSelectorPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorPlot.bShowHiddenColumns = False
        Me.ucrSelectorPlot.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorPlot, "ucrSelectorPlot")
        Me.ucrSelectorPlot.Name = "ucrSelectorPlot"
        '
        'ucrSavePlot
        '
        resources.ApplyResources(Me.ucrSavePlot, "ucrSavePlot")
        Me.ucrSavePlot.Name = "ucrSavePlot"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputFactorTreatment1
        '
        Me.ucrInputFactorTreatment1.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorTreatment1.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFactorTreatment1, "ucrInputFactorTreatment1")
        Me.ucrInputFactorTreatment1.Name = "ucrInputFactorTreatment1"
        '
        'ucrInputFactorTreatment2
        '
        Me.ucrInputFactorTreatment2.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorTreatment2.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFactorTreatment2, "ucrInputFactorTreatment2")
        Me.ucrInputFactorTreatment2.Name = "ucrInputFactorTreatment2"
        '
        'lblTreatment1
        '
        resources.ApplyResources(Me.lblTreatment1, "lblTreatment1")
        Me.lblTreatment1.Name = "lblTreatment1"
        '
        'lblTreatment2
        '
        resources.ApplyResources(Me.lblTreatment2, "lblTreatment2")
        Me.lblTreatment2.Name = "lblTreatment2"
        '
        'dlgCompareTreatmentLines
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTreatment2)
        Me.Controls.Add(Me.lblTreatment1)
        Me.Controls.Add(Me.ucrInputFactorTreatment2)
        Me.Controls.Add(Me.ucrInputFactorTreatment1)
        Me.Controls.Add(Me.ucrReceiverID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.ucrReceiverTreatments)
        Me.Controls.Add(Me.lblTreamtments)
        Me.Controls.Add(Me.ucrReceiverMeasurement)
        Me.Controls.Add(Me.lblMeasurement)
        Me.Controls.Add(Me.ucrSelectorPlot)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompareTreatmentLines"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrSelectorPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents ucrReceiverMeasurement As ucrReceiverSingle
    Friend WithEvents ucrReceiverTreatments As ucrReceiverSingle
    Friend WithEvents lblTreamtments As Label
    Friend WithEvents ucrReceiverID As ucrReceiverSingle
    Friend WithEvents lblID As Label
    Friend WithEvents lblTreatment2 As Label
    Friend WithEvents lblTreatment1 As Label
    Friend WithEvents ucrInputFactorTreatment2 As ucrInputFactorLevels
    Friend WithEvents ucrInputFactorTreatment1 As ucrInputFactorLevels
End Class
