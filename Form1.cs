using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator // so u are uploaded to github now aqt 14/08/2020, 00.01
{
    public partial class Calculator : Form // and this is second comment and also amazing and wow
    {
        Double resultVlaue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

                    private void Form1_Load(object sender, EventArgs e)
                    {

                        }

                    private void label1_Click(object sender, EventArgs e)
                    {

                    }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

            }


        private void buttonCE_Click(object sender, EventArgs e)
        {

            textBoxResult.Text = "0";
            resultVlaue = 0;
            label1.Text = "0";


            }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultVlaue = 0;
            label1.Text = "0";
            }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
           

            switch(operationPerformed ){

                case "+":

                    textBoxResult.Text = (resultVlaue + Double.Parse(textBoxResult.Text)).ToString();
                   
                    break;

                case "-":

                    textBoxResult.Text = (resultVlaue - Double.Parse(textBoxResult.Text)).ToString();
                   
                    break;

                case "×":

                    textBoxResult.Text = (resultVlaue * Double.Parse(textBoxResult.Text)).ToString();
                    
                    break;

                case "÷":
                   
                    textBoxResult.Text = (resultVlaue / Double.Parse(textBoxResult.Text)).ToString();
                   
                    break;

                default:
                    

                    break;
                    
        }
           // label1.Text = textBoxResult.Text;
            }


        private void button_Click(object sender, EventArgs e) //sender is a object name of this method
        {
            Button button = (Button)sender; // create button object and cast sender object to it, so sender object parameter could have new value
            isOperationPerformed = false;
            if (textBoxResult.Text == "0") {  //usuallt text box default value is "0"

                textBoxResult.Clear();//clear all text is textbox using .Clear() function
                }

            if (button.Text = ".") { 
                if(textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + button.Text; //text of buttons added to textbox 
                label1.Text = textBoxResult.Text;
            } else {
                textBoxResult.Text = textBoxResult.Text + button.Text; //text of buttons added to textbox 
                
                label1.Text = textBoxResult.Text;
          
            }; //using contains() method 

            
                //Application.Exit();
            
        }


        private void operatorClick(object sender, EventArgs e) //C# is Object Oriented PRG. 
        {

            Button button = (Button)sender; //sender object cast into a button variable 
            isOperationPerformed = true;
            operationPerformed = button.Text; //button text of operator"s" assigned to 
           
            resultVlaue = Double.Parse(textBoxResult.Text); //string value of button into double value
            label1.Text = (resultVlaue.ToString() + button.Text);
            //label1.Text = resultVlaue.ToString();
            textBoxResult.Clear(); // this will clear numbers in the text box after pressing operator so seems clear performing operation
           
        }

       

    }
}
