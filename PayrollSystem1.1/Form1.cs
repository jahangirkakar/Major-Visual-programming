using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void activeMenu(string active_name)
        {
            switch (active_name) {
                case "Employee":
                    lblActive_employee.Visible = true;
                    lblActive_payroll.Visible = false;
                    lblActive_report.Visible = false;
                    lblActive_user.Visible = false;
                    lblActive_home.Visible = false;
                    lblTitle.Text = "Manage Employees";
                    pnlContent.Controls.Clear(); 

                    frmEmployee  myForm = new frmEmployee ();
                    myForm.TopLevel = false;
                    //myForm.AutoScroll = true;
                    this.pnlContent.Controls.Add(myForm);
                    myForm.Show();

                    break;
                case "Payroll":
                    lblActive_employee.Visible = false;
                    lblActive_payroll.Visible = true;
                    lblActive_report.Visible = false;
                    lblActive_user.Visible = false;
                    lblActive_home.Visible = false;
                    lblTitle.Text = "Manage Payroll";
                    //picHomeLogo.Visible = false;
                    pnlContent.Controls.Clear(); 

                    frmPayroll pForm = new frmPayroll();
                    pForm.TopLevel = false;
                    pForm.AutoScroll = true;
                    this.pnlContent.Controls.Add(pForm);
                    pForm.Show();

                    break;
                case "User":
                    lblActive_employee.Visible = false;
                    lblActive_payroll.Visible = false;
                    lblActive_report.Visible = false;
                    lblActive_user.Visible = true;
                    lblActive_home.Visible = false;
                    lblTitle.Text = "Manage Users";
                    //picHomeLogo.Visible = false;
                    pnlContent.Controls.Clear(); 

                    frmUser uForm = new frmUser();
                    uForm.TopLevel = false;
                    uForm.AutoScroll = true;
                    this.pnlContent.Controls.Add(uForm);
                    uForm.Show();
                    break;
                case "Report":
                    lblActive_employee.Visible = false;
                    lblActive_payroll.Visible = false;
                    lblActive_report.Visible = true;
                    lblActive_user.Visible = false;
                    lblActive_home.Visible = false;
                    lblTitle.Text = "Generate Reports";
                    //picHomeLogo.Visible = false;
                    pnlContent.Controls.Clear(); 

                    frmReport rForm = new frmReport();
                    rForm.TopLevel = false;
                    rForm.AutoScroll = true;
                    this.pnlContent.Controls.Add(rForm);
                    rForm.Show();
                    break;
                case "Home":
                    lblActive_employee.Visible = false;
                    lblActive_payroll.Visible = false;
                    lblActive_report.Visible = false;
                    lblActive_user.Visible = false;
                    lblActive_home.Visible = true;
                    lblTitle.Text = "Home"; 
                    pnlContent.Controls.Clear();
                    //picHomeLogo.Visible = true;

                    PictureBox pic = new PictureBox();
                    pic.Image = Properties.Resources.logo;
                    pic.Dock = DockStyle.Fill;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pnlContent.Controls.Add(pic);
                    break;
            }


          
        }
        private void hoverMenu(string active_name)
        {
            switch (active_name)
            {
                case "Employee":
                    lblActive_employee.Visible = true;
                    lblActive_payroll.Visible = false;
                    lblActive_report.Visible = false;
                    lblActive_user.Visible = false;
                    lblActive_home.Visible = false; 
                    break;
                case "Payroll":
                    lblActive_employee.Visible = false;
                    lblActive_payroll.Visible = true;
                    lblActive_report.Visible = false;
                    lblActive_user.Visible = false;
                    lblActive_home.Visible = false; 

                    break;
                case "User":
                    lblActive_employee.Visible = false;
                    lblActive_payroll.Visible = false;
                    lblActive_report.Visible = false;
                    lblActive_user.Visible = true;
                    lblActive_home.Visible = false; 
                    break;
                case "Report":
                    lblActive_employee.Visible = false;
                    lblActive_payroll.Visible = false;
                    lblActive_report.Visible = true;
                    lblActive_user.Visible = false;
                    lblActive_home.Visible = false; 
                    break;
                case "Home": 
                    lblActive_home.Visible = true; 
                    break;
            }



        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            activeMenu("Employee");
        }

        private void btnPayrioll_Click(object sender, EventArgs e)
        {
            activeMenu("Payroll");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            activeMenu("User");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            activeMenu("Report");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            activeMenu("Payrool");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activeMenu("Home");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bit.ly/2LPn9Wu");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.facebook.com/Janobe-Community-2869996553072900/?modal=admin_todo_tour");
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Maroon;
        }

        private void btnEmployee_MouseHover(object sender, EventArgs e)
        {
            btnEmployee.BackColor = Color.Maroon;
        }

        private void btnPayrioll_MouseHover(object sender, EventArgs e)
        {
            btnPayrioll.BackColor = Color.Maroon;
        }

        private void btnUser_MouseHover(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.Maroon;
        }

        private void btnReports_MouseHover(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.Maroon;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Black;
        }

        private void btnEmployee_MouseLeave(object sender, EventArgs e)
        {
            btnEmployee.BackColor = Color.Black;
        }

        private void btnPayrioll_MouseLeave(object sender, EventArgs e)
        {
            btnPayrioll.BackColor = Color.Black;
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.Black;
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.Black;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
