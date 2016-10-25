'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports instat.Translations
Public Class dlgExportToOpenRefine
    Public bFirstLoad As Boolean = True
    Public clsWriteToCSV As New RFunction
    Private Sub dlgExportToOpenRefine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else

        End If
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        chkRefineBrowser.Checked = False
        ucrOpenRefineDataFrame.Reset()
        ucrInputDatasetName.Reset()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("rrefine::refine_upload")
    End Sub
    'Making sure that Ok is Enabled if the ucrInput has a name typed
    Private Sub TestOKEnabled()
        If ucrInputDatasetName.IsEmpty = True Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrInputDatasetName_ContentsChanged() Handles ucrInputDatasetName.ContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrOpenRefineDataFrame_DataFrameChanged() Handles ucrOpenRefineDataFrame.DataFrameChanged
        ucrInputDatasetName.SetName(ucrOpenRefineDataFrame.cboAvailableDataFrames.SelectedItem & "_clean_up")
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub



    'this provides the option opening the browser to access OpenRefine
    Private Sub chkOpenRefineBrowser_CheckedChanged(sender As Object, e As EventArgs) Handles chkRefineBrowser.CheckedChanged
        If chkRefineBrowser.Checked Then
            ucrBase.clsRsyntax.AddParameter("open.browser", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("open.browser", "FALSE")
        End If
    End Sub

    'In this dialog, we need to run two separate R functions. Since RSyntax only deals with one R command at a time, we add a sub that runs right before the rest by handling the "beforeClickOk" event, raised within the ucrBase
    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        'The first R function that needs to be run is write.csv
        clsWriteToCSV.SetRCommand("write.csv")
        'Then we add the relevant parameters...
        clsWriteToCSV.AddParameter("x", ucrOpenRefineDataFrame.cboAvailableDataFrames.SelectedItem)
        clsWriteToCSV.AddParameter("file", Chr(34) & ucrInputDatasetName.GetText & ".csv" & Chr(34))
        clsWriteToCSV.AddParameter("row.names", "FALSE")
        'Now that the RFunction clsWriteToCSV has been SetUp, we send the script (toscript) to the back-end via RLink.RunScript
        frmMain.clsRLink.RunScript(clsWriteToCSV.ToScript(), strComment:="Convert the data set to csv")

        'We also use this sub to setup the last parameters of the main R function (in RSyntax) as it will avoid changing the parameters each time the user changes the DataSetName, merely do it once and for all when the user clicks OK.
        ucrBase.clsRsyntax.AddParameter("project.name", Chr(34) & ucrInputDatasetName.GetText() & Chr(34))
        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & ucrInputDatasetName.GetText() & ".csv" & Chr(34))

    End Sub
End Class