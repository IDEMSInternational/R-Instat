' Instat-R
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
Public Class dlgSplitText
    Public bFirstLoad As Boolean = True
    Public clsDefaultFunction As New RFunction

    Private Sub dlgSplitText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim lstPatternPairs As New List(Of KeyValuePair(Of String, String))

        ucrBase.iHelpTopicID = 344

        ucrInputPattern.SetParameter(New RParameter("pattern"))
        lstPatternPairs.Add(New KeyValuePair(Of String, String)("Space ( )", Chr(34) & " " & Chr(34)))
        lstPatternPairs.Add(New KeyValuePair(Of String, String)("Period .", "fixed(" & Chr(34) & "." & Chr(34) & ")"))
        lstPatternPairs.Add(New KeyValuePair(Of String, String)("Comma ,", Chr(34) & "," & Chr(34)))
        lstPatternPairs.Add(New KeyValuePair(Of String, String)("Colon :", Chr(34) & ":" & Chr(34)))
        lstPatternPairs.Add(New KeyValuePair(Of String, String)("Semicolon ;", Chr(34) & ";" & Chr(34)))
        lstPatternPairs.Add(New KeyValuePair(Of String, String)("Hyphen -", Chr(34) & "-" & Chr(34)))
        lstPatternPairs.Add(New KeyValuePair(Of String, String)("Underscore _", Chr(34) & "_" & Chr(34)))
        ucrInputPattern.SetItems(lstPatternPairs)

        ucrReceiverSplitTextColumn.SetParameter(New RParameter("string"))
        ucrReceiverSplitTextColumn.SetParameterIsRFunction()
        ucrReceiverSplitTextColumn.Selector = ucrSelectorSplitTextColumn
        ucrReceiverSplitTextColumn.SetMeAsReceiver()
        ucrReceiverSplitTextColumn.bUseFilteredData = False
        ucrReceiverSplitTextColumn.SetIncludedDataTypes({"factor", "character"})

        ucrSaveColumn.SetIsTextBox()
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorSplitTextColumn.ucrAvailableDataFrames)
        ucrSaveColumn.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        ucrSaveColumn.SetLabelText("Prefix for New Columns:")

        ucrNudPieces.SetParameter(New RParameter("n"))

        clsDefaultFunction.SetRCommand("str_split_fixed")
        clsDefaultFunction.AddParameter("pattern", Chr(34) & "," & Chr(34))
        clsDefaultFunction.AddParameter("n", 2)
        clsDefaultFunction.SetAssignTo(strTemp:="Split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="Split", bAssignToIsPrefix:=True)
    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorSplitTextColumn.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSplitTextColumn.IsEmpty() AndAlso ucrNudPieces.GetText <> "" AndAlso Not ucrInputPattern.IsEmpty AndAlso ucrSaveColumn.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputPattern.ControlContentsChanged, ucrSelectorSplitTextColumn.ControlContentsChanged, ucrReceiverSplitTextColumn.ControlContentsChanged, ucrNudPieces.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class