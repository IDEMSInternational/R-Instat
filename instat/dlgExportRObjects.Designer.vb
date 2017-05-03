<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportRObjects
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
        Me.ucrSelectorObjects = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverObjects = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 320)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(398, 52)
        Me.ucrBase.TabIndex = 1
        '
        'ucrSelectorObjects
        '
        Me.ucrSelectorObjects.bShowHiddenColumns = False
        Me.ucrSelectorObjects.bUseCurrentFilter = True
        Me.ucrSelectorObjects.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorObjects.Name = "ucrSelectorObjects"
        Me.ucrSelectorObjects.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorObjects.TabIndex = 2
        '
        'ucrReceiverObjects
        '
        Me.ucrReceiverObjects.frmParent = Me
        Me.ucrReceiverObjects.Location = New System.Drawing.Point(264, 60)
        Me.ucrReceiverObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObjects.Name = "ucrReceiverObjects"
        Me.ucrReceiverObjects.Selector = Nothing
        Me.ucrReceiverObjects.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverObjects.TabIndex = 3
        Me.ucrReceiverObjects.ucrSelector = Nothing
        '
        'dlgExportRObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 384)
        Me.Controls.Add(Me.ucrReceiverObjects)
        Me.Controls.Add(Me.ucrSelectorObjects)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportRObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export R Objects"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorObjects As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverObjects As ucrReceiverMultiple
End Class
