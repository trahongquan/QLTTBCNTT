using System.Windows.Forms;

namespace QLTTBCNTT_WinForm
{
    partial class FormMain
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTB = new System.Windows.Forms.Button();
            this.btnDMTB = new System.Windows.Forms.Button();
            this.btnTBDV = new System.Windows.Forms.Button();
            this.btnTBQN = new System.Windows.Forms.Button();
            this.btnQN = new System.Windows.Forms.Button();
            this.btnDV = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MintCream;
            this.flowLayoutPanel1.Controls.Add(this.btnTB);
            this.flowLayoutPanel1.Controls.Add(this.btnDMTB);
            this.flowLayoutPanel1.Controls.Add(this.btnTBDV);
            this.flowLayoutPanel1.Controls.Add(this.btnTBQN);
            this.flowLayoutPanel1.Controls.Add(this.btnQN);
            this.flowLayoutPanel1.Controls.Add(this.btnDV);
            this.flowLayoutPanel1.Controls.Add(this.Dashboard);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Purple;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1123, 34);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnTB
            // 
            this.btnTB.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTB.Location = new System.Drawing.Point(3, 3);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(142, 28);
            this.btnTB.TabIndex = 0;
            this.btnTB.Text = "Thiết bị";
            this.btnTB.UseVisualStyleBackColor = false;
            this.btnTB.Click += new System.EventHandler(this.btnChildFormTB_Click);
            // 
            // btnDMTB
            // 
            this.btnDMTB.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDMTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDMTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMTB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMTB.Location = new System.Drawing.Point(151, 3);
            this.btnDMTB.Name = "btnDMTB";
            this.btnDMTB.Size = new System.Drawing.Size(142, 28);
            this.btnDMTB.TabIndex = 4;
            this.btnDMTB.Text = "DM Thiết bị";
            this.btnDMTB.UseVisualStyleBackColor = false;
            // 
            // btnTBDV
            // 
            this.btnTBDV.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTBDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTBDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTBDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTBDV.Location = new System.Drawing.Point(299, 3);
            this.btnTBDV.Name = "btnTBDV";
            this.btnTBDV.Size = new System.Drawing.Size(142, 28);
            this.btnTBDV.TabIndex = 1;
            this.btnTBDV.Text = "Đơn vị - Thiết bị";
            this.btnTBDV.UseVisualStyleBackColor = false;
            this.btnTBDV.Click += new System.EventHandler(this.btnChildFormTBDV_Click);
            // 
            // btnTBQN
            // 
            this.btnTBQN.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTBQN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTBQN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTBQN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTBQN.Location = new System.Drawing.Point(447, 3);
            this.btnTBQN.Name = "btnTBQN";
            this.btnTBQN.Size = new System.Drawing.Size(142, 28);
            this.btnTBQN.TabIndex = 1;
            this.btnTBQN.Text = "Quân nhân - Thiết bị";
            this.btnTBQN.UseVisualStyleBackColor = false;
            this.btnTBQN.Click += new System.EventHandler(this.btnChildFormTBQN_Click);
            // 
            // btnQN
            // 
            this.btnQN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQN.BackColor = System.Drawing.Color.LimeGreen;
            this.btnQN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQN.Location = new System.Drawing.Point(595, 3);
            this.btnQN.Name = "btnQN";
            this.btnQN.Size = new System.Drawing.Size(142, 28);
            this.btnQN.TabIndex = 2;
            this.btnQN.Text = "Quân nhân";
            this.btnQN.UseVisualStyleBackColor = false;
            this.btnQN.Click += new System.EventHandler(this.btnChildFormQN_Click);
            // 
            // btnDV
            // 
            this.btnDV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDV.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDV.Location = new System.Drawing.Point(743, 3);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(142, 28);
            this.btnDV.TabIndex = 3;
            this.btnDV.Text = "Đơn vị";
            this.btnDV.UseVisualStyleBackColor = false;
            this.btnDV.Click += new System.EventHandler(this.btnChildFormDV_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.Honeydew;
            this.Dashboard.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(891, 3);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(142, 28);
            this.Dashboard.TabIndex = 5;
            this.Dashboard.Text = "Trang chủ";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Location = new System.Drawing.Point(3, 43);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1123, 618);
            this.panelDesktopPane.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 660);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "Quản lý Trang thiết bị CNTT";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTB;
        private System.Windows.Forms.Button btnTBQN;
        private System.Windows.Forms.Button btnQN;
        private System.Windows.Forms.Button btnDV;
        private System.Windows.Forms.Button btnDMTB;
        private System.Windows.Forms.Button btnTBDV;
        private System.Windows.Forms.Panel panelDesktopPane;
        private Button Dashboard;
    }
}

