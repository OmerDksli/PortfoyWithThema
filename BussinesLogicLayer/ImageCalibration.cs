
using Microsoft.AspNetCore.Http;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BussinesLogicLayer
{
    public class ImageCalibration
    {
        public Image ReSize(Image originalImage, int newWidth, int newHeight)
        {
            Graphics graphicsHandle;
            double targetRatio = (double)newWidth / (double)newHeight;
            double newRatio = (double)originalImage.Width / (double)originalImage.Height;
            int targetWidth = newWidth;
            int targetHeight = newHeight;
            int newOriginX = 0;
            int newOriginY = 0;
            Image newImage = new Bitmap(newWidth, newHeight);

            if (newRatio > targetRatio)
            {
                targetWidth = (int)(originalImage.Width / ((double)originalImage.Height / newHeight));
                newOriginX = (newWidth - targetWidth) / 2;
            }
            else
            {
                if (newRatio < targetRatio)
                {
                    targetHeight = (int)(originalImage.Height / ((double)originalImage.Width / newWidth));
                    newOriginY = (newHeight - targetHeight) / 2;
                }
            }
            graphicsHandle = Graphics.FromImage(newImage);
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphicsHandle.CompositingQuality = CompositingQuality.HighQuality;
            graphicsHandle.SmoothingMode = SmoothingMode.HighQuality;
            graphicsHandle.DrawImage(originalImage, newOriginX, newOriginY, targetWidth, targetHeight);
            return newImage;
        }
        #region Bu dosya içerisine gelen resim dosyası işlemlerden geçerek kaydedilir
        public async Task<string> ImaheSaveInFileAsync(IFormFile image )
        {
            

            string imageExtension = Path.GetExtension(image.FileName);
            string imageName = Guid.NewGuid() + imageExtension;
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");
            using var stream = new FileStream(path, FileMode.Create);
            await image.CopyToAsync(stream);
            return $"images/{imageName}";


        }
        #endregion
    }
}
