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
    class StackArray //This is where I construct my methods. 
    {
        public static int top = -1; // This is where assigned the index of an array
        public static string[] DishWashing = new string[6]; // The size of an array is limited to six indexes


        public static void Push() // You will add kitchenware
        {

            if (top == 5)
            {
                MessageBox.Show("The Dish Washing Project is full!"); //The array storage is overflowing. The cons of an array :'(
            }
            else { 
                top = top + 1;
                DishWashing[top] = Add_Kitchenware.Kitchenware; //The new kitchenware will add and serve as the last kitchenware or top on the stack
            }
            
        }

        public static void Pop() // You will remove the kitchenware
        {
            if (top < 0)
            {
                MessageBox.Show("There are no kitchenwares!"); // //Notify the user that the array is empty
            }
            else
            {
                MessageBox.Show(String.Format("The {0} is being washed!", DishWashing[top]));
                top = top - 1;
                Add_Kitchenware._Labels[top + 1].Visible = false; //The last kitchenware will be removed
                Add_Kitchenware.labelx = Add_Kitchenware.labelx - 1;
            }
        }

        public static void Ibabaw() // Shows the top of the kitchenware
        {
            if (top < 0)
            {
                MessageBox.Show("There are no kitchenwares!"); //Notify the user that the array is empty
            }
            else
            {
                MessageBox.Show(String.Format("The {0} is on the top!", DishWashing[top]));
            }
        }

        public static void WashAll() // remove all the kitchenwares and delete all the value
        {
            while (top != -1)
            {
                top = top - 1;
                Add_Kitchenware._Labels[top+1].Visible = false;
            }
            Add_Kitchenware.labelx = 0;
            MessageBox.Show("The Dish Washing Project is clean!");
        }
    }
}
