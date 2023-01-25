public class LinkedList {
    public class Node{
        public int value;
        public Node? next; 

        public Node(int value){
            this.value = value;
        }
    }
    private Node? first;
    private Node? last;

    public void addLast(int item){
        var node = new Node(item);
        if(isEmpty())
            first=last=node;
        else{
            last.next = node;
            last = node;
        }
    }
    public Boolean isEmpty(){
        return first == null;
    }
    public void addFirst(int item){
        var node = new Node(item);
        if(isEmpty()) 
            first = last = node;
        else{
            node.next = first;
            first = node;
        }
    }
    public int indexOf(int item){
        int count=0;
        var current = first;
        while(current!=null){
            if(current.value == item) return count;
            count++;
            current=current.next;
        }
        return -1;
    }
    public Boolean contains(int item){
        return indexOf(item) != -1;
    }
    public void removeFirst(){
        if(isEmpty()){
            Console.WriteLine("The list is empty");return;}
        if(first == last){first = last = null; return;}
        var second = first.next;
        first.next = null;
        first = second;
    }
    public void removeLast(){
        if(isEmpty()){
            Console.WriteLine("The list is empty");return;}
        if(first == last){first = last = null; return;}  
        var previous = getPrevious(last);
        last = previous;
        last.next = null;
    }
    public Node? getPrevious(Node node){
        var current = first;
        while(current!=null){
            if(current.next == node) return current;
            current = current.next;
        }
        return null;
    }
    public void reverse (){
        if(isEmpty()){
            Console.WriteLine("The list is empty");return;}
        if(first == last) return;
        var prev = first;
        var curr = first.next;
        while(curr!=null){
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        last = first;
        last.next = null;
        first = prev;

    }
    public int nthElementFromTheEnd(int n){
        if(isEmpty()){
            Console.WriteLine("The list is empty"); 
            return -1;
        }
        var a = first;
        var b = first;
        for(int i=0; i<n-1;i++){
            b = b.next;
            if(b==null){
                Console.WriteLine("input number out of bound");
            }
        }
        while(b.next!=null){
            a = a.next;
            b = b.next;
        }
        return a.value;
    }
    public void print(){
        var start = first;
        while(start!=null){
            Console.WriteLine(start.value+",");
            start = start.next;
        }
    }
    
    static public void Main(){
        var list = new LinkedList();
        list.addLast(10);
        list.addLast(20);
        list.addLast(30);

        list.addFirst(5);
        // list.reverse();
        //list.nthElementFromTheEnd(1)
        // list.removeLast();
        // list.removeFirst();
        // list.indexOf(10);
        list.print();
    }
}
