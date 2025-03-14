using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class DaiLy
    {
        [Key]
        public string MaDaiLy { get; set; } // Mã đại lý là string
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }

        // Khóa ngoại liên kết với HeThongPhanPhoi
        public string MaHTPP { get; set; } // Mã hệ thống phân phối là string
        [ForeignKey("MaHTPP")]
        public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}