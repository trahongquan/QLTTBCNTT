using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class TBDonvi
    {
        private int idTBDV, idDonvi, idThietbi;
        private string DateBorrow, DateReturn;
        public TBDonvi() { }

        public TBDonvi(/*int idTBDV,*/ int idDonvi, int idThietbi, string dateBorrow, string dateReturn)
        {
            //this.idTBDV = idTBDV;
            this.idDonvi = idDonvi;
            this.idThietbi = idThietbi;
            DateBorrow = dateBorrow;
            DateReturn = dateReturn;
        }

        public int IdTBDV { get => idTBDV; set => idTBDV = value; }
        public int IdDonvi { get => idDonvi; set => idDonvi = value; }
        public int IdThietbi { get => idThietbi; set => idThietbi = value; }
        public string DateBorrow1 { get => DateBorrow; set => DateBorrow = value; }
        public string DateReturn1 { get => DateReturn; set => DateReturn = value; }
    }
}
