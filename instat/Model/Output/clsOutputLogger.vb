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
Imports System.IO
''' <summary>
''' Logging class to hold all scripts and outputs ran.
''' Holds multiple lists of outputs
''' </summary>
Public Class clsOutputLogger
    Private _filteredOutputs As List(Of clsOutputList)
    Private _outputElements As List(Of clsOutputElement)

    ''Output not used externally at the moment but will this will need to
    ''change if we are to remove from the output list.
    Public ReadOnly Property OutputElements As List(Of clsOutputElement)
        Get
            Return _outputElements
        End Get
    End Property

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        _outputElements = New List(Of clsOutputElement)
        _filteredOutputs = New List(Of clsOutputList)
    End Sub

    ''' <summary>
    ''' Event to show a new filtered list has been added
    ''' </summary>
    ''' <param name="listName"></param>
    Public Event NewFilteredListAdded(listName As String)

    ''' <summary>
    ''' Event to show a new output as been added
    ''' </summary>
    ''' <param name="outputElement"></param>
    Public Event NewOutputAdded(outputElement As clsOutputElement, bDisplayOutputInExternalViewer As Boolean)

    ''' <summary>
    ''' Event to show an output as been added to a new filtered list
    ''' </summary>
    ''' <param name="outputElement"></param>
    ''' <param name="listName"></param>
    Public Event NewOutputAddedToFilteredList(outputElement As clsOutputElement, listName As String)

    ''' <summary>
    ''' Holds a list of outputs that can be edited
    ''' </summary>
    ''' <returns></returns>
    Public Property FilteredOutputs() As List(Of clsOutputList)
        Get
            Return _filteredOutputs
        End Get
        Set(ByVal value As List(Of clsOutputList))
            _filteredOutputs = value
        End Set
    End Property

    Public Sub AddOutput(strScript As String, strOutput As String, bAsFile As Boolean, bDisplayOutputInExternalViewer As Boolean)
        ' Note this always takes the last script added as corresponding script
        If String.IsNullOrWhiteSpace(strScript) Then
            Throw New Exception("Cannot find script to attach output to.")
            Exit Sub
        End If

        ' Add the R script as an output element
        Dim rScriptElement As New clsOutputElement
        rScriptElement.SetContent(strScript, OutputType.Script, "")
        _outputElements.Add(rScriptElement)
        ' Raise event for output pages
        RaiseEvent NewOutputAdded(rScriptElement, False)

        ' Split the strOutput into an array of lines, removing empty entries
        Dim arrFilesPaths() As String = strOutput.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        For Each output In arrFilesPaths
            If Not String.IsNullOrEmpty(output) Then
                Dim outputElement As New clsOutputElement
                Dim outputType As OutputType

                If bAsFile Then
                    Dim strFileExtension As String = Path.GetExtension(output).ToLower
                    Select Case strFileExtension
                        Case ".png"
                            outputType = OutputType.ImageOutput
                        Case ".html"
                            outputType = OutputType.HtmlOutput
                        Case ".txt"
                            outputType = OutputType.TextOutput
                        Case Else
                            MessageBox.Show("The file type to be added is currently not supported", "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                    End Select
                Else
                    outputType = OutputType.TextOutput
                End If

                ' Add the output with its R script as another output element
                outputElement.SetContent("", outputType, output)
                _outputElements.Add(outputElement)
                ' Raise event for output pages
                RaiseEvent NewOutputAdded(outputElement, bDisplayOutputInExternalViewer)
            End If
        Next

    End Sub

    ''' <summary>
    ''' Adds an output to the given filtered list
    ''' </summary>
    ''' <param name="outputElement"></param>
    ''' <param name="strListName"></param>
    Public Sub AddOutputToFilteredList(outputElement As clsOutputElement, strListName As String)
        Dim filteredList As clsOutputList
        filteredList = GetFilteredList(strListName)
        outputElement.Id = filteredList.Output.Count + 1
        filteredList.Output.Add(outputElement)
        RaiseEvent NewOutputAddedToFilteredList(outputElement, strListName)
    End Sub

    ''' <summary>
    ''' Deletes output from a filtered list
    ''' </summary>
    ''' <param name="outputElement"></param>
    ''' <param name="strListName"></param>
    Public Sub DeleteOutputFromFilteredList(outputElement As clsOutputElement, strListName As String)
        Dim filteredList As clsOutputList
        filteredList = GetFilteredList(strListName, False)
        Dim elementId As Integer = outputElement.Id
        filteredList.Output.RemoveAll(Function(x) x.Id = elementId)
        For Each element In filteredList.Output.Where(Function(x) x.Id > elementId)
            element.Id -= 1
        Next
    End Sub

    ''' <summary>
    ''' Deletes output from main output list
    ''' </summary>
    ''' <param name="outputElement"></param>
    Public Sub DeleteOutputFromMainList(outputElement As clsOutputElement)
        _outputElements.RemoveAll(Function(x) x Is outputElement)
    End Sub

    ''' <summary>
    ''' Returns the filtered list given the name. Will create the list if doesnt already exist.
    ''' </summary>
    ''' <param name="strListName"></param>
    ''' <param name="bCreate"></param>
    ''' <returns></returns>
    Public Function GetFilteredList(strListName As String, Optional bCreate As Boolean = True) As clsOutputList
        Dim filteredList As clsOutputList
        filteredList = _filteredOutputs.Where(Function(x) x.StrName = strListName).FirstOrDefault()
        If filteredList Is Nothing And bCreate Then
            filteredList = New clsOutputList(strListName)
            _filteredOutputs.Add(filteredList)
            RaiseEvent NewFilteredListAdded(strListName)
        End If
        Return filteredList
    End Function

    ''' <summary>
    ''' Checks to see if list name is a valid name for a filtered list
    ''' </summary>
    ''' <param name="strListName"></param>
    ''' <returns></returns>
    Public Function IsValidFilteredListName(strListName As String) As Boolean
        If Trim(strListName) Is "" OrElse
            _filteredOutputs.Where(Function(x) x.StrName = strListName).Any() Then
            Return False
        End If
        Return True
    End Function

End Class