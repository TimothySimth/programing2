import random

score= 0
lenOfList = int(input("Enter List Length: "))
key = []
answers = []
for i in range(lenOfList):
  x = random.randrange(10)
  key.append(x)
  
  y = random.randrange(10)
  answers.append(y)
for i in answers:
  if key[i] == answers[i]: score += 4
  elif answers[i] == "?": score += 0
  else: score -= 1
print(key)
print(answers)
print(score)

