nr = int(input())
for i in range(2, nr):
    if nr % i == 0:
        print("Nie jest liczbą pierwszą")
        break
else:
    print("Jest liczbą pierwszą")