using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKS_Mock_Data_Access.Entity
{
    public class CDM_Don_Vi_Tinh
    {
        [Required(ErrorMessage = "Mã Đơn Vị Tính là bắt buộc")]
        public string Ma_Don_Vi_Tinh { get; set; }

        [Required(ErrorMessage = "Tên Đơn Vị Tính là bắt buộc")]
        public string Ten_Don_Vi_Tinh { get; set; }

        public string Ghi_Chu { get; set; }
    }
}
