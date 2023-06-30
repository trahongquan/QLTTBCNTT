namespace QLTTBCNTT_WinForm
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLTTBCNTTDataSet5 = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet5();
            this.dMLoaiThietBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_LoaiThietBiTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet5TableAdapters.DM_LoaiThietBiTableAdapter();
            this.dMThietBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_ThietBiTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet5TableAdapters.DM_ThietBiTableAdapter();
            this.tBQNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_QNTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet5TableAdapters.TB_QNTableAdapter();
            this.dMDonviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_DonviTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet5TableAdapters.DM_DonviTableAdapter();
            this.DM_DonviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DM_ThietBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DM_QuanNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMLoaiThietBiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMThietBiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBQNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM_DonviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM_ThietBiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM_QuanNhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReport";
            reportDataSource1.Value = this.dMDonviBindingSource;
            reportDataSource2.Name = "DataSetReport2";
            reportDataSource2.Value = this.dMThietBiBindingSource;
            reportDataSource3.Name = "DataSetQN";
            reportDataSource3.Value = this.tBQNBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "QLTTBCNTT_WinForm.Report1.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer.Size = new System.Drawing.Size(942, 531);
            this.reportViewer.TabIndex = 0;
            // 
            // qLTTBCNTTDataSet5
            // 
            this.qLTTBCNTTDataSet5.DataSetName = "QLTTBCNTTDataSet5";
            this.qLTTBCNTTDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMLoaiThietBiBindingSource
            // 
            this.dMLoaiThietBiBindingSource.DataMember = "DM_LoaiThietBi";
            this.dMLoaiThietBiBindingSource.DataSource = this.qLTTBCNTTDataSet5;
            // 
            // dM_LoaiThietBiTableAdapter
            // 
            this.dM_LoaiThietBiTableAdapter.ClearBeforeFill = true;
            // 
            // dMThietBiBindingSource
            // 
            this.dMThietBiBindingSource.DataMember = "DM_ThietBi";
            this.dMThietBiBindingSource.DataSource = this.qLTTBCNTTDataSet5;
            // 
            // dM_ThietBiTableAdapter
            // 
            this.dM_ThietBiTableAdapter.ClearBeforeFill = true;
            // 
            // tBQNBindingSource
            // 
            this.tBQNBindingSource.DataMember = "TB_QN";
            this.tBQNBindingSource.DataSource = this.qLTTBCNTTDataSet5;
            // 
            // tB_QNTableAdapter
            // 
            this.tB_QNTableAdapter.ClearBeforeFill = true;
            // 
            // dMDonviBindingSource
            // 
            this.dMDonviBindingSource.DataMember = "DM_Donvi";
            this.dMDonviBindingSource.DataSource = this.qLTTBCNTTDataSet5;
            // 
            // dM_DonviTableAdapter
            // 
            this.dM_DonviTableAdapter.ClearBeforeFill = true;
            // 
            // DM_DonviBindingSource
            // 
            this.DM_DonviBindingSource.DataMember = "DM_Donvi";
            this.DM_DonviBindingSource.DataSource = this.qLTTBCNTTDataSet5;
            // 
            // DM_ThietBiBindingSource
            // 
            this.DM_ThietBiBindingSource.DataMember = "DM_ThietBi";
            this.DM_ThietBiBindingSource.DataSource = this.qLTTBCNTTDataSet5;
            // 
            // DM_QuanNhanBindingSource
            // 
            this.DM_QuanNhanBindingSource.DataMember = "DM_QuanNhan";
            this.DM_QuanNhanBindingSource.DataSource = this.qLTTBCNTTDataSet5;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 531);
            this.Controls.Add(this.reportViewer);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMLoaiThietBiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMThietBiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBQNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM_DonviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM_ThietBiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM_QuanNhanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private QLTTBCNTTDataSet5 qLTTBCNTTDataSet5;
        private System.Windows.Forms.BindingSource dMLoaiThietBiBindingSource;
        private QLTTBCNTTDataSet5TableAdapters.DM_LoaiThietBiTableAdapter dM_LoaiThietBiTableAdapter;
        private System.Windows.Forms.BindingSource dMThietBiBindingSource;
        private QLTTBCNTTDataSet5TableAdapters.DM_ThietBiTableAdapter dM_ThietBiTableAdapter;
        private System.Windows.Forms.BindingSource tBQNBindingSource;
        private QLTTBCNTTDataSet5TableAdapters.TB_QNTableAdapter tB_QNTableAdapter;
        private System.Windows.Forms.BindingSource dMDonviBindingSource;
        private QLTTBCNTTDataSet5TableAdapters.DM_DonviTableAdapter dM_DonviTableAdapter;
        private System.Windows.Forms.BindingSource DM_DonviBindingSource;
        private System.Windows.Forms.BindingSource DM_ThietBiBindingSource;
        private System.Windows.Forms.BindingSource DM_QuanNhanBindingSource;
    }
}