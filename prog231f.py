from CL213f import Cl213f

def main():
  try:
    elecbill = []
    kwh = 0
    with open("Langdat/prog213f.dat", 'r') as f:
      for line in f:
        kwh = int(line)
        if kwh != -999:
          bill = Cl213f(kwh)
          elecbill.append(bill)
    for bill in elecbill:
      bill.calc()
      print(bill)
  except Exception as e:
    print("Error:", e)
  pass


if __name__ == "__main__":
  main()
