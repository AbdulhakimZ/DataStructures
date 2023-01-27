 namespace DS {
    class DSStart{
        public static void Main(){
            var pq = new PriorityQueue();
            pq.add(1);
            pq.add(4);
            pq.add(3);
            pq.add(5);
            pq.add(2);
            while(!pq.isEmpty()){
                Console.WriteLine(pq.remove());
            }
            pq.print();
        }
    }
 }