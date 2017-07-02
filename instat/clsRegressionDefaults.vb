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

Public Class clsRegressionDefaults
    Public Shared ReadOnly Property clsDefaultLmFunction As RFunction
        Get

            Dim clsRModelFunction As New RFunction

            clsRModelFunction.SetRCommand("lm")
            Return clsRModelFunction
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultGlmFunction As RFunction
        Get

            Dim clsDefaultGlmFunc As New RFunction

            clsDefaultGlmFunc.SetRCommand("glm")
            Return clsDefaultGlmFunc
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultRGraphicsOperator As ROperator
        Get

            Dim clsRGraphicsOperator As New ROperator

            clsRGraphicsOperator.SetOperation("+")
            Return clsRGraphicsOperator
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultFormulaOperator As ROperator
        Get
            Dim clsFormulaOperator As New ROperator

            clsFormulaOperator.SetOperation("~")
            Return clsFormulaOperator
        End Get
    End Property


    Public Shared ReadOnly Property clsDefaultSummary As RFunction
        Get
            Dim clsDefaultRestpvalFunction As New RFunction

            clsDefaultRestpvalFunction.SetRCommand("summary")
            Return clsDefaultRestpvalFunction
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultConfint As RFunction
        Get
            Dim clsDefaultRConfint As New RFunction
            clsDefaultRConfint.SetPackageName("stats")
            clsDefaultRConfint.SetRCommand("confint")
            Return clsDefaultRConfint
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultRaovPValueFunction As RFunction
        Get
            Dim clsDefaultRaovpvalFunction As New RFunction
            clsDefaultRaovpvalFunction.SetPackageName("stats")
            clsDefaultRaovpvalFunction.SetRCommand("anova")
            Return clsDefaultRaovpvalFunction
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultAnovaFunction As RFunction
        Get
            Dim clsDefaultRaovFunction As New RFunction
            clsDefaultRaovFunction.SetPackageName("stats")
            clsDefaultRaovFunction.SetRCommand("anova")
            Return clsDefaultRaovFunction
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultFormulaFunction As RFunction
        Get
            Dim clsDefaultRModelsFunction As New RFunction
            clsDefaultRModelsFunction.SetPackageName("stats")
            clsDefaultRModelsFunction.SetRCommand("formula")
            Return clsDefaultRModelsFunction
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultAutoplot As RFunction
        Get
            Dim clsAutoplot As New RFunction
            Dim clsWhichFuntion As New RFunction

            clsAutoplot.SetRCommand("autoplot")
            clsAutoplot.iCallType = 3
            clsWhichFuntion.SetRCommand("c")
            clsWhichFuntion.AddParameter("1", "1", bIncludeArgumentName:=False)
            clsWhichFuntion.AddParameter("2", "2", bIncludeArgumentName:=False)
            clsWhichFuntion.AddParameter("3", "3", bIncludeArgumentName:=False)
            clsWhichFuntion.AddParameter("5", "5", bIncludeArgumentName:=False)
            clsAutoplot.AddParameter("which", clsRFunctionParameter:=clsWhichFuntion, iPosition:=1)
            Return clsAutoplot
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultRgeom_pointFunction As RFunction
        Get
            Dim clsDefaultRgeom_point As New RFunction
            clsDefaultRgeom_point.SetPackageName("ggplot2")
            clsDefaultRgeom_point.SetRCommand("geom_point")
            Return clsDefaultRgeom_point
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultAddColumnsToData As RFunction
        Get
            Dim clsDefaultAddColumnsToDataFunction As New RFunction

            clsDefaultAddColumnsToDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
            Return clsDefaultAddColumnsToDataFunction
        End Get
    End Property

End Class
