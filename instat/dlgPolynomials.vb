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
Imports instat.Translations
Public Class dlgPolynomials
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsPolynomial As New RFunction
    Public clsScale As New RFunction
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

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 46

        ucrReceiverPolynomial.SetParameter(New RParameter("x", 0))
        ucrReceiverPolynomial.bUseFilteredData = False
        ucrReceiverPolynomial.Selector = ucrSelectorForPolynomial
        ucrReceiverPolynomial.SetMeAsReceiver()
        ucrReceiverPolynomial.SetIncludedDataTypes({"numeric"})
        ucrReceiverPolynomial.SetParameterIsRFunction()

        ucrPnlType.SetParameter(New RParameter("raw", 1))
        ucrPnlType.AddRadioButton(rdoSimple, "TRUE")
        ucrPnlType.AddRadioButton(rdoCentered, "TRUE")
        ucrPnlType.AddRadioButton(rdoOrthogonal, "FALSE")
        ucrPnlType.SetRDefault("FALSE")

        ucrPnlType.AddParameterValuesCondition(rdoOrthogonal, "raw", "FALSE")
        ucrPnlType.AddParameterValueFunctionNamesCondition(rdoOrthogonal, "x", "scale", False)
        ucrPnlType.AddParameterValuesCondition(rdoSimple, "raw", "TRUE")
        ucrPnlType.AddParameterValueFunctionNamesCondition(rdoSimple, "x", "scale", False)
        ucrPnlType.AddParameterValuesCondition(rdoCentered, "raw", "TRUE")
        ucrPnlType.AddParameterValueFunctionNamesCondition(rdoCentered, "x", "scale")

        ucrNudDegree.SetParameter(New RParameter("degree", 2))
        ucrNudDegree.Minimum = 1
        ucrNudDegree.SetRDefault(1)

        ucrSavePoly.SetSaveTypeAsColumn()
        ucrSavePoly.SetDataFrameSelector(ucrSelectorForPolynomial.ucrAvailableDataFrames)
        ucrSavePoly.SetIsComboBox()
    End Sub

    Private Sub SetDefaults()
        clsPolynomial = New RFunction
        clsScale = New RFunction

        ucrSelectorForPolynomial.Reset()
        ucrSavePoly.Reset()

        clsPolynomial.SetRCommand("poly")
        clsPolynomial.AddParameter("degree", 2)
        clsPolynomial.AddParameter("raw", "TRUE")

        clsScale.SetRCommand("scale")
        clsScale.AddParameter("center", "TRUE")
        clsScale.AddParameter("scale", "FALSE")
        clsPolynomial.SetAssignTo(ucrSavePoly.GetText, strTempDataframe:=ucrSelectorForPolynomial.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSavePoly.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsPolynomial)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudDegree.SetRCode(clsPolynomial, bReset)
        ucrPnlType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSavePoly.SetRCode(clsPolynomial, bReset)
        If rdoSimple.Checked OrElse rdoOrthogonal.Checked Then
            ucrReceiverPolynomial.SetRCode(clsPolynomial, bReset)
        End If
        ucrReceiverPolynomial.AddAdditionalCodeParameterPair(clsScale, New RParameter("x", 0), iAdditionalPairNo:=1)
        SetNewColumName()
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrReceiverPolynomial.IsEmpty()) AndAlso (ucrNudDegree.GetText <> "") AndAlso (ucrSavePoly.IsComplete)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetNewColumName()
        If ucrNudDegree.Value = 1 Then
            ucrSavePoly.SetAssignToBooleans(bTempAssignToIsPrefix:=False)
            ucrSavePoly.SetLabelText("New Column Name:")
            If Not ucrSavePoly.bUserTyped Then
                ucrSavePoly.SetPrefix("poly")
            End If
        Else
            ucrSavePoly.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
            ucrSavePoly.SetLabelText("Prefix for New Columns:")
            ucrSavePoly.SetPrefix("")
            If Not ucrSavePoly.bUserTyped Then
                ucrSavePoly.SetName("poly")
            End If
        End If

    End Sub

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlType.ControlValueChanged
        If rdoCentered.Checked Then
            clsPolynomial.AddParameter("x", clsRFunctionParameter:=clsScale)
        Else
            clsPolynomial.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables)
        End If
    End Sub

    Private Sub ucrNudDegree_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudDegree.ControlContentsChanged
        SetNewColumName()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPolynomial.ControlContentsChanged, ucrNudDegree.ControlContentsChanged, ucrSavePoly.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class