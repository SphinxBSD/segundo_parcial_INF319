open System.Collections.Generic

let rec fib n = if n > 1 then fib(n-1) + fib(n-2) else n
let lambdafib fib n = if n > 1 then fib(n-1) + fib(n-2) else n
let rec y f n = f(y f) n;;

printfn "Fibonacci con lambda"
type Y = delegate of Y -> (int -> int)
let fix fib = 
    let y' = new Y(fun y -> (fun n -> fib(y.Invoke(y))(n)))
    y'.Invoke(y')
let fibFixed = fix lambdafib
[1..20] |> Seq.iter(fun n ->
    printfn "fib(%d)= %d" n (fibFixed(n)))