Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports RDotNet

Namespace R_Adapter.RLink
    Public Class RConnector
        Private Shared ReadOnly log As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()
        Private _rEngine As REngine

        Protected Function IsConnectedToR() As Boolean
            If _rEngine IsNot Nothing Then
                Return _rEngine.IsRunning
            Else
                Return False
            End If
        End Function

        Public Function Connect() As Boolean
            Try
                _rEngine = REngine.GetInstance()
                _rEngine.Initialize()
                log.Info("Succesfully connected to R")
            Catch ex As Exception
                log.[Error](ex, "Could not connect to R")
                Return False
            End Try

            Return True
        End Function

        Public Function Diconnect() As Boolean
            If _rEngine IsNot Nothing Then

                Try
                    _rEngine.Dispose()
                    log.Info("Succesfully disposed the connection to R")
                Catch ex As Exception
                    log.[Error](ex, "Could not dispose for the connection to R")
                    Return False
                End Try
            End If

            Return True
        End Function

        Public Sub SetEnviromentVariables(ByVal rPath As String, ByVal rHome As String)
            log.Info("R Home: " & rHome)
            log.Info("R Path: " & rPath)

            If Directory.Exists(rHome) And Directory.Exists(rPath) Then
                log.Info("Using bundled R")
                REngine.SetEnvironmentVariables(rPath, rHome)
            Else
                REngine.SetEnvironmentVariables()
            End If
        End Sub

        'ToDo should be protected
        Public Function GetSymbol(ByVal strSymbol As String, ByVal Optional bSilent As Boolean = False) As SymbolicExpression
            Dim expTemp As SymbolicExpression = Nothing

            If _rEngine IsNot Nothing Then

                Try
                    expTemp = _rEngine.GetSymbol(strSymbol)
                    log.Trace("Retrived symbol: " & strSymbol)
                Catch ex As Exception
                    log.[Error](ex, "The error occurred in attempting to retrieve: " & strSymbol)
                    Return Nothing
                End Try
            End If

            Return expTemp
        End Function

        Public Function Evaluate(ByVal strScript As String) As Boolean
            If _rEngine IsNot Nothing Then

                Try
                    _rEngine.Evaluate(strScript)
                    log.Trace("Ran script: " & strScript)
                Catch ex As Exception
                    log.[Error](ex, "The error occurred in attempting to run the following R command(s): " & strScript)
                    Return False
                End Try
            End If

            Return True
        End Function
    End Class
End Namespace

