namespace BalancedBinaryTree
{
    public class Node<T>
    {
        public Node(T data)
        {
            this.data = data;
            
        }

        public Node<T> left { get; set; }
        public Node<T> right { get; set; }
        public int height { get; set;}
      
        public T data { get; set; }
    }
}