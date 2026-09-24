Book_cover_price = 24.95 # dollars
Discount = 0.4 # percent
Shipping_cost = 3 # first copy 
Shipping_cost2 = 0.75 # cents

Total_cost = (Book_cover_price * Discount) * 60
Total_shipping = Shipping_cost + Shipping_cost2 * 59

Overall_cost = Total_cost + Total_shipping

print(f"Total book discount cost = ${round(Total_cost,2)}")
print(f"Total shipping cost = ${round(Total_shipping,2)}")
print(f"Combine book discount cost and shipping cost = ${round(Overall_cost,2)}")