<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgClimaticDataEntry
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
        Me.ucrSelectorInfillMissing = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoDaily = New System.Windows.Forms.RadioButton()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrReceiverLevel = New instat.ucrReceiverSingle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrSelectorInfillMissing
        '
        Me.ucrSelectorInfillMissing.bDropUnusedFilterLevels = False
        Me.ucrSelectorInfillMissing.bShowHiddenColumns = False
        Me.ucrSelectorInfillMissing.bUseCurrentFilter = True
        Me.ucrSelectorInfillMissing.Location = New System.Drawing.Point(9, 56)
        Me.ucrSelectorInfillMissing.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorInfillMissing.Name = "ucrSelectorInfillMissing"
        Me.ucrSelectorInfillMissing.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorInfillMissing.TabIndex = 4
        '
        'rdoDaily
        '
        Me.rdoDaily.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDaily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoDaily.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDaily.FlatAppearance.BorderSize = 2
        Me.rdoDaily.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDaily.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDaily.Location = New System.Drawing.Point(277, 12)
        Me.rdoDaily.Name = "rdoDaily"
        Me.rdoDaily.Size = New System.Drawing.Size(135, 27)
        Me.rdoDaily.TabIndex = 25
        Me.rdoDaily.Text = "Daily"
        Me.rdoDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDaily.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        Me.rdoMonthly.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMonthly.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthly.FlatAppearance.BorderSize = 2
        Me.rdoMonthly.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMonthly.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMonthly.Location = New System.Drawing.Point(410, 12)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(135, 27)
        Me.rdoMonthly.TabIndex = 24
        Me.rdoMonthly.Text = "Monthly"
        Me.rdoMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(272, 10)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(278, 35)
        Me.ucrPnlOptions.TabIndex = 26
        '
        'ucrReceiverLevel
        '
        Me.ucrReceiverLevel.frmParent = Me
        Me.ucrReceiverLevel.Location = New System.Drawing.Point(272, 142)
        Me.ucrReceiverLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevel.Name = "ucrReceiverLevel"
        Me.ucrReceiverLevel.Selector = Nothing
        Me.ucrReceiverLevel.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLevel.strNcFilePath = ""
        Me.ucrReceiverLevel.TabIndex = 74
        Me.ucrReceiverLevel.ucrSelector = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(273, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Level:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(71, 375)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 82
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(273, 224)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(59, 13)
        Me.lblElement.TabIndex = 84
        Me.lblElement.Text = "Element(s):"
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(272, 241)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 83
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(272, 190)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 85
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(273, 174)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 86
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(273, 77)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 87
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(272, 93)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 88
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'dlgClimaticDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrReceiverLevel)
        Me.Controls.Add(Me.rdoDaily)
        Me.Controls.Add(Me.rdoMonthly)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSelectorInfillMissing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgClimaticDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Climatic Data Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorInfillMissing As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoDaily As RadioButton
    Friend WithEvents rdoMonthly As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrReceiverLevel As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
End Class
