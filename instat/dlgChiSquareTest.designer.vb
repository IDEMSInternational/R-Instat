<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgChiSquareTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgChiSquareTest))
        Me.lblLayoutOfData = New System.Windows.Forms.Label()
        Me.cboLayoutOfData = New System.Windows.Forms.ComboBox()
        Me.chkContinuityCorrection = New System.Windows.Forms.CheckBox()
        Me.chkSaveValues = New System.Windows.Forms.CheckBox()
        Me.lblDataColumns = New System.Windows.Forms.Label()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverChiSquare = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblLayoutOfData
        '
        resources.ApplyResources(Me.lblLayoutOfData, "lblLayoutOfData")
        Me.lblLayoutOfData.Name = "lblLayoutOfData"
        Me.lblLayoutOfData.Tag = "Layout_of_data"
        '
        'cboLayoutOfData
        '
        Me.cboLayoutOfData.FormattingEnabled = True
        Me.cboLayoutOfData.Items.AddRange(New Object() {resources.GetString("cboLayoutOfData.Items"), resources.GetString("cboLayoutOfData.Items1"), resources.GetString("cboLayoutOfData.Items2")})
        resources.ApplyResources(Me.cboLayoutOfData, "cboLayoutOfData")
        Me.cboLayoutOfData.Name = "cboLayoutOfData"
        '
        'chkContinuityCorrection
        '
        resources.ApplyResources(Me.chkContinuityCorrection, "chkContinuityCorrection")
        Me.chkContinuityCorrection.Name = "chkContinuityCorrection"
        Me.chkContinuityCorrection.Tag = "Continuity_correction"
        Me.chkContinuityCorrection.UseVisualStyleBackColor = True
        '
        'chkSaveValues
        '
        resources.ApplyResources(Me.chkSaveValues, "chkSaveValues")
        Me.chkSaveValues.Name = "chkSaveValues"
        Me.chkSaveValues.Tag = "Save_values"
        Me.chkSaveValues.UseVisualStyleBackColor = True
        '
        'lblDataColumns
        '
        resources.ApplyResources(Me.lblDataColumns, "lblDataColumns")
        Me.lblDataColumns.Name = "lblDataColumns"
        Me.lblDataColumns.Tag = "Data_Columns"
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrAddRemove, "ucrAddRemove")
        Me.ucrAddRemove.Name = "ucrAddRemove"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverChiSquare
        '
        resources.ApplyResources(Me.ucrReceiverChiSquare, "ucrReceiverChiSquare")
        Me.ucrReceiverChiSquare.Name = "ucrReceiverChiSquare"
        Me.ucrReceiverChiSquare.Selector = Nothing
        '
        'dlgChiSquareTest
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.lblDataColumns)
        Me.Controls.Add(Me.chkSaveValues)
        Me.Controls.Add(Me.chkContinuityCorrection)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverChiSquare)
        Me.Controls.Add(Me.cboLayoutOfData)
        Me.Controls.Add(Me.lblLayoutOfData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgChiSquareTest"
        Me.Tag = "Chi_square_Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLayoutOfData As Label
    Friend WithEvents cboLayoutOfData As ComboBox
    Friend WithEvents ucrReceiverChiSquare As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkContinuityCorrection As CheckBox
    Friend WithEvents chkSaveValues As CheckBox
    Friend WithEvents lblDataColumns As Label
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
End Class
