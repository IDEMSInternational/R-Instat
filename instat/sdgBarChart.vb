Public Class sdgBarChart
    Public clsBarChartFunction As RFunction

    Public Sub SetBarChartFunction(clsBarChartFunc As RFunction)
        clsBarChartFunction = clsBarChartFunc
    End Sub

    Public Sub SetDefaults()
        'Need to be careful that this will trigger the checkedchaged event
        'If rdoStack is checked in the designer, this will not trigger the event
        rdoStack.Checked = True
        nudWidth.Value = "0.9"
    End Sub

    Private Sub grpPosition_CheckedChanged(sender As Object, e As EventArgs) Handles rdoStack.CheckedChanged, rdoDodge.CheckedChanged, rdoFill.CheckedChanged
        If rdoStack.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsBarChartFunction.AddParameter("position", Chr(34) & "stack" & Chr(34))
            Else
                clsBarChartFunction.RemoveParameterByName("position")
            End If
        ElseIf rdoDodge.Checked Then
            clsBarChartFunction.AddParameter("position", Chr(34) & "dodge" & Chr(34))
        ElseIf rdoFill.Checked Then
            clsBarChartFunction.AddParameter("position", Chr(34) & "fill" & Chr(34))
        Else
            clsBarChartFunction.RemoveParameterByName("position")
        End If
    End Sub

    Private Sub nudWidth_TextChanged(sender As Object, e As EventArgs) Handles nudWidth.TextChanged
        If nudWidth.Value.ToString() <> "" Then
            clsBarChartFunction.AddParameter("width", nudWidth.Value)
        Else
            clsBarChartFunction.RemoveParameterByName("width")
        End If
    End Sub


End Class