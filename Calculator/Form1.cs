using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string no1, constfun;
        // public int no2;
        public bool inputstatus;
        public Form1()
        {
            InitializeComponent();
            no1 = "";
            textBox1.ReadOnly = true; 
            textBox1.RightToLeft = RightToLeft.Yes;
        }
        private void Numbutton_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
                inputstatus = true;
            }
        }
        private void operator_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = (sender as Button).Text;
            

        }
        private void funcal()
        {
            switch (constfun)
            {
                case "+":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) + Convert.ToInt32(textBox1.Text)); //ading values of textbox
                    
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) - Convert.ToInt32(textBox1.Text));

                    break;
                case "x":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) * Convert.ToInt32(textBox1.Text));
                    break;
                case "/":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "infinity";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToInt32(no1) / Convert.ToInt32(textBox1.Text));
                    }
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            funcal(); //calling of function
            
            inputstatus = false;
        }
        private void button_mousein(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.LawnGreen;
            (sender as Button).ForeColor = Color.Black;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
            {
                textBox1.Text = "";
            }
                
            else
            {
                textBox1.Text = (no1.Substring(0, n - 1));
            }
                
        }

        private void button17_Click(object sender, EventArgs e)
        {

            textBox1.Text = String.Empty;
            inputstatus = true;
            
        }

        private void button_mouseout(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Black;
            (sender as Button).ForeColor = Color.LawnGreen;
        }
    }
}
