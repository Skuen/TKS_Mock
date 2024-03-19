using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Runtime.CompilerServices;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Entity
{
    public class CDM_Loai_San_Pham
    {
        private string m_strMa_LSP;
        private string m_strTen_LSP;
        private string m_strGhi_Chu;

        public CDM_Loai_San_Pham()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strMa_LSP = CConst.STR_VALUE_NULL;
            m_strTen_LSP = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
        }

        public string Ma_LSP
        {
            get
            {
                return m_strMa_LSP;
            }
            set
            {
                m_strMa_LSP = value.Trim();
            }
        }

        public string Ten_LSP
        {
            get
            {
                return m_strTen_LSP;
            }
            set
            {
                m_strTen_LSP = value.Trim();
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
    }
}
