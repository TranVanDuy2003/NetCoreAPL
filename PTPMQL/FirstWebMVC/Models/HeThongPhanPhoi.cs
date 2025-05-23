using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirstWebMVC.Models
{
    public class HeThongPhanPhoi
    {   
        [Key]
        public string MaHTPP { get; set; } 
        public string TenHTPP { get; set; } 

        // Quan hệ 1-n với Đại Lý (DaiLy)
        public ICollection<DaiLy> DaiLys { get; set; }
    }
}
