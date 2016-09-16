using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class bangdiem_DTO
    {
        private string id;
        private string tennhanvien;
        private DateTime ngaythi;
        private float tongdiem;
        private string loaibaithi;

        public string Loaibaithi
        {
            get { return loaibaithi; }
            set { loaibaithi = value; }
        }

        public float Tongdiem
        {
            get { return tongdiem; }
            set { tongdiem = value; }
        }

        public DateTime Ngaythi
        {
            get { return ngaythi; }
            set { ngaythi = value; }
        }

        public string Tennhanvien
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
    }
}
