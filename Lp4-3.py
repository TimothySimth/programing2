j = int(input("# of eggs"))
g = j // 12
t = j % 12
e = j - t
if g < 4:
  print("The bill is equal to: ", e * 0.042 + g * 0.5)
  print("remaning eggs: " + str(t))
elif g >= 4 and g < 6:
  print("The bill is equal to: ", e * 0.038 + g * 0.45)
  print("remaning eggs: " + str(t))
elif g >= 6 and g < 11:
  print("The bill is equal to: ", e * 0.033 + g * 0.4)
  print("remaning eggs: " + str(t))
elif g >= 11:
  print("The bill is equal to: ", e * 0.029 + g * 0.35)
  print("remaning eggs: " + str(t))
else:
  print("Invalid Input")
