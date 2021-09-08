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
        ucrTryModelling.SetReceiver(ucrReceiverForEnterCalculation)
        ucrTryModelling.SetIsCommand()
        ucrTryModelling.StrvecOutputRequired()
        clsAttach.SetRCommand("attach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrDataFrameEnter.clsCurrDataFrame)
        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrDataFrameEnter.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveEnterResultInto.SetPrefix("enter")
        ucrSaveEnterResultInto.SetDataFrameSelector(ucrDataFrameEnter)
        ucrSaveEnterResultInto.SetIsComboBox()
        ucrSaveEnterResultInto.SetSaveTypeAsColumn()
        ucrSaveEnterResultInto.SetLabelText("Enter Result Into:")

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

        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach)
    End Sub
    Private Sub SetDefaults()
        chkShowEnterArguments.Checked = False
        ucrDataFrameEnter.Reset()
        ucrReceiverForEnterCalculation.Clear()
        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)
        ucrSaveEnterResultInto.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString)
    End Sub
    Private Sub ReopenDialog()
        SaveResults()
    End Sub
    Private Sub TestOKEnabled()
        If Not ucrReceiverForEnterCalculation.IsEmpty AndAlso ucrSaveEnterResultInto.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SaveResults()
        If ucrSaveEnterResultInto.IsComplete Then
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
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rep( )", 2)
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

    Private Sub ucrSaveEnterResultInto_NameChanged()
        SaveResults()
    End Sub

    Private Sub ucrSaveEnterResultInto_ContentsChanged()
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
End Class
