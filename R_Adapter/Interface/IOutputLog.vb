Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace R_Adapter.Interface
    Interface IOutputLog
        Sub AddScript(ByVal script As String)
        Sub AddTextOutput(ByVal text As String)

        'ToDo Add other outputs
    End Interface
End Namespace
