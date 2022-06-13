namespace Library1

module fibos =
    let generafibo n =
        let mutable s=""
        let mutable a = 0
        let mutable b = 1
        let mutable c = 1
        for i in 0..n do
           s <- s+" "+a.ToString()
           a <- b
           b <- c
           c <- a + b
        s
    let rec fib n =
        if n=0 then 0
        elif n=1 then 1
        elif n=2 then 1
        else fib (n-1) + fib (n-2)

    let genera n =
        let mutable s = ""
        for i in 0..n do
            s<-s+" "+ (fib i).ToString()
        s

module calcu =
    let suma x y = x + y
    let mutli x y = x* y

type Class1() = 
    member this.X = "F#"
