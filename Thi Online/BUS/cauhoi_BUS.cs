using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class cauhoi_BUS
    {
        public bool xoacauhoi_1(string id)
        {
            cauhoi_DAO dao = new cauhoi_DAO();
            return dao.xoacauhoi(id);

        }

        public DataTable timkiemcauhoi_1(cauhoi_DTO dto)
        {
            cauhoi_DAO dao = new cauhoi_DAO();
            return dao.timkiemcauhoi(dto.Id);
        }

        public bool themcauhoi_1(cauhoi_DTO dto)
        {
            cauhoi_DAO dao = new cauhoi_DAO();
            return dao.themcauhoi(dto);
        }

        public void importCauhoi_1(cauhoi_DTO dto)
        {
            cauhoi_DAO dao = new cauhoi_DAO();
            dao.importCauhoi(dto.Id, dto.Phanloai, dto.Doituong, dto.Noidung, dto.Dapan1, dto.Dapan2, dto.Dapan3, dto.Dapan4, dto.Dapandung);
        }

        public DataTable danhsachCH_1(cauhoi_DTO dto)
        {
            DataTable table = new DataTable();
            cauhoi_DAO dao = new cauhoi_DAO();
            return table = dao.danhsachCH(dto.Id);
        }

        public DataTable danhsachimport_1()
        {
            DataTable table = new DataTable();
            cauhoi_DAO dao = new cauhoi_DAO();
            return table = dao.danhsachimport();
        }

        public DataTable dsphanloai_1()
        {
            cauhoi_DAO dao = new cauhoi_DAO();
            return dao.dsphanloai();
        }

        public DataTable dsdoituong_1()
        {
            cauhoi_DAO dao = new cauhoi_DAO();
            return dao.dsdoituong();
        }
    }
}
