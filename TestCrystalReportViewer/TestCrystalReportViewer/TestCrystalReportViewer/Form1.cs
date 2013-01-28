using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestCrystalReportViewer
{
    public partial class frmCrystalReportViewer : Form
    {
        public frmCrystalReportViewer()
        {
            InitializeComponent();
        }

        private void frmCrystalReportViewer_Load(object sender, EventArgs e)
        {
            CRAXDDRT.Application crxApp = new CRAXDDRT.Application();
            CRAXDDRT.Report crxReport = new CRAXDDRT.Report();
            crxReport = crxApp.OpenReport(Application.StartupPath + "/KhmerUnicodeTest.rpt", null);
            this.axCrystalActiveXReportViewer1.ReportSource = crxReport;            
            this.axCrystalActiveXReportViewer1.ViewReport();
        }       
    }
}
