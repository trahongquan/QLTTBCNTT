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
    public partial class Dashboard : Form
    {
        QueryDashBoard QueryDB = new QueryDashBoard();
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Clear();
            RB_Doi.Checked = true;
        }
        /*private void Reload()
        {
            Clear();
            try
            {
                //dtgvDashboard.DataSource = QueryDB.getDS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        private void Clear()
        {
            txtSearchTenTB.Text = "";
            txtSearchTenQN.Text = "";
            txtSearchDV.Text = "";
        }

        private void btnBRG_DB_Click(object sender, EventArgs e)
        {
            string s = "select TB.TenTB, LTB.loai, QN.Ten, DV.Doi, DV.TieuDoan, DV.LuDoan " +
                            "From DM_ThietBi As TB, DM_LoaiThietBi As LTB, DM_Quannhan As QN, DM_Donvi As DV " +
                            "WHERE TB.idLoaiTB = LTB.IdLoaiTB And TB.idQuannhan = QN.IDQuannhan and TB.idDonvi = DV.IdDonvi ";
            dtgvDashboard.DataSource = QueryDB.getDS(s);
        }

        private void btnTBQN_DB_Click(object sender, EventArgs e)
        {
            string s = "select TB.TenTB, LTB.loai, QN.Ten, DV.Doi, DV.TieuDoan, TBQN.DateBorrow, TBQN.DateReturn " +
                            "From DM_ThietBi As TB, DM_LoaiThietBi As LTB, DM_Quannhan As QN, TB_QN As TBQN, DM_Donvi As DV " +
                            "WHERE TBQN.idThietbi=TB.IdThietBi and TBQN.idQuannhan=QN.IDQuannhan and TB.idLoaiTB=LTB.IdLoaiTB and QN.idDonvi=DV.IdDonvi";
            dtgvDashboard.DataSource = QueryDB.getDS(s);
        }

        private void btnTBDV_DB_Click(object sender, EventArgs e)
        {
            string s = "select TB.TenTB, LTB.loai, DV.Doi, DV.TieuDoan, TBDV.DateBorrow, TBDV.DateReturn " +
                            "From DM_ThietBi As TB, DM_LoaiThietBi As LTB, TB_Donvi As TBDV, DM_Donvi As DV " +
                            "WHERE TBDV.idThietbi=TB.IdThietBi and TBDV.idDonvi=DV.IdDonvi and TB.idLoaiTB=LTB.IdLoaiTB";
            dtgvDashboard.DataSource = QueryDB.getDS(s);
        }

        private void txtSearchTenTB_TextChanged(object sender, EventArgs e)
        {
            dtgvDashboard.DataSource = QueryDB.Search("TenTB",txtSearchTenTB.Text);
        }

        private void txtSearchTenQN_TextChanged(object sender, EventArgs e)
        {
            dtgvDashboard.DataSource = QueryDB.Search("Ten",txtSearchTenQN.Text);
        }

        private void txtSearchDV_TextChanged(object sender, EventArgs e)
        {
            if (RB_Doi.Checked) dtgvDashboard.DataSource = QueryDB.Search("Doi",txtSearchDV.Text);
            if(RB_TieuDoan.Checked) dtgvDashboard.DataSource = QueryDB.Search("TieuDoan", txtSearchDV.Text);
            if(RB_LuDoan.Checked) dtgvDashboard.DataSource = QueryDB.Search("LuDoan", txtSearchDV.Text);
        }
    }
}
