﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgOneVarGraph
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
        Me.tbcOneVarGraph = New System.Windows.Forms.TabControl()
        Me.tbpTypes = New System.Windows.Forms.TabPage()
        Me.lblCategorical = New System.Windows.Forms.Label()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.ucrInputCategorical = New instat.ucrInputComboBox()
        Me.ucrInputNumeric = New instat.ucrInputComboBox()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.chkFreeScaleAxisforFacets = New System.Windows.Forms.CheckBox()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.nudNumberofColumns = New System.Windows.Forms.NumericUpDown()
        Me.chkSpecifyLayout = New System.Windows.Forms.CheckBox()
        Me.ucrButtonsOneVarGraph = New instat.ucrButtonsSubdialogue()
        Me.tbcOneVarGraph.SuspendLayout()
        Me.tbpTypes.SuspendLayout()
        Me.tbpDisplay.SuspendLayout()
        CType(Me.nudNumberofColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcOneVarGraph
        '
        Me.tbcOneVarGraph.AccessibleName = ""
        Me.tbcOneVarGraph.Controls.Add(Me.tbpTypes)
        Me.tbcOneVarGraph.Controls.Add(Me.tbpDisplay)
        Me.tbcOneVarGraph.Location = New System.Drawing.Point(1, 1)
        Me.tbcOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcOneVarGraph.Name = "tbcOneVarGraph"
        Me.tbcOneVarGraph.SelectedIndex = 0
        Me.tbcOneVarGraph.Size = New System.Drawing.Size(276, 172)
        Me.tbcOneVarGraph.TabIndex = 0
        '
        'tbpTypes
        '
        Me.tbpTypes.Controls.Add(Me.lblCategorical)
        Me.tbpTypes.Controls.Add(Me.lblNumeric)
        Me.tbpTypes.Controls.Add(Me.ucrInputCategorical)
        Me.tbpTypes.Controls.Add(Me.ucrInputNumeric)
        Me.tbpTypes.Location = New System.Drawing.Point(4, 22)
        Me.tbpTypes.Name = "tbpTypes"
        Me.tbpTypes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTypes.Size = New System.Drawing.Size(268, 146)
        Me.tbpTypes.TabIndex = 0
        Me.tbpTypes.Text = "Types"
        Me.tbpTypes.UseVisualStyleBackColor = True
        '
        'lblCategorical
        '
        Me.lblCategorical.AutoSize = True
        Me.lblCategorical.Location = New System.Drawing.Point(10, 50)
        Me.lblCategorical.Name = "lblCategorical"
        Me.lblCategorical.Size = New System.Drawing.Size(60, 13)
        Me.lblCategorical.TabIndex = 4
        Me.lblCategorical.Text = "Categorical"
        '
        'lblNumeric
        '
        Me.lblNumeric.AutoSize = True
        Me.lblNumeric.Location = New System.Drawing.Point(10, 8)
        Me.lblNumeric.Name = "lblNumeric"
        Me.lblNumeric.Size = New System.Drawing.Size(46, 13)
        Me.lblNumeric.TabIndex = 4
        Me.lblNumeric.Text = "Numeric"
        '
        'ucrInputCategorical
        '
        Me.ucrInputCategorical.IsReadOnly = False
        Me.ucrInputCategorical.Location = New System.Drawing.Point(76, 50)
        Me.ucrInputCategorical.Name = "ucrInputCategorical"
        Me.ucrInputCategorical.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCategorical.TabIndex = 3
        '
        'ucrInputNumeric
        '
        Me.ucrInputNumeric.IsReadOnly = False
        Me.ucrInputNumeric.Location = New System.Drawing.Point(76, 6)
        Me.ucrInputNumeric.Name = "ucrInputNumeric"
        Me.ucrInputNumeric.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNumeric.TabIndex = 3
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.chkFreeScaleAxisforFacets)
        Me.tbpDisplay.Controls.Add(Me.lblNumberofColumns)
        Me.tbpDisplay.Controls.Add(Me.nudNumberofColumns)
        Me.tbpDisplay.Controls.Add(Me.chkSpecifyLayout)
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDisplay.Size = New System.Drawing.Size(268, 146)
        Me.tbpDisplay.TabIndex = 1
        Me.tbpDisplay.Text = "Display"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'chkFreeScaleAxisforFacets
        '
        Me.chkFreeScaleAxisforFacets.AutoSize = True
        Me.chkFreeScaleAxisforFacets.Location = New System.Drawing.Point(10, 69)
        Me.chkFreeScaleAxisforFacets.Name = "chkFreeScaleAxisforFacets"
        Me.chkFreeScaleAxisforFacets.Size = New System.Drawing.Size(149, 17)
        Me.chkFreeScaleAxisforFacets.TabIndex = 5
        Me.chkFreeScaleAxisforFacets.Text = "Free Scale Axis for Facets"
        Me.chkFreeScaleAxisforFacets.UseVisualStyleBackColor = True
        '
        'lblNumberofColumns
        '
        Me.lblNumberofColumns.AutoSize = True
        Me.lblNumberofColumns.Location = New System.Drawing.Point(7, 37)
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        Me.lblNumberofColumns.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberofColumns.TabIndex = 4
        Me.lblNumberofColumns.Text = "Number of Columns"
        '
        'nudNumberofColumns
        '
        Me.nudNumberofColumns.Location = New System.Drawing.Point(127, 35)
        Me.nudNumberofColumns.Name = "nudNumberofColumns"
        Me.nudNumberofColumns.Size = New System.Drawing.Size(43, 20)
        Me.nudNumberofColumns.TabIndex = 3
        '
        'chkSpecifyLayout
        '
        Me.chkSpecifyLayout.AutoSize = True
        Me.chkSpecifyLayout.Location = New System.Drawing.Point(7, 6)
        Me.chkSpecifyLayout.Name = "chkSpecifyLayout"
        Me.chkSpecifyLayout.Size = New System.Drawing.Size(96, 17)
        Me.chkSpecifyLayout.TabIndex = 2
        Me.chkSpecifyLayout.Text = "Specify Layout"
        Me.chkSpecifyLayout.UseVisualStyleBackColor = True
        '
        'ucrButtonsOneVarGraph
        '
        Me.ucrButtonsOneVarGraph.Location = New System.Drawing.Point(63, 178)
        Me.ucrButtonsOneVarGraph.Name = "ucrButtonsOneVarGraph"
        Me.ucrButtonsOneVarGraph.Size = New System.Drawing.Size(145, 30)
        Me.ucrButtonsOneVarGraph.TabIndex = 1
        '
        'sdgOneVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 216)
        Me.Controls.Add(Me.ucrButtonsOneVarGraph)
        Me.Controls.Add(Me.tbcOneVarGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarGraph"
        Me.Text = "One Variable Graph Options"
        Me.tbcOneVarGraph.ResumeLayout(False)
        Me.tbpTypes.ResumeLayout(False)
        Me.tbpTypes.PerformLayout()
        Me.tbpDisplay.ResumeLayout(False)
        Me.tbpDisplay.PerformLayout()
        CType(Me.nudNumberofColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcOneVarGraph As TabControl
    Friend WithEvents tbpTypes As TabPage
    Friend WithEvents tbpDisplay As TabPage
    Friend WithEvents ucrButtonsOneVarGraph As ucrButtonsSubdialogue
    Friend WithEvents ucrInputNumeric As ucrInputComboBox
    Friend WithEvents lblNumeric As Label
    Friend WithEvents lblCategorical As Label
    Friend WithEvents ucrInputCategorical As ucrInputComboBox
    Friend WithEvents chkSpecifyLayout As CheckBox
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents nudNumberofColumns As NumericUpDown
    Friend WithEvents chkFreeScaleAxisforFacets As CheckBox
End Class
