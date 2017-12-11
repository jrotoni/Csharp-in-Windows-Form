using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotoniExer2
{
    public class BinarySearchTree //This is where I created the methods.
    {
        public Node root;
        
        public BinarySearchTree()
        {
            root = null;
            
        }

        public void InsertNode(int data) //This is where I add the data into a new node.
        {
            Node newNode = new Node(data);
            if (root == null) //If the BST is empty, the new node will be the root node.
            {
                root = newNode;
            }

            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.Data) //This is where you add the node if it is less than the value of a root or parent node.
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right; //This is where you add the node if it is greater than the value of a root or parent node.
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void DeleteNode(int x, Form1 form) //This is where I delete my node
        {

            Node deleteNode = new Node(x);
            DeleteN(ref root, deleteNode.Data, form);
        }

        public void DeleteN(ref Node root, int num, Form1 form)
        {
            bool found = true;
            Node parent, DelNode, tempDelNode;

           /* if (root == null) //This will prompt the user if the BST is empty. However, this is no need because I disabled my Delete Node panel in my form if the BST is empty. 
            {
                form.label1.Text = "The BST is empty!";
                return;
            }*/

            parent = DelNode = null;


            Searchee(ref root, ref num, ref parent, ref DelNode, ref found);
            if (found == false) //Will prompt the user if the desired node to be deleted is not in the BST.
            {
                form.label1.Text = String.Format("Not found! There is no number {0} in the BST.", num);
                return;
            }
            else //This will prompt the user if the node has successfully deleted in the BST.
            {
                form.label1.Text = String.Format("{0} has been deleted in the BST.", num);
            }
            if (DelNode.Left != null && DelNode.Right != null)
            {
                parent = DelNode;
                tempDelNode = DelNode.Right;

                while (tempDelNode.Left != null)
                {
                    parent = tempDelNode;
                    tempDelNode = tempDelNode.Left;
                }

                DelNode.Data = tempDelNode.Data;
                DelNode = tempDelNode;
            }

            if (DelNode.Left == null && DelNode.Right == null) //If the node to be deleted has no left or right node.
            {
                if (parent != null)
                {
                    if (parent.Right == DelNode)
                    {
                        parent.Right = null;
                    }
                    else
                    {
                        parent.Left = null;
                    }
                    DelNode = null;
                    return;
                }
                else
                {
                    root = null;
                    return;
                }
            }

            if (DelNode.Left == null && DelNode.Right != null) //If the node to be deleted has only have a right child.
            {
                if (parent != null)
                {
                    if (parent.Left == DelNode)
                    {
                        parent.Left = DelNode.Right;
                    }
                    else
                    {
                        parent.Right = DelNode.Right;
                    }
                    DelNode = null;
                    return;
                }
                else
                {
                    root = root.Right;
                    return;
                }
            }

            if (DelNode.Left != null && DelNode.Right == null) //If the node to be deleted has only have a left child.
            {
                if (parent != null)
                {
                    if (parent.Left == DelNode)
                    {
                        parent.Left = DelNode.Left;
                    }

                    else
                    {
                        parent.Right = DelNode.Left;
                    }

                    DelNode = null;
                    return;
                }
                else
                {
                    root = root.Left;
                    return;
                }
            }
        }

        public void Searchee(ref Node root, ref int num, ref Node tempParent, ref Node x, ref bool found)
        {
            Node tempNode;
            tempNode = root;
            found = false;
            tempParent = null;

            while (tempNode != null)
            {
                if (tempNode.Data == num)
                {
                    found = true;
                    x = tempNode;
                    return;
                }

                tempParent = tempNode;

                if (tempNode.Data > num)
                {
                    tempNode = tempNode.Left;

                }
                else
                {
                    tempNode = tempNode.Right;

                }
            }


        }

        public Node FindMin(Node root) //Will find the minimum value of the BST and return a value once it called.
        {
            while (root.Left != null)
            {
                root = root.Left;
            }
            return root;
        }

        public Node FindMax(Node root) //Will find the maximum value of the BST and return a value once it called.
        {
            while (root.Right != null)
            {
                root = root.Right;
            }
            return root;
        }

        public void Minimum(ref string value) //Will look into the left most node of the BST.
        {
            
            Node current = root;
            if (current == null)
            {
                value = null;
            }
            else
            {
                while (current.Left != null)
                {
                    current = current.Left;
                }
                value = Convert.ToString(current.Data);
            }
        }

        public void Maximum(ref string value) //Will look into the right most node of the BST.
        {
            Node current = root;
            if (current == null)
            {
                value = null;
            }
            else
            {
                while (current.Right != null)
                {
                    current = current.Right;
                }
                value = Convert.ToString(current.Data);
            }
        }

        public Node Find(Node root, int data) //Will find the inserted value in the BST.
        {
            if (root == null) return null;
            else if (root.Data == data) return root;
            else if (root.Data < data) return Find(root.Right, data);
            else return Find(root.Left, data);
        }

        public void Successor(Form1 form1, int x)
        {
            Node successor = Getsuccessor(root, x);
            if (successor != null)
            {
                form1.label1.Text = String.Format("The successor of {0} is {1}.", x, successor.Data);
                return;
            }
            if (successor == null && Find(root, x) == null)
            {
                form1.label1.Text = String.Format("There is no number {0} in the BST.", x);
            }
            else
            {
                form1.label1.Text = String.Format("Number {0} has no successor in the BST.", x);
            }
        }

        public Node Getsuccessor(Node root, int data)
        {
            Node insertedValue = Find(root, data); //Will find first the inserted value in the BST. If found, assigned it to temporary node.
            if (insertedValue == null) { return null; }
            if (insertedValue.Right != null) //If the node has a right child.
            {  
                return FindMin(insertedValue.Right); 
            }
            else //If the node has no right child.
            {   
                Node successor = null;
                Node ancestor = root;
                while (ancestor != insertedValue)
                {
                    if (insertedValue.Data < ancestor.Data)
                    {
                        successor = ancestor; 
                        ancestor = ancestor.Left;
                    }
                    else
                    {
                        ancestor = ancestor.Right;
                    }
                }
                return successor; //Will return the successor of inserted value.
            }
        }

        public void Predecessor(Form1 form1, int x)
        {

            Node predecessor = Getpredecessor(root, x);
            if(predecessor!=null)
            {
                form1.label1.Text = String.Format("The predecessor of {0} is {1}.", x, predecessor.Data);
                return;
            }
            if(predecessor == null && Find(root, x) == null)
            {
                form1.label1.Text = String.Format("There is no number {0} in the BST.", x);
            }
            else
            {
                form1.label1.Text = String.Format("Number {0} has no predecessor in the BST.", x);
            }
        }

        public Node Getpredecessor(Node root, int data)
        {
 
            Node insertedValue = Find(root, data); //Will find first the inserted value in the BST. If found, assigned it to temporary node.
            if (insertedValue == null) { return null; }
            if (insertedValue.Left != null) //If the node has a left child.
            {  
                return FindMax(insertedValue.Left); 
            }
            else //If the node has no left child.
            {   
                Node predecessor = null;
                Node ancestor = root;
                while (ancestor != insertedValue)
                {
                    if (insertedValue.Data > ancestor.Data)
                    {
                        predecessor = ancestor; 
                        ancestor = ancestor.Right;
                    }
                    else
                    {
                        ancestor = ancestor.Left;
                    }
                }
                return predecessor; //Will return the predecessor of inserted value.
            }
        }

        public void Search(Form1 form1, int x) //This is where you find the value in the BST.
        {
            SearchNode(root, x, form1);
        }

        public void SearchNode(Node root, int x, Form1 form1)
        {
            if (root == null) //Will prompt the user if the inserted value has not found in the BST.
            {
                form1.label1.Text = String.Format("Not found! {0} is not in the BST.", x);

            }
            else if (root.Data == x) //Will prompt the user if the inserted value has found in the BST.
            {
                form1.label1.Text = String.Format("Found! Number {0} is in the BST.", x);

            }
            else if (x < root.Data) //Will keep searching in the left subtree if the inserted value is less than the root node. 
            {
                SearchNode(root.Left, x, form1);
            }
            else if (x >= root.Data) //Will keep searching in the right subtree if the inserted value is greater than the root node.
            {
                SearchNode(root.Right, x, form1);
            }
        }

        public void PrintBST(Form1 form) //This is where I print the BST in sorted order.
        {
            string PrintValue = "";
            PrintBSTRecurssion(null, ref PrintValue);
            form.label1.Text = "Inorder:" + PrintValue;
        }
        public void PrintBSTRecurssion(Node tempNode, ref string PrintNode)
        {
            if (tempNode == null) { tempNode = root; } //Will assign the root node value to tempNode.
            if (tempNode.Left != null) //Will find the value of the node if it has a left child and stored into a string value.
            {
                PrintBSTRecurssion(tempNode.Left, ref PrintNode);
                PrintNode = PrintNode + tempNode.Data.ToString().PadLeft(6)+",";
            }
            else
            {
                PrintNode = PrintNode + tempNode.Data.ToString().PadLeft(6)+",";
            }
            if (tempNode.Right != null) //Will find the value of the node if it has a right child and stored into a string value.
            {
                PrintBSTRecurssion(tempNode.Right, ref PrintNode);
            }
        }

       


    }
}
