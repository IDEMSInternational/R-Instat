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
        Me.cmdLayout = New System.Windows.Forms.Button()
        Me.ucrSaveCombinedGraph = New instat.ucrSaveGraph()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 263)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrCombineGraphSelector
        '
        Me.ucrCombineGraphSelector.bShowHiddenColumns = False
        Me.ucrCombineGraphSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrCombineGraphSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCombineGraphSelector.Name = "ucrCombineGraphSelector"
        Me.ucrCombineGraphSelector.Size = New System.Drawing.Size(210, 195)
        Me.ucrCombineGraphSelector.TabIndex = 1
        '
        'ucrCombineGraphReceiver
        '
        Me.ucrCombineGraphReceiver.Location = New System.Drawing.Point(238, 53)
        Me.ucrCombineGraphReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCombineGraphReceiver.Name = "ucrCombineGraphReceiver"
        Me.ucrCombineGraphReceiver.Selector = Nothing
        Me.ucrCombineGraphReceiver.Size = New System.Drawing.Size(120, 132)
        Me.ucrCombineGraphReceiver.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Graphs To Combine"
        '
        'cmdLayout
        '
        Me.cmdLayout.Location = New System.Drawing.Point(13, 199)
        Me.cmdLayout.Name = "cmdLayout"
        Me.cmdLayout.Size = New System.Drawing.Size(75, 23)
        Me.cmdLayout.TabIndex = 4
        Me.cmdLayout.Text = "Layout"
        Me.cmdLayout.UseVisualStyleBackColor = True
        '
        'ucrSaveCombinedGraph
        '
        Me.ucrSaveCombinedGraph.Location = New System.Drawing.Point(13, 235)
        Me.ucrSaveCombinedGraph.Name = "ucrSaveCombinedGraph"
        Me.ucrSaveCombinedGraph.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveCombinedGraph.TabIndex = 5
        '
        'dlgCombineforGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 321)
        Me.Controls.Add(Me.ucrSaveCombinedGraph)
        Me.Controls.Add(Me.cmdLayout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrCombineGraphReceiver)
        Me.Controls.Add(Me.ucrCombineGraphSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCombineforGraphics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Combine"
        Me.Text = "Combine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCombineGraphSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrCombineGraphReceiver As ucrReceiverMultiple
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdLayout As Button
    Friend WithEvents ucrSaveCombinedGraph As ucrSaveGraph
End Class
