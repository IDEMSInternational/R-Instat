' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgGlance
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private clsMap_df, clsDummyRfunction As New RFunction

    Private Sub dlgGlance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bfirstload Then
            InitialiseDialog()
            bfirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrModelReceiver.SetItemType("model")
        ucrModelReceiver.strSelectorHeading = "Model"
        ucrModelReceiver.SetParameterIsRFunction()
        ucrModelReceiver.Selector = ucrModelSelector
        ucrModelReceiver.bForceVariablesAsList = True

        ucrPnlOptions.AddRadioButton(rdoDisplayInOutput)
        ucrPnlOptions.AddRadioButton(rdoGlanceDataFrame)
        ucrPnlOptions.AddToLinkedControls(ucrSaveNewDataFrame, {rdoGlanceDataFrame}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrChkDisplayinOutput.SetText("Display in Output")

        ucrModelSelector.SetParameter(New RParameter("data", 0))
        ucrModelSelector.SetParameterIsrfunction()

        ucrSaveNewDataFrame.SetIsComboBox()
        ucrSaveNewDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveNewDataFrame.SetCheckBoxText("Save New data frame:")
        ucrSaveNewDataFrame.SetPrefix("Glance_dataframe")
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrModelSelector.ucrAvailableDataFrames)

        ucrModelReceiver.SetParameter(New RParameter(".x", 0))
        ucrModelReceiver.Selector = ucrModelSelector
        ucrModelReceiver.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        clsMap_df = New RFunction
        clsDummyRfunction = New RFunction

        ucrModelSelector.Reset()
        'ucrSaveNewDataFrame.Reset()

        'todo implement as a function properly
        clsMap_df.SetPackageName("purrr")
        clsMap_df.SetRCommand("map_df")
        clsMap_df.AddParameter(strParameterName:=".f", strParameterValue:="broom::glance", iPosition:=1)
        clsMap_df.AddParameter(strParameterName:=".id", strParameterValue:=Chr(34) & "model" & Chr(34))

        'ucrChkDisplayinOutput.Checked = True

        clsDummyRfunction = clsMap_df.Clone()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.SetBaseRFunction(clsMap_df)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (ucrSaveNewDataFrame.IsComplete AndAlso Not ucrModelReceiver.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub rdoDisplayInOutPut_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoDisplayInOutput.Checked Then
            ucrBase.clsRsyntax.iCallType = 2
        Else
            ucrBase.clsRsyntax.iCallType = 0
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrModelReceiver.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
