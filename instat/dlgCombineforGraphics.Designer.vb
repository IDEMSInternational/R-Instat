﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCombineforGraphics
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
        Me.ucrCombineGraphSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrCombineGraphReceiver = New instat.ucrReceiverMultiple()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrSaveCombinedGraph = New instat.ucrSaveGraph()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 254)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 5
        '
        'ucrCombineGraphSelector
        '
        Me.ucrCombineGraphSelector.bShowHiddenColumns = False
        Me.ucrCombineGraphSelector.bUseCurrentFilter = True
        Me.ucrCombineGraphSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrCombineGraphSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCombineGraphSelector.Name = "ucrCombineGraphSelector"
        Me.ucrCombineGraphSelector.Size = New System.Drawing.Size(210, 195)
        Me.ucrCombineGraphSelector.TabIndex = 0
        '
        'ucrCombineGraphReceiver
        '
        Me.ucrCombineGraphReceiver.Location = New System.Drawing.Point(252, 60)
        Me.ucrCombineGraphReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCombineGraphReceiver.Name = "ucrCombineGraphReceiver"
        Me.ucrCombineGraphReceiver.Selector = Nothing
        Me.ucrCombineGraphReceiver.Size = New System.Drawing.Size(120, 130)
        Me.ucrCombineGraphReceiver.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Graphs To Combine:"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 199)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 3
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveCombinedGraph
        '
        Me.ucrSaveCombinedGraph.Location = New System.Drawing.Point(10, 228)
        Me.ucrSaveCombinedGraph.Name = "ucrSaveCombinedGraph"
        Me.ucrSaveCombinedGraph.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveCombinedGraph.TabIndex = 4
        '
        'dlgCombineforGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 312)
        Me.Controls.Add(Me.ucrSaveCombinedGraph)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrCombineGraphReceiver)
        Me.Controls.Add(Me.ucrCombineGraphSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCombineforGraphics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Combine_Graphs"
        Me.Text = "Combine Graphs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCombineGraphSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrCombineGraphReceiver As ucrReceiverMultiple
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrSaveCombinedGraph As ucrSaveGraph
End Class
