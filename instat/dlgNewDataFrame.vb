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

Imports instat
Imports instat.Translations
Imports RDotNet

Public Class dlgNewDataFrame
    Private clsOverallFunction, clsMatrixFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgNewDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 6

        'nudRows
        ucrNudRows.SetParameter(New RParameter("nrow"))
        ucrNudRows.SetMinMax(1, Integer.MaxValue)

        'nudCols
        ucrNudCols.SetParameter(New RParameter("ncol"))
        ucrNudCols.SetMinMax(1, Integer.MaxValue)

        ' ucrNewSheetName
        ucrNewDFName.SetIsTextBox()
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetLabelText("New Data Frame Name:")
        ucrNewDFName.SetPrefix("data")
    End Sub

    ' updating controls doesn't update the function
    ' Sheet name is not on the dialog.

    Private Sub ReopenDialog()
    End Sub

    Private Sub SetDefaults()
        Dim clsMatrixDefaultFunction As New RFunction
        clsOverallFunction = New RFunction

        ucrNewDFName.Reset()

        ' Default R
        clsOverallFunction.SetRCommand("data.frame")

        'matrix(nrow = 10, ncol = 2, Data = NA)
        clsMatrixDefaultFunction.SetRCommand("matrix")
        clsMatrixDefaultFunction.AddParameter("data", "NA")
        clsMatrixDefaultFunction.AddParameter("ncol", 2)
        clsMatrixDefaultFunction.AddParameter("nrow", 10)

        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
        clsMatrixFunction = clsMatrixDefaultFunction.Clone()
        clsOverallFunction.AddParameter("data", clsRFunctionParameter:=clsMatrixFunction)
    End Sub

    Private Sub TestOKEnabled()
        If ucrNewDFName.IsComplete AndAlso ucrNudCols.GetText <> "" AndAlso ucrNudRows.GetText <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrNudCols.SetRCode(clsMatrixFunction, bReset)
        ucrNudRows.SetRCode(clsMatrixFunction, bReset)
        ucrNewDFName.SetRCode(clsOverallFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrInputDataFrameName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudRows.ControlContentsChanged, ucrNudCols.ControlContentsChanged, ucrNewDFName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class