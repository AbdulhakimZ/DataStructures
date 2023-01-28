using System.Collections;
namespace DS{
    public class HashTables {
        //Add,Get,Remove. use Chaining for collision removal.
        public class Entry {
            public int key;
            public String value;
            public Entry(int key, String value){
                this.key = key;
                this.value = value;
            }
        }
        LinkedList<Entry>[]   entries = new LinkedList<Entry>[5];

        public void Add(int key,string value){            
            var index = hash(key);
            if(entries[index] == null)
                entries[index] = new LinkedList<Entry>();
            
            foreach(var entry in entries[index])
                if(entry.key == key){
                    entry.value = value;
                    return;
                } 
            entries[index].AddLast(new Entry(key,value));
        }
        public string? Get(int key){
            var entry = getEntry(key);
            return entry?.value;
        }
        public string? remove(int key){
            var entry = getEntry(key);
            if(entry!=null){                
                string value = entry.value;
                entries[hash(key)].Remove(entry);
                return value;
            }            
            return null; 
        }
        public Entry? getEntry(int key){
            var index = hash(key);
            if(entries[index]!=null)
            foreach(var entry in entries[index])
                if(entry.key == key){
                    return entry;
                }    
            return null;
        }
        private int hash (int key){
            return Math.Abs(key%entries.Length);
        }

    }    
}