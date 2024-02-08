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
    public partial class removestudentfrm : Form
    {
        public System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public DataSet ds = new DataSet();
        public removestudentfrm()
        {
            InitializeComponent();
        }

        private void removestudentfrm_Load(object sender, EventArgs e)
        {
            if (ds.Tables["dtb"] != null)
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
            while (currentrow < rowcount)
            {
                editstudent.Items.Add(ds.Tables["dtb"].Rows[currentrow].ItemArray[1].ToString());



                currentrow++;
            }
        }

        private void tbfname_TextChanged(object sender, EventArgs e)
        {
            tbfuname.Text = tbfname.Text + "" + tblname.Text;
        }

        private void tblname_TextChanged(object sender, EventArgs e)
        {
            tbfuname.Text = tbfname.Text + "" + tblname.Text;
        }

        private void buclose_Click(object sender, EventArgs e)
        {
            Close();
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
            cbbid.Text = ds.Tables["dtb"].Rows[0].ItemArray[6].ToString();
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

        private void buremove_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-QEKBMBL6;Initial Catalog=studentmangementdetailsRN5042;Persist Security Info=True;User ID=sa;Password=123";
            cmd.Connection = con;
            con.Open();
            cmd=new System.Data.SqlClient.SqlCommand("DELETE FROM dtb WHERE idno='"+tbid.Text+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("you have been delected sucssesfully");

            editstudent.Items.Clear();
            editstudent.Refresh();

            if (ds.Tables["dtb"] != null)
            {
                ds.Tables["dtb"].Clear();

            }

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
            

        }

        private void tbremove_TextChanged(object sender, EventArgs e)
        {
            if (ds.Tables["dtb"] != null)
            {
                ds.Tables["dtb"].Clear();
                editstudent.Items.Clear();
                editstudent.Refresh();

            }
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM dtb WHERE firstname like '%" + tbremove.Text + "%'", con);
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
