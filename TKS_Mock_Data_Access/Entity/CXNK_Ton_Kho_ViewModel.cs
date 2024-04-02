using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Entity
{
    public class CXNK_Ton_Kho_ViewModel
    {
        private string m_strMa_San_Pham;
        private string m_strTen_San_Pham;
        private long m_lngSL_Dau_Ky;
        private long m_lngSL_Nhap;
        private long m_lngSL_Xuat;
        private long m_lngSL_Cuoi_Ky;
        public CXNK_Ton_Kho_ViewModel()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strTen_San_Pham = CConst.STR_VALUE_NULL;
            m_strMa_San_Pham = CConst.STR_VALUE_NULL;
            m_lngSL_Dau_Ky = CConst.INT_VALUE_NULL;
            m_lngSL_Nhap = CConst.INT_VALUE_NULL;
            m_lngSL_Xuat = CConst.INT_VALUE_NULL;
            m_lngSL_Cuoi_Ky = CConst.INT_VALUE_NULL;
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
        public long SL_Xuat
        {
            get
            {
                return m_lngSL_Xuat;
            }
            set
            {
                m_lngSL_Xuat = value;
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
        public long SL_Dau_Ky
        {
            get
            {
                return m_lngSL_Dau_Ky;
            }
            set
            {
                m_lngSL_Dau_Ky = value;
            }
        }
        public long SL_Cuoi_Ky
        {
            get
            {
                return m_lngSL_Cuoi_Ky;
            }
            set
            {
                m_lngSL_Cuoi_Ky = value;
            }
        }
    }
}
