'' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class dlgStringDistance
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsStringDistFunction As New RFunction
    Private Sub dlgStringDistance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctMethod As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 347

        'ucrReceiver
        ucrReceiverStringDistance.SetParameter(New RParameter("a", 0))
        ucrReceiverStringDistance.SetParameterIsRFunction()
        ucrReceiverStringDistance.Selector = ucrSelectorStringDistance
        ucrReceiverStringDistance.SetMeAsReceiver()

        ucrReceiverColumn.SetParameter(New RParameter("b", 1))
        ucrReceiverColumn.SetParameterIsRFunction()
        ucrReceiverColumn.Selector = ucrSelectorStringDistance
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumnString)

        ucrInputPatternStringDistance.SetParameter(New RParameter("b", 1))
        ucrInputPatternStringDistance.SetLinkedDisplayControl(lblPattern)

        ucrPnlStringDist.AddRadioButton(rdoString)
        ucrPnlStringDist.AddRadioButton(rdoColumn)

        ucrPnlStringDist.AddParameterIsRFunctionCondition(rdoColumn, "b")
        ucrPnlStringDist.AddParameterIsStringCondition(rdoString, "b")
        ucrPnlStringDist.AddToLinkedControls(ucrReceiverColumn, {rdoColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringDist.AddToLinkedControls(ucrInputPatternStringDistance, {rdoString}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputComboBoxMethod.SetParameter(New RParameter("method", 2))
        ucrInputComboBoxMethod.SetDropDownStyleAsNonEditable()

        dctMethod.Add("Cosine Distance between q-Gram Profiles", Chr(34) & "cosine" & Chr(34))
        dctMethod.Add("Distance based on Soundex Encoding", Chr(34) & "soundex" & Chr(34))
        dctMethod.Add("Full Damerau-Levenshtein Distance", Chr(34) & "dl" & Chr(34))
        dctMethod.Add("Hamming Distance", Chr(34) & "hamming" & Chr(34))
        dctMethod.Add("Jaccard Distance between q-Gram Profiles", Chr(34) & "jaccard" & Chr(34))
        dctMethod.Add("Jaro or Jaro-Winker Distance", Chr(34) & "jw" & Chr(34))
        dctMethod.Add("Levenshtein Distance", Chr(34) & "lv" & Chr(34))
        dctMethod.Add("Longest Common Substring Distance", Chr(34) & "lcs" & Chr(34))
        dctMethod.Add("Optimal String Alignment", Chr(34) & "osa" & Chr(34))
        dctMethod.Add("q-Gram Distance", Chr(34) & "qgram" & Chr(34))
        ucrInputComboBoxMethod.SetItems(dctMethod)
        ucrInputComboBoxMethod.SetRDefault(Chr(34) & "osa" & Chr(34))

        ucrSaveStringDistance.SetPrefix("Dist")
        ucrSaveStringDistance.SetSaveTypeAsColumn()
        ucrSaveStringDistance.SetDataFrameSelector(ucrSelectorStringDistance.ucrAvailableDataFrames)
        ucrSaveStringDistance.SetIsTextBox()
        ucrSaveStringDistance.SetLabelText("Save Result:")
    End Sub

    Private Sub SetDefaults()
        clsStringDistFunction = New RFunction

        ucrInputPatternStringDistance.SetName("")
        ucrSelectorStringDistance.Reset()
        ucrSaveStringDistance.Reset()
        ucrInputComboBoxMethod.Reset()

        clsStringDistFunction.SetPackageName("stringdist")
        clsStringDistFunction.SetRCommand("stringdist")
        ucrInputPatternStringDistance.Reset()
        clsStringDistFunction.AddParameter("method", Chr(34) & "osa" & Chr(34))
        clsStringDistFunction.AddParameter("b", Chr(34) & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsStringDistFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoColumn.Checked AndAlso Not ucrReceiverColumn.IsEmpty() AndAlso Not ucrReceiverStringDistance.IsEmpty() AndAlso ucrSaveStringDistance.IsComplete() AndAlso Not ucrInputComboBoxMethod.IsEmpty Then
            ucrBase.OKEnabled(True)
        ElseIf rdoString.Checked AndAlso Not ucrReceiverStringDistance.IsEmpty() AndAlso Not ucrInputPatternStringDistance.IsEmpty() AndAlso ucrSaveStringDistance.IsComplete() AndAlso Not ucrInputComboBoxMethod.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverStringDistance_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringDistance.ControlContentsChanged, ucrReceiverColumn.ControlContentsChanged, ucrSaveStringDistance.ControlContentsChanged, ucrInputPatternStringDistance.ControlContentsChanged, ucrInputComboBoxMethod.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class