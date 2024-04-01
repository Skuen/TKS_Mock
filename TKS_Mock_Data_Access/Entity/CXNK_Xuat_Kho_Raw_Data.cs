using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock
{
    public class CXNK_Xuat_Kho_Raw_Data
    {
        private string m_strXuat_Kho_ID;
        private string m_strSan_Pham_ID;
        private long m_lngSL_Xuat;
        private double m_dblDon_Gia_Xuat;

        public CXNK_Xuat_Kho_Raw_Data()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strXuat_Kho_ID = CConst.STR_VALUE_NULL;
            m_strSan_Pham_ID = CConst.STR_VALUE_NULL;
            m_lngSL_Xuat = CConst.INT_VALUE_NULL;
            m_dblDon_Gia_Xuat = CConst.FLT_VALUE_NULL;
        }

        public string Xuat_Kho_ID
        {
            get
            {
                return m_strXuat_Kho_ID;
            }
            set
            {
                m_strXuat_Kho_ID = value.Trim();
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

        public double Don_Gia_Xuat
        {
            get
            {
                return m_dblDon_Gia_Xuat;
            }
            set
            {
                m_dblDon_Gia_Xuat = value;
            }
        }
    }
}
