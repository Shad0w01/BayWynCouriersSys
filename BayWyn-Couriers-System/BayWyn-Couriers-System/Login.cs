using System;
using System.Collections.Generic;
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

            var u = user;
            var p = pass;
            var login = Couriers(u, p);

            return loginSuccess;
        }

        private bool Couriers(string u, string p)
        {

            CourierUsers users = new CourierUsers();

            List<CourierUsers> cUsers = new List<CourierUsers>() { new CourierUsers { UName = "C01", PWord = "Fa79^3s2AH5T"}, new CourierUsers { UName = "C02", PWord = "7b96CY#ykCW4"},
            new CourierUsers { UName = "C03", PWord ="wR3!3WEAcC9c"}, new CourierUsers { UName = "C04", PWord = "m3M%9K537rnQ"}, new CourierUsers { UName = "C05", PWord = "75sK$7e4BwEy"},
            new CourierUsers { UName = "C06", PWord = "3n3DU8A^CPeJ"}, new CourierUsers { UName = "C07", PWord = "6Z2y8zh!eT6V"}, new CourierUsers { UName = "C08", PWord = "aC75S65*7P%!"},
            new CourierUsers { UName = "C09", PWord = "c6H83*r5MEJh"}, new CourierUsers { UName = "C10", PWord = "Jq69J5^z3jkg"} };

            var ls = false;

            foreach (var user in cUsers)
            {

                if (u == user.UName && p == user.PWord)
                {
                    this.Hide();
                    frmDashboard dashboard = new frmDashboard();
                    dashboard.Show();
                    dashboard.btnAccept.Enabled = true;

                    ls = true;
                    loginSuccess = true;
                    break;
                }
            }
            return ls;
        }
    }
}

