num1 = int(input("Enter non negative num: "))
num2 = int(input("Enter non negative num: "))

while num2 > 0:
  temp = num1 % num2
  num1 = num2
  num2 = temp

print("GCD is :", num2)