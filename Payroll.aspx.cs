using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1_ASP
{
    public partial class Payroll : System.Web.UI.Page
    {
        //dependents, gender, CPP, EI
        //income tax
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //first load
            {
                
            }


        }

        public double CalculateNet(double gross)
        {
            double net = gross;
            double income1 = 0.0505;
            double income2 = 0.0915;
            double income3 = 0.116;
            double income4 = 0.1216;
            double income5 = 0.1316;

            //first figure out tax bracket,
            if (gross <= 42960) //5.05% tax
                net = IncomeTax(income1,gross);
            if (gross > 42960 && gross <= 85923) //9.15% tax 
                net = IncomeTax(income2, gross);
            if (gross > 85923 && gross <= 150000) //11.16% tax 
               net = IncomeTax(income3,gross);
            if (gross >150000  && gross <= 220000) //12.16% tax
                net = IncomeTax(income4,gross);
            if (gross > 220000) //13.16% tax
                net = IncomeTax(income5,gross);




            return net;
        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            NetPay.Text =   "$" + CalculateNet(Convert.ToDouble(grossSalary.Text)).ToString();
        }

        protected double IncomeTax(double tax, double gross) //send in gross, with specified income tax
        {
            // then gender, then dependants, then cpp and ei
            if (RadioButton1.Checked)
                tax -= 0.02; //decrease by 2%

            if (ddlDependants.SelectedIndex == 2) //3 dependents means 2% less income tax
                tax -= 0.02;
            if (ddlDependants.SelectedIndex == 3) // 4 depenants means 4% less income tax
                tax -= 0.04;

            if (cbxCPP.Checked)
            {
                gross = (gross * 0.949);
            }

            if (cbxEI.Checked)
            {
                gross = (gross * 0.9842);
            }

            if (cbxCPP.Checked && cbxEI.Checked)
            {
                gross = gross * 0.9332;
            }

            if (cbxBonus.Checked)
                gross += 150;
            if (cbxAllowance.Checked)
                gross += 200;

            double net = gross * (1.0 - tax);

            return net;


            
        }

    }
}