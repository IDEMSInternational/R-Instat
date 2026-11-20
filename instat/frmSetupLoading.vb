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

Imports instat
Imports instat.Translations

Public Class frmSetupLoading
    Private dctMessagesLinks As Dictionary(Of String, String)
    Private iSelectedMessage As Integer

    Private Sub frmSetupLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dctMessagesLinks = New Dictionary(Of String, String)

        dctMessagesLinks.Add("Did you know R-Instat was developed through African collaborations?" & Environment.NewLine & "R-Instat was originally developed by African Maths Initiative (AMI), and development continues today with teams across Africa, including INNODEMS and GHAIDEMS.", "")
        dctMessagesLinks.Add("Did you know: R-Instat started as a crowd funding campaign in 2015 by partners working across Africa." & Environment.NewLine & "Click here to view the original campaign website and see how it all began.", "http://chuffed.org/project/africandatainitiative")
        dctMessagesLinks.Add("Did you know: You can easily view a whole data frame in a separate window." & Environment.NewLine & "Just right click on the bottom sheets tab and select 'View'.", "")
        dctMessagesLinks.Add("Did you know: Importing data from many other statistics packages is easy. Go to 'File > Open From File...' and choose your file." & Environment.NewLine & "You can export for other packages as well with File > Export > Export Dataset...", "")
        dctMessagesLinks.Add("Did you know: R-Instat stores metadata on columns and data frames which you can edit. Go to View > Column Metadata... or Data Frame Metadata... to view and edit metadata.", "")
        dctMessagesLinks.Add("Have you tried: Describing all your variables at once." & Environment.NewLine & "Simply go to Describe > One Variable > Summarise or Graph and choose all your variables to start an exploration.", "")
        dctMessagesLinks.Add("Have you tried: Boxplots by a factor." & Environment.NewLine & "Boxplots are great visualisation and even better when using a second variable. Try adding a factor variable in the Factor receiver to compare across the factor levels.", "")
        dctMessagesLinks.Add("Have you tried: Using the library datasets." & Environment.NewLine & "Go to File > Open From Library... to see many interesting and real world datasets to explore.", "")
        dctMessagesLinks.Add("Looking for free statistics textbooks?" & Environment.NewLine & "CAST offers free, interactive textbooks covering introductory and more advanced statistics. Click to explore the resources.", "https://cast.idems.international/")
        dctMessagesLinks.Add("Looking for interesting case studies for teaching?" & Environment.NewLine & "The International Livestock Research Institute (ILRI) has freely available biometric case studies for anyone to use to teach or learn. Find the data sets in the R-Instat library and click to go to the ILRI website.", "https://www.ilri.org/biometrics/default.htm")
        dctMessagesLinks.Add("Looking for free statistics and data science textbooks?" & Environment.NewLine & "Explore a growing library of open textbooks covering a range of topics, with resources that can be adapted for different contexts, audiences and software.", "https://statsbooks.idems.international/library/")
        dctMessagesLinks.Add("New to R-Instat?" & Environment.NewLine & "Explore our free online training materials, with practical exercises to help you get started.", "https://ecampus.r-instat.org/course/view.php?id=14")
        dctMessagesLinks.Add("Did you know we're developing a book on R-Instat?" & Environment.NewLine & "We're developing a free, open-source book to help users learn how to explore and analyse data using R-Instat. Follow its development here!", "https://github.com/PreTeXtBooks/r-instat-book")
        dctMessagesLinks.Add("Working with climatic data?" & Environment.NewLine & "R-Instat has a dedicated Climatic Menu with tools for organising, checking and analysing climatic data. Go to View > Climatic Menu to access it.", "https://ecampus.r-instat.org/mod/page/view.php?id=253")
        dctMessagesLinks.Add("Working with tricot data?" & Environment.NewLine & "R-Instat has a dedicated Tricot Menu to help you organise and analyse tricot trial data. Go to View > Tricot Menu to access it.", "https://learn.climmob.net/analysis/r-instat")
        dctMessagesLinks.Add("Working with procurement data?" & Environment.NewLine & "R-Instat includes a dedicated Procurement Menu with tools for working with procurement datasets. Go to View > Procurement Menu to access it.", "")
        dctMessagesLinks.Add("Have you tried Pivot Tables?" & Environment.NewLine & "R-Instat can make interactive pivot tables to explore your data. Go to Describe > Two/Three Variables > Pivot Table... to get started.", "")
        dctMessagesLinks.Add("Did you know that while R-Instat development started in 2015, its history goes back to 1983!" & Environment.NewLine & "Read about its history here.", "https://ecampus.r-instat.org/mod/page/view.php?id=249")
        dctMessagesLinks.Add("Did you know you can create reproducible reports in R-Instat?" & Environment.NewLine & "R-Instat can record your analyses in a Quarto document, helping you create reports that combine code, results and explanations. Go to View > Log Script and click ""Record Quarto"" to get started.", "")
        dctMessagesLinks.Add("Interested in learning R?" & Environment.NewLine & "R-Instat generates R code as you work, helping you understand the commands behind your analyses. Explore the scripting facilities to see how menus and R code work together.", "https://ecampus.r-instat.org/mod/page/view.php?id=242")
        dctMessagesLinks.Add("Looking for datasets to practise with?" & Environment.NewLine & "R-Instat provides access to example datasets from R packages, giving you plenty of opportunities to practise statistical analyses.", "https://ecampus.r-instat.org/mod/page/view.php?id=239")
        dctMessagesLinks.Add("Want to work with real survey data?" & Environment.NewLine & "Learn how to access and analyse datasets from sources such as UNICEF's Multiple Indicator Cluster Surveys (MICS) and Demographic and Health Surveys (DHS).", "https://ecampus.r-instat.org/mod/page/view.php?id=226")
        dctMessagesLinks.Add("Did you know R-Instat is available in multiple languages?" & Environment.NewLine & "R-Instat can be used in different languages, helping make statistical analysis accessible to more people. Learn how to change the language in the software.", "https://ecampus.r-instat.org/mod/page/view.php?id=211")
        dctMessagesLinks.Add("Have a question about R-Instat?" & Environment.NewLine & "Explore our frequently asked questions and learning resources to find answers and get more out of R-Instat.", "https://ecampus.r-instat.org/mod/glossary/view.php?id=241")
        dctMessagesLinks.Add("Did you know R-Instat is open source?" & Environment.NewLine & "You can explore the code, report issues and contribute to its development. Click to visit our GitHub repository.", "https://github.com/IDEMSInternational/R-Instat")

        Randomize()
        iSelectedMessage = CInt(Math.Floor(Rnd() * dctMessagesLinks.Count))
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
                MsgBoxTranslate("Sorry, we couldn't open this link (" & strHyperlink & ")" & Environment.NewLine & ex.Message, "Cannot open link")
            End Try
        End If
    End Sub
End Class