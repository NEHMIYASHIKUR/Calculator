using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
   
    public partial class Form1 : Form
    {
        //used to differentiate what math operation is clicked
        int counter = 0;

        //used for checking and assigning the result to another variable
        int nadd =0,nmul=0,nmin=0,ndiv=0;

        //it checks if a dot is entered more than one time for a specific number
        int dotcounter =0;  

        //stores the value of the inputted first number , second number and the final result
        double firstadd, secondadd ,resultadd=0; 
        double firstmin, secondmin, resultmin=0;
        double firstmul, secondmul, resultmul=0;
        double firstdiv, seconddiv,resultdiv=0;

        //a method executed when the "=" sign is clicked
        private void button0_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text =textBox.Text + 0.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //a method executed when the 0 sign is clicked 
        private void button_Click(object sender, EventArgs e)
        {
            dotcounter = 0;
            if (counter == 1)
            {
                secondadd = double.Parse(textBox.Text);
                resultadd = firstadd + secondadd;
                label.Text = resultadd.ToString();


            }
            else if (counter == 2) {
                secondmin = double.Parse(textBox.Text);
                resultmin = firstmin - secondmin;
                label.Text = resultmin.ToString();
                
            }
            else if (counter == 3)
            {
                seconddiv = double.Parse(textBox.Text);
                resultdiv = firstdiv / seconddiv;
                label.Text = resultdiv.ToString();
            }
            else if (counter == 4)
            {
                secondmul = double.Parse(textBox.Text);
                resultmul = firstmul * secondmul;
                label.Text = resultmul.ToString();
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            
        }

        //a method executed when the 1 sign is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text =textBox.Text + 1.ToString();
            
           
            
        }

        //a method executed when the 2 sign is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text = textBox.Text + 2.ToString();
      
        }

        //a method executed when the clear button is clicked
        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox.Text ="";
            label.Text = "";
            nadd = 0;
            nmin = 0;
            ndiv = 0;
            nmul = 0;
        }

        //a method executed when the 3 sign is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text =textBox.Text + 3.ToString();
           
        }

        //a method executed when the dot sign is clicked
        private void dotbutton_Click(object sender, EventArgs e)
        {
            dotcounter=dotcounter + 1;
            if (dotcounter == 1)
            {
                textBox.Text = textBox.Text + ".";
            }
            else {
                label.Text = "INVALID INPUT";
             //   textBox.Text = "";
                dotcounter = 0;
            }
        }

        //a method executed when the 4 sign is clicked
        private void button4_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text =textBox.Text + 4.ToString();
          
        }

        //a method executed when the 5 sign is clicked
        private void button5_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text =textBox.Text + 5.ToString();
        }

        //a method executed when the 6 sign is clicked
        private void button6_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text =textBox.Text + 6.ToString();
        }

        //a method executed when the 7 sign is clicked
        private void button7_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text =textBox.Text + 7.ToString();
        }

        //a method executed when the 8 sign is clicked
        private void button8_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text =textBox.Text + 8.ToString();
        }

        //a method executed when the division sign is clicked
        private void dividebutton_Click(object sender, EventArgs e)
        {
            dotcounter = 0;
            ndiv = ndiv + 1;
            counter = 3;
            if (ndiv >= 2)
            {
                firstdiv = resultdiv;
            }
            else {
                firstdiv = double.Parse(textBox.Text);
            } 
            textBox.Text = "%";
        }

        //a method executed when the multiplication sign is clicked
        private void multiplybutton_Click(object sender, EventArgs e)
        {
            dotcounter = 0;
            nmul = nmul + 1;
            counter = 4;
            if (nmul >= 2)
            {
                firstmul = resultmul;
            }
            else {
                firstmul = double.Parse(textBox.Text);
            }
            textBox.Text = "x";
           
        }

        //a method executed when the subtraction sign is clicked
        private void minusbutton_Click(object sender, EventArgs e)
        {
            dotcounter = 0;
            counter = 2;
            nmin = nmin + 1;
            if (nmin >= 2)
            {
                firstmin = resultmin;
            }
            else {
                firstmin = double.Parse(textBox.Text);
            }
           
            textBox.Text = "-";
        }

        //a method executed when the 9 sign is clicked
        private void button9_Click(object sender, EventArgs e)
        {
            cleartextbox();
            textBox.Text =textBox.Text + 9.ToString();
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            dotcounter = 0;
            nadd = nadd + 1;
            counter =1;
            if (nadd >= 2)
            {
                firstadd = resultadd;
            }
            else {
                firstadd = double.Parse(textBox.Text);
            }
            textBox.Text = "+";

        }
        private void cleartextbox() {
            if (textBox.Text =="+" || textBox.Text=="-" || textBox.Text=="x" || textBox.Text=="%") {
                textBox.Text="";
            }
        }
        
        
    }
}
