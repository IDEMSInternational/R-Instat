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
    Public clsCentredOptionFunc, clsScale, clsRaw As New RFunction
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
        Dim clsDefaultFunction As New RFunction

        'Reset the selector
        ucrSelectorForPolynomial.Reset()

        'Define the default RFunction
        clsDefaultFunction.SetRCommand("poly")
        clsDefaultFunction.AddParameter("degree", 2)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        clsScale = clsCentredOptionFunc.Clone()
        clsDefaultFunction.AddParameter("y", clsRFunctionParameter:=clsCentredOptionFunc)
        clsDefaultFunction.AddParameter("raw", "TRUE")
        ucrRadioCentered.SetRCode(clsScale)
        ucrReceiverPolynomial.SetRCode(clsDefaultFunction)
        clsDefaultFunction.SetAssignTo("poly", strTempDataframe:=ucrSelectorForPolynomial.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="poly")

        ' Set default RFunction as the base function
        ' Warning: Centred radio button not fully impemented yet - Awaiting implementation ofpassing function within a function
        '  ABE <- InstatDataObject$get_columns_from_data(use_current_filter=FALSE, col_name="ABE", data_name="ghana_data")
        'Poly <- poly(x=scale(x=ABE, scale=FALSE, center=TRUE), raw=TRUE, degree=2)
        'clsDefaultFunction.AddParameter("x", clsRFunctionParameter:=clsCentredOptionFunc)


    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 46

        rdoOrthogonal.Enabled = False
        rdoSimple.Enabled = False
        'Second function to be set inside
        clsCentredOptionFunc.SetRCommand("scale")
        clsCentredOptionFunc.AddParameter("center", "TRUE")
        clsCentredOptionFunc.AddParameter("scale", "FALSE")
        clsCentredOptionFunc.AddParameter("x", ucrReceiverPolynomial.GetVariableNames(False))
        ' clsRaw.AddParameter("raw", "TRUE")

        ucrReceiverPolynomial.Selector = ucrSelectorForPolynomial
        ucrReceiverPolynomial.bUseFilteredData = False
        ucrReceiverPolynomial.SetMeAsReceiver()
        ucrReceiverPolynomial.SetIncludedDataTypes({"numeric"})
        ' ucrReceiverPolynomial.SetParameter(New RParameter("x", 0))

        ucrReceiverPolynomial.SetParameterIsRFunction()

        ucrPnlType.SetParameter(New RParameter("raw", 1))
        ucrPnlType.AddRadioButton(rdoSimple, "TRUE")
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

End Class