using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Extentions
{
    public static class IFormFileExtension
    {
        public static bool IsImage(this IFormFile Image)
        {
            return Image == null || Image.ContentType.Contains("image/") || Image.Length / 1024 / 1024 > 2;


        }
        public async static Task<string> Save(this IFormFile file, IHostingEnvironment env, string folder)
        {
            string filename = Guid.NewGuid().ToString() + file.FileName;
            string resultpath = Path.Combine(env.WebRootPath, folder, filename);
            using (FileStream stream = new FileStream(resultpath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filename;
        }
        public static bool ImageHasFile(this string filename, string folder,IHostingEnvironment env)
        {
            return System.IO.File.Exists(Path.Combine(env.WebRootPath, folder,filename));
            
        }
        public static void DeleteImage(this string filename, IHostingEnvironment env, string folder)
        {
            System.IO.File.Delete(Path.Combine(env.WebRootPath, folder, filename));
        }
        
   
    }
}

