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

Public Class dlgTraitsXp
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetVarMetadataFunction, clsGetObjectRFunction, clsRankingsItemsFunction,
                  clsPlotNetWorkFunction, clsCFunction As New RFunction
    Private clsGetRankingOperator, clsColNamesOperator As New ROperator
    Private Sub dlgTraitsXp_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrTraitGraphSelector.SetParameter(New RParameter("data_name", 0))
        ucrTraitGraphSelector.SetParameterIsString()

        ucrReceiverTrait.SetParameter(New RParameter("column", 1, bNewIncludeArgumentName:=False))
        ucrReceiverTrait.Selector = ucrTraitGraphSelector
        ucrReceiverTrait.SetParameterIsString()
        ucrReceiverTrait.bAutoFill = True
        ucrReceiverTrait.strSelectorHeading = "Traits"
        ucrReceiverTrait.SetMeAsReceiver()
        ucrReceiverTrait.SetTricotType({"traits"})

        ucrSaveTraits.SetPrefix("trait_plot")
        ucrSaveTraits.SetIsComboBox()
        ucrSaveTraits.SetCheckBoxText("Store Graph")
        ucrSaveTraits.SetSaveTypeAsGraph()
        ucrSaveTraits.SetDataFrameSelector(ucrTraitGraphSelector.ucrAvailableDataFrames)
        ucrSaveTraits.SetAssignToIfUncheckedValue("last_graph")

        ' only needed if cross-platform back-end used
        InitialiseScriptTransformations()

    End Sub

    Private Sub InitialiseScriptTransformations()
        ucrBase.strDialogName = "Traits"

        ucrBase.dctConfigurableValues = New Dictionary(Of String, String) From {
            {"comment", ""},
            {"dataFrame", ""},
            {"graphName", ""},
            {"isComment", ""},
            {"isStoreGraph", ""},
            {"trait", ""}
        }

        ucrBase.lstTransformFromControl = New List(Of clsTransformationControl) From {
            New clsTransformationControl With {.strKey = "comment", .clsControl = ucrBase, .enumTextType = ucrButtons.EnumTextType.comment},
            New clsTransformationControl With {.strKey = "dataFrame", .clsControl = ucrTraitGraphSelector.ucrAvailableDataFrames},
            New clsTransformationControl With {.strKey = "graphName", .clsControl = ucrSaveTraits, .enumTextType = ucrSave.SaveLocation.saveName},
            New clsTransformationControl With {.strKey = "isComment", .clsControl = ucrBase, .enumTextType = ucrButtons.EnumTextType.isComment},
            New clsTransformationControl With {.strKey = "isStoreGraph", .clsControl = ucrSaveTraits, .enumTextType = ucrSave.SaveLocation.isChecked},
            New clsTransformationControl With {.strKey = "trait", .clsControl = ucrReceiverTrait}
        }
    End Sub

    Private Sub SetDefaults()
        clsGetVarMetadataFunction = New RFunction
        clsGetObjectRFunction = New RFunction
        clsRankingsItemsFunction = New RFunction
        clsPlotNetWorkFunction = New RFunction
        clsCFunction = New RFunction
        clsGetRankingOperator = New ROperator
        clsColNamesOperator = New ROperator

        ucrTraitGraphSelector.Reset()
        ucrSaveTraits.Reset()

        clsCFunction.SetRCommand("c")
        clsCFunction.SetAssignTo("col_names")
        Dim strCAssignedScript As String = ""
        clsCFunction.ToScript(strScript:=strCAssignedScript)

        clsGetVarMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVarMetadataFunction.AddParameter("column", clsRFunctionParameter:=clsCFunction, iPosition:=1)
        clsGetVarMetadataFunction.SetAssignTo("get_index_names ")
        Dim strVarMetadataAssignedScript As String = ""
        clsGetVarMetadataFunction.ToScript(strScript:=strVarMetadataAssignedScript)

        clsGetObjectRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsGetObjectRFunction.AddParameter("list", Chr(34) & "rankings_list" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)

        clsGetRankingOperator.SetOperation("$")
        clsGetRankingOperator.AddParameter("left", clsRFunctionParameter:=clsGetObjectRFunction, iPosition:=0)
        clsGetRankingOperator.AddParameter("right", "object")
        clsGetRankingOperator.bSpaceAroundOperation = False
        clsGetRankingOperator.SetAssignTo("rankings_object")
        Dim strGetRankingAssignedScript As String = ""
        clsGetRankingOperator.ToScript(strScript:=strGetRankingAssignedScript)

        clsRankingsItemsFunction.SetRCommand("get_ranking_items")
        clsRankingsItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVarMetadataFunction, iPosition:=0)
        clsRankingsItemsFunction.AddParameter("vars_to_get", "col_names", iPosition:=1)
        clsRankingsItemsFunction.AddParameter("index", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsRankingsItemsFunction.AddParameter("rankings_object", clsROperatorParameter:=clsGetRankingOperator, bIncludeArgumentName:=False, iPosition:=3)
        clsRankingsItemsFunction.SetAssignTo("rankings_object")
        Dim strAssignedScript As String = ""
        clsRankingsItemsFunction.ToScript(strScript:=strAssignedScript)

        clsColNamesOperator.SetOperation("<-")
        clsColNamesOperator.AddParameter("left", "names(rankings_object)")
        clsColNamesOperator.AddParameter("right", "col_names")

        clsPlotNetWorkFunction.iCallType = 3
        clsPlotNetWorkFunction.SetRCommand("plot_network")
        clsPlotNetWorkFunction.AddParameter("rank", "rankings_object[[1]]", bIncludeArgumentName:=False)
        clsPlotNetWorkFunction.SetAssignTo("last_graph", strTempDataframe:=ucrTraitGraphSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsRankingsItemsFunction, 1)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsColNamesOperator, 2)
        ucrBase.clsRsyntax.SetBaseRFunction(clsPlotNetWorkFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrTraitGraphSelector.AddAdditionalCodeParameterPair(clsGetObjectRFunction, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrTraitGraphSelector.SetRCode(clsGetVarMetadataFunction, bReset)
        ucrReceiverTrait.SetRCode(clsCFunction, bReset)
        ucrSaveTraits.SetRCode(clsPlotNetWorkFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverTrait.IsEmpty AndAlso ucrSaveTraits.IsComplete)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTraitGraphSelector.ControlContentsChanged, ucrReceiverTrait.ControlContentsChanged, ucrSaveTraits.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class