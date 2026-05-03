namespace KHADPULE_NATI
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            userManagerToolStripMenuItem = new ToolStripMenuItem();
            userDetailToolStripMenuItem = new ToolStripMenuItem();
            masterToolStripMenuItem = new ToolStripMenuItem();
            memberEntryToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            memberReportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { userManagerToolStripMenuItem, masterToolStripMenuItem, reportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(972, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // userManagerToolStripMenuItem
            // 
            userManagerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userDetailToolStripMenuItem });
            userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
            userManagerToolStripMenuItem.Size = new Size(92, 20);
            userManagerToolStripMenuItem.Text = "User Manager";
            // 
            // userDetailToolStripMenuItem
            // 
            userDetailToolStripMenuItem.Name = "userDetailToolStripMenuItem";
            userDetailToolStripMenuItem.Size = new Size(130, 22);
            userDetailToolStripMenuItem.Text = "User Detail";
            // 
            // masterToolStripMenuItem
            // 
            masterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { memberEntryToolStripMenuItem });
            masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            masterToolStripMenuItem.Size = new Size(55, 20);
            masterToolStripMenuItem.Text = "Master";
            // 
            // memberEntryToolStripMenuItem
            // 
            memberEntryToolStripMenuItem.Name = "memberEntryToolStripMenuItem";
            memberEntryToolStripMenuItem.Size = new Size(180, 22);
            memberEntryToolStripMenuItem.Text = "Member Entry";
            memberEntryToolStripMenuItem.Click += memberEntryToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { memberReportToolStripMenuItem });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(54, 20);
            reportToolStripMenuItem.Text = "Report";
            // 
            // memberReportToolStripMenuItem
            // 
            memberReportToolStripMenuItem.Name = "memberReportToolStripMenuItem";
            memberReportToolStripMenuItem.Size = new Size(157, 22);
            memberReportToolStripMenuItem.Text = "Member Report";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userManagerToolStripMenuItem;
        private ToolStripMenuItem userDetailToolStripMenuItem;
        private ToolStripMenuItem masterToolStripMenuItem;
        private ToolStripMenuItem memberEntryToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem memberReportToolStripMenuItem;
    }
}