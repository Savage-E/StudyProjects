using BalancedBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AVL_TREE.Tests
{
    [TestClass]
    public class BinaryTreeTests
    {
        private BinaryTree<int> tree;

        #region Search Tests

        [TestMethod]
        public void Search_ExistNode_trueReturned()
        {
            tree = new BinaryTree<int>(3);
          
            tree.Insert(1);
            tree.Insert(5);
           
            Assert.IsTrue(tree.Search(5));
        }

        [TestMethod]
        public void Search_EmptyTree_falseReturned()
        {
            tree = new BinaryTree<int>(3);
            tree.Erase(3);
            Assert.IsFalse(tree.Search(3));
            Assert.IsFalse(tree.Search(5));
        }

        [TestMethod]
        public void Search_NonxistentNode_falseReturned()
        {
 
            tree = new BinaryTree<int>(3);
           
            tree.Insert(1);
            tree.Insert(5);
  
            Assert.IsFalse(tree.Search(42));
        }



        #endregion

        #region Erase Tests
        [TestMethod]
        public void Erase_Delete5_5Deleted()
        {

            tree = new BinaryTree<int>(2);
           
            tree.Insert(5);
            tree.Insert(43);
            tree.Erase(5);
           
            Assert.IsFalse(tree.Search(5));
        }

        public void Erase_EmptyTree_NothingReturned()
        {
            
            tree = new BinaryTree<int>(2);

            tree.Erase(2);

            Assert.IsFalse(tree.Search(53));
        }

        [TestMethod]
        public void Erase_NonexistentNode_NothingReturned()
        {
            
            tree = new BinaryTree<int>(2);
            
            tree.Insert(5);
            tree.Insert(43);
            tree.Erase(53);
            
            Assert.IsFalse(tree.Search(53));
        }
        #endregion
        [TestMethod]

        public void Insert_EmptyTree_AddedNode()
        {
            tree = new BinaryTree<int>(2);

            tree.Erase(2);
            Assert.IsFalse(tree.Search(2));
            tree.Insert(1);
            
            Assert.IsTrue(tree.Search( 1));
        }

        public void Insert_ADD5_NothingReturned()
        {
            
            tree = new BinaryTree<int>(41);

            bool expected = true;

            
            tree.Insert(5);
            bool actual = tree.Search(5);
            
            Assert.AreEqual(expected, actual);
        }
    }
}