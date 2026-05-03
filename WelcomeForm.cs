using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace KHADPULE_NATI
{
    public partial class MemberForm : Form
    {
        public void dataload()
        {
            string Sql = "select * from members";
            membergridview.DataSource = DbConnection.GetTableByQuery(Sql);
        }

        public void memberinputclear()
        {
            txtFullName.Text = "";
            cmbGender.Text = "";
            txtdob.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtGroupName.Text = "";
            Joindate.Text = "";
            txtstatus.Text = "";
        }
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void memberEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void membergridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get
            String fname = membergridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            String gender = membergridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            String dob = membergridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            String mob = membergridview.Rows[e.RowIndex].Cells[3].Value.ToString();
            String address = membergridview.Rows[e.RowIndex].Cells[4].Value.ToString();
            String group = membergridview.Rows[e.RowIndex].Cells[5].Value.ToString();
            String joindate = membergridview.Rows[e.RowIndex].Cells[6].Value.ToString();
            String status = membergridview.Rows[e.RowIndex].Cells[7].Value.ToString();
            //set
            txtFullName.Text = fname;
            cmbGender.Text = gender;
            txtdob.Text = dob;
            txtPhone.Text = mob;
            txtAddress.Text = address;
            txtGroupName.Text = group;
            Joindate.Text = joindate;
            txtstatus.Text = status;
            btnSave.Enabled = false;
            btnview.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int isActive = chkstatus.Checked ? 1:0;
            String Sql = "Insert into members(FullName, Gender, DOB, PhoneNumber, Address, JoinDate, GroupName, Status) " +
                "values('" + txtFullName.Text + "', '" + cmbGender.Text + "', '" + txtdob.Text + "', '" + txtPhone.Text + "', '" + txtAddress.Text + "', '" + Joindate.Text + "', '" + txtGroupName.Text + "','"+ isActive + "')".ToString();
            membergridview.DataSource = DbConnection.GetTableByQuery(Sql);
            MessageBox.Show("Data Saved Successfully");
            memberinputclear();
            dataload();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            dataload();
        }
    }
}
