﻿' Instat-R
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

Public Class dlgOneVariableGraph
    Private bFirstLoad As Boolean = True
    Private clsDefaultRFunction As New RFunction

    Private Sub dlgOneVariableGraph_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction.Clone())
        ' Link the base function to the sub dialog
        sdgOneVarGraph.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction)
        ' Update the main dialog controls from base function
        UpdateControls(Me, ucrBase.clsRsyntax.clsBaseFunction)
        ' Controls may have changed values before InitialiseDialog was run so need to correctly update RCode too
        UpdateRCode(Me, ucrBase.clsRsyntax.clsBaseFunction)
        ucrSelectorOneVarGraph.Reset()
        ucrSelectorOneVarGraph.Focus()
        ucrOneVarGraphSave.Reset()
        'rdoFacets.Checked = True
        ucrOneVarGraphSave.Reset()
        ucrOneVarGraphSave.strPrefix = "OneVariableGraph"

        'Will be removed when we have new radio button user control
        rdoFacets.Checked = True

        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'Define the default RFunction
        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$graph_one_variable")
        clsDefaultRFunction.AddParameter("numeric", Chr(34) & "violin_jitter" & Chr(34))
        clsDefaultRFunction.AddParameter("categorical", Chr(34) & "geom_bar" & Chr(34))
        'This currently has no effect on controls as there is no radio button user control yet
        clsDefaultRFunction.AddParameter("output", Chr(34) & "facets" & Chr(34))

        rdoSingleGraphs.Enabled = False

        ucrReceiverOneVarGraph.Selector = ucrSelectorOneVarGraph
        ucrReceiverOneVarGraph.SetMeAsReceiver()

        ucrSelectorOneVarGraph.SetParameterName("data")
        ucrSelectorOneVarGraph.SetParameterIsString()

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameterName("coord_flip")
        'When checked add coord_flip = TRUE, when unchecked remove coord_flip parameter
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "")

        ucrBase.iHelpTopicID = 412
        ucrOneVarGraphSave.strPrefix = "OneVariableGraph"
        ucrOneVarGraphSave.SetDataFrameSelector(ucrSelectorOneVarGraph.ucrAvailableDataFrames)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
    End Sub

    Private Sub ReopenDialog()
        CheckDataType()
    End Sub

    Private Sub TestOkEnabled()
        'Question: What should TestOK do in the new implementation? Still check controls or check the code?
        'this test when to enable okay button. Should be enabled only when the receiver is not empty or when the save graph is schecked and the save graph is not empty
        If ucrReceiverOneVarGraph.IsEmpty() OrElse (ucrOneVarGraphSave.chkSaveGraph.Checked AndAlso ucrOneVarGraphSave.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrReceiverOneVarGraph_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverOneVarGraph.SelectionChanged
        ' this adds the parameter columns to the syntax
        ucrBase.clsRsyntax.AddParameter("columns", ucrReceiverOneVarGraph.GetVariableNames())
        CheckDataType()
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub ucrOneVarGraphSave_GraphNameChanged() Handles ucrOneVarGraphSave.GraphNameChanged, ucrOneVarGraphSave.SaveGraphCheckedChanged
        'this sub saves graphs 
        If ucrOneVarGraphSave.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrOneVarGraphSave.strGraphName, strTempDataframe:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrOneVarGraphSave.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdGraph_Click(sender As Object, e As EventArgs) Handles cmdGraphOptions.Click
        sdgOneVarGraph.ShowDialog()
    End Sub

    Private Sub rdoFacets_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFacets.CheckedChanged, rdoCombineGraph.CheckedChanged, rdoSingleGraphs.CheckedChanged
        SetOutputparameter()
    End Sub

    Private Sub SetOutputparameter()
        'this adds different outputs parameters to the syntax
        If rdoFacets.Checked Then
            ucrBase.clsRsyntax.AddParameter("output", Chr(34) & "facets" & Chr(34))
        ElseIf rdoCombineGraph.Checked Then
            ucrBase.clsRsyntax.AddParameter("output", Chr(34) & "combine" & Chr(34))
        ElseIf rdoSingleGraphs.Checked Then
            ucrBase.clsRsyntax.AddParameter("output", Chr(34) & "single" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("output") 'this might never run because atleast one must be checked at a time
        End If
    End Sub

    Private Sub CheckDataType()
        'this checks for data types and if all the selected variable are of same type, enables facets 
        If ucrReceiverOneVarGraph.IsAllNumeric() OrElse ucrReceiverOneVarGraph.IsAllCategorical() Then
            rdoFacets.Enabled = True
        Else
            rdoFacets.Enabled = False
            If rdoFacets.Checked Then
                rdoCombineGraph.Checked = True
            End If
        End If
    End Sub

    Private Sub ucrOneVarGraphSave_ContentsChanged() Handles ucrOneVarGraphSave.ContentsChanged
        TestOkEnabled()
    End Sub

    'When any of the ucrCore controls have been changed we update the R Code to match the contents
    Private Sub ucrSelectorOneVarGraph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOneVarGraph.ControlValueChanged, ucrChkFlip.ControlValueChanged
        'The control that has changed updates the R code
        ucrChangedControl.UpdateRCode(ucrBase.clsRsyntax.clsBaseFunction)
        'This line may be needed if there are linked controls that need to be updated after other controls have changed
        UpdateControls(Me, ucrBase.clsRsyntax.clsBaseFunction)
    End Sub
End Class