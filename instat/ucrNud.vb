Imports instat

Public Class ucrNud
    Private Sub ucrNud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Overrides Sub UpdateControl(clsRFunction As RFunction)
        Dim iNewValue As Integer
        Dim clsTempParam As RParameter

        clsTempParam = clsRFunction.GetParameter(strParameterName)
        If strParameterName <> "" Then
            If clsTempParam IsNot Nothing Then
                If Integer.TryParse(clsTempParam.strArgumentValue, iNewValue) AndAlso iNewValue >= nudUpDown.Minimum AndAlso iNewValue <= nudUpDown.Maximum Then
                    nudUpDown.Value = iNewValue
                Else
                    MsgBox("Developer error: The value of parameter " & clsTempParam.strArgumentName & ": " & clsTempParam.strArgumentValue & " cannot be converted to an integer or is outside the range of the control. Defaulting to the minimum value.")
                    nudUpDown.Value = nudUpDown.Minimum
                End If
            End If
        End If
    End Sub

    Public Overrides Sub UpdateRFunction(clsRFunction As RFunction)
        If strParameterName <> "" Then
            clsRFunction.AddParameter(strParameterName, nudUpDown.Value)
        End If
    End Sub

    Public Sub SetMinMax(Optional iNewMin As Integer = Integer.MinValue, Optional iNewMax As Integer = Integer.MaxValue)
        nudUpDown.Minimum = iNewMin
        nudUpDown.Maximum = iNewMax
    End Sub

    Public Property Minimum As Integer
        Get
            Return nudUpDown.Minimum
        End Get
        Set(iNewMin As Integer)
            nudUpDown.Minimum = iNewMin
        End Set
    End Property

    Public Property Maximum As Integer
        Get
            Return nudUpDown.Maximum
        End Get
        Set(iNewMax As Integer)
            nudUpDown.Maximum = iNewMax
        End Set
    End Property
End Class
