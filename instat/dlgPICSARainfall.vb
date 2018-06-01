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
Public Class dlgPICSARainfall
    Public bFirstLoad As Boolean = True
    Private clsRggplotFunction As New RFunction
    Private clsRgeomlineplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bReset As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsGeomSmoothFunc As New RFunction
    Private clsGeomSmoothParameter As New RParameter

    Private Sub dlgPCSARainfall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim clsGeomPointFunc As New RFunction
        Dim clsGeomPointParam As New RParameter

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 118

        ucrPICSARainfallSelector.SetParameter(New RParameter("data", 0))
        ucrPICSARainfallSelector.SetParameterIsrfunction()

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.Selector = ucrPICSARainfallSelector
        ucrReceiverX.strSelectorHeading = "Variables"
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour", 2))
        ucrFactorOptionalReceiver.Selector = ucrPICSARainfallSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorOptionalReceiver.strSelectorHeading = "Factors"
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.SetParameterIsString()

        ucrVariablesAsFactor.SetParameter(New RParameter("y", 1))
        ucrVariablesAsFactor.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactor.Selector = ucrPICSARainfallSelector
        ucrVariablesAsFactor.strSelectorHeading = "Varibles"
        ucrVariablesAsFactor.SetParameterIsString()
        ucrVariablesAsFactor.bWithQuotes = False
        ucrVariablesAsFactor.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariablesAsFactor.bAddParameterIfEmpty = True

        clsGeomPointFunc.SetPackageName("ggplot2")
        clsGeomPointFunc.SetRCommand("geom_point")
        clsGeomPointParam.SetArgumentName("geom_point")
        clsGeomPointParam.SetArgument(clsGeomPointFunc)
        clsGeomPointParam.Position = 3
        ucrChkPoints.SetText("Points")
        ucrChkPoints.SetParameter(clsGeomPointParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsGeomSmoothFunc.SetPackageName("ggplot2")
        clsGeomSmoothFunc.SetRCommand("geom_smooth")
        clsGeomSmoothFunc.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=0)
        clsGeomSmoothFunc.AddParameter("se", "FALSE", iPosition:=1)
        clsGeomSmoothParameter.SetArgumentName("geom_smooth")
        clsGeomSmoothParameter.SetArgument(clsGeomSmoothFunc)

        ucrSave.SetPrefix("lineplot")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
        ucrSave.SetDataFrameSelector(ucrPICSARainfallSelector.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsRggplotFunction = New RFunction
        clsRgeomlineplotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsBaseOperator = New ROperator

        ucrPICSARainfallSelector.Reset()
        ucrPICSARainfallSelector.SetGgplotFunction(clsBaseOperator)
        ucrSave.Reset()
        ucrVariablesAsFactor.SetMeAsReceiver()
        bResetSubdialog = True
        bResetLineLayerSubdialog = True



        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("lineplot", clsRFunctionParameter:=clsRgeomlineplotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
        clsRaesFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=1)

        clsRgeomlineplotFunction.SetPackageName("ggplot2")
        clsRgeomlineplotFunction.SetRCommand("geom_line")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsGeomSmoothFunc.AddParameter("se", "FALSE", iPosition:=1)
        clsBaseOperator.RemoveParameterByName("geom_point")
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrPICSARainfallSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrPICSARainfallSelector.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactor.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkPoints.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrSave.IsComplete OrElse (ucrReceiverX.IsEmpty AndAlso ucrVariablesAsFactor.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs)
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        If ucrVariablesAsFactor.bSingleVariable Then
            cmdPICSAOptions.Enabled = True
        Else
            cmdPICSAOptions.Enabled = False

        End If
    End Sub
    Private Sub UcrVariablesAsFactor_ControlValueChanged() Handles ucrVariablesAsFactor.ControlValueChanged
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    Private Sub AllControl_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrVariablesAsFactor.ControlContentsChanged, ucrSave.ControlContentsChanged
        TestOkEnabled()
    End Sub


    Private Sub cmdPICSAOptions_Click(sender As Object, e As EventArgs) Handles cmdPICSAOptions.Click
        sdgPICSARainfallGraph.ShowDialog()
    End Sub
End Class