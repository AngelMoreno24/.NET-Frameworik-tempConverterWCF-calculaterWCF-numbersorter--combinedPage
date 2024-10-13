using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            //Creates an object for the temperature conversion service
            TemperatureConversion.Service1Client TemperatureConversion = new TemperatureConversion.Service1Client();

            //Parses user input into int to convert value, converts to string again, then displays it as a string in a label
            int temp;
            int.TryParse(TextBox1.Text, out temp);
            int value = TemperatureConversion.c2f(temp);
            Label1.Text = value.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Creates an object for the temperature conversion service
            TemperatureConversion.Service1Client TemperatureConversion = new TemperatureConversion.Service1Client();

            //Parses user input into int to convert value, converts to string again, then displays it as a string in a label
            int temp;
            int.TryParse(TextBox2.Text, out temp);
            int value = TemperatureConversion.f2c(temp);
            Label2.Text = value.ToString();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Creates an object for the number sorting service
            NumberSorter.Service1Client NumberSorter = new NumberSorter.Service1Client();

            //runs sort service on user input and displays sorted string in a label
            string value = NumberSorter.sort(TextBox3.Text);
            ctl00.Text = value.ToString();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}