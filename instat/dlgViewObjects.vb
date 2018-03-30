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
Public Class dlgViewObjects
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetObjectsFunction As RFunction
    Private clsShowObjectStructureFunction As RFunction
    Private clsShowObjectContentsFunction As RFunction
    Private clsShowGraphFunction As RFunction

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

        'ucrPnlContentsToView.bAllowNonConditionValues = True ' temporary
        'add radio buttons to the panel rdo's
        ucrPnlContentsToView.AddRadioButton(rdoStructure)
        ucrPnlContentsToView.AddRadioButton(rdoAllContents)
        'ucrPnlContentsToView.AddRadioButton(rdoComponent)
        ucrPnlContentsToView.AddRadioButton(rdoViewGraph)

        'we are disabling this for now until they're working correctly.
        'rdoAllContents.Enabled = False
        rdoComponent.Enabled = False
    End Sub

    Private Sub SetDefaults()
        'initialise the Rfunctions
        clsGetObjectsFunction = New RFunction
        clsShowObjectStructureFunction = New RFunction
        clsShowObjectContentsFunction = New RFunction
        clsShowGraphFunction = New RFunction

        'reset controls to default states
        ucrSelectorForViewObject.Reset()
        rdoStructure.Checked = True
        SetICallType()

        'set R function for getting objects
        clsGetObjectsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_objects")

        'set R function for showing selected object structure
        clsShowObjectStructureFunction.SetRCommand("str")
        clsShowObjectStructureFunction.AddParameter(New RParameter("object", clsGetObjectsFunction, iNewPosition:=0))

        'set R function for showing selected object contents
        clsShowObjectContentsFunction.SetRCommand("show")
        clsShowObjectContentsFunction.AddParameter(New RParameter("object", clsGetObjectsFunction, iNewPosition:=0))

        'set R function for showing graph
        clsShowGraphFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
        clsShowGraphFunction.AddParameter("print_graph", "TRUE")

        'set the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsShowObjectStructureFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrSelectorForViewObject.SetRCode(clsGetObjectsFunction, bReset)
        ucrReceiverSelectedObject.SetRCode(clsGetObjectsFunction, bReset)
        'ucrPnlContentsToView.SetRCode(clsShowObjectStructureFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        'If Not ucrReceiverSelectedObject.IsEmpty Then
        '    ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
        ucrBase.OKEnabled(Not ucrReceiverSelectedObject.IsEmpty)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetICallType()
        If rdoViewGraph.Checked Then
            ucrBase.clsRsyntax.iCallType = 3
        Else
            ucrBase.clsRsyntax.iCallType = 2
        End If
    End Sub

    Private Sub ucrPnlContentsToReview_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlContentsToView.ControlContentsChanged
        'set the appropriate Base RFunction
        If rdoStructure.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsShowObjectStructureFunction)
        ElseIf rdoAllContents.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsShowObjectContentsFunction)
        ElseIf rdoViewGraph.Checked Then
            SetGraphParameters()
            ucrBase.clsRsyntax.SetBaseRFunction(clsShowGraphFunction)
        End If
        SetICallType()
    End Sub

    Private Sub ucrReceiverSelectedObject_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedObject.ControlContentsChanged
        TestOKEnabled()
        SetGraphParameters()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        SetGraphParameters()
    End Sub

    'This is being called in several place because we don't have a BeforeToScripts Click event
    Private Sub SetGraphParameters()
        If rdoViewGraph.Checked Then
            clsShowGraphFunction.AddParameter(strParameterName:="data_name", strParameterValue:=Chr(34) & ucrSelectorForViewObject.strCurrentDataFrame & Chr(34), iPosition:=0)
            clsShowGraphFunction.AddParameter(strParameterName:="graph_name", strParameterValue:=ucrReceiverSelectedObject.GetVariableNames(bWithQuotes:=True), iPosition:=1)
        End If
    End Sub
End Class