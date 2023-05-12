using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_17
{
    public class TreeNode<T>
    {
        private T value;
        private bool hasParent;
        private List<TreeNode<T>> children;
        
        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value");
            }
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value");
            }
            if(child.hasParent)
            {
                throw new ArgumentException("The node already has a parent");
            }
            child.hasParent= true;
            this.children.Add(child);
        }
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }





    }
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("Cannot enter null value");
            }
            this.root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children):this(value)
        {
            foreach(Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
           
        }
        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }
        private void PrintDFS(TreeNode<T> root)
        {
            if(this.root == null)
            {
                return;
            }
            Console.WriteLine(root.Value);
            TreeNode<T> child = null;
            for(int i = 0; i<root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child);
            }
        }
        public void TraverseDFS()
        {
            this.PrintDFS(this.root);
        }
         
        //public void CountOfNumber(int n)
        //{
        //    if (this.root == null)
        //    {
        //        return;
        //    }
        //    Console.WriteLine(root.Value);
        //    TreeNode<int> child = null;
        //    int count = 0;
        //    for (int i = 0; i < root.ChildrenCount; i++)
        //    {
        //        child = root.GetChild(i);
        //        if(child.Value == n)
        //        {
            //        count++;
            //    }
              //   
            //}
           // Console.WriteLine(count);
       // }
            
        //public static void Exercise1()
        //{
        //    //Tree<int> tree = new Tree<int>(7, new Tree<int>(19, new Tree<int>(1), new Tree<int>(12), new Tree<int>(31)), new Tree<int>(12), new Tree<int>(14, new Tree<int>(31), new Tree<int>(6)));

        //    Tree<int> tree2 = new Tree<int>(7);
        //    TreeNode<int> childOne = new TreeNode<int>(19);
        //    childOne.AddChild(new TreeNode<int>(90));
        //    tree2.Root.AddChild(child_one);
        //    tree2.Root.AddChild(new TreeNode<int>(13));
        //    tree2.Root.AddChild(new TreeNode<int>(15));
        //    tree2.Root.AddChild(new TreeNode<int>(23));
        //    tree2.Root.AddChild(new TreeNode<int>(8));
        //    tree2.Root.AddChild(new TreeNode<int>(11));


        //    tree.CountOfNumber(7);
        //}
    }
}
