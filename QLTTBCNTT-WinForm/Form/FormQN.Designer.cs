﻿namespace QLTTBCNTT_WinForm
{
    partial class FormQN
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
            this.dtgvQN = new System.Windows.Forms.DataGridView();
            this.AddQN = new System.Windows.Forms.Button();
            this.ModifyQN = new System.Windows.Forms.Button();
            this.DelQN = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCapbac = new System.Windows.Forms.ComboBox();
            this.cbbChucvu = new System.Windows.Forms.ComboBox();
            this.cbbDonvi = new System.Windows.Forms.ComboBox();
            this.dMDonviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTBCNTTDataSet = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet();
            this.txtCMTQD = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dM_DonviTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSetTableAdapters.DM_DonviTableAdapter();
            this.labDV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvQN
            // 
            this.dtgvQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvQN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQN.Location = new System.Drawing.Point(13, 13);
            this.dtgvQN.Name = "dtgvQN";
            this.dtgvQN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQN.Size = new System.Drawing.Size(705, 526);
            this.dtgvQN.TabIndex = 0;
            this.dtgvQN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvQN_MouseClick);
            // 
            // AddQN
            // 
            this.AddQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddQN.Location = new System.Drawing.Point(763, 42);
            this.AddQN.Name = "AddQN";
            this.AddQN.Size = new System.Drawing.Size(75, 23);
            this.AddQN.TabIndex = 1;
            this.AddQN.Text = "Thêm";
            this.AddQN.UseVisualStyleBackColor = true;
            this.AddQN.Click += new System.EventHandler(this.AddQN_Click);
            // 
            // ModifyQN
            // 
            this.ModifyQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyQN.Location = new System.Drawing.Point(874, 41);
            this.ModifyQN.Name = "ModifyQN";
            this.ModifyQN.Size = new System.Drawing.Size(75, 23);
            this.ModifyQN.TabIndex = 2;
            this.ModifyQN.Text = "Sửa";
            this.ModifyQN.UseVisualStyleBackColor = true;
            this.ModifyQN.Click += new System.EventHandler(this.ModifyQN_Click);
            // 
            // DelQN
            // 
            this.DelQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelQN.Location = new System.Drawing.Point(985, 41);
            this.DelQN.Name = "DelQN";
            this.DelQN.Size = new System.Drawing.Size(75, 23);
            this.DelQN.TabIndex = 3;
            this.DelQN.Text = "Xóa";
            this.DelQN.UseVisualStyleBackColor = true;
            this.DelQN.Click += new System.EventHandler(this.DelQN_Click);
            // 
            // lable1
            // 
            this.lable1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(763, 98);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(46, 13);
            this.lable1.TabIndex = 4;
            this.lable1.Text = "CMTQĐ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(763, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cấp bậc";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn vị";
            // 
            // cbbCapbac
            // 
            this.cbbCapbac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbCapbac.FormattingEnabled = true;
            this.cbbCapbac.Items.AddRange(new object[] {
            "Thiếu úy",
            "Trung úy",
            "Thượng úy",
            "Đại úy",
            "Thiếu tá",
            "Trung tá",
            "Thượng tá",
            "Đại tá",
            "Thiếu úy CN",
            "Trung úy CN",
            "Thượng úy CN",
            "Đại úy CN",
            "Thiếu tá CN",
            "Trung tá CN",
            "Thượng tá CN"});
            this.cbbCapbac.Location = new System.Drawing.Point(828, 180);
            this.cbbCapbac.Name = "cbbCapbac";
            this.cbbCapbac.Size = new System.Drawing.Size(232, 21);
            this.cbbCapbac.TabIndex = 9;
            // 
            // cbbChucvu
            // 
            this.cbbChucvu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbChucvu.FormattingEnabled = true;
            this.cbbChucvu.Items.AddRange(new object[] {
            "Chiến đấu viên",
            "Kỹ thuật viên",
            "Đội trưởng",
            "Đội phó",
            "Tiểu đoàn trưởng",
            "Tiểu đoàn phó",
            "Lữ đoàn trưởng",
            "Lữ đoàn phó"});
            this.cbbChucvu.Location = new System.Drawing.Point(828, 226);
            this.cbbChucvu.Name = "cbbChucvu";
            this.cbbChucvu.Size = new System.Drawing.Size(232, 21);
            this.cbbChucvu.TabIndex = 10;
            // 
            // cbbDonvi
            // 
            this.cbbDonvi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbDonvi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMDonviBindingSource, "IdDonvi", true));
            this.cbbDonvi.DataSource = this.dMDonviBindingSource;
            this.cbbDonvi.DisplayMember = "IdDonvi";
            this.cbbDonvi.FormattingEnabled = true;
            this.cbbDonvi.Location = new System.Drawing.Point(828, 273);
            this.cbbDonvi.Name = "cbbDonvi";
            this.cbbDonvi.Size = new System.Drawing.Size(28, 21);
            this.cbbDonvi.TabIndex = 11;
            this.cbbDonvi.ValueMember = "IdDonvi";
            this.cbbDonvi.TextChanged += new System.EventHandler(this.cbbDonvi_TextChanged);
            // 
            // dMDonviBindingSource
            // 
            this.dMDonviBindingSource.DataMember = "DM_Donvi";
            this.dMDonviBindingSource.DataSource = this.qLTTBCNTTDataSet;
            // 
            // qLTTBCNTTDataSet
            // 
            this.qLTTBCNTTDataSet.DataSetName = "QLTTBCNTTDataSet";
            this.qLTTBCNTTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCMTQD
            // 
            this.txtCMTQD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCMTQD.Location = new System.Drawing.Point(828, 95);
            this.txtCMTQD.Name = "txtCMTQD";
            this.txtCMTQD.Size = new System.Drawing.Size(232, 20);
            this.txtCMTQD.TabIndex = 12;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.Location = new System.Drawing.Point(828, 138);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(232, 20);
            this.txtTen.TabIndex = 13;
            // 
            // dM_DonviTableAdapter
            // 
            this.dM_DonviTableAdapter.ClearBeforeFill = true;
            // 
            // labDV
            // 
            this.labDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDV.Enabled = false;
            this.labDV.Location = new System.Drawing.Point(871, 273);
            this.labDV.Name = "labDV";
            this.labDV.Size = new System.Drawing.Size(189, 21);
            this.labDV.TabIndex = 14;
            this.labDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormQN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 559);
            this.Controls.Add(this.labDV);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtCMTQD);
            this.Controls.Add(this.cbbDonvi);
            this.Controls.Add(this.cbbChucvu);
            this.Controls.Add(this.cbbCapbac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.DelQN);
            this.Controls.Add(this.ModifyQN);
            this.Controls.Add(this.AddQN);
            this.Controls.Add(this.dtgvQN);
            this.Name = "FormQN";
            this.Text = "Danh mục Quân nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvQN;
        private System.Windows.Forms.Button AddQN;
        private System.Windows.Forms.Button ModifyQN;
        private System.Windows.Forms.Button DelQN;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbCapbac;
        private System.Windows.Forms.ComboBox cbbChucvu;
        private System.Windows.Forms.ComboBox cbbDonvi;
        private System.Windows.Forms.TextBox txtCMTQD;
        private System.Windows.Forms.TextBox txtTen;
        private QLTTBCNTTDataSet qLTTBCNTTDataSet;
        private System.Windows.Forms.BindingSource dMDonviBindingSource;
        private QLTTBCNTTDataSetTableAdapters.DM_DonviTableAdapter dM_DonviTableAdapter;
        private System.Windows.Forms.Label labDV;
    }
}