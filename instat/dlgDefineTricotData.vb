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
Imports System.Text.RegularExpressions
Imports RDotNet
Public Class dlgDefineTricotData
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private lstReceiversLevelID, lstReceiversVarityLevel, lstReceiversIDVarietyLevel As New List(Of ucrReceiverSingle)
    Private lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Private clsGetColumnSelection, clsUnameFunction, clsCreateRankingFunction, clsGroupRankingFunction,
        clsGetDataFrameFunction, clsAddRankingObjFunction, clsAddGrpRankingObjFunction As New RFunction
    Private clsDATIDLevelFunction, clsDATVarietyLevelFunction, clsDATIDVarietyFunction As New RFunction
    Private clsAnyDuplicatesFunction, clsVarietyDuplicatesFunction, clsIDVarietyDuplicatesFunction, clsConcFunction, clsNewConcFunction, clsGetColFunction, clsDummyFunction As New RFunction
    Private clsCDATIDLevelFunction, cslCDATVarietyLevelFunction, clsCDATIDLevelVarietiesFunction, clsCDATIDLevelTraitsFunction As New RFunction
    Private clsOperator As New ROperator
    Private bIsUnique As Boolean = True

    Private strCurrentDataframeName As String

    Private Sub dlgDefineTricotData_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        ucrBase.iHelpTopicID = 672

        Dim kvpID As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("id", {"id", "ID", "participant_id", "participant_name"}.ToList())
        Dim kvpLongitude As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("longitude", {"lon", "long", "lont", "longitude", "Longitude", "Lon"}.ToList())
        Dim kvpLatitude As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("latitude", {"lat", "latitude", "Lat", "Latitude"}.ToList())
        Dim kvpPlantingDate As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("planting_date", {"planting_date", "Planting_date", "plantingdate"}.ToList())
        Dim kvpTraits As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("traits", {"overall", "overall_perf", "Overall"}.ToList())
        Dim kvpVariety As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("variety", {"item", "items", "variety", "varieties"}.ToList())


        lstRecognisedTypes.AddRange({kvpID, kvpLongitude, kvpLatitude, kvpPlantingDate, kvpTraits, kvpVariety})
        lstReceiversLevelID.AddRange({ucrReceiverLevelID, ucrReceiverLevelLatitude, ucrReceiverLevelLongitude, ucrReceiverLevelPlantingDate})
        lstReceiversVarityLevel.AddRange({ucrReceiverVarietyLevelVariety})
        lstReceiversIDVarietyLevel.AddRange({ucrReceiverIDVarietyLevelID, ucrReceiverIDVarietyLevelVariety})

        ucrSelectorIDLevelData.SetParameter(New RParameter("data_name", 0))
        ucrSelectorIDLevelData.SetParameterIsString()

        'ID Level Data (run by the top groupbox)
        ucrReceiverLevelOverallTraits.SetParameter(New RParameter("traits", 5))
        ucrReceiverLevelOverallTraits.Selector = ucrSelectorIDLevelData
        ucrReceiverLevelOverallTraits.SetParameterIsString()
        ucrReceiverLevelOverallTraits.strSelectorHeading = "Variables"

        ucrReceiverLevelVarieties.SetParameter(New RParameter("varieties", 1))
        ucrReceiverLevelVarieties.Selector = ucrSelectorIDLevelData
        ucrReceiverLevelVarieties.SetParameterIsString()
        ucrReceiverLevelVarieties.strSelectorHeading = "Variables"
        SetRSelector(ucrSelectorIDLevelData, lstReceiversLevelID)

        'Variety Level Data (run by the middle groupbox)
        ucrSelectorVarietyLevelData.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVarietyLevelData.SetParameterIsString()

        ucrReceiverVarietyLevelVariety.SetParameter(New RParameter("key_col_names", 1))
        ucrReceiverVarietyLevelVariety.Selector = ucrSelectorVarietyLevelData
        ucrReceiverVarietyLevelVariety.SetParameterIsString()
        ucrReceiverVarietyLevelVariety.strSelectorHeading = "Id"


        'ID-Variety Level Data (run by the middle groupbox)
        ucrSelectorIDVarietyLevel.SetParameter(New RParameter("data_name", 0))
        ucrSelectorIDVarietyLevel.SetParameterIsString()

        SetRSelector(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
        ucrReceiverIDVarietyLevelTraits.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverIDVarietyLevelTraits.SetParameter(New RParameter("traits", 2))
        ucrReceiverIDVarietyLevelTraits.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverIDVarietyLevelTraits.SetParameterIsString()
        ucrReceiverIDVarietyLevelTraits.strSelectorHeading = "Id"

    End Sub

    Private Sub SetDefaults()
        clsDATIDLevelFunction = New RFunction
        clsDATIDVarietyFunction = New RFunction
        clsDATVarietyLevelFunction = New RFunction
        clsCDATIDLevelFunction = New RFunction
        clsCDATIDLevelVarietiesFunction = New RFunction
        clsCDATIDLevelTraitsFunction = New RFunction
        cslCDATVarietyLevelFunction = New RFunction
        clsGetColumnSelection = New RFunction
        clsUnameFunction = New RFunction
        clsCreateRankingFunction = New RFunction
        clsGroupRankingFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsAddRankingObjFunction = New RFunction
        clsAddGrpRankingObjFunction = New RFunction
        clsOperator = New ROperator
        clsAnyDuplicatesFunction = New RFunction
        clsIDVarietyDuplicatesFunction = New RFunction
        clsVarietyDuplicatesFunction = New RFunction
        clsGetColFunction = New RFunction

        ucrReceiverLevelID.SetMeAsReceiver()

        clsCDATIDLevelFunction.SetRCommand("c")
        clsCDATIDLevelVarietiesFunction.SetRCommand("c")
        cslCDATVarietyLevelFunction.SetRCommand("c")
        clsCDATIDLevelTraitsFunction.SetRCommand("c")

        clsDATIDLevelFunction.SetRCommand("data_book$define_as_tricot")
        clsDATIDLevelFunction.AddParameter("types", clsRFunctionParameter:=clsCDATIDLevelFunction, iPosition:=2)
        clsDATIDLevelFunction.AddParameter("auto_selection", "TRUE", iPosition:=4)
        clsDATIDLevelFunction.iCallType = 2

        clsDATVarietyLevelFunction.SetRCommand("data_book$define_as_tricot")
        clsDATVarietyLevelFunction.AddParameter("types", clsRFunctionParameter:=cslCDATVarietyLevelFunction, iPosition:=2)
        clsDATVarietyLevelFunction.AddParameter("auto_selection", "TRUE", iPosition:=3)
        clsDATVarietyLevelFunction.iCallType = 2

        clsDATIDVarietyFunction.SetRCommand("data_book$define_as_tricot")
        clsDATIDVarietyFunction.AddParameter("key_col_names", clsRFunctionParameter:=clsCDATIDLevelTraitsFunction, iPosition:=1)
        clsDATIDVarietyFunction.AddParameter("types", clsRFunctionParameter:=clsCDATIDLevelVarietiesFunction, iPosition:=2)
        clsDATIDVarietyFunction.AddParameter("auto_selection", "TRUE", iPosition:=3)
        clsDATIDVarietyFunction.iCallType = 2

        clsGetColumnSelection.SetRCommand("data_book$get_column_selection")
        clsGetColumnSelection.AddParameter("name", Chr(34) & "traits_selection" & Chr(34), iPosition:=1)
        clsGetColumnSelection.SetAssignTo("traits")
        clsGetColumnSelection.ToScript(strScript:="")

        clsOperator.SetOperation("$")
        clsOperator.AddParameter("left", clsRFunctionParameter:=clsGetColumnSelection)
        clsOperator.AddParameter("right", "conditions$C0$parameters$x")
        clsOperator.bSpaceAroundOperation = False

        clsUnameFunction.SetRCommand("unname")
        clsUnameFunction.AddParameter("param", clsROperatorParameter:=clsOperator, bIncludeArgumentName:=False)
        clsUnameFunction.SetAssignTo("traits")
        clsUnameFunction.ToScript(strScript:="")

        clsGetDataFrameFunction.SetRCommand("data_book$get_data_frame")

        clsCreateRankingFunction.SetPackageName("instatExtras")
        clsCreateRankingFunction.SetRCommand("create_rankings_list")
        clsCreateRankingFunction.AddParameter("data", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
        clsCreateRankingFunction.AddParameter("traits", clsRFunctionParameter:=clsUnameFunction, iPosition:=1)
        clsCreateRankingFunction.AddParameter("flag", "FALSE", iPosition:=4, bIncludeArgumentName:=False)
        clsCreateRankingFunction.SetAssignTo("rankings_list")
        clsCreateRankingFunction.ToScript(strScript:="")

        clsGroupRankingFunction.SetPackageName("instatExtras")
        clsGroupRankingFunction.SetRCommand("create_rankings_list")
        clsGroupRankingFunction.AddParameter("traits", "traits", iPosition:=1)
        clsGroupRankingFunction.AddParameter("flag", "TRUE", iPosition:=4, bIncludeArgumentName:=False)
        clsGroupRankingFunction.SetAssignTo("grouped_rankings_list")
        clsGroupRankingFunction.ToScript(strScript:="")

        clsAddRankingObjFunction.SetRCommand("data_book$add_object")
        clsAddRankingObjFunction.AddParameter("object_name", Chr(34) & "rankings_list" & Chr(34), iPosition:=1)
        clsAddRankingObjFunction.AddParameter("object_type_label", Chr(34) & "structure" & Chr(34), iPosition:=2)
        clsAddRankingObjFunction.AddParameter("object_format", Chr(34) & "text" & Chr(34), iPosition:=3)
        clsAddRankingObjFunction.AddParameter("object", clsRFunctionParameter:=clsCreateRankingFunction, iPosition:=4)

        clsAddGrpRankingObjFunction.SetRCommand("data_book$add_object")
        clsAddGrpRankingObjFunction.AddParameter("object_name", Chr(34) & "grouped_rankings_list" & Chr(34), iPosition:=1)
        clsAddGrpRankingObjFunction.AddParameter("object_type_label", Chr(34) & "structure" & Chr(34), iPosition:=2)
        clsAddGrpRankingObjFunction.AddParameter("object_format", Chr(34) & "text" & Chr(34), iPosition:=3)
        clsAddGrpRankingObjFunction.AddParameter("object", clsRFunctionParameter:=clsGroupRankingFunction, iPosition:=4)

        clsAnyDuplicatesFunction.SetRCommand("anyDuplicated")
        clsAnyDuplicatesFunction.AddParameter("x", clsRFunctionParameter:=clsGetColFunction)

        clsVarietyDuplicatesFunction.SetRCommand("anyDuplicated")
        clsVarietyDuplicatesFunction.AddParameter("x", clsRFunctionParameter:=clsGetColFunction)

        clsIDVarietyDuplicatesFunction.SetRCommand("anyDuplicated")
        clsIDVarietyDuplicatesFunction.AddParameter("x", clsRFunctionParameter:=clsGetColFunction)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsDATIDLevelFunction, 1)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsDATVarietyLevelFunction, 2)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsDATIDVarietyFunction, 3)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAddRankingObjFunction, 4)
        ucrBase.clsRsyntax.SetBaseRFunction(clsAddGrpRankingObjFunction)
        clsGetColFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColFunction.AddParameter("data_name", Chr(34) & strCurrentDataframeName & Chr(34))
        clsGetColFunction.AddParameter("col_names", clsRFunctionParameter:=clsConcFunction)

        AutoFillReceivers(ucrSelectorIDLevelData, lstReceiversLevelID)
        AutoFillReceivers(ucrSelectorVarietyLevelData, lstReceiversVarityLevel)
        AutoFillReceivers(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorIDVarietyLevel.AddAdditionalCodeParameterPair(clsGetColumnSelection, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrSelectorIDVarietyLevel.AddAdditionalCodeParameterPair(clsGetDataFrameFunction, New RParameter("data_name", 0), iAdditionalPairNo:=2)
        ucrSelectorIDVarietyLevel.AddAdditionalCodeParameterPair(clsAddGrpRankingObjFunction, New RParameter("data_name", 0), iAdditionalPairNo:=3)
        ucrSelectorIDVarietyLevel.AddAdditionalCodeParameterPair(clsAddRankingObjFunction, New RParameter("data_name", 0), iAdditionalPairNo:=4)
        ucrReceiverLevelID.AddAdditionalCodeParameterPair(clsDATIDLevelFunction, New RParameter("key_col_names", 1), iAdditionalPairNo:=1)
        ucrReceiverVarietyLevelVariety.AddAdditionalCodeParameterPair(cslCDATVarietyLevelFunction, New RParameter("variety", 0), iAdditionalPairNo:=1)
        ucrReceiverIDVarietyLevelID.AddAdditionalCodeParameterPair(clsCDATIDLevelTraitsFunction, New RParameter("id", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverIDVarietyLevelVariety.AddAdditionalCodeParameterPair(clsCDATIDLevelTraitsFunction, New RParameter("variety", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverIDVarietyLevelVariety.AddAdditionalCodeParameterPair(clsCreateRankingFunction, New RParameter("variety", 2), iAdditionalPairNo:=2)
        ucrReceiverIDVarietyLevelID.AddAdditionalCodeParameterPair(clsCreateRankingFunction, New RParameter("id", 3), iAdditionalPairNo:=2)
        ucrReceiverIDVarietyLevelVariety.AddAdditionalCodeParameterPair(clsGroupRankingFunction, New RParameter("variety", 2), iAdditionalPairNo:=3)
        ucrReceiverIDVarietyLevelID.AddAdditionalCodeParameterPair(clsGroupRankingFunction, New RParameter("id", 3), iAdditionalPairNo:=3)

        ucrSelectorIDLevelData.SetRCode(clsDATIDLevelFunction, bReset)
        ucrReceiverLevelID.SetRCode(clsCDATIDLevelFunction, bReset)
        ucrReceiverLevelLatitude.SetRCode(clsCDATIDLevelFunction, bReset)
        ucrReceiverLevelLongitude.SetRCode(clsCDATIDLevelFunction, bReset)
        ucrReceiverLevelPlantingDate.SetRCode(clsCDATIDLevelFunction, bReset)
        ucrReceiverLevelOverallTraits.SetRCode(clsCDATIDLevelFunction, bReset)
        ucrReceiverLevelVarieties.SetRCode(clsCDATIDLevelFunction, bReset)

        ucrSelectorVarietyLevelData.SetRCode(clsDATVarietyLevelFunction, bReset)
        ucrReceiverVarietyLevelVariety.SetRCode(clsDATVarietyLevelFunction, bReset)

        ucrSelectorIDVarietyLevel.SetRCode(clsDATIDVarietyFunction, bReset)
        ucrReceiverIDVarietyLevelID.SetRCode(clsCDATIDLevelVarietiesFunction, bReset)
        ucrReceiverIDVarietyLevelVariety.SetRCode(clsCDATIDLevelVarietiesFunction, bReset)
        ucrReceiverIDVarietyLevelTraits.SetRCode(clsCDATIDLevelVarietiesFunction, bReset)
    End Sub

    Private Sub SetRSelector(sender As ucrSelectorByDataFrameAddRemove, lstReceivers As List(Of ucrReceiverSingle))
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetParameter(New RParameter(ucrTempReceiver.Tag))
            ucrTempReceiver.Selector = sender
            ucrTempReceiver.SetParameterIsString()
            ucrTempReceiver.bExcludeFromSelector = True
        Next
    End Sub

    Private Sub AutoFillReceivers(sender As ucrSelectorByDataFrameAddRemove, lstReceivers As List(Of ucrReceiverSingle))
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        If lstReceivers.Count = 0 Then
            Exit Sub
        End If

        ucrCurrentReceiver = sender.CurrentReceiver
        Dim strData As String = sender.strCurrentDataFrame
        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In sender.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, strData)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If
    End Sub

    Private Function GetRecognisedValues(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Public Function AreAllDataframessDifferent(strData1 As String, strData2 As String, strData3 As String) As Boolean
        Return (strData1 <> strData2) AndAlso (strData1 <> strData3) AndAlso (strData2 <> strData3)
    End Function


    Private Sub TestOKEnabled()
        Dim bDataFramesDifferent As Boolean = AreAllDataframessDifferent(
        ucrSelectorIDLevelData.strCurrentDataFrame,
        ucrSelectorIDVarietyLevel.strCurrentDataFrame,
        ucrSelectorVarietyLevelData.strCurrentDataFrame
    )
        ucrBase.OKEnabled(Not ucrReceiverIDVarietyLevelID.IsEmpty AndAlso
                          Not ucrReceiverIDVarietyLevelVariety.IsEmpty AndAlso
                          Not ucrReceiverIDVarietyLevelTraits.IsEmpty AndAlso Not ucrReceiverVarietyLevelVariety.IsEmpty AndAlso
                          Not ucrReceiverLevelID.IsEmpty AndAlso bDataFramesDifferent)
    End Sub
    Private Sub ucrSelectorVarietyLevelData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorVarietyLevelData.ControlValueChanged
        AutoFillReceivers(ucrSelectorVarietyLevelData, lstReceiversVarityLevel)
    End Sub

    Private Sub ucrSelectorIDVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorIDVarietyLevel.ControlValueChanged
        AutoFillReceivers(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
        Dim strDataName As String = ucrSelectorIDVarietyLevel.strCurrentDataFrame
        clsGetDataFrameFunction.SetAssignTo(strDataName)
        clsGetDataFrameFunction.ToScript(strScript:="")

        clsGroupRankingFunction.AddParameter("data", strDataName, iPosition:=0)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverIDVarietyLevelID.ControlContentsChanged, ucrReceiverIDVarietyLevelVariety.ControlContentsChanged, ucrReceiverIDVarietyLevelTraits.ControlContentsChanged, ucrReceiverVarietyLevelVariety.ControlContentsChanged, ucrReceiverVarietyLevelVariety.ControlContentsChanged, ucrSelectorIDLevelData.ControlContentsChanged, ucrSelectorIDVarietyLevel.ControlContentsChanged, ucrSelectorVarietyLevelData.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub btnckeckduplicatesIDLevel_Click(sender As Object, e As EventArgs) Handles btnckeckduplicatesIDLevel.Click
        Dim iAnyDuplicated As Integer

        Try
            iAnyDuplicated = frmMain.clsRLink.RunInternalScriptGetValue(clsAnyDuplicatesFunction.ToScript()).AsInteger(0)
        Catch ex As Exception
            iAnyDuplicated = -1
        End Try

        If iAnyDuplicated = -1 Then
            ucrInputCheckInputIDLevel.SetName("Developer error! Could not check uniqueness.")
            ucrInputCheckInputIDLevel.txtInput.BackColor = Color.Yellow
            bIsUnique = False
        ElseIf iAnyDuplicated > 0 Then
            ucrInputCheckInputIDLevel.SetName("")
            ucrInputCheckInputIDLevel.txtInput.BackColor = Color.LightCoral
            bIsUnique = False
            If ucrReceiverLevelID.IsEmpty Then
                ucrInputCheckInputIDVarietyLevel.SetName("Duplicate ID's found.")
                MsgBox("You have multiple rows with the same ID.", MsgBoxStyle.Information, Title:="Duplicates")
            Else
                ucrInputCheckInputIDVarietyLevel.SetName("Duplicate ID were found.")
                MsgBox("You have multiple rows with the same ID's.", MsgBoxStyle.Information, Title:="Duplicates")
            End If
        Else
            ucrInputCheckInputIDLevel.SetName("No duplicate ID.")
            ucrInputCheckInputIDLevel.txtInput.BackColor = Color.LightGreen
            bIsUnique = True
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorIDLevelData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorIDLevelData.ControlValueChanged
        strCurrentDataframeName = ucrSelectorIDLevelData.strCurrentDataFrame
        clsGetColFunction.AddParameter("data_name", Chr(34) & strCurrentDataframeName & Chr(34), iPosition:=0)
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLevelID.ControlValueChanged, ucrReceiverLevelID.ControlContentsChanged
        'EnableDisableCheckUniqueBtn()
        If Not ucrReceiverLevelID.IsEmpty Then
            clsConcFunction.AddParameter("x1", ucrReceiverLevelID.GetVariableNames, bIncludeArgumentName:=False)
        Else
            clsConcFunction.RemoveParameterByName("x1")
        End If
    End Sub


    Private Sub btncheckduplicatesvarietylevel_Click(sender As Object, e As EventArgs) Handles btncheckduplicatesvarietylevel.Click
        Dim iAnyDuplicated As Integer

        Try
            iAnyDuplicated = frmMain.clsRLink.RunInternalScriptGetValue(clsVarietyDuplicatesFunction.ToScript()).AsInteger(0)
        Catch ex As Exception
            iAnyDuplicated = -1
        End Try

        If iAnyDuplicated = -1 Then
            ucrInputCheckInputVarietyLevel.SetName("Developer error! Could not check uniqueness.")
            ucrInputCheckInputVarietyLevel.txtInput.BackColor = Color.Yellow
            bIsUnique = False
        ElseIf iAnyDuplicated > 0 Then
            ucrInputCheckInputVarietyLevel.SetName("")
            ucrInputCheckInputVarietyLevel.txtInput.BackColor = Color.LightCoral
            bIsUnique = False
            If ucrReceiverVarietyLevelVariety.IsEmpty Then
                ucrInputCheckInputIDVarietyLevel.SetName("Duplicate varieties found.")
                MsgBox("You have multiple rows with the same varieties.", MsgBoxStyle.Information, Title:="Duplicates")
            Else
                ucrInputCheckInputIDVarietyLevel.SetName("Duplicate varieties were found.")
                MsgBox("You have multiple rows with the same varieties.", MsgBoxStyle.Information, Title:="Duplicates")
            End If
        Else
            ucrInputCheckInputVarietyLevel.SetName("No duplicate varieties.")
            ucrInputCheckInputVarietyLevel.txtInput.BackColor = Color.LightGreen
            bIsUnique = True
        End If
        TestOKEnabled()
    End Sub

    Private Sub btncheckduplicatesIDVarietyLevel_Click(sender As Object, e As EventArgs) Handles btncheckduplicatesIDVarietyLevel.Click
        Dim iAnyDuplicated As Integer

        Try
            iAnyDuplicated = frmMain.clsRLink.RunInternalScriptGetValue(clsIDVarietyDuplicatesFunction.ToScript()).AsInteger(0)
        Catch ex As Exception
            iAnyDuplicated = -1
        End Try

        If iAnyDuplicated = -1 Then
            ucrInputCheckInputIDVarietyLevel.SetName("Developer error! Could not check uniqueness.")
            ucrInputCheckInputIDVarietyLevel.txtInput.BackColor = Color.Yellow
            bIsUnique = False
        ElseIf iAnyDuplicated > 0 Then
            ucrInputCheckInputIDVarietyLevel.SetName("")
            ucrInputCheckInputIDVarietyLevel.txtInput.BackColor = Color.LightCoral
            bIsUnique = False
            If ucrReceiverIDVarietyLevelID.IsEmpty Then
                ucrInputCheckInputIDVarietyLevel.SetName("Duplicate ID-Variety combination found.")
                MsgBox("You have multiple rows with the same ID-Variety combination.", MsgBoxStyle.Information, Title:="Duplicates")
            Else
                ucrInputCheckInputIDVarietyLevel.SetName("Duplicate ID-Variety combination were found.")
                MsgBox("You have multiple rows with the same ID-Variety combination.", MsgBoxStyle.Information, Title:="Duplicates")
            End If
        Else
            ucrInputCheckInputIDVarietyLevel.SetName("No duplicate ID-Variety combination.")
            ucrInputCheckInputIDVarietyLevel.txtInput.BackColor = Color.LightGreen
            bIsUnique = True
        End If
        TestOKEnabled()
    End Sub

End Class