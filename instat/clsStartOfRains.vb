Public Class clsStartOfRains
    Public clsIsNaIfelse, clsSumIsNA As New RFunction
    Public clsSORFilterOperator As New ROperator
    Private clsGreaterIfelseOp As New ROperator
    Private clsNotIsNA, clsSumFunc As New RFunction
    Public strStartDoy As String = "start_doy"

    Public Sub SetDefaults()

        clsSumFunc.Clear()

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
        clsSORFilterOperator.AddParameter("left", strParameterValue:=strStartDoy, bIncludeArgumentName:=False, iPosition:=0)
        clsSORFilterOperator.AddParameter("right", "1]", bIncludeArgumentName:=False, iPosition:=1)

        clsSumFunc.SetRCommand("sum")
        clsSumFunc.AddParameter("is.na", clsRFunctionParameter:=clsSumIsNA, bIncludeArgumentName:=False)

        clsSumIsNA.SetRCommand("is.na")
    End Sub
End Class
