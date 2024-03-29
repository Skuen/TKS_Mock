using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Entity
{
    public class CXNK_Phieu_Xuat_ViewModel
    {
        private long m_lngSTT;
        private string m_strTen_San_Pham;
        private string m_strMa_San_Pham;
        private string m_strGhi_Chu;
        private long m_lngSL_Xuat;
        private string m_strTen_Don_Vi_Tinh;

        public CXNK_Phieu_Xuat_ViewModel()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngSTT = CConst.INT_VALUE_NULL;
            m_strTen_San_Pham = CConst.STR_VALUE_NULL;
            m_strTen_Don_Vi_Tinh = CConst.STR_VALUE_NULL;
            m_strMa_San_Pham = CConst.STR_VALUE_NULL;
            m_lngSL_Xuat = CConst.INT_VALUE_NULL;
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
        public string Ghi_Chu
        {
            get
            {
                return m_strGhi_Chu;
            }
            set
            {
                m_strGhi_Chu = value.Trim();
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


    }
}

