﻿namespace QLTTBCNTT_WinForm
{
    partial class FormTBDV
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
            this.dtgvTBDV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTBDV = new System.Windows.Forms.Button();
            this.ModifyTBDV = new System.Windows.Forms.Button();
            this.DelTBDV = new System.Windows.Forms.Button();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.txtSearchTBDV = new System.Windows.Forms.TextBox();
            this.DateBorrow = new System.Windows.Forms.DateTimePicker();
            this.DateReturn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbIDDV = new System.Windows.Forms.ComboBox();
            this.dMDonviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTBCNTTDataSet2 = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet2();
            this.cbbIDTB = new System.Windows.Forms.ComboBox();
            this.dMThietBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTBCNTTDataSet_TBDV_IDTB = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet_TBDV_IDTB();
            this.dM_DonviTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet2TableAdapters.DM_DonviTableAdapter();
            this.dM_ThietBiTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet_TBDV_IDTBTableAdapters.DM_ThietBiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTBDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMThietBiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet_TBDV_IDTB)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTBDV
            // 
            this.dtgvTBDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvTBDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgvTBDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTBDV.Location = new System.Drawing.Point(13, 13);
            this.dtgvTBDV.Name = "dtgvTBDV";
            this.dtgvTBDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTBDV.Size = new System.Drawing.Size(491, 425);
            this.dtgvTBDV.TabIndex = 0;
            this.dtgvTBDV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvTBDV_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn vị";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thiết bị";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm kiếm";
            // 
            // AddTBDV
            // 
            this.AddTBDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTBDV.Location = new System.Drawing.Point(555, 48);
            this.AddTBDV.Name = "AddTBDV";
            this.AddTBDV.Size = new System.Drawing.Size(75, 23);
            this.AddTBDV.TabIndex = 4;
            this.AddTBDV.Text = "Thêm";
            this.AddTBDV.UseVisualStyleBackColor = true;
            this.AddTBDV.Click += new System.EventHandler(this.AddTBDV_Click);
            // 
            // ModifyTBDV
            // 
            this.ModifyTBDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyTBDV.Location = new System.Drawing.Point(645, 47);
            this.ModifyTBDV.Name = "ModifyTBDV";
            this.ModifyTBDV.Size = new System.Drawing.Size(75, 23);
            this.ModifyTBDV.TabIndex = 5;
            this.ModifyTBDV.Text = "Sửa";
            this.ModifyTBDV.UseVisualStyleBackColor = true;
            this.ModifyTBDV.Click += new System.EventHandler(this.ModifyTBDV_Click);
            // 
            // DelTBDV
            // 
            this.DelTBDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelTBDV.Location = new System.Drawing.Point(736, 47);
            this.DelTBDV.Name = "DelTBDV";
            this.DelTBDV.Size = new System.Drawing.Size(75, 23);
            this.DelTBDV.TabIndex = 0;
            this.DelTBDV.Text = "Xóa";
            this.DelTBDV.UseVisualStyleBackColor = true;
            this.DelTBDV.Click += new System.EventHandler(this.DelTBDV_Click);
            // 
            // txtDV
            // 
            this.txtDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDV.Enabled = false;
            this.txtDV.Location = new System.Drawing.Point(639, 144);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(198, 20);
            this.txtDV.TabIndex = 6;
            // 
            // txtTB
            // 
            this.txtTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTB.Enabled = false;
            this.txtTB.Location = new System.Drawing.Point(639, 193);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(198, 20);
            this.txtTB.TabIndex = 7;
            // 
            // txtSearchTBDV
            // 
            this.txtSearchTBDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchTBDV.Location = new System.Drawing.Point(617, 337);
            this.txtSearchTBDV.Name = "txtSearchTBDV";
            this.txtSearchTBDV.Size = new System.Drawing.Size(124, 20);
            this.txtSearchTBDV.TabIndex = 8;
            // 
            // DateBorrow
            // 
            this.DateBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBorrow.Location = new System.Drawing.Point(618, 240);
            this.DateBorrow.Name = "DateBorrow";
            this.DateBorrow.Size = new System.Drawing.Size(124, 20);
            this.DateBorrow.TabIndex = 9;
            this.DateBorrow.Value = new System.DateTime(2023, 6, 27, 11, 27, 37, 0);
            // 
            // DateReturn
            // 
            this.DateReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateReturn.Location = new System.Drawing.Point(618, 287);
            this.DateReturn.Name = "DateReturn";
            this.DateReturn.Size = new System.Drawing.Size(124, 20);
            this.DateReturn.TabIndex = 10;
            this.DateReturn.Value = new System.DateTime(2023, 6, 27, 11, 27, 46, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày Biên chế";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Trả Biên chế";
            // 
            // cbbIDDV
            // 
            this.cbbIDDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbIDDV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMDonviBindingSource, "IdDonvi", true));
            this.cbbIDDV.DataSource = this.dMDonviBindingSource;
            this.cbbIDDV.DisplayMember = "IdDonvi";
            this.cbbIDDV.FormattingEnabled = true;
            this.cbbIDDV.Location = new System.Drawing.Point(579, 143);
            this.cbbIDDV.Name = "cbbIDDV";
            this.cbbIDDV.Size = new System.Drawing.Size(43, 21);
            this.cbbIDDV.TabIndex = 13;
            this.cbbIDDV.ValueMember = "IdDonvi";
            this.cbbIDDV.TextChanged += new System.EventHandler(this.ccbidDV_TextChanged);
            // 
            // dMDonviBindingSource
            // 
            this.dMDonviBindingSource.DataMember = "DM_Donvi";
            this.dMDonviBindingSource.DataSource = this.qLTTBCNTTDataSet2;
            // 
            // qLTTBCNTTDataSet2
            // 
            this.qLTTBCNTTDataSet2.DataSetName = "QLTTBCNTTDataSet2";
            this.qLTTBCNTTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbIDTB
            // 
            this.cbbIDTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbIDTB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMThietBiBindingSource, "IdThietBi", true));
            this.cbbIDTB.DataSource = this.dMThietBiBindingSource;
            this.cbbIDTB.DisplayMember = "IdThietBi";
            this.cbbIDTB.FormattingEnabled = true;
            this.cbbIDTB.Location = new System.Drawing.Point(579, 192);
            this.cbbIDTB.Name = "cbbIDTB";
            this.cbbIDTB.Size = new System.Drawing.Size(43, 21);
            this.cbbIDTB.TabIndex = 14;
            this.cbbIDTB.ValueMember = "IdThietBi";
            this.cbbIDTB.SelectedIndexChanged += new System.EventHandler(this.cbbIDTB_SelectedIndexChanged);
            this.cbbIDTB.TextChanged += new System.EventHandler(this.cbbidTB_TextChanged);
            // 
            // dMThietBiBindingSource
            // 
            this.dMThietBiBindingSource.DataMember = "DM_ThietBi";
            this.dMThietBiBindingSource.DataSource = this.qLTTBCNTTDataSet_TBDV_IDTB;
            // 
            // qLTTBCNTTDataSet_TBDV_IDTB
            // 
            this.qLTTBCNTTDataSet_TBDV_IDTB.DataSetName = "QLTTBCNTTDataSet_TBDV_IDTB";
            this.qLTTBCNTTDataSet_TBDV_IDTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_DonviTableAdapter
            // 
            this.dM_DonviTableAdapter.ClearBeforeFill = true;
            // 
            // dM_ThietBiTableAdapter
            // 
            this.dM_ThietBiTableAdapter.ClearBeforeFill = true;
            // 
            // FormTBDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.cbbIDTB);
            this.Controls.Add(this.cbbIDDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateReturn);
            this.Controls.Add(this.DateBorrow);
            this.Controls.Add(this.txtSearchTBDV);
            this.Controls.Add(this.txtTB);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.DelTBDV);
            this.Controls.Add(this.ModifyTBDV);
            this.Controls.Add(this.AddTBDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvTBDV);
            this.Name = "FormTBDV";
            this.Text = "FormTBDV";
            this.Load += new System.EventHandler(this.FormTBDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTBDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDonviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMThietBiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet_TBDV_IDTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTBDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddTBDV;
        private System.Windows.Forms.Button ModifyTBDV;
        private System.Windows.Forms.Button DelTBDV;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.TextBox txtSearchTBDV;
        private System.Windows.Forms.DateTimePicker DateBorrow;
        private System.Windows.Forms.DateTimePicker DateReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbIDDV;
        private System.Windows.Forms.ComboBox cbbIDTB;
        private QLTTBCNTTDataSet2 qLTTBCNTTDataSet2;
        private System.Windows.Forms.BindingSource dMDonviBindingSource;
        private QLTTBCNTTDataSet2TableAdapters.DM_DonviTableAdapter dM_DonviTableAdapter;
        private QLTTBCNTTDataSet_TBDV_IDTB qLTTBCNTTDataSet_TBDV_IDTB;
        private System.Windows.Forms.BindingSource dMThietBiBindingSource;
        private QLTTBCNTTDataSet_TBDV_IDTBTableAdapters.DM_ThietBiTableAdapter dM_ThietBiTableAdapter;
    }
}