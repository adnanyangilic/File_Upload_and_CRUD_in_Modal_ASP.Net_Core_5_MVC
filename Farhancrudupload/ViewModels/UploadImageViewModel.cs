﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Farhancrudupload.ViewModels
{
    public class UploadImageViewModel 
    {

        [Display(Name = "Picture")]
        public IFormFile SpeakerPicture { get; set; }
    }
}
