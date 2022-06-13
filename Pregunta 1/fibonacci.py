n = int(input())
a = 1
b = 0
for i in range(n):
    f = a + b
    print(f)
    a = b
    b = f