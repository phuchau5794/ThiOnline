using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class phanloai_DTO
    {
        private string maphanloai;
        private string tenphanloai;

        public string Tenphanloai
        {
            get { return tenphanloai; }
            set { tenphanloai = value; }
        }

        public string Maphanloai
        {
            get { return maphanloai; }
            set { maphanloai = value; }
        }
    }
}
