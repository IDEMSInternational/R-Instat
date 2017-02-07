'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports instat
Imports instat.Translations
Public Class dlgPolynomials
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Public clsCentredOptionFunc, clsScale, clsOverallFuction As New RFunction
    Private Sub dlgPolynomials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrReceiverPolynomial.IsEmpty()) AndAlso (Not ucrNudDegree.IsEmpty) AndAlso (ucrSavePoly.IsComplete)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()

        'Reset the selector
        ucrSelectorForPolynomial.Reset()

        TypeFunction()

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        TypeFunction()
    End Sub

    Public Sub TypeFunction()
        'Define the default RFunction
        clsDefaultFunction.SetRCommand("poly")
        clsDefaultFunction.AddParameter("degree", 2)


        If rdoSimple.Checked OrElse rdoOrthogonal.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
            SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ElseIf rdoCentered.Checked Then
            clsScale = clsCentredOptionFunc.Clone()
            clsOverallFuction = clsDefaultFunction.Clone()

            clsOverallFuction.AddParameter("x", clsRFunctionParameter:=clsScale)
            ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFuction)

            ucrReceiverPolynomial.SetRCode(clsScale, bReset)

        End If


        clsDefaultFunction.SetAssignTo(strTemp:=ucrSavePoly.GetText, strTempDataframe:=ucrSelectorForPolynomial.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSavePoly.GetText(), bAssignToIsPrefix:=True)

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 46

        ucrReceiverPolynomial.Selector = ucrSelectorForPolynomial
        ucrReceiverPolynomial.bUseFilteredData = False
        ucrReceiverPolynomial.SetMeAsReceiver()
        ucrReceiverPolynomial.SetIncludedDataTypes({"numeric"})
        ucrReceiverPolynomial.SetParameter(New RParameter("x"))
        ucrReceiverPolynomial.SetParameterIsRFunction()

        'Second function to be set inside
        clsCentredOptionFunc.SetRCommand("scale")
        clsCentredOptionFunc.AddParameter("center", "TRUE")
        clsCentredOptionFunc.AddParameter("scale", "FALSE")

        ucrPnlType.SetParameter(New RParameter("raw", 1))
        ucrPnlType.AddRadioButton(rdoSimple, "TRUE")
        ucrPnlType.AddRadioButton(rdoCentered, "TRUE")
        ucrPnlType.AddRadioButton(rdoOrthogonal, "FALSE")
        ucrPnlType.SetRDefault("FALSE")


        ucrNudDegree.SetParameter(New RParameter("degree", 2))

        'Set ucrSave 
        ucrSavePoly.SetPrefix("poly")
        ucrSavePoly.SetSaveTypeAsColumn()
        ucrSavePoly.SetLabelText("Save Poly")
        ucrSavePoly.SetDataFrameSelector(ucrSelectorForPolynomial.ucrAvailableDataFrames)
        ucrSavePoly.SetIsComboBox()

    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPolynomial.ControlContentsChanged, ucrNudDegree.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlType.ControlValueChanged
        TypeFunction()
    End Sub


End Class