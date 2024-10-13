using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //back button
        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser1.GoBack();
        }

        //forward button
        private void button2_Click(object sender, EventArgs e)
        {
            WebBrowser1.GoForward();
        }

        //refresh button
        private void button3_Click(object sender, EventArgs e)
        {
            WebBrowser1.Refresh();
        }

        //search button
        private void button4_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate(textBox1.Text);
        }

        //Home button
        private void button5_Click(object sender, EventArgs e)
        {
            WebBrowser1.GoHome();
        }

        //search bar
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //web browser
        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //define variables to read textbox and store information for the operation
            string text = textBox2.Text;
            int length = text.Length;
            string temp = "";
            float a = 0;
            float b = 0;
            int n = 0;
            char operation = ' ';

            for(int i=0; i<length; i++)
            {
                //find the operation and save it
                if (text[i] == '+')
                    operation = '+';
                if (text[i] == '-')
                    operation = '-';
                if (text[i] == '/')
                    operation = '/';
                if (text[i] == '*')
                    operation = '*';

                //stores the first number
                if (text[i] == '+' || text[i] == '-' || text[i] == '/' || text[i] == '*')
                {
                    float.TryParse(temp, out a);
                    temp = "";
                    
                }
                else
                {
                    //read the number character by character and adds it to a string
                    temp = temp + text[i];
                }
            }
            
            //stores the second number
            float.TryParse(temp, out b);

            //performs operation
            float total= 1;
            if (operation == '+')
                total = a + b;
            if (operation == '-')
                total = a - b;
            if (operation == '/')
                total = a / b;
            if (operation == '*')
                total = a * b;

            label1.Text = total.ToString() ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            //create an object of EcryptService
            EncryptService.ServiceClient myClient = new EncryptService.ServiceClient();

            //encrypt and decrypt what the user enters into the textbox and display it in a box
            try{label5.Text = myClient.Encrypt(textBox3.Text);}
            catch(Exception ec){label5.Text = ec.Message.ToString(); }
            try{label7.Text = myClient.Decrypt(label5.Text);}
            catch(Exception dc){label7.Text = dc.Message.ToString();}

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
