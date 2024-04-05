
def add(n1, n2):
  return n1 + n2
def sub(n1, n2):
  return n1 - n2
def multi(n1, n2):
  return n1 * n2
def div(n1, n2):
  return n1 / n2

def main():
  n1 = int(input("enter num1: "))
  simble = str(input("enter simble: "))
  n2 = int(input("enter num1: "))
  if simble == "+":
    n3 = add(n1, n2)
    print(n3)
  elif simble == "-":
    n3 = sub(n1, n2)
    print(n3)
  elif simble == "x" or simble == "*":
    n3 = multi(n1, n2)
    print(n3)
  elif simble == "/":
    n3 = div(n1, n2)
    print(n3)
  else:
    print("invaled input")

if __name__ == "__main__":
  main()










