n = int(input())
l = []
a = 2
while n != 1:
  while n % a == 0:
    n /= a
    l.append(a)
  a += 1
print(l)