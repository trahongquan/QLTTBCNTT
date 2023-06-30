using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class Thietbi
    {
        private int idThietbi, idloaiTB, idQuannhan, idDonvi;
        private string TenTB, Seri, MAC, CoreCPU, RAM, HardDisk, Monitor;

        public Thietbi()
        {
        }

        public Thietbi(int idloaiTB, int idDonvi, string tenTB, string seri, string mAC, string coreCPU, string rAM, string hardDisk, string monitor)
        {
            this.idloaiTB = idloaiTB;
            this.idDonvi = idDonvi;
            TenTB = tenTB;
            Seri = seri;
            MAC = mAC;
            CoreCPU = coreCPU;
            RAM = rAM;
            HardDisk = hardDisk;
            Monitor = monitor;
        }

        public Thietbi(int idloaiTB, int idQuannhan, int idDonvi, string tenTB, string seri, string mAC, string coreCPU, string rAM, string hardDisk, string monitor)
        {
            this.idloaiTB = idloaiTB;
            this.idQuannhan = idQuannhan;
            this.idDonvi = idDonvi;
            TenTB = tenTB;
            Seri = seri;
            MAC = mAC;
            CoreCPU = coreCPU;
            RAM = rAM;
            HardDisk = hardDisk;
            Monitor = monitor;
        }

        public int IdThietbi { get => idThietbi; set => idThietbi = value; }
        public int IdloaiTB { get => idloaiTB; set => idloaiTB = value; }
        public int IdQuannhan { get => idQuannhan; set => idQuannhan = value; }
        public int IdDonvi { get => idDonvi; set => idDonvi = value; }
        public string TenTB1 { get => TenTB; set => TenTB = value; }
        public string Seri1 { get => Seri; set => Seri = value; }
        public string MAC1 { get => MAC; set => MAC = value; }
        public string CoreCPU1 { get => CoreCPU; set => CoreCPU = value; }
        public string RAM1 { get => RAM; set => RAM = value; }
        public string HardDisk1 { get => HardDisk; set => HardDisk = value; }
        public string Monitor1 { get => Monitor; set => Monitor = value; }
    }
}
