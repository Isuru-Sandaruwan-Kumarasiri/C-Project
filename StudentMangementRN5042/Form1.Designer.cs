namespace StudentMangementRN5042
{
    partial class mainfrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystemlg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystemlgo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystemexit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStud = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudaddstud = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudremovestud = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudeditstud = new System.Windows.Forms.ToolStripMenuItem();
            this.maintheam = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuStud});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystemlg,
            this.mnuSystemlgo,
            this.mnuSystemexit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(68, 24);
            this.mnuSystem.Text = "System";
            // 
            // mnuSystemlg
            // 
            this.mnuSystemlg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuSystemlg.Image = global::StudentMangementRN5042.Properties.Resources.icons8_user_50;
            this.mnuSystemlg.Name = "mnuSystemlg";
            this.mnuSystemlg.Size = new System.Drawing.Size(131, 26);
            this.mnuSystemlg.Text = "Login";
            this.mnuSystemlg.Click += new System.EventHandler(this.mnuSystemlg_Click);
            // 
            // mnuSystemlgo
            // 
            this.mnuSystemlgo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuSystemlgo.Enabled = false;
            this.mnuSystemlgo.Name = "mnuSystemlgo";
            this.mnuSystemlgo.Size = new System.Drawing.Size(131, 26);
            this.mnuSystemlgo.Text = "Logout";
            this.mnuSystemlgo.Click += new System.EventHandler(this.mnuSystemlgo_Click);
            // 
            // mnuSystemexit
            // 
            this.mnuSystemexit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuSystemexit.Name = "mnuSystemexit";
            this.mnuSystemexit.Size = new System.Drawing.Size(131, 26);
            this.mnuSystemexit.Text = "Exit";
            this.mnuSystemexit.Click += new System.EventHandler(this.mnuSystemexit_Click);
            // 
            // mnuStud
            // 
            this.mnuStud.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuStud.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudaddstud,
            this.mnuStudremovestud,
            this.mnuStudeditstud});
            this.mnuStud.Enabled = false;
            this.mnuStud.Name = "mnuStud";
            this.mnuStud.Size = new System.Drawing.Size(122, 24);
            this.mnuStud.Text = "Student Details";
            // 
            // mnuStudaddstud
            // 
            this.mnuStudaddstud.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuStudaddstud.Name = "mnuStudaddstud";
            this.mnuStudaddstud.Size = new System.Drawing.Size(193, 26);
            this.mnuStudaddstud.Text = "Add Student";
            this.mnuStudaddstud.Click += new System.EventHandler(this.mnuStudaddstud_Click);
            // 
            // mnuStudremovestud
            // 
            this.mnuStudremovestud.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuStudremovestud.Name = "mnuStudremovestud";
            this.mnuStudremovestud.Size = new System.Drawing.Size(193, 26);
            this.mnuStudremovestud.Text = "Remove Student";
            this.mnuStudremovestud.Click += new System.EventHandler(this.mnuStudremovestud_Click);
            // 
            // mnuStudeditstud
            // 
            this.mnuStudeditstud.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuStudeditstud.Name = "mnuStudeditstud";
            this.mnuStudeditstud.Size = new System.Drawing.Size(193, 26);
            this.mnuStudeditstud.Text = "Edit Student";
            this.mnuStudeditstud.Click += new System.EventHandler(this.mnuStudeditstud_Click);
            // 
            // maintheam
            // 
            this.maintheam.AutoSize = true;
            this.maintheam.BackColor = System.Drawing.Color.SpringGreen;
            this.maintheam.Font = new System.Drawing.Font("Mongolian Baiti", 100.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintheam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maintheam.Location = new System.Drawing.Point(250, 430);
            this.maintheam.Name = "maintheam";
            this.maintheam.Size = new System.Drawing.Size(1462, 180);
            this.maintheam.TabIndex = 1;
            this.maintheam.Text = "Esoft Metro Campus";
            this.maintheam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentMangementRN5042.Properties.Resources.shiromani_kant_mo3FOTG62ao_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 669);
            this.Controls.Add(this.maintheam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainfrm";
            this.Text = "Student Mangemant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainfrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuSystemlg;
        private System.Windows.Forms.ToolStripMenuItem mnuSystemlgo;
        private System.Windows.Forms.ToolStripMenuItem mnuSystemexit;
        private System.Windows.Forms.ToolStripMenuItem mnuStud;
        private System.Windows.Forms.ToolStripMenuItem mnuStudaddstud;
        private System.Windows.Forms.ToolStripMenuItem mnuStudremovestud;
        private System.Windows.Forms.ToolStripMenuItem mnuStudeditstud;
        private System.Windows.Forms.Label maintheam;
    }
}

