# Quick Chapter 2
print('Starbuck_Coffee_Drink?')

product_list3_custom = ['ice', 'cream', 'milk', 'sugar', 'half & half']

coffee_request = input("Enter Coffee Name here: ")
coffee_toppings = " "
toppings_list = []
while coffee_toppings != "no_toppings":
    coffee_toppings = input("Enter Coffee Toppings here: ")
    if coffee_toppings not in product_list3_custom:
        print("There is no option for what you want")
        continue
    if coffee_toppings != "no_toppings":
        toppings_list.append(coffee_toppings)



    print(f"great choice! You have a {coffee_request} with {coffee_toppings}!")
else:
    print(f"Dude that is not what we have!")


# ask a question: 
# 1 "What do you want in your drink? "
# 2 "Nothing?"

