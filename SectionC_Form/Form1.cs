using System;
using SectionC_Form.Models;

namespace SectionC_Form
{
    public partial class Form1 : Form
    {
        List<Models.tblMobilePhones> mobilePhones = new List<Models.tblMobilePhones>();

        public Form1()
        {
            InitializeComponent();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtCode.Text != "" && txtMake.Text != "" && txtQuantity.Text != "")
            {
                Models.tblMobilePhones mobilePhone = new Models.tblMobilePhones
                {
                    Mobilecode = txtCode.Text,
                    Make = txtMake.Text,
                    Quantity = int.Parse(txtQuantity.Text)
                };
                mobilePhones.Add(mobilePhone);
                lblOutput.Text = "Record Added.";
            }
            else
            {
                lblOutput.Text = "Please fill in all fields.";
            };
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != "")
            {
                var mobilePhone = mobilePhones.FirstOrDefault(m => m.Mobilecode == txtCode.Text);
                if (mobilePhone != null)
                {
                    mobilePhones.Remove(mobilePhone);
                    lblOutput.Text = "Record Deleted.";
                }
                else
                {
                    lblOutput.Text = "Mobile phone not found.";
                }
            }
            else
            {
                lblOutput.Text = "Please enter a mobile code.";
            };
        }

        public void btnFind_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != "")
            {
                var mobilePhone = mobilePhones.FirstOrDefault(m => m.Mobilecode == txtCode.Text);
                if (mobilePhone != null)
                {
                    lblOutput.Text = $"Record Found.";
                }
                else
                {
                    lblOutput.Text = "Record NOT Found.";
                }
            }
            else
            {
                lblOutput.Text = "Please enter a mobile code.";
            };
        }

    }
}
