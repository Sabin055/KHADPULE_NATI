namespace KHADPULE_NATI
{
    partial class MemberForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            hometab = new TabControl();
            memberentrytab = new TabPage();
            txtdob = new TextBox();
            chkstatus = new CheckBox();
            txtstatus = new Label();
            membergridview = new DataGridView();
            btnview = new Button();
            cmbGender = new ComboBox();
            Fname = new Label();
            txtFullName = new TextBox();
            txtGroupName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            dtpJoinDate = new DateTimePicker();
            btnUpdate = new Button();
            dtpDOB = new DateTimePicker();
            btnSave = new Button();
            btnClear = new Button();
            Gender = new Label();
            btnDelete = new Button();
            DOB = new Label();
            Phone = new Label();
            Address = new Label();
            Joindate = new Label();
            Groupname = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            hometab.SuspendLayout();
            memberentrytab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)membergridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // hometab
            // 
            hometab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hometab.Controls.Add(memberentrytab);
            hometab.Location = new Point(0, 99);
            hometab.Name = "hometab";
            hometab.SelectedIndex = 0;
            hometab.Size = new Size(1243, 649);
            hometab.TabIndex = 0;
            // 
            // memberentrytab
            // 
            memberentrytab.Controls.Add(textBox1);
            memberentrytab.Controls.Add(txtdob);
            memberentrytab.Controls.Add(chkstatus);
            memberentrytab.Controls.Add(txtstatus);
            memberentrytab.Controls.Add(membergridview);
            memberentrytab.Controls.Add(btnview);
            memberentrytab.Controls.Add(cmbGender);
            memberentrytab.Controls.Add(Fname);
            memberentrytab.Controls.Add(txtFullName);
            memberentrytab.Controls.Add(txtGroupName);
            memberentrytab.Controls.Add(txtAddress);
            memberentrytab.Controls.Add(txtPhone);
            memberentrytab.Controls.Add(dtpJoinDate);
            memberentrytab.Controls.Add(btnUpdate);
            memberentrytab.Controls.Add(dtpDOB);
            memberentrytab.Controls.Add(btnSave);
            memberentrytab.Controls.Add(btnClear);
            memberentrytab.Controls.Add(Gender);
            memberentrytab.Controls.Add(btnDelete);
            memberentrytab.Controls.Add(DOB);
            memberentrytab.Controls.Add(Phone);
            memberentrytab.Controls.Add(Address);
            memberentrytab.Controls.Add(Joindate);
            memberentrytab.Controls.Add(Groupname);
            memberentrytab.Controls.Add(pictureBox1);
            memberentrytab.Location = new Point(4, 24);
            memberentrytab.Name = "memberentrytab";
            memberentrytab.Padding = new Padding(3);
            memberentrytab.Size = new Size(1235, 621);
            memberentrytab.TabIndex = 1;
            memberentrytab.Text = "Member Entry";
            memberentrytab.UseVisualStyleBackColor = true;
            // 
            // txtdob
            // 
            txtdob.Location = new Point(545, 110);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(200, 23);
            txtdob.TabIndex = 16;
            // 
            // chkstatus
            // 
            chkstatus.AutoSize = true;
            chkstatus.Location = new Point(545, 264);
            chkstatus.Name = "chkstatus";
            chkstatus.Size = new Size(59, 19);
            chkstatus.TabIndex = 36;
            chkstatus.Text = "Active";
            chkstatus.UseVisualStyleBackColor = true;
            // 
            // txtstatus
            // 
            txtstatus.AutoSize = true;
            txtstatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtstatus.Location = new Point(427, 260);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(55, 21);
            txtstatus.TabIndex = 35;
            txtstatus.Text = "Status";
            // 
            // membergridview
            // 
            membergridview.AllowUserToOrderColumns = true;
            membergridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            membergridview.BackgroundColor = SystemColors.ButtonFace;
            membergridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            membergridview.Dock = DockStyle.Bottom;
            membergridview.GridColor = SystemColors.InactiveCaption;
            membergridview.Location = new Point(3, 434);
            membergridview.Name = "membergridview";
            membergridview.Size = new Size(1229, 184);
            membergridview.TabIndex = 34;
            membergridview.CellContentClick += membergridview_CellContentClick;
            // 
            // btnview
            // 
            btnview.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnview.Location = new Point(425, 339);
            btnview.Name = "btnview";
            btnview.Size = new Size(94, 35);
            btnview.TabIndex = 25;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = true;
            btnview.Click += btnview_Click;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(545, 81);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(200, 23);
            cmbGender.TabIndex = 15;
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.BackColor = Color.Transparent;
            Fname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fname.Location = new Point(427, 54);
            Fname.Name = "Fname";
            Fname.Size = new Size(82, 21);
            Fname.TabIndex = 19;
            Fname.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(545, 52);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 23);
            txtFullName.TabIndex = 14;
            // 
            // txtGroupName
            // 
            txtGroupName.Location = new Point(545, 197);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(200, 23);
            txtGroupName.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(545, 168);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(545, 139);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 17;
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Location = new Point(769, 226);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(200, 23);
            dtpJoinDate.TabIndex = 38;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(509, 298);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 35);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(769, 110);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 37;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(427, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(76, 35);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(702, 298);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 35);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gender.Location = new Point(427, 83);
            Gender.Name = "Gender";
            Gender.Size = new Size(64, 21);
            Gender.TabIndex = 22;
            Gender.Text = "Gender";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(601, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 35);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // DOB
            // 
            DOB.AutoSize = true;
            DOB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DOB.Location = new Point(427, 112);
            DOB.Name = "DOB";
            DOB.Size = new Size(43, 21);
            DOB.TabIndex = 24;
            DOB.Text = "DOB";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Phone.Location = new Point(427, 141);
            Phone.Name = "Phone";
            Phone.Size = new Size(92, 21);
            Phone.TabIndex = 26;
            Phone.Text = "Mobile No.";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Address.Location = new Point(427, 170);
            Address.Name = "Address";
            Address.Size = new Size(70, 21);
            Address.TabIndex = 27;
            Address.Text = "Address";
            // 
            // Joindate
            // 
            Joindate.AutoSize = true;
            Joindate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Joindate.Location = new Point(427, 228);
            Joindate.Name = "Joindate";
            Joindate.Size = new Size(77, 21);
            Joindate.TabIndex = 31;
            Joindate.Text = "Join Date";
            // 
            // Groupname
            // 
            Groupname.AutoSize = true;
            Groupname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Groupname.Location = new Point(427, 199);
            Groupname.Name = "Groupname";
            Groupname.Size = new Size(103, 21);
            Groupname.TabIndex = 30;
            Groupname.Text = "Group Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MEMBERS_CLIIPART;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(95, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 252);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(hometab);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1248, 749);
            panel2.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 93);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 22);
            label1.Name = "label1";
            label1.Size = new Size(621, 57);
            label1.TabIndex = 18;
            label1.Text = "KHADPULE NATI SAMUHA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(545, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 20;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1248, 749);
            Controls.Add(panel1);
            Controls.Add(panel2);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += MemberForm_Load;
            hometab.ResumeLayout(false);
            memberentrytab.ResumeLayout(false);
            memberentrytab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)membergridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl hometab;
        private TabPage memberentrytab;
        private ComboBox cmbGender;
        private Label Fname;
        private TextBox txtFullName;
        private TextBox txtGroupName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private DateTimePicker dtpJoinDate;
        private Button btnUpdate;
        private DateTimePicker dtpDOB;
        private Button btnSave;
        private Button btnClear;
        private Label Gender;
        private Button btnDelete;
        private Label DOB;
        private Label Phone;
        private Label Address;
        private Label Joindate;
        private Label Groupname;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Button btnview;
        private DataGridView membergridview;
        private CheckBox chkstatus;
        private Label txtstatus;
        private TextBox txtdob;
        private TextBox textBox1;
    }
}
