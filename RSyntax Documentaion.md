The description contained in this file is to guide the developers in using the RSyntax class, whose purpose to write the R scripts function that are executable within R. 
In this description, we will be using the Regular sequence dialog as an example of how to use this RSyntax class.
Steps.
1.  In the form load routine, start by the following lines of codes,
  ucrBase.clsRsyntax.SetFunction("seq").
  What this line of code does is to set up the specific R function that one intends to use. In this case, for the creating of sequences, we will need the seq() function as defined in R. To get quickly to the form load, double any where on the form, as long as it is not on any component within the form.

2.  In the dialogue for Regular sequence, there are three text boxes; txtFrom, txtTo and txtStps. The idea is to capture the parameters/values from these text boxes on the event of textchange and not when the Ok button is clicked. This means that, for any control: be it a text box, list box e.t.c, we need to capture any changes as they are happening. We then send this changes to the addParameter routine defined in the RSyntax class, which will be storing all these changes. In this case, using Regular sequence, the code under the TextChanged event will be,
  UcrBase.clsRsyntax.AddParameter ("from", txtFrom.Text) for the txtFrom
  UcrBase.clsRsyntax.AddParameter ("to", txtTo.Text) for the txtTo
  UcrBase.clsRsyntax.AddParameter ("by", txtSteps.Text) for the txtSteps
  
  Everytime an event for TextChanged ocuurs in any of the text boxes, this change is sent to the routine addParameter
  
3.  Finally there is the function GetScript() in RSyntax that does the actual writing up of the appropriate executable R script. We use this function in the ClickOk event for the Ok button. That is, to generate the script, we call this function under the clik ok, as follows,
  
  frmMain.clsRInterface.RunScript(UcrBase.clsRsyntax.GetScript (), 1) 
  
  There are three things happening in the above code: one we are creating an instance of the Rlink, which we defined on the form Main --clsRInterface and calling the routine RunScript(), secondly, we are passing the the GetScript function, defined as a routine in the RSyntax and lastly, we pass the optional Integer 1, which in this case, just means that we do no need to capture the output as it appears in R output. Actually there are three optional integers that can be used here:
    0 - When only expecting graphical types of outputs
    1 - When working with special types of dialogs such as thos found under the Manage menu or whose output needs to be written back to the spreadsheet
    2 - When working with dialogs, whose output must apear as they are in R output, espcially the dialogs under the Statistics menu or when using the summary() functions
    The script generated with the GetScript function will appear as seq(from=txtFrom.text,to=txtTo.text,by=txtSteps.text) for the case of Regular sequences.

4.  Care has to be observed, when passing values to the addParameter routine, especially when using a list box. My suggestion at the moment is to have these adding and removing of Parameter under the click events for add and remove buttons. We also have the removeParameter routine defined in the RSytax class. Will update this documentation as soon as I finish discussing the above with David.


