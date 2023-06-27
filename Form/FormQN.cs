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
    public partial class FormQN : Form
    {
        QueryQuannhan QueryQN = new QueryQuannhan();
        public FormQN()
        {
            InitializeComponent();
        }

        private void FormQN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet1.DM_Donvi' table. You can move, or remove it, as needed.
            //this.dM_DonviTableAdapter.Fill(this.qLTTBCNTTDataSet1.DM_Donvi);

            Reload();
            dtgvQN.Columns[0].HeaderText = "IDQN";
            dtgvQN.Columns[1].HeaderText = "CMTQĐ";
            dtgvQN.Columns[2].HeaderText = "Tên";
            dtgvQN.Columns[3].HeaderText = "Cấp bậc";
            dtgvQN.Columns[4].HeaderText = "Chức vụ";
            dtgvQN.Columns[5].HeaderText = "ID Đơn vị";
        }

        #region Button Funcion
        private void AddQN_Click(object sender, EventArgs e)
        {
            if (Input())
            {
                QueryQN.Insert(GetQN());
                Reload();
                dtgvQN.Refresh();
            }
        }
        private void ModifyQN_Click(object sender, EventArgs e)
        {
            if (dtgvQN.SelectedRows.Count == 0)
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
                QueryQN.Modify(GetQN(), int.Parse(dtgvQN.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelQN_Click(object sender, EventArgs e)
        {
            if (dtgvQN.SelectedRows.Count == 0)
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
                QueryQN.Delete(int.Parse(dtgvQN.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Bổ trợ

        private Quannhan GetQN()
        {
            int idDV = int.Parse(cbbDonvi.Text);
            Quannhan QN = new Quannhan(txtCMTQD.Text, txtTen.Text, cbbCapbac.Text, cbbChucvu.Text, idDV);
            return QN;
        }
        private bool Input()
        {
            if (txtCMTQD.Text == "" || txtTen.Text == "" || cbbCapbac.Text == "" || cbbChucvu.Text == "" || cbbDonvi.Text == "") { return false; }
            MessageBox.Show("Bạn cần nhập đủ các trường");
            return true;
        }
        private void Clear()
        {
            txtCMTQD.Text = "";
            txtTen.Text = "";
            txtDonvi.Text = "";
            cbbCapbac.GetItemText(0);
            cbbChucvu.GetItemText(0);
            cbbDonvi.GetItemText(0);
        }

        private void Reload()
        {
            Clear();
            try
            {
                dtgvQN.DataSource = QueryQN.getDS_Quannhan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Display()
        {
            var QN = dtgvQN.SelectedRows[0];
            txtCMTQD.Text = QN.Cells[1].Value.ToString();
            txtTen.Text = QN.Cells[2].Value.ToString();
            cbbCapbac.Text = QN.Cells[3].Value.ToString();
            cbbChucvu.Text = QN.Cells[4].Value.ToString();
            cbbDonvi.Text = QN.Cells[5].Value.ToString();
        }

        private void dtgvQN_MouseClick(object sender, MouseEventArgs e)
        {
            Display();
        }

        private void cbbDonvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string x = cbbIDLTB.Text;
            switch (cbbDonvi.SelectedItem)
            {
                case "1":
                    txtDonvi.Text = "Đội 1, Tiều đoàn 1, Lữ đoàn 1";
                    break;
                case "2":
                    txtDonvi.Text = "Đội 2, Tiều đoàn 1, Lữ đoàn 1";
                    break;
                case "3":
                    txtDonvi.Text = "Đội 3, Tiều đoàn 1, Lữ đoàn 1";
                    break;
                case "4":
                    txtDonvi.Text = "Đội 4, Tiều đoàn 2, Lữ đoàn 1";
                    break;
                case "5":
                    txtDonvi.Text = "Đội 5, Tiều đoàn 2, Lữ đoàn 1";
                    break;
                case "6":
                    txtDonvi.Text = "Đội 6, Tiều đoàn 2, Lữ đoàn 1";
                    break;
                case "7":
                    txtDonvi.Text = "Đội 7, Tiều đoàn 3, Lữ đoàn 1";
                    break;
                case "8":
                    txtDonvi.Text = "Đội 8, Tiều đoàn 3, Lữ đoàn 1";
                    break;
                case "9":
                    txtDonvi.Text = "Đội 9, Tiều đoàn 3, Lữ đoàn 1";
                    break;
                case "10":
                    txtDonvi.Text = "Tiều đoàn 1, Lữ đoàn 1";
                    break;
                case "11":
                    txtDonvi.Text = "Tiều đoàn 2, Lữ đoàn 1";
                    break;
                case "12":
                    txtDonvi.Text = "Tiều đoàn 3, Lữ đoàn 1";
                    break;
                case "13":
                    txtDonvi.Text = "Lữ đoàn 1";
                    break;
            }
            #endregion
        }
    }
}
