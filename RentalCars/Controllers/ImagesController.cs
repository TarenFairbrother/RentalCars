using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RentalCars.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {

        private readonly IWebHostEnvironment _env;

        public ImagesController(IWebHostEnvironment env)
        {
            this._env = env;
        }

        [HttpPost]
        public async Task<IActionResult> Post(UploadedFile uploadedFile)
        {
            if (uploadedFile == null || uploadedFile.FileContent.Length == 0)
                return BadRequest("Upload a file");

            string fileName = uploadedFile.FileName;
            string extension = Path.GetExtension(fileName);

            string[] allowedExtensions = { ".jpg", ".png", ".bmp" };

            if (!allowedExtensions.Contains(extension))
                return BadRequest("Upload File is not a valid image");

            string newFileName = $"{Guid.NewGuid()}{extension}";
            string filePath = Path.Combine(_env.WebRootPath, "Images", newFileName);

            var fs = System.IO.File.Create(filePath);
            fs.Write(uploadedFile.FileContent, 0, uploadedFile.FileContent.Length);
            fs.Close();

            return Ok($"Images/{newFileName}");
        }

    }
}
