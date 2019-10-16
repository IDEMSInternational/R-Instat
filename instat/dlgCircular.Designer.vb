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
        Me.lblToCircular = New System.Windows.Forms.Label()
        Me.grpUnits = New System.Windows.Forms.GroupBox()
        Me.rdoHours = New System.Windows.Forms.RadioButton()
        Me.rdoDegrees = New System.Windows.Forms.RadioButton()
        Me.rdoRadians = New System.Windows.Forms.RadioButton()
        Me.ucrPnlUnits = New instat.UcrPanel()
        Me.rdo2Pi = New System.Windows.Forms.RadioButton()
        Me.rdoPi = New System.Windows.Forms.RadioButton()
        Me.rdoAsis = New System.Windows.Forms.RadioButton()
        Me.grpModulo = New System.Windows.Forms.GroupBox()
        Me.ucrPnlModulo = New instat.UcrPanel()
        Me.ucrSaveCircularColumn = New instat.ucrSave()
        Me.ucrReceiverCircular = New instat.ucrReceiverSingle()
        Me.ucrSelectorCircular = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpUnits.SuspendLayout()
        Me.grpModulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblToCircular
        '
        Me.lblToCircular.AutoSize = True
        Me.lblToCircular.Location = New System.Drawing.Point(345, 62)
        Me.lblToCircular.Name = "lblToCircular"
        Me.lblToCircular.Size = New System.Drawing.Size(79, 17)
        Me.lblToCircular.TabIndex = 2
        Me.lblToCircular.Text = "To circular:"
        '
        'grpUnits
        '
        Me.grpUnits.Controls.Add(Me.rdoHours)
        Me.grpUnits.Controls.Add(Me.rdoDegrees)
        Me.grpUnits.Controls.Add(Me.rdoRadians)
        Me.grpUnits.Controls.Add(Me.ucrPnlUnits)
        Me.grpUnits.Location = New System.Drawing.Point(13, 261)
        Me.grpUnits.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpUnits.Name = "grpUnits"
        Me.grpUnits.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpUnits.Size = New System.Drawing.Size(140, 108)
        Me.grpUnits.TabIndex = 4
        Me.grpUnits.TabStop = False
        Me.grpUnits.Text = "Units"
        '
        'rdoHours
        '
        Me.rdoHours.AutoSize = True
        Me.rdoHours.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHours.Location = New System.Drawing.Point(13, 81)
        Me.rdoHours.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoHours.Name = "rdoHours"
        Me.rdoHours.Size = New System.Drawing.Size(65, 21)
        Me.rdoHours.TabIndex = 3
        Me.rdoHours.TabStop = True
        Me.rdoHours.Text = "hours"
        Me.rdoHours.UseVisualStyleBackColor = True
        '
        'rdoDegrees
        '
        Me.rdoDegrees.AutoSize = True
        Me.rdoDegrees.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDegrees.Location = New System.Drawing.Point(13, 53)
        Me.rdoDegrees.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDegrees.Name = "rdoDegrees"
        Me.rdoDegrees.Size = New System.Drawing.Size(81, 21)
        Me.rdoDegrees.TabIndex = 2
        Me.rdoDegrees.TabStop = True
        Me.rdoDegrees.Text = "degrees"
        Me.rdoDegrees.UseVisualStyleBackColor = True
        '
        'rdoRadians
        '
        Me.rdoRadians.AutoSize = True
        Me.rdoRadians.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRadians.Location = New System.Drawing.Point(13, 26)
        Me.rdoRadians.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoRadians.Name = "rdoRadians"
        Me.rdoRadians.Size = New System.Drawing.Size(76, 21)
        Me.rdoRadians.TabIndex = 1
        Me.rdoRadians.TabStop = True
        Me.rdoRadians.Text = "radians"
        Me.rdoRadians.UseVisualStyleBackColor = True
        '
        'ucrPnlUnits
        '
        Me.ucrPnlUnits.Location = New System.Drawing.Point(4, 20)
        Me.ucrPnlUnits.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlUnits.Name = "ucrPnlUnits"
        Me.ucrPnlUnits.Size = New System.Drawing.Size(124, 82)
        Me.ucrPnlUnits.TabIndex = 0
        '
        'rdo2Pi
        '
        Me.rdo2Pi.AutoSize = True
        Me.rdo2Pi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdo2Pi.Location = New System.Drawing.Point(20, 76)
        Me.rdo2Pi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdo2Pi.Name = "rdo2Pi"
        Me.rdo2Pi.Size = New System.Drawing.Size(48, 21)
        Me.rdo2Pi.TabIndex = 3
        Me.rdo2Pi.TabStop = True
        Me.rdo2Pi.Text = "2pi"
        Me.rdo2Pi.UseVisualStyleBackColor = True
        '
        'rdoPi
        '
        Me.rdoPi.AutoSize = True
        Me.rdoPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPi.Location = New System.Drawing.Point(20, 48)
        Me.rdoPi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.rdoAsis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAsis.Location = New System.Drawing.Point(20, 21)
        Me.rdoAsis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoAsis.Name = "rdoAsis"
        Me.rdoAsis.Size = New System.Drawing.Size(54, 21)
        Me.rdoAsis.TabIndex = 1
        Me.rdoAsis.TabStop = True
        Me.rdoAsis.Text = "asis"
        Me.rdoAsis.UseVisualStyleBackColor = True
        '
        'grpModulo
        '
        Me.grpModulo.Controls.Add(Me.rdo2Pi)
        Me.grpModulo.Controls.Add(Me.rdoPi)
        Me.grpModulo.Controls.Add(Me.rdoAsis)
        Me.grpModulo.Controls.Add(Me.ucrPnlModulo)
        Me.grpModulo.Location = New System.Drawing.Point(215, 261)
        Me.grpModulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpModulo.Name = "grpModulo"
        Me.grpModulo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpModulo.Size = New System.Drawing.Size(140, 108)
        Me.grpModulo.TabIndex = 5
        Me.grpModulo.TabStop = False
        Me.grpModulo.Text = "Modulo"
        '
        'ucrPnlModulo
        '
        Me.ucrPnlModulo.Location = New System.Drawing.Point(13, 14)
        Me.ucrPnlModulo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlModulo.Name = "ucrPnlModulo"
        Me.ucrPnlModulo.Size = New System.Drawing.Size(124, 82)
        Me.ucrPnlModulo.TabIndex = 3
        '
        'ucrSaveCircularColumn
        '
        Me.ucrSaveCircularColumn.Location = New System.Drawing.Point(13, 386)
        Me.ucrSaveCircularColumn.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrSaveCircularColumn.Name = "ucrSaveCircularColumn"
        Me.ucrSaveCircularColumn.Size = New System.Drawing.Size(324, 30)
        Me.ucrSaveCircularColumn.TabIndex = 6
        '
        'ucrReceiverCircular
        '
        Me.ucrReceiverCircular.frmParent = Me
        Me.ucrReceiverCircular.Location = New System.Drawing.Point(349, 81)
        Me.ucrReceiverCircular.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCircular.Name = "ucrReceiverCircular"
        Me.ucrReceiverCircular.Selector = Nothing
        Me.ucrReceiverCircular.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverCircular.strNcFilePath = ""
        Me.ucrReceiverCircular.TabIndex = 3
        Me.ucrReceiverCircular.ucrSelector = Nothing
        '
        'ucrSelectorCircular
        '
        Me.ucrSelectorCircular.bDropUnusedFilterLevels = False
        Me.ucrSelectorCircular.bShowHiddenColumns = False
        Me.ucrSelectorCircular.bUseCurrentFilter = True
        Me.ucrSelectorCircular.Location = New System.Drawing.Point(13, 33)
        Me.ucrSelectorCircular.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCircular.Name = "ucrSelectorCircular"
        Me.ucrSelectorCircular.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorCircular.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 420)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(537, 64)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCircular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 491)
        Me.Controls.Add(Me.ucrSaveCircularColumn)
        Me.Controls.Add(Me.grpModulo)
        Me.Controls.Add(Me.grpUnits)
        Me.Controls.Add(Me.lblToCircular)
        Me.Controls.Add(Me.ucrReceiverCircular)
        Me.Controls.Add(Me.ucrSelectorCircular)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert to Circular"
        Me.grpUnits.ResumeLayout(False)
        Me.grpUnits.PerformLayout()
        Me.grpModulo.ResumeLayout(False)
        Me.grpModulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorCircular As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverCircular As ucrReceiverSingle
    Friend WithEvents lblToCircular As Label
    Friend WithEvents grpUnits As GroupBox
    Friend WithEvents rdoHours As RadioButton
    Friend WithEvents rdoDegrees As RadioButton
    Friend WithEvents rdoRadians As RadioButton
    Friend WithEvents ucrPnlUnits As UcrPanel
    Friend WithEvents rdo2Pi As RadioButton
    Friend WithEvents rdoPi As RadioButton
    Friend WithEvents rdoAsis As RadioButton
    Friend WithEvents ucrPnlModulo As UcrPanel
    Friend WithEvents grpModulo As GroupBox
    Friend WithEvents ucrSaveCircularColumn As ucrSave
End Class
