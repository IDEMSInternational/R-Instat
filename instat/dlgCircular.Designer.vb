<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCircular
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
        Me.ucrToCircularSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrToCircularReceiver = New instat.ucrReceiverSingle()
        Me.lblToCircular = New System.Windows.Forms.Label()
        Me.grpUnit = New System.Windows.Forms.GroupBox()
        Me.grpModulo = New System.Windows.Forms.GroupBox()
        Me.rdoRadians = New System.Windows.Forms.RadioButton()
        Me.rdoDegrees = New System.Windows.Forms.RadioButton()
        Me.rdoHours = New System.Windows.Forms.RadioButton()
        Me.rdo2Pi = New System.Windows.Forms.RadioButton()
        Me.rdoPi = New System.Windows.Forms.RadioButton()
        Me.rdoAsis = New System.Windows.Forms.RadioButton()
        Me.grpUnit.SuspendLayout()
        Me.grpModulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(25, 373)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 0
        '
        'ucrToCircularSelector
        '
        Me.ucrToCircularSelector.bDropUnusedFilterLevels = False
        Me.ucrToCircularSelector.bShowHiddenColumns = False
        Me.ucrToCircularSelector.bUseCurrentFilter = True
        Me.ucrToCircularSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrToCircularSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrToCircularSelector.Name = "ucrToCircularSelector"
        Me.ucrToCircularSelector.Size = New System.Drawing.Size(280, 226)
        Me.ucrToCircularSelector.TabIndex = 1
        '
        'ucrToCircularReceiver
        '
        Me.ucrToCircularReceiver.frmParent = Me
        Me.ucrToCircularReceiver.Location = New System.Drawing.Point(335, 47)
        Me.ucrToCircularReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrToCircularReceiver.Name = "ucrToCircularReceiver"
        Me.ucrToCircularReceiver.Selector = Nothing
        Me.ucrToCircularReceiver.Size = New System.Drawing.Size(160, 25)
        Me.ucrToCircularReceiver.strNcFilePath = ""
        Me.ucrToCircularReceiver.TabIndex = 2
        Me.ucrToCircularReceiver.ucrSelector = Nothing
        '
        'lblToCircular
        '
        Me.lblToCircular.AutoSize = True
        Me.lblToCircular.Location = New System.Drawing.Point(382, 19)
        Me.lblToCircular.Name = "lblToCircular"
        Me.lblToCircular.Size = New System.Drawing.Size(75, 17)
        Me.lblToCircular.TabIndex = 3
        Me.lblToCircular.Text = "To circular"
        '
        'grpUnit
        '
        Me.grpUnit.Controls.Add(Me.rdoHours)
        Me.grpUnit.Controls.Add(Me.rdoDegrees)
        Me.grpUnit.Controls.Add(Me.rdoRadians)
        Me.grpUnit.Location = New System.Drawing.Point(12, 254)
        Me.grpUnit.Name = "grpUnit"
        Me.grpUnit.Size = New System.Drawing.Size(160, 112)
        Me.grpUnit.TabIndex = 4
        Me.grpUnit.TabStop = False
        Me.grpUnit.Text = "Units"
        '
        'grpModulo
        '
        Me.grpModulo.Controls.Add(Me.rdoAsis)
        Me.grpModulo.Controls.Add(Me.rdoPi)
        Me.grpModulo.Controls.Add(Me.rdo2Pi)
        Me.grpModulo.Location = New System.Drawing.Point(335, 252)
        Me.grpModulo.Name = "grpModulo"
        Me.grpModulo.Size = New System.Drawing.Size(160, 112)
        Me.grpModulo.TabIndex = 5
        Me.grpModulo.TabStop = False
        Me.grpModulo.Text = "Modulo"
        '
        'rdoRadians
        '
        Me.rdoRadians.AutoSize = True
        Me.rdoRadians.Location = New System.Drawing.Point(6, 21)
        Me.rdoRadians.Name = "rdoRadians"
        Me.rdoRadians.Size = New System.Drawing.Size(76, 21)
        Me.rdoRadians.TabIndex = 0
        Me.rdoRadians.TabStop = True
        Me.rdoRadians.Text = "radians"
        Me.rdoRadians.UseVisualStyleBackColor = True
        '
        'rdoDegrees
        '
        Me.rdoDegrees.AutoSize = True
        Me.rdoDegrees.Location = New System.Drawing.Point(6, 52)
        Me.rdoDegrees.Name = "rdoDegrees"
        Me.rdoDegrees.Size = New System.Drawing.Size(81, 21)
        Me.rdoDegrees.TabIndex = 1
        Me.rdoDegrees.TabStop = True
        Me.rdoDegrees.Text = "degrees"
        Me.rdoDegrees.UseVisualStyleBackColor = True
        '
        'rdoHours
        '
        Me.rdoHours.AutoSize = True
        Me.rdoHours.Location = New System.Drawing.Point(6, 85)
        Me.rdoHours.Name = "rdoHours"
        Me.rdoHours.Size = New System.Drawing.Size(65, 21)
        Me.rdoHours.TabIndex = 2
        Me.rdoHours.TabStop = True
        Me.rdoHours.Text = "hours"
        Me.rdoHours.UseVisualStyleBackColor = True
        '
        'rdo2Pi
        '
        Me.rdo2Pi.AutoSize = True
        Me.rdo2Pi.Location = New System.Drawing.Point(6, 21)
        Me.rdo2Pi.Name = "rdo2Pi"
        Me.rdo2Pi.Size = New System.Drawing.Size(48, 21)
        Me.rdo2Pi.TabIndex = 1
        Me.rdo2Pi.TabStop = True
        Me.rdo2Pi.Text = "2pi"
        Me.rdo2Pi.UseVisualStyleBackColor = True
        '
        'rdoPi
        '
        Me.rdoPi.AutoSize = True
        Me.rdoPi.Location = New System.Drawing.Point(6, 52)
        Me.rdoPi.Name = "rdoPi"
        Me.rdoPi.Size = New System.Drawing.Size(40, 21)
        Me.rdoPi.TabIndex = 2
        Me.rdoPi.TabStop = True
        Me.rdoPi.Text = "pi"
        Me.rdoPi.UseVisualStyleBackColor = True
        '
        'rdoAsis
        '
        Me.rdoAsis.AutoSize = True
        Me.rdoAsis.Location = New System.Drawing.Point(6, 79)
        Me.rdoAsis.Name = "rdoAsis"
        Me.rdoAsis.Size = New System.Drawing.Size(54, 21)
        Me.rdoAsis.TabIndex = 3
        Me.rdoAsis.TabStop = True
        Me.rdoAsis.Text = "asis"
        Me.rdoAsis.UseVisualStyleBackColor = True
        '
        'dlgCircular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 450)
        Me.Controls.Add(Me.grpModulo)
        Me.Controls.Add(Me.grpUnit)
        Me.Controls.Add(Me.lblToCircular)
        Me.Controls.Add(Me.ucrToCircularReceiver)
        Me.Controls.Add(Me.ucrToCircularSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circular"
        Me.grpUnit.ResumeLayout(False)
        Me.grpUnit.PerformLayout()
        Me.grpModulo.ResumeLayout(False)
        Me.grpModulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrToCircularSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrToCircularReceiver As ucrReceiverSingle
    Friend WithEvents lblToCircular As Label
    Friend WithEvents grpModulo As GroupBox
    Friend WithEvents rdoAsis As RadioButton
    Friend WithEvents rdoPi As RadioButton
    Friend WithEvents rdo2Pi As RadioButton
    Friend WithEvents grpUnit As GroupBox
    Friend WithEvents rdoHours As RadioButton
    Friend WithEvents rdoDegrees As RadioButton
    Friend WithEvents rdoRadians As RadioButton
End Class
