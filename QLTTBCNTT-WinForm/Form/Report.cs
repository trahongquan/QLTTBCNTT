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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet5.DM_Donvi' table. You can move, or remove it, as needed.
            this.dM_DonviTableAdapter.Fill(this.qLTTBCNTTDataSet5.DM_Donvi);
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet5.TB_QN' table. You can move, or remove it, as needed.
            this.tB_QNTableAdapter.Fill(this.qLTTBCNTTDataSet5.TB_QN);
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet5.DM_ThietBi' table. You can move, or remove it, as needed.
            this.dM_ThietBiTableAdapter.Fill(this.qLTTBCNTTDataSet5.DM_ThietBi);
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet5.DM_LoaiThietBi' table. You can move, or remove it, as needed.
            this.dM_LoaiThietBiTableAdapter.Fill(this.qLTTBCNTTDataSet5.DM_LoaiThietBi);

            this.reportViewer.RefreshReport();
            
        }
    }
}
