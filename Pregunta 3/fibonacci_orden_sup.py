def fibo_ord_sup(operacion):
    
    def serie(n):
        a = 1
        b = 0
        for i in range(n):
            f = a + b
            print(f)
            a = b
            b = f
    def enesimo(n):
        a = 0
        b = 1
        def fibo(n,a,b):
            if n == 1:
                return 1
            else:
                return a + fibo(n-1,b,a+b)
        print(fibo(n,a,b))
    if operacion == "serie":
        return serie
    elif operacion == "enesimo":
        return enesimo

op = input("Ingrese el tipo de operacion: serie o enesimo: ")
n = int(input("Ingrese un numero n: "))
f = fibo_ord_sup(op)
f(n)
