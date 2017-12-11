/* Jeremy C. Rotoni
 * 2007-85009
 * April 28, 2017
 * This windows form application tries to be much simpler than the previous exercises.
 * It performs a Depth First Traversal and Breadth First Traversal on selected graph. 
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

namespace RotoniExer3
{
    public partial class Form1 : Form
    {
        public bool DFS = false; // This is where the Form 2 determined if it's DFS or BFS
        public bool BFS = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Perform Depth First Traversal
        {
            this.Visible = false;
            DFS = true;
            Form2 form2 = new RotoniExer3.Form2(this);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Perform Breadth First Traversal
        {
            this.Visible = false;
            BFS = true;
            Form2 form2 = new RotoniExer3.Form2(this);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e) // Perform Depth First Search in Graph 1
        {
            panel1.Enabled = false;
            Graph1.Visible = true;
            Graph2.Visible = false;
            panel3.Visible = true;
            
        }

        private void button4_Click(object sender, EventArgs e) // Perform Breadth First Search in Graph 2
        {
            panel1.Enabled = false;
            Graph1.Visible = false;
            Graph2.Visible = true;
            panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e) // Close the program
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e) // Get the value to do Depth First Search in Graph 1
        {
            Form2 form2 = new RotoniExer3.Form2(this);
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                form2.Graph1();
                form2.g1.DFSearch(this, number);
                panel3.Visible = false;
                textBox1.Clear();
                panel1.Enabled = true;
            }

        }

        private void button7_Click_1(object sender, EventArgs e) // Get the value to do Breadth First Search in Graph 2
        {
            
            Form2 form2 = new RotoniExer3.Form2(this);
            int number;
            if (int.TryParse(textBox2.Text, out number))
            {
                form2.Graph2();
                form2.g2.BFSearch(this, number);
                panel4.Visible = false;
                textBox2.Clear();
                panel1.Enabled = true;
            }
        }
    }
}
