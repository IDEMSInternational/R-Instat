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
Imports RDotNet

Public Class dlgTransformTricotData
    Private clsOutputDataLevel, clsCheckDataLevel, clsCreateTricotData, clsIDColsFunction, clsVarietyColsFunction, clsTraitColsFunction As New RFunction
    Private clsOutputLevelsOperator, OverallSymbolOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bUniqueChecked As Boolean = False

    Private Sub dlgTransformTricotData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bUniqueChecked = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 671
        ucrReceiverTricotData.SetParameter(New RParameter("data_list", 0))
        ucrReceiverTricotData.SetParameterIsString()
        ucrReceiverTricotData.Selector = ucrSelectorTricotData
        ucrReceiverTricotData.strSelectorHeading = "Data Frames"
        ucrReceiverTricotData.SetItemType("dataframe")
    End Sub

    Private Sub SetDefaults()
        clsOutputDataLevel = New RFunction
        clsCreateTricotData = New RFunction
        clsIDColsFunction = New RFunction
        clsVarietyColsFunction = New RFunction
        clsTraitColsFunction = New RFunction
        clsOutputLevelsOperator = New ROperator
        OverallSymbolOperator = New ROperator
        bUniqueChecked = False
        'ucrSelectorTricotData.Reset()
        'ucrReceiverTricotData.SetMeAsReceiver()
        'bResetSubdialog = True

        ucrReceiverTricotData.SetMeAsReceiver()
        clsOutputDataLevel.SetPackageName("instatExtras")
        clsOutputDataLevel.SetRCommand("summarise_data_levels")

        clsCreateTricotData.SetPackageName("databook")
        clsCreateTricotData.SetRCommand("create_tricot_data")
        clsCreateTricotData.AddParameter("output_data_levels", clsRFunctionParameter:=clsOutputDataLevel)

        clsOutputLevelsOperator.SetOperation("$")
        clsOutputLevelsOperator.AddParameter("left", clsROperatorParameter:=OverallSymbolOperator, iPosition:=0)
        clsOutputLevelsOperator.AddParameter("right", "print", iPosition:=1)
        clsOutputLevelsOperator.bSpaceAroundOperation = False

        OverallSymbolOperator.SetOperation("[")
        OverallSymbolOperator.AddParameter("left", clsRFunctionParameter:=clsOutputDataLevel, iPosition:=0)
        OverallSymbolOperator.AddParameter("right", "1,]", iPosition:=1)
        OverallSymbolOperator.bSpaceAroundOperation = False

        ucrBase.clsRsyntax.SetBaseRFunction(clsCreateTricotData)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverTricotData.SetRCode(clsOutputDataLevel, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click

        ' Only add parameters if it is clicked, otherwise we take the defaults
        clsOutputDataLevel.AddParameter("id_cols", clsRFunctionParameter:=clsIDColsFunction)
        clsOutputDataLevel.AddParameter("variety_cols", clsRFunctionParameter:=clsVarietyColsFunction)
        clsOutputDataLevel.AddParameter("trait_cols", clsRFunctionParameter:=clsTraitColsFunction)
        clsIDColsFunction.SetRCommand("c")
        clsIDColsFunction.AddParameter("id_1", Chr(34) & "ID" & Chr(34), bIncludeArgumentName:=False)
        clsIDColsFunction.AddParameter("id_2", Chr(34) & "id" & Chr(34), bIncludeArgumentName:=False)
        clsIDColsFunction.AddParameter("id_3", Chr(34) & "participant_name" & Chr(34), bIncludeArgumentName:=False)
        clsIDColsFunction.AddParameter("id_4", Chr(34) & "participant_id" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.SetRCommand("c")
        clsVarietyColsFunction.AddParameter("var_1", Chr(34) & "variety" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_2", Chr(34) & "varieties" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_3", Chr(34) & "item" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_4", Chr(34) & "items" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_5", Chr(34) & "Genotype" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_6", Chr(34) & "genotype" & Chr(34), bIncludeArgumentName:=False)
        clsTraitColsFunction.SetRCommand("c")
        clsTraitColsFunction.AddParameter("trait_1", Chr(34) & "trait" & Chr(34), bIncludeArgumentName:=False)
        clsTraitColsFunction.AddParameter("trait_2", Chr(34) & "traits" & Chr(34), bIncludeArgumentName:=False)

        sdgTransformations.SetRFunction(clsNewRFunction:=clsOutputDataLevel, clsNewDefaultFunction:=clsCreateTricotData, clsNewIDColsFunction:=clsIDColsFunction, clsNewVarietyColsFunction:=clsVarietyColsFunction, clsNewTraitColsFunction:=clsTraitColsFunction, ucrNewBaseSelector:=ucrSelectorTricotData, bReset:=bResetSubdialog)
        sdgTransformations.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(True)
        'ucrBase.OKEnabled(Not ucrReceiverTricotData.IsEmpty AndAlso bUniqueChecked)
    End Sub


    Private Sub cmdCheckTricotData_click(sender As Object, e As EventArgs) Handles cmdCheckTricotData.Click
        Check()
    End Sub


    Private Sub Check()
        Dim clsPackageCheck As New RFunction
        Dim expOutput As SymbolicExpression
        Dim chrOutput As CharacterVector
        Dim strFormNames() As String
        Dim expTemp As SymbolicExpression

        clsPackageCheck.SetPackageName("instatExtras")
        clsPackageCheck.SetRCommand("check_data_levels")
        clsPackageCheck.AddParameter("x", clsRFunctionParameter:=clsOutputDataLevel)

        expOutput = frmMain.clsRLink.RunInternalScriptGetValue(clsPackageCheck.ToScript(), bSilent:=True)

        If expOutput Is Nothing OrElse expOutput.Type = Internals.SymbolicExpressionType.Null Then
            ucrInputTricotData.SetText("Cannot get data information.")
            Exit Sub
        End If

        chrOutput = expOutput.AsCharacter
        If chrOutput.Count < 1 Then
            ucrInputTricotData.SetText("Cannot get data information.")
            Exit Sub
        End If
        Select Case chrOutput(0)
            Case "0"
                bUniqueChecked = False
                ucrInputTricotData.SetText("Need ID level data to proceed. If you have an ID variable, are they all unique?")
                ucrInputTricotData.txtInput.BackColor = Color.LightCoral
            Case "1"
                bUniqueChecked = False
                ucrInputTricotData.SetText("Multiple data frames given at ID level. Should only have one data frame at each level.")
                ucrInputTricotData.txtInput.BackColor = Color.LightCoral
            Case "2"
                bUniqueChecked = False
                ucrInputTricotData.SetText("Tricot Data not found. Try using Options.")
                ucrInputTricotData.txtInput.BackColor = Color.LightCoral
            Case Else
                bUniqueChecked = True
                Cursor = Cursors.WaitCursor
                expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsOutputLevelsOperator.ToScript(), bSeparateThread:=False, bShowWaitDialogOverride:=False)
                Cursor = Cursors.Default
                If expTemp IsNot Nothing Then
                    strFormNames = expTemp.AsCharacter().ToArray()
                    ucrInputTricotData.SetName(String.Join(", ", strFormNames))
                End If
                ucrInputTricotData.txtInput.BackColor = Color.LightGreen
        End Select
        TestOKEnabled()
    End Sub

End Class