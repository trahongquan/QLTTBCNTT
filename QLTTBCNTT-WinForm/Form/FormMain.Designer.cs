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
            this.btnChildFormTB = new System.Windows.Forms.Button();
            this.btnChildFormTBDV = new System.Windows.Forms.Button();
            this.btnChildFormDMTB = new System.Windows.Forms.Button();
            this.btnChildFormQN = new System.Windows.Forms.Button();
            this.btnChildFormDV = new System.Windows.Forms.Button();
            this.btnChildFormTBQN = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MintCream;
            this.flowLayoutPanel1.Controls.Add(this.btnChildFormTB);
            this.flowLayoutPanel1.Controls.Add(this.btnChildFormTBDV);
            this.flowLayoutPanel1.Controls.Add(this.btnChildFormDMTB);
            this.flowLayoutPanel1.Controls.Add(this.btnChildFormQN);
            this.flowLayoutPanel1.Controls.Add(this.btnChildFormDV);
            this.flowLayoutPanel1.Controls.Add(this.btnChildFormTBQN);
            this.flowLayoutPanel1.Controls.Add(this.Dashboard);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Purple;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1123, 34);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnChildFormTB
            // 
            this.btnChildFormTB.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChildFormTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChildFormTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormTB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildFormTB.Location = new System.Drawing.Point(3, 3);
            this.btnChildFormTB.Name = "btnChildFormTB";
            this.btnChildFormTB.Size = new System.Drawing.Size(142, 28);
            this.btnChildFormTB.TabIndex = 0;
            this.btnChildFormTB.Text = "Thiết bị";
            this.btnChildFormTB.UseVisualStyleBackColor = false;
            this.btnChildFormTB.Click += new System.EventHandler(this.btnChildFormTB_Click);
            // 
            // btnChildFormTBDV
            // 
            this.btnChildFormTBDV.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChildFormTBDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChildFormTBDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormTBDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildFormTBDV.Location = new System.Drawing.Point(151, 3);
            this.btnChildFormTBDV.Name = "btnChildFormTBDV";
            this.btnChildFormTBDV.Size = new System.Drawing.Size(142, 28);
            this.btnChildFormTBDV.TabIndex = 4;
            this.btnChildFormTBDV.Text = "Đơn vị mượn";
            this.btnChildFormTBDV.UseVisualStyleBackColor = false;
            this.btnChildFormTBDV.Click += new System.EventHandler(this.btnChildFormTBDV_Click);
            // 
            // btnChildFormDMTB
            // 
            this.btnChildFormDMTB.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChildFormDMTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChildFormDMTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormDMTB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildFormDMTB.Location = new System.Drawing.Point(299, 3);
            this.btnChildFormDMTB.Name = "btnChildFormDMTB";
            this.btnChildFormDMTB.Size = new System.Drawing.Size(142, 28);
            this.btnChildFormDMTB.TabIndex = 1;
            this.btnChildFormDMTB.Text = "DM Thiết bị";
            this.btnChildFormDMTB.UseVisualStyleBackColor = false;
            this.btnChildFormDMTB.Click += new System.EventHandler(this.btnChildFormDMTB_Click);
            // 
            // btnChildFormQN
            // 
            this.btnChildFormQN.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChildFormQN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChildFormQN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormQN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildFormQN.Location = new System.Drawing.Point(447, 3);
            this.btnChildFormQN.Name = "btnChildFormQN";
            this.btnChildFormQN.Size = new System.Drawing.Size(142, 28);
            this.btnChildFormQN.TabIndex = 1;
            this.btnChildFormQN.Text = "Quân nhân";
            this.btnChildFormQN.UseVisualStyleBackColor = false;
            this.btnChildFormQN.Click += new System.EventHandler(this.btnChildFormQN_Click);
            // 
            // btnChildFormDV
            // 
            this.btnChildFormDV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChildFormDV.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChildFormDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChildFormDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildFormDV.Location = new System.Drawing.Point(595, 3);
            this.btnChildFormDV.Name = "btnChildFormDV";
            this.btnChildFormDV.Size = new System.Drawing.Size(142, 28);
            this.btnChildFormDV.TabIndex = 2;
            this.btnChildFormDV.Text = "Đơn vị";
            this.btnChildFormDV.UseVisualStyleBackColor = false;
            this.btnChildFormDV.Click += new System.EventHandler(this.btnChildFormDV_Click);
            // 
            // btnChildFormTBQN
            // 
            this.btnChildFormTBQN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChildFormTBQN.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChildFormTBQN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChildFormTBQN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormTBQN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildFormTBQN.Location = new System.Drawing.Point(743, 3);
            this.btnChildFormTBQN.Name = "btnChildFormTBQN";
            this.btnChildFormTBQN.Size = new System.Drawing.Size(142, 28);
            this.btnChildFormTBQN.TabIndex = 3;
            this.btnChildFormTBQN.Text = "Cá nhân mượn";
            this.btnChildFormTBQN.UseVisualStyleBackColor = false;
            this.btnChildFormTBQN.Click += new System.EventHandler(this.btnChildFormTBQN_Click);
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
        private System.Windows.Forms.Button btnChildFormTB;
        private System.Windows.Forms.Button btnChildFormQN;
        private System.Windows.Forms.Button btnChildFormDV;
        private System.Windows.Forms.Button btnChildFormTBQN;
        private System.Windows.Forms.Button btnChildFormTBDV;
        private System.Windows.Forms.Button btnChildFormDMTB;
        private System.Windows.Forms.Panel panelDesktopPane;
        private Button Dashboard;
    }
}

