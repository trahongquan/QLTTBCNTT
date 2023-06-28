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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnTB = new System.Windows.Forms.Button();
            this.btnQN = new System.Windows.Forms.Button();
            this.btnDV = new System.Windows.Forms.Button();
            this.btnTBQN = new System.Windows.Forms.Button();
            this.btnTBDV = new System.Windows.Forms.Button();
            this.btnLTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackgroundImage = global::QLTTBCNTT_WinForm.Properties.Resources.BG;
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktopPane.Location = new System.Drawing.Point(166, 7);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(960, 654);
            this.panelDesktopPane.TabIndex = 1;
            // 
            // btnDB
            // 
            this.btnDB.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDB.Location = new System.Drawing.Point(1, 29);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(159, 82);
            this.btnDB.TabIndex = 2;
            this.btnDB.Text = "Trang chủ";
            this.btnDB.UseVisualStyleBackColor = false;
            this.btnDB.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // btnTB
            // 
            this.btnTB.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTB.Location = new System.Drawing.Point(1, 117);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(159, 82);
            this.btnTB.TabIndex = 3;
            this.btnTB.Text = "Thiết bị";
            this.btnTB.UseVisualStyleBackColor = false;
            this.btnTB.Click += new System.EventHandler(this.btnChildFormTB_Click);
            // 
            // btnQN
            // 
            this.btnQN.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQN.Location = new System.Drawing.Point(1, 205);
            this.btnQN.Name = "btnQN";
            this.btnQN.Size = new System.Drawing.Size(159, 82);
            this.btnQN.TabIndex = 4;
            this.btnQN.Text = "Quân nhân";
            this.btnQN.UseVisualStyleBackColor = false;
            this.btnQN.Click += new System.EventHandler(this.btnChildFormQN_Click);
            // 
            // btnDV
            // 
            this.btnDV.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDV.Location = new System.Drawing.Point(1, 293);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(159, 82);
            this.btnDV.TabIndex = 5;
            this.btnDV.Text = "Đơn vị";
            this.btnDV.UseVisualStyleBackColor = false;
            this.btnDV.Click += new System.EventHandler(this.btnChildFormDV_Click);
            // 
            // btnTBQN
            // 
            this.btnTBQN.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTBQN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTBQN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTBQN.Location = new System.Drawing.Point(1, 381);
            this.btnTBQN.Name = "btnTBQN";
            this.btnTBQN.Size = new System.Drawing.Size(159, 82);
            this.btnTBQN.TabIndex = 6;
            this.btnTBQN.Text = "Quân nhân - Thiết bị";
            this.btnTBQN.UseVisualStyleBackColor = false;
            this.btnTBQN.Click += new System.EventHandler(this.btnChildFormTBQN_Click);
            // 
            // btnTBDV
            // 
            this.btnTBDV.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTBDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTBDV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTBDV.Location = new System.Drawing.Point(1, 469);
            this.btnTBDV.Name = "btnTBDV";
            this.btnTBDV.Size = new System.Drawing.Size(159, 82);
            this.btnTBDV.TabIndex = 7;
            this.btnTBDV.Text = "Đơn vị - Thiết bị";
            this.btnTBDV.UseVisualStyleBackColor = false;
            this.btnTBDV.Click += new System.EventHandler(this.btnChildFormTBDV_Click);
            // 
            // btnLTB
            // 
            this.btnLTB.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLTB.Location = new System.Drawing.Point(1, 557);
            this.btnLTB.Name = "btnLTB";
            this.btnLTB.Size = new System.Drawing.Size(159, 82);
            this.btnLTB.TabIndex = 8;
            this.btnLTB.Text = "Loại thiết bị";
            this.btnLTB.UseVisualStyleBackColor = false;
            this.btnLTB.Click += new System.EventHandler(this.btnChildFormDMTB_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 660);
            this.Controls.Add(this.btnLTB);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.btnTBDV);
            this.Controls.Add(this.btnTB);
            this.Controls.Add(this.btnTBQN);
            this.Controls.Add(this.btnQN);
            this.Controls.Add(this.btnDV);
            this.Controls.Add(this.panelDesktopPane);
            this.Name = "FormMain";
            this.Text = "Quản lý Trang thiết bị CNTT";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktopPane;
        private Button btnDB;
        private Button btnTB;
        private Button btnQN;
        private Button btnDV;
        private Button btnTBQN;
        private Button btnTBDV;
        private Button btnLTB;
    }
}

