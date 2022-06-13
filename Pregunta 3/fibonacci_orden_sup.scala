import scala.annotation.tailrec
 
object RecursionVsIteration extends App {
 
  val zero = BigInt(0)
  
  def fibTail(n: Long): BigInt = {
 
    if(n <= 1) return 1
 
    @tailrec
    def fibRecursion(a: BigInt, b: BigInt, n: BigInt): BigInt = {
      
      n match  {
        case `zero` => b  //wrap with "`" to match against a variable
        case _ => fibRecursion(b, a + b, n - 1)
      }    
    }
    
    fibRecursion(1, 1, n - 2)  
  }
  val n = 10 // Valor enesimo de la serie
  var x = 1
  while (x <= n){
      println(fibTail(x))
      x = x +1
  }
}