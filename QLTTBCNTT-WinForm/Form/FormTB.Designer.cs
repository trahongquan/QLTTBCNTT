using System.Windows.Forms;

namespace QLTTBCNTT_WinForm
{
    partial class FormTB
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
            this.dtgvTB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTB = new System.Windows.Forms.Button();
            this.ModifyTB = new System.Windows.Forms.Button();
            this.DelTB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbIDLTB = new System.Windows.Forms.ComboBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.txtCoreCPU = new System.Windows.Forms.TextBox();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.txtQN = new System.Windows.Forms.TextBox();
            this.txtDonvi = new System.Windows.Forms.TextBox();
            this.cbbRAM = new System.Windows.Forms.ComboBox();
            this.cbbHardDisk = new System.Windows.Forms.ComboBox();
            this.txtIDLTB = new System.Windows.Forms.TextBox();
            this.cbbidQN = new System.Windows.Forms.ComboBox();
            this.dMQuanNhanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTBCNTTDataSet_cbbIDQN_DMTB = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet_cbbIDQN_DMTB();
            this.dMQuanNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbidDV = new System.Windows.Forms.ComboBox();
            this.dMDonviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTBCNTTDataSet = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet();
            this.dMDonviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dM_QuanNhanTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet_cbbIDQN_DMTBTableAdapters.DM_QuanNhanTableAdapter();
            this.dM_DonviTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSetTableAdapters.DM_DonviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMQuanNhanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet_cbbIDQN_DMTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMQuanNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTB
            // 
            this.dtgvTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgvTB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTB.Location = new System.Drawing.Point(13, 13);
            this.dtgvTB.Name = "dtgvTB";
            this.dtgvTB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTB.Size = new System.Drawing.Size(700, 555);
            this.dtgvTB.TabIndex = 0;
            this.dtgvTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvTB_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Thiết bị";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thiết bị";
            // 
            // AddTB
            // 
            this.AddTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTB.Location = new System.Drawing.Point(738, 46);
            this.AddTB.Name = "AddTB";
            this.AddTB.Size = new System.Drawing.Size(75, 23);
            this.AddTB.TabIndex = 3;
            this.AddTB.Text = "Thêm";
            this.AddTB.UseVisualStyleBackColor = true;
            this.AddTB.Click += new System.EventHandler(this.AddTB_Click);
            // 
            // ModifyTB
            // 
            this.ModifyTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyTB.Location = new System.Drawing.Point(861, 45);
            this.ModifyTB.Name = "ModifyTB";
            this.ModifyTB.Size = new System.Drawing.Size(75, 23);
            this.ModifyTB.TabIndex = 4;
            this.ModifyTB.Text = "Sửa";
            this.ModifyTB.UseVisualStyleBackColor = true;
            this.ModifyTB.Click += new System.EventHandler(this.ModifyTB_Click);
            // 
            // DelTB
            // 
            this.DelTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelTB.Location = new System.Drawing.Point(981, 45);
            this.DelTB.Name = "DelTB";
            this.DelTB.Size = new System.Drawing.Size(75, 23);
            this.DelTB.TabIndex = 5;
            this.DelTB.Text = "Xóa";
            this.DelTB.UseVisualStyleBackColor = true;
            this.DelTB.Click += new System.EventHandler(this.DelTB_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số seri";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MAC";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CoreCPU";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "RAM";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "HardDisk";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(735, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Màn hình";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(738, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Biên chế cá nhân";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(738, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Biên chế đơn vị";
            // 
            // cbbIDLTB
            // 
            this.cbbIDLTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbIDLTB.FormattingEnabled = true;
            this.cbbIDLTB.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbbIDLTB.Location = new System.Drawing.Point(829, 109);
            this.cbbIDLTB.Name = "cbbIDLTB";
            this.cbbIDLTB.Size = new System.Drawing.Size(41, 21);
            this.cbbIDLTB.TabIndex = 14;
            this.cbbIDLTB.SelectedIndexChanged += new System.EventHandler(this.cbbIDLTB_SelectedIndexChanged);
            // 
            // txtTenTB
            // 
            this.txtTenTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenTB.Location = new System.Drawing.Point(829, 149);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(259, 20);
            this.txtTenTB.TabIndex = 15;
            // 
            // txtSeri
            // 
            this.txtSeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSeri.Location = new System.Drawing.Point(829, 190);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(259, 20);
            this.txtSeri.TabIndex = 16;
            // 
            // txtMAC
            // 
            this.txtMAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMAC.Location = new System.Drawing.Point(829, 235);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(259, 20);
            this.txtMAC.TabIndex = 17;
            // 
            // txtCoreCPU
            // 
            this.txtCoreCPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCoreCPU.Location = new System.Drawing.Point(829, 288);
            this.txtCoreCPU.Name = "txtCoreCPU";
            this.txtCoreCPU.Size = new System.Drawing.Size(259, 20);
            this.txtCoreCPU.TabIndex = 18;
            // 
            // txtMonitor
            // 
            this.txtMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMonitor.Location = new System.Drawing.Point(829, 439);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(259, 20);
            this.txtMonitor.TabIndex = 20;
            // 
            // txtQN
            // 
            this.txtQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQN.Enabled = false;
            this.txtQN.Location = new System.Drawing.Point(890, 503);
            this.txtQN.Name = "txtQN";
            this.txtQN.Size = new System.Drawing.Size(177, 20);
            this.txtQN.TabIndex = 21;
            // 
            // txtDonvi
            // 
            this.txtDonvi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonvi.Enabled = false;
            this.txtDonvi.Location = new System.Drawing.Point(890, 541);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(177, 20);
            this.txtDonvi.TabIndex = 22;
            // 
            // cbbRAM
            // 
            this.cbbRAM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbRAM.FormattingEnabled = true;
            this.cbbRAM.Items.AddRange(new object[] {
            "",
            "4GB",
            "8GB",
            "12GB",
            "16GB",
            "20GB",
            "24GB",
            "28GB",
            "32GB",
            "48GB",
            "64GB"});
            this.cbbRAM.Location = new System.Drawing.Point(829, 339);
            this.cbbRAM.Name = "cbbRAM";
            this.cbbRAM.Size = new System.Drawing.Size(259, 21);
            this.cbbRAM.TabIndex = 23;
            // 
            // cbbHardDisk
            // 
            this.cbbHardDisk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbHardDisk.FormattingEnabled = true;
            this.cbbHardDisk.Items.AddRange(new object[] {
            "",
            "64GB",
            "128GB",
            "256GB",
            "512GB",
            "1TB",
            "2TB",
            "3TB",
            "4TB"});
            this.cbbHardDisk.Location = new System.Drawing.Point(829, 389);
            this.cbbHardDisk.Name = "cbbHardDisk";
            this.cbbHardDisk.Size = new System.Drawing.Size(259, 21);
            this.cbbHardDisk.TabIndex = 24;
            // 
            // txtIDLTB
            // 
            this.txtIDLTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDLTB.Location = new System.Drawing.Point(876, 109);
            this.txtIDLTB.Name = "txtIDLTB";
            this.txtIDLTB.Size = new System.Drawing.Size(212, 20);
            this.txtIDLTB.TabIndex = 25;
            // 
            // cbbidQN
            // 
            this.cbbidQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbidQN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMQuanNhanBindingSource1, "IDQuannhan", true));
            this.cbbidQN.DataSource = this.dMQuanNhanBindingSource;
            this.cbbidQN.DisplayMember = "IDQuannhan";
            this.cbbidQN.FormattingEnabled = true;
            this.cbbidQN.Location = new System.Drawing.Point(829, 502);
            this.cbbidQN.Name = "cbbidQN";
            this.cbbidQN.Size = new System.Drawing.Size(48, 21);
            this.cbbidQN.TabIndex = 26;
            this.cbbidQN.ValueMember = "IDQuannhan";
            this.cbbidQN.TextChanged += new System.EventHandler(this.ccbidQN_TextChanged);
            // 
            // dMQuanNhanBindingSource1
            // 
            this.dMQuanNhanBindingSource1.DataMember = "DM_QuanNhan";
            this.dMQuanNhanBindingSource1.DataSource = this.qLTTBCNTTDataSet_cbbIDQN_DMTB;
            // 
            // qLTTBCNTTDataSet_cbbIDQN_DMTB
            // 
            this.qLTTBCNTTDataSet_cbbIDQN_DMTB.DataSetName = "QLTTBCNTTDataSet_cbbIDQN_DMTB";
            this.qLTTBCNTTDataSet_cbbIDQN_DMTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMQuanNhanBindingSource
            // 
            this.dMQuanNhanBindingSource.DataMember = "DM_QuanNhan";
            this.dMQuanNhanBindingSource.DataSource = this.qLTTBCNTTDataSet_cbbIDQN_DMTB;
            // 
            // cbbidDV
            // 
            this.cbbidDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbidDV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMDonviBindingSource1, "IdDonvi", true));
            this.cbbidDV.DataSource = this.dMDonviBindingSource;
            this.cbbidDV.DisplayMember = "IdDonvi";
            this.cbbidDV.FormattingEnabled = true;
            this.cbbidDV.Location = new System.Drawing.Point(829, 544);
            this.cbbidDV.Name = "cbbidDV";
            this.cbbidDV.Size = new System.Drawing.Size(48, 21);
            this.cbbidDV.TabIndex = 27;
            this.cbbidDV.ValueMember = "IdDonvi";
            this.cbbidDV.TextChanged += new System.EventHandler(this.cbbidDV_TextChanged);
            // 
            // dMDonviBindingSource1
            // 
            this.dMDonviBindingSource1.DataMember = "DM_Donvi";
            this.dMDonviBindingSource1.DataSource = this.qLTTBCNTTDataSet;
            // 
            // qLTTBCNTTDataSet
            // 
            this.qLTTBCNTTDataSet.DataSetName = "QLTTBCNTTDataSet";
            this.qLTTBCNTTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMDonviBindingSource
            // 
            this.dMDonviBindingSource.DataMember = "DM_Donvi";
            this.dMDonviBindingSource.DataSource = this.qLTTBCNTTDataSet;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(861, 473);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(144, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "biên chế hoặc cho mượn";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // dM_QuanNhanTableAdapter
            // 
            this.dM_QuanNhanTableAdapter.ClearBeforeFill = true;
            // 
            // dM_DonviTableAdapter
            // 
            this.dM_DonviTableAdapter.ClearBeforeFill = true;
            // 
            // FormTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.cbbidDV);
            this.Controls.Add(this.cbbidQN);
            this.Controls.Add(this.txtIDLTB);
            this.Controls.Add(this.cbbHardDisk);
            this.Controls.Add(this.cbbRAM);
            this.Controls.Add(this.txtDonvi);
            this.Controls.Add(this.txtQN);
            this.Controls.Add(this.txtMonitor);
            this.Controls.Add(this.txtCoreCPU);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.txtSeri);
            this.Controls.Add(this.txtTenTB);
            this.Controls.Add(this.cbbIDLTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelTB);
            this.Controls.Add(this.ModifyTB);
            this.Controls.Add(this.AddTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvTB);
            this.Name = "FormTB";
            this.Text = "Danh mục quản lý thiết bị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTB_Load);
            this.TextChanged += new System.EventHandler(this.ccbidQN_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMQuanNhanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet_cbbIDQN_DMTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMQuanNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvTB;
        private Label label1;
        private Label label2;
        private Button AddTB;
        private Button ModifyTB;
        private Button DelTB;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cbbIDLTB;
        private TextBox txtTenTB;
        private TextBox txtSeri;
        private TextBox txtMAC;
        private TextBox txtCoreCPU;
        private TextBox txtMonitor;
        private TextBox txtQN;
        private TextBox txtDonvi;
        private ComboBox cbbRAM;
        private ComboBox cbbHardDisk;
        private TextBox txtIDLTB;
        private ComboBox cbbidQN;
        private ComboBox cbbidDV;
        private CheckBox checkBox2;
        private QLTTBCNTTDataSet_cbbIDQN_DMTB qLTTBCNTTDataSet_cbbIDQN_DMTB;
        private BindingSource dMQuanNhanBindingSource;
        private QLTTBCNTTDataSet_cbbIDQN_DMTBTableAdapters.DM_QuanNhanTableAdapter dM_QuanNhanTableAdapter;
        private QLTTBCNTTDataSet qLTTBCNTTDataSet;
        private BindingSource dMDonviBindingSource;
        private QLTTBCNTTDataSetTableAdapters.DM_DonviTableAdapter dM_DonviTableAdapter;
        private BindingSource dMQuanNhanBindingSource1;
        private BindingSource dMDonviBindingSource1;
    }
}