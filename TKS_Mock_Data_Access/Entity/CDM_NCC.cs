using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKS_Mock_Data_Access.Entity
{
    public class CDM_NCC
    {
        [Required(ErrorMessage = "Mã NCC là bắt buộc")]
        public string Ma_NCC { get; set; }

        [Required(ErrorMessage = "Tên NCC là bắt buộc")]
        public string Ten_NCC { get; set; }

        public string Ghi_Chu { get; set; }
    }
}
