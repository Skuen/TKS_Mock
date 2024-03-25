using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Entity
{
    public class CDM_San_Pham
    {
        private string m_strMa_San_Pham;
        private string m_strTen_San_Pham;
        private string m_strLoai_San_Pham_ID;
        private string m_strDon_Vi_Tinh_ID;
        private string m_strGhi_Chu;

        public CDM_San_Pham()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strMa_San_Pham = CConst.STR_VALUE_NULL;
            m_strTen_San_Pham = CConst.STR_VALUE_NULL;
            m_strLoai_San_Pham_ID = CConst.STR_VALUE_NULL;
            m_strDon_Vi_Tinh_ID = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
        }
        [Required(ErrorMessage = "Mã Sản Phẩm là bắt buộc")]
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
        [Required(ErrorMessage = "Tên Sản Phẩm là bắt buộc")]
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

        [Required(ErrorMessage = "Loại Sản Phẩm là bắt buộc")]
        public string Loai_San_Pham_ID
        {
            get
            {
                return m_strLoai_San_Pham_ID;
            }
            set
            {
                m_strLoai_San_Pham_ID = value.Trim();
            }
        }

        [Required(ErrorMessage = "Đơn Vị Tính là bắt buộc")]
        public string Don_Vi_Tinh_ID
        {
            get
            {
                return m_strDon_Vi_Tinh_ID;
            }
            set
            {
                m_strDon_Vi_Tinh_ID = value.Trim();
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
