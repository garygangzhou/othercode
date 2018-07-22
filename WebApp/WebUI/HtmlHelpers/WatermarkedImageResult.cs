using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.HtmlHelpers {
    
    //custom ActionResult
    //add water mark to a picture
    public class WatermarkedImageResult : ActionResult {

        public string ImageFileName { get; private set; }
        public string WatermarkText { get; private set; }
        public WatermarkedImageResult(string imageFileName, string watermarkText) {
            ImageFileName = imageFileName;
            WatermarkText = watermarkText;
        }
        public override void ExecuteResult(ControllerContext context) {
            using (var image = Image.FromFile(ImageFileName))
            using (var graphics = Graphics.FromImage(image))
            using (var font = new Font("Arial", 10))
            using (var memoryStream = new MemoryStream()) {
                // Render the watermark text in bottom-left corner
                var textSize = graphics.MeasureString(WatermarkText, font);
                graphics.DrawString(WatermarkText, font, Brushes.Red , 10, image.Height - textSize.Height - 10);
                
                // Transmit the image in PNG format (note: must buffer it in
                // memory first due to GDI+ limitation)
                image.Save(memoryStream, ImageFormat.Png);
                var response = context.RequestContext.HttpContext.Response;
                response.ContentType = "image/png";
                response.BinaryWrite(memoryStream.GetBuffer());
            }
        }
    }
}
