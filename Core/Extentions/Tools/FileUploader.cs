using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extentions.Tools
{
    public static class FileUploader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">wwwroot/Resource/UploadedImages/CategoryImages/</param>
        /// <param name="formFile">IFormFile Model</param>
        /// <returns></returns>
        public static string UploadImage(string path, IFormFile formFile)
        {
            var fileExtention = Path.GetExtension(formFile.FileName);
            var ImageNewName = Guid.NewGuid()+fileExtention;
            var UploadedPath = Path.Combine(Directory.GetCurrentDirectory(),
                path+ImageNewName);
            var stream = new FileStream(UploadedPath, FileMode.Create);
            formFile.CopyTo(stream);
            path=String.Empty;
            formFile=null;
            return ImageNewName;
        }
    }
}
