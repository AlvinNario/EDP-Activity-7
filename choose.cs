using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do_List
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            var loginForm = new login();
            loginForm.Show();
            this.Hide();
        }

        private void stud_techbtn_Click(object sender, EventArgs e)
        {     
            var indexForm = new index();
            indexForm.Show();
            this.Hide();
        }
    }
}
