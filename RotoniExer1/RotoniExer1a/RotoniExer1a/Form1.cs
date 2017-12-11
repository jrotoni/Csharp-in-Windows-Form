/* Rotoni, Jeremy C.
 * 2007-85009
 * March 17, 2017
 * I created a program and named it as "The Dishwashing Project."
 * Here, I made a visual representation of stack where you can see how it push and pop.
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
using Microsoft.VisualBasic;

namespace RotoniExer1a
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent(); //This is where The Dishwashing Project interface loads.

        }

        private void Form1_Load(object sender, EventArgs e) 
        {


        }




        private void button5_Click(object sender, EventArgs e) //This is where you close your application.
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //This is where the user input the kitchenware.
        {
            Add_Kitchenware AddKitchenwareForm = new Add_Kitchenware(this);
            AddKitchenwareForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) // The kitchenware is popped from the stack.
        {
            StackArray.Pop();
            if(StackArray.top == -1)
            {
                label1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e) // Shows the name of the kitchenware on the top
        {
            StackArray.Ibabaw();
        }

        private void button4_Click(object sender, EventArgs e) // This is where you empty the array
        {
            StackArray.WashAll();
           
        }




}
}
