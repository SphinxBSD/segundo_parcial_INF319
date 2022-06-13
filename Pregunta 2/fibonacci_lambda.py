def fibonacci(n):
    fib_list = [0, 1]
  
    any(map(lambda _: fib_list.append(sum(fib_list[-2:])),
                                         range(2, n)))
  
    return fib_list[:n]
  
n = int(input("Ingrese el valor de n: "))
print(fibonacci(n))