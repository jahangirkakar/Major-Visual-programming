using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystem1._1.includes;

namespace PayrollSystem1._1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
        SQLConfig config = new SQLConfig();
        string sql;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_username.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from user WHERE username = '" + txt_username.Text + "' and Pass = sha('" + txt_password.Text + "')";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                
                //this.Close();
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Accounts does not exist! please contact administrator", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
