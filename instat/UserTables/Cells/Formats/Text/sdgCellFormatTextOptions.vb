Imports instat.Translations
Public Class sdgCellFormatTextOptions
    Private clsUnitsFormatRFunction, clsCustomFormatRFunction As New RFunction
    Private bFirstload As Boolean = True
    Private bUserMadeChanges As Boolean = False
    Private bUserClickedReturn As Boolean = False


    Private Sub sdgCellFormatTextOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        SetDefaults()

        bUserMadeChanges = False
        bUserClickedReturn = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        rdoCustom.Checked = True
        ucrCellFormatEmail.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsUnitsFormatRFunction = New RFunction
        clsCustomFormatRFunction = New RFunction

        clsCustomFormatRFunction.SetPackageName("gt")
        clsCustomFormatRFunction.SetRCommand("fmt")


        clsUnitsFormatRFunction.SetPackageName("gt")
        clsUnitsFormatRFunction.SetRCommand("fmt_units")


        ucrInputFormatExpression.SetName("")
    End Sub

    Public Function GetNewUserInputAsRFunction() As RFunction
        If Not bUserClickedReturn OrElse Not bUserMadeChanges Then
            Return Nothing
        End If

        If rdoUnits.Checked Then
            Return clsUnitsFormatRFunction
        ElseIf rdoCustom.Checked AndAlso Not ucrInputFormatExpression.IsEmpty Then
            Return clsCustomFormatRFunction
        End If

        Return Nothing
    End Function

    Private Sub radioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCustom.CheckedChanged, rdoUnits.CheckedChanged, rdoEmail.CheckedChanged
        ucrInputFormatExpression.Visible = rdoCustom.Checked
        ucrCellFormatEmail.Visible = rdoEmail.Checked
        bUserMadeChanges = True
    End Sub

    Private Sub ucrInputFormatExpression_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFormatExpression.ControlValueChanged
        If ucrInputFormatExpression.IsEmpty Then
            clsCustomFormatRFunction.ClearParameters()
        Else
            clsCustomFormatRFunction.AddParameter(strParameterName:="fns", strParameterValue:="function(x){ " & ucrInputFormatExpression.GetText() & " }")
        End If

        bUserMadeChanges = True

    End Sub

    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        bUserClickedReturn = True
    End Sub
End Class