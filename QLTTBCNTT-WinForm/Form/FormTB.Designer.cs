﻿using System.Windows.Forms;

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
            this.dMThietBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTBCNTTDataSet = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet();
            this.dM_ThietBiTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSetTableAdapters.DM_ThietBiTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMThietBiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTB
            // 
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
            // dMThietBiBindingSource
            // 
            this.dMThietBiBindingSource.DataMember = "DM_ThietBi";
            this.dMThietBiBindingSource.DataSource = this.qLTTBCNTTDataSet;
            // 
            // qLTTBCNTTDataSet
            // 
            this.qLTTBCNTTDataSet.DataSetName = "QLTTBCNTTDataSet";
            this.qLTTBCNTTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_ThietBiTableAdapter
            // 
            this.dM_ThietBiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thiết bị";
            // 
            // AddTB
            // 
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
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MAC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CoreCPU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "RAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "HardDisk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(735, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Màn hình";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(738, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Biên chế cá nhân";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(738, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Biên chế đơn vị";
            // 
            // cbbIDLTB
            // 
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
            this.txtTenTB.Location = new System.Drawing.Point(829, 149);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(259, 20);
            this.txtTenTB.TabIndex = 15;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(829, 190);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(259, 20);
            this.txtSeri.TabIndex = 16;
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(829, 235);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(259, 20);
            this.txtMAC.TabIndex = 17;
            // 
            // txtCoreCPU
            // 
            this.txtCoreCPU.Location = new System.Drawing.Point(829, 288);
            this.txtCoreCPU.Name = "txtCoreCPU";
            this.txtCoreCPU.Size = new System.Drawing.Size(259, 20);
            this.txtCoreCPU.TabIndex = 18;
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(829, 439);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(259, 20);
            this.txtMonitor.TabIndex = 20;
            // 
            // txtQN
            // 
            this.txtQN.Location = new System.Drawing.Point(829, 483);
            this.txtQN.Name = "txtQN";
            this.txtQN.Size = new System.Drawing.Size(259, 20);
            this.txtQN.TabIndex = 21;
            // 
            // txtDonvi
            // 
            this.txtDonvi.Location = new System.Drawing.Point(829, 527);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(259, 20);
            this.txtDonvi.TabIndex = 22;
            // 
            // cbbRAM
            // 
            this.cbbRAM.FormattingEnabled = true;
            this.cbbRAM.Items.AddRange(new object[] {
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
            this.cbbHardDisk.FormattingEnabled = true;
            this.cbbHardDisk.Items.AddRange(new object[] {
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
            this.txtIDLTB.Location = new System.Drawing.Point(876, 109);
            this.txtIDLTB.Name = "txtIDLTB";
            this.txtIDLTB.Size = new System.Drawing.Size(212, 20);
            this.txtIDLTB.TabIndex = 25;
            // 
            // FormTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 580);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMThietBiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvTB;
        private QLTTBCNTTDataSet qLTTBCNTTDataSet;
        private BindingSource dMThietBiBindingSource;
        private QLTTBCNTTDataSetTableAdapters.DM_ThietBiTableAdapter dM_ThietBiTableAdapter;
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
    }
}