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
    public partial class mainfrm : Form
    {
        public mainfrm()
        {
            InitializeComponent();
        }

        private void mnuSystemlg_Click(object sender, EventArgs e)
        {
            loginfrm login = new loginfrm();
            if(login.ShowDialog()==DialogResult.OK)
            {
                mnuStud.Enabled = true;
                mnuSystemlgo.Enabled = true;
                mnuSystemlg.Enabled = false;
            }
            else
            {
                mnuStud.Enabled = false;
            }
        }

        private void mnuSystemlgo_Click(object sender, EventArgs e)
        {
            

        }

        private void mnuStudaddstud_Click(object sender, EventArgs e)
        {
            addstudfrm add = new addstudfrm();
            add.ShowDialog();
        }

        private void mnuStudremovestud_Click(object sender, EventArgs e)
        {
            removestudentfrm remove = new removestudentfrm();
            remove.ShowDialog();
        }

        private void mnuStudeditstud_Click(object sender, EventArgs e)
        {
            editstudentfrm edit = new editstudentfrm();
            edit.ShowDialog();
        }

        private void mnuSystemexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
