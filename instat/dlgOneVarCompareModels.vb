' R-Instat 
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

Public Class dlgOneVarCompareModels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsGofStat, clsReceiver, clsRAsDataFrame, clsCdfcompFunction, clsDenscompFunction, clsQqcompFunction, clsPpcompFunction As New RFunction
    Private clsChisqtableOperator, clsChisqbreaksOperator As New ROperator

    Private Sub dlgOneVarCompareModels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 174
        ucrBase.clsRsyntax.iCallType = 2

        'ucrReceiver
        ucrReceiverCompareModels.SetParameter(New RParameter("f", 0))
        ucrReceiverCompareModels.SetParameterIsRFunction()
        ucrReceiverCompareModels.Selector = ucrSelectorOneVarCompModels
        ucrReceiverCompareModels.SetMeAsReceiver()
        ucrReceiverCompareModels.SetItemType("model")
    End Sub

    Private Sub SetDefaults()
        clsGofStat = New RFunction
        clsPpcompFunction = New RFunction
        clsReceiver = New RFunction
        clsDenscompFunction = New RFunction
        clsQqcompFunction = New RFunction
        clsQqcompFunction = New RFunction
        clsChisqbreaksOperator = New ROperator
        clsChisqtableOperator = New ROperator

        ucrSelectorOneVarCompModels.Reset()

        clsGofStat.SetPackageName("fitdistrplus")
        clsGofStat.SetRCommand("gofstat")
        clsGofStat.iCallType = 3

        clsCdfcompFunction.SetPackageName("fitdistrplus")
        clsCdfcompFunction.SetRCommand("cdfcomp")
        clsCdfcompFunction.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
        clsCdfcompFunction.iCallType = 3

        clsPpcompFunction.SetPackageName("fitdistrplus")
        clsPpcompFunction.SetRCommand("ppcomp")
        clsPpcompFunction.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
        clsPpcompFunction.iCallType = 3

        clsQqcompFunction.SetPackageName("fitdistrplus")
        clsQqcompFunction.SetRCommand("qqcomp")
        clsQqcompFunction.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
        clsQqcompFunction.iCallType = 3

        clsDenscompFunction.SetPackageName("fitdistrplus")
        clsDenscompFunction.SetRCommand("denscomp")
        clsDenscompFunction.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
        clsDenscompFunction.iCallType = 3

        clsChisqtableOperator.SetOperation("$")
        clsChisqtableOperator.AddParameter(clsRFunctionParameter:=clsGofStat, iPosition:=0)
        clsChisqtableOperator.AddParameter(strParameterValue:="chisqtable", iPosition:=1)

        clsChisqbreaksOperator.SetOperation("$")
        clsChisqbreaksOperator.AddParameter(clsRFunctionParameter:=clsGofStat, iPosition:=0)
        clsChisqbreaksOperator.AddParameter(strParameterValue:="chisqbreaks", iPosition:=1)
        clsChisqbreaksOperator.iCallType = 2

        clsRAsDataFrame.SetRCommand("as.data.frame")
        clsRAsDataFrame.AddParameter("x", clsROperatorParameter:=clsChisqtableOperator)

        clsRAsDataFrame.SetAssignTo(ucrSelectorOneVarCompModels.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_ChiSquare", strTempDataframe:=ucrSelectorOneVarCompModels.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToAfterCodes(clsCdfcompFunction, iPosition:=0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsGofStat)
        bResetSubdialog = True
    End Sub

    'Only distributions that can be accepted into the receiver have to be from the same variable
    ' If variable from variablex is selected then
    ' variables not fromvariablex cannot be in dataframe

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverCompareModels.SetRCode(clsGofStat, bReset)
        ucrReceiverCompareModels.AddAdditionalCodeParameterPair(clsCdfcompFunction, New RParameter("ft", 0), iAdditionalPairNo:=1)
        ucrReceiverCompareModels.AddAdditionalCodeParameterPair(clsPpcompFunction, New RParameter("ft", 0), iAdditionalPairNo:=2)
        ucrReceiverCompareModels.AddAdditionalCodeParameterPair(clsQqcompFunction, New RParameter("ft", 0), iAdditionalPairNo:=3)
        ucrReceiverCompareModels.AddAdditionalCodeParameterPair(clsDenscompFunction, New RParameter("ft", 0), iAdditionalPairNo:=4)
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverCompareModels.IsEmpty Then
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

    Private Sub ucrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCompareModels.ControlValueChanged
        If ucrReceiverCompareModels.IsEmpty Then
            cmdDisplayObjects.Enabled = False
        Else
            cmdDisplayObjects.Enabled = True
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayObjects_Click(sender As Object, e As EventArgs) Handles cmdDisplayObjects.Click
        sdgOneVarCompareModels.SetRCode(ucrBase.clsRsyntax, clsGofStat, clsDenscompFunction, clsCdfcompFunction, clsQqcompFunction, clsPpcompFunction, clsRAsDataFrame, clsChisqtableOperator, clsChisqbreaksOperator, bResetSubdialog)
        sdgOneVarCompareModels.ShowDialog()
        bResetSubdialog = False
    End Sub
End Class


