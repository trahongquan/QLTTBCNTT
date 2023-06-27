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
    public partial class FormTBDV : Form
    {
        public FormTBDV()
        {
            InitializeComponent();
        }
        QueryTBDonvi QueryTBDV = new QueryTBDonvi();

        private void FormTBDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet_TBDV_IDTB.DM_ThietBi' table. You can move, or remove it, as needed.
            this.dM_ThietBiTableAdapter.Fill(this.qLTTBCNTTDataSet_TBDV_IDTB.DM_ThietBi);
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet2.DM_Donvi' table. You can move, or remove it, as needed.
            this.dM_DonviTableAdapter.Fill(this.qLTTBCNTTDataSet2.DM_Donvi);
            Reload();
            dtgvTBDV.Columns[0].HeaderText = "IDTBDV";
            dtgvTBDV.Columns[1].HeaderText = "ID Đơn vị";
            dtgvTBDV.Columns[2].HeaderText = "ID Thiết bị";
            dtgvTBDV.Columns[3].HeaderText = "Ngày biên chế";
            dtgvTBDV.Columns[4].HeaderText = "Ngày trả biên chế";

        }

        #region Button Funcion
        private void AddTBDV_Click(object sender, EventArgs e)
        {
            if (Input())
            {
                QueryTBDV.Insert(GetTBDV());
                Reload();
                dtgvTBDV.Refresh();
            }
        }
        private void ModifyTBDV_Click(object sender, EventArgs e)
        {
            if (dtgvTBDV.SelectedRows.Count == 0)
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
                QueryTBDV.Modify(GetTBDV(), int.Parse(dtgvTBDV.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelTBDV_Click(object sender, EventArgs e)
        {
            if (dtgvTBDV.SelectedRows.Count == 0)
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
                QueryTBDV.Delete(int.Parse(dtgvTBDV.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Bổ trợ

        private TBDonvi GetTBDV()
        {
            int idDV = int.Parse(cbbIDDV.Text);
            int idTB = int.Parse(cbbIDTB.Text);
            TBDonvi TBDV = new TBDonvi(idDV, idTB, DateBorrow.Value.ToString(), DateReturn.Value.ToString());
            return TBDV;
        }
        private bool Input()
        {
            if (cbbIDDV.Text == "" || cbbIDTB.Text == "")
            {
                MessageBox.Show("Không được để trống trường đơn vị và thiết bị");
                return false;
            }
            return true;
        }
        private void Clear()
        {
            txtDV.Text = "";
            cbbIDDV.Text = "";
            txtTB.Text = "";
            cbbIDTB.Text = "";
            txtSearchTBDV.Text = "";
        }

        private void Reload()
        {
            Clear();
            try
            {
                dtgvTBDV.DataSource = QueryTBDV.getDS_TBDonvi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Display()
        {
            var TBDV = dtgvTBDV.SelectedRows[0];
            cbbIDDV.Text = TBDV.Cells[1].Value.ToString();
            cbbIDTB.Text = TBDV.Cells[2].Value.ToString();
            DateBorrow.Value = Convert.ToDateTime(TBDV.Cells[3].Value.ToString());
            DateReturn.Value = Convert.ToDateTime(TBDV.Cells[4].Value.ToString());
        }

        private void dtgvTBDV_MouseClick(object sender, MouseEventArgs e)
        {
            Display();
        }
        private void ccbidDV_TextChanged(object sender, EventArgs e)
        {
            if (cbbIDDV.Text != "") txtDV.Text = QueryTBDV.getTBDV_idDV(cbbIDDV.Text);
        }

        private void cbbidTB_TextChanged(object sender, EventArgs e)
        {
            if (cbbIDTB.Text != "") txtTB.Text = QueryTBDV.getTBDV_idTB(cbbIDTB.Text);
        }

        #endregion


        
    }
}
