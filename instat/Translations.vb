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

Public Class Translations
    Public Shared Function translate(tag As String) As String
        ' Note: if the tag is not found in Resources then Nothing will be returned
        Return My.Resources.ResourceManager.GetObject(tag)
    End Function

    Public Shared Sub translateEach(controls As Control.ControlCollection)
        ' Given a ControlCollection, attempt to translate the Text property of each control
        Dim formControl As Control
        Dim originalTag As String
        Dim translatedString As String

        For Each formControl In controls
            If (TypeOf formControl Is Panel) Then
                ' Recursively translate all controls inside the panel
                translateEach(formControl.Controls)

            ElseIf (TypeOf formControl Is MenuStrip) Then
                ' Translate all MenuItems inside the MenuStrip
                translateMenu(formControl)


            ElseIf (TypeOf formControl Is UserControl) Then
                ' Translate all controls in a usercontrol
                translateEach(formControl.Controls)

            ElseIf (TypeOf formControl Is TextBox OrElse TypeOf formControl Is Button OrElse TypeOf formControl Is Label OrElse TypeOf formControl Is CheckBox) Then
                originalTag = formControl.Tag
                If (originalTag IsNot Nothing) Then
                    translatedString = My.Resources.ResourceManager.GetObject(originalTag)
                    If (translatedString IsNot Nothing) Then
                        formControl.Text = translatedString
                    End If
                End If
            End If
        Next formControl
    End Sub

    Public Shared Sub autoTranslate(frm As Form)
        Dim translatedString As String

        ' Attempt to translate the form's title if it has a tag
        If frm.Tag IsNot Nothing Then
            translatedString = My.Resources.ResourceManager.GetObject(frm.Tag)
            If (translatedString IsNot Nothing) Then
                frm.Text = translatedString
            End If
        End If
        ' Translate all controls in object
        translateEach(frm.Controls)
    End Sub

    ' translateMenu and translateSubMenu should not be neccessary if we can improve translateEach to accept any iterable
    Public Shared Sub translateMenu(menuControl As MenuStrip)
        Dim item As ToolStripMenuItem
        Dim originalTag As String
        Dim translatedString As String

        For Each item In menuControl.Items
            ' process this item, then recursively process any sub items
            If item.HasDropDownItems Then
                translateSubMenu(item.DropDownItems)
            End If
            originalTag = item.Tag
            If (originalTag IsNot Nothing) Then
                translatedString = My.Resources.ResourceManager.GetObject(originalTag)
                If (translatedString IsNot Nothing) Then
                    item.Text = translatedString
                End If
            End If
        Next item
    End Sub

    ' translateMenu and translateSubMenu should not be neccessary if we can improve translateEach to accept any iterable
    Public Shared Sub translateSubMenu(subMenuControl As ToolStripItemCollection)
        Dim item
        Dim originalTag As String
        Dim translatedString As String

        For Each item In subMenuControl
            ' process this item, then recursively process any sub items
            If Not (TypeOf item Is ToolStripSeparator) Then

                If (item.hasdropdownitems()) Then
                    translateSubMenu(item.DropDownItems)
                End If
                originalTag = item.Tag
                If (originalTag IsNot Nothing) Then
                    translatedString = My.Resources.ResourceManager.GetObject(originalTag)
                    If (translatedString IsNot Nothing) Then
                        item.Text = translatedString
                    End If
                End If
            End If
        Next item
    End Sub
End Class
