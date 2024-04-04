import sys
sys.setrecursionlimit(5000)
def factLoop(n):
  prod = 1
  for num in range(n, 0, -1):
    prod *= num
  return prod
def fact(n):
  if n <= 1: return n
  return n * fact(n-1)
def main():
  num = int(input("Enter a num: "))
  while num != 0:
    factn = fact(num)
    print(f"{num}! = {factn}")
    num = int(input("Enter a num: "))
if __name__ == "__main__":
  main()