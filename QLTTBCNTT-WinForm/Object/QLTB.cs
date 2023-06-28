using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class QLTB
    {
        private int idTB;
        private string TenTB, Seri, MAC, CoreCPU, RAM, HardDisk, Monitor, 
            CMTQD, Ten, Capbac, Chucvu, 
            Doi, TieuDoan, LuDoan;

        public QLTB(string tenTB, string seri, string mAC, string coreCPU, string rAM, string hardDisk, string monitor, string cMTQD, string ten, string capbac, string chucvu, string doi, string tieuDoan, string luDoan)
        {
            TenTB = tenTB;
            Seri = seri;
            MAC = mAC;
            CoreCPU = coreCPU;
            RAM = rAM;
            HardDisk = hardDisk;
            Monitor = monitor;
            CMTQD = cMTQD;
            Ten = ten;
            Capbac = capbac;
            Chucvu = chucvu;
            Doi = doi;
            TieuDoan = tieuDoan;
            LuDoan = luDoan;
        }

        public string TenTB1 { get => TenTB; set => TenTB = value; }
        public string Seri1 { get => Seri; set => Seri = value; }
        public string MAC1 { get => MAC; set => MAC = value; }
        public string CoreCPU1 { get => CoreCPU; set => CoreCPU = value; }
        public string RAM1 { get => RAM; set => RAM = value; }
        public string HardDisk1 { get => HardDisk; set => HardDisk = value; }
        public string Monitor1 { get => Monitor; set => Monitor = value; }
        public string CMTQD1 { get => CMTQD; set => CMTQD = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string Capbac1 { get => Capbac; set => Capbac = value; }
        public string Chucvu1 { get => Chucvu; set => Chucvu = value; }
        public string Doi1 { get => Doi; set => Doi = value; }
        public string TieuDoan1 { get => TieuDoan; set => TieuDoan = value; }
        public string LuDoan1 { get => LuDoan; set => LuDoan = value; }
    }
}
