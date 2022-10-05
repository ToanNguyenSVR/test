﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSoccers.Service.Models.Payload.ImageFolder
{
    public class ImageFolderCreatePayload
    {
        public int FieldId { get; set; }

        [StringLength(200)]
        public string Path { get; set; }
    }
}
