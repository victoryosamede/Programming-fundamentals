using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProgrammingFundamentalsPractice.Chapter_17
{
    public class ChapterSeventeenExercises
    {
       public static void Exercise1()
       {
            Tree<int> tree = new Tree<int>(8);
            TreeNode<int> childOne = new TreeNode<int>(2);
            TreeNode<int> childTwo = new TreeNode<int>(16);
            TreeNode<int> childThree = new TreeNode<int>(15);
            tree.Root.AddChild(childOne);
            tree.Root.AddChild(childTwo);
            tree.Root.AddChild(childThree);
            TreeNode<int> childFour= new TreeNode<int>(11);
            childOne.AddChild(childFour);
            TreeNode<int> childFive = new TreeNode<int>(7);
            childFour.AddChild(childFive);
            TreeNode<int> childSix = new TreeNode<int>(15);
            childFour.AddChild(childSix);
            TreeNode<int> childSeven = new TreeNode<int>(15);
            childTwo.AddChild(childSeven);
            TreeNode<int> childEight = new TreeNode<int>(21);
            childThree.AddChild(childEight);
            TreeNode<int> childNine = new TreeNode<int>(15);
            childThree.AddChild(childNine);
            TreeNode<int> childTen = new TreeNode<int>(3);
            childThree.AddChild(childTen);
            TreeNode<int> treeRoot =  tree.Root;
            DoIt(treeRoot, 15);
             
       }
        public static int count = 0;
        public static int nodeCount = 0;

        public static void DoIt(TreeNode<int> node, int n) 
        {
            TraverseDFS2(node, n);
            Console.WriteLine(n + " appeared " + count + " times ");
        }

        public static void TraverseDFS2(TreeNode<int> node,  int n)
        {
            
            if(node == null)
            {
                return;
            }
            Console.WriteLine(node.Value);
            TreeNode<int> child = null;
            
            for(int i = 0; i < node.ChildrenCount; i++)
            {
                
                child = node.GetChild(i);
                
                if (child.Value == n)
                {
                    count++;
                    
                }
                 
               
                TraverseDFS2(child, n);
                
                 
            }
            
            
            //Console.WriteLine(n + " appeared " + count + " times ");
        }
        
        public static void Exercise2()
        {
            Tree<int> tree = new Tree<int>(8);
            TreeNode<int> childOne = new TreeNode<int>(2);
            TreeNode<int> childTwo = new TreeNode<int>(16);
            TreeNode<int> childThree = new TreeNode<int>(15);
            tree.Root.AddChild(childOne);
            tree.Root.AddChild(childTwo);
            tree.Root.AddChild(childThree);
            TreeNode<int> childFour = new TreeNode<int>(11);
            childOne.AddChild(childFour);
            TreeNode<int> childFive = new TreeNode<int>(7);
            childFour.AddChild(childFive);
            TreeNode<int> childSix = new TreeNode<int>(15);
            childFour.AddChild(childSix);
            TreeNode<int> childSeven = new TreeNode<int>(15);
            childTwo.AddChild(childSeven);
            TreeNode<int> childEight = new TreeNode<int>(21);
            childThree.AddChild(childEight);
            TreeNode<int> childNine = new TreeNode<int>(15);
            childThree.AddChild(childNine);
            TreeNode<int> childTen = new TreeNode<int>(3);
            childThree.AddChild(childTen);
            TreeNode<int> treeRoot = tree.Root;
            Count(treeRoot, 4);
        }
        public static void CountNodes(TreeNode<int> node, int n)
        {
            // Interesting!!!
            // why is there a children count property in node?

            if (node == null)
            {
                return;
            }
           
            //Console.WriteLine($"Child count for this node is: {node.ChildrenCount}");
            TreeNode<int> child = null;
            count = node.ChildrenCount;
            for (int i = 0; i < node.ChildrenCount; i++)
            {

                child = node.GetChild(i);


                nodeCount = nodeCount + count;
                
                CountNodes(child, n);
                
               

            }


            //Console.WriteLine(n + " appeared " + count + " times ");
        }
        public static void Count(TreeNode<int> node, int n)
        {
            List<int> store = new List<int>();
            for (int i = 0; i < node.ChildrenCount; i++)
            {
                TreeNode<int> child2 = node.GetChild(i);
                int totalNodes = 0;
                CountNodes(child2, n);
                totalNodes = 1 + nodeCount;
                nodeCount = 0;
                if (totalNodes == n)
                {
                    
                    store.Add(child2.Value);
                }
            }
            Console.Write($"The root of subtrees with {n} nodes are: ");
            for (int i = 0; i < store.Count; i++)
            {
                Console.Write(store[i] + ", ");
            }
           var fraction = $"{n}\u2044{node}";
            Console.WriteLine(fraction);

        }
       //public static void GetCount(TreeNode<int> node)
       // {
        //    Count(node);
      //  }
    }
}
