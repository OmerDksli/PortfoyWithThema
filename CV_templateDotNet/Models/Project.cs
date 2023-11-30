using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CV_templateDotNet.Models
{
    public class Project
    {
        [Column(TypeName = "nchar(50)")]
        [DisplayName("İsim")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "En fazla 50, en az 2 karakter")]
        public string ProjectName { get; set; }
        [Column(TypeName = "nchar(200)")]
        [DisplayName("Proje Açıklaması")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "En fazla 200, en az 10 karakter")]
        public string? Description { get; set; } = default;

        [Column(TypeName = "image")]
        [DisplayName("Resim")]
        public ICollection<ImagePath> Image { get; set; }
        [Column(TypeName = "nchar(20)")]
        [DisplayName("Proje Tipi")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "En fazla 20, en az 3 karakter")]
        public string ProjectType { get; set; }
        [Column(TypeName = "nchar(200)")]
        [DisplayName("Kullanılan Teknolojiler")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "En fazla 200, en az 10 karakter")]
        public string UsedTeknologies { get; set; }
        [Column(TypeName = "date")]
        [DisplayName("Bitiş Tarihi")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        public string? GithubUrl { get; set; } = default;
    }
}
