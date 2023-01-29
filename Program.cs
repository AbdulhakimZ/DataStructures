using System.Collections;
namespace DS {
    class DSStart{
        public static void Main(){
            BinaryTree bt = new BinaryTree();
            bt.Insert(7);
            bt.Insert(4);
            bt.Insert(9);
            bt.Insert(1);
            bt.Insert(8);
            bt.Insert(10);
            bt.Insert(6);
            bt.traverseLevelOrder();
            var list = bt.GetNthNodesFromTheRoot(2);
            
        }
    }
 }