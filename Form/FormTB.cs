using QLTTBCNTT_WinForm.Object;
using QLTTBCNTT_WinForm.suport;
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
    public partial class FormTB : Form
    {
        QueryTB QueryTB = new QueryTB();
        public FormTB()
        {
            InitializeComponent();
        }

        private void FormTB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet.DM_ThietBi' table. You can move, or remove it, as needed.
            //this.dM_ThietBiTableAdapter.Fill(this.qLTTBCNTTDataSet.DM_ThietBi);
            Reload();
            dtgvTB.Columns[0].HeaderText = "IDTB";
            dtgvTB.Columns[1].HeaderText = "ID Loại";
            dtgvTB.Columns[2].HeaderText = "Tên";
            dtgvTB.Columns[3].HeaderText = "Số Seri";
            dtgvTB.Columns[4].HeaderText = "MAC";
            dtgvTB.Columns[5].HeaderText = "CoreCPU";
            dtgvTB.Columns[6].HeaderText = "RAM";
            dtgvTB.Columns[7].HeaderText = "HardDisk";
            dtgvTB.Columns[8].HeaderText = "Màn hình";
            dtgvTB.Columns[9].HeaderText = "ID cá nhân được biên chế";
            dtgvTB.Columns[10].HeaderText = "ID đơn vị được biên chế";
        }
        #region Button Funcion
        private void AddTB_Click(object sender, EventArgs e)
        {
            if(Input()) {
                QueryTB.Insert(GetDMTB());
                Reload();
                dtgvTB.Refresh();
            }
        }
        private void ModifyTB_Click(object sender, EventArgs e)
        {
            if (dtgvTB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng");
                return;
            }

            DialogResult dlr = new DialogResult();

            dlr = (DialogResult)MessageBox.Show("Sửa đổi thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr.Equals(DialogResult.No))
            {
                return;
            }

            try
            {
                QueryTB.Modify(GetDMTB(), int.Parse(dtgvTB.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelTB_Click(object sender, EventArgs e)
        {
            if (dtgvTB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng");
                return;
            }
            DialogResult dlr = new DialogResult();

            dlr = (DialogResult)MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr.Equals(DialogResult.No))
            {
                return;
            }
            try
            {
                QueryTB.Delete(int.Parse(dtgvTB.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Bổ trợ

        private DMTB GetDMTB()
        {
            int idLTB = int.Parse(cbbIDLTB.Text);
            int idQN = int.Parse(txtQN.Text);
            int idDV = int.Parse(txtDonvi.Text);
            DMTB DMTB = new DMTB(idLTB, idQN, idDV,
                                txtTenTB.Text, txtSeri.Text, txtMAC.Text, txtCoreCPU.Text,
                                cbbRAM.Text, cbbHardDisk.Text, txtMonitor.Text);
            return DMTB;
        }
        private bool Input()
        {
            if (txtTenTB.Text == "" || txtSeri.Text == "" || cbbIDLTB.Text == "") { return false; }
            MessageBox.Show("Bạn cần nhập đủ trường Tên, Seri và Id loại thiết bị");
            return true;
        }
        private void Clear()
        {
            cbbIDLTB.GetItemText(0);
            txtQN.Text = "";
            txtDonvi.Text = "";
            txtTenTB.Text = "";
            txtSeri.Text = "";
            txtMAC.Text = "";
            txtCoreCPU.Text = "";
            cbbRAM.GetItemText(0);
            cbbHardDisk.GetItemText(0);
            txtMonitor.Text = "";
        }

        private void Reload()
        {
            Clear();
            try
            {
                dtgvTB.DataSource = QueryTB.getDS_Thietbi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Display()
        {
            var TB = dtgvTB.SelectedRows[0];
            cbbIDLTB.Text = TB.Cells[1].Value.ToString();
            txtQN.Text = TB.Cells[9].Value.ToString();
            txtDonvi.Text = TB.Cells[10].Value.ToString();
            txtTenTB.Text = TB.Cells[2].Value.ToString();
            txtSeri.Text = TB.Cells[3].Value.ToString();
            txtMAC.Text = TB.Cells[4].Value.ToString();
            txtCoreCPU.Text = TB.Cells[5].Value.ToString();
            cbbRAM.Text = TB.Cells[6].Value.ToString();
            cbbHardDisk.Text = TB.Cells[7].Value.ToString();
            txtMonitor.Text = TB.Cells[8].Value.ToString();
        }

        private void dtgvTB_MouseClick(object sender, MouseEventArgs e)
        {
            Display();
        }

        private void cbbIDLTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string x = cbbIDLTB.Text;
            switch (cbbIDLTB.SelectedItem)
            {
                case "1": txtIDLTB.Text = "Máy chủ";
                    break;
                case "2":
                    txtIDLTB.Text = "Thiết bị mạng";
                    break;
                case "3":txtIDLTB.Text = "Thiết bị bảo đảm kỹ thuật";
                    break;
                case "4":
                    txtIDLTB.Text = "Máy tính để bàn";
                    break;
                case "5":
                    txtIDLTB.Text = "Máy tính xách tay";
                    break;
                case "6":
                    txtIDLTB.Text = "Thiết bị khác";
                    break;
            }
        #endregion

        }


    }
}
