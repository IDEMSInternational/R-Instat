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
    Private clsStructureRFunction, clsPrintRFunction, clsDummyFunction As New RFunction
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
        ucrSelectorForViewObject.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForViewObject.SetParameterIsString()

        ' ucr receiver
        ucrReceiverSelectedObject.SetParameter(New RParameter("object_name", 1))
        'ucrReceiverSelectedObject.SetParameterIsRFunction()
        ucrReceiverSelectedObject.Selector = ucrSelectorForViewObject
        ucrReceiverSelectedObject.SetMeAsReceiver()
        ucrReceiverSelectedObject.strSelectorHeading = "Objects"
        ucrReceiverSelectedObject.SetItemType("object")
        ucrReceiverSelectedObject.bAutoFill = True

        'todo. disabling and hiding this for now until they're working correctly.
        rdoAllContents.Visible = False
        rdoComponent.Visible = False

        'add radio buttons to the panel rdo's
        ucrPnlContentsToView.AddRadioButton(rdoPrint)
        ucrPnlContentsToView.AddRadioButton(rdoStructure)

        ucrPnlContentsToView.AddParameterValuesCondition(rdoPrint, "check", "print")
        ucrPnlContentsToView.AddParameterValuesCondition(rdoStructure, "check", "str")

        ucrInputObjectType.SetParameter(New RParameter("object_type", 0))
        dctTypes.Add("Objects", Chr(34) & "object" & Chr(34))
        dctTypes.Add("Summaries", Chr(34) & "summary" & Chr(34))
        dctTypes.Add("Tables", Chr(34) & "table" & Chr(34))
        dctTypes.Add("Graphs", Chr(34) & "graph" & Chr(34))
        dctTypes.Add("Models", Chr(34) & "model" & Chr(34))
        ucrInputObjectType.SetItems(dctTypes)
        ucrInputObjectType.SetDropDownStyleAsNonEditable()

    End Sub

    Private Sub SetDefaults()
        'initialise the Rfunctions
        clsStructureRFunction = New RFunction
        clsPrintRFunction = New RFunction
        clsDummyFunction = New RFunction

        'reset controls to default states
        ucrSelectorForViewObject.Reset()

        clsDummyFunction.AddParameter("object_type", Chr(34) & "object" & Chr(34), iPosition:=0)
        clsDummyFunction.AddParameter("check", "print", iPosition:=1)

        'as of 02/3/2023 get object data is used instead of print command because the print command is not yet supported for html formats.
        clsPrintRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsPrintRFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        'set R function for showing selected object structure
        clsStructureRFunction.SetRCommand("str")

        'set the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsPrintRFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverSelectedObject.AddAdditionalCodeParameterPair(clsStructureRFunction, New RParameter("object", 1))
        ucrSelectorForViewObject.SetRCode(clsPrintRFunction, bReset)
        ucrReceiverSelectedObject.SetRCode(clsPrintRFunction, bReset)
        ucrInputObjectType.SetRCode(clsDummyFunction, bReset)
        ucrPnlContentsToView.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverSelectedObject.IsEmpty)
    End Sub

    Private Sub ucrPnlContentsToReview_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlContentsToView.ControlContentsChanged
        'set the appropriate Base RFunction
        If rdoPrint.Checked Then
            ucrReceiverSelectedObject.SetParameterIsString()
            clsDummyFunction.AddParameter("check", "print", iPosition:=1)
            ucrBase.clsRsyntax.SetBaseRFunction(clsPrintRFunction)
        ElseIf rdoStructure.Checked Then
            ucrReceiverSelectedObject.SetParameterIsRFunction()
            clsDummyFunction.AddParameter("check", "str", iPosition:=1)
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

    Private Sub ucrInputObjectType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputObjectType.ControlValueChanged
        Dim key As String = dctTypes.Keys(ucrInputObjectType.cboInput.SelectedIndex)
        Dim value As String = ""

        If key IsNot Nothing AndAlso dctTypes.TryGetValue(key, value) Then
            ucrReceiverSelectedObject.strSelectorHeading = key
            ucrReceiverSelectedObject.SetItemType(value.Replace(Chr(34), ""))
        End If
    End Sub
End Class
