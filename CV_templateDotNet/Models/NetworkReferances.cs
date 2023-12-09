using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CV_templateDotNet.Models
{
    public class NetworkReferances
    {
        public int Id { get; set; }

        [Column(TypeName = "nchar(50)")]
        [DisplayName("Mesleki Ünvan")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "En fazla 50, en az 3 karakter")]
        public string? Title { get; set; }

        
        [Column(TypeName = "nchar(50)")]
        [DisplayName("İsim")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "En fazla 50, en az 3 karakter")]
        public string Name { get; set; }

        [Column(TypeName = "char(10)")]
        [DisplayName("Telefon")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "10 karakter")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "char(256)")]
        [DisplayName("E-posta")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(256, MinimumLength = 5, ErrorMessage = "En fazla 256, en az 5 karakter")]
        [EmailAddress(ErrorMessage = "Geçersiz format")]
        public string Email { get; set; }

    }
}
