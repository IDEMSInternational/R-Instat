Imports Antlr.Runtime

Public Class ucrStub

    Private bFirstload As Boolean = True

    Private Sub initialiseDialog()
        ucrPnlStub.AddRadioButton(rdoVariables)
        ucrPnlStub.AddRadioButton(rdoStyles)

        rdoVariables.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator, Optional strTableName As String = "")
        If bFirstload Then
            initialiseDialog()
            bFirstload = False
        End If

        ucrStubOptions.Setup(strDataFrameName, clsOperator, strTableName)
        ucrStubStyle.Setup(strDataFrameName, clsOperator)
    End Sub

    Private Sub ucrPnlRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStub.ControlValueChanged
        ucrStubOptions.Visible = rdoVariables.Checked
        ucrStubStyle.Visible = rdoStyles.Checked
    End Sub

    Public Sub SetValuesToOperator()
        ucrStubOptions.SetValuesToOperator()
        ucrStubStyle.SetValuesToOperator()
    End Sub
End Class
