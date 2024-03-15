import math
class Cl213f:
  def __init__(self, kwh):
    self.kwh = kwh
    self.cost = 0
  def calc(self):
    if self.kwh >= 2000:
      if self.kwh >= 8000:
        if self.kwh >= 10000:
          self.cost = 0.04
        else:
          self.cost = 0.05
    else:
      self.cost = 0.07
    self.a = self.cost * self.kwh
    self.a = round(self.a, 2)
  def __str__(self):
    return f"The Cost of {self.kwh} is: {self.a}"