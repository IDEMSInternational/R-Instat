﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgPolynomials
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
        Me.lblDegree = New System.Windows.Forms.Label()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.rdoCentered = New System.Windows.Forms.RadioButton()
        Me.rdoOrthogonal = New System.Windows.Forms.RadioButton()
        Me.rdoSimple = New System.Windows.Forms.RadioButton()
        Me.ucrPnlType = New instat.UcrPanel()
        Me.ucrNudDegree = New instat.ucrNud()
        Me.ucrSavePoly = New instat.ucrSave()
        Me.ucrSelectorForPolynomial = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverPolynomial = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDegree
        '
        Me.lblDegree.AutoSize = True
        Me.lblDegree.Location = New System.Drawing.Point(258, 93)
        Me.lblDegree.Name = "lblDegree"
        Me.lblDegree.Size = New System.Drawing.Size(45, 13)
        Me.lblDegree.TabIndex = 3
        Me.lblDegree.Tag = "Degree"
        Me.lblDegree.Text = "Degree:"
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rdoCentered)
        Me.grpType.Controls.Add(Me.rdoOrthogonal)
        Me.grpType.Controls.Add(Me.rdoSimple)
        Me.grpType.Controls.Add(Me.ucrPnlType)
        Me.grpType.Location = New System.Drawing.Point(258, 119)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(120, 98)
        Me.grpType.TabIndex = 5
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type"
        '
        'rdoCentered
        '
        Me.rdoCentered.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoCentered.AutoSize = True
        Me.rdoCentered.Location = New System.Drawing.Point(13, 43)
        Me.rdoCentered.Name = "rdoCentered"
        Me.rdoCentered.Size = New System.Drawing.Size(68, 17)
        Me.rdoCentered.TabIndex = 2
        Me.rdoCentered.Tag = "Centered"
        Me.rdoCentered.Text = "Centered"
        Me.rdoCentered.UseVisualStyleBackColor = True
        '
        'rdoOrthogonal
        '
        Me.rdoOrthogonal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoOrthogonal.AutoSize = True
        Me.rdoOrthogonal.Location = New System.Drawing.Point(13, 67)
        Me.rdoOrthogonal.Name = "rdoOrthogonal"
        Me.rdoOrthogonal.Size = New System.Drawing.Size(77, 17)
        Me.rdoOrthogonal.TabIndex = 3
        Me.rdoOrthogonal.Tag = "Orthogonal"
        Me.rdoOrthogonal.Text = "Orthogonal"
        Me.rdoOrthogonal.UseVisualStyleBackColor = True
        '
        'rdoSimple
        '
        Me.rdoSimple.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoSimple.AutoSize = True
        Me.rdoSimple.Location = New System.Drawing.Point(13, 19)
        Me.rdoSimple.Name = "rdoSimple"
        Me.rdoSimple.Size = New System.Drawing.Size(56, 17)
        Me.rdoSimple.TabIndex = 1
        Me.rdoSimple.Tag = "Simple"
        Me.rdoSimple.Text = "Simple"
        Me.rdoSimple.UseVisualStyleBackColor = True
        '
        'ucrPnlType
        '
        Me.ucrPnlType.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlType.Name = "ucrPnlType"
        Me.ucrPnlType.Size = New System.Drawing.Size(108, 73)
        Me.ucrPnlType.TabIndex = 0
        '
        'ucrNudDegree
        '
        Me.ucrNudDegree.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDegree.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDegree.Location = New System.Drawing.Point(328, 90)
        Me.ucrNudDegree.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDegree.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDegree.Name = "ucrNudDegree"
        Me.ucrNudDegree.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDegree.TabIndex = 4
        Me.ucrNudDegree.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSavePoly
        '
        Me.ucrSavePoly.Location = New System.Drawing.Point(10, 222)
        Me.ucrSavePoly.Name = "ucrSavePoly"
        Me.ucrSavePoly.Size = New System.Drawing.Size(254, 24)
        Me.ucrSavePoly.TabIndex = 6
        '
        'ucrSelectorForPolynomial
        '
        Me.ucrSelectorForPolynomial.bShowHiddenColumns = False
        Me.ucrSelectorForPolynomial.bUseCurrentFilter = True
        Me.ucrSelectorForPolynomial.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForPolynomial.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForPolynomial.Name = "ucrSelectorForPolynomial"
        Me.ucrSelectorForPolynomial.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForPolynomial.TabIndex = 0
        '
        'ucrReceiverPolynomial
        '
        Me.ucrReceiverPolynomial.frmParent = Me
        Me.ucrReceiverPolynomial.Location = New System.Drawing.Point(258, 60)
        Me.ucrReceiverPolynomial.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPolynomial.Name = "ucrReceiverPolynomial"
        Me.ucrReceiverPolynomial.Selector = Nothing
        Me.ucrReceiverPolynomial.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPolynomial.TabIndex = 2
        Me.ucrReceiverPolynomial.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 249)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 7
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(258, 45)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'dlgPolynomials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 305)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.ucrNudDegree)
        Me.Controls.Add(Me.ucrSavePoly)
        Me.Controls.Add(Me.ucrSelectorForPolynomial)
        Me.Controls.Add(Me.ucrReceiverPolynomial)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblDegree)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPolynomials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Polynomials"
        Me.Text = "Polynomials"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDegree As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverPolynomial As ucrReceiverSingle
    Friend WithEvents ucrSelectorForPolynomial As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSavePoly As ucrSave
    Friend WithEvents ucrNudDegree As ucrNud
    Friend WithEvents grpType As GroupBox
    Friend WithEvents rdoCentered As RadioButton
    Friend WithEvents rdoOrthogonal As RadioButton
    Friend WithEvents rdoSimple As RadioButton
    Friend WithEvents ucrPnlType As UcrPanel
    Friend WithEvents lblSelectedVariable As Label
End Class
