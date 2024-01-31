from random import randint
r = randint(1,21)
h = int(input("guess a number 1-20:"))
if r == h:
  print("you win")
else:
  print("you lose")
  print(r)