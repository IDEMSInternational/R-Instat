'R-Instat
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

Public Class dlgCircularRosePlot
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private clsRosePlotFunction As RFunction
    Private Sub dlgCircularRosePlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
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

        Dim dctRadius As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelctorCircularDataFrame.SetParameter(New RParameter("data", 0))
        ucrSelctorCircularDataFrame.SetParameterIsrfunction()

        ucrReceiverVariable.SetParameter(New RParameter("x", 0))
        ucrReceiverVariable.Selector = ucrSelctorCircularDataFrame
        ucrReceiverVariable.SetParameterIsRFunction()

        ucrInputComboRadius.SetParameter(New RParameter("radii.scale", 3))
        dctRadius.Add("sqrt", Chr(34) & "sqrt" & Chr(34))
        dctRadius.Add("linear", Chr(34) & "linear" & Chr(34))
        ucrInputComboRadius.SetItems(dctRadius)


        ucrSaveCircularRosePlot.SetPrefix("circular_rose_plot")
        ucrSaveCircularRosePlot.SetDataFrameSelector(ucrSelctorCircularDataFrame.ucrAvailableDataFrames)
        ucrSaveCircularRosePlot.SetIsComboBox()
        ucrSaveCircularRosePlot.SetCheckBoxText("Save Graph")
        ucrSaveCircularRosePlot.SetSaveTypeAsGraph()
        ucrSaveCircularRosePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsRosePlotFunction = New RFunction

        ucrSelctorCircularDataFrame.Reset()
        ucrSaveCircularRosePlot.Reset()
        ucrReceiverVariable.SetMeAsReceiver()

        clsRosePlotFunction.SetPackageName("circular")
        clsRosePlotFunction.SetRCommand("rose.diag")

        ucrInputBins.SetParameter(New RParameter("bins", 2))
        ucrInputBins.SetValidationTypeAsNumeric()
        ucrInputBins.SetDefaultState(12)
        ucrInputBins.AddQuotesIfUnrecognised = False

        ucrBase.clsRsyntax.SetBaseRFunction(clsRosePlotFunction)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrInputBins.AddAdditionalCodeParameterPair(clsRosePlotFunction, ucrInputBins.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverVariable.SetRCode(clsRosePlotFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrSaveCircularRosePlot.IsComplete AndAlso Not ucrReceiverVariable.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetRCodeForControls(True)
        SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrReceiverVariable.ControlContentsChanged, ucrSaveCircularRosePlot.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class