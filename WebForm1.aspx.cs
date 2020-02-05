using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1_ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        enum days
        {
            Sun, Mon, Tue, Wed
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TextBox1.Text))
                {
                    double temp = Convert.ToDouble(TextBox1.Text);

                    Label1.Text = Temperature(temp);
                }
            }

            // exception, not considered error
            catch (Exception ex)
            {

                Label1.Text = ex.Message;
            }

            //finally will always run
            //example server closing, can throw if someone enters malicious code
            finally 
            {

            }
           




        }

        private string Greeting (string name)
        {
            return name + "How are you?";
        }

        private string Temperature(double Fahrenheit)
        {
            
                //convert from int to fahrenheit, subtract 32 multiply by 5/9
                double Celsius = (Fahrenheit - 32) * 5 / 9d;
                Label2.Text = (Math.Round(Celsius, 2)).ToString() + "° Celsius";

                string result;
                if (Celsius <= 0)
                    result = "Winter";

                else if (Celsius > 0 && Celsius < 15)
                    result = "Spring";

                else if (Celsius > 15)
                    result = "Summer";

                else result = "Enter valid temperature in Fahrenheit!";
                return result;

        }


    }
}