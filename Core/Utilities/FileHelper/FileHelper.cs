using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string AddAsync(IFormFile file)
        {
            var result = newPath(file);
            try
            {
                var source = Path.GetTempFileName();
                if (file.Length > 0)
                {
                    using (var stream = new FileStream(source, FileMode.Create)) file.CopyTo(stream);
                    File.Move(source, result.newPath);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return result.path;
        }



        public static (string newPath, string path) newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;

            var creatingUniqueFilename = Guid.NewGuid().ToString()
               + "_" + DateTime.Now.Month + "_"
               + DateTime.Now.Day + "_"
               + DateTime.Now.Year + fileExtension;


            string path = Environment.CurrentDirectory + @"\wwwroot\Images";

            string result = $@"{path}\{creatingUniqueFilename}";

            return (result, $"\\Images\\{creatingUniqueFilename}");
        }

        public static IResult DeleteAsync(string oldpath)
        {
            try
            {
                File.Delete(oldpath);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }

        public static string UpdateAsync(string oldpath, IFormFile file)
        {
            var result = newPath(file);

            try
            {
                if (oldpath.Length > 0)
                {
                    using (var stream = new FileStream(result.newPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

                File.Delete(oldpath);
            }
            catch (Exception excepiton)
            {
                return excepiton.Message;
            }

            return result.path;
        }
    }
}

