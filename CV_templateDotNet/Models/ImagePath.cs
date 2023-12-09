using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using BussinesLogicLayer;

namespace CV_templateDotNet.Models
{
    public class ImagePath
    {
        public ImagePath(IFormFile formFile)
        {
            
            ImageCalibration imageCalibration = new();
            
            CvImagePath = imageCalibration.ImageSaveInFileAsync(formFile).Result;


        }
        public ImagePath()
        {

        }

        public int Id { get; set; }
        [ForeignKey(nameof(Project))]
        public int? PojectId { get; set; }
        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        public string CvImagePath { get; set; }
        [DisplayName("Resim Dosyası")]
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public Project? Project { get; set; }
        public User? User { get; set; }
    }
}
