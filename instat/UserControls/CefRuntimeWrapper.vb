Imports System.IO
Imports CefSharp
Imports CefSharp.SchemeHandler
Imports CefSharp.WinForms
'''------------------------------------------------------------------------------------------------
''' <summary>
''' <para>
''' Note: This class is intended to be used solely as a 'static' class (i.e. contains only shared 
''' members, cannot be instantiated and cannot be inherited from).
''' In order to enforce this (and prevent developers from using this class in an unintended way), 
''' the class is declared as 'NotInheritable` and the constructor is declared as 'Private'.
''' </para>
''' </summary>
''' '''------------------------------------------------------------------------------------------------
Public NotInheritable Class CefRuntimeWrapper



    '''--------------------------------------------------------------------------------------------
    ''' <summary> 
    ''' Declare constructor 'Private' to prevent instantiation of this class (see class comments 
    ''' for more details). 
    ''' </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub New()
    End Sub

    Public Shared Function initialiseCefRuntime() As Boolean

        If isCefInitilised() Then
            Return False
        End If


        'If ANYCPU Then
        CefRuntime.SubscribeAnyCpuAssemblyResolver()
        'End If

        'Programmatically enable DPI Aweness
        'Can also be done via app.manifest Or app.config
        'https://github.com/cefsharp/CefSharp/wiki/General-Usage#high-dpi-displayssupport
        'If set via app.manifest this call will have no effect.
        'Cef.EnableHighDPISupport()

        Dim settings As New CefSettings()
        'By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
        settings.CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache")

        'Example of setting a command line argument
        'Enables WebRTC
        ' - CEF Doesn't currently support permissions on a per browser basis see https://bitbucket.org/chromiumembedded/cef/issues/2582/allow-run-time-handling-of-media-access
        ' - CEF Doesn't currently support displaying a UI for media access permissions
        '
        'NOTE: WebRTC Device Id's aren't persisted as they are in Chrome see https://bitbucket.org/chromiumembedded/cef/issues/2064/persist-webrtc-deviceids-across-restart
        settings.CefCommandLineArgs.Add("enable-media-stream")
        'https://peter.sh/experiments/chromium-command-line-switches/#use-fake-ui-for-media-stream
        settings.CefCommandLineArgs.Add("use-fake-ui-for-media-stream")
        'For screen sharing add (see https://bitbucket.org/chromiumembedded/cef/issues/2582/allow-run-time-handling-of-media-access#comment-58677180)
        settings.CefCommandLineArgs.Add("enable-usermedia-screen-capturing")

        'todo. explore this further once we find the limitations of File:///
        'settings.RegisterScheme(GetCustomSheme())

        'Perform dependency check to make sure all relevant resources are in our output directory.
        Dim k = Cef.Initialize(settings, performDependencyCheck:=True, browserProcessHandler:=Nothing)

        Return True

    End Function

    'todo. left here for future reference
    Private Shared Function GetCustomSheme() As CefCustomScheme
        Dim cefCustomScheme As New CefCustomScheme
        cefCustomScheme.SchemeName = "rinstat_temp_local_folder"
        cefCustomScheme.DomainName = "rinstat_output"
        cefCustomScheme.SchemeHandlerFactory = New FolderSchemeHandlerFactory(
            rootFolder:="C:\RInstatInstallationFolder\tempfiles",
            hostName:="rinstat_output",
            defaultPage:="rinstat_default_page.html")

        'usage example; strUrl = "rinstat_temp_local_folder://rinstat_output/anyFileDisplayable" 
        'browser.LoadUrl(strUrl)
        Return cefCustomScheme

    End Function



    Public Shared Function isCefInitilised() As Boolean
        Return Cef.IsInitialized
    End Function

    Public Shared Sub shutDownCef()
        Cef.Shutdown()
    End Sub




End Class
