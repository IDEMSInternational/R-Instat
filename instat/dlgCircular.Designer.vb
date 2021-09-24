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
        Me.lblToCircular.Location = New System.Drawing.Point(259, 50)
        Me.lblToCircular.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblToCircular.Name = "lblToCircular"
        Me.lblToCircular.Size = New System.Drawing.Size(60, 13)
        Me.lblToCircular.TabIndex = 2
        Me.lblToCircular.Text = "To circular:"
        '
        'grpUnits
        '
        Me.grpUnits.Controls.Add(Me.rdoHours)
        Me.grpUnits.Controls.Add(Me.rdoDegrees)
        Me.grpUnits.Controls.Add(Me.rdoRadians)
        Me.grpUnits.Controls.Add(Me.ucrPnlUnits)
        Me.grpUnits.Location = New System.Drawing.Point(10, 212)
        Me.grpUnits.Name = "grpUnits"
        Me.grpUnits.Size = New System.Drawing.Size(105, 88)
        Me.grpUnits.TabIndex = 4
        Me.grpUnits.TabStop = False
        Me.grpUnits.Text = "Units"
        '
        'rdoHours
        '
        Me.rdoHours.AutoSize = True
        Me.rdoHours.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHours.Location = New System.Drawing.Point(10, 66)
        Me.rdoHours.Name = "rdoHours"
        Me.rdoHours.Size = New System.Drawing.Size(51, 17)
        Me.rdoHours.TabIndex = 3
        Me.rdoHours.TabStop = True
        Me.rdoHours.Text = "hours"
        Me.rdoHours.UseVisualStyleBackColor = True
        '
        'rdoDegrees
        '
        Me.rdoDegrees.AutoSize = True
        Me.rdoDegrees.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDegrees.Location = New System.Drawing.Point(10, 43)
        Me.rdoDegrees.Name = "rdoDegrees"
        Me.rdoDegrees.Size = New System.Drawing.Size(63, 17)
        Me.rdoDegrees.TabIndex = 2
        Me.rdoDegrees.TabStop = True
        Me.rdoDegrees.Text = "degrees"
        Me.rdoDegrees.UseVisualStyleBackColor = True
        '
        'rdoRadians
        '
        Me.rdoRadians.AutoSize = True
        Me.rdoRadians.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRadians.Location = New System.Drawing.Point(10, 21)
        Me.rdoRadians.Name = "rdoRadians"
        Me.rdoRadians.Size = New System.Drawing.Size(59, 17)
        Me.rdoRadians.TabIndex = 1
        Me.rdoRadians.TabStop = True
        Me.rdoRadians.Text = "radians"
        Me.rdoRadians.UseVisualStyleBackColor = True
        '
        'ucrPnlUnits
        '
        Me.ucrPnlUnits.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlUnits.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlUnits.Name = "ucrPnlUnits"
        Me.ucrPnlUnits.Size = New System.Drawing.Size(93, 67)
        Me.ucrPnlUnits.TabIndex = 0
        '
        'rdo2Pi
        '
        Me.rdo2Pi.AutoSize = True
        Me.rdo2Pi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdo2Pi.Location = New System.Drawing.Point(15, 62)
        Me.rdo2Pi.Name = "rdo2Pi"
        Me.rdo2Pi.Size = New System.Drawing.Size(39, 17)
        Me.rdo2Pi.TabIndex = 3
        Me.rdo2Pi.TabStop = True
        Me.rdo2Pi.Text = "2pi"
        Me.rdo2Pi.UseVisualStyleBackColor = True
        '
        'rdoPi
        '
        Me.rdoPi.AutoSize = True
        Me.rdoPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPi.Location = New System.Drawing.Point(15, 39)
        Me.rdoPi.Name = "rdoPi"
        Me.rdoPi.Size = New System.Drawing.Size(33, 17)
        Me.rdoPi.TabIndex = 2
        Me.rdoPi.TabStop = True
        Me.rdoPi.Text = "pi"
        Me.rdoPi.UseVisualStyleBackColor = True
        '
        'rdoAsis
        '
        Me.rdoAsis.AutoSize = True
        Me.rdoAsis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAsis.Location = New System.Drawing.Point(15, 17)
        Me.rdoAsis.Name = "rdoAsis"
        Me.rdoAsis.Size = New System.Drawing.Size(43, 17)
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
        Me.grpModulo.Location = New System.Drawing.Point(161, 212)
        Me.grpModulo.Name = "grpModulo"
        Me.grpModulo.Size = New System.Drawing.Size(105, 88)
        Me.grpModulo.TabIndex = 5
        Me.grpModulo.TabStop = False
        Me.grpModulo.Text = "Modulo"
        '
        'ucrPnlModulo
        '
        Me.ucrPnlModulo.Location = New System.Drawing.Point(10, 11)
        Me.ucrPnlModulo.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlModulo.Name = "ucrPnlModulo"
        Me.ucrPnlModulo.Size = New System.Drawing.Size(93, 67)
        Me.ucrPnlModulo.TabIndex = 3
        '
        'ucrSaveCircularColumn
        '
        Me.ucrSaveCircularColumn.Location = New System.Drawing.Point(10, 314)
        Me.ucrSaveCircularColumn.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrSaveCircularColumn.Name = "ucrSaveCircularColumn"
        Me.ucrSaveCircularColumn.Size = New System.Drawing.Size(255, 22)
        Me.ucrSaveCircularColumn.TabIndex = 6
        '
        'ucrReceiverCircular
        '
        Me.ucrReceiverCircular.frmParent = Me
        Me.ucrReceiverCircular.Location = New System.Drawing.Point(262, 66)
        Me.ucrReceiverCircular.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCircular.Name = "ucrReceiverCircular"
        Me.ucrReceiverCircular.Selector = Nothing
        Me.ucrReceiverCircular.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCircular.strNcFilePath = ""
        Me.ucrReceiverCircular.TabIndex = 3
        Me.ucrReceiverCircular.ucrSelector = Nothing
        '
        'ucrSelectorCircular
        '
        Me.ucrSelectorCircular.bDropUnusedFilterLevels = False
        Me.ucrSelectorCircular.bShowHiddenColumns = False
        Me.ucrSelectorCircular.bUseCurrentFilter = True
        Me.ucrSelectorCircular.Location = New System.Drawing.Point(10, 27)
        Me.ucrSelectorCircular.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCircular.Name = "ucrSelectorCircular"
        Me.ucrSelectorCircular.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCircular.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 341)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCircular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 399)
        Me.Controls.Add(Me.ucrSaveCircularColumn)
        Me.Controls.Add(Me.grpModulo)
        Me.Controls.Add(Me.grpUnits)
        Me.Controls.Add(Me.lblToCircular)
        Me.Controls.Add(Me.ucrReceiverCircular)
        Me.Controls.Add(Me.ucrSelectorCircular)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "histogram"
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
