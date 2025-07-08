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
    Private clsAttach As New RFunction
    Private clsDetach As New RFunction
    Private clsAttachScalarsFunction, clsDetachScalarsFunction, clsScalarsDataFuntion, clsAddScalarFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private strPackageName As String

    Private Sub dlgEnter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub SetEntryHistory()
        ucrReceiverForEnterCalculation.AddtoCombobox(ucrReceiverForEnterCalculation.GetText)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 458

        ucrSelectorEnter.SetItemType("scalar")
        ucrSelectorEnter.HideShowAddOrDataOptionsOrListView(bAddVisible:=False, bDataOptionsVisible:=False, bListVariables:=False)

        ucrReceiverForEnterCalculation.strSelectorHeading = "Scalars"
        ucrReceiverForEnterCalculation.Selector = ucrSelectorEnter

        ucrTryModelling.SetReceiver(ucrReceiverForEnterCalculation)
        ucrTryModelling.SetIsCommand()
        ucrTryModelling.StrvecOutputRequired()

        ucrChkStoreScalar.SetText("Store Scalar")

        clsAddScalarFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_scalar")

        clsScalarsDataFuntion.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_scalars")
        clsScalarsDataFuntion.SetAssignTo("scalars")

        clsAttachScalarsFunction.SetRCommand("attach")
        clsDetachScalarsFunction.SetRCommand("detach")
        clsAttachScalarsFunction.AddParameter("what", clsRFunctionParameter:=clsScalarsDataFuntion)
        clsDetachScalarsFunction.AddParameter("name", "scalars")
        clsDetachScalarsFunction.AddParameter("unload", "TRUE")

        clsAttach.SetRCommand("attach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorEnter.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("unload", "TRUE")

        ucrBase.clsRsyntax.SetCommandString("")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach, 0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttachScalarsFunction, 1)

        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach, 0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetachScalarsFunction, 1)

        ucrSaveEnterResultInto.SetPrefix("enter")
        ucrSaveEnterResultInto.SetDataFrameSelector(ucrSelectorEnter.ucrAvailableDataFrames)
        ucrSaveEnterResultInto.SetIsComboBox()
        ucrSaveEnterResultInto.SetSaveTypeAsColumn()
        ucrSaveEnterResultInto.SetCheckBoxText("Enter Result")
        ucrSaveEnterResultInto.SetAssignToIfUncheckedValue("last_enter")

        ucrSaveEnterResultInto.SetPrefix("enter")
        ucrSaveEnterResultInto.SetSaveTypeAsColumn()
        ucrSaveEnterResultInto.SetIsComboBox()
        ucrSaveEnterResultInto.SetCheckBoxText("Enter Result")
        ucrSaveEnterResultInto.SetAssignToIfUncheckedValue("last_enter")
        ucrSaveEnterResultInto.SetDataFrameSelector(ucrSelectorEnter.ucrAvailableDataFrames)

        'Adding tooltips for the buttons
        ttEnter.SetToolTip(cmdColon, "A subset, e.g. letters[1:4] gives a, b, c, d.")
        ttEnter.SetToolTip(cmdLetters2, "The letters, e.g. letters[1:4] gives a, b, c, d. Type LETTERS[1:4] for A, B, C, D.")
        ttEnter.SetToolTip(cmdFactor, "e.g. forcats::as_factor(""B"", ""c"", ""A"") to make the contents into a factor variable with the levels in the order as entered, so here B is the lowest level.")
        ttEnter.SetToolTip(cmdRepelicationFunction, "Repeat of a sequence, e.g. rep(c(2, 3, 4), each=2) gives 2, 2, 3, 3, 4, 4.")
        ttEnter.SetToolTip(cmdMonths, "month.abb[1:4] is ""Jan2"", ""Feb"", ""Mar"", ""Apr"". Type month.name for full month names.")
        ttEnter.SetToolTip(cmdText, "Define a character variable, e.g. as.character(c(3, 5, ""a"", ""b"")).")
        ttEnter.SetToolTip(cmdSequenceFunction, "Sequences, given either as seq(1, 5, 2) to give 1, 3, 5 or as seq(1, 5, length = 3) to give the same.")
        ttEnter.SetToolTip(cmdPi, "The number pi = 3.14...")
        ttEnter.SetToolTip(cmdLogical, " Define a logical variable, e.g. as.logical(0, 1, 0, 10, -5) gives FALSE, TRUE, FALSE, TRUE, TRUE.")
        ttEnter.SetToolTip(cmdConcantenateFunction, "Combines arguments to form a single vector, e.g. c(1:3 8) is 1, 2, 3, 8.")
        ttEnter.SetToolTip(cmdExponential, "For scientific notation, e.g. 1.5E-1 = 0.15.")

    End Sub

    Private Sub checkScalars_CheckedChanged(sender As Object, e As EventArgs) Handles checkScalars.CheckedChanged
        If checkScalars.Checked Then
            ucrSelectorEnter.HideShowAddOrDataOptionsOrListView(bAddVisible:=True, bDataOptionsVisible:=False, bListVariables:=True)
        Else
            ucrSelectorEnter.HideShowAddOrDataOptionsOrListView(bAddVisible:=False, bDataOptionsVisible:=False, bListVariables:=False)
        End If
    End Sub

    Private Sub SetDefaults()
        chkShowEnterArguments.Checked = False
        ucrChkStoreScalar.Checked = False
        ucrSelectorEnter.Reset()
        checkScalars.Checked = False
        ucrSaveEnterResultInto.ucrChkSave.Checked = True
        ucrReceiverForEnterCalculation.Clear()
        ucrReceiverForEnterCalculation.SetMeAsReceiver()
        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)
        ucrSaveEnterResultInto.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString)
        SaveResults()
        ucrBase.clsRsyntax.SetAssignTo(ucrSaveEnterResultInto.GetText(), strTempColumn:=ucrSaveEnterResultInto.GetText(),
                                           strTempDataframe:=ucrSelectorEnter.ucrAvailableDataFrames.cboAvailableDataFrames.Text,
                                           bAssignToIsPrefix:=ucrBase.clsRsyntax.clsBaseCommandString.bAssignToIsPrefix,
                                           bAssignToColumnWithoutNames:=ucrBase.clsRsyntax.clsBaseCommandString.bAssignToColumnWithoutNames,
                                           bInsertColumnBefore:=ucrBase.clsRsyntax.clsBaseCommandString.bInsertColumnBefore,
                                           bRequireCorrectLength:=ucrBase.clsRsyntax.clsBaseCommandString.bRequireCorrectLength)
    End Sub

    Private Sub ReopenDialog()
        SaveResults()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForEnterCalculation.IsEmpty AndAlso ucrSaveEnterResultInto.IsComplete AndAlso
            (ucrChkStoreScalar.Checked OrElse ucrSaveEnterResultInto.ucrChkSave.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SaveResults()
        If ucrSaveEnterResultInto.IsComplete AndAlso ucrSaveEnterResultInto.ucrChkSave.Checked Then
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
        ManageScalarStorage()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        SetEntryHistory()
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForEnterCalculation.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForEnterCalculation.GetVariableNames(False))
        ucrChkStoreScalar.Checked = False
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("[:]", 2)
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

    Private Sub cmdPi_Click(sender As Object, e As EventArgs) Handles cmdPi.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("pi")
        TestOKEnabled()
    End Sub

    Private Sub cmdMissingValues_Click_1(sender As Object, e As EventArgs) Handles cmdQuotes.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(Chr(34) & "" & Chr(34), 1)
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
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("c( , recursive = FALSE)", 20)
        Else
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("c( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdRepelicationFunction_Click_1(sender As Object, e As EventArgs) Handles cmdRepelicationFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rep(x = , times = , length = , each = )", 32)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rep( , )", 4)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdSequenceFunction_Click_1(sender As Object, e As EventArgs) Handles cmdSequenceFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq(from = , to = , by = , length =  )", 27)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdLETTERS_Click(sender As Object, e As EventArgs) Handles cmdLogical.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("as.logical(c( ))", 3)
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
        lstView.Items.Add(New ListViewItem({"4.5"}))
        lstView.Items.Item(0).ToolTipText = "A single number repeated for the data frame." 'todo. sensible tooltip here.

        lstView.Items.Add(New ListViewItem({"""Nairobi"""}))
        lstView.Items.Item(1).ToolTipText = "A single text repeated for the data frame." 'todo. Sensible tooltip here.

        lstView.Items.Add(New ListViewItem({"c(2, 3, 4)*1.5E02"}))
        lstView.Items.Item(2).ToolTipText = "Gives 300, 450, 600 then repeated for the data frame." 'todo. Sensible tooltip here

        lstView.Items.Add(New ListViewItem({"factor(c(1, 2, 3))"}))
        lstView.Items.Item(3).ToolTipText = "Values 1 to 3 with the variable made into a factor ." 'todo. Sensible tooltip here

        lstView.Items.Add(New ListViewItem({"forcats::as_factor(rep(LETTERS[4:1], c(4, 3, 1, 1)))"}))
        lstView.Items.Item(4).ToolTipText = "Gives D, D, D, D, C, C, C, B, A as a factor."

        lstView.Items.Add(New ListViewItem({"forcats::as_factor(rep(c(month.abb[4:7], NA), c(2, 1, 2, 1, 3)))"}))
        lstView.Items.Item(5).ToolTipText = "Gives Apr, Apr, May, Jun, Jun, Jul, NA, NA, NA."

        lstView.Items.Add(New ListViewItem({"c(1:4, 10, rep(15, 3), 20)"}))
        lstView.Items.Item(6).ToolTipText = "A sequence of values 1, 2, 3, 4, 10, 15, 15, 15, 20."

        lstView.Items.Add(New ListViewItem({"c(0,seq(1, 5, 2 ), seq(10, 12), 15, 15)"}))
        lstView.Items.Item(7).ToolTipText = "A set of sequences, giving  0, 1, 3, 5, 10, 11, 12, 15, 15."

        lstView.Items.Add(New ListViewItem({"runif(3, c(0, 5, 10), c(1, 10, 20))"}))
        lstView.Items.Item(8).ToolTipText = "Random uniform data from 3 different uniform distributions)."

        lstView.Items.Add(New ListViewItem({"seq(as.Date('1935/3/1'), as.Date('1937/12/1'), 'quarter')"}))
        lstView.Items.Item(9).ToolTipText = "A sequence of dates from 1935/3/1, 1935/6/1 ...)"




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

    Private Sub cmdDay_Click(sender As Object, e As EventArgs) Handles cmdText.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("as.character(c( ))", 2)
    End Sub

    Private Sub cmdFactor_Click(sender As Object, e As EventArgs) Handles cmdFactor.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("forcats::as_factor( )", 2)
    End Sub

    Private Sub cmdMonth_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("'month'")
    End Sub

    Private Sub cmdRnorm_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rnorm( )", 2)
    End Sub

    Private Sub cmdRunif_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("runif( )", 2)
    End Sub

    Private Sub cmdRHelp_Click(sender As Object, e As EventArgs) Handles cmdRHelp.Click, ToolStripMenuBase.Click
        strPackageName = "base"
        If Not String.IsNullOrEmpty(strPackageName) Then
            frmMaximiseOutput.Show(strFileName:=clsFileUrlUtilities.GetHelpFileURL(strPackageName:=strPackageName), bReplace:=False)
        End If
    End Sub

    Private Sub ucrSaveEnterResultInto_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveEnterResultInto.ControlValueChanged
        Dim strDataFrame As String = ucrSelectorEnter.ucrAvailableDataFrames.strCurrDataFrame

        clsDetach.AddParameter("name", strDataFrame)
        clsScalarsDataFuntion.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
        clsAddScalarFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub ManageScalarStorage()
        If ucrChkStoreScalar.Checked AndAlso Not ucrReceiverForEnterCalculation.IsEmpty Then
            Dim strResut As String = ucrSaveEnterResultInto.GetText
            clsAddScalarFunction.AddParameter("scalar_name", Chr(34) & strResut & Chr(34), iPosition:=1)
            clsAddScalarFunction.AddParameter("scalar_value", strResut, iPosition:=2)
            ucrBase.clsRsyntax.AddToAfterCodes(clsAddScalarFunction, 2)
            ucrBase.clsRsyntax.SetAssignTo(strResut)

            ucrSaveEnterResultInto.btnColumnPosition.Enabled = False
            ucrSaveEnterResultInto.ucrChkSave.Enabled = False
            ucrSaveEnterResultInto.ucrChkSave.Checked = False

        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddScalarFunction)
            ucrSaveEnterResultInto.btnColumnPosition.Enabled = True
            ucrSaveEnterResultInto.ucrChkSave.Enabled = True
        End If
        ucrSaveEnterResultInto.btnColumnPosition.Visible = True
        ucrSaveEnterResultInto.ucrInputComboSave.Visible = True
        ucrSaveEnterResultInto.ucrInputComboSave.Enabled = True
        TestOKEnabled()
    End Sub

    Private Sub ucrChkStoreScalar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStoreScalar.ControlValueChanged
        ManageScalarStorage()
    End Sub

    Private Sub ucrSaveEnterResultInto_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveEnterResultInto.ControlContentsChanged
        SaveResults()
    End Sub
End Class
