namespace QLTTBCNTT_WinForm
{
    partial class Dashboard
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
            this.dtgvDashboard = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchTenTB = new System.Windows.Forms.TextBox();
            this.txtSearchTenQN = new System.Windows.Forms.TextBox();
            this.txtSearchDV = new System.Windows.Forms.TextBox();
            this.btnBRG_DB = new System.Windows.Forms.Button();
            this.btnTBQN_DB = new System.Windows.Forms.Button();
            this.btnTBDV_DB = new System.Windows.Forms.Button();
            this.RB_Doi = new System.Windows.Forms.RadioButton();
            this.RB_TieuDoan = new System.Windows.Forms.RadioButton();
            this.RB_LuDoan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDashboard
            // 
            this.dtgvDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDashboard.Location = new System.Drawing.Point(2, 3);
            this.dtgvDashboard.Name = "dtgvDashboard";
            this.dtgvDashboard.Size = new System.Drawing.Size(586, 557);
            this.dtgvDashboard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo tên thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm theo tên quân nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm kiếm theo đơn vị";
            // 
            // txtSearchTenTB
            // 
            this.txtSearchTenTB.Location = new System.Drawing.Point(627, 116);
            this.txtSearchTenTB.Name = "txtSearchTenTB";
            this.txtSearchTenTB.Size = new System.Drawing.Size(193, 20);
            this.txtSearchTenTB.TabIndex = 4;
            this.txtSearchTenTB.TextChanged += new System.EventHandler(this.txtSearchTenTB_TextChanged);
            // 
            // txtSearchTenQN
            // 
            this.txtSearchTenQN.Location = new System.Drawing.Point(627, 230);
            this.txtSearchTenQN.Name = "txtSearchTenQN";
            this.txtSearchTenQN.Size = new System.Drawing.Size(193, 20);
            this.txtSearchTenQN.TabIndex = 5;
            this.txtSearchTenQN.TextChanged += new System.EventHandler(this.txtSearchTenQN_TextChanged);
            // 
            // txtSearchDV
            // 
            this.txtSearchDV.Location = new System.Drawing.Point(627, 347);
            this.txtSearchDV.Name = "txtSearchDV";
            this.txtSearchDV.Size = new System.Drawing.Size(193, 20);
            this.txtSearchDV.TabIndex = 6;
            this.txtSearchDV.TextChanged += new System.EventHandler(this.txtSearchDV_TextChanged);
            // 
            // btnBRG_DB
            // 
            this.btnBRG_DB.Location = new System.Drawing.Point(636, 36);
            this.btnBRG_DB.Name = "btnBRG_DB";
            this.btnBRG_DB.Size = new System.Drawing.Size(84, 23);
            this.btnBRG_DB.TabIndex = 7;
            this.btnBRG_DB.Text = "Bảng rút gọn";
            this.btnBRG_DB.UseVisualStyleBackColor = true;
            this.btnBRG_DB.Click += new System.EventHandler(this.btnBRG_DB_Click);
            // 
            // btnTBQN_DB
            // 
            this.btnTBQN_DB.Location = new System.Drawing.Point(741, 36);
            this.btnTBQN_DB.Name = "btnTBQN_DB";
            this.btnTBQN_DB.Size = new System.Drawing.Size(84, 23);
            this.btnTBQN_DB.TabIndex = 8;
            this.btnTBQN_DB.Text = "QN mượn";
            this.btnTBQN_DB.UseVisualStyleBackColor = true;
            this.btnTBQN_DB.Click += new System.EventHandler(this.btnTBQN_DB_Click);
            // 
            // btnTBDV_DB
            // 
            this.btnTBDV_DB.Location = new System.Drawing.Point(850, 36);
            this.btnTBDV_DB.Name = "btnTBDV_DB";
            this.btnTBDV_DB.Size = new System.Drawing.Size(84, 23);
            this.btnTBDV_DB.TabIndex = 9;
            this.btnTBDV_DB.Text = "ĐV mượn";
            this.btnTBDV_DB.UseVisualStyleBackColor = true;
            this.btnTBDV_DB.Click += new System.EventHandler(this.btnTBDV_DB_Click);
            // 
            // RB_Doi
            // 
            this.RB_Doi.AutoSize = true;
            this.RB_Doi.Location = new System.Drawing.Point(627, 374);
            this.RB_Doi.Name = "RB_Doi";
            this.RB_Doi.Size = new System.Drawing.Size(41, 17);
            this.RB_Doi.TabIndex = 10;
            this.RB_Doi.TabStop = true;
            this.RB_Doi.Text = "Đội";
            this.RB_Doi.UseVisualStyleBackColor = true;
            // 
            // RB_TieuDoan
            // 
            this.RB_TieuDoan.AutoSize = true;
            this.RB_TieuDoan.Location = new System.Drawing.Point(674, 373);
            this.RB_TieuDoan.Name = "RB_TieuDoan";
            this.RB_TieuDoan.Size = new System.Drawing.Size(74, 17);
            this.RB_TieuDoan.TabIndex = 11;
            this.RB_TieuDoan.TabStop = true;
            this.RB_TieuDoan.Text = "Tiểu đoàn";
            this.RB_TieuDoan.UseVisualStyleBackColor = true;
            // 
            // RB_LuDoan
            // 
            this.RB_LuDoan.AutoSize = true;
            this.RB_LuDoan.Location = new System.Drawing.Point(754, 373);
            this.RB_LuDoan.Name = "RB_LuDoan";
            this.RB_LuDoan.Size = new System.Drawing.Size(66, 17);
            this.RB_LuDoan.TabIndex = 12;
            this.RB_LuDoan.TabStop = true;
            this.RB_LuDoan.Text = "Lữ Đoàn";
            this.RB_LuDoan.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 572);
            this.Controls.Add(this.RB_LuDoan);
            this.Controls.Add(this.RB_TieuDoan);
            this.Controls.Add(this.RB_Doi);
            this.Controls.Add(this.btnTBDV_DB);
            this.Controls.Add(this.btnTBQN_DB);
            this.Controls.Add(this.btnBRG_DB);
            this.Controls.Add(this.txtSearchDV);
            this.Controls.Add(this.txtSearchTenQN);
            this.Controls.Add(this.txtSearchTenTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDashboard);
            this.Name = "Dashboard";
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchTenTB;
        private System.Windows.Forms.TextBox txtSearchTenQN;
        private System.Windows.Forms.TextBox txtSearchDV;
        private System.Windows.Forms.Button btnBRG_DB;
        private System.Windows.Forms.Button btnTBQN_DB;
        private System.Windows.Forms.Button btnTBDV_DB;
        private System.Windows.Forms.RadioButton RB_Doi;
        private System.Windows.Forms.RadioButton RB_TieuDoan;
        private System.Windows.Forms.RadioButton RB_LuDoan;
    }
}