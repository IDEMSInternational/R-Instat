Imports instat.Translations
Public Class sdgSaveColumnPosition
    Private clsRFunction As New RFunction
    Private bControlsInitialised As Boolean = False
    Private Sub sdgSaveColumnPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dctBeforeAfter As New Dictionary(Of String, String)

        ucrReceiverColumn.Selector = ucrSelectorSaveColumnPosition
        ucrReceiverColumn.SetParameter(New RParameter("adjacent_column", 1))
        ucrReceiverColumn.SetParameterIsString()
        ucrReceiverColumn.SetMeAsReceiver()

        ucrPnlColumnPosition.SetParameter(New RParameter("before", 2))
        ucrPnlColumnPosition.AddRadioButton(rdoStart, "TRUE")
        ucrPnlColumnPosition.AddRadioButton(rdoEnd, "FALSE")
        ucrPnlColumnPosition.AddRadioButton(rdoBeforeOrAfterColumn)

        ucrPnlColumnPosition.AddToLinkedControls(ucrSelectorSaveColumnPosition, {rdoBeforeOrAfterColumn}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnPosition.AddToLinkedControls(ucrReceiverColumn, {rdoBeforeOrAfterColumn}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnPosition.AddToLinkedControls(ucrInputBeforeAfter, {rdoBeforeOrAfterColumn}, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumn)
        ucrPnlColumnPosition.AddParameterValuesCondition(rdoStart, "before", "TRUE")
        ucrPnlColumnPosition.AddParameterValuesCondition(rdoEnd, "before", "FALSE")
        ucrPnlColumnPosition.AddParameterPresentCondition(True, "adjcent_column")

        ucrInputBeforeAfter.SetParameter(New RParameter("before", 2))
        dctBeforeAfter.Add("Before", "TRUE")
        dctBeforeAfter.Add("After", "FALSE")
        ucrInputBeforeAfter.SetItems(dctBeforeAfter)
        ucrInputBeforeAfter.SetDropDownStyleAsNonEditable()
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsAddColumnsToData As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsRFunction = clsAddColumnsToData
        SetRCode(clsRFunction, bReset)
    End Sub


End Class