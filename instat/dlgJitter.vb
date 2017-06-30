' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class dlgJitter
    Public clsRunif As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgJitter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverJitter.Selector = ucrSelectorForJitter
        ucrReceiverJitter.SetMeAsReceiver()
        ucrReceiverJitter.strSelectorHeading = "Numerics"
        ucrBase.clsRsyntax.SetOperation("+")
        clsRunif.SetRCommand("runif")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRunif)
        ucrInputNewColumnName.SetItemsTypeAsColumns()
        ucrInputNewColumnName.SetDefaultTypeAsColumn()
        ucrInputNewColumnName.SetDataFrameSelector(ucrSelectorForJitter.ucrAvailableDataFrames)
        ucrReceiverJitter.SetIncludedDataTypes({"numeric"})
        ucrInputMaximum.SetValidationTypeAsNumeric()
        ucrInputMinimum.SetValidationTypeAsNumeric()
        ucrInputMaximumDistanceFromZero.SetValidationTypeAsNumeric()
        ucrBase.iHelpTopicID = 396
        ucrInputNewColumnName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        MinAndMaxValue()
        ucrInputMaximumDistanceFromZero.SetName(1)
        rdoMaximumDistanceFromZero.Checked = True
        ucrInputNewColumnName.SetPrefix("Jitter_values")
        ucrInputMaximum.SetName(1)
        ucrInputMinimum.SetName(0)
        ucrSelectorForJitter.Reset()
        LengthOfDataset()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ((ucrReceiverJitter.IsEmpty() = False) And (ucrInputNewColumnName.IsEmpty() = False)) Then
            If Not ucrInputMaximumDistanceFromZero.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
            If ucrInputMinimum.IsEmpty = False And ucrInputMaximum.IsEmpty = False Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub grpMaximumAndMinimumValues_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMaximumDistanceFromZero.CheckedChanged, rdoMinimumAndMaximum.CheckedChanged
        MinAndMaxValue()
        TestOKEnabled()
    End Sub

    Private Sub MinAndMaxValue()
        If rdoMaximumDistanceFromZero.Checked Then
            ucrInputMaximum.Enabled = False
            ucrInputMinimum.Enabled = False
            ucrInputMaximumDistanceFromZero.Enabled = True
            Distance()
        ElseIf rdoMinimumAndMaximum.Checked Then
            ucrInputMaximum.Enabled = True
            ucrInputMinimum.Enabled = True
            ucrInputMaximumDistanceFromZero.Enabled = False
            Distance()
        End If
    End Sub

    Private Sub ucrInputNewColumnName_NameChanged() Handles ucrInputNewColumnName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputNewColumnName.GetText, strTempDataframe:=ucrSelectorForJitter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputNewColumnName.GetText)
    End Sub

    Private Sub Distance()
        If rdoMaximumDistanceFromZero.Checked Then
            If Not ucrInputMaximumDistanceFromZero.IsEmpty Then
                clsRunif.AddParameter("min", -(ucrInputMaximumDistanceFromZero.GetText))
                clsRunif.AddParameter("max", ucrInputMaximumDistanceFromZero.GetText)
            Else
                clsRunif.RemoveParameterByName("min")
                clsRunif.RemoveParameterByName("max")
            End If
        ElseIf rdoMinimumAndMaximum.Checked Then
            If Not ucrInputMinimum.IsEmpty Then
                clsRunif.AddParameter("min", ucrInputMinimum.GetText)
            Else
                clsRunif.RemoveParameterByName("min")
            End If
            If Not ucrInputMaximum.IsEmpty Then
                clsRunif.AddParameter("max", ucrInputMaximum.GetText)
            Else
                clsRunif.RemoveParameterByName("max")
            End If
        Else
            clsRunif.RemoveParameterByName("max")
            clsRunif.RemoveParameterByName("min")
        End If
    End Sub

    Private Sub ucrInputs_NameChanged() Handles ucrInputMinimum.NameChanged, ucrInputMaximum.NameChanged, ucrInputMaximumDistanceFromZero.NameChanged
        Distance()
    End Sub

    Private Sub ucrReceiverJitter_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverJitter.SelectionChanged
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=ucrReceiverJitter.GetVariables)
        TestOKEnabled()
    End Sub

    Private Sub LengthOfDataset()
        clsRunif.AddParameter("n", ucrSelectorForJitter.ucrAvailableDataFrames.iDataFrameLength)
    End Sub

    Private Sub ucrSelectorForJitter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForJitter.ControlValueChanged
        LengthOfDataset()
    End Sub

End Class