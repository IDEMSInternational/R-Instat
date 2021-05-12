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
Public Class dlgStringDistance
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsStringDistFunction As New RFunction
    Private clsColumnFunction As New RFunction
    Private lstRCodeStructure As List(Of RCodeStructure)

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

        ucrReceiverColumn.SetParameter(New RParameter("b", 1))
        ucrReceiverColumn.SetParameterIsRFunction()
        ucrReceiverColumn.Selector = ucrSelectorStringDistance
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumnString)

        ucrInputPatternStringDistance.SetParameter(New RParameter("b", 1))
        ucrInputPatternStringDistance.SetLinkedDisplayControl(lblPattern)

        ucrPnlStringDist.AddRadioButton(rdoString)
        ucrPnlStringDist.AddRadioButton(rdoColumn)

        ucrPnlStringDist.AddParameterIsRFunctionCondition(rdoColumn, "b", True)
        ucrPnlStringDist.AddParameterIsRFunctionCondition(rdoString, "b", False)

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

        ucrSaveStringDistance.SetPrefix("dist")
        ucrSaveStringDistance.SetSaveTypeAsColumn()
        ucrSaveStringDistance.SetDataFrameSelector(ucrSelectorStringDistance.ucrAvailableDataFrames)
        ucrSaveStringDistance.SetIsComboBox()
        ucrSaveStringDistance.SetLabelText("Save Result:")
        ucrSaveStringDistance.setLinkedReceiver(ucrReceiverStringDistance)
    End Sub

    Private Sub ResetFunctions()
        clsStringDistFunction = New RFunction
        clsColumnFunction = New RFunction

        clsColumnFunction.SetPackageName("stringdist")
        clsColumnFunction.SetRCommand("stringdist")

        clsStringDistFunction.SetPackageName("stringdist")
        clsStringDistFunction.SetRCommand("stringdist")

        ucrBase.clsRsyntax.SetBaseRFunction(clsStringDistFunction)
    End Sub

    Private Sub SetDefaults()
        ucrSelectorStringDistance.Reset()
        ucrSaveStringDistance.Reset()
        ucrReceiverStringDistance.SetMeAsReceiver()

        ResetFunctions()

        If Not IsNothing(lstRCodeStructure) Then
            If (lstRCodeStructure.Count > 1) Then
                MsgBox("Developer error: List of RCodeStructure must have only one RFunction")
            ElseIf lstRCodeStructure.Count = 1 Then
                If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction)) Then
                    If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction).GetParameter("b")) Then
                        If TryCast(lstRCodeStructure(0), RFunction).GetParameter("b").bIsFunction Then
                            clsColumnFunction = lstRCodeStructure(0)
                            If Not IsNothing(clsColumnFunction.GetParameter("a")) Then
                                clsStringDistFunction.AddParameter(clsColumnFunction.GetParameter("a"))
                            End If
                            If Not IsNothing(clsColumnFunction.GetParameter("method")) Then
                                clsStringDistFunction.AddParameter(clsColumnFunction.GetParameter("method"))
                            End If
                            ucrBase.clsRsyntax.SetBaseRFunction(clsColumnFunction)
                        Else
                                clsStringDistFunction = lstRCodeStructure(0)
                            ucrBase.clsRsyntax.SetBaseRFunction(clsStringDistFunction)
                        End If
                    Else
                        MsgBox("Developer error: The RFunction has no parameter b")
                    End If
                End If
            End If
        End If
        lstRCodeStructure = Nothing
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStringDistance.AddAdditionalCodeParameterPair(clsColumnFunction, New RParameter("a", 0), iAdditionalPairNo:=1)
        ucrInputComboBoxMethod.AddAdditionalCodeParameterPair(clsColumnFunction, clsNewRParameter:=New RParameter("method", 2), iAdditionalPairNo:=1)
        ucrSaveStringDistance.AddAdditionalRCode(clsColumnFunction, iAdditionalPairNo:=1)

        ucrReceiverStringDistance.SetRCode(clsStringDistFunction, bReset)
        ucrInputPatternStringDistance.SetRCode(clsStringDistFunction, bReset)
        ucrInputComboBoxMethod.SetRCode(clsStringDistFunction, bReset)
        ucrSaveStringDistance.SetRCode(clsStringDistFunction, bReset)

        ucrPnlStringDist.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrReceiverColumn.SetRCode(clsColumnFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverStringDistance.IsEmpty() AndAlso ucrSaveStringDistance.IsComplete() AndAlso Not ucrInputComboBoxMethod.IsEmpty AndAlso ((rdoColumn.Checked AndAlso Not ucrReceiverColumn.IsEmpty()) OrElse (rdoString.Checked AndAlso Not ucrInputPatternStringDistance.IsEmpty())) Then
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

    Private Sub ReceiverFocus()
        If rdoString.Checked Then
            ucrReceiverStringDistance.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrPnlStringDist_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStringDist.ControlValueChanged
        ReceiverFocus()
        If rdoColumn.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsColumnFunction)
        ElseIf rdoString.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsStringDistFunction)
        End If
    End Sub

    Private Sub ucrReceiverStringDistance_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringDistance.ControlContentsChanged, ucrReceiverColumn.ControlContentsChanged, ucrSaveStringDistance.ControlContentsChanged, ucrInputPatternStringDistance.ControlContentsChanged, ucrInputComboBoxMethod.ControlContentsChanged, ucrPnlStringDist.ControlContentsChanged
        TestOkEnabled()
    End Sub
    Public Property lstScriptsRCodeStructure As List(Of RCodeStructure)
        Get
            Return lstRCodeStructure
        End Get
        Set(lstNewRCodeStructure As List(Of RCodeStructure))
            lstRCodeStructure = lstNewRCodeStructure
            bReset = True
        End Set
    End Property
End Class