fib :: (Num a, Ord a) => a -> a
fib n
  | (n == 0) = 1
  | (n == 1) = 1
  | (n > 1) = fib (n - 1) + fib (n - 2)

fib' :: (Num t, Ord t) => t -> [t]
fib' n = (fib n):(fib' (n+1))

fiblst :: [Integer]
fiblst = fib' 0
