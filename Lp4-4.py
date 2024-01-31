h = int(input("Enter the model # of your car: "))
if h == 119 or h == 179 or h >= 189 and h <= 195 or h == 221 or h == 780:
  return print("Your car is defective. It must be repaired.")
else:
  return print("Your car is not defective.")


