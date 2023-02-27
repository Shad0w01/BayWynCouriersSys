using BayWyn_Couriers_System_Interface;
using System;
using System.Windows.Forms;

namespace BayWyn_Couriers_System
{
    public partial class frmBWCLogin : Form
    {


        public frmBWCLogin()
        {
            InitializeComponent();

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();

            //Test logins

            if (txtUser.Text == "Jones81" && mtxtPass.Text == "X5fw3Q3!yAt9")
            {
                this.Hide();
                dashboard.Show();

                dashboard.btnNewCon.Enabled = true;
                dashboard.btnCreateJob.Enabled = true;
                dashboard.btnEditContract.Enabled = true;
                dashboard.btnViewContract.Enabled = true;
                dashboard.btnSetDtd.Enabled = true;
                dashboard.btnCancel.Enabled = true;
                dashboard.btnViewReport.Enabled = true;
            }

            else if (txtUser.Text == "Kapoor72" && mtxtPass.Text == "Nx392R&^f96T")
            {
                this.Hide();
                dashboard.Show();

                dashboard.btnNewCon.Enabled = true;
                dashboard.btnCreateJob.Enabled = true;
                dashboard.btnEditContract.Enabled = true;
                dashboard.btnViewContract.Enabled = true;
                dashboard.btnCancel.Enabled = true;
                dashboard.btnViewReport.Enabled = true;

            }

            else if (txtUser.Text == "Gavin68" && mtxtPass.Text == "Ce97bQ6$M22Y")
            {
                this.Hide();
                dashboard.Show();

                dashboard.btnCreateJob.Enabled = true;
                dashboard.btnViewContract.Enabled = true;
                dashboard.btnCancel.Enabled = true;
                dashboard.btnViewReport.Enabled = true;
            }

            else if (txtUser.Text == "C01" && mtxtPass.Text == "Fa79^3s2AH5T")
            {
                this.Hide();
                dashboard.Show();
                dashboard.btnAccept.Enabled = true;
            }

            else
            {
                MessageBox.Show("Invalid username or password", "Invalid");
            }

        }
    }
}
