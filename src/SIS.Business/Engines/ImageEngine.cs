using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Newtonsoft.Json;
using RedStarter.Business.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Engines
{
    public class ImageEngine : IImageEngine
    {
        public string UploadImageAndGetUrl(PaintingCreateDTO image)
        {

            Account account = new Account(
                    "paintingproject", //cloud name
                    "373497354299735", //api key
                    "6rt6J94a-ZylEscK5hZf5jLMyhM" //api secret
                );

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(image.Image.FileName, image.Image.OpenReadStream())
            };

            var cloudinary = new Cloudinary(account);
            var uploadResult = cloudinary.Upload(uploadParams);
            var id = uploadResult.JsonObj;
            var data = JsonConvert.DeserializeObject<RawUploadResult>(id.ToString());
            var result = data.SecureUri.ToString();

            return result;

            throw new NotImplementedException();
        }

        public string UpdateImageAndGetUrl(PaintingUpdateDTO image)
        {
            Account account = new Account(
                    "paintingproject", //cloud name
                    "373497354299735", //api key
                    "6rt6J94a-ZylEscK5hZf5jLMyhM" //api secret
                );

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(image.Image.FileName, image.Image.OpenReadStream())
            };

            var cloudinary = new Cloudinary(account);
            var uploadResult = cloudinary.Upload(uploadParams);
            var id = uploadResult.JsonObj;
            var data = JsonConvert.DeserializeObject<RawUploadResult>(id.ToString());
            var result = data.SecureUri.ToString();

            return result;
            throw new NotImplementedException();
        }
    }
}
