class Cl213f:
  def __init__(self, kwh):
    self.kwh = kwh
    self.cost = 0.0
  def calc(self):
    if kwh >= 2000:
      if kwh >= 8000:
        if kwh >= 10000:
          self.cost = 0.04
        else:
          self.cost = 0.05

      else:
        self.cost = 0.7

    return kwh * self.cost
  def __str__(self):
    return f"The Cost of {self.kwh} is: {self.cost}"
  