class Shape:
  # constructor: sets up class data
  def __init__(self, length, width):
    self.length = length
    self.width = width
    self._area = 0
    self._perim = 0

  # Mutator?setter: modifies class data
  def calculate(self):
    self._area = self.length * self.width
    self._perim = 2 * self.length + 2 * self.width

  def setLength(self, length):
    self.length = length

  #Accessor/getter: returns class data
  def getarea(self):
    return self._area

  def getperim(self):
    return self._perim


def main():
  len = int(input("Enter Length: "))
  wid = int(input("Enter Width: "))
  # make a new 'shape' object
  shape = Shape(len, wid) # call the shape constructor
  # shape.setlength(5)
  shape.calculate()
  print("Area: ", shape.getarea())
  print("Perimeter: ", shape.getperim())
  pass


if __name__ == "__main__":
  main()