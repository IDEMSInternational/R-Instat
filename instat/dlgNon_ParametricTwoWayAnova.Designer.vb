<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgNon_ParametricTwoWayAnova
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
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.lblFirstFactor = New System.Windows.Forms.Label()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.ucrSelectorDataFrameAndVars = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSecondFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverDataColumn = New instat.ucrReceiverSingle()
        Me.ucrBaseNPTwoWayANOVA = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblDataColumn
        '
        Me.lblDataColumn.AutoSize = True
        Me.lblDataColumn.Location = New System.Drawing.Point(255, 25)
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Size = New System.Drawing.Size(67, 13)
        Me.lblDataColumn.TabIndex = 5
        Me.lblDataColumn.Tag = "Data_column"
        Me.lblDataColumn.Text = "Data column"
        '
        'lblFirstFactor
        '
        Me.lblFirstFactor.AutoSize = True
        Me.lblFirstFactor.Location = New System.Drawing.Point(255, 80)
        Me.lblFirstFactor.Name = "lblFirstFactor"
        Me.lblFirstFactor.Size = New System.Drawing.Size(56, 13)
        Me.lblFirstFactor.TabIndex = 6
        Me.lblFirstFactor.Tag = "First_factor"
        Me.lblFirstFactor.Text = "First factor"
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(255, 135)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(74, 13)
        Me.lblSecondFactor.TabIndex = 7
        Me.lblSecondFactor.Tag = "Second_factor"
        Me.lblSecondFactor.Text = "Second factor"
        '
        'ucrSelectorDataFrameAndVars
        '
        Me.ucrSelectorDataFrameAndVars.bShowHiddenColumns = False
        Me.ucrSelectorDataFrameAndVars.bUseCurrentFilter = False
        Me.ucrSelectorDataFrameAndVars.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDataFrameAndVars.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrameAndVars.Name = "ucrSelectorDataFrameAndVars"
        Me.ucrSelectorDataFrameAndVars.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDataFrameAndVars.TabIndex = 8
        '
        'ucrReceiverSecondFactor
        '
        Me.ucrReceiverSecondFactor.Location = New System.Drawing.Point(255, 150)
        Me.ucrReceiverSecondFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondFactor.Name = "ucrReceiverSecondFactor"
        Me.ucrReceiverSecondFactor.Selector = Nothing
        Me.ucrReceiverSecondFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondFactor.TabIndex = 4
        '
        'ucrReceiverFirstFactor
        '
        Me.ucrReceiverFirstFactor.Location = New System.Drawing.Point(255, 97)
        Me.ucrReceiverFirstFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstFactor.Name = "ucrReceiverFirstFactor"
        Me.ucrReceiverFirstFactor.Selector = Nothing
        Me.ucrReceiverFirstFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstFactor.TabIndex = 3
        '
        'ucrReceiverDataColumn
        '
        Me.ucrReceiverDataColumn.Location = New System.Drawing.Point(255, 44)
        Me.ucrReceiverDataColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataColumn.Name = "ucrReceiverDataColumn"
        Me.ucrReceiverDataColumn.Selector = Nothing
        Me.ucrReceiverDataColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDataColumn.TabIndex = 2
        '
        'ucrBaseNPTwoWayANOVA
        '
        Me.ucrBaseNPTwoWayANOVA.Location = New System.Drawing.Point(10, 208)
        Me.ucrBaseNPTwoWayANOVA.Name = "ucrBaseNPTwoWayANOVA"
        Me.ucrBaseNPTwoWayANOVA.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseNPTwoWayANOVA.TabIndex = 0
        '
        'dlgNon_ParametricTwoWayAnova
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 262)
        Me.Controls.Add(Me.ucrSelectorDataFrameAndVars)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFirstFactor)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.ucrReceiverSecondFactor)
        Me.Controls.Add(Me.ucrReceiverFirstFactor)
        Me.Controls.Add(Me.ucrReceiverDataColumn)
        Me.Controls.Add(Me.ucrBaseNPTwoWayANOVA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNon_ParametricTwoWayAnova"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Non-Parametric_Two_Way_ANOVA"
        Me.Text = "Non-Parametric Two Way ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseNPTwoWayANOVA As ucrButtons
    Friend WithEvents ucrReceiverDataColumn As ucrReceiverSingle
    Friend WithEvents ucrReceiverFirstFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondFactor As ucrReceiverSingle
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents lblFirstFactor As Label
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents ucrSelectorDataFrameAndVars As ucrSelectorByDataFrameAddRemove
End Class
