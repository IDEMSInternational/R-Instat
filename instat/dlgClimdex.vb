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
Imports instat
Imports instat.Translations
Public Class dlgClimdex
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Public clsDefaultFunction As New RFunction
    Public clsRDataName, clsRTmax, clsRTmin, clsRPrec, clsRDate, clsRPCIct, clsRChar As New RFunction

    Private Sub dlgClimdex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrSelectorClimdex.Reset()
        ucrSelectorClimdex.Focus()
        ucrReceiverDate.SetMeAsReceiver()

        'Define the default RFunction
        clsDefaultFunction.SetRCommand("climdexInput.raw")
        clsRTmax.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRTmin.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRPrec.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRDate.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRPCIct.SetRCommand("as.PCICt")
        clsRChar.SetRCommand("as.character")
        clsRPCIct.AddParameter("cal", Chr(34) & "gregorian" & Chr(34))

        clsRChar.AddParameter("x", clsRFunctionParameter:=clsRDate)
        clsRPCIct.AddParameter("x", clsRFunctionParameter:=clsRChar)
        clsDefaultFunction.SetAssignTo("climdex_input")

        ' Set default RFunction as the base function
        ucrBaseClimdex.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        'add rfunction as parameters of the main function here
        ucrBaseClimdex.clsRsyntax.AddParameter("tmax", clsRFunctionParameter:=clsRTmax)
        ucrBaseClimdex.clsRsyntax.AddParameter("tmax.dates", clsRFunctionParameter:=clsRPCIct)
        ucrBaseClimdex.clsRsyntax.AddParameter("tmin", clsRFunctionParameter:=clsRTmin)
        ucrBaseClimdex.clsRsyntax.AddParameter("tmin.dates", clsRFunctionParameter:=clsRPCIct)
        ucrBaseClimdex.clsRsyntax.AddParameter("prec", clsRFunctionParameter:=clsRPrec)
        ucrBaseClimdex.clsRsyntax.AddParameter("prec.dates", clsRFunctionParameter:=clsRPCIct)
        bResetSubdialog = True
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseClimdex.iHelpTopicID = 190
        ucrBaseClimdex.clsRsyntax.iCallType = 0

        ucrSelectorClimdex.SetParameter(New RParameter("data_name", 0))
        ucrSelectorClimdex.SetParameterIsString()

        ucrReceiverDate.Selector = ucrSelectorClimdex
        ucrReceiverDate.SetDataType("Date")
        ucrReceiverDate.SetParameter(New RParameter("col_name"))
        ucrReceiverDate.SetParameterIsString()

        ucrReceiverTmax.Selector = ucrSelectorClimdex
        ucrReceiverTmax.SetParameter(New RParameter("col_name"))
        ucrReceiverTmax.SetParameterIsString()

        ucrReceiverTmin.Selector = ucrSelectorClimdex
        ucrReceiverTmin.SetParameter(New RParameter("col_name"))
        ucrReceiverTmin.SetParameterIsString()

        ucrReceiverPrec.Selector = ucrSelectorClimdex
        ucrReceiverPrec.SetParameter(New RParameter("col_name"))
        ucrReceiverPrec.SetParameterIsString()

        'AssignName()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty AndAlso (Not ucrReceiverTmax.IsEmpty OrElse Not ucrReceiverTmin.IsEmpty OrElse Not ucrReceiverPrec.IsEmpty) Then
            AddRemoveDates()
            ucrBaseClimdex.OKEnabled(True)
        Else
            ucrBaseClimdex.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)

        ucrSelectorClimdex.SetRCode(clsRDate, bReset)
        ucrSelectorClimdex.SetRCode(clsRTmax, bReset)
        ucrSelectorClimdex.SetRCode(clsRTmin, bReset)
        ucrSelectorClimdex.SetRCode(clsRPrec, bReset)
        ucrSelectorClimdex.SetRCode(sdgClimdexIndices.clsRWriteDf, bReset)
        ucrReceiverDate.SetRCode(clsRDate, bReset)
        ucrReceiverTmax.SetRCode(clsRTmax, bReset)
        ucrReceiverTmin.SetRCode(clsRTmin, bReset)
        ucrReceiverPrec.SetRCode(clsRPrec, bReset)
    End Sub

    Private Sub ucrBaseClimdex_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseClimdex.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AddRemoveDates()
        If Not ucrReceiverTmax.IsEmpty Then
            ucrBaseClimdex.clsRsyntax.AddParameter("tmax", clsRFunctionParameter:=clsRTmax)
            ucrBaseClimdex.clsRsyntax.AddParameter("tmax.dates", clsRFunctionParameter:=clsRPCIct)
        Else
            ucrBaseClimdex.clsRsyntax.RemoveParameter("tmax.dates")
            ucrBaseClimdex.clsRsyntax.RemoveParameter("tmax")
        End If
        If Not ucrReceiverTmin.IsEmpty Then
            ucrBaseClimdex.clsRsyntax.AddParameter("tmin", clsRFunctionParameter:=clsRTmin)
            ucrBaseClimdex.clsRsyntax.AddParameter("tmin.dates", clsRFunctionParameter:=clsRPCIct)

        Else
            ucrBaseClimdex.clsRsyntax.RemoveParameter("tmin")
            ucrBaseClimdex.clsRsyntax.RemoveParameter("tmin.dates")
        End If
        If Not ucrReceiverPrec.IsEmpty Then
            ucrBaseClimdex.clsRsyntax.AddParameter("prec", clsRFunctionParameter:=clsRPrec)
            ucrBaseClimdex.clsRsyntax.AddParameter("prec.dates", clsRFunctionParameter:=clsRPCIct)
        Else
            ucrBaseClimdex.clsRsyntax.RemoveParameter("prec")
            ucrBaseClimdex.clsRsyntax.RemoveParameter("prec.dates")
        End If
    End Sub

    Private Sub cmdIndices_Click(sender As Object, e As EventArgs) Handles cmdIndices.Click
        sdgClimdexIndices.SetRFunction(ucrBaseClimdex.clsRsyntax.clsBaseFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgClimdexIndices.ShowDialog()
    End Sub

    Private Sub ucrBaseClimdex_clickok(sender As Object, e As EventArgs) Handles ucrBaseClimdex.ClickOk
        sdgClimdexIndices.IndicesOptions()
    End Sub

    Private Sub AssignName()
        ucrBaseClimdex.clsRsyntax.SetAssignTo("climdex_input")
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimdex.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverPrec.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class