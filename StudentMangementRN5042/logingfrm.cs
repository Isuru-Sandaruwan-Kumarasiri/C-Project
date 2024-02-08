using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMangementRN5042
{
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        private void lgbucancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lgbulogin_Click(object sender, EventArgs e)
        {
            if (lgtbuname.Text == "isuru" && lgtbpassword.Text == "0528")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid User name /Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
              
            
            
            
        }

        private void loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void lgtbuname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
