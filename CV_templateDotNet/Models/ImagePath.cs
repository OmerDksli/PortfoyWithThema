using System.ComponentModel.DataAnnotations.Schema;

namespace CV_templateDotNet.Models
{
    public class ImagePath
    {
        public int Id { get; set; }
        public int? PojectId { get; set; }
        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        public string CvImagePath { get; set; }

        public Project? Project { get; set; }
        public User? User { get; set; }
    }
}
