using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class baithi_BUS
    {
        public void capnhattilebaithi_1(string tile)
        {
            baithi_DAO dao = new baithi_DAO();
            dao.capnhattilebaithi(tile);
        }

        public DataTable loadBaithi_1()
        {
            baithi_DAO dao = new baithi_DAO();
            return dao.loadBaithi();
        }

        public bool luubangdiem(bangdiem_DTO dto)
        {
            baithi_DAO dao = new baithi_DAO();
            return dao.luubangdiem(dto);
        }

        public DataTable xuatbangdiem_1()
        {
            baithi_DAO dao = new baithi_DAO();
            return dao.xuatbangdiem();
        }

        public DataTable loadDetai_1()
        {
            baithi_DAO dao = new baithi_DAO();
            return dao.loadDetai();
        }

        public DataTable loadBaithitheoDT_1(string doituong,int tile)
        {
            baithi_DAO dao = new baithi_DAO();
            return dao.loadBaithitheoDT(doituong,tile);
        }

        public DataTable timkiembangdiem_1(int dieukien, string timkiem)
        {
            baithi_DAO dao = new baithi_DAO();
            return dao.timkiembangdiem(dieukien,timkiem);
        }
    }
}
