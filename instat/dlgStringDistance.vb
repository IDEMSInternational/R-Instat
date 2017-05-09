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
        ucrBase.iHelpTopicID = 347
        'ucrReceiver
        ucrReceiverStringDistance.SetParameter(New RParameter("a", 0))
        ucrReceiverStringDistance.SetParameterIsRFunction()
        ucrReceiverStringDistance.Selector = ucrSelectorStringDistance
        ucrReceiverStringDistance.SetMeAsReceiver()

        ucrInputPatternStringDistance.SetParameter(New RParameter("b", 1))

        ucrInputComboBoxMethod.SetParameter(New RParameter("method", 2))

        Dim dctMethod As New Dictionary(Of String, String)
        dctMethod.Add("Optimal String Alignment", Chr(34) & "osa" & Chr(34))
        dctMethod.Add("Levenshtein Distance", Chr(34) & "lv" & Chr(34))
        dctMethod.Add("Full Damerau-Levenshtein Distance", Chr(34) & "dl" & Chr(34))
        dctMethod.Add("Hamming Distance", Chr(34) & "hamming" & Chr(34))
        dctMethod.Add("Longest Common Substring Distance", Chr(34) & "lcs" & Chr(34))
        dctMethod.Add("q-Gram Distance", Chr(34) & "qgram" & Chr(34))
        dctMethod.Add("Cosine Distance between q-Gram Profiles", Chr(34) & "cosine" & Chr(34))
        dctMethod.Add("Jaccard Distance between q-Gram Profiles", Chr(34) & "jaccard" & Chr(34))
        dctMethod.Add("Jaro or Jaro-Winker Distance", Chr(34) & "jw" & Chr(34))
        dctMethod.Add("Distance based on Soundex Encoding", Chr(34) & "soundex" & Chr(34))
        ucrInputComboBoxMethod.SetItems(dctMethod)
        ucrInputComboBoxMethod.SetRDefault(Chr(34) & "osa" & Chr(34))
        'ucrSave
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
        ucrInputPatternStringDistance.Reset()
        clsStringDistFunction.SetPackageName("stringdist")
        clsStringDistFunction.SetRCommand("stringdist")
        clsStringDistFunction.AddParameter("method", Chr(34) & "osa" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsStringDistFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverStringDistance.IsEmpty() AndAlso Not ucrInputPatternStringDistance.IsEmpty() AndAlso Not ucrInputComboBoxMethod.IsEmpty AndAlso ucrSaveStringDistance.IsComplete() Then
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

    Private Sub UcrReceiverStringDistance_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringDistance.ControlContentsChanged, ucrSaveStringDistance.ControlContentsChanged, ucrInputPatternStringDistance.ControlContentsChanged, ucrInputComboBoxMethod.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class