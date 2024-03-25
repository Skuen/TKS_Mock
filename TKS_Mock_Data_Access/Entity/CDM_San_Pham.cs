using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKS_Mock_Data_Access.Entity
{
    public class CDM_San_Pham
    {
        [Required(ErrorMessage = "Mã Sản Phẩm là bắt buộc")]
        public string Ma_San_Pham { get; set; }
        [Required(ErrorMessage = "Tên Sản Phẩm là bắt buộc")]
        public string Ten_San_Pham { get; set; }
        [Required(ErrorMessage = "Loại Sản Phẩm là bắt buộc")]
        public string Loai_San_Pham_ID { get; set; }
        [Required(ErrorMessage = "Đơn Vị Tính là bắt buộc")]
        public string Don_Vi_Tinh_ID { get; set; }
        public string Ghi_Chu { get; set; }  
    }
}
