namespace DS{
    public class BinaryTree {
        public class TreeNode{
            public int value;
            public TreeNode? left; 
            public TreeNode? right; 

            public TreeNode(int value){
                this.value = value;
            }
            // @Override
            public String ToString(){
                return "Node: "+value;
            }
        }
        private TreeNode? root;

        public void Insert(int value){
            if(root==null){
                root = new TreeNode(value);
                return;
            }
            var current = root;
            while(true){
                if(value<current.value){
                    if(current.left == null){
                        current.left = new TreeNode(value);
                        break;
                    }
                    current=current.left;
                }
                else if(value>current.value){
                    if(current.right == null){
                        current.right = new TreeNode(value);
                        break;
                    }
                    current = current.right;
                }
            }
        }
        public Boolean find(int value){
            var current = root;
            while(current!=null){
                if(value < current.value)
                    current = current.left;
                else if(value > current.value)
                    current = current.right;
                else
                    return true;
            }
            return false;
        }

        //TRAVERSAL
        //Breadth first->Level Order -> traverse based on equal depth
        //Depth First -> Pre Order, Inorder, postOrder
        //PreOrder -> Root,Left,Right
        //Inorder -> Left, Root, Right
        //Post-Order -> Left,Right,Root
        public void PreOrder(){
            PreOrder(root);
        }
        private void PreOrder(TreeNode root){
            if(root == null)
                return;
            Console.Write(root.value+",");
            PreOrder(root.left);
            PreOrder(root.right);
        }
        public void InOrder(){
            InOrder(root);
        }
        private void InOrder(TreeNode root){
            if(root == null)
                return;
            InOrder(root.left);
            Console.Write(root.value+",");
            InOrder(root.right);
        }
        public void PostOrder(){
            PostOrder(root);
        }
        private void PostOrder(TreeNode root){
            if(root == null)
                return;
            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.value+",");
        }
        public int Height(){
            return Height(root);
        }
        public int Height(TreeNode root){
            if(root == null) return -1;
            if(root.left == null && root.right == null)
                return 0;
            return 1+Math.Max(Height(root.left),Height(root.right));
        }
        public int Minimum(){
            return Minimum(root);
        }
        public int Minimum(TreeNode root){
            if(isLeaf(root))
                return Math.Min(root.value,root.value);
            return Math.Min(Minimum(root.left),Minimum(root.right));
        }
        public Boolean isLeaf(TreeNode node){
            return node.left == null && node.right == null;
        }
        public Boolean Equals(BinaryTree other){
            if(other == null) return false;
            return Equals(other.root,root);
        }
        public Boolean Equals(TreeNode first, TreeNode second){
            if(first==null && second==null)
                return true;
            if(first!=null && second!=null)
                return first.value == second.value && Equals(first.left,second.left) && Equals(first.right,second.right);
            
            return false;
        }
        public void swapRoot(){
            var temp = root.left;
            root.left = root.right;
            root.right = temp;
        }
        public Boolean IsBinarySearchTree(){
            return IsBinarySearchTree(root);
        }
        public Boolean IsBinarySearchTree(TreeNode root){
            if(isLeaf(root)) return true;

            return root.left.value<root.value && root.right.value>root.value 
                && IsBinarySearchTree(root.left) && IsBinarySearchTree(root.right);
        }
        public List<int> GetNthNodesFromTheRoot(int distance){
            var list = new List<int>();
            GetNthNodesFromTheRoot(root,distance,list);
            return list;
        }
        public void GetNthNodesFromTheRoot(TreeNode root, int distance, List<int> list){
            if(root == null) return;
            if(distance == 0){
                list.Add(root.value);
                // Console.Write(root.value+","); 
                return;
            }
            GetNthNodesFromTheRoot(root.left,distance-1,list);
            GetNthNodesFromTheRoot(root.right,distance-1,list);
        }
        public void traverseLevelOrder(){
            for(int i=0;i<=Height();i++){
                foreach(var item in GetNthNodesFromTheRoot(i))
                    Console.Write(item+",");
            }
        }
    }
}