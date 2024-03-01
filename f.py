a = int(input("Enter non negative num :"))
b = int(input("Enter non negative num :"))
r = a%b
q = int(a/b)
while(r!=0):
    a = b
    b = r
    q = int(a/b)
    r = a - (b * q)
print("GCD IS :", b)