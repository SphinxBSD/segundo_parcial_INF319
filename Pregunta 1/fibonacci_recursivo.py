def fibo(n,a,b):
    if n == 0:
        return "FIN"
    f = a+b
    print(f)
    fibo(n-1,b,f)
n = int(input())
a = 1
b = 0
fibo(n,a,b)
