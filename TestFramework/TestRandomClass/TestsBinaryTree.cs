using BalancedBinaryTree;
using System;
using TestFramework;

namespace TestRandomClass
{
    //Tested Classes and methods
    [NTestClass]
    public class TestsBinaryTree
    {
        private BinaryTree<int> tree;


        #region SearchTests
        [NTestMethod]
        public void Search_ExistNode_trueReturned()
        {
            tree = new BinaryTree<int>(3);

            tree.Insert(1);
            tree.Insert(5);

            Console.WriteLine("Search_ExistNode_trueReturned() :" + Assert<int>.IsTrue(tree.Search(5)));
        }

        [NTestMethod]
        public void Search5and3_EmptyTree_falseReturned()
        {
            tree = new BinaryTree<int>(3);
            tree.Erase(3);
            Console.WriteLine("Search3_EmptyTree_falseReturned " + Assert<int>.IsTrue(!tree.Search(3)));
            Console.WriteLine("Search5_EmptyTree_falseReturned " + Assert<int>.IsTrue(!tree.Search(5)));


        }

        [NTestMethod]
        public void Search_NonxistentNode_falseReturned()
        {

            tree = new BinaryTree<int>(3);

            tree.Insert(1);
            tree.Insert(5);

            Console.WriteLine("Search_NonxistentNode_falseReturned " + Assert<int>.IsFalse(tree.Search(42)));
        }
        #endregion

        #region Erase Tests
        [NTestMethod]
        public void Erase_Delete5_5Deleted()
        {

            tree = new BinaryTree<int>(2);

            tree.Insert(5);
            tree.Insert(43);
            tree.Erase(5);

            Console.WriteLine("Erase_Delete5_5Deleted " + Assert<int>.IsTrue(!tree.Search(5)));
        }

        public void Erase2_EmptyTree_FalseReturned()
        {

            tree = new BinaryTree<int>(2);

            tree.Erase(2);

          Console.WriteLine("Erase2_EmptyTree_FalseReturned " +  Assert<int>.IsFalse(!tree.Search(53)));
        }

        [NTestMethod]
        public void Erase53_NonexistentNode_FalseReturned()
        {

            tree = new BinaryTree<int>(2);

            tree.Insert(5);
            tree.Insert(43);
            tree.Erase(53);

           Console.WriteLine("Erase53_NonexistentNode_FalseReturned " + Assert<int>.IsTrue(!tree.Search(53)));
        }


        #endregion


    }
    //Didn't mark with attribute to show that TestFramework doesn't run classes and methods without attributes
     public class TestsBinaryTree2
    {
        private BinaryTree<int> tree;
        public void Insert1_EmptyTree_AddedNode()
        {
            tree = new BinaryTree<int>(2);

            tree.Erase(2);
            Console.WriteLine(" Insert1_EmptyTree_AddedNode " + Assert<int>.IsFalse(tree.Search(2)));
            tree.Insert(1);
            Console.WriteLine("Insert1_EmptyTree_AddedNode "+ Assert<int>.IsTrue(tree.Search(1)));
        }
        [NTestMethod]
        public void Insert_ADD5_5Found()
        {

            tree = new BinaryTree<int>(41);

            bool expected = true;


            tree.Insert(5);
            bool actual = tree.Search(5);

           Console.WriteLine("Insert_ADD5_5Found " + Assert<bool>.AreEqual(expected, actual));
        }
    }

}