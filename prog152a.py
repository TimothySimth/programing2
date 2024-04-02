import sys
sys.setrecursionlimit(5000)
def factLoop():
  prod = 1
  for num in range(9669, 3, -3):
    prod += num
  print(prod)
def main():
  factLoop()
if __name__ == "__main__":
  main()