using BlazorInputFile;
using BookStore_UI.Contracts;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_UI.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _env;

        public FileUpload(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void RemoveFile(string picName)
        {
            var path = $"{_env.WebRootPath}\\uploads\\{picName}";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        //public async Task UploadFile(IFileListEntry file, string picName)
        //{
        //    try
        //    {
        //        var ms = new MemoryStream();
        //        await file.Data.CopyToAsync(ms);

        //        var path = $"{_env.WebRootPath}\\uploads\\{picName}";

        //        using (FileStream fs = new FileStream(path, FileMode.Create))
        //        {
        //            ms.WriteTo(fs);
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        throw;
        //    }
        //}

        //public void UploadFile(IFileListEntry file, MemoryStream msFile, string picName)
        //{
        //    try
        //    {
        //        var path = $"{_env.WebRootPath}\\uploads\\{picName}";

        //        using (FileStream fs = new FileStream(path, FileMode.Create))
        //        {
        //            msFile.WriteTo(fs);
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}
        public async Task UploadFile(Stream msFile, string picName)
        {
            try
            {
                var path = $"{_env.WebRootPath}\\uploads\\{picName}";
                var buffer = new byte[4 * 1096];
                int byteRead;
                double totalRead = 0;
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    while((byteRead=await msFile.ReadAsync(buffer)) != 0){
                        totalRead += byteRead;
                        await fs.WriteAsync(buffer);
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }   
}
