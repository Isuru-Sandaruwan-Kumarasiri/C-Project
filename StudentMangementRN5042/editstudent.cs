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
    public partial class editstudentfrm : Form
    {
        public System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public DataSet ds = new DataSet();

        public editstudentfrm()
        {
            InitializeComponent();
        }

        private void tbfname_TextChanged(object sender, EventArgs e)
        {
            tbfuname.Text = tbfname.Text + " " + tblname.Text;

        }

        private void tblname_TextChanged(object sender, EventArgs e)
        {
            tbfuname.Text = tbfname.Text + " " + tblname.Text;
        }

        private void tbhome_TextChanged(object sender, EventArgs e)
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

        private void bucancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbmobile_TextChanged(object sender, EventArgs e)
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

        private void buedit_Click(object sender, EventArgs e)
        {
            
        }

        private void buupdate_Click(object sender, EventArgs e)

               
        {
            if (tbfname.Text == "" || tblname.Text == "" || tbadress.Text == "" || tbuname.Text == "" || tbpassword.Text == "" || tbid.Text == "" || cbb.Text == "Select ID Type" || dtp.Value == DateTime.Now)
            {
                MessageBox.Show("pleace fill all filed!!!");
            }
            else if (rbumale.Checked == false && rbufemale.Checked == false)
            {
                MessageBox.Show("pleace select Gender!");
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
                cmd.CommandText = "UPDATE dtb SET firstname='" + tbfname.Text + "',lastname='" + tblname.Text + "',adress='" + tbadress.Text +
                    "',username='" + tbuname.Text + "',password='" + tbpassword.Text + "',idtype='" + cbb.Text + "',idno='" + tbid.Text +
                    "',dob='" + dtp.Value.ToShortDateString() + "',gender='" + gender + "',mobile='" + tbmobile.Text +
                    "',home='" + tbhome.Text + "',office='" + tboffice.Text + "'  WHERE idno='" + tbid.Text + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("you have been updated sucssesfully!");

                ds.Tables["dtb"].Clear();
                editstudent.Items.Clear();
                editstudent.Refresh();
                con.ConnectionString = "Data Source=LAPTOP-QEKBMBL6;Initial Catalog=studentmangementdetailsRN5042;Persist Security Info=True;User ID=sa;Password=123";
                con.Open();
                da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM dtb", con);
                da.Fill(ds, "dtb");
                con.Close();

                int currentrow = 0;
                int rowcount = ds.Tables["dtb"].Rows.Count;
                while (currentrow < rowcount)
                {
                    editstudent.Items.Add(ds.Tables["dtb"].Rows[currentrow].ItemArray[1].ToString());



                    currentrow++;
                }
            }

        }

        private void editstudentfrm_Load(object sender, EventArgs e)
        {
            if(ds.Tables["dtb"] !=null)
            {
                ds.Tables["dtb.tb"].Clear();

            }

            con.ConnectionString = "Data Source=LAPTOP-QEKBMBL6;Initial Catalog=studentmangementdetailsRN5042;Persist Security Info=True;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM dtb", con);
            da.Fill(ds, "dtb");
            con.Close();

            int currentrow = 0;
            int rowcount = ds.Tables["dtb"].Rows.Count;
            while(currentrow<rowcount)
            {
                editstudent.Items.Add(ds.Tables["dtb"].Rows[currentrow].ItemArray[1].ToString());
                
                

                currentrow++;
            }

        }

        private void editstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Tables["dtb"].Clear();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM dtb WHERE firstname='" + editstudent.SelectedItem.ToString() + "'", con);
            da.Fill(ds, "dtb");
            con.Close();

            tbfname.Text = ds.Tables["dtb"].Rows[0].ItemArray[1].ToString();
            tblname.Text = ds.Tables["dtb"].Rows[0].ItemArray[2].ToString();
            tbadress.Text = ds.Tables["dtb"].Rows[0].ItemArray[3].ToString();
            tbuname.Text = ds.Tables["dtb"].Rows[0].ItemArray[4].ToString();
            tbpassword.Text = ds.Tables["dtb"].Rows[0].ItemArray[5].ToString();
            cbb.Text = ds.Tables["dtb"].Rows[0].ItemArray[6].ToString();
            tbid.Text = ds.Tables["dtb"].Rows[0].ItemArray[7].ToString();
            dtp.Text = ds.Tables["dtb"].Rows[0].ItemArray[8].ToString();

            if (ds.Tables["dtb"].Rows[0].ItemArray[9].ToString() == "male")
            {
                rbufemale.Checked = true;
            }
            else
            {
                rbumale.Checked = true;
            }

            if (ds.Tables["dtb"].Rows[0].ItemArray[10].ToString() != "")
            {
                tbmobile.Text = ds.Tables["dtb"].Rows[0].ItemArray[10].ToString();
                cbmobile.Checked = true;
                tbmobile.Enabled = true;
            }
            else
            {
                
                cbmobile.Checked = false;
                tbmobile.Enabled = false;
            }
            if (ds.Tables["dtb"].Rows[0].ItemArray[11].ToString() != "")
            {
                tbhome.Text = ds.Tables["dtb"].Rows[0].ItemArray[11].ToString();
                cbhome.Checked = true;
                tbhome.Enabled = true;
            }
            else
            {

                cbhome.Checked = false;
                tbhome.Enabled = false;
            }
            if (ds.Tables["dtb"].Rows[0].ItemArray[12].ToString() != "")
            {
                tboffice.Text = ds.Tables["dtb"].Rows[0].ItemArray[12].ToString();
                cboffice.Checked = true;
                tboffice.Enabled = true;
            }
            else
            {

                cboffice.Checked = false;
                tboffice.Enabled = false;
            }






        }

        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editstudtbsearch_TextChanged(object sender, EventArgs e)
        {
            if (ds.Tables["dtb"] != null)
            {
                ds.Tables["dtb"].Clear();
                editstudent.Items.Clear();
                editstudent.Refresh();

            }
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM dtb WHERE firstname like '%" + editstudtbsearch.Text + "%'", con);
            da.Fill(ds, "dtb");
            con.Close();

            int currentrow = 0;
            int rowcount = ds.Tables["dtb"].Rows.Count;
            while (currentrow < rowcount)
            {
                editstudent.Items.Add(ds.Tables["dtb"].Rows[currentrow].ItemArray[1].ToString());

                currentrow++;
            }

        }
    }
}
