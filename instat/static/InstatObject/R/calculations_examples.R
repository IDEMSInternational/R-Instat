# Example 1 - Yearly summary from daily data
############################################
# Start with any daily data
Daily <- read.csv("Bungoma_edit.csv", na.strings = "-9998")
InstatDataObject$import_data(data_tables = list(Daily = Daily))

# This will be manipulation of main calculation
Year_group_for_daily <- instat_calculation$new(type = "by", calculated_from = list(Daily = "Year"))

# This is the summary
mean_rain_from_daily <- instat_calculation$new(function_exp = "mean(Rain)", type = "summary", result_name = "mean_Rain_daily",
                                               calculated_from = list(Daily = "Rain"), manipulations = list(Year_group_for_daily))

InstatDataObject$apply_instat_calculation(mean_rain_from_daily)

# Example 2 - Daily summaries into existing yearly data
############################################
# This works only because the Yearly is linked to the Daily by a key


# Start with any daily data
Daily <- read.csv("C:/Users/Danny/Downloads/Bungoma_edit.csv", na.strings = "-9998")
# Create the yearly data
Yearly <- Daily %>% group_by(Year) %>% summarise(Av_Rain = mean(Rain))
InstatDataObject <- instat_object$new()
InstatDataObject$import_data(data_tables = list(Yearly = Yearly, Daily = Daily))
# Add a link between the data
InstatDataObject$add_link("Daily", "Yearly", c(Year = "Year"), type = keyed_link_label)

# Maniplation for daily data
Year_group_for_daily <- instat_calculation$new(type = "by", calculated_from = list(Daily = "Year"))
# Summary of daily data
mean_rain_from_daily <- instat_calculation$new(function_exp = "mean(Rain)", type = "summary", result_name = "mean_Rain_daily",
                                               calculated_from = list(Daily = "Rain"), manipulations = list(Year_group_for_daily))

# Calculates square root of Av_Rain column in the Yearly data
Double_rain_from_yearly <- instat_calculation$new(function_exp = "sqrt(Av_Rain)", type = "calculation", result_name = "Sqrt_Av_Rain",
                                                  calculated_from = list(Yearly = "Av_Rain"))

# Calculates the difference between Sqrt_Av_Rain and mean_Rain_daily
# This shows how data from two different data frames can be used for a calculation
# Because of the link, it knows to merge the Daily summarised data into the existing Yearly data
Yearly_diff <- instat_calculation$new(function_exp = "abs(mean_Rain_daily - Sqrt_Av_Rain)", type = "calculation", result_name = "diff",
                                      sub_calculations = list(mean_rain_from_daily, Double_rain_from_yearly), save = 2)
InstatDataObject$apply_instat_calculation(Yearly_diff)

# Example 3 - Proportions
############################################

# A manipulation grouping by village
village_group <- instat_calculation$new(type = "by", calculated_from = list(survey = "Village."))
# A sinple count summary, n() does counts
total <- instat_calculation$new(function_exp = "n()", type = "summary", result_name = "total", save = 0)
# A manipulation grouping by variety
variety_group <- instat_calculation$new(type = "by", calculated_from = list(survey = "Variety."))
# A simple count, with variety_group as manipulation, so counts for each variety
val <- instat_calculation$new(function_exp = "n()", type = "summary", result_name = "val",
                              manipulations = list(variety_group), save = 0)
# Has subcalculations doing val and total first and then doing the proportion
# This has manipulation of village_group so that total is count within village
# and val is count within village and variety
# So val/total is therefore the proportion of each variety within each village
prop_calc <- instat_calculation$new(function_exp = "val/total", type = "calculation", calculated_from = list(), 
                                    result_name = "prop", manipulations = list(village_group),
                                    sub_calculations = list(total, val), save = 2, name = "prop_calc")
InstatDataObject$apply_instat_calculation(prop_calc)


# Example 4 - Within data frame
############################################

# Simple calculations within a data frame
# First two calculations on Yield which will be sub calculations of the main calculation
Yield2 <- instat_calculation$new(function_exp = "Yield * 2", type = "calculation", result_name = "Yield2", calculated_from = list(survey = "Yield"), save_output = FALSE)
Yield3 <- instat_calculation$new(function_exp = "Yield * 3", type = "calculation", result_name = "Yield3", calculated_from = list(survey = "Yield"), save_output = FALSE)

# Calculation using the output from each sub calculation
Yield_com <- instat_calculation$new(type = "calculation", function_exp = "Yield3 - Yield2", calculated_from = list(survey = "Yield2", survey = "Yield3"),
                                    sub_calculations = list(Yield2, Yield3), save_output = FALSE, result_name = "YieldCheck", save_calc = FALSE)
InstatDataObject$apply_instat_calculation(Yield_com)
#InstatDataObject$get_data_frame("survey")

# Example 4 - Empty main calculation
############################################
# Empty main calculation with two sub calculations using different filters.
# This can only be done if the data has a key
# (output comes in stange order but added to data correctly)
# (not very sensible example but shows the functionality of using filters)

# Add a column to the survey data
InstatDataObject$add_columns_to_data("survey", col_data = 1:36, col_name = "ID")
# Make this column a key
InstatDataObject$add_key("survey", "ID")

# Two filters which will be manipulations to other calculations
Yield_over_50 <- instat_calculation$new(type = "filter", function_exp = "Yield > 50", calculated_from = list(survey = "Yield"))
Yield_under_50 <- instat_calculation$new(type = "filter", function_exp = "Yield <= 50", calculated_from = list(survey = "Yield"))

# calculation using Yield_over_50 as the manipulation
sub1 <- instat_calculation$new(function_exp = "Yield * Size", type = "calculation", result_name = "YieldxSize", manipulations = list(Yield_over_50), calculated_from = list(survey = "Yield"))
# calculation using Yield_under_50 as the manipulation
sub2 <- instat_calculation$new(function_exp = "Yield * 100", type = "calculation", result_name = "Yieldx100", manipulations = list(Yield_under_50), calculated_from = list(survey = "Yield"))

# main calculation that just runs the two sub calculations
# type = "combination" means that there is no main calculation
Yield_Size_com <- instat_calculation$new(type = "combination", manipulations = list(), sub_calculations = list(sub1, sub2))
InstatDataObject$apply_instat_calculation(Yield_Size_com)