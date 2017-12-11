using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotoniExer1a
{
    public partial class Add_Kitchenware : Form //This is where I declared the variables of my array.
    {
        Form1 MainForm;
        public static string Kitchenware;
        public static Label[] _Labels = new Label[6];
        public static int labelx = 0;

        public Add_Kitchenware(Form1 form) //get the value from Form1
        {
            InitializeComponent();
            MainForm = form; //assign the this variables
            
                _Labels[0] = this.MainForm.label1;
                _Labels[1] = this.MainForm.label2;
                _Labels[2] = this.MainForm.label3;
                _Labels[3] = this.MainForm.label4;
                _Labels[4] = this.MainForm.label5;
                _Labels[5] = this.MainForm.label6;
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e) //limit the size of the text into 20 characters
        {
            textBox1.MaxLength = 20;
        }

        private void button1_Click(object sender, EventArgs e) //made a condition where the user input a null value
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Please enter any value.");
            }
            else
            {
                executePush();
            }
     
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) //this is where the user hit the enter key
        {
            if (e.KeyCode == Keys.Enter && textBox1.TextLength ==0)
            {
                MessageBox.Show("Please enter any value.");
                
            }
            if(e.KeyCode == Keys.Enter && textBox1.TextLength!=0)
            {
                executePush();
            }

        }


        private void executePush() //this is wehere you stored the value of textbox into array
        {
            Kitchenware = textBox1.Text;
            StackArray.Push();

            for (labelx = labelx + 0; labelx <= StackArray.top; labelx++) //this is where I print the text in the form for visual aide
            {
                _Labels[labelx].Visible = true;
                _Labels[labelx].Text = StackArray.DishWashing[StackArray.top];
            }
            this.Close();
        }


    }
}
