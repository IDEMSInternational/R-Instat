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
Imports System.IO

Public Class dlgApsimx
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsApsimxExampleFunction, clsApsimExampleFunction As New RFunction
    Private Sub dlgApsimx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 479

        ucrInputComboList.IsReadOnly = True

        ucrChkSilent.SetText("Silent")
        ucrChkSilent.SetParameter(New RParameter("silent", 1))
        ucrChkSilent.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSilent.SetRDefault("FALSE")

        ucrSaveFile.SetSaveTypeAsDataFrame()
        ucrSaveFile.SetLabelText("New Data Frame Name:")
        ucrSaveFile.SetIsTextBox()

        Dim dctExamplesModels As New Dictionary(Of String, String) From {
           {"Barley", Chr(34) & "Barley" & Chr(34)},
           {"Controlled Environment", Chr(34) & "ControlledEnvironment" & Chr(34)},
           {"Eucalyptus", Chr(34) & "Eucalyptus" & Chr(34)},
           {"Eucalyptus Rotation", Chr(34) & "EucalyptusRotation" & Chr(34)},
           {"Maize", Chr(34) & "Maize" & Chr(34)},
           {"Oats", Chr(34) & "Oats" & Chr(34)},
           {"Rotation", Chr(34) & "Rotation" & Chr(34)},
           {"Soybean", Chr(34) & "Soybean" & Chr(34)},
           {"Sugarcane", Chr(34) & "Sugarcane" & Chr(34)},
           {"Wheat", Chr(34) & "Wheat" & Chr(34)},
           {"Sugar", Chr(34) & "Sugar" & Chr(34)},
           {"Potato", Chr(34) & "Potato" & Chr(34)},
           {"Millet", Chr(34) & "Millet" & Chr(34)},
           {"Centro", Chr(34) & "Centro" & Chr(34)},
           {"Canopy", Chr(34) & "Canopy" & Chr(34)},
           {"agpasture", Chr(34) & "agpasture" & Chr(34)}
       }

        ucrInputComboList.SetParameter(New RParameter("example", 0))
        ucrInputComboList.SetItems(dctExamplesModels)
        ucrInputComboList.SetDropDownStyleAsNonEditable()

    End Sub

    Private Sub SetDefaults()
        clsApsimxExampleFunction = New RFunction
        clsApsimExampleFunction = New RFunction

        clsApsimxExampleFunction.SetPackageName("apsimx")
        clsApsimxExampleFunction.SetRCommand("apsimx_example")
        clsApsimxExampleFunction.AddParameter("example", Chr(34) & "Barley" & Chr(34), iPosition:=0)

        clsApsimExampleFunction.SetPackageName("apsimx")
        clsApsimExampleFunction.SetRCommand("apsim_example")

        ucrBase.clsRsyntax.SetBaseRFunction(clsApsimxExampleFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkSilent.AddAdditionalCodeParameterPair(clsApsimExampleFunction, New RParameter("silent", 1), iAdditionalPairNo:=1)
        ucrInputComboList.AddAdditionalCodeParameterPair(clsApsimExampleFunction, New RParameter("example", 0), iAdditionalPairNo:=1)
        ucrSaveFile.AddAdditionalRCode(clsApsimExampleFunction, bReset)

        ucrChkSilent.SetRCode(clsApsimxExampleFunction, bReset)
        ucrSaveFile.SetRCode(clsApsimxExampleFunction, bReset)
        ucrInputComboList.SetRCode(clsApsimxExampleFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveFile.IsComplete Then
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

    Private Sub ucrInputPath_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveFile.ControlContentsChanged, ucrChkSilent.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrInputComboList_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboList.ControlValueChanged
        If ucrInputComboList.GetText = "Wheat" OrElse ucrInputComboList.GetText = "Barley" OrElse ucrInputComboList.GetText = "ControlledEnvironment" OrElse ucrInputComboList.GetText = "Sugarcane" OrElse ucrInputComboList.GetText = "Eucalyptus" OrElse ucrInputComboList.GetText = "EucalyptusRotation" OrElse ucrInputComboList.GetText = "Maize" OrElse ucrInputComboList.GetText = "Oats" OrElse ucrInputComboList.GetText = "Rotation" OrElse ucrInputComboList.GetText = "Soybean" Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsApsimxExampleFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsApsimExampleFunction)
        End If
        ucrSaveFile.SetPrefix(ucrInputComboList.GetText)
    End Sub
End Class