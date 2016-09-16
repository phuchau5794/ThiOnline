using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class nhanvien_DTO
    {
        private string maNV;
        private string matkhau;
        private string tennhanvien;
        private string donvi;
        private int solanthi;
        private int quyenhan;

        public int Quyenhan
        {
            get { return quyenhan; }
            set { quyenhan = value; }
        }

        public int Solanthi
        {
            get { return solanthi; }
            set { solanthi = value; }
        }

        public string Donvi
        {
            get { return donvi; }
            set { donvi = value; }
        }

        public string Tennhanvien
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
    }
}
