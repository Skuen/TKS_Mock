using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock
{
    public class CXNK_Nhap_Kho_Raw_Data
    {
        private string m_strNhap_Kho_ID;
        private string m_strSan_Pham_ID;
        private long m_lngSL_Nhap;
        private double m_dblDon_Gia_Nhap;

        public CXNK_Nhap_Kho_Raw_Data()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strNhap_Kho_ID = CConst.STR_VALUE_NULL;
            m_strSan_Pham_ID = CConst.STR_VALUE_NULL;
            m_lngSL_Nhap = CConst.INT_VALUE_NULL;
            m_dblDon_Gia_Nhap = CConst.FLT_VALUE_NULL;
        }

        public string Nhap_Kho_ID
        {
            get
            {
                return m_strNhap_Kho_ID;
            }
            set
            {
                m_strNhap_Kho_ID = value.Trim();
            }
        }

        public string San_Pham_ID
        {
            get
            {
                return m_strSan_Pham_ID;
            }
            set
            {
                m_strSan_Pham_ID = value.Trim();
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
    }
}
