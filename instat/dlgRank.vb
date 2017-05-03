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
Imports instat.Translations

Public Class dlgRank
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgRank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 25

        'Setting Parameters and Data types allowed
        ucrReceiverRank.Selector = ucrSelectorForRank
        ucrReceiverRank.SetMeAsReceiver()
        ucrReceiverRank.SetIncludedDataTypes({"numeric"})
        ucrReceiverRank.bUseFilteredData = False
        ucrReceiverRank.SetParameter(New RParameter("x", 0))
        ucrReceiverRank.SetParameterIsRFunction()

        'Setting Parameters for the respective radio buttons
        ucrPanelTies.SetParameter(New RParameter("ties.method", 1))
        ucrPanelTies.AddRadioButton(rdoAverage, Chr(34) & "average" & Chr(34))
        ucrPanelTies.AddRadioButton(rdoMinimum, Chr(34) & "min" & Chr(34))
        ucrPanelTies.AddRadioButton(rdoMaximum, Chr(34) & "max" & Chr(34))
        ucrPanelTies.AddRadioButton(rdoFirst, Chr(34) & "first" & Chr(34))
        ucrPanelTies.AddRadioButton(rdoRandom, Chr(34) & "random" & Chr(34))
        ucrPanelTies.SetRDefault(Chr(34) & "average" & Chr(34))

        ucrPanelMissingValues.SetParameter(New RParameter("na.last", 2))
        ucrPanelMissingValues.AddRadioButton(rdoKeptAsMissing, Chr(34) & "keep" & Chr(34))
        ucrPanelMissingValues.AddRadioButton(rdoFirstMissingValues, Chr(34) & "FALSE" & Chr(34))
        ucrPanelMissingValues.AddRadioButton(rdoLast, Chr(34) & "TRUE" & Chr(34))
        ucrPanelMissingValues.SetRDefault("TRUE")

        ucrSaveRank.SetPrefix("rank")
        ucrSaveRank.SetSaveTypeAsColumn()
        ucrSaveRank.SetDataFrameSelector(ucrSelectorForRank.ucrAvailableDataFrames)
        ucrSaveRank.SetLabelText("Save Rank:")
        ucrSaveRank.SetIsComboBox()
    End Sub

    'Testing when to Enable the OK button
    Private Sub TestOKEnabled()
        If Not ucrReceiverRank.IsEmpty() AndAlso ucrSaveRank.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    ' Sub that runs only the first time the dialog loads it sets default RFunction as the base function
    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrSelectorForRank.Reset()
        ucrSaveRank.Reset()

        'Setting default Rfunction as the base function
        clsDefaultFunction.SetRCommand("rank")
        clsDefaultFunction.AddParameter("ties.method", Chr(34) & "average" & Chr(34))
        clsDefaultFunction.AddParameter("na.last", Chr(34) & "keep" & Chr(34))
        clsDefaultFunction.SetAssignTo(ucrSaveRank.GetText, strTempDataframe:=ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveRank.GetText, bAssignToIsPrefix:=True)

        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRank.ControlContentsChanged, ucrSaveRank.ControlContentsChanged
        TestOKEnabled()
    End Sub

    'When the reset button is clicked, set the defaults again
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
End Class
