using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Mock_Data_Access.Utility;

namespace TKS_Mock_Data_Access.Entity
{
    public class CXNK_Xuat_Kho
    {
        private string m_strSo_Phieu_Xuat_Kho;
        private string m_strKho_ID;
        private string m_strNCC_ID;
        private DateTime? m_dtmNgay_Xuat_Kho;
        private string m_strGhi_Chu;

        public CXNK_Xuat_Kho()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strSo_Phieu_Xuat_Kho = CConst.STR_VALUE_NULL;
            m_strKho_ID = CConst.STR_VALUE_NULL;
            m_strNCC_ID = CConst.STR_VALUE_NULL;
            m_dtmNgay_Xuat_Kho = CConst.DTM_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
        }
        [Required(ErrorMessage = "Số phiếu xuất kho là bắt buộc")]
        public string So_Phieu_Xuat_Kho
        {
            get
            {
                return m_strSo_Phieu_Xuat_Kho;
            }
            set
            {
                m_strSo_Phieu_Xuat_Kho = value.Trim();
            }
        }
        [Required(ErrorMessage = "Kho là bắt buộc")]
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
        [Required(ErrorMessage = "Nhà cung cấp là bắt buộc")]
        public string NCC_ID
        {
            get
            {
                return m_strNCC_ID;
            }
            set
            {
                m_strNCC_ID = value.Trim();
            }
        }

        public DateTime? Ngay_Xuat_Kho
        {
            get
            {
                return m_dtmNgay_Xuat_Kho;
            }
            set
            {
                m_dtmNgay_Xuat_Kho = value;
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
