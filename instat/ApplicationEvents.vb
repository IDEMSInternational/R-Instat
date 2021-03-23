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
        '''             and populates the dialog with the double-clicked file's path.</summary>
        '''
        ''' <param name="sender">   Source of the event. </param>
        ''' <param name="e">        Startup next instance event information. </param>
        '''----------------------------------------------------------------------------------------
        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            frmMain.TopMost = True 'Needed to force the window above the other windows
            frmMain.TopMost = False 'After the window is forced above other windows, this will allow other windows to be on top of this window
            If frmMain.isMinimised Then
                frmMain.WindowState = If(frmMain.isMaximised, FormWindowState.Maximized, FormWindowState.Normal)
            End If

            If e.CommandLine.Count > 0 Then
                If Application.OpenForms.OfType(Of dlgImportDataset).Any Then
                    dlgImportDataset.SetControlsFromFile(e.CommandLine(0).ToString)
                Else
                    dlgImportDataset.strFileToOpenOn = e.CommandLine(0)
                    dlgImportDataset.bStartOpenDialog = False
                    dlgImportDataset.ShowDialog()
                End If
            End If
        End Sub
    End Class
End Namespace
