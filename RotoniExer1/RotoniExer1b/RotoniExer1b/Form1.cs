/* Rotoni, Jeremy C.
 * 2007-85009
 * March 17, 2017
 * I made a program that looks like a simulator where you get the orders in a restaurant.
 * I named my restaurant as Baybi :)
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotoniExer1b
{
    public partial class Form1 : Form
    {
        LinkedListImplementation linky = new LinkedListImplementation(); //This is where you access your linkedlist

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Where it exits your program
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e) //This is where you input the data
        {
            textBox1.Text = null;
            textBox2.Text = null;
            panel1.Visible = true;
        }

        private void back1_Click(object sender, EventArgs e) //This is where you enqueue the data
        {
            

            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Please put any value in 'Name' or 'Order'");
            }

            else
            {
                pictureBox2.Visible = true;
                panel1.Visible = false;
                linky.EnQ(textBox1.Text, textBox2.Text);
                welcome.Text = "Hello! " + linky.FirstInTheLine();
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void button4_Click(object sender, EventArgs e) //This is where you free up the whole queue
        {
            if (linky.size == 0)
            {
                MessageBox.Show("The queue is empty.");
            }
            else
            {
                pictureBox2.Visible = false;
                panel4.Visible = true;
                linky.Clear();
                welcome.Text = "Closing time!";
            }
        }

        private void button2_Click(object sender, EventArgs e) //This is where you show the order
        {
            
            if (linky.size == 0)
            {
                MessageBox.Show("The queue is empty.");
            }
            else
            {
                Panel2.Visible = true;
                DisplayOrder.Text = String.Format("{0}'s order is {1}. \nHappy to serve! Clap(3x)!", linky.FirstInTheLine(), linky.OrderNungUna());
                welcome.Text = "Bye, " + linky.FirstInTheLine() + "!";
                linky.DeQ();
                if (linky.size == 0)
                {
                    pictureBox2.Visible = false;
                }
            }
        }



        private void button5_Click(object sender, EventArgs e) //This is where you show the name in the smallest monitor
        {
            Panel2.Visible = false;
            if (linky.FirstInTheLine() == null)
            {
                welcome.Text = "Welcome to Baybi!";
            }
            else
            {
                welcome.Text = "Hi, " + linky.FirstInTheLine() +"!";
            }
        }

        private void button3_Click(object sender, EventArgs e) //This is where you present the name
        {
            if (linky.size == 0)
            {
                MessageBox.Show("The queue is empty.");
            }
            else
            {
                panel3.Visible = true;
                label3.Text = "Customer's name is " + linky.FirstInTheLine();
            }

        }

        private void button6_Click(object sender, EventArgs e) //This is where you close the panel3
        {
            panel3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e) //This is where you close the panel4
        {
            panel4.Visible = false;
        }



    }
}
