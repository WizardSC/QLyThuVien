﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class DocGiaBLL
    {
        private DocGiaDAL dgDAL;

        public DocGiaBLL()
        {
            dgDAL = new DocGiaDAL();
        }

        public DataTable GetListDocGia()
        {
            return dgDAL.getListDocGia();
        }

        public bool InsertDocGia(DocGiaDTO docGia)
        {
            return dgDAL.insertDocGia(docGia);
        }

        public bool UpdateDocGia(DocGiaDTO docGia)
        {
            return dgDAL.updateDocGia(docGia);
        }

        public bool DeleteDocGia(int maDocGia, out bool isForeignKey)
        {
            return dgDAL.DeleteDocGia(maDocGia, out isForeignKey);
        }
    }
}
