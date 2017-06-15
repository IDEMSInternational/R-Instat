' Instat-R
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
Imports instat.Translations
Public Class dlgViewObjects
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsViewObjectFunction As New RFunction

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
        ucrSelectorForViewObject.SetItemType("object")

        ' ucr receiver
        ucrReceiverSelectedObject.SetParameter(New RParameter("object_name", 1))
        ucrReceiverSelectedObject.SetParameterIsString()
        ucrReceiverSelectedObject.Selector = ucrSelectorForViewObject
        ucrReceiverSelectedObject.SetMeAsReceiver()
        ucrReceiverSelectedObject.strSelectorHeading = "Objects"

        ucrPnlContentsToView.bAllowNonConditionValues = True ' temporary
        ' rdo's
        'ucrPnlContentsToView.SetParameter(New RParameter("", 2))
        'ucrPnlContentsToView.AddRadioButton(rdoStructure, Chr(34) & "" & Chr(34))
        'ucrPnlContentsToView.AddRadioButton(rdoAllContents, Chr(34) & " " & Chr(34))
        'ucrPnlContentsToView.AddRadioButton(rdoComponent, Chr(34) & " " & Chr(34))
        'ucrPnlContentsToView.AddRadioButton(rdoViewGraph, Chr(34) & " " & Chr(34))
        'ucrPnlContentsToView.SetRDefault(Chr(34) & "" & Chr(34))
    End Sub

    Private Sub SetDefaults()
        clsViewObjectFunction = New RFunction

        ucrSelectorForViewObject.Reset()
        rdoViewGraph.Checked = True
        SetiCallType()

        clsViewObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_objects")
        ucrBase.clsRsyntax.SetBaseRFunction(clsViewObjectFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSelectedObject.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetiCallType()
        If rdoViewGraph.Checked Then
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.iCallType = 2
        End If
    End Sub

    Private Sub ucrPnlContentsToReview_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlContentsToView.ControlContentsChanged
        SetiCallType()
    End Sub

    Private Sub ucrReceiverSelectedObject_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedObject.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class