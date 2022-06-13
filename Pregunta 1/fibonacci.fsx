let mutable a = 1
let mutable b = 0
let mutable f = 1
let mutable n = 10 // n secuencias de la serie de fibonacci
while n > 0 do
    f <- a + b
    printf "%i\n" f
    a <- b
    b <- f
    n <- n-1