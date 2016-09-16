using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class phanloai_BUS
    {
        public void themphanloai_1(phanloai_DTO dto)
        {
            phanloai_DAO dao = new phanloai_DAO();
            dao.themphanloai(dto.Maphanloai, dto.Tenphanloai);
        }
    }
}
