// using System.Collections.Generic.Stack;
namespace DS{
    public class Stack {
        //Push,Pop,Peek,isEmpty
        public class Node{
            public int value;
            public Node next;
            public Node(int value){
                this.value = value;
            }
        }
        private Node? first;
        private Node? last;
        public void Push(int item){
            var node = new Node(item);
            if(isEmpty())
                first = last = node;
            else{
                node.next = first;
                first = node;
            }
        }
        public int? Pop(){
            if(isEmpty())
                return null;
            var node = first.next;
            var val = first.value;
            first = null;
            first = node;
            return val;
        }
        public int? Peek(){
            if(isEmpty())
                return null;
            return first.value;
        }
        
        public Boolean isEmpty(){
            return first == null;
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
        //Other exercises
        // public String reverse(String input){
        //     if(input == null)
        //         return null;
        //     var stack = new Stack<char>();
        //     for(int i=0; i<input.Length;i++){
        //         stack.Push(input[i]);
        //     }
        //     var reversed = new System.Text.StringBuilder();
        //     while(stack.Count()!=0)
        //         reversed.Append(stack.Pop());

        //     return reversed.ToString();
        // }

        // public Boolean isBalanced(String input){
        //     var stack = new Stack<char>();
        //     for(int i=0; i<input.Length;i++){
        //         if(input[i] == '('){
        //             stack.Push(')');
        //         }
        //         else if(input[i] == '['){
        //             stack.Push(']');
        //         }else if(input[i] == ')' || input[i] == ']'){
        //             if(stack.Count()==0) return false;
        //             if(stack.Pop()!=input[i]){
        //                 return false;
        //             }
        //         }
        //     }
        //     if(stack.Count()>0) return false;
        //     return true;
        // }        
    }
}