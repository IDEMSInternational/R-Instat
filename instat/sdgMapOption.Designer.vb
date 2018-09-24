<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgMapOption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgMapOption))
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblLongMin = New System.Windows.Forms.Label()
        Me.lblLatMax = New System.Windows.Forms.Label()
        Me.lblLongMax = New System.Windows.Forms.Label()
        Me.lblLatMin = New System.Windows.Forms.Label()
        Me.lblLong = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrInputLatMax = New instat.ucrInputTextBox()
        Me.ucrInputLongMax = New instat.ucrInputTextBox()
        Me.ucrInputLatMin = New instat.ucrInputTextBox()
        Me.ucrInputLongMin = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblLat
        '
        resources.ApplyResources(Me.lblLat, "lblLat")
        Me.lblLat.Name = "lblLat"
        '
        'lblLongMin
        '
        resources.ApplyResources(Me.lblLongMin, "lblLongMin")
        Me.lblLongMin.Name = "lblLongMin"
        '
        'lblLatMax
        '
        resources.ApplyResources(Me.lblLatMax, "lblLatMax")
        Me.lblLatMax.Name = "lblLatMax"
        '
        'lblLongMax
        '
        resources.ApplyResources(Me.lblLongMax, "lblLongMax")
        Me.lblLongMax.Name = "lblLongMax"
        '
        'lblLatMin
        '
        resources.ApplyResources(Me.lblLatMin, "lblLatMin")
        Me.lblLatMin.Name = "lblLatMin"
        '
        'lblLong
        '
        resources.ApplyResources(Me.lblLong, "lblLong")
        Me.lblLong.Name = "lblLong"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputLatMax
        '
        Me.ucrInputLatMax.AddQuotesIfUnrecognised = False
        Me.ucrInputLatMax.IsMultiline = False
        Me.ucrInputLatMax.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLatMax, "ucrInputLatMax")
        Me.ucrInputLatMax.Name = "ucrInputLatMax"
        '
        'ucrInputLongMax
        '
        Me.ucrInputLongMax.AddQuotesIfUnrecognised = False
        Me.ucrInputLongMax.IsMultiline = False
        Me.ucrInputLongMax.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLongMax, "ucrInputLongMax")
        Me.ucrInputLongMax.Name = "ucrInputLongMax"
        '
        'ucrInputLatMin
        '
        Me.ucrInputLatMin.AddQuotesIfUnrecognised = False
        Me.ucrInputLatMin.IsMultiline = False
        Me.ucrInputLatMin.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLatMin, "ucrInputLatMin")
        Me.ucrInputLatMin.Name = "ucrInputLatMin"
        '
        'ucrInputLongMin
        '
        Me.ucrInputLongMin.AddQuotesIfUnrecognised = False
        Me.ucrInputLongMin.IsMultiline = False
        Me.ucrInputLongMin.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLongMin, "ucrInputLongMin")
        Me.ucrInputLongMin.Name = "ucrInputLongMin"
        '
        'sdgMapOption
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblLat)
        Me.Controls.Add(Me.lblLongMin)
        Me.Controls.Add(Me.lblLatMax)
        Me.Controls.Add(Me.ucrInputLatMax)
        Me.Controls.Add(Me.lblLongMax)
        Me.Controls.Add(Me.ucrInputLongMax)
        Me.Controls.Add(Me.lblLatMin)
        Me.Controls.Add(Me.ucrInputLatMin)
        Me.Controls.Add(Me.lblLong)
        Me.Controls.Add(Me.ucrInputLongMin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMapOption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLat As Label
    Friend WithEvents lblLongMin As Label
    Friend WithEvents lblLatMax As Label
    Friend WithEvents ucrInputLatMax As ucrInputTextBox
    Friend WithEvents lblLongMax As Label
    Friend WithEvents ucrInputLongMax As ucrInputTextBox
    Friend WithEvents lblLatMin As Label
    Friend WithEvents ucrInputLatMin As ucrInputTextBox
    Friend WithEvents lblLong As Label
    Friend WithEvents ucrInputLongMin As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
End Class
