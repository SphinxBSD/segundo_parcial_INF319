let mutable a = 1
let mutable b = 0
let mutable n = 10 // n secuencias de la serie de fibonacci
let rec fibo n a b = 
    if n = 0 then 
        0
    else
        printf "%i\n" (a+b)
        fibo (n-1) b (a+b)

fibo n a b