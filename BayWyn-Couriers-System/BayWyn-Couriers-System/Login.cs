using System;
using System.Windows.Forms;

namespace BayWyn_Couriers_System
{
    public partial class frmBWCLogin : Form
    {
        public string username = string.Empty;
        public string password = string.Empty;
        public bool loginSuccess = false;

        public frmBWCLogin()
        {
            InitializeComponent();

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            username = txtUser.Text;
            password = mtxtPass.Text;
            //Test logins

            var ls = LoginStatus(username, password);

            if (!ls) 
            {
                MessageBox.Show("Invalid username or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool LoginStatus(string user, string pass) 
        {
            frmDashboard dashboard = new frmDashboard();

            if (user == "Jones81" && pass == "X5fw3Q3!yAt9")
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
                loginSuccess = true;
            }

            else if (user == "Kapoor72" && pass == "Nx392R&^f96T")
            {
                this.Hide();
                dashboard.Show();

                dashboard.btnNewCon.Enabled = true;
                dashboard.btnCreateJob.Enabled = true;
                dashboard.btnEditContract.Enabled = true;
                dashboard.btnViewContract.Enabled = true;
                dashboard.btnCancel.Enabled = true;
                dashboard.btnViewReport.Enabled = true;
                loginSuccess = true;
            }

            else if (user == "Gavin68" && pass == "Ce97bQ6$M22Y")
            {
                this.Hide();
                dashboard.Show();

                dashboard.btnCreateJob.Enabled = true;
                dashboard.btnViewContract.Enabled = true;
                dashboard.btnCancel.Enabled = true;
                dashboard.btnViewReport.Enabled = true;
                loginSuccess = true;
            }

            else if (user == "C01" && pass == "Fa79^3s2AH5T")
            {
                this.Hide();
                dashboard.Show();
                dashboard.btnAccept.Enabled = true;
                loginSuccess = true;
            }
            return loginSuccess;
        }
    }
}

