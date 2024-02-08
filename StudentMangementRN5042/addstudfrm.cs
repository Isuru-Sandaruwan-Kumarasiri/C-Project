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
    public partial class addstudfrm : Form
    {
        public System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public DataSet ds = new DataSet();
        public addstudfrm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbfname_Click(object sender, EventArgs e)
        {

        }

        private void lbuname_Click(object sender, EventArgs e)
        {

        }

        private void lbadress_Click(object sender, EventArgs e)
        {

        }

        private void lbid_Click(object sender, EventArgs e)
        {

        }

        private void lbgender_Click(object sender, EventArgs e)
        {

        }

        private void lbfuname_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lbcpassword_Click(object sender, EventArgs e)
        {

        }

        private void lbpassword_Click(object sender, EventArgs e)
        {

        }

        private void lbdofb_Click(object sender, EventArgs e)
        {

        }

        private void tbfname_TextChanged(object sender, EventArgs e)
        {
            tbfuname.Text = tbfname.Text + "" + tblname.Text;
            busave.Enabled = true;
            buclear.Enabled = true;
        }

        private void tblname_TextChanged(object sender, EventArgs e)
        {
            tbfuname.Text = tbfname.Text + " " + tblname.Text;
        }

        private void tbfuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbadress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbcpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbhome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboffice_CheckedChanged(object sender, EventArgs e)
        {
            if (cboffice.Checked == true)
            {
                tboffice.Enabled = true;
            }
            else
            {
                tboffice.Enabled = false;
                tboffice.Clear();
            }
        }

        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmobile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmobile.Checked == true)
            {
                tbmobile.Enabled = true;
            }
            else
            {
                tbmobile.Enabled = false;
                tbmobile.Clear();
            }
        }

        private void cbhome_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhome.Checked == true)
            {
                tbhome.Enabled = true;
            }
            else
            {
                tbhome.Enabled = false;
                tbhome.Clear();
            }
        }

        private void tboffice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbumale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbufemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buadd_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void busave_Click(object sender, EventArgs e)
        {
            if (tbfname.Text == "" || tblname.Text == "" || tbadress.Text == "" || tbuname.Text == "" || tbpassword.Text == "" || tbid.Text == "" || cbbid.Text == "Select ID Type" || dtp.Value == DateTime.Now)
            {
                MessageBox.Show("pleace fill all filed!!!");
            }
            else if (rbumale.Checked == false && rbufemale.Checked == false)
            {
                MessageBox.Show("pleace select Gender!");
            }
            else if (tbpassword.Text != tbcpassword.Text)
            {
                MessageBox.Show("pleace type confirm password correctly!");
            }
            else
            {
                string gender = "";
                if (rbufemale.Checked == true)
                {
                    gender = "female";
                }
                else
                {
                    gender = "male";
                }

                con.ConnectionString = "Data Source=LAPTOP-QEKBMBL6;Initial Catalog=studentmangementdetailsRN5042;Persist Security Info=True;User ID=sa;Password=123";
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO dtb VALUES('" + tbfname.Text + "','" + tblname.Text + "','" + tbadress.Text + "','" + tbuname.Text +
                    "','" + tbpassword.Text + "','" + cbbid.Text + "','" + tbid.Text + "','" + dtp.Value.ToShortDateString() +
                    "','" + gender + "','" + tbmobile.Text + "','" + tbhome.Text + "','" + tboffice.Text + "')";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been saved sucssfully");
                tbfname.Clear();
                tblname.Clear();
                tbadress.Clear();
                tbuname.Clear();
                tbpassword.Clear();
                tbcpassword.Clear();
                cbbid.Text = "Select ID Type";
                tbid.Clear();
                rbufemale.Checked = false;
                rbumale.Checked = false;
                cbhome.Checked = false;
                cboffice.Checked = false;
                cbmobile.Checked = false;
                panel1.Enabled = true;
                buclear.Enabled = false;
                busave.Enabled = false;
            }
        }

        private void bucancel_Click(object sender, EventArgs e)
        {
            tbfname.Clear();
            tblname.Clear();
            tbadress.Clear();
            tbuname.Clear();
            tbpassword.Clear();
            tbcpassword.Clear();
            cbbid.Text = "Select ID Type";
            tbid.Clear();
            dtp.Value = DateTime.Now;
            rbufemale.Checked = false;
            rbumale.Checked = false;
            cbhome.Checked = false;
            cboffice.Checked = false;
            cbmobile.Checked = false;
            panel1.Enabled = true;
            tbmobile.Clear();
            tboffice.Clear();
            tbhome.Clear();
            buclear.Enabled = false;
            busave.Enabled = false;
        }
    
        private void addstudfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
