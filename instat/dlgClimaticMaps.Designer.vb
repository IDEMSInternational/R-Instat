<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticMaps
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
        Me.ucrSelectorClimaticMaps = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveMap = New instat.ucrSave()
        Me.cmdMapOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrSelectorClimaticMaps
        '
        Me.ucrSelectorClimaticMaps.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimaticMaps.bShowHiddenColumns = False
        Me.ucrSelectorClimaticMaps.bUseCurrentFilter = True
        Me.ucrSelectorClimaticMaps.Location = New System.Drawing.Point(10, 40)
        Me.ucrSelectorClimaticMaps.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticMaps.Name = "ucrSelectorClimaticMaps"
        Me.ucrSelectorClimaticMaps.Size = New System.Drawing.Size(315, 277)
        Me.ucrSelectorClimaticMaps.TabIndex = 0
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.frmParent = Me
        Me.ucrReceiverFill.Location = New System.Drawing.Point(412, 98)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 2
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(416, 73)
        Me.lblFill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(32, 20)
        Me.lblFill.TabIndex = 1
        Me.lblFill.Text = "Fill:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 465)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 80)
        Me.ucrBase.TabIndex = 5
        '
        'ucrSaveMap
        '
        Me.ucrSaveMap.Location = New System.Drawing.Point(10, 408)
        Me.ucrSaveMap.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrSaveMap.Name = "ucrSaveMap"
        Me.ucrSaveMap.Size = New System.Drawing.Size(366, 37)
        Me.ucrSaveMap.TabIndex = 4
        '
        'cmdMapOptions
        '
        Me.cmdMapOptions.Location = New System.Drawing.Point(14, 339)
        Me.cmdMapOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdMapOptions.Name = "cmdMapOptions"
        Me.cmdMapOptions.Size = New System.Drawing.Size(154, 35)
        Me.cmdMapOptions.TabIndex = 3
        Me.cmdMapOptions.Text = "Map Options"
        Me.cmdMapOptions.UseVisualStyleBackColor = True
        '
        'dlgClimaticMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 552)
        Me.Controls.Add(Me.cmdMapOptions)
        Me.Controls.Add(Me.ucrSaveMap)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrSelectorClimaticMaps)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticMaps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Maps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorClimaticMaps As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents cmdMapOptions As Button
    Friend WithEvents ucrSaveMap As ucrSave
End Class
