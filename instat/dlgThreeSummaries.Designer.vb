<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgThreeSummaries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgThreeSummaries))
        Me.ucrBase = New instat.ucrButtons()
        Me.lblLinetype = New System.Windows.Forms.Label()
        Me.lblLineWidth = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblYlabel = New System.Windows.Forms.Label()
        Me.lblPlotType = New System.Windows.Forms.Label()
        Me.lblMaximum = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.nudlineWidth = New System.Windows.Forms.NumericUpDown()
        Me.nudPlotCharacter = New System.Windows.Forms.NumericUpDown()
        Me.nudLineType = New System.Windows.Forms.NumericUpDown()
        Me.txtColourMaximum = New System.Windows.Forms.TextBox()
        Me.txtColourMean = New System.Windows.Forms.TextBox()
        Me.txtPlotType = New System.Windows.Forms.TextBox()
        Me.txtColourMinimum = New System.Windows.Forms.TextBox()
        Me.txtYlabel = New System.Windows.Forms.TextBox()
        Me.txtVariable = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.grpColour = New System.Windows.Forms.GroupBox()
        Me.lblPlotCharacter = New System.Windows.Forms.Label()
        CType(Me.nudlineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLineType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpColour.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblLinetype
        '
        resources.ApplyResources(Me.lblLinetype, "lblLinetype")
        Me.lblLinetype.Name = "lblLinetype"
        Me.lblLinetype.Tag = "Line_type"
        '
        'lblLineWidth
        '
        resources.ApplyResources(Me.lblLineWidth, "lblLineWidth")
        Me.lblLineWidth.Name = "lblLineWidth"
        Me.lblLineWidth.Tag = "Line_Width"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Tag = "Title"
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        '
        'lblYlabel
        '
        resources.ApplyResources(Me.lblYlabel, "lblYlabel")
        Me.lblYlabel.Name = "lblYlabel"
        Me.lblYlabel.Tag = "Y_label"
        '
        'lblPlotType
        '
        resources.ApplyResources(Me.lblPlotType, "lblPlotType")
        Me.lblPlotType.Name = "lblPlotType"
        Me.lblPlotType.Tag = "Plot_Type"
        '
        'lblMaximum
        '
        resources.ApplyResources(Me.lblMaximum, "lblMaximum")
        Me.lblMaximum.Name = "lblMaximum"
        Me.lblMaximum.Tag = "Mean"
        '
        'lblMean
        '
        resources.ApplyResources(Me.lblMean, "lblMean")
        Me.lblMean.Name = "lblMean"
        '
        'lblMinimum
        '
        resources.ApplyResources(Me.lblMinimum, "lblMinimum")
        Me.lblMinimum.Name = "lblMinimum"
        '
        'nudlineWidth
        '
        resources.ApplyResources(Me.nudlineWidth, "nudlineWidth")
        Me.nudlineWidth.Name = "nudlineWidth"
        '
        'nudPlotCharacter
        '
        resources.ApplyResources(Me.nudPlotCharacter, "nudPlotCharacter")
        Me.nudPlotCharacter.Name = "nudPlotCharacter"
        '
        'nudLineType
        '
        resources.ApplyResources(Me.nudLineType, "nudLineType")
        Me.nudLineType.Name = "nudLineType"
        '
        'txtColourMaximum
        '
        resources.ApplyResources(Me.txtColourMaximum, "txtColourMaximum")
        Me.txtColourMaximum.Name = "txtColourMaximum"
        '
        'txtColourMean
        '
        resources.ApplyResources(Me.txtColourMean, "txtColourMean")
        Me.txtColourMean.Name = "txtColourMean"
        '
        'txtPlotType
        '
        resources.ApplyResources(Me.txtPlotType, "txtPlotType")
        Me.txtPlotType.Name = "txtPlotType"
        '
        'txtColourMinimum
        '
        resources.ApplyResources(Me.txtColourMinimum, "txtColourMinimum")
        Me.txtColourMinimum.Name = "txtColourMinimum"
        '
        'txtYlabel
        '
        resources.ApplyResources(Me.txtYlabel, "txtYlabel")
        Me.txtYlabel.Name = "txtYlabel"
        '
        'txtVariable
        '
        resources.ApplyResources(Me.txtVariable, "txtVariable")
        Me.txtVariable.Name = "txtVariable"
        '
        'txtTitle
        '
        resources.ApplyResources(Me.txtTitle, "txtTitle")
        Me.txtTitle.Name = "txtTitle"
        '
        'grpColour
        '
        Me.grpColour.Controls.Add(Me.txtColourMaximum)
        Me.grpColour.Controls.Add(Me.txtColourMinimum)
        Me.grpColour.Controls.Add(Me.txtColourMean)
        Me.grpColour.Controls.Add(Me.lblMinimum)
        Me.grpColour.Controls.Add(Me.lblMean)
        Me.grpColour.Controls.Add(Me.lblMaximum)
        resources.ApplyResources(Me.grpColour, "grpColour")
        Me.grpColour.Name = "grpColour"
        Me.grpColour.TabStop = False
        Me.grpColour.Tag = "Colour"
        '
        'lblPlotCharacter
        '
        resources.ApplyResources(Me.lblPlotCharacter, "lblPlotCharacter")
        Me.lblPlotCharacter.Name = "lblPlotCharacter"
        Me.lblPlotCharacter.Tag = "lblPlotCharacter"
        '
        'dlgThreeSummaries
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblPlotCharacter)
        Me.Controls.Add(Me.grpColour)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtVariable)
        Me.Controls.Add(Me.txtYlabel)
        Me.Controls.Add(Me.txtPlotType)
        Me.Controls.Add(Me.nudLineType)
        Me.Controls.Add(Me.nudPlotCharacter)
        Me.Controls.Add(Me.nudlineWidth)
        Me.Controls.Add(Me.lblPlotType)
        Me.Controls.Add(Me.lblYlabel)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLineWidth)
        Me.Controls.Add(Me.lblLinetype)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeSummaries"
        CType(Me.nudlineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLineType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpColour.ResumeLayout(False)
        Me.grpColour.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblLinetype As Label
    Friend WithEvents lblLineWidth As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblYlabel As Label
    Friend WithEvents lblPlotType As Label
    Friend WithEvents lblMaximum As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents lblMinimum As Label
    Friend WithEvents nudlineWidth As NumericUpDown
    Friend WithEvents nudPlotCharacter As NumericUpDown
    Friend WithEvents nudLineType As NumericUpDown
    Friend WithEvents txtColourMaximum As TextBox
    Friend WithEvents txtColourMean As TextBox
    Friend WithEvents txtPlotType As TextBox
    Friend WithEvents txtColourMinimum As TextBox
    Friend WithEvents txtYlabel As TextBox
    Friend WithEvents txtVariable As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents grpColour As GroupBox
    Friend WithEvents lblPlotCharacter As Label
End Class