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

Public Class dlgExtremes
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgExtremes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 488
        ucrBase.clsRsyntax.iCallType = 1
        ucrBase.OKEnabled(False) ' temporarily for beta

        'ucrReceiverDataToFit
        ucrReceiverDataToFit.SetParameter(New RParameter("xdat", 0))
        ucrReceiverDataToFit.SetParameterIsRFunction()
        ucrReceiverDataToFit.Selector = ucrAddRemove
        ucrReceiverDataToFit.SetMeAsReceiver()

        'ucrChkRestrictDataValues
        '      ucrInputTo.SetParameter(New RParameter(" "))
        ucrChkRestrictDataValues.SetParameter(ucrInputTo.GetParameter(), bNewChangeParameterValue:=False) ' bNewAddRemoveParameter:=True)
        ucrInputTo.bAddRemoveParameter = False
        ucrInputTo.SetLinkedDisplayControl(lblBetween)
        'set default value

        '        ucrInputFrom.SetParameter(New RParameter(" "))
        ucrChkRestrictDataValues.SetParameter(ucrInputFrom.GetParameter(), bNewChangeParameterValue:=False) ' bNewAddRemoveParameter:=True)
        ucrInputFrom.bAddRemoveParameter = False
        ucrInputFrom.SetLinkedDisplayControl(lblAnd)

        ucrChkRestrictDataValues.SetText("Restrict Data Values")
        ucrChkRestrictDataValues.bChangeParameterValue = False
        ucrChkRestrictDataValues.AddToLinkedControls(ucrLinked:=ucrInputTo, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkRestrictDataValues.AddToLinkedControls(ucrLinked:=ucrInputFrom, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkRestrictDataValues.SetRDefault("FALSE")

        'ucrChkProbabilityPlot
        '        ucrChkProbPlot.SetParameter(New RParameter(" "))
        ucrChkProbPlot.SetText("Probability Plot")
        ucrChkProbPlot.SetRDefault("FALSE")

        'ucrChkMLE
        '        ucrChkMLE.SetParameter(New RParameter(" "))
        ucrChkMLE.SetText("Maximum Likelihood")
        ucrChkMLE.SetRDefault("FALSE")
        ucrChkMLE.SetParameter(ucrInputMLE.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkMLE.AddToLinkedControls(ucrLinked:=ucrInputMLE, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMLE.bAddRemoveParameter = False
        ucrInputMLE.SetLinkedDisplayControl(lblSaveInMLE)

        'ucrChkMOM
        '        ucrChkMOM.SetParameter(New RParameter(" "))
        ucrChkMOM.SetText("Method of Moments")
        ucrChkMOM.SetRDefault("FALSE")
        ucrChkMOM.SetParameter(ucrInputMOM.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkMOM.AddToLinkedControls(ucrLinked:=ucrInputMOM, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMOM.bAddRemoveParameter = False
        ucrInputMOM.SetLinkedDisplayControl(lblSaveInMOM)

        ' not sure if "Save in" for the cbos refers to where to display the output (i.e., output window, column) or something else.
        ' Kept it as cbo for the time being.

        'rdos
        '        ucrPnlDistributions.SetParameter(New RParameter(" "))
        '        ucrPnlDistributions.AddRadioButton(rdoGEV, Chr(34) & "" & Chr(34))
        '        ucrPnlDistributions.AddRadioButton(rdoGumbel, Chr(34) & " " & Chr(34))
        '        ucrPnlDistributions.SetRDefault(Chr(34) & " " & Chr(34)) ' gumbel as default

    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrAddRemove.Reset()

        ucrBase.clsRsyntax.SetFunction("gev.fit")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    'ControlContentsChanged sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
End Class