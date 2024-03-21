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
    public class CDM_Loai_San_Pham
    {
        [Required(ErrorMessage = "Mã Loại Sản Phẩm là bắt buộc")]
        public string Ma_LSP { get; set; }

        [Required(ErrorMessage = "Tên Loại Sản Phẩm là bắt buộc")]
        public string Ten_LSP { get; set; }

        public string Ghi_Chu { get; set; }
    }
}
