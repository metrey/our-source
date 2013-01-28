namespace TestCrystalReportViewer
{
    partial class frmCrystalReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrystalReportViewer));
            this.axCrystalActiveXReportViewer1 = new AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalActiveXReportViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axCrystalActiveXReportViewer1
            // 
            this.axCrystalActiveXReportViewer1.Enabled = true;
            this.axCrystalActiveXReportViewer1.Location = new System.Drawing.Point(1, 12);
            this.axCrystalActiveXReportViewer1.Name = "axCrystalActiveXReportViewer1";
            this.axCrystalActiveXReportViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCrystalActiveXReportViewer1.OcxState")));
            this.axCrystalActiveXReportViewer1.Size = new System.Drawing.Size(647, 536);
            this.axCrystalActiveXReportViewer1.TabIndex = 0;
            // 
            // frmCrystalReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 560);
            this.Controls.Add(this.axCrystalActiveXReportViewer1);
            this.Name = "frmCrystalReportViewer";
            this.Text = "Crystal Report Viewer";
            this.Load += new System.EventHandler(this.frmCrystalReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalActiveXReportViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer axCrystalActiveXReportViewer1;
    }
}

