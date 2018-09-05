' R-Instat
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


Public Class sdgMapOption
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsXlimFunction, clsYlimFunction As New RFunction
    Private clsGgplotOperator As New ROperator

    Private Sub sdgMapOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()
        ucrInputLongMin.SetParameter(New RParameter("longmin", bNewIncludeArgumentName:=False))
        ucrInputLongMax.SetParameter(New RParameter("longmax", bNewIncludeArgumentName:=False))
        ucrInputLatMin.SetParameter(New RParameter("latmin", bNewIncludeArgumentName:=False))
        ucrInputLatMax.SetParameter(New RParameter("latmax", bNewIncludeArgumentName:=False))
    End Sub

    Private Sub SetDefaults()
        clsXlimFunction = New RFunction
        clsYlimFunction = New RFunction
        clsGgplotOperator = New ROperator

        clsGgplotOperator.SetOperation("+")

        clsXlimFunction.SetRCommand("xlim")
        clsYlimFunction.SetRCommand("ylim")

        clsGgplotOperator.AddParameter("xlim", clsRFunctionParameter:=clsXlimFunction, bIncludeArgumentName:=False)
        clsGgplotOperator.AddParameter("ylim", clsRFunctionParameter:=clsYlimFunction, bIncludeArgumentName:=False)
    End Sub

    Public Sub SetRCode(clsBaseOperator, clsXlim, clsylim, bReset)
        ucrInputLongMin.SetRCode(clsXlimFunction, bReset)
        ucrInputLongMax.SetRCode(clsXlimFunction, bReset)
        ucrInputLatMin.SetRCode(clsYlimFunction, bReset)
        ucrInputLatMax.SetRCode(clsYlimFunction, bReset)
    End Sub

End Class