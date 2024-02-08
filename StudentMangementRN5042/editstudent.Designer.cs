namespace StudentMangementRN5042
{
    partial class editstudentfrm
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
            this.rbufemale = new System.Windows.Forms.RadioButton();
            this.rbumale = new System.Windows.Forms.RadioButton();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.tbmobile = new System.Windows.Forms.TextBox();
            this.tboffice = new System.Windows.Forms.TextBox();
            this.cbhome = new System.Windows.Forms.CheckBox();
            this.cbmobile = new System.Windows.Forms.CheckBox();
            this.cbb = new System.Windows.Forms.ComboBox();
            this.cboffice = new System.Windows.Forms.CheckBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbhome = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbcpassword = new System.Windows.Forms.TextBox();
            this.tbuname = new System.Windows.Forms.TextBox();
            this.tbadress = new System.Windows.Forms.TextBox();
            this.tbfuname = new System.Windows.Forms.TextBox();
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.buupdate = new System.Windows.Forms.Button();
            this.bucancel = new System.Windows.Forms.Button();
            this.lbdofb = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbcpassword = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbfuname = new System.Windows.Forms.Label();
            this.lbgender = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.lbadress = new System.Windows.Forms.Label();
            this.lbuname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editstudtbsearch = new System.Windows.Forms.TextBox();
            this.editstudent = new System.Windows.Forms.ListBox();
            this.lbfname = new System.Windows.Forms.Label();
            this.buedit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbufemale
            // 
            this.rbufemale.AutoSize = true;
            this.rbufemale.Location = new System.Drawing.Point(553, 460);
            this.rbufemale.Name = "rbufemale";
            this.rbufemale.Size = new System.Drawing.Size(75, 21);
            this.rbufemale.TabIndex = 36;
            this.rbufemale.TabStop = true;
            this.rbufemale.Text = "Female";
            this.rbufemale.UseVisualStyleBackColor = true;
            // 
            // rbumale
            // 
            this.rbumale.AutoSize = true;
            this.rbumale.Location = new System.Drawing.Point(465, 460);
            this.rbumale.Name = "rbumale";
            this.rbumale.Size = new System.Drawing.Size(59, 21);
            this.rbumale.TabIndex = 35;
            this.rbumale.TabStop = true;
            this.rbumale.Text = "Male";
            this.rbumale.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(583, 326);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(210, 22);
            this.dtp.TabIndex = 34;
            // 
            // tbmobile
            // 
            this.tbmobile.Location = new System.Drawing.Point(1015, 416);
            this.tbmobile.Name = "tbmobile";
            this.tbmobile.Size = new System.Drawing.Size(210, 22);
            this.tbmobile.TabIndex = 33;
            this.tbmobile.TextChanged += new System.EventHandler(this.tbmobile_TextChanged);
            // 
            // tboffice
            // 
            this.tboffice.Location = new System.Drawing.Point(1015, 470);
            this.tboffice.Name = "tboffice";
            this.tboffice.Size = new System.Drawing.Size(210, 22);
            this.tboffice.TabIndex = 32;
            // 
            // cbhome
            // 
            this.cbhome.AutoSize = true;
            this.cbhome.Location = new System.Drawing.Point(896, 374);
            this.cbhome.Name = "cbhome";
            this.cbhome.Size = new System.Drawing.Size(67, 21);
            this.cbhome.TabIndex = 31;
            this.cbhome.Text = "Home";
            this.cbhome.UseVisualStyleBackColor = true;
            // 
            // cbmobile
            // 
            this.cbmobile.AutoSize = true;
            this.cbmobile.Location = new System.Drawing.Point(896, 418);
            this.cbmobile.Name = "cbmobile";
            this.cbmobile.Size = new System.Drawing.Size(71, 21);
            this.cbmobile.TabIndex = 30;
            this.cbmobile.Text = "Mobile";
            this.cbmobile.UseVisualStyleBackColor = true;
            this.cbmobile.CheckedChanged += new System.EventHandler(this.cbmobile_CheckedChanged);
            // 
            // cbb
            // 
            this.cbb.FormattingEnabled = true;
            this.cbb.Location = new System.Drawing.Point(583, 259);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(210, 24);
            this.cbb.TabIndex = 29;
            this.cbb.Text = "Select ID Type";
            this.cbb.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectedIndexChanged);
            // 
            // cboffice
            // 
            this.cboffice.AutoSize = true;
            this.cboffice.Location = new System.Drawing.Point(896, 474);
            this.cboffice.Name = "cboffice";
            this.cboffice.Size = new System.Drawing.Size(67, 21);
            this.cboffice.TabIndex = 28;
            this.cboffice.Text = "Office";
            this.cboffice.UseVisualStyleBackColor = true;
            this.cboffice.CheckedChanged += new System.EventHandler(this.cboffice_CheckedChanged);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(1496, 745);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 27;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(1488, 737);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 26;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1480, 729);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 25;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1472, 721);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 24;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1464, 713);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 23;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(1015, 295);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(210, 22);
            this.tbid.TabIndex = 22;
            // 
            // tbhome
            // 
            this.tbhome.Location = new System.Drawing.Point(1015, 372);
            this.tbhome.Name = "tbhome";
            this.tbhome.Size = new System.Drawing.Size(210, 22);
            this.tbhome.TabIndex = 21;
            this.tbhome.TextChanged += new System.EventHandler(this.tbhome_TextChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(1015, 175);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(210, 22);
            this.tbpassword.TabIndex = 20;
            // 
            // tbcpassword
            // 
            this.tbcpassword.Location = new System.Drawing.Point(1015, 227);
            this.tbcpassword.Name = "tbcpassword";
            this.tbcpassword.Size = new System.Drawing.Size(210, 22);
            this.tbcpassword.TabIndex = 19;
            // 
            // tbuname
            // 
            this.tbuname.Location = new System.Drawing.Point(1015, 125);
            this.tbuname.Name = "tbuname";
            this.tbuname.Size = new System.Drawing.Size(210, 22);
            this.tbuname.TabIndex = 18;
            // 
            // tbadress
            // 
            this.tbadress.Location = new System.Drawing.Point(583, 125);
            this.tbadress.Multiline = true;
            this.tbadress.Name = "tbadress";
            this.tbadress.Size = new System.Drawing.Size(210, 86);
            this.tbadress.TabIndex = 17;
            // 
            // tbfuname
            // 
            this.tbfuname.Enabled = false;
            this.tbfuname.Location = new System.Drawing.Point(583, 70);
            this.tbfuname.Name = "tbfuname";
            this.tbfuname.Size = new System.Drawing.Size(642, 22);
            this.tbfuname.TabIndex = 16;
            // 
            // tblname
            // 
            this.tblname.Location = new System.Drawing.Point(1015, 26);
            this.tblname.Multiline = true;
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(210, 22);
            this.tblname.TabIndex = 15;
            this.tblname.TextChanged += new System.EventHandler(this.tblname_TextChanged);
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(583, 26);
            this.tbfname.Multiline = true;
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(210, 22);
            this.tbfname.TabIndex = 14;
            this.tbfname.TextChanged += new System.EventHandler(this.tbfname_TextChanged);
            // 
            // buupdate
            // 
            this.buupdate.Location = new System.Drawing.Point(886, 564);
            this.buupdate.Name = "buupdate";
            this.buupdate.Size = new System.Drawing.Size(114, 30);
            this.buupdate.TabIndex = 43;
            this.buupdate.Text = "Update";
            this.buupdate.UseVisualStyleBackColor = true;
            this.buupdate.Click += new System.EventHandler(this.buupdate_Click);
            // 
            // bucancel
            // 
            this.bucancel.Location = new System.Drawing.Point(1036, 564);
            this.bucancel.Name = "bucancel";
            this.bucancel.Size = new System.Drawing.Size(114, 30);
            this.bucancel.TabIndex = 41;
            this.bucancel.Text = "Cancel";
            this.bucancel.UseVisualStyleBackColor = true;
            this.bucancel.Click += new System.EventHandler(this.bucancel_Click);
            // 
            // lbdofb
            // 
            this.lbdofb.AutoSize = true;
            this.lbdofb.Location = new System.Drawing.Point(462, 326);
            this.lbdofb.Name = "lbdofb";
            this.lbdofb.Size = new System.Drawing.Size(87, 17);
            this.lbdofb.TabIndex = 13;
            this.lbdofb.Text = "Date of Birth";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(894, 175);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(69, 17);
            this.lbpassword.TabIndex = 12;
            this.lbpassword.Text = "Password";
            // 
            // lbcpassword
            // 
            this.lbcpassword.AutoSize = true;
            this.lbcpassword.Location = new System.Drawing.Point(894, 227);
            this.lbcpassword.Name = "lbcpassword";
            this.lbcpassword.Size = new System.Drawing.Size(121, 17);
            this.lbcpassword.TabIndex = 11;
            this.lbcpassword.Text = "Confirm Password";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(913, 24);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(76, 17);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "Last Name";
            // 
            // lbfuname
            // 
            this.lbfuname.AutoSize = true;
            this.lbfuname.Location = new System.Drawing.Point(462, 70);
            this.lbfuname.Name = "lbfuname";
            this.lbfuname.Size = new System.Drawing.Size(71, 17);
            this.lbfuname.TabIndex = 9;
            this.lbfuname.Text = "Full Name";
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Location = new System.Drawing.Point(462, 393);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(56, 17);
            this.lbgender.TabIndex = 4;
            this.lbgender.Text = "Gender";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(894, 295);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(75, 17);
            this.lbid.TabIndex = 3;
            this.lbid.Text = "ID Number";
            // 
            // lbadress
            // 
            this.lbadress.AutoSize = true;
            this.lbadress.Location = new System.Drawing.Point(462, 125);
            this.lbadress.Name = "lbadress";
            this.lbadress.Size = new System.Drawing.Size(52, 17);
            this.lbadress.TabIndex = 2;
            this.lbadress.Text = "Adress";
            // 
            // lbuname
            // 
            this.lbuname.AutoSize = true;
            this.lbuname.Location = new System.Drawing.Point(894, 125);
            this.lbuname.Name = "lbuname";
            this.lbuname.Size = new System.Drawing.Size(79, 17);
            this.lbuname.TabIndex = 1;
            this.lbuname.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editstudtbsearch);
            this.panel1.Controls.Add(this.editstudent);
            this.panel1.Controls.Add(this.rbufemale);
            this.panel1.Controls.Add(this.rbumale);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.tbmobile);
            this.panel1.Controls.Add(this.tboffice);
            this.panel1.Controls.Add(this.cbhome);
            this.panel1.Controls.Add(this.cbmobile);
            this.panel1.Controls.Add(this.cbb);
            this.panel1.Controls.Add(this.cboffice);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.tbhome);
            this.panel1.Controls.Add(this.tbpassword);
            this.panel1.Controls.Add(this.tbcpassword);
            this.panel1.Controls.Add(this.tbuname);
            this.panel1.Controls.Add(this.tbadress);
            this.panel1.Controls.Add(this.tbfuname);
            this.panel1.Controls.Add(this.tblname);
            this.panel1.Controls.Add(this.tbfname);
            this.panel1.Controls.Add(this.lbdofb);
            this.panel1.Controls.Add(this.lbpassword);
            this.panel1.Controls.Add(this.lbcpassword);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lbfuname);
            this.panel1.Controls.Add(this.lbgender);
            this.panel1.Controls.Add(this.lbid);
            this.panel1.Controls.Add(this.lbadress);
            this.panel1.Controls.Add(this.lbuname);
            this.panel1.Controls.Add(this.lbfname);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 532);
            this.panel1.TabIndex = 40;
            // 
            // editstudtbsearch
            // 
            this.editstudtbsearch.Location = new System.Drawing.Point(30, 26);
            this.editstudtbsearch.Name = "editstudtbsearch";
            this.editstudtbsearch.Size = new System.Drawing.Size(265, 22);
            this.editstudtbsearch.TabIndex = 38;
            this.editstudtbsearch.TextChanged += new System.EventHandler(this.editstudtbsearch_TextChanged);
            // 
            // editstudent
            // 
            this.editstudent.FormattingEnabled = true;
            this.editstudent.ItemHeight = 16;
            this.editstudent.Location = new System.Drawing.Point(30, 72);
            this.editstudent.Name = "editstudent";
            this.editstudent.Size = new System.Drawing.Size(265, 436);
            this.editstudent.TabIndex = 37;
            this.editstudent.SelectedIndexChanged += new System.EventHandler(this.editstudent_SelectedIndexChanged);
            // 
            // lbfname
            // 
            this.lbfname.AutoSize = true;
            this.lbfname.Location = new System.Drawing.Point(462, 26);
            this.lbfname.Name = "lbfname";
            this.lbfname.Size = new System.Drawing.Size(80, 17);
            this.lbfname.TabIndex = 0;
            this.lbfname.Text = "First  Name";
            // 
            // buedit
            // 
            this.buedit.Location = new System.Drawing.Point(722, 564);
            this.buedit.Name = "buedit";
            this.buedit.Size = new System.Drawing.Size(114, 30);
            this.buedit.TabIndex = 42;
            this.buedit.Text = "Edit";
            this.buedit.UseVisualStyleBackColor = true;
            this.buedit.Click += new System.EventHandler(this.buedit_Click);
            // 
            // editstudentfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 607);
            this.Controls.Add(this.buupdate);
            this.Controls.Add(this.bucancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buedit);
            this.Name = "editstudentfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit student";
            this.Load += new System.EventHandler(this.editstudentfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbufemale;
        private System.Windows.Forms.RadioButton rbumale;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox tbmobile;
        private System.Windows.Forms.TextBox tboffice;
        private System.Windows.Forms.CheckBox cbhome;
        private System.Windows.Forms.CheckBox cbmobile;
        private System.Windows.Forms.ComboBox cbb;
        private System.Windows.Forms.CheckBox cboffice;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbhome;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbcpassword;
        private System.Windows.Forms.TextBox tbuname;
        private System.Windows.Forms.TextBox tbadress;
        private System.Windows.Forms.TextBox tbfuname;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.Button buupdate;
        private System.Windows.Forms.Button bucancel;
        private System.Windows.Forms.Label lbdofb;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbcpassword;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbfuname;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbadress;
        private System.Windows.Forms.Label lbuname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox editstudtbsearch;
        private System.Windows.Forms.ListBox editstudent;
        private System.Windows.Forms.Label lbfname;
        private System.Windows.Forms.Button buedit;
    }
}