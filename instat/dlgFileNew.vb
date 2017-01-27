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
Imports RDotNet

Public Class dlgFileNew
    Public strDefaultSheetPrefix As String = "Sheet"
    Private clsOverallFunction, clsMatrixDefaultFunction, clsMatrixFunction As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub dlgFileNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        'TODO What should these defaults be?
        '     Defaults should be stored in Options dialog 
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
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
        ucrNewDFName.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        ucrNewDFName.SetLabelText("New Data Frame Name:")

        ' Default R
        clsOverallFunction.SetRCommand("data.frame")
        clsOverallFunction.AddParameter("data", clsRFunctionParameter:=clsMatrixFunction)
        clsOverallFunction.SetAssignTo(ucrNewDFName.GetText(), strTempDataframe:=ucrNewDFName.GetText())

        'matrix(nrow = 10, ncol = 2, Data = NA)
        clsMatrixDefaultFunction.SetRCommand("matrix")
        clsMatrixDefaultFunction.AddParameter("data", "NA")
        clsMatrixDefaultFunction.AddParameter("ncol", 2)
        clsMatrixDefaultFunction.AddParameter("nrow", 10)

    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
        clsMatrixFunction = clsMatrixDefaultFunction.Clone()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        SetRCode(Me, clsMatrixFunction, True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        '      If ucrNewDFName.IsComplete AndAlso ucrNudCols.GetText <> "" AndAlso ucrNudRows.GetText <> "" Then
        '     ucrBase.OKEnabled(True)
        '    Else
        '   ucrBase.OKEnabled(False)
        '  End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrInputDataFrameName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudRows.ControlContentsChanged, ucrNudCols.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class