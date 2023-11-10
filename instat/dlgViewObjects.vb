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
    Private clsStructureRFunction, clsPrintRFunction As New RFunction
    Private dctTypes As New Dictionary(Of String, String)

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
        'todo. temporary to have the str() output captured as text
        ucrBase.clsRsyntax.iCallType = -1

        ucrPnlOptions.AddRadioButton(rdoOutputObjects)
        ucrPnlOptions.AddRadioButton(rdoDataObjects)
        'todo disabled until functionality of viewing data objects is implemented
        rdoDataObjects.Enabled = False
        ucrPnlOptions.AddFunctionNamesCondition(rdoOutputObjects, {frmMain.clsRLink.strInstatDataObject & "$get_object_data", "str"})

        ucrSelectorForViewObject.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForViewObject.SetParameterIsString()

        dctTypes.Add("Objects", "object")
        dctTypes.Add("Summaries", RObjectTypeLabel.Summary)
        dctTypes.Add("Tables", RObjectTypeLabel.Table)
        dctTypes.Add("Graphs", RObjectTypeLabel.Graph)
        dctTypes.Add("Models", RObjectTypeLabel.Model)
        dctTypes.Add("Structured", RObjectTypeLabel.StructureLabel)
        ucrInputObjectType.SetItems(dctTypes, bSetConditions:=False)
        ucrInputObjectType.SetDropDownStyleAsNonEditable()

        ucrReceiverSelectedObject.SetParameter(New RParameter("object_name", 1))
        ucrReceiverSelectedObject.Selector = ucrSelectorForViewObject
        ucrReceiverSelectedObject.SetMeAsReceiver()
        ucrReceiverSelectedObject.strSelectorHeading = "Objects"
        ucrReceiverSelectedObject.SetItemType("object")
        ucrReceiverSelectedObject.bAutoFill = True

        ucrPnlContentsToView.AddRadioButton(rdoPrint)
        ucrPnlContentsToView.AddRadioButton(rdoStructure)

        ucrPnlContentsToView.AddFunctionNamesCondition(rdoPrint, frmMain.clsRLink.strInstatDataObject & "$get_object_data", bNewIsPositive:=True)
        ucrPnlContentsToView.AddFunctionNamesCondition(rdoStructure, "str", bNewIsPositive:=True)

    End Sub

    Private Sub SetDefaults()
        'initialise the Rfunctions
        clsStructureRFunction = New RFunction
        clsPrintRFunction = New RFunction

        'reset controls to default states
        ucrSelectorForViewObject.Reset()
        ucrInputObjectType.GetSetSelectedIndex = 0
        rdoPrint.Checked = True

        'set R function for showing selected object structure
        clsStructureRFunction.SetRCommand("str")

        'as of 02/3/2023 get object data is used instead of print command because the print command is not yet supported for html formats.
        clsPrintRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsPrintRFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsPrintRFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverSelectedObject.AddAdditionalCodeParameterPair(clsStructureRFunction, New RParameter("object", 1))
        ucrSelectorForViewObject.SetRCode(clsPrintRFunction, bReset)
        ucrReceiverSelectedObject.SetRCode(clsPrintRFunction, bReset)
        ucrPnlContentsToView.SetRCode(ucrBase.clsRsyntax.clsBaseFunction)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverSelectedObject.IsEmpty)
    End Sub

    Private Sub ucrInputObjectType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputObjectType.ControlValueChanged
        ucrReceiverSelectedObject.Clear()
        If dctTypes.ContainsKey(ucrInputObjectType.GetText()) Then
            ucrReceiverSelectedObject.strSelectorHeading = ucrInputObjectType.GetText()
            ucrReceiverSelectedObject.SetItemType(dctTypes.Item(ucrInputObjectType.GetText()))
        End If
    End Sub

    Private Sub ucrPnlContentsToReview_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlContentsToView.ControlContentsChanged
        'set the appropriate base RFunction
        If rdoPrint.Checked Then
            ucrReceiverSelectedObject.SetParameterIsString()
            ucrBase.clsRsyntax.SetBaseRFunction(clsPrintRFunction)
        ElseIf rdoStructure.Checked Then
            ucrReceiverSelectedObject.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsStructureRFunction)
        End If
    End Sub

    Private Sub ucrReceiverSelectedObject_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedObject.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub


End Class
