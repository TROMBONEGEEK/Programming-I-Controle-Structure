# Start with today being 100% Sunny.
sunny_chance = 1.0
rainy_chance = 0.0

print(f"Today:Sunny:{sunny_chance:.0%}, Rainy:{rainy_chance:.0%}")
#---Calculate Tomorrow---
# Sun tomorrow comes from: (Sun today staying sun) + (Rain today turning to sun)
tomorrow_sunny = (sunny_chance * 0.8) + (rainy_chance * 0.4)
tomorrow_rainy = (sunny_chance * 0.2) + (rainy_chance * 0.6)
print(f"Tomorrow_Sunny:{tomorrow_sunny:.0%}, Rainy:{tomorrow_rainy:.0%}")

#---Calculate Day 2---
# Day 2 comes entirely from Tomorrow's percentages.
day2_sunny = (tomorrow_sunny * 0.8) + (tomorrow_rainy * 0.4)
day2_rainy = (tomorrow_sunny * 0.2) + (tomorrow_rainy * 0.6)
print(f"Day2_Sunny:{day2_sunny:.0%}, Rainy:{day2_rainy:.0%}")

# f means format.
