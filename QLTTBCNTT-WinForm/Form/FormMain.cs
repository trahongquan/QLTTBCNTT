using QLTTBCNTT_WinForm.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTBCNTT_WinForm
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        private Button currentButton;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    //DisnableButton();
                    //Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    //currentButton.BackColor = Color.Pink;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            //this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #region button header
        private void btnChildFormTB_Click(object sender, EventArgs e)
        {
            FormTB FormTB = new FormTB();
            OpenChildForm(FormTB, sender);
        }

        private void btnChildFormQN_Click(object sender, EventArgs e)
        {
            FormQN FormQN = new FormQN();
            OpenChildForm(FormQN, sender);
        }

        private void btnChildFormTBDV_Click(object sender, EventArgs e)
        {
            FormTBDV FormTBDV = new FormTBDV();
            OpenChildForm(FormTBDV, sender);
        }

        private void btnChildFormDMTB_Click(object sender, EventArgs e)
        {
            //Không làm
        }

        private void btnChildFormDV_Click(object sender, EventArgs e)
        {
            FormDV FormDV = new FormDV();
            OpenChildForm(FormDV, sender);
        }

        private void btnChildFormTBQN_Click(object sender, EventArgs e)
        {
            FormTBQN FormTBQN = new FormTBQN();
            OpenChildForm(FormTBQN, sender);
        }
        #endregion
    }
}
