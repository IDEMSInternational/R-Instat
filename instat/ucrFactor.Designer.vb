<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrFactor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblNoFactorsLoaded = New System.Windows.Forms.Label()
        Me.grdFactorData = New unvell.ReoGrid.ReoGridControl()
        Me.SuspendLayout()
        '
        'lblNoFactorsLoaded
        '
        Me.lblNoFactorsLoaded.AutoSize = True
        Me.lblNoFactorsLoaded.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoFactorsLoaded.Location = New System.Drawing.Point(3, 18)
        Me.lblNoFactorsLoaded.Name = "lblNoFactorsLoaded"
        Me.lblNoFactorsLoaded.Size = New System.Drawing.Size(196, 16)
        Me.lblNoFactorsLoaded.TabIndex = 0
        Me.lblNoFactorsLoaded.Text = "No factor columns selected"
        '
        'grdFactorData
        '
        Me.grdFactorData.BackColor = System.Drawing.Color.White
        Me.grdFactorData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdFactorData.LeadHeaderContextMenuStrip = Nothing
        Me.grdFactorData.Location = New System.Drawing.Point(4, 4)
        Me.grdFactorData.Name = "grdFactorData"
        Me.grdFactorData.RowHeaderContextMenuStrip = Nothing
        Me.grdFactorData.Script = Nothing
        Me.grdFactorData.SheetTabContextMenuStrip = Nothing
        Me.grdFactorData.SheetTabNewButtonVisible = False
        Me.grdFactorData.SheetTabWidth = 60
        Me.grdFactorData.SheetTabNewButtonVisible = False
        Me.grdFactorData.Size = New System.Drawing.Size(260, 174)
        Me.grdFactorData.TabIndex = 32
        '
        'ucrFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.grdFactorData)
        Me.Controls.Add(Me.lblNoFactorsLoaded)
        Me.Name = "ucrFactor"
        Me.Size = New System.Drawing.Size(267, 181)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNoFactorsLoaded As Label
    Friend WithEvents grdFactorData As unvell.ReoGrid.ReoGridControl
End Class
