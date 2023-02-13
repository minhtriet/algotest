namespace AlgoTest
{
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public string Data { get; set; }
    }

    public class BinaryTree
    {
        public Node Root { get; set; }

        public bool Add(string value)
        {
            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null) {
                this.Root = newNode;
                return true;
            }

            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                int compare_after = value.CompareTo(after.Data);
                if (compare_after < 0)
                    after = after.LeftNode;
                else if (compare_after > 0)
                    after = after.RightNode;
                else
                    return false;   // same value
            }
           
            int compare_before = value.CompareTo(before.Data);
            if (compare_before < 0)
                before.LeftNode = newNode;
            else
                before.RightNode = newNode;

            return true;
        }


        public void TraversePreOrder(Node parent) {
            if (parent != null) {
                Console.WriteLine(parent.Data);
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }
    }
}

