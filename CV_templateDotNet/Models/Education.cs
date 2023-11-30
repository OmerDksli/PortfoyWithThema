using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CV_templateDotNet.Models
{
    public class Education
    {
        public int Id { get; set; }
        [Column(TypeName = "nchar(50)")]
        [DisplayName("Okul Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "En fazla 50, en az 2 karakter")]
        public string SchoolName { get; set; }
        [Column(TypeName = "nchar(50)")]
        [DisplayName("Lisans seviyesi (önlisans, lisans, yükseklisans)")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "En fazla 50, en az 2 karakter")]
        public string Degree { get; set; }
        [Column(TypeName = "nchar(200)")]
        [DisplayName("Okul ve bölüm açıklaması")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "En fazla 200, en az 10 karakter")]
        public string SchoolDescription { get; set; }
        [Column(TypeName = "nchar(200)")]
        [DisplayName("Okuduğu bölüm")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "En fazla 200, en az 10 karakter")]
        public string FieldOfStudy { get; set; }
        [Column(TypeName = "date")]
        [DisplayName("Mezuniyet Tarihi")]
        [DataType(DataType.Date)]
        public DateTime GraduationYear { get; set; }
    }
}
