﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgYearRaincount
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
        Me.ucrBase = New instat.ucrButtons()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblVariableLabel = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblXLabel = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.lblLineType = New System.Windows.Forms.Label()
        Me.lblPlotCharacter = New System.Windows.Forms.Label()
        Me.lblYLimits = New System.Windows.Forms.Label()
        Me.lblYGrid = New System.Windows.Forms.Label()
        Me.lblLineWidth2 = New System.Windows.Forms.Label()
        Me.lblLineWidth1 = New System.Windows.Forms.Label()
        Me.nudPlotCharacter = New System.Windows.Forms.NumericUpDown()
        Me.nudLineWidth2 = New System.Windows.Forms.NumericUpDown()
        Me.nudLineWidth1 = New System.Windows.Forms.NumericUpDown()
        Me.nudLineType = New System.Windows.Forms.NumericUpDown()
        Me.chkPlotWindow = New System.Windows.Forms.CheckBox()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.chkGrid = New System.Windows.Forms.CheckBox()
        Me.txtXLabel = New System.Windows.Forms.TextBox()
        Me.txtYLabel = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtVariableLabel = New System.Windows.Forms.TextBox()
        Me.txtVariable = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.nudYLimits = New System.Windows.Forms.NumericUpDown()
        Me.nudYGrid = New System.Windows.Forms.NumericUpDown()
        Me.txtColour1 = New System.Windows.Forms.TextBox()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblColour2 = New System.Windows.Forms.Label()
        Me.txtColour2 = New System.Windows.Forms.TextBox()
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLineWidth2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLineWidth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLineType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYLimits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(82, 303)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 51)
        Me.ucrBase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Label3"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(12, 61)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(39, 13)
        Me.lblVariable.TabIndex = 5
        Me.lblVariable.Text = "Label5"
        '
        'lblVariableLabel
        '
        Me.lblVariableLabel.AutoSize = True
        Me.lblVariableLabel.Location = New System.Drawing.Point(12, 87)
        Me.lblVariableLabel.Name = "lblVariableLabel"
        Me.lblVariableLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblVariableLabel.TabIndex = 6
        Me.lblVariableLabel.Tag = "Variable_Label"
        Me.lblVariableLabel.Text = "Label6"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(12, 110)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(39, 13)
        Me.lblType.TabIndex = 7
        Me.lblType.Tag = "Type"
        Me.lblType.Text = "Label7"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(12, 136)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblXLabel.TabIndex = 8
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "Label8"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(335, 146)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblYLabel.TabIndex = 9
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Label9"
        '
        'lblLineType
        '
        Me.lblLineType.AutoSize = True
        Me.lblLineType.Location = New System.Drawing.Point(264, 204)
        Me.lblLineType.Name = "lblLineType"
        Me.lblLineType.Size = New System.Drawing.Size(45, 13)
        Me.lblLineType.TabIndex = 10
        Me.lblLineType.Tag = "Line_Type"
        Me.lblLineType.Text = "Label10"
        '
        'lblPlotCharacter
        '
        Me.lblPlotCharacter.AutoSize = True
        Me.lblPlotCharacter.Location = New System.Drawing.Point(12, 203)
        Me.lblPlotCharacter.Name = "lblPlotCharacter"
        Me.lblPlotCharacter.Size = New System.Drawing.Size(45, 13)
        Me.lblPlotCharacter.TabIndex = 11
        Me.lblPlotCharacter.Text = "Label11"
        '
        'lblYLimits
        '
        Me.lblYLimits.AutoSize = True
        Me.lblYLimits.Location = New System.Drawing.Point(12, 227)
        Me.lblYLimits.Name = "lblYLimits"
        Me.lblYLimits.Size = New System.Drawing.Size(45, 13)
        Me.lblYLimits.TabIndex = 12
        Me.lblYLimits.Tag = "YLimits"
        Me.lblYLimits.Text = "Label12"
        '
        'lblYGrid
        '
        Me.lblYGrid.AutoSize = True
        Me.lblYGrid.Location = New System.Drawing.Point(12, 253)
        Me.lblYGrid.Name = "lblYGrid"
        Me.lblYGrid.Size = New System.Drawing.Size(45, 13)
        Me.lblYGrid.TabIndex = 13
        Me.lblYGrid.Tag = "YGrid"
        Me.lblYGrid.Text = "Label13"
        '
        'lblLineWidth2
        '
        Me.lblLineWidth2.AutoSize = True
        Me.lblLineWidth2.Location = New System.Drawing.Point(264, 229)
        Me.lblLineWidth2.Name = "lblLineWidth2"
        Me.lblLineWidth2.Size = New System.Drawing.Size(45, 13)
        Me.lblLineWidth2.TabIndex = 14
        Me.lblLineWidth2.Tag = "Line_Width2"
        Me.lblLineWidth2.Text = "Label14"
        '
        'lblLineWidth1
        '
        Me.lblLineWidth1.AutoSize = True
        Me.lblLineWidth1.Location = New System.Drawing.Point(264, 251)
        Me.lblLineWidth1.Name = "lblLineWidth1"
        Me.lblLineWidth1.Size = New System.Drawing.Size(45, 13)
        Me.lblLineWidth1.TabIndex = 15
        Me.lblLineWidth1.Tag = "Line_Width1"
        Me.lblLineWidth1.Text = "Label15"
        '
        'nudPlotCharacter
        '
        Me.nudPlotCharacter.Location = New System.Drawing.Point(125, 201)
        Me.nudPlotCharacter.Name = "nudPlotCharacter"
        Me.nudPlotCharacter.Size = New System.Drawing.Size(52, 20)
        Me.nudPlotCharacter.TabIndex = 18
        '
        'nudLineWidth2
        '
        Me.nudLineWidth2.Location = New System.Drawing.Point(356, 225)
        Me.nudLineWidth2.Name = "nudLineWidth2"
        Me.nudLineWidth2.Size = New System.Drawing.Size(52, 20)
        Me.nudLineWidth2.TabIndex = 19
        '
        'nudLineWidth1
        '
        Me.nudLineWidth1.Location = New System.Drawing.Point(356, 248)
        Me.nudLineWidth1.Name = "nudLineWidth1"
        Me.nudLineWidth1.Size = New System.Drawing.Size(52, 20)
        Me.nudLineWidth1.TabIndex = 20
        '
        'nudLineType
        '
        Me.nudLineType.Location = New System.Drawing.Point(356, 201)
        Me.nudLineType.Name = "nudLineType"
        Me.nudLineType.Size = New System.Drawing.Size(52, 20)
        Me.nudLineType.TabIndex = 21
        '
        'chkPlotWindow
        '
        Me.chkPlotWindow.AutoSize = True
        Me.chkPlotWindow.Location = New System.Drawing.Point(356, 90)
        Me.chkPlotWindow.Name = "chkPlotWindow"
        Me.chkPlotWindow.Size = New System.Drawing.Size(81, 17)
        Me.chkPlotWindow.TabIndex = 23
        Me.chkPlotWindow.Tag = "Plot_Window"
        Me.chkPlotWindow.Text = "CheckBox2"
        Me.chkPlotWindow.UseVisualStyleBackColor = True
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(356, 64)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 24
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox3"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'chkGrid
        '
        Me.chkGrid.AutoSize = True
        Me.chkGrid.Location = New System.Drawing.Point(461, 204)
        Me.chkGrid.Name = "chkGrid"
        Me.chkGrid.Size = New System.Drawing.Size(81, 17)
        Me.chkGrid.TabIndex = 25
        Me.chkGrid.Tag = "Grid"
        Me.chkGrid.Text = "CheckBox4"
        Me.chkGrid.UseVisualStyleBackColor = True
        '
        'txtXLabel
        '
        Me.txtXLabel.Location = New System.Drawing.Point(125, 136)
        Me.txtXLabel.Name = "txtXLabel"
        Me.txtXLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtXLabel.TabIndex = 26
        '
        'txtYLabel
        '
        Me.txtYLabel.Location = New System.Drawing.Point(427, 139)
        Me.txtYLabel.Name = "txtYLabel"
        Me.txtYLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtYLabel.TabIndex = 27
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(125, 110)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(100, 20)
        Me.txtType.TabIndex = 28
        '
        'txtVariableLabel
        '
        Me.txtVariableLabel.Location = New System.Drawing.Point(125, 87)
        Me.txtVariableLabel.Name = "txtVariableLabel"
        Me.txtVariableLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtVariableLabel.TabIndex = 29
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(125, 61)
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(100, 20)
        Me.txtVariable.TabIndex = 30
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(125, 35)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(215, 20)
        Me.txtTitle.TabIndex = 31
        '
        'nudYLimits
        '
        Me.nudYLimits.Location = New System.Drawing.Point(125, 220)
        Me.nudYLimits.Name = "nudYLimits"
        Me.nudYLimits.Size = New System.Drawing.Size(52, 20)
        Me.nudYLimits.TabIndex = 17
        '
        'nudYGrid
        '
        Me.nudYGrid.Location = New System.Drawing.Point(125, 246)
        Me.nudYGrid.Name = "nudYGrid"
        Me.nudYGrid.Size = New System.Drawing.Size(52, 20)
        Me.nudYGrid.TabIndex = 18
        '
        'txtColour1
        '
        Me.txtColour1.Location = New System.Drawing.Point(125, 162)
        Me.txtColour1.Name = "txtColour1"
        Me.txtColour1.Size = New System.Drawing.Size(100, 20)
        Me.txtColour1.TabIndex = 32
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(12, 165)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(39, 13)
        Me.lblColour.TabIndex = 33
        Me.lblColour.Tag = "Colour1"
        Me.lblColour.Text = "Label2"
        '
        'lblColour2
        '
        Me.lblColour2.AutoSize = True
        Me.lblColour2.Location = New System.Drawing.Point(335, 169)
        Me.lblColour2.Name = "lblColour2"
        Me.lblColour2.Size = New System.Drawing.Size(39, 13)
        Me.lblColour2.TabIndex = 34
        Me.lblColour2.Tag = "Colour2"
        Me.lblColour2.Text = "Label2"
        '
        'txtColour2
        '
        Me.txtColour2.Location = New System.Drawing.Point(427, 169)
        Me.txtColour2.Name = "txtColour2"
        Me.txtColour2.Size = New System.Drawing.Size(100, 20)
        Me.txtColour2.TabIndex = 35
        '
        'dlgYearRaincount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 366)
        Me.Controls.Add(Me.txtColour2)
        Me.Controls.Add(Me.lblColour2)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.txtColour1)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtVariable)
        Me.Controls.Add(Me.txtVariableLabel)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtYLabel)
        Me.Controls.Add(Me.txtXLabel)
        Me.Controls.Add(Me.chkGrid)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkPlotWindow)
        Me.Controls.Add(Me.nudLineType)
        Me.Controls.Add(Me.nudLineWidth1)
        Me.Controls.Add(Me.nudLineWidth2)
        Me.Controls.Add(Me.nudYGrid)
        Me.Controls.Add(Me.nudYLimits)
        Me.Controls.Add(Me.nudPlotCharacter)
        Me.Controls.Add(Me.lblLineWidth1)
        Me.Controls.Add(Me.lblLineWidth2)
        Me.Controls.Add(Me.lblYGrid)
        Me.Controls.Add(Me.lblYLimits)
        Me.Controls.Add(Me.lblPlotCharacter)
        Me.Controls.Add(Me.lblLineType)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblVariableLabel)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgYearRaincount"
        Me.Text = "Plot Yearly Rain Count"
        CType(Me.nudPlotCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLineWidth2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLineWidth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLineType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYLimits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblVariableLabel As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblXLabel As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents lblLineType As Label
    Friend WithEvents lblPlotCharacter As Label
    Friend WithEvents lblYLimits As Label
    Friend WithEvents lblYGrid As Label
    Friend WithEvents lblLineWidth2 As Label
    Friend WithEvents lblLineWidth1 As Label
    Friend WithEvents nudPlotCharacter As NumericUpDown
    Friend WithEvents nudLineWidth2 As NumericUpDown
    Friend WithEvents nudLineWidth1 As NumericUpDown
    Friend WithEvents nudLineType As NumericUpDown
    Friend WithEvents chkPlotWindow As CheckBox
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents chkGrid As CheckBox
    Friend WithEvents txtXLabel As TextBox
    Friend WithEvents txtYLabel As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtVariableLabel As TextBox
    Friend WithEvents txtVariable As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents nudYLimits As NumericUpDown
    Friend WithEvents nudYGrid As NumericUpDown
    Friend WithEvents txtColour1 As TextBox
    Friend WithEvents lblColour As Label
    Friend WithEvents lblColour2 As Label
    Friend WithEvents txtColour2 As TextBox
End Class


