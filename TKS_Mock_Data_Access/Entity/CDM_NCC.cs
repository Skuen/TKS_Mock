using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Entity
{
    public class CDM_NCC
    {
        private string m_strMa_NCC;
        private string m_strTen_NCC;
        private string m_strGhi_Chu;

        public CDM_NCC()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strMa_NCC = CConst.STR_VALUE_NULL;
            m_strTen_NCC = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
        }

        [Required(ErrorMessage = "Mã NCC là bắt buộc")]
        public string Ma_NCC
        {
            get
            {
                return m_strMa_NCC;
            }
            set
            {
                m_strMa_NCC = value.Trim();
            }
        }

        [Required(ErrorMessage = "Tên NCC là bắt buộc")]
        public string Ten_NCC
        {
            get
            {
                return m_strTen_NCC;
            }
            set
            {
                m_strTen_NCC = value.Trim();
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
