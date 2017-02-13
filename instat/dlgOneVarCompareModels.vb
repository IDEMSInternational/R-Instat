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

Public Class dlgOneVarCompareModels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    'Private bResetSubdialog As Boolean = False

    Private Sub dlgOneVarCompareModels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 174
        ucrBase.clsRsyntax.iCallType = 2

        'ucrSelector
        ucrSelectorOneVarCompModels.SetItemType("model")

        'ucrReceiver
        UcrReceiverCompareModels.SetParameter(New RParameter("f", 0))
        UcrReceiverCompareModels.SetParameterIsRFunction()
        UcrReceiverCompareModels.Selector = ucrSelectorOneVarCompModels
        UcrReceiverCompareModels.SetMeAsReceiver()


        ' sdgOneVarCompareModels.InitialiseDialog()
        ' sdgOneVarCompareModels.SetModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
        ' sdgOneVarCompareModels.SetReceiver(UcrReceiver)
        ' sdgOneVarCompareModels.DisplayChiSquare()
        ' sdgOneVarCompareModels.DisplayChiBreaks()
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorOneVarCompModels.Reset()

        clsDefaultFunction.SetRCommand("gofstat")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ' bResetSubdialog = True
    End Sub

    'Only distributions that can be accepted into the receiver have to be from the same variable
    ' If variable from variablex is selected then
    ' variables not fromvariablex cannot be in dataframe

    Private Sub ReopenDialog()
        sdgOneVarCompareModels.Reopen()
    End Sub

    Public Sub TestOKEnabled()
        If Not UcrReceiverCompareModels.IsEmpty Then 'sdgOneVarCompareModels.TestOkEnabled() AndAlso Not  Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorOneVarCompModels_DataFrameChanged() Handles ucrSelectorOneVarCompModels.DataFrameChanged
        '    sdgOneVarCompareModels.DisplayChiSquare()
    End Sub

    Private Sub UcrReceiver_SelectionChanged(ucrChangedControl As ucrCore) Handles UcrReceiverCompareModels.ControlContentsChanged
        If UcrReceiverCompareModels.IsEmpty Then
            cmdDisplayObjects.Enabled = False
        Else
            cmdDisplayObjects.Enabled = True
        End If
        TestOKEnabled()
        '        sdgOneVarCompareModels.SetModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
    End Sub

    Private Sub cmdDisplayObjects_Click(sender As Object, e As EventArgs) Handles cmdDisplayObjects.Click
        '        sdgOneVarCompareModels.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubdialog)
        'bResetSubdialog = False
        'sdgOneVarCompareModels.ShowDialog()

        ''TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        '    sdgOneVarCompareModels.CreateGraphs()
    End Sub
End Class