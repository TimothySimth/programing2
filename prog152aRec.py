import sys
sys.setrecursionlimit(5000)

def factLoop(x):
  tot = 0
  tot += x
  
  if x <= 3: return tot
  return x * factLoop(x -3)

def main():
  x = 9669
  factLoop(x)
  
  print(tot)

if __name__ == "__main__":
  main()