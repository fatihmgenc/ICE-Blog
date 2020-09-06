using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace IComputerEngineer.Data.FileManager
{
    public class FileManager:IFileManager
    {
        private string _imagePath;

        public FileManager(IConfiguration configuration)
        {
            _imagePath = configuration["Path:Images"];
        }

        public async Task<string> SaveImage(IFormFile image)
        {
            try
            {

            var savePath = Path.Combine(_imagePath);
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            var mime = image.FileName.Substring(image.FileName.LastIndexOf("."));
            var fileName = $"img_{DateTime.Now.ToString("dd/MM/yy")}{mime}";
            using (var fileSteam = new FileStream(Path.Combine(savePath,fileName),FileMode.Create))
            {
                await image.CopyToAsync(fileSteam);
            }
            return fileName;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return "Error";
            }
        }
    }
}
