using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_templateDotNet.Models
{
    public class Skill
    {
        public int Id { get; set; }
        [Column(TypeName = "nchar(50)")]
        [DisplayName("Yetenek Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "En fazla 50, en az 2 karakter")]
        public string Name { get; set; }
        [DisplayName("Yetenek Seviyesi")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Range(0, 100, ErrorMessage = "0 - 100 arası yetenek seviyesi")]
        public byte SkillLevel { get; set; }
    }
}
