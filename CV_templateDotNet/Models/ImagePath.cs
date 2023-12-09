using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using BussinesLogicLayer;

namespace CV_templateDotNet.Models
{
    public class ImagePath
    {
        //public ImagePath(IFormFile image ,int newWidth, int newHeight)
        //{

        //    ImageCalibration imageCalibration = new();
        //    IFormFile formFile= (IFormFile)imageCalibration.ReSize((Image)image,newWidth,newHeight);
        //    CvImagePath = imageCalibration.ImaheSaveInFileAsync(formFile).Result;
            

        //}
        
        public int Id { get; set; }
        [ForeignKey(nameof(Project))]
        public int? PojectId { get; set; }
        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        public string CvImagePath { get; set; }

        public Project? Project { get; set; }
        public User? User { get; set; }
    }
}
