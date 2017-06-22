Public Class clsRegressionDefaults
    Public Shared ReadOnly Property clsDefaultRLmOrGLM As RFunction
        Get

            Dim clsRModelFunction As New RFunction

            clsRModelFunction.SetRCommand("lm")
            Return clsRModelFunction
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

            clsDefaultRestpvalFunction.SetPackageName("base")
            clsDefaultRestpvalFunction.SetRCommand("summary")
            Return clsDefaultRestpvalFunction
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultRConfinterval As RFunction
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

    Public Shared ReadOnly Property clsDefaultRanovaFunction As RFunction
        Get
            Dim clsDefaultRaovFunction As New RFunction
            clsDefaultRaovFunction.SetPackageName("stats")
            clsDefaultRaovFunction.SetRCommand("anova")
            Return clsDefaultRaovFunction
        End Get
    End Property


    Public Shared ReadOnly Property clsDefaultModel As RFunction
        Get
            Dim clsDefaultRModelsFunction As New RFunction
            clsDefaultRModelsFunction.SetPackageName("stats")
            clsDefaultRModelsFunction.SetRCommand("formula")
            Return clsDefaultRModelsFunction
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultRResidualPlots As RFunction
        Get
            Dim clsDefaultRResidualPlotsFunction As New RFunction
            clsDefaultRResidualPlotsFunction.SetPackageName("ggplot2")
            clsDefaultRResidualPlotsFunction.SetRCommand("autoplot")
            Return clsDefaultRResidualPlotsFunction
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

    Public Shared ReadOnly Property clsDefaultRggplot As RFunction
        Get
            Dim clsDefaultRggplotFunction As New RFunction
            clsDefaultRggplotFunction.SetPackageName("visreg")
            clsDefaultRggplotFunction.SetRCommand("visreg")
            Return clsDefaultRggplotFunction
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultFitted As RFunction
        Get
            Dim clsRFittedValues As New RFunction
            Dim clsRWriteFitted, clsRModelFunction As New RFunction

            clsRWriteFitted.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
            Return clsRWriteFitted
        End Get
    End Property


    Public Shared ReadOnly Property clsDefaultRWriteFitted As RFunction
        Get
            Dim clsDefaultRWriteFittedFunction As New RFunction

            clsDefaultRWriteFittedFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
            Return clsDefaultRWriteFittedFunction
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultRWriteResiduals As RFunction
        Get
            Dim clsDefaultRWriteResidualsFunc As New RFunction

            clsDefaultRWriteResidualsFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
            Return clsDefaultRWriteResidualsFunc
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultRWriteStdResiduals As RFunction
        Get
            Dim clsDefaultRWriteStdResidualsFunc As New RFunction

            clsDefaultRWriteStdResidualsFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
            Return clsDefaultRWriteStdResidualsFunc
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultRWriteLeverage As RFunction
        Get
            Dim clsDefaultRWriteLeverageFunc As New RFunction

            clsDefaultRWriteLeverageFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
            Return clsDefaultRWriteLeverageFunc
        End Get
    End Property

End Class
