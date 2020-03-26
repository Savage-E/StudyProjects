namespace BalancedBinaryTree
{
    public class Node
    {
        public Node(int data)
        {
            this.data = data;
            // height = 1;
        }

        public Node left { get; set; }
        public Node right { get; set; }
        public int height { get; set;}
      
        public int data { get; set; }
    }
}