using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Entity
{
    public class CDM_Kho_User
    {
        private string m_strMa_Dang_Nhap;
        private string m_strKho_ID;

        public CDM_Kho_User()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strMa_Dang_Nhap = CConst.STR_VALUE_NULL;
            m_strKho_ID = CConst.STR_VALUE_NULL;
        }

        public string Ma_Dang_Nhap
        {
            get
            {
                return m_strMa_Dang_Nhap;
            }
            set
            {
                m_strMa_Dang_Nhap = value.Trim();
            }
        }

        public string Kho_ID
        {
            get
            {
                return m_strKho_ID;
            }
            set
            {
                m_strKho_ID = value.Trim();
            }
        }
    }
}
