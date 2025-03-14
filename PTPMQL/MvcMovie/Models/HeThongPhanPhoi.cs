using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public string MaHTPP { get; set; } // Mã hệ thống phân phối là string
        public string TenHeThong { get; set; }
        public string MoTa { get; set; }

        // Danh sách các đại lý thuộc hệ thống phân phối này
        public ICollection<DaiLy> DaiLys { get; set; }
    }
}