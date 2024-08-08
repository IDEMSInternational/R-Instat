Public Class sdgCellFormatNumberOptions
    Private clsFormatNumberRFunction As New RFunction
    Private bFirstload As Boolean = True

    Private bUserMadeChanges As Boolean = False
    Private bUserClickedReturn As Boolean = False


    Private Sub sdgCellFormatNumberOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        SetDefaults()
        SetRCode(True)

        bUserMadeChanges = False
        bUserClickedReturn = False
    End Sub


    Private Sub InitialiseDialog()

        '---------------
        ucrChkDecimalPlaces.SetText("Change Decimal Places")
        ucrChkDecimalPlaces.AddToLinkedControls(ucrNudDecimalPlaces, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="2")

        ucrNudDecimalPlaces.SetParameter(New RParameter("decimals", 3))
        '---------------

        '--------------
        ucrChkSignificantFigures.SetText("Change Significant Figures")
        ucrChkSignificantFigures.AddToLinkedControls(ucrNudSignificantFigures, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

        ucrNudSignificantFigures.SetParameter(New RParameter("n_sigfig", 4))
        '--------------


        '--------------
        ucrChkDecimalMark.SetText("Change Decimal Mark")
        ucrChkDecimalMark.AddToLinkedControls(ucrInputDecimalMark, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=".")

        ucrInputDecimalMark.SetParameter(New RParameter("dec_mark", 13))
        '--------------

        '---------------
        ucrChkSeparatorMark.SetText("Change Digits Separator Mark")
        ucrChkSeparatorMark.AddToLinkedControls(ucrInputSeperatorMark, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=",")

        ucrInputSeperatorMark.SetParameter(New RParameter("sep_mark", 14))
        '---------------

        '---------------
        ucrChkDropTrailingZeros.SetText("Drop Trailing Zeros")
        ucrChkDropTrailingZeros.SetParameter(New RParameter("drop_trailing_zeros", 5))
        ucrChkDropTrailingZeros.SetValuesCheckedAndUnchecked("TRUE", False)
        ucrChkDropTrailingZeros.SetRDefault("FALSE")
        '---------------

        '---------------
        ucrChkDropTrailingDecimalMark.SetText("Drop Trailing Decimal Mark")
        ucrChkDropTrailingDecimalMark.SetParameter(New RParameter("drop_trailing_dec_mark", 6))
        ucrChkDropTrailingDecimalMark.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropTrailingDecimalMark.SetRDefault("TRUE")
        '---------------

        '---------------
        ucrChkSuffix.SetText("Suffix Large Numbers")
        ucrChkSuffix.SetParameter(New RParameter("suffixing", 10))
        ucrChkSuffix.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSuffix.SetRDefault("FALSE")
        '---------------


    End Sub

    Private Sub SetDefaults()
        clsFormatNumberRFunction = New RFunction

        clsFormatNumberRFunction.SetPackageName("gt")
        clsFormatNumberRFunction.SetRCommand("fmt_number")

    End Sub

    Private Sub SetRCode(bReset As Boolean)
        ucrChkDecimalPlaces.SetRCode(clsFormatNumberRFunction, bReset)
        ucrNudDecimalPlaces.SetRCode(clsFormatNumberRFunction, bReset)

        ucrChkSignificantFigures.SetRCode(clsFormatNumberRFunction, bReset)
        ucrNudSignificantFigures.SetRCode(clsFormatNumberRFunction, bReset)

        ucrChkDecimalMark.SetRCode(clsFormatNumberRFunction, bReset)
        ucrInputDecimalMark.SetRCode(clsFormatNumberRFunction, bReset)

        ucrChkSeparatorMark.SetRCode(clsFormatNumberRFunction, bReset)
        ucrInputSeperatorMark.SetRCode(clsFormatNumberRFunction, bReset)

        ucrChkDropTrailingZeros.SetRCode(clsFormatNumberRFunction, bReset)
        ucrChkDropTrailingDecimalMark.SetRCode(clsFormatNumberRFunction, bReset)

        ucrChkSuffix.SetRCode(clsFormatNumberRFunction, bReset)

    End Sub

    Public Function GetNewUserInputAsRFunction() As RFunction
        If Not bUserClickedReturn OrElse Not bUserMadeChanges Then
            Return Nothing
        End If

        Return clsFormatNumberRFunction
    End Function

    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        bUserClickedReturn = True
    End Sub

    Private Sub controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDecimalMark.ControlValueChanged,
    ucrChkDecimalPlaces.ControlValueChanged, ucrChkDropTrailingDecimalMark.ControlValueChanged, ucrChkDropTrailingZeros.ControlValueChanged,
    ucrChkSeparatorMark.ControlValueChanged, ucrChkSignificantFigures.ControlValueChanged, ucrChkSuffix.ControlValueChanged,
    ucrInputDecimalMark.ControlValueChanged, ucrInputSeperatorMark.ControlValueChanged, ucrNudDecimalPlaces.ControlValueChanged,
    ucrNudSignificantFigures.ControlValueChanged

        bUserMadeChanges = True
    End Sub

End Class