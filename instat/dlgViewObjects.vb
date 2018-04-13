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
Imports RDotNet

Public Class dlgViewObjects
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetObjectsFunction As RFunction
    Private clsShowObjectStructureFunction As RFunction

    Private Sub dlgViewObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 349

        ' ucr selector
        ucrSelectorForViewObject.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForViewObject.SetParameterIsString()

        ' ucr receiver
        ucrReceiverSelectedObject.SetParameter(New RParameter("object_name", 1))
        ucrReceiverSelectedObject.SetParameterIsString()
        ucrReceiverSelectedObject.Selector = ucrSelectorForViewObject
        ucrReceiverSelectedObject.SetMeAsReceiver()
        ucrReceiverSelectedObject.strSelectorHeading = "Objects"
        ucrReceiverSelectedObject.SetItemType("object")
        ucrReceiverSelectedObject.bAutoFill = True

        'add radio buttons to the panel rdo's
        ucrPnlContentsToView.AddRadioButton(rdoPrint)
        ucrPnlContentsToView.AddRadioButton(rdoStructure)
        'ucrPnlContentsToView.AddRadioButton(rdoAllContents) 'to be added later
        'ucrPnlContentsToView.AddRadioButton(rdoComponent) 'to be added later

        ucrPnlContentsToView.AddFunctionNamesCondition(rdoPrint, frmMain.clsRLink.strInstatDataObject & "$get_objects")
        ucrPnlContentsToView.AddFunctionNamesCondition(rdoStructure, "str")

        'we are disabling this for now until they're working correctly.
        rdoAllContents.Enabled = False
        rdoComponent.Enabled = False
    End Sub

    Private Sub SetDefaults()
        'initialise the Rfunctions
        clsGetObjectsFunction = New RFunction
        clsShowObjectStructureFunction = New RFunction

        'reset controls to default states
        ucrSelectorForViewObject.Reset()

        'set R function for getting and viewing objects
        clsGetObjectsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_objects")

        'set R function for showing selected object structure
        clsShowObjectStructureFunction.SetRCommand("str")
        clsShowObjectStructureFunction.AddParameter(New RParameter("object", clsGetObjectsFunction, iNewPosition:=0))

        'set the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsGetObjectsFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrSelectorForViewObject.SetRCode(clsGetObjectsFunction, bReset)
        ucrReceiverSelectedObject.SetRCode(clsGetObjectsFunction, bReset)
        ucrPnlContentsToView.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverSelectedObject.IsEmpty)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetICallType()
        If Not rdoStructure.Checked AndAlso IsSelectedObjectGraph() Then
            ucrBase.clsRsyntax.iCallType = 3
        Else
            ucrBase.clsRsyntax.iCallType = 2
        End If
    End Sub

    Private Sub ucrPnlContentsToReview_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlContentsToView.ControlContentsChanged
        'set the appropriate Base RFunction
        If rdoPrint.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetObjectsFunction)
        ElseIf rdoStructure.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsShowObjectStructureFunction)
        End If
        'set the iCallType
        SetICallType()
    End Sub

    Private Sub ucrReceiverSelectedObject_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedObject.ControlContentsChanged
        TestOKEnabled()
        SetICallType()
    End Sub

    Private Function IsSelectedObjectGraph() As Boolean
        Dim bGraph As Boolean = False
        Dim clsGetGraphNames As RFunction
        Dim expItems As SymbolicExpression
        Dim strArr As String()

        clsGetGraphNames = New RFunction
        clsGetGraphNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graph_names")
        clsGetGraphNames.AddParameter(strParameterName:="data_name", strParameterValue:=Chr(34) & ucrSelectorForViewObject.strCurrentDataFrame & Chr(34), iPosition:=0)

        expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsGetGraphNames.ToScript(), bSilent:=True)

        If expItems IsNot Nothing AndAlso Not (expItems.Type = Internals.SymbolicExpressionType.Null) Then
            strArr = expItems.AsCharacter.ToArray
            If strArr IsNot Nothing Then
                bGraph = strArr.Contains(ucrReceiverSelectedObject.GetVariableNames(bWithQuotes:=False))
            Else
                bGraph = False
            End If
        End If

        Return bGraph
    End Function

End Class
