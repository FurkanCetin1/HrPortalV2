using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HrPortalV2.Web.Models
{
public class FileHelpers
    {
        public static async Task<string> ProcessFormFile(IFormFile formFile, 
            ModelStateDictionary modelState)
        {
            var fieldDisplayName = "Fotoğraf";

            // Use Path.GetFileName to obtain the file name, which will
            // strip any path information passed as part of the
            // FileName property. HtmlEncode the result in case it must 
            // be returned in an error message.
            var fileName = WebUtility.HtmlEncode(
                Path.GetFileName(formFile.FileName));

            if (formFile.ContentType.ToLower() != "image/jpeg")
            {
                modelState.AddModelError(formFile.Name, 
                    $"{fieldDisplayName} dosyası ({fileName}) JPEG resmi olmalıdır.");
            }

            // Check the file length and don't bother attempting to
            // read it if the file contains no content. This check
            // doesn't catch files that only have a BOM as their
            // content, so a content length check is made later after 
            // reading the file's content to catch a file that only
            // contains a BOM.
            if (formFile.Length == 0)
            {
                modelState.AddModelError(formFile.Name, 
                    $"{fieldDisplayName} dosyası ({fileName}) boş.");
            }
            else if (formFile.Length > 1048576)
            {
                modelState.AddModelError(formFile.Name, 
                    $"{fieldDisplayName} dosyası ({fileName}) 1 MB büyüklüğünü aşıyor.");
            }
            else
            {
                try
                {
                    string fileContents;

                    // The StreamReader is created to read files that are UTF-8 encoded. 
                    // If uploads require some other encoding, provide the encoding in the 
                    // using statement. To change to 32-bit encoding, change 
                    // new UTF8Encoding(...) to new UTF32Encoding().
                    using (
                        var reader = 
                            new StreamReader(
                                formFile.OpenReadStream(), 
                                new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, 
                                    throwOnInvalidBytes: true), 
                                detectEncodingFromByteOrderMarks: true))
                    {
                        fileContents = await reader.ReadToEndAsync();

                        // Check the content length in case the file's only
                        // content was a BOM and the content is actually
                        // empty after removing the BOM.
                        if (fileContents.Length > 0)
                        {
                            return fileContents;
                        }
                        else
                        {
                            modelState.AddModelError(formFile.Name, 
                                $"{fieldDisplayName} dosyası ({fileName}) boş.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    modelState.AddModelError(formFile.Name, 
                        $"{fieldDisplayName} dosyası ({fileName}) yüklemesi başarısız oldu. " +
                        $"Lütfen destek birimimize başvurun. Hata: {ex.Message}");
                    // Log the exception
                }
            }

            return string.Empty;
        }
    }
} 