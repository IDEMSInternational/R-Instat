<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExtremesClimatic
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorClimaticExtremes = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrButtonMinMax = New System.Windows.Forms.Button()
        Me.ucrButtonPeaks = New System.Windows.Forms.Button()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle3 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle4 = New instat.ucrReceiverSingle()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayOfYear = New System.Windows.Forms.Label()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.grpMaxMin = New System.Windows.Forms.GroupBox()
        Me.ucrMaxima = New instat.ucrCheck()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblThresh = New System.Windows.Forms.Label()
        Me.ucrInputThreshhold = New instat.ucrInputTextBox()
        Me.ucrValueThreshhold = New instat.ucrCheck()
        Me.grpMaxMin.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 404)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(398, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrSelectorClimaticExtremes
        '
        Me.ucrSelectorClimaticExtremes.bShowHiddenColumns = False
        Me.ucrSelectorClimaticExtremes.bUseCurrentFilter = True
        Me.ucrSelectorClimaticExtremes.Location = New System.Drawing.Point(9, 52)
        Me.ucrSelectorClimaticExtremes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticExtremes.Name = "ucrSelectorClimaticExtremes"
        Me.ucrSelectorClimaticExtremes.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClimaticExtremes.TabIndex = 4
        '
        'ucrButtonMinMax
        '
        Me.ucrButtonMinMax.Location = New System.Drawing.Point(39, 12)
        Me.ucrButtonMinMax.Name = "ucrButtonMinMax"
        Me.ucrButtonMinMax.Size = New System.Drawing.Size(75, 23)
        Me.ucrButtonMinMax.TabIndex = 5
        Me.ucrButtonMinMax.Text = "Min/Max"
        Me.ucrButtonMinMax.UseVisualStyleBackColor = True
        '
        'ucrButtonPeaks
        '
        Me.ucrButtonPeaks.Location = New System.Drawing.Point(144, 12)
        Me.ucrButtonPeaks.Name = "ucrButtonPeaks"
        Me.ucrButtonPeaks.Size = New System.Drawing.Size(75, 23)
        Me.ucrButtonPeaks.TabIndex = 6
        Me.ucrButtonPeaks.Text = "Peaks"
        Me.ucrButtonPeaks.UseVisualStyleBackColor = True
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.frmParent = Me
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(272, 41)
        Me.UcrReceiverSingle1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Selector = Nothing
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle1.TabIndex = 7
        Me.UcrReceiverSingle1.ucrSelector = Nothing
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.frmParent = Me
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(272, 85)
        Me.UcrReceiverSingle2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Selector = Nothing
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle2.TabIndex = 8
        Me.UcrReceiverSingle2.ucrSelector = Nothing
        '
        'UcrReceiverSingle3
        '
        Me.UcrReceiverSingle3.frmParent = Me
        Me.UcrReceiverSingle3.Location = New System.Drawing.Point(272, 128)
        Me.UcrReceiverSingle3.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle3.Name = "UcrReceiverSingle3"
        Me.UcrReceiverSingle3.Selector = Nothing
        Me.UcrReceiverSingle3.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle3.TabIndex = 9
        Me.UcrReceiverSingle3.ucrSelector = Nothing
        '
        'UcrReceiverSingle4
        '
        Me.UcrReceiverSingle4.frmParent = Me
        Me.UcrReceiverSingle4.Location = New System.Drawing.Point(272, 179)
        Me.UcrReceiverSingle4.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle4.Name = "UcrReceiverSingle4"
        Me.UcrReceiverSingle4.Selector = Nothing
        Me.UcrReceiverSingle4.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle4.TabIndex = 10
        Me.UcrReceiverSingle4.ucrSelector = Nothing
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.Location = New System.Drawing.Point(269, 25)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(45, 13)
        Me.lblStations.TabIndex = 11
        Me.lblStations.Text = "Stations"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(269, 70)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "Date"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(270, 113)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 13
        Me.lblYear.Text = "Year"
        '
        'lblDayOfYear
        '
        Me.lblDayOfYear.AutoSize = True
        Me.lblDayOfYear.Location = New System.Drawing.Point(269, 162)
        Me.lblDayOfYear.Name = "lblDayOfYear"
        Me.lblDayOfYear.Size = New System.Drawing.Size(65, 13)
        Me.lblDayOfYear.TabIndex = 14
        Me.lblDayOfYear.Text = "Day Of Year"
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(259, 232)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 15
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(322, 232)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 16
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(255, 219)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 17
        Me.lblFrom.Text = "From"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(318, 216)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 18
        Me.lblTo.Text = "To"
        '
        'grpMaxMin
        '
        Me.grpMaxMin.Controls.Add(Me.ucrMaxima)
        Me.grpMaxMin.Location = New System.Drawing.Point(19, 256)
        Me.grpMaxMin.Name = "grpMaxMin"
        Me.grpMaxMin.Size = New System.Drawing.Size(165, 100)
        Me.grpMaxMin.TabIndex = 19
        Me.grpMaxMin.TabStop = False
        Me.grpMaxMin.Text = "Max/Min"
        '
        'ucrMaxima
        '
        Me.ucrMaxima.Checked = False
        Me.ucrMaxima.Location = New System.Drawing.Point(7, 25)
        Me.ucrMaxima.Name = "ucrMaxima"
        Me.ucrMaxima.Size = New System.Drawing.Size(100, 20)
        Me.ucrMaxima.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrValueThreshhold)
        Me.GroupBox1.Controls.Add(Me.lblThresh)
        Me.GroupBox1.Controls.Add(Me.ucrInputThreshhold)
        Me.GroupBox1.Location = New System.Drawing.Point(227, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 100)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Peaks"
        '
        'lblThresh
        '
        Me.lblThresh.AutoSize = True
        Me.lblThresh.Location = New System.Drawing.Point(6, 16)
        Me.lblThresh.Name = "lblThresh"
        Me.lblThresh.Size = New System.Drawing.Size(30, 13)
        Me.lblThresh.TabIndex = 18
        Me.lblThresh.Text = "From"
        '
        'ucrInputThreshhold
        '
        Me.ucrInputThreshhold.AddQuotesIfUnrecognised = True
        Me.ucrInputThreshhold.IsMultiline = False
        Me.ucrInputThreshhold.IsReadOnly = False
        Me.ucrInputThreshhold.Location = New System.Drawing.Point(8, 31)
        Me.ucrInputThreshhold.Name = "ucrInputThreshhold"
        Me.ucrInputThreshhold.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputThreshhold.TabIndex = 0
        '
        'ucrValueThreshhold
        '
        Me.ucrValueThreshhold.Checked = False
        Me.ucrValueThreshhold.Location = New System.Drawing.Point(8, 74)
        Me.ucrValueThreshhold.Name = "ucrValueThreshhold"
        Me.ucrValueThreshhold.Size = New System.Drawing.Size(103, 20)
        Me.ucrValueThreshhold.TabIndex = 19
        '
        'dlgExtremesClimatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 464)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpMaxMin)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.ucrNudTo)
        Me.Controls.Add(Me.ucrNudFrom)
        Me.Controls.Add(Me.lblDayOfYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.UcrReceiverSingle4)
        Me.Controls.Add(Me.UcrReceiverSingle3)
        Me.Controls.Add(Me.UcrReceiverSingle2)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.ucrButtonPeaks)
        Me.Controls.Add(Me.ucrButtonMinMax)
        Me.Controls.Add(Me.ucrSelectorClimaticExtremes)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremesClimatic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extremes Climatic"
        Me.grpMaxMin.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorClimaticExtremes As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrButtonMinMax As Button
    Friend WithEvents ucrButtonPeaks As Button
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblThresh As Label
    Friend WithEvents ucrInputThreshhold As ucrInputTextBox
    Friend WithEvents grpMaxMin As GroupBox
    Friend WithEvents ucrMaxima As ucrCheck
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents lblDayOfYear As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStations As Label
    Friend WithEvents UcrReceiverSingle4 As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle3 As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents ucrValueThreshhold As ucrCheck
End Class
