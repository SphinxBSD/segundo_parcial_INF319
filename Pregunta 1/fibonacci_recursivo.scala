import java.util.Scanner

object MyClass {
    def fibo(n: Int, a: Int, b: Int){
        if (n==0)
            print("")
        else {
            print(a + b)
            print("\n")
            fibo(n-1,b,a+b)
        }
    }

    def main(args: Array[String]) {
        val scanner = new java.util.Scanner(System.in)
        val n=scanner.nextInt()
        val a = 1
        val b = 0
        fibo(n,a,b);
    }
}