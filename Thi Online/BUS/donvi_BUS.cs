using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class donvi_BUS
    {
        public void importDonvi_1( donvi_DTO dto)
        {
            donvi_DAO dao = new donvi_DAO();
            dao.importDonvi(dto.Id,dto.Tendonvi,dto.Diachi);
        }

        public DataTable dsDonviTheoID_1(donvi_DTO dto)
        {
            donvi_DAO dao = new donvi_DAO();
            return dao.dsDonviTheoID(dto.Id);
        }

        public DataTable dsDonvi_1()
        {
            donvi_DAO dao = new donvi_DAO();
            return dao.dsImportDonvi();
        }

        public void capnhatDonvi_1(donvi_DTO dto)
        {
            donvi_DAO dao = new donvi_DAO();
            dao.capnhatDonvi(dto.Id,dto.Tendonvi,dto.Diachi);
        }

        public bool checkDuplicate_1(donvi_DTO dto)
        {
            donvi_DAO dao = new donvi_DAO();
            return dao.checkDuplicate(dto.Id);
        }
    }
}
