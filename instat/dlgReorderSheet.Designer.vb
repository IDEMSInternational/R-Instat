<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReorderSheet
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReorderSheet))
        Me.lblSheetsToReoder = New System.Windows.Forms.Label()
        Me.ucrSheetsToReorder = New instat.ucrReorder()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSheetsToReoder
        '
        resources.ApplyResources(Me.lblSheetsToReoder, "lblSheetsToReoder")
        Me.lblSheetsToReoder.Name = "lblSheetsToReoder"
        '
        'ucrSheetsToReorder
        '
        resources.ApplyResources(Me.ucrSheetsToReorder, "ucrSheetsToReorder")
        Me.ucrSheetsToReorder.Name = "ucrSheetsToReorder"
        Me.ucrSheetsToReorder.ucrDataFrameList = Nothing
        Me.ucrSheetsToReorder.ucrReceiver = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgReorderSheet
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSheetsToReoder)
        Me.Controls.Add(Me.ucrSheetsToReorder)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderSheet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSheetsToReorder As ucrReorder
    Friend WithEvents lblSheetsToReoder As Label
End Class
