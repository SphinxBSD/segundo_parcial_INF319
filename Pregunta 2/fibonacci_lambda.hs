import Prelude hiding (pred)

data Nat = Succ Nat | Zero deriving Show

pred (Succ pred) = pred
pred Zero        = Zero

fold (Succ pred) succ zero = succ (fold pred succ zero)
fold Zero succ zero        = zero

add a b = fold a Succ b

fromInt 0 = Zero
fromInt x = Succ (fromInt (x-1))

toInt x = fold x (+ 1) 0

fib n = fold n fib' id (pred n) where
    fib' rec (Succ p) = add (rec p) (rec (pred p))
    fib' rec Zero     = Succ Zero

main = print $ toInt (fib (fromInt 30))

fib = (λa.(a(λbc.(c(λdefg.(bef(b(e(λhi.i)(λhij.(j(λk.(kij)))))fg)))(λdef.(ef))))
        (λb.b)(a(λbcd.(c(λe.(ecd))b))(λbc.(c(λd.(dbc))))(λbc.c)(λbcd.(d(λe.(ecd)))))))
