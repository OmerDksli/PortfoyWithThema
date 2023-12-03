

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CV_templateDotNet.Models
{
    public class User
    {
        public int Id { get; set; }

        [Column(TypeName = "nchar(50)")]
        [DisplayName("Kullanıcı Adı")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "En fazla 50, en az 2 karakter")]
        public string UserName { get; set; } = "Admin";

        [Column(TypeName = "nchar(50)")]
        [DisplayName("İsim")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "En fazla 50, en az 3 karakter")]
        public string NameSurname { get; set; } = default!;

        [Column(TypeName = "date")]
        [DisplayName("Doğum tarihi")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Column(TypeName = "char(256)")]
        [DisplayName("E-posta")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(256, MinimumLength = 5, ErrorMessage = "En fazla 256, en az 5 karakter")]
        [EmailAddress(ErrorMessage = "Geçersiz format")]
        public string Email { get; set; }
        
        [DisplayName("Parola")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(128, MinimumLength = 8, ErrorMessage = "En fazla 128, en az 8 karakter")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Column(TypeName = "nchar(200)")]
        [DisplayName("Adres")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "En fazla 200, en az 3 karakter")]
        public string Address { get; set; } = default!;

        [Column(TypeName = "char(10)")]
        [DisplayName("Telefon")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "10 karakter")]
        public  string PhoneNumber { get ; set ; }
        [NotMapped]
        [DisplayName("Resim")]
        public ICollection<IFormFile>? Image { get; set; }

        
        [DisplayName("Profil Resmi")]          
        public ICollection<ImagePath>? ProfilImage { get; set; }
    }
}
