copies = int(input("Enter # of copies to be printed: "))
price = 0.0
if 0 < copies <= 100:
  price = 0.30
elif 100 < copies <= 499:
  price = 0.28
elif 599 < copies <= 749:
  price = 0.27
elif 749 < copies <= 1000:
  price = 0.26
elif 1000 < copies:
  price = 0.25
else:
  print("Invalid # of copies")
print("Price per copy:  $" + str(price))
print("Total cost is::  $" + str(price*copies))