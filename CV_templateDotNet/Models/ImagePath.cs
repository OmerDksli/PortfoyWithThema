namespace CV_templateDotNet.Models
{
    public class ImagePath
    {
        public int Id { get; set; }
        public int PojectId { get; set; }

        public string CvImagePath { get; set; }

        public Project Project { get; set; }
    }
}
