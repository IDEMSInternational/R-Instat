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

Public Class dlgFromLibrary
    Private strLibraryTemp As String = "dfLibrary"
    Private strPackages As String = "dfPackagesList"
    Private strLibraryPath As String = frmMain.strStaticPath & "\" & "Library"
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDataFunction As New RFunction
    Private dctPackages As New Dictionary(Of String, String)

    'a string array that holds the packages displayed in the combobox 
    'todo. this property can be removed once the PR that enhances the inputCombobox control is merged
    Private arrAvailablePackages() As String

    Private strSelectedPackage As String = ""
    Private clsImportFunction As New RFunction 'the base function that call on import R-Instat function

    Private Sub dlgFromLibrary_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)

        If lstCollection.SelectedItems.Count > 0 Then
            'make the listview have the focus
            lstCollection.Select()
            'set the selected item to be visible 
            lstCollection.TopItem = lstCollection.Items(lstCollection.Items.IndexOf(lstCollection.SelectedItems.Item(0)))
        End If

        bReset = False
        TestOkEnabled()
        EnableHelp()
    End Sub

    Private Sub InitialiseDialog()
        Dim clsGetPackages As New RFunction
        Dim expPackageNames As SymbolicExpression
        Dim chrPackageNames As CharacterVector

        ucrBase.iHelpTopicID = 156

        lstCollection.HideSelection = False

        clsGetPackages.SetRCommand("get_installed_packages_with_data")
        expPackageNames = frmMain.clsRLink.RunInternalScriptGetValue(clsGetPackages.ToScript(), bSilent:=True)
        If expPackageNames IsNot Nothing AndAlso expPackageNames.Type <> Internals.SymbolicExpressionType.Null Then
            chrPackageNames = expPackageNames.AsCharacter
            arrAvailablePackages = chrPackageNames.ToArray
            Array.Sort(arrAvailablePackages)
            ucrInputPackages.SetParameter(New RParameter("package")) 'for combobox, can't set items without setting parameter first
            ucrInputPackages.SetItems(arrAvailablePackages, bAddConditions:=True)
        End If

        ucrInputPackages.SetDropDownStyleAsNonEditable()
        ucrInputPackages.SetLinkedDisplayControl(lblFromPackage)

        ucrPnlOptions.AddRadioButton(rdoDefaultDatasets)
        ucrPnlOptions.AddRadioButton(rdoInstatCollection)
        ucrPnlOptions.AddRSyntaxContainsFunctionNamesCondition(rdoDefaultDatasets, {"data"})
        ucrPnlOptions.AddRSyntaxContainsFunctionNamesCondition(rdoInstatCollection, {"data"}, False)
        ucrPnlOptions.AddToLinkedControls(ucrInputPackages, {rdoDefaultDatasets}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOptions.AddToLinkedControls(ucrNewDataFrameName, {rdoDefaultDatasets}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)

        ucrNewDataFrameName.SetSaveTypeAsDataFrame()
        ucrNewDataFrameName.SetLabelText("New Data Frame Name:")
        ucrNewDataFrameName.SetIsTextBox()
    End Sub

    Private Sub SetDefaults()
        'reset the functions and the custom controls
        ucrNewDataFrameName.SetName("") 'called here cause its not called in the control's reset method
        ucrNewDataFrameName.Reset()
        clsDataFunction.Clear()
        clsImportFunction.Clear()

        'set up the data function
        clsDataFunction.SetPackageName("utils")
        clsDataFunction.SetRCommand("data")
        clsDataFunction.AddParameter("package", Chr(34) & "datasets" & Chr(34))

        'set up the import data function
        clsImportFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")

        'add the before codes (the data() R base function) and the base function(import_data() R-Instat function)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsDataFunction)
        ucrBase.clsRsyntax.SetBaseRFunction(clsImportFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        If arrAvailablePackages IsNot Nothing Then
            ucrInputPackages.SetRCode(clsDataFunction, bReset)
        End If
        ucrPnlOptions.SetRSyntax(ucrBase.clsRsyntax, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(bReset)
        TestOkEnabled()
        EnableHelp()
    End Sub

    Private Sub cmdLibraryCollection_Click(sender As Object, e As EventArgs) Handles cmdLibraryCollection.Click
        dlgImportDataset.bFromLibrary = True 'set flag that this should open from library
        dlgImportDataset.bStartOpenDialog = True
        dlgImportDataset.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged
        'this is done manually as because lstCollection doesnt inherit from core 
        If rdoDefaultDatasets.Checked Then
            lstCollection.Visible = True
            cmdLibraryCollection.Visible = False
            ucrBase.clsRsyntax.AddToBeforeCodes(clsDataFunction)
        Else
            lstCollection.Visible = False
            cmdLibraryCollection.Visible = True
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsDataFunction)
        End If
        TestOkEnabled()
        EnableHelp()
    End Sub

    Private Sub FillListView(dfDataframe As DataFrame)
        Dim lstItem As ListViewItem

        lstCollection.Items.Clear()
        If dfDataframe IsNot Nothing Then
            For i As Integer = 0 To dfDataframe.RowCount - 1
                lstItem = lstCollection.Items.Add(dfDataframe(i, 0))
                If dfDataframe.ColumnCount > 1 Then
                    lstItem.SubItems.Add(dfDataframe(i, 1))
                Else
                    lstItem.SubItems.Add("")
                End If
            Next
            lstCollection.Select()
        End If
    End Sub

    Private Sub LoadDatasets(strPackage As String)
        Dim expTemp As SymbolicExpression
        Dim dfPackage As DataFrame = Nothing

        If strPackage IsNot Nothing Then
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue("data.frame(data(package =" & Chr(34) & strPackage & Chr(34) & ")$results)[ ,3:4]", bSilent:=True)
            If expTemp IsNot Nothing Then
                dfPackage = expTemp.AsDataFrame
            End If
        End If
        FillListView(dfDataframe:=dfPackage)
    End Sub

    Private Sub ucrInputPackages_ControlValueChanged() Handles ucrInputPackages.ControlValueChanged
        If strSelectedPackage <> ucrInputPackages.GetText() Then
            strSelectedPackage = ucrInputPackages.GetText()
            LoadDatasets(strSelectedPackage)
            TestOkEnabled()
            EnableHelp()
        End If

    End Sub

    Private Sub lstCollection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCollection.SelectedIndexChanged

        If lstCollection.SelectedItems.Count > 0 Then
            If Not ucrNewDataFrameName.bUserTyped Then
                'this will raise event ControValueChanged for this control, which will inturn call SetParameterValues()
                ucrNewDataFrameName.SetName(CheckString(lstCollection.SelectedItems(0).SubItems(0).Text))
            Else
                SetParameterValues()
            End If
        End If
        TestOkEnabled()
        EnableHelp()
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(rdoDefaultDatasets.Checked AndAlso lstCollection.SelectedItems.Count > 0 AndAlso ucrNewDataFrameName.IsComplete)
    End Sub

    Private Sub EnableHelp()
        cmdHelp.Enabled = rdoDefaultDatasets.Checked AndAlso lstCollection.SelectedItems.Count > 0
    End Sub

    Private Function CheckString(ByVal strValue As String)
        Dim strLength As Integer = strValue.IndexOf(" ")
        If strLength = -1 Then
            Return strValue
        Else
            Return strValue.Substring(0, strLength)
        End If
    End Function

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim clsHelp As New RFunction
        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("topic", Chr(34) & lstCollection.SelectedItems(0).Text & Chr(34))
        clsHelp.AddParameter("package", Chr(34) & ucrInputPackages.cboInput.SelectedItem & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page for" & " " & lstCollection.SelectedItems(0).Text & " " & "dataset. Generated from dialog Open Dataset from Library", iCallType:=2, bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Private Sub ucrNewDataFrameName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDataFrameName.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrNewDataFrameName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewDataFrameName.ControlValueChanged
        SetParameterValues()
    End Sub

    ''' <summary>
    ''' sets the R parameters and functions used by the main import function
    ''' in importing datasets of different R types 
    ''' </summary>
    Private Sub SetParameterValues()
        Dim strSelectedDataName As String
        Dim strVecOutput As CharacterVector
        Dim strRClass As String = ""

        If lstCollection.SelectedItems.Count < 1 Then
            Exit Sub
        End If

        strSelectedDataName = CheckString(lstCollection.SelectedItems(0).SubItems(0).Text)
        clsDataFunction.AddParameter("X", strSelectedDataName)

        'calling RunInternalScriptGetOutput() twice because currently it can't execute multiple lines
        frmMain.clsRLink.RunInternalScriptGetOutput(clsDataFunction.Clone.ToScript(), bSilent:=True)
        strVecOutput = frmMain.clsRLink.RunInternalScriptGetOutput("class(" + strSelectedDataName + ")", bSilent:=True)
        If strVecOutput IsNot Nothing AndAlso strVecOutput.Length > 0 Then
            strRClass = Mid(strVecOutput(0), 5).Replace("""", "").ToLower
        End If

        If strRClass = "list" Then
            clsImportFunction.AddParameter("data_tables", strParameterValue:=strSelectedDataName)
        Else
            Dim clsListFunction As New RFunction 'defines the list function. list(x=x)
            Dim clsListParameterFunction As New RFunction 'defines the function that act as list parameters e.g list(y=fortify.zoo(x))
            clsListFunction.SetRCommand("list")
            Select Case strRClass
                Case "zoo"
                    'this is the recommended command for converting zoo object types to data frames.
                    'In R-Instat the data.frame doesn't convert this object type well. See issue #5649
                    clsListParameterFunction.SetPackageName("zoo")
                    clsListParameterFunction.SetRCommand("fortify.zoo")
                    clsListParameterFunction.AddParameter("model", strParameterValue:=strSelectedDataName)
                    clsListFunction.AddParameter(ucrNewDataFrameName.GetText, clsRFunctionParameter:=clsListParameterFunction)
                Case "spatialpolygonsdataframe"
                    'for some reason, objects of this type have to be explicitly coerced to data.frame 
                    'before being imported by import R-Instat function
                    clsListParameterFunction.SetRCommand("data.frame")
                    clsListParameterFunction.AddParameter("x", strParameterValue:=strSelectedDataName)
                    clsListFunction.AddParameter(ucrNewDataFrameName.GetText, clsRFunctionParameter:=clsListParameterFunction)
                Case "dgcmatrix", "dscmatrix"
                    'this if block is used for dgcmatrix,dscmatrix.
                    'The R summary() function returns an object of type data.frame if given a matrix. Used here to coerce it to data.frame
                    'todo. this needs to be investigated further on the best(correct) command for coercing this type of data. 
                    'the data.frame command is unable to coerce data of this class type hence it's own block form the matrix command
                    clsListParameterFunction.SetRCommand("summary")
                    clsListParameterFunction.AddParameter("object", strParameterValue:=strSelectedDataName)
                    clsListFunction.AddParameter(ucrNewDataFrameName.GetText, clsRFunctionParameter:=clsListParameterFunction)
                Case "matrix"
                    'this if block is used for matrix type 
                    'this has been done in it's own block in anticipation of a correct way of coercing matrix to data frame
                    'currently this command loses data(some columns) of the matrix once it's coerced. See issue #5649
                    clsListParameterFunction.SetRCommand("data.frame")
                    clsListParameterFunction.AddParameter("x", strParameterValue:=strSelectedDataName)
                    clsListFunction.AddParameter(ucrNewDataFrameName.GetText, clsRFunctionParameter:=clsListParameterFunction)
                Case Else
                    clsListFunction.AddParameter(ucrNewDataFrameName.GetText, strParameterValue:=strSelectedDataName)
            End Select
            clsImportFunction.AddParameter("data_tables", clsRFunctionParameter:=clsListFunction)
        End If
    End Sub

End Class