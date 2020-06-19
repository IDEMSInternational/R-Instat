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

Public Class clsRains
    Public clsIsNaIfelse As New RFunction
    Private clsSumIsNA, clsSumFunc As New RFunction
    Public clsSORFilterOperator As New ROperator
    Private clsGreaterIfelseOp As New ROperator
    Private clsNotIsNA As New RFunction

    Public Sub SetDefaults()
        clsSumFunc.Clear()
        clsIsNaIfelse.Clear()
        clsGreaterIfelseOp.Clear()
        clsNotIsNA.Clear()
        clsSORFilterOperator.Clear()
        clsSumIsNA.Clear()


        clsIsNaIfelse.SetRCommand("ifelse")
        clsIsNaIfelse.AddParameter("sum", clsROperatorParameter:=clsGreaterIfelseOp, bIncludeArgumentName:=False, iPosition:=0)
        clsIsNaIfelse.AddParameter("NA", "NA", bIncludeArgumentName:=False, iPosition:=1)
        clsIsNaIfelse.AddParameter("!is.na", clsRFunctionParameter:=clsNotIsNA, bIncludeArgumentName:=False)

        clsGreaterIfelseOp.SetOperation(">")
        clsGreaterIfelseOp.bSpaceAroundOperation = False
        clsGreaterIfelseOp.AddParameter("left", clsRFunctionParameter:=clsSumFunc, iPosition:=0)
        clsGreaterIfelseOp.AddParameter("right", 0, bIncludeArgumentName:=False, iPosition:=1)

        clsNotIsNA.SetRCommand("!is.na")
        clsNotIsNA.AddParameter("!is.na", clsROperatorParameter:=clsSORFilterOperator, bIncludeArgumentName:=False)

        clsSORFilterOperator.SetOperation("[")
        clsSORFilterOperator.bSpaceAroundOperation = False

        clsSORFilterOperator.AddParameter("right", "1]", bIncludeArgumentName:=False, iPosition:=1)
        clsSumFunc.SetRCommand("sum")
        clsSumFunc.AddParameter("is.na", clsRFunctionParameter:=clsSumIsNA, bIncludeArgumentName:=False)

        clsSumIsNA.SetRCommand("is.na")
    End Sub

    Public Sub SetControlParameters(ucrNewControl As ucrCore, iAdditionalPairNo As Integer)
        ucrNewControl.AddAdditionalCodeParameterPair(clsSumIsNA, New RParameter("Rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=iAdditionalPairNo)
    End Sub
End Class
