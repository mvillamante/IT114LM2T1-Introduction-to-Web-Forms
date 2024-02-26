using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO 3.3 Set the text value of the finalGrade label to "Submit your grade percentage to see your final grade!". Watch out for post backs
            if (!IsPostBack)
            {
                finalGrade.Text = "Submit your grade percentage to see your final grade!";
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double percentage = 0;
            double equiGrade = 0;
            if (double.TryParse(percentageGrade.Text, out percentage))
            {
                if (percentage > 96)
                {
                    equiGrade = 1.00;
                }
                else if (percentage >= 91.51 && percentage <= 96.00)
                {
                    equiGrade = 1.25;
                }
                else if (percentage >= 87.01 && percentage <= 91.50)
                {
                    equiGrade = 1.50;
                }
                else if (percentage >= 82.51 && percentage <= 87.00)
                {
                    equiGrade = 1.75;
                }
                else if (percentage >= 78.01 && percentage <= 82.50)
                {
                    equiGrade = 2.00;
                }
                else if (percentage >= 73.51 && percentage <= 78.00)
                {
                    equiGrade = 2.25;
                }
                else if (percentage >= 69.01 && percentage <= 73.50)
                {
                    equiGrade = 2.50;
                }
                else if (percentage >= 64.51 && percentage <= 69.00)
                {
                    equiGrade = 2.75;
                }
                else if (percentage >= 60.00 && percentage <= 64.50)
                {
                    equiGrade = 3.00;
                }
                else if (percentage < 60.00)
                {
                    equiGrade = 5.00;
                }
                else
                {
                    finalGrade.Text = "Invalid input. Please enter a valid percentage value.";
                }
                finalGrade.Text = equiGrade.ToString();
                }
                
                if (equiGrade == 1.00)
                {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CongratulationsAlert", "displayCongratulations();", true); 
                }
                
            }

        }
}
