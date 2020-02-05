using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Project1_ASP
{
    public partial class ClassesWork : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //instantiate a class 

        protected void Button1_Click(object sender, EventArgs e)
        {
            Classes.ClassA obj = new Classes.ClassA();
            Label1.Text = obj.Sum(10, 5).ToString();

           Classes.ClassC objt = new Classes.ClassC();


            //multi layer, call classes seperately
            //sealed class cannot be inherited
            //abstract class cannot be instantiated

            ArrayList arrList = new ArrayList();
            //hash table gives key value pair

            Hashtable hts = new Hashtable();
            hts.Add(1, "AB");
            hts.Add(2, "CD");
            hts.Add(3, "CG");

            foreach (var val in hts.Values)
                val.ToString();

            

        }
    }
}