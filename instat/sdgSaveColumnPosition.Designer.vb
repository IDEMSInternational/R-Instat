<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgSaveColumnPosition
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
        Me.rdoStart = New instat.ucrRadio()
        Me.rdoEnd = New instat.ucrRadio()
        Me.rdoBefore = New instat.ucrRadio()
        Me.rdoAfter = New instat.ucrRadio()
        Me.ucrSelectorSaveColumnPosition = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrPnlColumnPosition = New instat.UcrPanel()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'rdoStart
        '
        Me.rdoStart.Location = New System.Drawing.Point(12, 27)
        Me.rdoStart.Name = "rdoStart"
        Me.rdoStart.Size = New System.Drawing.Size(100, 20)
        Me.rdoStart.TabIndex = 0
        '
        'rdoEnd
        '
        Me.rdoEnd.Location = New System.Drawing.Point(12, 85)
        Me.rdoEnd.Name = "rdoEnd"
        Me.rdoEnd.Size = New System.Drawing.Size(100, 20)
        Me.rdoEnd.TabIndex = 1
        '
        'rdoBefore
        '
        Me.rdoBefore.Location = New System.Drawing.Point(12, 143)
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.Size = New System.Drawing.Size(100, 20)
        Me.rdoBefore.TabIndex = 2
        '
        'rdoAfter
        '
        Me.rdoAfter.Location = New System.Drawing.Point(12, 201)
        Me.rdoAfter.Name = "rdoAfter"
        Me.rdoAfter.Size = New System.Drawing.Size(100, 20)
        Me.rdoAfter.TabIndex = 3
        '
        'ucrSelectorSaveColumnPosition
        '
        Me.ucrSelectorSaveColumnPosition.bDropUnusedFilterLevels = False
        Me.ucrSelectorSaveColumnPosition.bShowHiddenColumns = False
        Me.ucrSelectorSaveColumnPosition.bUseCurrentFilter = True
        Me.ucrSelectorSaveColumnPosition.Location = New System.Drawing.Point(124, 133)
        Me.ucrSelectorSaveColumnPosition.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSaveColumnPosition.Name = "ucrSelectorSaveColumnPosition"
        Me.ucrSelectorSaveColumnPosition.Size = New System.Drawing.Size(216, 186)
        Me.ucrSelectorSaveColumnPosition.TabIndex = 4
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(345, 154)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 5
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrPnlColumnPosition
        '
        Me.ucrPnlColumnPosition.Location = New System.Drawing.Point(5, 12)
        Me.ucrPnlColumnPosition.Name = "ucrPnlColumnPosition"
        Me.ucrPnlColumnPosition.Size = New System.Drawing.Size(107, 231)
        Me.ucrPnlColumnPosition.TabIndex = 6
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(164, 362)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubdialog.TabIndex = 7
        '
        'sdgSaveColumnPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 404)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.ucrSelectorSaveColumnPosition)
        Me.Controls.Add(Me.rdoAfter)
        Me.Controls.Add(Me.rdoBefore)
        Me.Controls.Add(Me.rdoEnd)
        Me.Controls.Add(Me.rdoStart)
        Me.Controls.Add(Me.ucrPnlColumnPosition)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSaveColumnPosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Save Column Position"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdoStart As ucrRadio
    Friend WithEvents rdoEnd As ucrRadio
    Friend WithEvents rdoBefore As ucrRadio
    Friend WithEvents rdoAfter As ucrRadio
    Friend WithEvents ucrSelectorSaveColumnPosition As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents ucrPnlColumnPosition As UcrPanel
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
End Class
