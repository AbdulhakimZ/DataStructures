// using System.Collections.Generic.Stack;
namespace DS{
    public class Queue {
        //Enqueue,Dequeue,Peek,isEmpty,isFull
        public class Node{
            public int value;
            public Node next;
            public Node(int value){
                this.value = value;
            }
        }
        private Node? first;
        private Node? last;

        public Boolean isEmpty(){
            return first == null;
        }

        public void Enqueue(int item){
            var node = new Node(item);
            if(isEmpty())
                first = last = node;
            else{
                last.next = node;
                last = node;
            }
        }
        public int? Dequeue(){
            if(isEmpty())
                return null;
            var val = first.value;
            var node = first.next;
            first = null;
            first = node;
            return val;            
        }
        public int? Peek (){
            if(isEmpty())
                return null;

            return first.value;
        }
        public String toString(){
            var result = new System.Text.StringBuilder("[");
            while(first!=null){
                result.Append(first.value);
                first = first.next;
                if(first!=null) result.Append(",");
            }
            
            return result.Append("]").ToString();
        }
    }

    public class QueueStack{
        Stack stackEnq = new Stack();
        Stack stackDeq = new Stack();
        //O(1)
        public void Enqueue(int item){
                stackEnq.Push(item);
        }
        //O(n)
        public int? Dequeue(){
            if(isEmpty()) return null;
            MoveStackEnqToStackDeq();
            return stackDeq.Pop();
        }
        //O(n)
        public int? Peek()
        {
            if (isEmpty()) return null;
            MoveStackEnqToStackDeq();
            return stackDeq.Peek();
        }

        private void MoveStackEnqToStackDeq()
        {
            if (stackDeq.isEmpty())
                while (!stackEnq.isEmpty())
                    stackDeq.Push((int)stackEnq.Pop());
        }

        public Boolean isEmpty(){
            return stackEnq.isEmpty() && stackDeq.isEmpty();
        }
    }
}