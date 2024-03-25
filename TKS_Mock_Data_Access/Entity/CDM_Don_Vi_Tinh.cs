using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Entity
{
    public class CDM_Don_Vi_Tinh
    {
        private string m_strMa_Don_Vi_Tinh;
        private string m_strTen_Don_Vi_Tinh;
        private string m_strGhi_Chu;

        public CDM_Don_Vi_Tinh()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strMa_Don_Vi_Tinh = CConst.STR_VALUE_NULL;
            m_strTen_Don_Vi_Tinh = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
        }

        [Required(ErrorMessage = "Mã Đơn Vị Tính là bắt buộc")]
        public string Ma_Don_Vi_Tinh
        {
            get
            {
                return m_strMa_Don_Vi_Tinh;
            }
            set
            {
                m_strMa_Don_Vi_Tinh = value.Trim();
            }
        }

        [Required(ErrorMessage = "Tên Đơn Vị Tính là bắt buộc")]
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
