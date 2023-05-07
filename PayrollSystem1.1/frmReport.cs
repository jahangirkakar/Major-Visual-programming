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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        string sql;

       
        private void reports(string sql, string rptname)
        {

            try
            {

                config.loadReports(sql);

                string reportname = rptname;


                CrystalDecisions.CrystalReports.Engine.ReportDocument reportdoc = new CrystalDecisions.CrystalReports.Engine.ReportDocument(); ;

                string strReportPath = Application.StartupPath + "\\report\\" + reportname + ".rpt";


                reportdoc.Load(strReportPath);
                reportdoc.SetDataSource(config.dt);

                crystalReportViewer1.ReportSource = reportdoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }


        }

        private void active_Menu(string activeMenu)
        {
            switch (activeMenu)
            {
                case "Weekly":
                    pnlActive_payslip.Visible = false;
                    pnlActive_weekly.Visible = true;
                    break;
                case "Payslip":
                    pnlActive_payslip.Visible = true;
                    pnlActive_weekly.Visible = false;
                    break;
            }
        }

        private void btnweeklypayroll_Click(object sender, EventArgs e)
        {
            reports("SELECT CONCAT(  `emp_lname` ,  ' , ',  `emp_fname` ),`num_days` ,  `d_rate` ,  `r_wage` ,  `overtime` , `hol_pay` ,  `gross_sal` ,  `cash_ad` ,  `bread_vale` ,  `philhealth` ,  `deduct1` ,  `ded_amount1` , `deduct2` ,  `ded_amount2` ,  `deduct3` ,  `ded_amount3` ,  `total_ded` ,  `net_income` ,`dateissued` "
         + "FROM  `employee` e,  `employee_workinfo` we,  `payroll` p,  `other_deduction` od "
         + "WHERE e.`emp_code` = p.`emp_code` "
         + "AND p.`emp_code` = we.`emp_code` "
         + "AND p.`trans_id` = od.`trans_id` ", "weeklypayroll");
            active_Menu("Weekly");
        }


        private void btnPayslip_Click(object sender, EventArgs e)
        {
            sql = "SELECT CONCAT(  `emp_lname` ,  ' , ',  `emp_fname` ) ,`num_days` , `d_rate` ,  `r_wage` "
              + ",  `overtime` , `hol_pay` ,  `gross_sal` ,  `cash_ad` ,  `bread_vale` ,  `philhealth` , "
              + "`pag-ibig`,  `deduct1` ,  `ded_amount1` , `deduct2` ,  `ded_amount2` ,  `deduct3` ,  "
              + "`ded_amount3` ,  `total_ded` ,  `net_income` ,`dateissued`" +
               " FROM  `employee` e,  `employee_workinfo` we,  `payroll` p,  `other_deduction` od " +
               " WHERE e.`emp_code` = p.`emp_code` " +
               " AND p.`emp_code` = we.`emp_code` " +
               " AND p.`trans_id` = od.`trans_id` ";
            reports(sql, "payslip");
            active_Menu("Payslip");
        }

        private void btnweeklypayroll_MouseHover(object sender, EventArgs e)
        {
            btnweeklypayroll.BackColor = Color.Maroon;
        }

        private void btnweeklypayroll_MouseLeave(object sender, EventArgs e)
        {
            btnweeklypayroll.BackColor = Color.Black;
        }

        private void btnPayslip_MouseHover(object sender, EventArgs e)
        {
            btnPayslip.BackColor = Color.Maroon;
        }

        private void btnPayslip_MouseLeave(object sender, EventArgs e)
        {
            btnPayslip.BackColor = Color.Black;
        }
    }
}
