<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCompare
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCompare))
        Me.ucrSelectorCompare = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSateliteElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblSateliteElement = New System.Windows.Forms.Label()
        Me.lblStationElement = New System.Windows.Forms.Label()
        Me.lblWithinYear = New System.Windows.Forms.Label()
        Me.ucrReceiverWithinYear = New instat.ucrReceiverSingle()
        Me.ucrChkAbsoluteDifference = New instat.ucrCheck()
        Me.ucrChkDifference = New instat.ucrCheck()
        Me.ucrSaveAbsDev = New instat.ucrSave()
        Me.ucrSaveBias = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'ucrSelectorCompare
        '
        Me.ucrSelectorCompare.bDropUnusedFilterLevels = False
        Me.ucrSelectorCompare.bShowHiddenColumns = False
        Me.ucrSelectorCompare.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorCompare, "ucrSelectorCompare")
        Me.ucrSelectorCompare.Name = "ucrSelectorCompare"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverSateliteElement
        '
        Me.ucrReceiverSateliteElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSateliteElement, "ucrReceiverSateliteElement")
        Me.ucrReceiverSateliteElement.Name = "ucrReceiverSateliteElement"
        Me.ucrReceiverSateliteElement.Selector = Nothing
        Me.ucrReceiverSateliteElement.strNcFilePath = ""
        Me.ucrReceiverSateliteElement.ucrSelector = Nothing
        '
        'ucrReceiverStationElement
        '
        Me.ucrReceiverStationElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStationElement, "ucrReceiverStationElement")
        Me.ucrReceiverStationElement.Name = "ucrReceiverStationElement"
        Me.ucrReceiverStationElement.Selector = Nothing
        Me.ucrReceiverStationElement.strNcFilePath = ""
        Me.ucrReceiverStationElement.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblSateliteElement
        '
        resources.ApplyResources(Me.lblSateliteElement, "lblSateliteElement")
        Me.lblSateliteElement.Name = "lblSateliteElement"
        '
        'lblStationElement
        '
        resources.ApplyResources(Me.lblStationElement, "lblStationElement")
        Me.lblStationElement.Name = "lblStationElement"
        '
        'lblWithinYear
        '
        resources.ApplyResources(Me.lblWithinYear, "lblWithinYear")
        Me.lblWithinYear.Name = "lblWithinYear"
        '
        'ucrReceiverWithinYear
        '
        Me.ucrReceiverWithinYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWithinYear, "ucrReceiverWithinYear")
        Me.ucrReceiverWithinYear.Name = "ucrReceiverWithinYear"
        Me.ucrReceiverWithinYear.Selector = Nothing
        Me.ucrReceiverWithinYear.strNcFilePath = ""
        Me.ucrReceiverWithinYear.ucrSelector = Nothing
        '
        'ucrChkAbsoluteDifference
        '
        Me.ucrChkAbsoluteDifference.Checked = False
        resources.ApplyResources(Me.ucrChkAbsoluteDifference, "ucrChkAbsoluteDifference")
        Me.ucrChkAbsoluteDifference.Name = "ucrChkAbsoluteDifference"
        '
        'ucrChkDifference
        '
        Me.ucrChkDifference.Checked = False
        resources.ApplyResources(Me.ucrChkDifference, "ucrChkDifference")
        Me.ucrChkDifference.Name = "ucrChkDifference"
        '
        'ucrSaveAbsDev
        '
        resources.ApplyResources(Me.ucrSaveAbsDev, "ucrSaveAbsDev")
        Me.ucrSaveAbsDev.Name = "ucrSaveAbsDev"
        '
        'ucrSaveBias
        '
        resources.ApplyResources(Me.ucrSaveBias, "ucrSaveBias")
        Me.ucrSaveBias.Name = "ucrSaveBias"
        '
        'dlgCompare
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveBias)
        Me.Controls.Add(Me.ucrSaveAbsDev)
        Me.Controls.Add(Me.ucrChkDifference)
        Me.Controls.Add(Me.ucrChkAbsoluteDifference)
        Me.Controls.Add(Me.lblWithinYear)
        Me.Controls.Add(Me.ucrReceiverWithinYear)
        Me.Controls.Add(Me.lblStationElement)
        Me.Controls.Add(Me.lblSateliteElement)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverStationElement)
        Me.Controls.Add(Me.ucrReceiverSateliteElement)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorCompare)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorCompare As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverSateliteElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationElement As ucrReceiverSingle
    Friend WithEvents lblStationElement As Label
    Friend WithEvents lblSateliteElement As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents lblWithinYear As Label
    Friend WithEvents ucrReceiverWithinYear As ucrReceiverSingle
    Friend WithEvents ucrSaveBias As ucrSave
    Friend WithEvents ucrSaveAbsDev As ucrSave
    Friend WithEvents ucrChkDifference As ucrCheck
    Friend WithEvents ucrChkAbsoluteDifference As ucrCheck
End Class
