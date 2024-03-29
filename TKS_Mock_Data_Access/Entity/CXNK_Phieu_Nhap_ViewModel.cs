using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Entity
{
    public class CXNK_Phieu_Nhap_ViewModel
    {
        private long m_lngSTT;
        private string m_strTen_San_Pham;
        private string m_strMa_San_Pham;
        private string m_strTen_Don_Vi_Tinh;
        private long m_lngSL_Nhap;
        private double m_dblDon_Gia_Nhap;
        private string m_dblThanh_Tien;

        public CXNK_Phieu_Nhap_ViewModel()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngSTT = CConst.INT_VALUE_NULL;
            m_strTen_San_Pham = CConst.STR_VALUE_NULL;
            m_strTen_Don_Vi_Tinh = CConst.STR_VALUE_NULL;
            m_strMa_San_Pham = CConst.STR_VALUE_NULL;
            m_lngSL_Nhap = CConst.INT_VALUE_NULL;
            m_dblDon_Gia_Nhap = CConst.FLT_VALUE_NULL;
            m_dblThanh_Tien = CConst.STR_VALUE_NULL;
        }
        public long STT
        {
            get
            {
                return m_lngSTT;
            }
            set
            {
                m_lngSTT = value;
            }
        }
        public string Ten_San_Pham
        {
            get
            {
                return m_strTen_San_Pham;
            }
            set
            {
                m_strTen_San_Pham = value.Trim();
            }
        }

        public string Ma_San_Pham
        {
            get
            {
                return m_strMa_San_Pham;
            }
            set
            {
                m_strMa_San_Pham = value.Trim();
            }
        }
        public string Ten_Don_Vi_Tinh
        {
            get
            {
                return m_strTen_Don_Vi_Tinh;
            }
            set
            {
                m_strTen_Don_Vi_Tinh = value.Trim();
            }
        }
        public long SL_Nhap
        {
            get
            {
                return m_lngSL_Nhap;
            }
            set
            {
                m_lngSL_Nhap = value;
            }
        }

        public double Don_Gia_Nhap
        {
            get
            {
                return m_dblDon_Gia_Nhap;
            }
            set
            {
                m_dblDon_Gia_Nhap = value;
            }
        }
        public string Thanh_Tien
        {
            get
            {
                return m_dblThanh_Tien;
            }
            set
            {
                m_dblThanh_Tien = value.Trim();
            }
        }
    }
}

