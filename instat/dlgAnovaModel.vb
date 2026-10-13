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

Public Class dlgAnovaModel
    Public strVariableType As String
    Private clsAttach As New RFunction
    Private clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bRCodeSet As Boolean = False
    Public clsFormulaOperator As New ROperator

    Public clsRestpvalFunction, clsFamilyFunction, clsRCIFunction, clsRConvert, clsAutoPlot, clsVisReg As New RFunction
    Public bResetModelOptions As Boolean = False
    Public clsRSingleModelFunction, clsFormulaFunction, clsAnovaFunction, clsAnovaIIFunction, clsSummaryFunction, clsConfint As New RFunction
    Public clsGLMFunction, clsLM, clsLMOrGLM, clsGLMFunctionNB, clsAOVFunction, clsGLMFunctionPolr, clsGLMFunctionMultinom, clsAsNumeric As New RFunction

    'Saving Operators/Functions
    Private clsRstandardFunction, clsHatvaluesFunction, clsResidualFunction, clsFittedValuesFunction As New RFunction

    Public bResetSubDialog As Boolean = False
    Public bResetOptionsSubDialog As Boolean = False

    Private dctPlotFunctions As New Dictionary(Of String, RFunction)

    Private Sub dlgAnovaModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrReceiverExpressionAnovaModel.AddtoCombobox(ucrReceiverExpressionAnovaModel.GetText)
    End Sub
End Class