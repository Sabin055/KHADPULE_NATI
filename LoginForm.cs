using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace KHADPULE_NATI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=KHADPULE_NS;Integrated Security=True");

        public void logininputclear()
        {
            txtusername.Text = "";
            txtpasssword.Text = "";
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from users where Username = '" + txtusername.Text + "' and PasswordHash = '" + txtpasssword.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Enter the Valid UserName and Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpassword.Checked)
            {
                txtpasssword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpasssword.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sorry Resetting password is Invalid, Please contact developer!!");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            logininputclear();
            Application.Exit();
        }
    }
}
