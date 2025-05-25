using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class PhotoUploadResult
    {
        public required string PublicId {get; set; }
        public required string Url { get; set; }
    }
}