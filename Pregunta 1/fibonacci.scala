import java.util.Scanner

object MyClass {

    def main(args: Array[String]) {
        val scanner = new java.util.Scanner(System.in)
        var n=scanner.nextInt()
        var a = 1
        var b = 0
        while (n>0){
            var f = a+ b
            print(f)
            print("\n")
            a = b
            b = f
            n = n-1
        }
    }
}