using System.Collections;
namespace DS {
    class DSStart{
        public static void Main(){
            HashTables ht = new HashTables();
            ht.Add(6,"A");
            ht.Add(8,"B");
            ht.Add(11,"C");
            ht.Add(6,"A+");
            // Console.Write(ht.remove(6));
            Console.Write(ht.Get(68));
        }
    }
 }