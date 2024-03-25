using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Runtime.CompilerServices;
using TKS_Mock_Data_Access.Utility;
using System.ComponentModel.DataAnnotations;

namespace TKS_Mock_Data_Access.Entity
{
    public class CDM_Kho
    {
        private string m_strMa_Kho;
        private string m_strTen_Kho;
        private string m_strGhi_Chu;

        public CDM_Kho()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strMa_Kho = CConst.STR_VALUE_NULL;
            m_strTen_Kho = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
        }

        [Required(ErrorMessage = "Mã Kho là bắt buộc")]
        public string Ma_Kho
        {
            get
            {
                return m_strMa_Kho;
            }
            set
            {
                m_strMa_Kho = value.Trim();
            }
        }

        [Required(ErrorMessage = "Tên Kho là bắt buộc")]
        public string Ten_Kho
        {
            get
            {
                return m_strTen_Kho;
            }
            set
            {
                m_strTen_Kho = value.Trim();
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
