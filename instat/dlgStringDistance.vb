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
Imports instat
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

        'ucrReceiver
        ucrReceiverStringDistance.SetParameterIsRFunction()
        ucrReceiverStringDistance.Selector = ucrSelectorStringDistance
        ucrReceiverStringDistance.SetMeAsReceiver()
        ucrReceiverStringDistance.SetParameter(New RParameter("a", 0))
        ucrReceiverStringDistance.SetParameterIsString()
        ucrInputPatternStringDistance.SetParameter(New RParameter("b", 1))
        ucrInputPatternStringDistance.AddQuotesIfUnrecognised = True

        ucrInputComboBoxMethod.SetParameter(New RParameter("method", 2))

        Dim dctMethod As New Dictionary(Of String, String)
        dctMethod.Add("Optimal string aligment", Chr(34) & "osa" & Chr(34))
        dctMethod.Add("Levenshtein distance", Chr(34) & "lv" & Chr(34))
        dctMethod.Add("Full Damerau-Levenshtein distance", Chr(34) & "dl" & Chr(34))
        dctMethod.Add("Hamming distance", Chr(34) & "hamming" & Chr(34))
        dctMethod.Add("Longest common substring distance", Chr(34) & "lcs" & Chr(34))
        dctMethod.Add("q-gram distance", Chr(34) & "qgram" & Chr(34))
        dctMethod.Add("cosine distance", Chr(34) & "cosine" & Chr(34))
        dctMethod.Add("jaccard Distance", Chr(34) & "jaccard" & Chr(34))
        dctMethod.Add("Jaro ,or Jaro-Winker distance", Chr(34) & "jw" & Chr(34))
        dctMethod.Add("soundex encoding", Chr(34) & "soundex" & Chr(34))
        ucrInputComboBoxMethod.SetItems(dctMethod)

        'ucrSave
        ucrSaveStringDistance.SetPrefix("string_distance")
        ucrSaveStringDistance.SetSaveTypeAsColumn()
        ucrSaveStringDistance.SetDataFrameSelector(ucrSelectorStringDistance.ucrAvailableDataFrames)
        ucrSaveStringDistance.SetIsTextBox()
        ucrSaveStringDistance.SetLabelText("Save Result")

        clsStringDistFunction.SetAssignTo(ucrSaveStringDistance.GetText, strTempDataframe:=ucrSelectorStringDistance.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveStringDistance.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsStringDistFunction)

    End Sub

    Private Sub SetDefaults()

        clsStringDistFunction = New RFunction
        ucrSelectorStringDistance.Reset()
        ucrInputPatternStringDistance.Reset()
        ucrSaveStringDistance.Reset()
        clsStringDistFunction.SetPackageName("stringdist")
        clsStringDistFunction.SetRCommand("stringdist")
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

    Private Sub UcrReceiverStringDistance_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringDistance.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class