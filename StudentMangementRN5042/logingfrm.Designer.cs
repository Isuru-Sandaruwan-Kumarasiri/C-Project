namespace StudentMangementRN5042
{
    partial class loginfrm
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
            this.lglb = new System.Windows.Forms.Label();
            this.lglbpassword = new System.Windows.Forms.Label();
            this.lguname = new System.Windows.Forms.Label();
            this.lgtbuname = new System.Windows.Forms.TextBox();
            this.lgtbpassword = new System.Windows.Forms.TextBox();
            this.lgpb = new System.Windows.Forms.PictureBox();
            this.lgbulogin = new System.Windows.Forms.Button();
            this.lgbucancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lgpb)).BeginInit();
            this.SuspendLayout();
            // 
            // lglb
            // 
            this.lglb.AutoSize = true;
            this.lglb.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lglb.Location = new System.Drawing.Point(395, 155);
            this.lglb.Name = "lglb";
            this.lglb.Size = new System.Drawing.Size(203, 80);
            this.lglb.TabIndex = 0;
            this.lglb.Text = "Login";
            // 
            // lglbpassword
            // 
            this.lglbpassword.AutoSize = true;
            this.lglbpassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lglbpassword.Location = new System.Drawing.Point(241, 322);
            this.lglbpassword.Name = "lglbpassword";
            this.lglbpassword.Size = new System.Drawing.Size(130, 31);
            this.lglbpassword.TabIndex = 1;
            this.lglbpassword.Text = "Password";
            // 
            // lguname
            // 
            this.lguname.AutoSize = true;
            this.lguname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lguname.Location = new System.Drawing.Point(241, 257);
            this.lguname.Name = "lguname";
            this.lguname.Size = new System.Drawing.Size(148, 31);
            this.lguname.TabIndex = 2;
            this.lguname.Text = "User Name";
            // 
            // lgtbuname
            // 
            this.lgtbuname.Location = new System.Drawing.Point(409, 257);
            this.lgtbuname.Multiline = true;
            this.lgtbuname.Name = "lgtbuname";
            this.lgtbuname.PasswordChar = '*';
            this.lgtbuname.Size = new System.Drawing.Size(282, 35);
            this.lgtbuname.TabIndex = 3;
            this.lgtbuname.TextChanged += new System.EventHandler(this.lgtbuname_TextChanged);
            // 
            // lgtbpassword
            // 
            this.lgtbpassword.Location = new System.Drawing.Point(409, 322);
            this.lgtbpassword.Multiline = true;
            this.lgtbpassword.Name = "lgtbpassword";
            this.lgtbpassword.PasswordChar = '*';
            this.lgtbpassword.Size = new System.Drawing.Size(282, 32);
            this.lgtbpassword.TabIndex = 4;
            // 
            // lgpb
            // 
            this.lgpb.BackgroundImage = global::StudentMangementRN5042.Properties.Resources.icons8_log_in_64;
            this.lgpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lgpb.Location = new System.Drawing.Point(48, 214);
            this.lgpb.Name = "lgpb";
            this.lgpb.Size = new System.Drawing.Size(138, 158);
            this.lgpb.TabIndex = 5;
            this.lgpb.TabStop = false;
            // 
            // lgbulogin
            // 
            this.lgbulogin.Location = new System.Drawing.Point(409, 395);
            this.lgbulogin.Name = "lgbulogin";
            this.lgbulogin.Size = new System.Drawing.Size(75, 26);
            this.lgbulogin.TabIndex = 6;
            this.lgbulogin.Text = "Login";
            this.lgbulogin.UseVisualStyleBackColor = true;
            this.lgbulogin.Click += new System.EventHandler(this.lgbulogin_Click);
            // 
            // lgbucancel
            // 
            this.lgbucancel.Location = new System.Drawing.Point(535, 395);
            this.lgbucancel.Name = "lgbucancel";
            this.lgbucancel.Size = new System.Drawing.Size(75, 26);
            this.lgbucancel.TabIndex = 7;
            this.lgbucancel.Text = "Cancel";
            this.lgbucancel.UseVisualStyleBackColor = true;
            this.lgbucancel.Click += new System.EventHandler(this.lgbucancel_Click);
            // 
            // loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentMangementRN5042.Properties.Resources.avel_chuklanov_DUmFLtMeAbQ_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 531);
            this.Controls.Add(this.lgbucancel);
            this.Controls.Add(this.lgbulogin);
            this.Controls.Add(this.lgpb);
            this.Controls.Add(this.lgtbpassword);
            this.Controls.Add(this.lgtbuname);
            this.Controls.Add(this.lguname);
            this.Controls.Add(this.lglbpassword);
            this.Controls.Add(this.lglb);
            this.Name = "loginfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "logingfrm";
            this.Load += new System.EventHandler(this.loginfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lgpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lglb;
        private System.Windows.Forms.Label lglbpassword;
        private System.Windows.Forms.Label lguname;
        private System.Windows.Forms.TextBox lgtbuname;
        private System.Windows.Forms.TextBox lgtbpassword;
        private System.Windows.Forms.PictureBox lgpb;
        private System.Windows.Forms.Button lgbulogin;
        private System.Windows.Forms.Button lgbucancel;
    }
}