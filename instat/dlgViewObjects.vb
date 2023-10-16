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

        ' ucr receiver
        ucrReceiverSelectedObject.SetParameter(New RParameter("x", 1))
        ucrReceiverSelectedObject.SetParameterIsRFunction()
        ucrReceiverSelectedObject.Selector = ucrSelectorForViewObject
        ucrReceiverSelectedObject.SetMeAsReceiver()
        ucrReceiverSelectedObject.strSelectorHeading = "Objects"
        ucrReceiverSelectedObject.SetItemType("object")
        ucrReceiverSelectedObject.bAutoFill = True

        'todo. disabling and hiding this for now until they're working correctly.
        'calling print via a dialog currently does not work correctly
        rdoPrint.Enabled = False
        rdoAllContents.Visible = False
        rdoComponent.Visible = False

        'add radio buttons to the panel rdo's
        'ucrPnlContentsToView.AddRadioButton(rdoPrint)
        ucrPnlContentsToView.AddRadioButton(rdoStructure)

        'ucrPnlContentsToView.AddFunctionNamesCondition(rdoPrint, "print")
        ucrPnlContentsToView.AddFunctionNamesCondition(rdoStructure, "str")

    End Sub

    Private Sub SetDefaults()
        'initialise the Rfunctions
        clsStructureRFunction = New RFunction
        clsPrintRFunction = New RFunction

        'reset controls to default states
        ucrSelectorForViewObject.Reset()
        rdoStructure.Checked = True

        'set R function for showing selected object structure
        clsPrintRFunction.SetRCommand("print")
        clsStructureRFunction.SetRCommand("str")


        'set the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsStructureRFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverSelectedObject.AddAdditionalCodeParameterPair(clsStructureRFunction, New RParameter("object", 1))
        ucrReceiverSelectedObject.SetRCode(clsPrintRFunction, bReset)
        ucrPnlContentsToView.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverSelectedObject.IsEmpty)
    End Sub

    Private Sub ucrPnlContentsToReview_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlContentsToView.ControlContentsChanged
        'set the appropriate Base RFunction
        If rdoPrint.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPrintRFunction)
        ElseIf rdoStructure.Checked Then
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
