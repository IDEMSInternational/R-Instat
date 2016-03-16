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
Public Class sdgCorrPlot
    Public clsRGGPairsFunction As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub sdgCorrPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub GGPairs()
        Dim clsRGraphics As New RSyntax
        clsRGraphics.SetFunction("ggpairs")
        clsRGraphics.AddParameter("data", clsRFunctionParameter:=dlgCorrelation.ucrSelectorDataFrameVarAddRemove.ucrAvailableDataFrames.clsCurrDataFrame)
        clsRGraphics.AddParameter("columns", dlgCorrelation.ucrReceiverMultipleColumns.GetVariableNames())

        'clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRGGPairsFunction)
        'clsRGraphics.SetOperation("")
        'clsRGGPairsFunction.SetRCommand("ggpairs")
        'clsRGGPairsFunction.AddParameter("data", clsRFunctionParameter:=dlgCorrelation.ucrSelectorDataFrameVarAddRemove.ucrAvailableDataFrames.clsCurrDataFrame)
        'clsRGGPairsFunction.AddParameter("columns", dlgCorrelation.ucrReceiverMultipleColumns.GetVariableNames())
        'clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRGGPairsFunction)

        'Calltype is not the right one but it works
        frmMain.clsRLink.RunScript(clsRGraphics.GetScript(), 2)
    End Sub

    Private Sub GGcorr()
        Dim clsRGGcorrGraphics As New RSyntax
        'We may have to save the correlation matrix then use it here.
        'We still need to add more arguments to the ggcorr function 
        clsRGGcorrGraphics.SetFunction("ggcorr")
        clsRGGcorrGraphics.AddParameter("data", "NULL")
        clsRGGcorrGraphics.AddParameter("cor_matrix", dlgCorrelation.ucrBase.clsRsyntax.GetScript())


        'Calltype is not the right one but it works
        frmMain.clsRLink.RunScript(clsRGGcorrGraphics.GetScript(), 2)
    End Sub


    Public Sub SetDefaults()
        chkGGPairs.Checked = False
        chkGGcorr.Checked = False
    End Sub

    Public Sub RegOptions()
        If (chkGGPairs.Checked = True) Then
            GGPairs()
        End If
        If (chkGGcorr.Checked = True) Then
            GGcorr()
        End If
    End Sub
End Class