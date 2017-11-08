' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgPolynomials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgPolynomials))
        Me.lblDegree = New System.Windows.Forms.Label()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.rdoCentred = New System.Windows.Forms.RadioButton()
        Me.rdoOrthogonal = New System.Windows.Forms.RadioButton()
        Me.rdoSimple = New System.Windows.Forms.RadioButton()
        Me.ucrPnlType = New instat.UcrPanel()
        Me.ucrNudDegree = New instat.ucrNud()
        Me.ucrSavePoly = New instat.ucrSave()
        Me.ucrSelectorForPolynomial = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverPolynomial = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDegree
        '
        resources.ApplyResources(Me.lblDegree, "lblDegree")
        Me.lblDegree.Name = "lblDegree"
        Me.lblDegree.Tag = "Degree"
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rdoCentred)
        Me.grpType.Controls.Add(Me.rdoOrthogonal)
        Me.grpType.Controls.Add(Me.rdoSimple)
        Me.grpType.Controls.Add(Me.ucrPnlType)
        resources.ApplyResources(Me.grpType, "grpType")
        Me.grpType.Name = "grpType"
        Me.grpType.TabStop = False
        '
        'rdoCentred
        '
        resources.ApplyResources(Me.rdoCentred, "rdoCentred")
        Me.rdoCentred.Name = "rdoCentred"
        Me.rdoCentred.Tag = "Centred"
        Me.rdoCentred.UseVisualStyleBackColor = True
        '
        'rdoOrthogonal
        '
        resources.ApplyResources(Me.rdoOrthogonal, "rdoOrthogonal")
        Me.rdoOrthogonal.Name = "rdoOrthogonal"
        Me.rdoOrthogonal.Tag = "Orthogonal"
        Me.rdoOrthogonal.UseVisualStyleBackColor = True
        '
        'rdoSimple
        '
        resources.ApplyResources(Me.rdoSimple, "rdoSimple")
        Me.rdoSimple.Name = "rdoSimple"
        Me.rdoSimple.Tag = "Simple"
        Me.rdoSimple.UseVisualStyleBackColor = True
        '
        'ucrPnlType
        '
        resources.ApplyResources(Me.ucrPnlType, "ucrPnlType")
        Me.ucrPnlType.Name = "ucrPnlType"
        '
        'ucrNudDegree
        '
        Me.ucrNudDegree.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDegree.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDegree, "ucrNudDegree")
        Me.ucrNudDegree.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDegree.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDegree.Name = "ucrNudDegree"
        Me.ucrNudDegree.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSavePoly
        '
        resources.ApplyResources(Me.ucrSavePoly, "ucrSavePoly")
        Me.ucrSavePoly.Name = "ucrSavePoly"
        '
        'ucrSelectorForPolynomial
        '
        Me.ucrSelectorForPolynomial.bShowHiddenColumns = False
        Me.ucrSelectorForPolynomial.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForPolynomial, "ucrSelectorForPolynomial")
        Me.ucrSelectorForPolynomial.Name = "ucrSelectorForPolynomial"
        '
        'ucrReceiverPolynomial
        '
        Me.ucrReceiverPolynomial.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPolynomial, "ucrReceiverPolynomial")
        Me.ucrReceiverPolynomial.Name = "ucrReceiverPolynomial"
        Me.ucrReceiverPolynomial.Selector = Nothing
        Me.ucrReceiverPolynomial.strNcFilePath = ""
        Me.ucrReceiverPolynomial.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblSelectedVariable
        '
        resources.ApplyResources(Me.lblSelectedVariable, "lblSelectedVariable")
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        '
        'dlgPolynomials
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.ucrNudDegree)
        Me.Controls.Add(Me.ucrSavePoly)
        Me.Controls.Add(Me.ucrSelectorForPolynomial)
        Me.Controls.Add(Me.ucrReceiverPolynomial)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblDegree)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPolynomials"
        Me.Tag = "Polynomials"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDegree As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverPolynomial As ucrReceiverSingle
    Friend WithEvents ucrSelectorForPolynomial As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSavePoly As ucrSave
    Friend WithEvents ucrNudDegree As ucrNud
    Friend WithEvents grpType As GroupBox
    Friend WithEvents rdoCentred As RadioButton
    Friend WithEvents rdoOrthogonal As RadioButton
    Friend WithEvents rdoSimple As RadioButton
    Friend WithEvents ucrPnlType As UcrPanel
    Friend WithEvents lblSelectedVariable As Label
End Class
