# Problem number 3
#Leaving the house at 6:52 pm and converting it to minutes from midnight.

print("Leave_house = 6:52 pm")
minute_conversion = (6 * 60) + 52  # 412 min. 
if minute_conversion == 412:
    print("The conversion is correct!")

# Pace per mile (minutes.seconds format from your script)
mile_1 = 8.25  # 8:15 min.
mile_3 = 7.20  # 7:12 min. 
mile_1a = 8.25  # 8:15 min. 

# Total time spent running each segment (in minutes/seconds decimal format)
mile_run1 = mile_1 * 1
mile_run3 = mile_3 * 3
mile_run1a = mile_1a * 1

# Total running time
timerun = mile_run1 + mile_run3 + mile_run1a

# Calculate arrival time in total minutes from midnight
# Note: Since your paces use .15 for 15 seconds (0.25 of a minute),
# standard math applies, but let's look at the total raw addition:
# total_arrival_minutes = minute_conversion + timerun

print

