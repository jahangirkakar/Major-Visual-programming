namespace PayrollSystem1._1
{
    partial class frmReport
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnPayslip = new System.Windows.Forms.Button();
            this.btnweeklypayroll = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlActive_weekly = new System.Windows.Forms.Panel();
            this.pnlActive_payslip = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.pnlActive_payslip);
            this.Panel1.Controls.Add(this.pnlActive_weekly);
            this.Panel1.Controls.Add(this.btnPayslip);
            this.Panel1.Controls.Add(this.btnweeklypayroll);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(129, 464);
            this.Panel1.TabIndex = 3;
            // 
            // btnPayslip
            // 
            this.btnPayslip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayslip.BackColor = System.Drawing.Color.Black;
            this.btnPayslip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayslip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayslip.ForeColor = System.Drawing.Color.White;
            this.btnPayslip.Location = new System.Drawing.Point(7, 54);
            this.btnPayslip.Name = "btnPayslip";
            this.btnPayslip.Size = new System.Drawing.Size(119, 43);
            this.btnPayslip.TabIndex = 5;
            this.btnPayslip.Text = "Payslip";
            this.btnPayslip.UseVisualStyleBackColor = false;
            this.btnPayslip.Click += new System.EventHandler(this.btnPayslip_Click);
            this.btnPayslip.MouseLeave += new System.EventHandler(this.btnPayslip_MouseLeave);
            this.btnPayslip.MouseHover += new System.EventHandler(this.btnPayslip_MouseHover);
            // 
            // btnweeklypayroll
            // 
            this.btnweeklypayroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnweeklypayroll.BackColor = System.Drawing.Color.Black;
            this.btnweeklypayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnweeklypayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnweeklypayroll.ForeColor = System.Drawing.Color.White;
            this.btnweeklypayroll.Location = new System.Drawing.Point(7, 5);
            this.btnweeklypayroll.Name = "btnweeklypayroll";
            this.btnweeklypayroll.Size = new System.Drawing.Size(119, 43);
            this.btnweeklypayroll.TabIndex = 4;
            this.btnweeklypayroll.Text = "Weekly Payroll";
            this.btnweeklypayroll.UseVisualStyleBackColor = false;
            this.btnweeklypayroll.Click += new System.EventHandler(this.btnweeklypayroll_Click);
            this.btnweeklypayroll.MouseLeave += new System.EventHandler(this.btnweeklypayroll_MouseLeave);
            this.btnweeklypayroll.MouseHover += new System.EventHandler(this.btnweeklypayroll_MouseHover);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(129, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(683, 464);
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pnlActive_weekly
            // 
            this.pnlActive_weekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlActive_weekly.Location = new System.Drawing.Point(0, 5);
            this.pnlActive_weekly.Name = "pnlActive_weekly";
            this.pnlActive_weekly.Size = new System.Drawing.Size(13, 46);
            this.pnlActive_weekly.TabIndex = 5;
            this.pnlActive_weekly.Visible = false;
            // 
            // pnlActive_payslip
            // 
            this.pnlActive_payslip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlActive_payslip.Location = new System.Drawing.Point(0, 54);
            this.pnlActive_payslip.Name = "pnlActive_payslip";
            this.pnlActive_payslip.Size = new System.Drawing.Size(13, 46);
            this.pnlActive_payslip.TabIndex = 6;
            this.pnlActive_payslip.Visible = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 464);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnPayslip;
        internal System.Windows.Forms.Button btnweeklypayroll;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel pnlActive_payslip;
        private System.Windows.Forms.Panel pnlActive_weekly;
    }
}