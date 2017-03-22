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
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False

    Private Sub dlgOneVariableGraph_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        ReopenDialog()
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrSelectorOneVarGraph.Reset()
        ucrSaveGraph.Reset()

        'Define the default RFunction
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$graph_one_variable")
        clsDefaultFunction.AddParameter("numeric", Chr(34) & "geom_boxplot" & Chr(34))
        clsDefaultFunction.AddParameter("categorical", Chr(34) & "geom_bar" & Chr(34))
        clsDefaultFunction.AddParameter("output", Chr(34) & "facets" & Chr(34))
        clsDefaultFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        bResetSubdialog = True
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 412
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlOutput.SetParameter(New RParameter("output"))
        ucrPnlOutput.AddRadioButton(rdoFacets, Chr(34) & "facets" & Chr(34))
        ucrPnlOutput.AddRadioButton(rdoCombine, Chr(34) & "combine" & Chr(34))
        ucrPnlOutput.AddRadioButton(rdoSingleGraphs, Chr(34) & "single" & Chr(34))
        ucrPnlOutput.SetRDefault(Chr(34) & "facets" & Chr(34))

        ucrReceiverOneVarGraph.Selector = ucrSelectorOneVarGraph
        ucrReceiverOneVarGraph.SetMeAsReceiver()
        ucrReceiverOneVarGraph.SetParameter(New RParameter("columns", 1))
        ucrReceiverOneVarGraph.SetParameterIsString()

        ucrSelectorOneVarGraph.SetParameter(New RParameter("data_name", 0))
        ucrSelectorOneVarGraph.SetParameterIsString()

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameter(New RParameter("coord_flip"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFlip.SetRDefault("FALSE")

        ucrSaveGraph.SetPrefix("one_var")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorOneVarGraph.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub ReopenDialog()
        CheckDataType()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverOneVarGraph.IsEmpty() AndAlso ucrSaveGraph.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdGraph_Click(sender As Object, e As EventArgs) Handles cmdGraphOptions.Click
        ' Link the base function to the sub dialog
        sdgOneVarGraph.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgOneVarGraph.ShowDialog()
    End Sub

    Private Sub CheckDataType()
        'this checks for data types and if all the selected variable are of same type, enables facets 
        If ucrReceiverOneVarGraph.IsAllNumeric() OrElse ucrReceiverOneVarGraph.IsAllCategorical() Then
            rdoFacets.Enabled = True
        Else
            rdoFacets.Enabled = False
            If rdoFacets.Checked Then
                rdoCombine.Checked = True
            End If
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOneVarGraph.ControlContentsChanged, ucrReceiverOneVarGraph.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneVarGraph.ControlValueChanged
        CheckDataType()
    End Sub
End Class