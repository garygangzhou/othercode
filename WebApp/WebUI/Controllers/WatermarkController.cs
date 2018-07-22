using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.HtmlHelpers;

namespace WebUI.Controllers
{
    public class WatermarkController : Controller
    {
        private static string ImagesDirectory = @"C:\Temp\pictures\cat.JPG";
        public WatermarkedImageResult GetImage1(string fileName) {
            // For security, only allow image files from a specific directory
            // var fullPath = Path.Combine(ImagesDirectory, Path.GetFileName(fileName));
            var fullPath = ImagesDirectory;
            string watermarkText = "The time is " + DateTime.Now.ToShortTimeString();
            return new WatermarkedImageResult(fullPath, watermarkText);
        }

        public ViewResult GetImage() {
            return View();
        }
    }
}
