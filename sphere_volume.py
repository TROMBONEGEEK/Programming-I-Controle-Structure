radius = float(input("Enter the radius of the sphere: "))
volume = (4/3) * 3.14 * (radius ** 3)
print(f"The volume of the sphere with radius {radius} is: {volume}")

volume = float(input("Enter the volume of the sphere: "))
radius = ((3 * volume) / (4 * 3.14)) ** (1/3)
print(f"The radius of the sphere with volume {volume} is: {radius}")