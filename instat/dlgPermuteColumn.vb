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
Public Class dlgPermuteColumn
    Public clsSetSampleFunc As New RFunction
    Private clsOverallFunction As New RFunction
    Public clsSetSeedFunc As New RFunction
    Private clsSample As New RFunction
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True

    Private Sub dlgPermuteRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False

        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ReopenDialog()
        TestOkEnabled()

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverPermuteRows.SetRCode(clsSample, bReset)
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction


        clsDefaultFunction.SetRCommand("replicate")

        clsSample = clsSetSampleFunc.Clone
        clsOverallFunction = clsDefaultFunction.Clone()

        clsOverallFunction.AddParameter("expr", clsRFunctionParameter:=clsSample)
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)


        ucrPermuteRowsSelector.Reset()
        clsSetSampleFunc.AddParameter("n", 1)
        nudSetSeed.Value = 5
        chkSetSeed.Checked = False
        nudSetSeed.Visible = False
        TestOkEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 66



        ucrReceiverPermuteRows.Selector = ucrPermuteRowsSelector
        ucrReceiverPermuteRows.SetMeAsReceiver()
        ucrReceiverPermuteRows.bUseFilteredData = False
        ucrReceiverPermuteRows.SetParameter(New RParameter("x", 1))
        ucrReceiverPermuteRows.SetParameterIsRFunction()
        ucrNudNumberofColumns.SetParameter(New RParameter("n", 2))

        clsSetSeedFunc.SetRCommand("set.seed")
        clsSetSampleFunc.SetRCommand("sample")
        '        clsSetSampleFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverPermuteRows.GetVariables())
        clsSetSampleFunc.AddParameter("replace", "FALSE")
        clsSetSampleFunc.AddParameter("size", ucrPermuteRowsSelector.ucrAvailableDataFrames.iDataFrameLength)


        ucrSavePermute.SetPrefix("permute")
        ucrSavePermute.SetSaveTypeAsColumn()
        ucrSavePermute.SetDataFrameSelector(ucrPermuteRowsSelector.ucrAvailableDataFrames)
        ucrSavePermute.SetCheckBoxText("Save Permute:")
        ucrSavePermute.SetIsComboBox()

        nudSetSeed.Minimum = Integer.MinValue
        nudSetSeed.Maximum = Integer.MaxValue
        'nudNumberofColumns.Minimum = 1
        'SetSize()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverPermuteRows.IsEmpty AndAlso ucrSavePermute.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'Private Sub ucrReceiverPermuteRows_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverPermuteRows.SelectionChanged
    '    If Not ucrReceiverPermuteRows.IsEmpty Then
    '        clsSetSampleFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverPermuteRows.GetVariables())
    '    Else
    '        clsSetSampleFunc.RemoveParameterByName("x")
    '    End If
    '    TestOkEnabled()
    'End Sub

    'Private Sub chkSetSeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSetSeed.CheckedChanged
    '    If chkSetSeed.Checked = True Then
    '        nudSetSeed.Visible = True
    '    Else
    '        nudSetSeed.Visible = False
    '    End If
    'End Sub

    'Private Sub nudSetSeed_TextChanged(sender As Object, e As EventArgs) Handles nudSetSeed.TextChanged
    '    clsSetSeedFunc.AddParameter("seed", nudSetSeed.Value)
    'End Sub

    'Private Sub nudNumberOfColumns_TextChanged(sender As Object, e As EventArgs) Handles nudNumberofColumns.TextChanged
    'ucrBase.clsRsyntax.AddParameter("n", nudNumberofColumns.Value)
    'If nudNumberofColumns.Value = 1 Then
    '    lblNewColumnName.Text = "New Column Name:"
    '    If Not ucrInputPermuteRows.bUserTyped Then
    '        ucrInputPermuteRows.SetPrefix("Permute")
    '    End If
    'Else
    '    lblNewColumnName.Text = "Prefix for New Columns:"
    '    If Not ucrInputPermuteRows.bUserTyped Then
    '        ucrInputPermuteRows.SetPrefix("")
    '        ucrInputPermuteRows.SetName("Permute")
    '    End If
    'End If
    'SetAssignTo()
    'End Sub

    'Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
    '    SetDefaults()
    'End Sub

    'Private Sub ucrInputPermuteRows_nameChanged()
    '    SetAssignTo()
    '    TestOkEnabled()
    'End Sub

    'Private Sub SetAssignTo()
    '    Dim bIsPrefix As Boolean

    '    bIsPrefix = (nudNumberofColumns.Value > 1)
    '    ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSavePermute.GetText, strTempDataframe:=ucrPermuteRowsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSavePermute.GetText, bAssignToIsPrefix:=bIsPrefix)
    'End Sub

    'Private Sub ucrPermuteRowsSelector_DataFrameChanged() Handles ucrPermuteRowsSelector.DataFrameChanged
    '    SetSize()
    'End Sub

    'Private Sub SetSize()
    '    clsSetSampleFunc.AddParameter("size", ucrPermuteRowsSelector.ucrAvailableDataFrames.iDataFrameLength)
    'End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPermuteRows.ControlContentsChanged
        TestOkEnabled()
    End Sub

    'Private Sub ucrPermuteRowsSelector_Load(sender As Object, e As EventArgs) Handles ucrPermuteRowsSelector.Load

    'End Sub
End Class