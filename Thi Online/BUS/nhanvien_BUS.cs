using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class nhanvien_BUS
    {
        public void capnhattrangthai_1(string trangthai,string id)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            dao.capnhattrangthai(trangthai,id);
        }

        public bool checkDuplicate_1(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.checkDuplicate(dto.MaNV);
        }

        public bool themtaikhoan_1(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.themtaikhoan(dto);
        }

        public DataTable loadQuyenhan_1()
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.loadQuyenhan();
        }

        public DataTable loadDonvi_1()
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.loadDonvi();
        }

        public string getNameByID(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.getNameByID(dto.MaNV);
        }
        public string getNameByROLE_1(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.getNameByQUYEN(dto.MaNV);
        }
        public bool kiemtradangnhap_1(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.kiemtradangnhap(dto);
        }

        public void importNhanvien_1(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            dao.importNhanvien(dto.MaNV, dto.Matkhau, dto.Tennhanvien, dto.Quyenhan, dto.Donvi);
        }

        public DataTable danhsachNhanvien_1(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.danhsachNV(dto.MaNV);
        }

        public DataTable danhsachImportNV_1()
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.danhsachImportNV();
        }

        public DataTable DSnhanvien_1()
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.DSnhanvien();
        }

        public bool thaydoimatkhau_1(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.thaydoimatkhau(dto);
        }

        public bool kiemtramatkhau_1(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.kiemtramatkhau(dto);
        }

        public string Encrypt_1(string toEncrypt,bool useHashing)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.Encrypt(toEncrypt,useHashing);
        }

        public bool xoataikhoan_1(nhanvien_DTO dto)
        { 
            nhanvien_DAO dao = new nhanvien_DAO();
            return dao.xoataikhoan(dto);
        }

        public void capnhatnhanvien_1(nhanvien_DTO dto)
        {
            nhanvien_DAO dao = new nhanvien_DAO();
            dao.capnhatnhanvien(dto.MaNV,dto.Matkhau,dto.Tennhanvien,dto.Quyenhan,dto.Donvi);
        }
    }
}
