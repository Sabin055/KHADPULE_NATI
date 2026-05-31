namespace KHADPULE_NATI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            forgetpsw = new LinkLabel();
            btncancel = new Button();
            btnlogin = new Button();
            chkpassword = new CheckBox();
            txtpasssword = new TextBox();
            txtusername = new TextBox();
            label3 = new Label();
            username = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            loginimage = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginimage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 93);
            panel1.TabIndex = 21;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1248, 749);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Controls.Add(forgetpsw);
            panel3.Controls.Add(btncancel);
            panel3.Controls.Add(btnlogin);
            panel3.Controls.Add(chkpassword);
            panel3.Controls.Add(txtpasssword);
            panel3.Controls.Add(txtusername);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(username);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(loginimage);
            panel3.Location = new Point(12, 220);
            panel3.Name = "panel3";
            panel3.Size = new Size(1224, 483);
            panel3.TabIndex = 1;
            // 
            // forgetpsw
            // 
            forgetpsw.AutoSize = true;
            forgetpsw.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgetpsw.Location = new Point(748, 202);
            forgetpsw.Name = "forgetpsw";
            forgetpsw.Size = new Size(141, 18);
            forgetpsw.TabIndex = 6;
            forgetpsw.TabStop = true;
            forgetpsw.Text = "Forget Password ?";
            forgetpsw.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancel.Location = new Point(793, 244);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(96, 40);
            btncancel.TabIndex = 5;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(691, 244);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(96, 40);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Sign In";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // chkpassword
            // 
            chkpassword.AutoSize = true;
            chkpassword.Location = new Point(691, 169);
            chkpassword.Name = "chkpassword";
            chkpassword.Size = new Size(108, 19);
            chkpassword.TabIndex = 3;
            chkpassword.Text = "Show Password";
            chkpassword.UseVisualStyleBackColor = true;
            chkpassword.CheckedChanged += chkpassword_CheckedChanged;
            // 
            // txtpasssword
            // 
            txtpasssword.Location = new Point(689, 135);
            txtpasssword.Name = "txtpasssword";
            txtpasssword.PasswordChar = '*';
            txtpasssword.Size = new Size(200, 23);
            txtpasssword.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(690, 95);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(199, 23);
            txtusername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(568, 136);
            label3.Name = "label3";
            label3.Size = new Size(115, 22);
            label3.TabIndex = 4;
            label3.Text = "Password: ";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(568, 96);
            username.Name = "username";
            username.Size = new Size(116, 22);
            username.TabIndex = 3;
            username.Text = "Username: ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(360, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // loginimage
            // 
            loginimage.BackgroundImage = (Image)resources.GetObject("loginimage.BackgroundImage");
            loginimage.BackgroundImageLayout = ImageLayout.Stretch;
            loginimage.InitialImage = (Image)resources.GetObject("loginimage.InitialImage");
            loginimage.Location = new Point(198, 89);
            loginimage.Name = "loginimage";
            loginimage.Size = new Size(231, 195);
            loginimage.SizeMode = PictureBoxSizeMode.CenterImage;
            loginimage.TabIndex = 0;
            loginimage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 162);
            label2.Name = "label2";
            label2.Size = new Size(544, 55);
            label2.TabIndex = 0;
            label2.Text = "Welcome to Admin Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 749);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginimage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private PictureBox loginimage;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label username;
        private Label label3;
        private Button btncancel;
        private Button btnlogin;
        private CheckBox chkpassword;
        private TextBox txtpasssword;
        private TextBox txtusername;
        private LinkLabel forgetpsw;
    }
}