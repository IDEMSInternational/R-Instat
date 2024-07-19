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

Public Class sdgFlowsToImport
    Private bControlsInitialised As Boolean = False
    Public clsGetFlowFunction As New RFunction
    Public clsModifyOperation As New ROperator
    Public clsOpeningOperator As New ROperator
    Public clsClosingOperator As New ROperator
    Private lstReceivers As New List(Of ucrReceiverSingle)
    Private lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private Sub sdgFlowsToImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Public Sub InitialiseControls()
        Dim kvpName As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("name", {"name"}.ToList())

        lstRecognisedTypes.AddRange({kvpName})
        lstReceivers.AddRange({ucrReceiverName})

        ucrReceiverName.Tag = "Flow Metadata"

        ucrSelectorFlows.SetParameterIsrfunction()

        ucrReceiverName.SetParameter(New RParameter("name", 0, bNewIncludeArgumentName:=False)) ' to left of %in% operator
        ucrReceiverName.SetParameterIsRFunction()
        ucrReceiverName.bWithQuotes = False
        ucrReceiverName.Selector = ucrSelectorFlows
        ucrReceiverName.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverName.SetLinkedDisplayControl(lblFlowName)

        'ucrFactorLevels 
        ucrModifyEventFactor.SetAsMultipleSelectorGrid(ucrReceiverName,
                                                  hiddenColNames:={ucrFactor.DefaultColumnNames.Level},
                                                  bIncludeNALevel:=True)
    End Sub
    Public Sub SetRFunction(clsNewGetFlowFunction As RFunction, clsNewModifyOperation As ROperator, clsNewClosingOperator As ROperator, clsNewOpeningOperator As ROperator, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsGetFlowFunction = clsNewGetFlowFunction
        clsModifyOperation = clsNewModifyOperation
        clsClosingOperator = clsNewClosingOperator
        clsOpeningOperator = clsNewOpeningOperator

        ucrReceiverName.SetRCode(clsModifyOperation, bReset)
        ModifyOptions()
    End Sub

    Private Sub ModifyOptions()
        If Not ucrReceiverName.IsEmpty Then
            ucrModifyEventFactor.Visible = True
            clsModifyOperation.AddParameter("factor_value",
                                                   mdlCoreControl.GetRVector(ucrModifyEventFactor.GetSelectedCellValues(ucrFactor.DefaultColumnNames.Label, True)),
                                                   bIncludeArgumentName:=False, iPosition:=1)
            clsOpeningOperator.AddParameter("left", "name", iPosition:=0)
            clsOpeningOperator.AddParameter("right", clsROperatorParameter:=clsClosingOperator, iPosition:=1)
            clsOpeningOperator.bSpaceAroundOperation = False

            clsClosingOperator.AddParameter("left", clsROperatorParameter:=clsModifyOperation, iPosition:=0)
            clsClosingOperator.AddParameter("right", "", iPosition:=1)
            clsClosingOperator.bSpaceAroundOperation = False

            clsGetFlowFunction.AddParameter("flow_name", clsROperatorParameter:=clsOpeningOperator, iPosition:=0)
        Else
            ucrModifyEventFactor.Visible = False
            clsModifyOperation.RemoveParameterByName("factor_value")
            clsGetFlowFunction.RemoveParameterByName("name")
        End If
    End Sub

    Private Sub ucrReceiverName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverName.ControlValueChanged, ucrModifyEventFactor.ControlValueChanged
        ModifyOptions()
        AutoFillReceivers()
    End Sub

    Private Sub AutoFillReceivers()
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False
        Dim strSelectorVariable As String
        ucrCurrentReceiver = ucrSelectorFlows.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorFlows.lstAvailableVariable.Items
                    strSelectorVariable = Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|", String.Empty)
                    For Each strValue As String In lstRecognisedValues
                        If strSelectorVariable.Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorFlows.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
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

    Private Sub ucrSelectorFlows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorFlows.ControlValueChanged
        AutoFillReceivers()
    End Sub
End Class