using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace Social_Network_API.Services
{
    class ImageUploadService
        {
            private Cloudinary cloudinary;

        public ImageUploadService()
            {
                Account account = new Account("doikwz68x", "942723343131761", "GUkuFeEWYyAhB8zWAxeYPwNKBfI");
                cloudinary = new Cloudinary(account);
            }
        public ImageUploadResult uploadImage(string image)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(@image)
            };

            return cloudinary.Upload(uploadParams);
        }

    }    

}