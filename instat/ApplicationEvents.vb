Namespace My
    ''' <summary> 
    ''' The 'My' namespace and the 'My.Application' objects are part of the dotnet framework.
    ''' This class extends the 'My.Application' object by creating a Partial class named MyApplication.
    ''' This class handles the event raised when R-Instat is launched when it's already running.
    ''' For more details on extending 'My.Application', please see: 
    ''' https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/customizing-extending-my/extending-the-my-namespace 
    ''' </summary>
    Partial Friend Class MyApplication
        ''' <summary>   Handles the event raised when launching a single-instance application. 
        '''             If the event was triggered by double-clicking on a data file, then the sub 
        '''             opens R-Instat (if not already running), displays the import dataset dialog 
        '''             and populates the dialog with the double-clicked file's path. 
        '''             If the event was triggered by just starting the R-Instat executable, then 
        '''             the sub displays a message box informing the user that R-Instat is already 
        '''             running.</summary>
        '''
        ''' <param name="sender">   Source of the event. </param>
        ''' <param name="e">        Startup next instance event information. </param>
        '''----------------------------------------------------------------------------------------
        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            Dim strPath As String
            If e.CommandLine.Count > 0 Then
                frmMain.TopMost = True 'Needed to force the window above the other windows
                frmMain.TopMost = False 'After the window being above other windows this will allow going to other windows
                If Application.OpenForms.OfType(Of dlgImportDataset).Any Then
                    strPath = Replace(e.CommandLine(0).ToString, "\", "/")
                    dlgImportDataset.ucrInputFilePath.SetName(strPath)
                Else
                    If frmMain.WindowState <> FormWindowState.Maximized Then
                        frmMain.WindowState = FormWindowState.Normal
                        dlgImportDataset.strFileToOpenOn = e.CommandLine(0)
                        dlgImportDataset.bStartOpenDialog = False
                        dlgImportDataset.ShowDialog()
                    Else
                        frmMain.WindowState = FormWindowState.Maximized
                        dlgImportDataset.strFileToOpenOn = e.CommandLine(0)
                        dlgImportDataset.bStartOpenDialog = False
                        dlgImportDataset.ShowDialog()
                    End If
                End If
            Else
                frmMain.TopMost = True 'Needed to force the window above the other windows
                frmMain.TopMost = False 'After the window being above other windows this will allow going to other windows
            End If
        End Sub
    End Class
End Namespace
