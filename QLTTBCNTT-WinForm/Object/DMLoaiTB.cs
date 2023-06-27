using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class DMLoaiTB
    {
        private int idLoaiTB;
        private string loai1, loai2, loai3, loai4, loai5, loai6;

        public DMLoaiTB()
        {
        }

        public DMLoaiTB(string loai1, string loai2, string loai3, string loai4, string loai5, string loai6)
        {
            this.loai1 = loai1;
            this.loai2 = loai2;
            this.loai3 = loai3;
            this.loai4 = loai4;
            this.loai5 = loai5;
            this.loai6 = loai6;
        }

        public DMLoaiTB(int idLoaiTB, string loai1, string loai2, string loai3, string loai4, string loai5, string loai6)
        {
            this.idLoaiTB = idLoaiTB;
            this.loai1 = loai1;
            this.loai2 = loai2;
            this.loai3 = loai3;
            this.loai4 = loai4;
            this.loai5 = loai5;
            this.loai6 = loai6;
        }

        public int IdLoaiTB { get => idLoaiTB; set => idLoaiTB = value; }
        public string Loai1 { get => loai1; set => loai1 = value; }
        public string Loai2 { get => loai2; set => loai2 = value; }
        public string Loai3 { get => loai3; set => loai3 = value; }
        public string Loai4 { get => loai4; set => loai4 = value; }
        public string Loai5 { get => loai5; set => loai5 = value; }
        public string Loai6 { get => loai6; set => loai6 = value; }
    }
}
