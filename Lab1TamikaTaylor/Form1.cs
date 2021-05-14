using System;
using System.Windows.Forms;

namespace Lab1TamikaTaylor
{
    public partial class LunchOrderingApp : Form
    {
        //Constants
        private const decimal hamburger = 6.95m;
        private const decimal pizza = 5.95m;
        private const decimal salad = 4.95m;
        private const decimal hamburgerChoices = .75m;
        private const decimal pizzaChoices = .50m;
        private const decimal saladChoices = .25m;

        // Functions
        
        // Function that clears all the checkboxes
        public void ClearCheckBox() 
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
        // Function that clears all the textboxes
        public void CleartxtBox() 
        {
            txtSubTotal.Clear();
            txtTax.Clear();
            txtOrderTotal.Clear();
        }

        public LunchOrderingApp()
        {
            InitializeComponent();
        }

        private void LunchOrderingApp_Load(object sender, EventArgs e)
        {
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0;

            //if statement that add the Hamburger||Pizza||Salad cost to the subtotal
            //if the Hamburger||Pizza||Salad radio button is checked 
            if (radBtnHamburger.Checked)
            {
                subtotal += hamburger;

                //Nested if statements for Main Course checkboxes that add the addons to the subtotal
                //if the checkboxes are checked
                if (checkBox1.Checked == true)
                {
                    subtotal += hamburgerChoices;
                }
                if (checkBox2.Checked == true)
                {
                    subtotal += hamburgerChoices;
                }
                if (checkBox3.Checked == true)
                {
                    subtotal += hamburgerChoices;
                }
            }
            else if (radBtnPizza.Checked)
            {
                subtotal += pizza;

                if (checkBox1.Checked == true)
                {
                    subtotal += pizzaChoices;
                }
                if (checkBox2.Checked == true)
                {
                    subtotal += pizzaChoices;
                }
                if (checkBox3.Checked == true)
                {
                    subtotal += pizzaChoices;
                }
            }
            else if (radBtnSalad.Checked)
            {
                subtotal += salad;

                if (checkBox1.Checked == true)
                {
                    subtotal += saladChoices;
                }
                if (checkBox2.Checked == true)
                {
                    subtotal += saladChoices;
                }
                if (checkBox3.Checked == true)
                {
                    subtotal += saladChoices;
                }
            }

            //Calculating the info in OrderTotal GroupBox
            decimal tax = .05m * subtotal;
            decimal orderTotal = tax + subtotal;

            //Displaying the info in OrderTotal GroupBox
            txtSubTotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtOrderTotal.Text = orderTotal.ToString("c");
        }

        private void radBtnHamburger_CheckedChanged(object sender, EventArgs e)
        {   //EveryTime a different Radio button is Checked it clears every checkbox and textbox 
           // then changes the groupbox text and all the checkbox text
            ClearCheckBox();
            CleartxtBox();

            gbAddOns.Text = "Add-on items ($.75/each)";
            checkBox1.Text = "Lettuce,Tomato & Onions";
            checkBox2.Text = "Ketchup, Mustard & Mayo";
            checkBox3.Text = "French Fries";
        }

        private void radBtnPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckBox();
            CleartxtBox();

            gbAddOns.Text = "Add-on items ($.50/each)";
            checkBox1.Text = "Pepperoni ";
            checkBox2.Text = "Sausage";
            checkBox3.Text = "Olives";
        }

        private void radBtnSalad_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckBox();
            CleartxtBox();

            gbAddOns.Text = "Add-on items ($.25/each)";
            checkBox1.Text = "Croutons ";
            checkBox2.Text = "Bacon bits";
            checkBox3.Text = "Bread sticks";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CleartxtBox();
            ClearCheckBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}