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

Public Class dlgViewGraph
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsPlotlyRFunction, clsGetObjectRFunction, clsViewObjectRFunction, clsPrintRFunction As New RFunction


    Private Sub dlgViewGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        'todo. after changing the radio buttons translations, restore this line
        'autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 525

        'Selector
        ucrGraphsSelector.SetParameter(New RParameter("data_name", 0))
        ucrGraphsSelector.SetParameterIsString()

        'Receiver
        ucrGraphReceiver.SetParameter(New RParameter("object_name", 1))
        ucrGraphReceiver.strSelectorHeading = "Ggplot Graphs"
        ucrGraphReceiver.bAutoFill = True
        ucrGraphReceiver.SetParameterIsString()
        ucrGraphReceiver.SetItemType(RObjectTypeLabel.Graph)
        ucrGraphReceiver.Selector = ucrGraphsSelector
        ucrGraphReceiver.SetMeAsReceiver()

        ' We don't specify rdos in the new system here. This is because the automatic detection of the radio buttons relies on VB options, not R code
        'Group Options panel
        ucrPnlDisplayOptions.AddRadioButton(rdoOutputWindow)
        ucrPnlDisplayOptions.AddRadioButton(rdoMaximised)
        ucrPnlDisplayOptions.AddRadioButton(rdoInteractiveView)
        ucrPnlDisplayOptions.AddRadioButton(rdoRViewer)

        'todo. Calling print() from this dialog doesn't work. investigate why
        'temporarily disabled
        rdoRViewer.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsPlotlyRFunction = New RFunction
        clsGetObjectRFunction = New RFunction
        clsViewObjectRFunction = New RFunction
        clsPrintRFunction = New RFunction

        ucrGraphsSelector.Reset()
        rdoOutputWindow.Checked = True

        clsGetObjectRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")

        clsPlotlyRFunction.SetPackageName("plotly")
        clsPlotlyRFunction.SetRCommand("ggplotly")
        clsPlotlyRFunction.AddParameter("p", clsRFunctionParameter:=clsGetObjectRFunction)

        clsPrintRFunction.SetRCommand("print")
        clsPrintRFunction.AddParameter("x", clsRFunctionParameter:=clsGetObjectRFunction, iPosition:=0)

        clsViewObjectRFunction.SetRCommand("view_object_data")
        clsViewObjectRFunction.AddParameter("object", clsRFunctionParameter:=clsGetObjectRFunction)
        clsViewObjectRFunction.AddParameter("object_format", strParameterValue:=Chr(34) & RObjectFormat.Image & Chr(34))

        ucrBase.clsRsyntax.SetBaseRFunction(clsGetObjectRFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrGraphReceiver.SetRCode(clsGetObjectRFunction, bReset)
        ucrGraphsSelector.SetRCode(clsGetObjectRFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrGraphReceiver.IsEmpty Then
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

    Private Sub ucrPnlDisplayOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDisplayOptions.ControlValueChanged
        If rdoOutputWindow.Checked Then
            clsGetObjectRFunction.AddParameter("as_file", strParameterValue:="TRUE", iPosition:=2)
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetObjectRFunction)
        ElseIf rdoMaximised.Checked Then
            clsViewObjectRFunction.AddParameter("object", clsRFunctionParameter:=clsGetObjectRFunction)
            clsViewObjectRFunction.AddParameter("object_format", strParameterValue:=Chr(34) & RObjectFormat.Image & Chr(34), iPosition:=1)
            clsGetObjectRFunction.AddParameter("as_file", strParameterValue:="FALSE", iPosition:=2)
            ucrBase.clsRsyntax.SetBaseRFunction(clsViewObjectRFunction)
        ElseIf rdoInteractiveView.Checked Then
            clsViewObjectRFunction.AddParameter("object", clsRFunctionParameter:=clsPlotlyRFunction)
            clsViewObjectRFunction.AddParameter("object_format", strParameterValue:=Chr(34) & RObjectFormat.Html & Chr(34), iPosition:=1)
            clsGetObjectRFunction.AddParameter("as_file", strParameterValue:="FALSE", iPosition:=2)
            ucrBase.clsRsyntax.SetBaseRFunction(clsViewObjectRFunction)
        ElseIf rdoRViewer.Checked Then
            'clsViewObjectRFunction.AddParameter("object", clsRFunctionParameter:=clsGetObjectRFunction)
            'clsViewObjectRFunction.RemoveParameterByName("object_format")
            ucrBase.clsRsyntax.SetBaseRFunction(clsPrintRFunction)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrGraphReceiver.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class