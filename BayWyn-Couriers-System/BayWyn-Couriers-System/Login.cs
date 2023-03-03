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

            string[] cUser = { "C01", "C02", "C03", "C04", "C05", "C06", "C07", "C08", "C09", "C10" };
            string[] cPass = { cUser[0] = "Fa79^3s2AH5T", cUser[1] = "7b96CY#ykCW4", cUser[2] = "wR3!3WEAcC9c", cUser[3] = "m3M%9K537rnQ", cUser[4] = "75sK$7e4BwEy", cUser[5] = "3n3DU8A^CPeJ", cUser[6] = "6Z2y8zh!eT6V", cUser[7] = "aC75S65*7P%!", cUser[8] = "c6H83*r5MEJh", cUser[9] = "Jq69J5^z3jkg" };

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


            else if (user == cUser.ToString() && pass == cPass.ToString())
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

