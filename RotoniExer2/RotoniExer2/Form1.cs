/* Jeremy C. Rotoni
 * 2007-85009
 * A program where you can add and delete a node in a binary search tree.
 * You could also search the value in the binary search tree, find the minimum or maximum value,  
 * find the successor or predecessor of a value, and print the binary search tree in order. 
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RotoniExer2
{
    public partial class Form1 : Form
    {
        BinarySearchTree BST = new BinarySearchTree();
    
        public Form1()
        {
            InitializeComponent();
      
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InsertNode_Click(object sender, EventArgs e) 
        {
            textBox1.Clear();
            InsertPanel.Visible = true;
            panel1.Enabled = false;
            label1.Text = "Please input an integer";
           
            
        }

        private void button1_Click(object sender, EventArgs e) //This is where you insert a node
        {
            InsertPanel.Visible = false;
            panel1.Enabled = true;
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                label1.Text = String.Format("{0} has been inserted into the BST", Convert.ToString(number));
                BST.InsertNode(number);
            } 
            else
            {
                label1.Text = "Please input an integer";
            }

            
        }

        private void DeleteNode_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (BST.root != null)
            {
                DeletePanel.Visible = true;
                panel1.Enabled = false;
            }
            else
            {
                label1.Text = "The BST is empty. Please insert a node.";
            }

        }

        private void button2_Click(object sender, EventArgs e) //This is where you delete a node
        {
            DeletePanel.Visible = false;
            panel1.Enabled = true;
            int number;
            if (int.TryParse(textBox2.Text, out number))
            {
                BST.DeleteNode(number, this);
            }
            else
            {
                label1.Text = "Please input an integer";
            }
        }

        private void Successor_Click(object sender, EventArgs e) 
        {
            textBox5.Clear();
            if (BST.root != null)
            {
                SuccessorPanel.Visible = true;
                panel1.Enabled = false;
            }
            else
            {
                label1.Text = "The BST is empty. Please insert a node.";
            }
        }


        private void button5_Click(object sender, EventArgs e) //This is where you find the successor of a value
        {
            SuccessorPanel.Visible = false;
            panel1.Enabled = true;
            int number;
                if (int.TryParse(textBox5.Text, out number))
                {
                    BST.Successor(this, number);
                }
                else
                {
                    label1.Text = "Please input an integer";
                }
            
        }

        private void Predecessor_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            if (BST.root != null)
            {
                PredecessorPanel.Visible = true;
                panel1.Enabled = false;
            }
            else
            {
                label1.Text = "The BST is empty. Please insert a node.";
            }

        }

        private void button6_Click(object sender, EventArgs e) //This is where you find the predecessor of a value
        {
            PredecessorPanel.Visible = false;
            panel1.Enabled = true;
            int number;
                if (int.TryParse(textBox6.Text, out number))
                {
                    BST.Predecessor(this, number);
                }
                else
                {
                    label1.Text = "Please input an integer";
                }

        }

        private void Search_Click(object sender, EventArgs e) 
        {
            textBox7.Clear();
            if (BST.root != null)
            {
                SearchPanel.Visible = true;
                panel1.Enabled = false;
            }
            else
            {
                label1.Text = "The BST is empty. Please insert a node.";
            }
}

        private void button7_Click(object sender, EventArgs e) //This is where you search the value
        {
            SearchPanel.Visible = false;
            panel1.Enabled = true;
            int number;

                if (int.TryParse(textBox7.Text, out number))
                {
                    BST.Search(this, number);
                }
                else
                {
                    label1.Text = "Please input an integer";
                }

        }


        private void Minimum_Click(object sender, EventArgs e) //Displays the minimum value of BST.
        {
            string value = "";
            
            BST.Minimum(ref value);
            if (value == null)
            {
                label1.Text = "The BST is empty. Please insert a node.";
            }
            else
            {
                label1.Text = "The minimum value is: " + value;
            }
        }

        private void Maximum_Click(object sender, EventArgs e) //Displays the maximum value of BST.
        {
            string value = "";
            
            BST.Maximum(ref value);
            if (value == null)
            {
                label1.Text = "The BST is empty. Please insert a node.";
            }
            else
            {
                label1.Text = "The maximum value is: " + value;
            }
        }

        private void PrintBST_Click(object sender, EventArgs e) //Print the binary search tree in order.
        {
            if (BST.root != null)
            {
                BST.PrintBST(this);
            }
            else
            {
                label1.Text = "The BST is empty. Please insert a node.";
            }

        }
    }
}
