namespace BalancedBinaryTree
{
    public class BinaryTree
    {
        private Node root;

        public int GetHeight(Node node)
        {
            if (node == null)
                return 0;
            return node.height;
        }

        private int Bfactor(Node node)//Вычисляет разницу высоты левого и правого поддеревьев(фактор баланса).
        {
            return GetHeight(node.left) - GetHeight(node.right);
        }

        private void CorrectHeight(Node node)//Корректирует высоту узла после преобразований.
        {
            int heigthleft = GetHeight(node.left);
            int heigthright = GetHeight(node.right);
            node.height = 1 + (heigthleft > heigthright ? heigthleft : heigthright);
        }

        public BinaryTree(int data)
        {
            root = new Node(data);
        }

        private Node InsertNode(Node current, int data)
        {
            if (current == null)
                return new Node(data);

            if (current.data < data)
                current.right = InsertNode(current.right, data);
            else if (current.data > data)
                current.left = InsertNode(current.left, data);
            else
                return current;//Одинаковые значения недопустимы

            CorrectHeight(current);
            current = BalanceTree(current);

            return current;
        }

        public void Insert(int data)
        {
            root = InsertNode(root, data);
        }

        public string Search(int data)
        {
            if (SearchData(root, data).data == data)
                return "Элемент " + data + " найден";
            else
                return "Элемент не найден";
        }

        private Node SearchData(Node current, int data)
        {
            if (current == null)
                return root;
            if (current.data == data)
                return current;
            if (current.data < data)
                return SearchData(current.right, data);
            else
                return SearchData(current.left, data);
        }

        public void Erase(int data)
        {
            root = EraseNode(root, data);
        }

        private Node EraseNode(Node node, int data)
        {
            if (node == null)
                return null;
            if (data < node.data)
                node.left = EraseNode(node.left, data);
            else if (data > node.data)
                node.right = EraseNode(node.right, data);
            else
            {
                Node left = node.left;
                Node right = node.right;
                if (node.right == null)
                    return left;
                else
                {
                    Node min = Findmin(node.right);
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

        private Node Findmin(Node n)
        {
            return n.left != null ? Findmin(n.left) : n;
        }

        

        //public void DisposeTree()
        //{
        //    if (root == null)
        //        return;

        //}

        private Node RotateLL(Node parent)//Left Left Case(Поворот направо).
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            CorrectHeight(parent);
            CorrectHeight(pivot);

            return pivot;
        }

        private Node RotateRL(Node parent)//Right Left case(Поворот налево, а затем направо).
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }

        private Node RotateLR(Node parent)//Left Right case(Поворот направо, а зачем налево).
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }

        private Node RotateRR(Node parent)//Right Right case(Поворот налево).
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            CorrectHeight(parent);
            CorrectHeight(pivot);

            return pivot;
        }

        private Node BalanceTree(Node node)//Балансировка дерева.
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