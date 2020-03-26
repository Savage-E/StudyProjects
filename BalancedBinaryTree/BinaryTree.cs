namespace BalancedBinaryTree
{
    public class BinaryTree<T> where T : System.IComparable<T>
    {
        private Node<T> root;

        public int GetHeight(Node<T> node)
        {
            if (node == null)
                return 0;
            return node.height;
        }

        private int Bfactor(Node<T> node)//Вычисляет разницу высоты левого и правого поддеревьев(фактор баланса).
        {
            return GetHeight(node.left) - GetHeight(node.right);
        }

        private void CorrectHeight(Node<T> node)//Корректирует высоту узла после преобразований.
        {
            int heigthleft = GetHeight(node.left);
            int heigthright = GetHeight(node.right);
            node.height = 1 + (heigthleft > heigthright ? heigthleft : heigthright);
        }

        public BinaryTree(T data)
        {
            root = new Node<T>(data);
        }

        private Node<T> InsertNode(Node<T> current, T data)
        {
            if (current == null)
                return new Node<T>( data);

            if (data.CompareTo(current.data) > 0)
                current.right = InsertNode(current.right, data);
            else if (data.CompareTo(current.data) < 0)
                current.left = InsertNode(current.left, data);
            else
                return current;//Одинаковые значения недопустимы

            CorrectHeight(current);
            current = BalanceTree(current);

            return current;
        }

        public void Insert(T data)
        {
            root = InsertNode(root, data);
        }

        public bool Search(T data)
        {
            if (root == null)
                return false;
            else if (data.CompareTo(SearchData(root, data).data) == 0)
                return true;
            else
                return false;
        }

        private Node<T> SearchData(Node<T> current, T data)
        {
            if (current == null)
                return root;
            if (data.CompareTo(current.data) == 0)
                return current;
            if (data.CompareTo(current.data) > 0)
                return SearchData(current.right, data);
            else
                return SearchData(current.left, data);
        }

        public void Erase(T data)
        {
            root = EraseNode(root, data);
        }

        private Node<T> EraseNode(Node<T> node, T data)
        {
            if (node == null)
                return null;
            if (data.CompareTo(node.data) < 0)
                node.left = EraseNode(node.left, data);
            else if (data.CompareTo(node.data) > 0)
                node.right = EraseNode(node.right, data);
            else
            {
                Node<T> left = node.left;
                Node<T> right = node.right;
                if (node.right == null)
                    return left;
                else
                {
                    Node<T> min = Findmin(node.right);
                    right.left = min.right;
                    node.data = min.data;
                    min = node;

                    CorrectHeight(min);
                    BalanceTree(min);
                }
            }

            CorrectHeight(node);
            node = BalanceTree(node);
            return node;
        }

        private Node <T>Findmin(Node<T> n)
        {
            return n.left != null ? Findmin(n.left) : n;
        }

        


        private Node<T> RotateLL(Node<T> parent)//Left Left Case(Поворот направо).
        {
            Node<T> pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            CorrectHeight(parent);
            CorrectHeight(pivot);

            return pivot;
        }

        private Node<T> RotateRL(Node<T> parent)//Right Left case(Поворот налево, а затем направо).
        {
            Node<T> pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }

        private Node<T> RotateLR(Node<T> parent)//Left Right case(Поворот направо, а зачем налево).
        {
            Node<T> pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }

        private Node<T> RotateRR(Node<T> parent)//Right Right case(Поворот налево).
        {
            Node<T> pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            CorrectHeight(parent);
            CorrectHeight(pivot);

            return pivot;
        }

        private Node<T> BalanceTree(Node<T> node)//Балансировка дерева.
        {
            int bfactor = Bfactor(node);
            if (bfactor > 1)
            {
                if (Bfactor(node.left) > 0)
                {
                    node = RotateLL(node);
                }
                else
                {
                    node = RotateLR(node);
                }
            }
            if (bfactor < -1)
            {
                if (Bfactor(node.right) < 0)
                {
                    node = RotateRR(node);
                }
                else
                {
                    node = RotateRL(node);
                }
            }

            return node;
        }

        

        
    }
}