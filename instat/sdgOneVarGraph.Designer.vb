<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.tbpNumeric = New System.Windows.Forms.TabPage()
        Me.rdohistogram = New System.Windows.Forms.RadioButton()
        Me.rdodotplot = New System.Windows.Forms.RadioButton()
        Me.rdoBoxplot = New System.Windows.Forms.RadioButton()
        Me.tbpFactor = New System.Windows.Forms.TabPage()
        Me.rdoPieChart = New System.Windows.Forms.RadioButton()
        Me.rdoBarChart = New System.Windows.Forms.RadioButton()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.rdoFacets = New System.Windows.Forms.RadioButton()
        Me.rdoSingleGraph = New System.Windows.Forms.RadioButton()
        Me.rdoCombineGraphs = New System.Windows.Forms.RadioButton()
        Me.UcrButtonsOneVarGraph = New instat.ucrButtonsSubdialogue()
        Me.tbcOneVarGraph.SuspendLayout()
        Me.tbpNumeric.SuspendLayout()
        Me.tbpFactor.SuspendLayout()
        Me.tbpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcOneVarGraph
        '
        Me.tbcOneVarGraph.AccessibleName = ""
        Me.tbcOneVarGraph.Controls.Add(Me.tbpNumeric)
        Me.tbcOneVarGraph.Controls.Add(Me.tbpFactor)
        Me.tbcOneVarGraph.Controls.Add(Me.tbpDisplay)
        Me.tbcOneVarGraph.Location = New System.Drawing.Point(1, 1)
        Me.tbcOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcOneVarGraph.Name = "tbcOneVarGraph"
        Me.tbcOneVarGraph.SelectedIndex = 0
        Me.tbcOneVarGraph.Size = New System.Drawing.Size(237, 131)
        Me.tbcOneVarGraph.TabIndex = 0
        '
        'tbpNumeric
        '
        Me.tbpNumeric.Controls.Add(Me.rdohistogram)
        Me.tbpNumeric.Controls.Add(Me.rdodotplot)
        Me.tbpNumeric.Controls.Add(Me.rdoBoxplot)
        Me.tbpNumeric.Location = New System.Drawing.Point(4, 22)
        Me.tbpNumeric.Name = "tbpNumeric"
        Me.tbpNumeric.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpNumeric.Size = New System.Drawing.Size(229, 105)
        Me.tbpNumeric.TabIndex = 0
        Me.tbpNumeric.Text = "Numeric"
        Me.tbpNumeric.UseVisualStyleBackColor = True
        '
        'rdohistogram
        '
        Me.rdohistogram.AutoSize = True
        Me.rdohistogram.Location = New System.Drawing.Point(8, 59)
        Me.rdohistogram.Name = "rdohistogram"
        Me.rdohistogram.Size = New System.Drawing.Size(72, 17)
        Me.rdohistogram.TabIndex = 2
        Me.rdohistogram.TabStop = True
        Me.rdohistogram.Text = "Histogram"
        Me.rdohistogram.UseVisualStyleBackColor = True
        '
        'rdodotplot
        '
        Me.rdodotplot.AutoSize = True
        Me.rdodotplot.Location = New System.Drawing.Point(8, 36)
        Me.rdodotplot.Name = "rdodotplot"
        Me.rdodotplot.Size = New System.Drawing.Size(63, 17)
        Me.rdodotplot.TabIndex = 1
        Me.rdodotplot.TabStop = True
        Me.rdodotplot.Text = "Dot Plot"
        Me.rdodotplot.UseVisualStyleBackColor = True
        '
        'rdoBoxplot
        '
        Me.rdoBoxplot.AutoSize = True
        Me.rdoBoxplot.Location = New System.Drawing.Point(8, 13)
        Me.rdoBoxplot.Name = "rdoBoxplot"
        Me.rdoBoxplot.Size = New System.Drawing.Size(60, 17)
        Me.rdoBoxplot.TabIndex = 0
        Me.rdoBoxplot.TabStop = True
        Me.rdoBoxplot.Text = "Boxplot"
        Me.rdoBoxplot.UseVisualStyleBackColor = True
        '
        'tbpFactor
        '
        Me.tbpFactor.Controls.Add(Me.rdoPieChart)
        Me.tbpFactor.Controls.Add(Me.rdoBarChart)
        Me.tbpFactor.Location = New System.Drawing.Point(4, 22)
        Me.tbpFactor.Name = "tbpFactor"
        Me.tbpFactor.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFactor.Size = New System.Drawing.Size(229, 105)
        Me.tbpFactor.TabIndex = 1
        Me.tbpFactor.Text = "Factor"
        Me.tbpFactor.UseVisualStyleBackColor = True
        '
        'rdoPieChart
        '
        Me.rdoPieChart.AutoSize = True
        Me.rdoPieChart.Location = New System.Drawing.Point(8, 36)
        Me.rdoPieChart.Name = "rdoPieChart"
        Me.rdoPieChart.Size = New System.Drawing.Size(68, 17)
        Me.rdoPieChart.TabIndex = 1
        Me.rdoPieChart.TabStop = True
        Me.rdoPieChart.Text = "Pie Chart"
        Me.rdoPieChart.UseVisualStyleBackColor = True
        '
        'rdoBarChart
        '
        Me.rdoBarChart.AutoSize = True
        Me.rdoBarChart.Location = New System.Drawing.Point(8, 13)
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.Size = New System.Drawing.Size(69, 17)
        Me.rdoBarChart.TabIndex = 0
        Me.rdoBarChart.TabStop = True
        Me.rdoBarChart.Text = "Bar Chart"
        Me.rdoBarChart.UseVisualStyleBackColor = True
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.rdoFacets)
        Me.tbpDisplay.Controls.Add(Me.rdoSingleGraph)
        Me.tbpDisplay.Controls.Add(Me.rdoCombineGraphs)
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDisplay.Size = New System.Drawing.Size(229, 105)
        Me.tbpDisplay.TabIndex = 2
        Me.tbpDisplay.Text = "Display"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'rdoFacets
        '
        Me.rdoFacets.AutoSize = True
        Me.rdoFacets.Location = New System.Drawing.Point(8, 59)
        Me.rdoFacets.Name = "rdoFacets"
        Me.rdoFacets.Size = New System.Drawing.Size(57, 17)
        Me.rdoFacets.TabIndex = 2
        Me.rdoFacets.TabStop = True
        Me.rdoFacets.Text = "Facets"
        Me.rdoFacets.UseVisualStyleBackColor = True
        '
        'rdoSingleGraph
        '
        Me.rdoSingleGraph.AutoSize = True
        Me.rdoSingleGraph.Location = New System.Drawing.Point(8, 36)
        Me.rdoSingleGraph.Name = "rdoSingleGraph"
        Me.rdoSingleGraph.Size = New System.Drawing.Size(86, 17)
        Me.rdoSingleGraph.TabIndex = 1
        Me.rdoSingleGraph.TabStop = True
        Me.rdoSingleGraph.Text = "Single Graph"
        Me.rdoSingleGraph.UseVisualStyleBackColor = True
        '
        'rdoCombineGraphs
        '
        Me.rdoCombineGraphs.AutoSize = True
        Me.rdoCombineGraphs.Location = New System.Drawing.Point(8, 13)
        Me.rdoCombineGraphs.Name = "rdoCombineGraphs"
        Me.rdoCombineGraphs.Size = New System.Drawing.Size(103, 17)
        Me.rdoCombineGraphs.TabIndex = 0
        Me.rdoCombineGraphs.TabStop = True
        Me.rdoCombineGraphs.Text = "Combine Graphs"
        Me.rdoCombineGraphs.UseVisualStyleBackColor = True
        '
        'UcrButtonsOneVarGraph
        '
        Me.UcrButtonsOneVarGraph.Location = New System.Drawing.Point(47, 135)
        Me.UcrButtonsOneVarGraph.Name = "UcrButtonsOneVarGraph"
        Me.UcrButtonsOneVarGraph.Size = New System.Drawing.Size(145, 30)
        Me.UcrButtonsOneVarGraph.TabIndex = 1
        '
        'sdgOneVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 169)
        Me.Controls.Add(Me.UcrButtonsOneVarGraph)
        Me.Controls.Add(Me.tbcOneVarGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarGraph"
        Me.Text = "sdgOneVarGraph"
        Me.tbcOneVarGraph.ResumeLayout(False)
        Me.tbpNumeric.ResumeLayout(False)
        Me.tbpNumeric.PerformLayout()
        Me.tbpFactor.ResumeLayout(False)
        Me.tbpFactor.PerformLayout()
        Me.tbpDisplay.ResumeLayout(False)
        Me.tbpDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcOneVarGraph As TabControl
    Friend WithEvents tbpNumeric As TabPage
    Friend WithEvents tbpFactor As TabPage
    Friend WithEvents tbpDisplay As TabPage
    Friend WithEvents rdohistogram As RadioButton
    Friend WithEvents rdodotplot As RadioButton
    Friend WithEvents rdoBoxplot As RadioButton
    Friend WithEvents rdoPieChart As RadioButton
    Friend WithEvents rdoBarChart As RadioButton
    Friend WithEvents rdoFacets As RadioButton
    Friend WithEvents rdoSingleGraph As RadioButton
    Friend WithEvents rdoCombineGraphs As RadioButton
    Friend WithEvents UcrButtonsOneVarGraph As ucrButtonsSubdialogue
End Class
