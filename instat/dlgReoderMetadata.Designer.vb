<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReoderMetadata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReoderMetadata))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameReoderMetadata = New instat.ucrDataFrame()
        Me.lblMetataDataColumns = New System.Windows.Forms.Label()
        Me.ucrReorderMetadata = New instat.ucrReorder()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrDataFrameReoderMetadata
        '
        Me.ucrDataFrameReoderMetadata.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrDataFrameReoderMetadata, "ucrDataFrameReoderMetadata")
        Me.ucrDataFrameReoderMetadata.Name = "ucrDataFrameReoderMetadata"
        '
        'lblMetataDataColumns
        '
        resources.ApplyResources(Me.lblMetataDataColumns, "lblMetataDataColumns")
        Me.lblMetataDataColumns.Name = "lblMetataDataColumns"
        '
        'ucrReorderMetadata
        '
        resources.ApplyResources(Me.ucrReorderMetadata, "ucrReorderMetadata")
        Me.ucrReorderMetadata.Name = "ucrReorderMetadata"
        Me.ucrReorderMetadata.ucrDataFrameList = Nothing
        Me.ucrReorderMetadata.ucrReceiver = Nothing
        '
        'dlgReoderMetadata
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReorderMetadata)
        Me.Controls.Add(Me.lblMetataDataColumns)
        Me.Controls.Add(Me.ucrDataFrameReoderMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReoderMetadata"
        Me.Tag = "Reoder_Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameReoderMetadata As ucrDataFrame
    Friend WithEvents lblMetataDataColumns As Label
    Friend WithEvents ucrReorderMetadata As ucrReorder
End Class
