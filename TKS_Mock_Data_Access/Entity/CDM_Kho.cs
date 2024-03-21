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
        [Required(ErrorMessage = "Mã Kho là bắt buộc")]
        public string Ma_Kho { get; set; }

        [Required(ErrorMessage = "Tên Kho là bắt buộc")]
        public string Ten_Kho { get; set; }

        public string Ghi_Chu { get; set; }
    }
}
