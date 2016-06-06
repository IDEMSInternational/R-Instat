Imports instat

Public Class ucrLayerParamsControls
    Public clsLayerParam As LayerParameters
    Public ctrActive As Control
    Public clsGeomFunction As RFunction

    Public Event RParameterChanged(ucrControl As ucrLayerParamsControls)

    Private Sub ucrLayerParamsControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InitialiseControl()

    End Sub

    Public Sub SetGeomFunction(clsTempFunction As RFunction)
        clsGeomFunction = clsTempFunction
    End Sub

    Public Sub SetLayerParameter(clsTempLayerParam As LayerParameters)

        clsLayerParam = clsTempLayerParam

        nudParamValue.Visible = False
        ucrcborParamValue.Visible = False
        If Not IsNothing(clsLayerParam) Then
            chkParamName.Visible = True
            chkParamName.Text = clsLayerParam.strLayerParameterName
            chkParamName.Checked = False
            If clsLayerParam.strLayerParameterDataType = "numeric" Then
                ctrActive = nudParamValue
            ElseIf clsLayerParam.strLayerParameterDataType = "boolean" Then
                ctrActive = ucrcborParamValue
                ucrcborParamValue.cboInput.Items.Clear()
                ucrcborParamValue.cboInput.Items.Add("TRUE")
                ucrcborParamValue.cboInput.Items.Add("FALSE")
            Else
                ctrActive = New Control 'this should never actually be used but is here to ensure the code is stable even if a developper uses an incorrect datatype
            End If
            ctrActive.Text = clsLayerParam.strParameterDefaultValue
        Else
            chkParamName.Visible = False
        End If
    End Sub

    Private Sub chkParamName_CheckedChanged(sender As Object, e As EventArgs) Handles chkParamName.CheckedChanged
        ctrActive.Visible = chkParamName.Checked
        RaiseEvent RParameterChanged(Me)
    End Sub

    Private Sub nudParamValue_ValueChanged(sender As Object, e As EventArgs) Handles nudParamValue.TextChanged
        RaiseEvent RParameterChanged(Me)
    End Sub

    Private Sub ucrcborParamValue_NameChanged() Handles ucrcborParamValue.NameChanged
        RaiseEvent RParameterChanged(Me)
    End Sub

    Private Sub ucrLayerParamsControls_RParameterChanged(ucrControl As ucrLayerParamsControls) Handles Me.RParameterChanged

        If Not IsNothing(clsLayerParam) And Not IsNothing(clsGeomFunction) Then
            If chkParamName.Checked Then
                clsGeomFunction.AddParameter(clsLayerParam.strLayerParameterName, ctrActive.Text)
            Else
                clsGeomFunction.RemoveParameterByName(clsLayerParam.strLayerParameterName)
            End If
        End If

    End Sub

End Class
