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

Public Class frmSetupLoading
    Private dctMessagesLinks As Dictionary(Of String, String)
    Private iSelectedMessage As Integer

    Private Sub frmSetupLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dctMessagesLinks = New Dictionary(Of String, String)

        dctMessagesLinks.Add("Did you know: R-Instat was developed in Africa by African Maths Initiative (AMI)?" & Environment.NewLine & "Click here to find out more about AMI and the partners behind creating R-Instat.", "http://africandata.org")
        dctMessagesLinks.Add("Did you know: R-Instat started as a crowd funding campaign in 2015 by partners working across Africa." & Environment.NewLine & "Click here to view the original campaign website and see how it all began.", "http://chuffed.org/project/africandatainitiative")
        dctMessagesLinks.Add("Did you know: You can easily view a whole data frame in a separate window." & Environment.NewLine & "Just right click on the bottom sheets tab and select 'View'.", "")
        dctMessagesLinks.Add("Did you know: Importing data from many other statistics packages is easy. Go to 'File > Open From File...' and choose your file." & Environment.NewLine & "You can export for other packages as well with File > Export > Export Dataset...", "")
        dctMessagesLinks.Add("Did you know: R-Instat stores metadata on columns and data frames which you can edit. Go to View > Column Metadata... or Data Frame Metadata... to view and edit metadata.", "")
        dctMessagesLinks.Add("Have you tried: Describing all your variables at once." & Environment.NewLine & "Simply go to Describe > One Variable > Summarise or Graph and choose all your variables to start an exploration.", "")
        dctMessagesLinks.Add("Have you tried: Boxplots by a factor." & Environment.NewLine & "Boxplots are great visualisation and even better when using a second variable. Try adding a factor variable in the Factor receiver to compare across the factor levels.", "")
        dctMessagesLinks.Add("Have you tried: Using the library datasets." & Environment.NewLine & "Go to File > Open From Library... to see many interesting and real world datasets to explore.", "")
        dctMessagesLinks.Add("Looking for free statistics textbooks?" & Environment.NewLine & "Download the completely free CAST electronic and interactive textbooks for basic and advanced statistics. Click to find out more.", "http://cast.massey.ac.nz/")
        dctMessagesLinks.Add("Looking for training materials?" & Environment.NewLine & "University of Reading's 'Stats Made Simple' resources are freely available online for anyone to use to teach or learn. Click to find out more.", "http://www.reading.ac.uk/ssc/resourcepage/materials.php")
        dctMessagesLinks.Add("Looking for interesting case studies for teaching?" & Environment.NewLine & "The International Livestock Research Institute (ILRI) has freely available biometric case studies for anyone to use to teach or learn. Find the data sets in the R-Instat library and click to go to the ILRI website.", "https://www.ilri.org/biometrics/default.htm")

        Randomize()
        iSelectedMessage = CInt(Math.Ceiling(Rnd() * dctMessagesLinks.Count))
        lblMessage.Text = dctMessagesLinks.Keys(iSelectedMessage)
        If dctMessagesLinks.Values(iSelectedMessage) = "" Then
            lblMessage.Cursor = Cursors.Default
        Else
            lblMessage.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click
        Dim strHyperlink As String = ""

        strHyperlink = dctMessagesLinks.Values(iSelectedMessage)
        If strHyperlink <> "" Then
            Try
                Process.Start(strHyperlink)
            Catch ex As Exception
                MsgBox("Sorry, we couldn't open this link (" & strHyperlink & ")" & Environment.NewLine & ex.Message, "Cannot open link")
            End Try
        End If
    End Sub
End Class