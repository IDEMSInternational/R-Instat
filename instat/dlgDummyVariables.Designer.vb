<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDummyVariables
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
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblVariate = New System.Windows.Forms.Label()
        Me.ucrSelectorDummyVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrVariateReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpLevelOmitted = New System.Windows.Forms.GroupBox()
        Me.rdoLevelNumber = New System.Windows.Forms.RadioButton()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLevelOmitted = New instat.UcrPanel()
        Me.ucrChkWithXVariable = New instat.ucrCheck()
        Me.grpLevelOmitted.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(258, 39)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(90, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected Column:"
        '
        'lblVariate
        '
        Me.lblVariate.AutoSize = True
        Me.lblVariate.Location = New System.Drawing.Point(252, 252)
        Me.lblVariate.Name = "lblVariate"
        Me.lblVariate.Size = New System.Drawing.Size(43, 13)
        Me.lblVariate.TabIndex = 5
        Me.lblVariate.Tag = "Variate"
        Me.lblVariate.Text = "Variate:"
        '
        'ucrSelectorDummyVariable
        '
        Me.ucrSelectorDummyVariable.bShowHiddenColumns = False
        Me.ucrSelectorDummyVariable.bUseCurrentFilter = True
        Me.ucrSelectorDummyVariable.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDummyVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDummyVariable.Name = "ucrSelectorDummyVariable"
        Me.ucrSelectorDummyVariable.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDummyVariable.TabIndex = 0
        '
        'ucrVariateReceiver
        '
        Me.ucrVariateReceiver.frmParent = Me
        Me.ucrVariateReceiver.Location = New System.Drawing.Point(298, 248)
        Me.ucrVariateReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrVariateReceiver.Name = "ucrVariateReceiver"
        Me.ucrVariateReceiver.Selector = Nothing
        Me.ucrVariateReceiver.Size = New System.Drawing.Size(101, 20)
        Me.ucrVariateReceiver.TabIndex = 6
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(258, 56)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 279)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'grpLevelOmitted
        '
        Me.grpLevelOmitted.Controls.Add(Me.rdoLevelNumber)
        Me.grpLevelOmitted.Controls.Add(Me.rdoLast)
        Me.grpLevelOmitted.Controls.Add(Me.rdoFirst)
        Me.grpLevelOmitted.Controls.Add(Me.rdoNone)
        Me.grpLevelOmitted.Controls.Add(Me.ucrPnlLevelOmitted)
        Me.grpLevelOmitted.Location = New System.Drawing.Point(258, 86)
        Me.grpLevelOmitted.Name = "grpLevelOmitted"
        Me.grpLevelOmitted.Size = New System.Drawing.Size(102, 151)
        Me.grpLevelOmitted.TabIndex = 14
        Me.grpLevelOmitted.TabStop = False
        Me.grpLevelOmitted.Tag = "Level Omitted"
        Me.grpLevelOmitted.Text = "Level Omitted"
        '
        'rdoLevelNumber
        '
        Me.rdoLevelNumber.AutoSize = True
        Me.rdoLevelNumber.Location = New System.Drawing.Point(22, 114)
        Me.rdoLevelNumber.Name = "rdoLevelNumber"
        Me.rdoLevelNumber.Size = New System.Drawing.Size(51, 17)
        Me.rdoLevelNumber.TabIndex = 7
        Me.rdoLevelNumber.TabStop = True
        Me.rdoLevelNumber.Tag = "Level"
        Me.rdoLevelNumber.Text = "Level"
        Me.rdoLevelNumber.UseVisualStyleBackColor = True
        '
        'rdoLast
        '
        Me.rdoLast.AutoSize = True
        Me.rdoLast.Location = New System.Drawing.Point(22, 85)
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.Size = New System.Drawing.Size(45, 17)
        Me.rdoLast.TabIndex = 6
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.Text = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        Me.rdoFirst.AutoSize = True
        Me.rdoFirst.Location = New System.Drawing.Point(22, 56)
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.Size = New System.Drawing.Size(44, 17)
        Me.rdoFirst.TabIndex = 5
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.Text = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(22, 27)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 4
        Me.rdoNone.TabStop = True
        Me.rdoNone.Tag = "None"
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'ucrPnlLevelOmitted
        '
        Me.ucrPnlLevelOmitted.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlLevelOmitted.Name = "ucrPnlLevelOmitted"
        Me.ucrPnlLevelOmitted.Size = New System.Drawing.Size(85, 129)
        Me.ucrPnlLevelOmitted.TabIndex = 0
        '
        'ucrChkWithXVariable
        '
        Me.ucrChkWithXVariable.Checked = False
        Me.ucrChkWithXVariable.Location = New System.Drawing.Point(12, 248)
        Me.ucrChkWithXVariable.Name = "ucrChkWithXVariable"
        Me.ucrChkWithXVariable.Size = New System.Drawing.Size(128, 20)
        Me.ucrChkWithXVariable.TabIndex = 15
        '
        'dlgDummyVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 340)
        Me.Controls.Add(Me.ucrChkWithXVariable)
        Me.Controls.Add(Me.grpLevelOmitted)
        Me.Controls.Add(Me.ucrSelectorDummyVariable)
        Me.Controls.Add(Me.ucrVariateReceiver)
        Me.Controls.Add(Me.lblVariate)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDummyVariables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dummy_Variables"
        Me.Text = "Dummy Variables"
        Me.TopMost = True
        Me.grpLevelOmitted.ResumeLayout(False)
        Me.grpLevelOmitted.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelected As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents ucrSelectorDummyVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblVariate As Label
    Friend WithEvents ucrVariateReceiver As ucrReceiverSingle
    Friend WithEvents grpLevelOmitted As GroupBox
    Friend WithEvents rdoLevelNumber As RadioButton
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrPnlLevelOmitted As UcrPanel
    Friend WithEvents ucrChkWithXVariable As ucrCheck
End Class
