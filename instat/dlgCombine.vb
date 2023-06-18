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

Imports instat.Translations
Public Class dlgCombine
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgCombine_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub


    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 39
        Dim dctInputSeparator As New Dictionary(Of String, String)

        'ucrReceiver
        ucrFactorsReceiver.SetParameter(New RParameter("x", 0))
        ucrFactorsReceiver.strSelectorHeading = "Factors"
        ucrFactorsReceiver.SetParameterIsRFunction()
        ucrFactorsReceiver.Selector = ucrSelectorCombineFactors
        ucrFactorsReceiver.SetMeAsReceiver()
        ucrFactorsReceiver.bUseFilteredData = False
        ucrFactorsReceiver.SetIncludedDataTypes({"factor"}, bStrict:=True)

        ucrInputSeparator.SetParameter(New RParameter("sep", 2))
        dctInputSeparator.Add("Period .", Chr(34) & "." & Chr(34))
        dctInputSeparator.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctInputSeparator.Add("Colon :", Chr(34) & ":" & Chr(34))
        dctInputSeparator.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctInputSeparator.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputSeparator.SetItems(dctInputSeparator)
        ucrInputSeparator.SetLinkedDisplayControl(lblSeparator)
        ucrInputSeparator.SetRDefault(Chr(34) & "." & Chr(34))
        ucrInputSeparator.bAllowNonConditionValues = True

        ucrChkLexOrder.SetParameter(New RParameter("lex.order", 3))
        ucrChkLexOrder.SetText("Lexical Order")
        ucrChkLexOrder.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkLexOrder.SetRDefault("FALSE")

        ' Input Column Name
        ucrNewColName.SetIsComboBox()
        ucrNewColName.SetPrefix("interact")
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetDataFrameSelector(ucrSelectorCombineFactors.ucrAvailableDataFrames)
        ucrNewColName.SetLabelText("New Column Name:")
        ucrNewColName.setLinkedReceiver(ucrFactorsReceiver)

        'chkbox
        ucrChkDropUnusedLevels.SetParameter(New RParameter("drop", 1))
        ucrChkDropUnusedLevels.SetText("Drop Unused Levels")
        ucrChkDropUnusedLevels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropUnusedLevels.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorCombineFactors.Reset()
        ucrNewColName.Reset()

        clsDefaultFunction.SetRCommand("interaction")
        clsDefaultFunction.SetAssignTo(strTemp:=ucrNewColName.GetText(), strTempDataframe:=ucrSelectorCombineFactors.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText())

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (ucrFactorsReceiver.lstSelectedVariables.Items.Count > 1) AndAlso ucrNewColName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorsReceiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrFactorsReceiver.ControlContentsChanged, ucrNewColName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
