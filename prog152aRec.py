import sys
sys.setrecursionlimit(5000)
def fact(n):
  if n >= 9669: return n
  return n + fact(n+3)
def main():
  n = fact(3)
  print(n)
if __name__ == "__main__":
  main()