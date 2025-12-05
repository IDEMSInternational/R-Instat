<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgClimsoftFilter
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
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrDataFrameCopySheets = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(9, 81)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(299, 36)
        Me.ucrBaseSubdialog.TabIndex = 4
        '
        'ucrDataFrameCopySheets
        '
        Me.ucrDataFrameCopySheets.AutoSize = True
        Me.ucrDataFrameCopySheets.bDropUnusedFilterLevels = False
        Me.ucrDataFrameCopySheets.bUseCurrentFilter = True
        Me.ucrDataFrameCopySheets.Location = New System.Drawing.Point(9, 9)
        Me.ucrDataFrameCopySheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameCopySheets.Name = "ucrDataFrameCopySheets"
        Me.ucrDataFrameCopySheets.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataFrameCopySheets.TabIndex = 5
        '
        'sdgClimsoftFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 135)
        Me.Controls.Add(Me.ucrDataFrameCopySheets)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimsoftFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climsoft Stations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents ucrDataFrameCopySheets As ucrDataFrame
End Class
