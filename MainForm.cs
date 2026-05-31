using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHADPULE_NATI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void memberEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm WF = new MemberForm();
            WF.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //LoginForm lf = new LoginForm();
            //lf.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
