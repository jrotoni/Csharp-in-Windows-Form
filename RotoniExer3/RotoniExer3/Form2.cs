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
    public partial class Form2 : Form
    {
        Form1 MainForm;
        public Graph g1 = new Graph(6); // This is where I initizialize the number of vertices on each graph
        public Graph g2 = new Graph(4);

        public Form2(Form1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        public void Graph1() // This is where I enqueued the adjacent vertices for Graph 1
        {
            g1.EnQ(0, 2);
            g1.EnQ(1, 0);
            g1.EnQ(1, 2);
            g1.EnQ(2, 3);
            g1.EnQ(2, 4);
            g1.EnQ(3, 1);
            g1.EnQ(4, 1);
            g1.EnQ(4, 3);
            g1.EnQ(4, 5);
            g1.EnQ(5, 3);
        }

        public void Graph2() // This is where I enqueued the adjacent vertices for Graph 2
        {
            g2.EnQ(0, 1);
            g2.EnQ(1, 2);
            g2.EnQ(1, 3);
            g2.EnQ(2, 0);
            g2.EnQ(2, 3);
            g2.EnQ(3, 0);
        }
        
        private void button1_Click(object sender, EventArgs e) // Graph 1
        {
            this.Close();
            this.MainForm.label1.Text = "";
            Graph1();
            this.MainForm.Graph1.Visible = true;
            this.MainForm.Graph2.Visible = false;
            if (this.MainForm.DFS == true)
            {
                g1.DFSPrint(this.MainForm);
                this.MainForm.DFS = false;
            }
            else if(this.MainForm.BFS == true)
            {
                g1.BFSPrint(this.MainForm);
            }
            this.MainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Graph 2
        {
            this.Close();
            this.MainForm.label1.Text = "";
            Graph2();
            this.MainForm.Graph1.Visible = false;
            this.MainForm.Graph2.Visible = true;
            if (this.MainForm.DFS == true)
            {
                g2.DFSPrint(this.MainForm);
                this.MainForm.DFS = false;
            }
            else if (this.MainForm.BFS == true)
            {
                g2.BFSPrint(this.MainForm);
            }
            this.MainForm.Show();
        }


    }
}
