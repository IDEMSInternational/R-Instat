<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportClimaticDefinitions
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
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.btnConnection = New System.Windows.Forms.Button()
        Me.ucrSelectorExportToEPicsa = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblAnnualRainfallSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverAnnualRainfallSummaries = New instat.ucrReceiverSingle()
        Me.lblMonthlyTempSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverMonthlyTempSummaries = New instat.ucrReceiverSingle()
        Me.lblAnnualTempSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverAnnualTempSummaries = New instat.ucrReceiverSingle()
        Me.lblMonthlyRainfallSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverMonthlyRainfallSummaries = New instat.ucrReceiverSingle()
        Me.grpDefinitionsProducts = New System.Windows.Forms.GroupBox()
        Me.lblMonthlyRainfall = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleMonthlyRainfall = New instat.ucrReceiverMultiple()
        Me.lblMonthlyTemp = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleMonthlyTemp = New instat.ucrReceiverMultiple()
        Me.lblAnnualTemp = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleAnnualTemp = New instat.ucrReceiverMultiple()
        Me.lblAnnualRainfall = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleAnnualRainfall = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDefinitionsProducts.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(265, 21)
        Me.lblConnection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(114, 20)
        Me.lblConnection.TabIndex = 18
        Me.lblConnection.Text = "No Connection"
        '
        'btnConnection
        '
        Me.btnConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnection.Location = New System.Drawing.Point(29, 13)
        Me.btnConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Size = New System.Drawing.Size(220, 34)
        Me.btnConnection.TabIndex = 17
        Me.btnConnection.Text = "Connect to Database"
        Me.btnConnection.UseVisualStyleBackColor = True
        '
        'ucrSelectorExportToEPicsa
        '
        Me.ucrSelectorExportToEPicsa.AutoSize = True
        Me.ucrSelectorExportToEPicsa.bDropUnusedFilterLevels = False
        Me.ucrSelectorExportToEPicsa.bShowHiddenColumns = False
        Me.ucrSelectorExportToEPicsa.bUseCurrentFilter = True
        Me.ucrSelectorExportToEPicsa.Location = New System.Drawing.Point(29, 57)
        Me.ucrSelectorExportToEPicsa.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExportToEPicsa.Name = "ucrSelectorExportToEPicsa"
        Me.ucrSelectorExportToEPicsa.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorExportToEPicsa.TabIndex = 19
        '
        'lblAnnualRainfallSummaries
        '
        Me.lblAnnualRainfallSummaries.AutoSize = True
        Me.lblAnnualRainfallSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAnnualRainfallSummaries.Location = New System.Drawing.Point(403, 63)
        Me.lblAnnualRainfallSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnnualRainfallSummaries.Name = "lblAnnualRainfallSummaries"
        Me.lblAnnualRainfallSummaries.Size = New System.Drawing.Size(204, 20)
        Me.lblAnnualRainfallSummaries.TabIndex = 20
        Me.lblAnnualRainfallSummaries.Tag = "By_Factor:"
        Me.lblAnnualRainfallSummaries.Text = "Annual Rainfall Summaries:"
        '
        'ucrReceiverAnnualRainfallSummaries
        '
        Me.ucrReceiverAnnualRainfallSummaries.AutoSize = True
        Me.ucrReceiverAnnualRainfallSummaries.frmParent = Me
        Me.ucrReceiverAnnualRainfallSummaries.Location = New System.Drawing.Point(407, 85)
        Me.ucrReceiverAnnualRainfallSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAnnualRainfallSummaries.Name = "ucrReceiverAnnualRainfallSummaries"
        Me.ucrReceiverAnnualRainfallSummaries.Selector = Nothing
        Me.ucrReceiverAnnualRainfallSummaries.Size = New System.Drawing.Size(251, 30)
        Me.ucrReceiverAnnualRainfallSummaries.strNcFilePath = ""
        Me.ucrReceiverAnnualRainfallSummaries.TabIndex = 21
        Me.ucrReceiverAnnualRainfallSummaries.ucrSelector = Nothing
        '
        'lblMonthlyTempSummaries
        '
        Me.lblMonthlyTempSummaries.AutoSize = True
        Me.lblMonthlyTempSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonthlyTempSummaries.Location = New System.Drawing.Point(403, 249)
        Me.lblMonthlyTempSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonthlyTempSummaries.Name = "lblMonthlyTempSummaries"
        Me.lblMonthlyTempSummaries.Size = New System.Drawing.Size(247, 20)
        Me.lblMonthlyTempSummaries.TabIndex = 24
        Me.lblMonthlyTempSummaries.Tag = "By_Factor:"
        Me.lblMonthlyTempSummaries.Text = "Monthly Temperature Summaries:"
        '
        'ucrReceiverMonthlyTempSummaries
        '
        Me.ucrReceiverMonthlyTempSummaries.AutoSize = True
        Me.ucrReceiverMonthlyTempSummaries.frmParent = Me
        Me.ucrReceiverMonthlyTempSummaries.Location = New System.Drawing.Point(407, 271)
        Me.ucrReceiverMonthlyTempSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthlyTempSummaries.Name = "ucrReceiverMonthlyTempSummaries"
        Me.ucrReceiverMonthlyTempSummaries.Selector = Nothing
        Me.ucrReceiverMonthlyTempSummaries.Size = New System.Drawing.Size(251, 30)
        Me.ucrReceiverMonthlyTempSummaries.strNcFilePath = ""
        Me.ucrReceiverMonthlyTempSummaries.TabIndex = 25
        Me.ucrReceiverMonthlyTempSummaries.ucrSelector = Nothing
        '
        'lblAnnualTempSummaries
        '
        Me.lblAnnualTempSummaries.AutoSize = True
        Me.lblAnnualTempSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAnnualTempSummaries.Location = New System.Drawing.Point(403, 125)
        Me.lblAnnualTempSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnnualTempSummaries.Name = "lblAnnualTempSummaries"
        Me.lblAnnualTempSummaries.Size = New System.Drawing.Size(242, 20)
        Me.lblAnnualTempSummaries.TabIndex = 26
        Me.lblAnnualTempSummaries.Tag = "By_Factor:"
        Me.lblAnnualTempSummaries.Text = "Annual Temperature Summaries:"
        '
        'ucrReceiverAnnualTempSummaries
        '
        Me.ucrReceiverAnnualTempSummaries.AutoSize = True
        Me.ucrReceiverAnnualTempSummaries.frmParent = Me
        Me.ucrReceiverAnnualTempSummaries.Location = New System.Drawing.Point(407, 147)
        Me.ucrReceiverAnnualTempSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAnnualTempSummaries.Name = "ucrReceiverAnnualTempSummaries"
        Me.ucrReceiverAnnualTempSummaries.Selector = Nothing
        Me.ucrReceiverAnnualTempSummaries.Size = New System.Drawing.Size(251, 30)
        Me.ucrReceiverAnnualTempSummaries.strNcFilePath = ""
        Me.ucrReceiverAnnualTempSummaries.TabIndex = 27
        Me.ucrReceiverAnnualTempSummaries.ucrSelector = Nothing
        '
        'lblMonthlyRainfallSummaries
        '
        Me.lblMonthlyRainfallSummaries.AutoSize = True
        Me.lblMonthlyRainfallSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonthlyRainfallSummaries.Location = New System.Drawing.Point(403, 187)
        Me.lblMonthlyRainfallSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonthlyRainfallSummaries.Name = "lblMonthlyRainfallSummaries"
        Me.lblMonthlyRainfallSummaries.Size = New System.Drawing.Size(209, 20)
        Me.lblMonthlyRainfallSummaries.TabIndex = 28
        Me.lblMonthlyRainfallSummaries.Tag = "By_Factor:"
        Me.lblMonthlyRainfallSummaries.Text = "Monthly Rainfall Summaries:"
        '
        'ucrReceiverMonthlyRainfallSummaries
        '
        Me.ucrReceiverMonthlyRainfallSummaries.AutoSize = True
        Me.ucrReceiverMonthlyRainfallSummaries.frmParent = Me
        Me.ucrReceiverMonthlyRainfallSummaries.Location = New System.Drawing.Point(407, 209)
        Me.ucrReceiverMonthlyRainfallSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthlyRainfallSummaries.Name = "ucrReceiverMonthlyRainfallSummaries"
        Me.ucrReceiverMonthlyRainfallSummaries.Selector = Nothing
        Me.ucrReceiverMonthlyRainfallSummaries.Size = New System.Drawing.Size(251, 30)
        Me.ucrReceiverMonthlyRainfallSummaries.strNcFilePath = ""
        Me.ucrReceiverMonthlyRainfallSummaries.TabIndex = 29
        Me.ucrReceiverMonthlyRainfallSummaries.ucrSelector = Nothing
        '
        'grpDefinitionsProducts
        '
        Me.grpDefinitionsProducts.Controls.Add(Me.lblMonthlyRainfall)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverMultipleMonthlyRainfall)
        Me.grpDefinitionsProducts.Controls.Add(Me.lblMonthlyTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverMultipleMonthlyTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.lblAnnualTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverMultipleAnnualTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.lblAnnualRainfall)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverMultipleAnnualRainfall)
        Me.grpDefinitionsProducts.Location = New System.Drawing.Point(19, 350)
        Me.grpDefinitionsProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDefinitionsProducts.Name = "grpDefinitionsProducts"
        Me.grpDefinitionsProducts.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDefinitionsProducts.Size = New System.Drawing.Size(639, 481)
        Me.grpDefinitionsProducts.TabIndex = 32
        Me.grpDefinitionsProducts.TabStop = False
        Me.grpDefinitionsProducts.Tag = ""
        Me.grpDefinitionsProducts.Text = "Definitions Products"
        '
        'lblMonthlyRainfall
        '
        Me.lblMonthlyRainfall.AutoSize = True
        Me.lblMonthlyRainfall.Location = New System.Drawing.Point(13, 259)
        Me.lblMonthlyRainfall.Name = "lblMonthlyRainfall"
        Me.lblMonthlyRainfall.Size = New System.Drawing.Size(125, 20)
        Me.lblMonthlyRainfall.TabIndex = 12
        Me.lblMonthlyRainfall.Text = "Monthly Rainfall:"
        '
        'ucrReceiverMultipleMonthlyRainfall
        '
        Me.ucrReceiverMultipleMonthlyRainfall.AutoSize = True
        Me.ucrReceiverMultipleMonthlyRainfall.frmParent = Me
        Me.ucrReceiverMultipleMonthlyRainfall.Location = New System.Drawing.Point(17, 282)
        Me.ucrReceiverMultipleMonthlyRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleMonthlyRainfall.Name = "ucrReceiverMultipleMonthlyRainfall"
        Me.ucrReceiverMultipleMonthlyRainfall.Selector = Nothing
        Me.ucrReceiverMultipleMonthlyRainfall.Size = New System.Drawing.Size(213, 189)
        Me.ucrReceiverMultipleMonthlyRainfall.strNcFilePath = ""
        Me.ucrReceiverMultipleMonthlyRainfall.TabIndex = 11
        Me.ucrReceiverMultipleMonthlyRainfall.ucrSelector = Nothing
        '
        'lblMonthlyTemp
        '
        Me.lblMonthlyTemp.AutoSize = True
        Me.lblMonthlyTemp.Location = New System.Drawing.Point(405, 259)
        Me.lblMonthlyTemp.Name = "lblMonthlyTemp"
        Me.lblMonthlyTemp.Size = New System.Drawing.Size(163, 20)
        Me.lblMonthlyTemp.TabIndex = 10
        Me.lblMonthlyTemp.Text = "Monthly Temperature:"
        '
        'ucrReceiverMultipleMonthlyTemp
        '
        Me.ucrReceiverMultipleMonthlyTemp.AutoSize = True
        Me.ucrReceiverMultipleMonthlyTemp.frmParent = Me
        Me.ucrReceiverMultipleMonthlyTemp.Location = New System.Drawing.Point(409, 282)
        Me.ucrReceiverMultipleMonthlyTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleMonthlyTemp.Name = "ucrReceiverMultipleMonthlyTemp"
        Me.ucrReceiverMultipleMonthlyTemp.Selector = Nothing
        Me.ucrReceiverMultipleMonthlyTemp.Size = New System.Drawing.Size(213, 189)
        Me.ucrReceiverMultipleMonthlyTemp.strNcFilePath = ""
        Me.ucrReceiverMultipleMonthlyTemp.TabIndex = 9
        Me.ucrReceiverMultipleMonthlyTemp.ucrSelector = Nothing
        '
        'lblAnnualTemp
        '
        Me.lblAnnualTemp.AutoSize = True
        Me.lblAnnualTemp.Location = New System.Drawing.Point(405, 28)
        Me.lblAnnualTemp.Name = "lblAnnualTemp"
        Me.lblAnnualTemp.Size = New System.Drawing.Size(158, 20)
        Me.lblAnnualTemp.TabIndex = 8
        Me.lblAnnualTemp.Text = "Annual Temperature:"
        '
        'ucrReceiverMultipleAnnualTemp
        '
        Me.ucrReceiverMultipleAnnualTemp.AutoSize = True
        Me.ucrReceiverMultipleAnnualTemp.frmParent = Me
        Me.ucrReceiverMultipleAnnualTemp.Location = New System.Drawing.Point(409, 51)
        Me.ucrReceiverMultipleAnnualTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleAnnualTemp.Name = "ucrReceiverMultipleAnnualTemp"
        Me.ucrReceiverMultipleAnnualTemp.Selector = Nothing
        Me.ucrReceiverMultipleAnnualTemp.Size = New System.Drawing.Size(213, 189)
        Me.ucrReceiverMultipleAnnualTemp.strNcFilePath = ""
        Me.ucrReceiverMultipleAnnualTemp.TabIndex = 7
        Me.ucrReceiverMultipleAnnualTemp.ucrSelector = Nothing
        '
        'lblAnnualRainfall
        '
        Me.lblAnnualRainfall.AutoSize = True
        Me.lblAnnualRainfall.Location = New System.Drawing.Point(13, 28)
        Me.lblAnnualRainfall.Name = "lblAnnualRainfall"
        Me.lblAnnualRainfall.Size = New System.Drawing.Size(120, 20)
        Me.lblAnnualRainfall.TabIndex = 6
        Me.lblAnnualRainfall.Text = "Annual Rainfall:"
        '
        'ucrReceiverMultipleAnnualRainfall
        '
        Me.ucrReceiverMultipleAnnualRainfall.AutoSize = True
        Me.ucrReceiverMultipleAnnualRainfall.frmParent = Me
        Me.ucrReceiverMultipleAnnualRainfall.Location = New System.Drawing.Point(17, 51)
        Me.ucrReceiverMultipleAnnualRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleAnnualRainfall.Name = "ucrReceiverMultipleAnnualRainfall"
        Me.ucrReceiverMultipleAnnualRainfall.Selector = Nothing
        Me.ucrReceiverMultipleAnnualRainfall.Size = New System.Drawing.Size(213, 189)
        Me.ucrReceiverMultipleAnnualRainfall.strNcFilePath = ""
        Me.ucrReceiverMultipleAnnualRainfall.TabIndex = 5
        Me.ucrReceiverMultipleAnnualRainfall.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(19, 845)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 52
        '
        'dlgExportClimaticDefinitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(677, 928)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpDefinitionsProducts)
        Me.Controls.Add(Me.lblMonthlyRainfallSummaries)
        Me.Controls.Add(Me.ucrReceiverMonthlyRainfallSummaries)
        Me.Controls.Add(Me.lblAnnualTempSummaries)
        Me.Controls.Add(Me.ucrReceiverAnnualTempSummaries)
        Me.Controls.Add(Me.lblMonthlyTempSummaries)
        Me.Controls.Add(Me.ucrReceiverMonthlyTempSummaries)
        Me.Controls.Add(Me.lblAnnualRainfallSummaries)
        Me.Controls.Add(Me.ucrReceiverAnnualRainfallSummaries)
        Me.Controls.Add(Me.ucrSelectorExportToEPicsa)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.btnConnection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportClimaticDefinitions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export to EPicsa"
        Me.grpDefinitionsProducts.ResumeLayout(False)
        Me.grpDefinitionsProducts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConnection As Label
    Friend WithEvents btnConnection As Button
    Friend WithEvents ucrSelectorExportToEPicsa As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblAnnualRainfallSummaries As Label
    Friend WithEvents ucrReceiverAnnualRainfallSummaries As ucrReceiverSingle
    Friend WithEvents lblMonthlyRainfallSummaries As Label
    Friend WithEvents ucrReceiverMonthlyRainfallSummaries As ucrReceiverSingle
    Friend WithEvents lblAnnualTempSummaries As Label
    Friend WithEvents ucrReceiverAnnualTempSummaries As ucrReceiverSingle
    Friend WithEvents lblMonthlyTempSummaries As Label
    Friend WithEvents ucrReceiverMonthlyTempSummaries As ucrReceiverSingle
    Friend WithEvents grpDefinitionsProducts As GroupBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblMonthlyRainfall As Label
    Friend WithEvents ucrReceiverMultipleMonthlyRainfall As ucrReceiverMultiple
    Friend WithEvents lblMonthlyTemp As Label
    Friend WithEvents ucrReceiverMultipleMonthlyTemp As ucrReceiverMultiple
    Friend WithEvents lblAnnualTemp As Label
    Friend WithEvents ucrReceiverMultipleAnnualTemp As ucrReceiverMultiple
    Friend WithEvents lblAnnualRainfall As Label
    Friend WithEvents ucrReceiverMultipleAnnualRainfall As ucrReceiverMultiple
End Class
