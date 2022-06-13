import scala.collection.mutable.ListBuffer

def fibonacci(l: Int): List[Int] = {
    val lista = new ListBuffer[Int]()
    for (i<-0  to l){
        if (i>1) lista += lista(i-1) + lista(i-2)
        else lista+=1
    }
    lista.toList
}
fibonacci(9).foreach(x=>println(x))