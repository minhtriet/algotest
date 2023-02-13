namespace TreeTest;
using AlgoTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestAdd()
    {
        AlgoTest.BinaryTree tree = new AlgoTest.BinaryTree();
        tree.Add("g");
        tree.Add("b");
        tree.Add("c");
        tree.Add("z");
        tree.Add("a");
        Node root = tree.Root;
        Assert.AreEqual(root.Data, "g");
        Assert.AreEqual(root.LeftNode.Data, "b");
        Assert.AreEqual(root.RightNode.Data, "z");
        Assert.AreEqual(root.LeftNode.LeftNode.Data, "a");
        Assert.AreEqual(root.LeftNode.RightNode.Data, "c");
    }
}
