Public Enum R_ReturnType
    ''' <summary>
    ''' Ignore the result of the R code.
    ''' </summary>
    IgnoreResult = 0
    ''' <summary>
    ''' Store the result of the R code in a temporary R variable, And then 
    ''' output the variable's value as text.
    ''' </summary>
    ResultAsTemporaryVariable = 1
    ''' <summary>
    ''' If the R code executes successfully then show the result as text.
    ''' </summary>
    ResultAsText = 2
    ''' <summary>
    ''' If the R code executes successfully then show the result as a graph.
    ''' </summary>
    ResultAsImage = 3
    ''' <summary>
    ''' Store the result of the R code in a temporary R variable, and then 
    ''' output the variable's value in a web browser.
    ''' </summary>
    ResultAsWebControl = 4



End Enum
