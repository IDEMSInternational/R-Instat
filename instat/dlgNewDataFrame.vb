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

Public Class dlgNewDataFrame
    Private clsOverallFunction, clsMatrixFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgNewDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        'ucrNewDFName.SetLabelText("New Data Frame Name:")
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

    Private Sub SetDefaults()
        clsOverallFunction = New RFunction
        clsMatrixFunction = New RFunction

        ucrNewDFName.Reset()

        ' Default R
        clsOverallFunction.SetRCommand("data.frame")

        'matrix(nrow = 10, ncol = 2, Data = NA)
        clsMatrixFunction.SetRCommand("matrix")
        clsMatrixFunction.AddParameter("data", "NA")
        clsMatrixFunction.AddParameter("ncol", 2)
        clsMatrixFunction.AddParameter("nrow", 10)

        clsOverallFunction.AddParameter("data", clsRFunctionParameter:=clsMatrixFunction)
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
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