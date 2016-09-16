using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class donvi_DTO
    {
        private string id;
        private string tendonvi;
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Tendonvi
        {
            get { return tendonvi; }
            set { tendonvi = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
