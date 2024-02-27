using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClearControls()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";

            ddlTicketType.SelectedIndex = -1;

            rblDaysAttending.ClearSelection();

            foreach (ListItem item in cblPerformances.Items)
            {
                item.Selected = false;
            }

            proofOfPayment = new FileUpload();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (proofOfPayment.HasFile)
            {
                try
                {
                    string fileExtension = System.IO.Path.GetExtension(proofOfPayment.FileName).ToLower();
                    if (fileExtension == ".jpg" || fileExtension == ".png")
                    {
                        string saveDirectory = @"D:\Pictures";

                        string savePath = System.IO.Path.Combine(saveDirectory, proofOfPayment.FileName);

                        proofOfPayment.SaveAs(savePath);

                    }
                    else
                    {
                        sb.Append("Only JPG and PNG files are allowed.");
                    }
                }
                catch (Exception ex)
                {
                    sb.AppendFormat("Unable to save file <br/> {0}", ex.Message);
                }
            }
            else
            {
                lblMessage.Text = "No file selected.";
            }

            ClearControls();

            lblMessage.Text = sb.ToString();

        }
    }
}