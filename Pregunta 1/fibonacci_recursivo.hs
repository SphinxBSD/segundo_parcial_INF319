fib 0 = 0
fib 1 = 1
fib n = fib(n-1) + fib(n-2)

main :: IO()

main = do
  let res1 = fib(1)
  let res2 = fib(2)
  let res3 = fib(3)
  print res1
  print res2
  print res3