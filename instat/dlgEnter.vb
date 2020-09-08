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
Public Class dlgEnter
    Dim dataset As DataFrame
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction
    Dim clsLength As New RFunction
    Public bFirstLoad As Boolean = True
    Public strOutput As String
    Public clsCommands As New RFunction

    Private Sub dlgEnter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub SetEntryHistory()
        ucrReceiverForEnterCalculation.AddtoCombobox(ucrReceiverForEnterCalculation.GetText)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 458
        ucrTryModelling.SetReceiver(ucrReceiverForEnterCalculation)
        ucrTryModelling.SetIsCommand()
        ucrTryModelling.StrvecOutputRequired()
        clsAttach.SetRCommand("attach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrDataFrameEnter.clsCurrDataFrame)
        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrDataFrameEnter.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveEnterResultInto.SetItemsTypeAsColumns()
        ucrSaveEnterResultInto.SetDefaultTypeAsColumn()
        ucrSaveEnterResultInto.SetDataFrameSelector(ucrDataFrameEnter)
        ucrSaveEnterResultInto.SetValidationTypeAsRVariable()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach)
    End Sub
    Private Sub SetDefaults()
        chkShowEnterArguments.Checked = False
        ucrDataFrameEnter.Reset()
        chkSaveEnterResultInto.Checked = True
        ucrSaveEnterResultInto.SetPrefix("Enter")
        ucrReceiverForEnterCalculation.Clear()
        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)
    End Sub
    Private Sub ReopenDialog()
        SaveResults()
    End Sub
    Private Sub TestOKEnabled()
        If Not ucrReceiverForEnterCalculation.IsEmpty Then
            If chkSaveEnterResultInto.Checked AndAlso Not ucrSaveEnterResultInto.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SaveResults()
        If chkSaveEnterResultInto.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveEnterResultInto.GetText(), strTempColumn:=ucrSaveEnterResultInto.GetText(), strTempDataframe:=ucrDataFrameEnter.cboAvailableDataFrames.Text, bRequireCorrectLength:=False)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        'Dim strScript As String = ""
        'Dim strFunc As String
        'clsAttach.AddParameter("what", clsRFunctionParameter:=ucrDataFrameEnter.clsCurrDataFrame)
        'strFunc = clsAttach.ToScript(strScript)
        ' frmMain.clsRLink.RunScript(strScript & strFunc)
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'Dim strScript As String = ""
        ' Dim strFunc As String
        'clsDetach.AddParameter("name", clsRFunctionParameter:=ucrDataFrameEnter.clsCurrDataFrame)
        'strFunc = clsDetach.ToScript(strScript)
        'frmMain.clsRLink.RunScript(strScript & strFunc)
        SetEntryHistory()
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForEnterCalculation.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForEnterCalculation.GetVariableNames(False))
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub
    Private Sub cmd0_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("0")
        TestOKEnabled()
    End Sub
    Private Sub cmd1_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("1")
        TestOKEnabled()
    End Sub

    Private Sub md2_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("2")
        TestOKEnabled()
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("3")
        TestOKEnabled()
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("4")
        TestOKEnabled()
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("5")
        TestOKEnabled()
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("6")
        TestOKEnabled()
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("7")
        TestOKEnabled()
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("8")
        TestOKEnabled()
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("9")
        TestOKEnabled()
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(":")
        TestOKEnabled()
    End Sub
    Private Sub cmdMissingValues_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("NA")
        TestOKEnabled()
    End Sub

    Private Sub cmdBrackets_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("( )", 2)
        TestOKEnabled()
    End Sub
    Private Sub cmdMinus_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("-")
        TestOKEnabled()
    End Sub

    Private Sub cmdDelete_Click_1(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.Backspace()
        TestOKEnabled()
    End Sub
    Private Sub cmdPi_Click(sender As Object, e As EventArgs) Handles cmdPi.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("pi")
        TestOKEnabled()
    End Sub

    Private Sub cmdMissingValues_Click_1(sender As Object, e As EventArgs) Handles cmdMissingValues.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("NA")
    End Sub

    Private Sub cmdSquareBrackets_Click_1(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("[ ]", 2)
        TestOKEnabled()
    End Sub

    Private Sub cmdExponential_Click_1(sender As Object, e As EventArgs) Handles cmdExponential.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("E")
        TestOKEnabled()
    End Sub
    Private Sub cmdConcantenateFunction_Click_1(sender As Object, e As EventArgs) Handles cmdConcantenateFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("c( ,recursive=FALSE)", 17)
        Else
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("c( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdRepelicationFunction_Click_1(sender As Object, e As EventArgs) Handles cmdRepelicationFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rep(x= ,times= ,length= ,each= )", 25)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rep( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdSequenceFunction_Click_1(sender As Object, e As EventArgs) Handles cmdSequenceFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq(from= ,to= ,by= )", 11)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdClear_Click_1(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.Clear()
        TestOKEnabled()
    End Sub

    Private Sub cmdLETTERS_Click(sender As Object, e As EventArgs) Handles cmdLETTERS.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("LETTERS")
        TestOKEnabled()
    End Sub

    Private Sub cmdLetters2_Click(sender As Object, e As EventArgs) Handles cmdLetters2.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("letters")
        TestOKEnabled()
    End Sub

    Private Sub cmdMonthMinus_Click(sender As Object, e As EventArgs) Handles cmdMonths.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("month.abb")
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveEnterResultInto_NameChanged() Handles ucrSaveEnterResultInto.NameChanged
        SaveResults()
    End Sub

    Private Sub ucrSaveEnterResultInto_ContentsChanged() Handles ucrSaveEnterResultInto.ContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub chkSaveEnterResultInto_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveEnterResultInto.CheckedChanged
        If chkSaveEnterResultInto.Checked Then
            ucrSaveEnterResultInto.Visible = True
        Else
            ucrSaveEnterResultInto.Visible = False
        End If
        SaveResults()
    End Sub

    ''' <summary>
    ''' displays a popup with example commands just above the input receiver
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExample_Click(sender As Object, e As EventArgs) Handles btnExample.Click
        Dim objPopup As New clsPopup
        Dim lstView As New ListView With {
            .Scrollable = True,
            .View = View.Details,
            .FullRowSelect = True,
            .ShowItemToolTips = True
        }

        'add a single column
        lstView.Columns.Add("Commands", 450)

        'add rows of sample commands
        lstView.Items.Add(New ListViewItem({"seq(9 )"}))
        lstView.Items.Item(0).ToolTipText = "seq(9 )" 'todo. sensible tooltip here.

        lstView.Items.Add(New ListViewItem({"LETTERS"}))
        lstView.Items.Item(1).ToolTipText = "LETTERS" 'todo. sensible tooltip here.

        lstView.Items.Add(New ListViewItem({"month.name"}))
        lstView.Items.Item(2).ToolTipText = "month.name" 'todo. sensible tooltip here.

        lstView.Items.Add(New ListViewItem({"month.abb"}))
        lstView.Items.Item(3).ToolTipText = "month.abb" 'todo. sensible tooltip here.


        AddHandler lstView.DoubleClick, Sub()
                                            If lstView.SelectedItems.Count > 0 Then
                                                ucrReceiverForEnterCalculation.Clear()
                                                ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(lstView.SelectedItems.Item(0).SubItems(0).Text)
                                                objPopup.Hide()
                                            End If
                                        End Sub

        objPopup.SetContentControl(lstView)
        objPopup.SetSize(ucrReceiverForEnterCalculation.Width, ucrReceiverForEnterCalculation.Height + 100)
        objPopup.Show(ucrReceiverForEnterCalculation)
    End Sub
    Private Sub cmd7_Click_1(sender As Object, e As EventArgs) Handles cmd7.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("7")
    End Sub

    Private Sub cmd8_Click_1(sender As Object, e As EventArgs) Handles cmd8.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("8")
    End Sub

    Private Sub cmd9_Click_1(sender As Object, e As EventArgs) Handles cmd9.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("9")
    End Sub

    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(".")
    End Sub

    Private Sub cmd4_Click_1(sender As Object, e As EventArgs) Handles cmd4.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("4")
    End Sub

    Private Sub cmd5_Click_1(sender As Object, e As EventArgs) Handles cmd5.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("5")
    End Sub

    Private Sub cmd6_Click_1(sender As Object, e As EventArgs) Handles cmd6.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("6")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmd1_Click_1(sender As Object, e As EventArgs) Handles cmd1.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("1")
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("2")
    End Sub

    Private Sub cmd3_Click_1(sender As Object, e As EventArgs) Handles cmd3.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("3")
    End Sub

    Private Sub cmdMinus_Click_1(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(",")
    End Sub

    Private Sub cmd0_Click_1(sender As Object, e As EventArgs) Handles cmd0.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("0")
    End Sub

    Private Sub cmdBrackets_Click_1(sender As Object, e As EventArgs) Handles cmdBrackets.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("()")
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForEnterCalculation.Clear()
    End Sub

    Private Sub cmdDate_Click(sender As Object, e As EventArgs) Handles cmdDate.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("as.date('')")
        Else
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("as.date('')", 3)
        End If
    End Sub

    Private Sub cmdDay_Click(sender As Object, e As EventArgs) Handles cmdDay.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("'day'")
    End Sub

    Private Sub cmdFactor_Click(sender As Object, e As EventArgs) Handles cmdFactor.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("factor( )", 2)
    End Sub

    Private Sub cmdMonth_Click(sender As Object, e As EventArgs) Handles cmdMonth.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("'month'")
    End Sub

    Private Sub cmdRnorm_Click(sender As Object, e As EventArgs) Handles cmdRnorm.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(" rnorm( )", 2)
    End Sub

    Private Sub cmdRunif_Click(sender As Object, e As EventArgs) Handles cmdRunif.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(" runif( )", 2)
    End Sub
End Class
