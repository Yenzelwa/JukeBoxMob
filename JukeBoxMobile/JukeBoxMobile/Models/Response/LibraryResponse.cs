using System;
using System.Collections.Generic;
using System.Text;

namespace JukeBoxMobile.Models.Response
{
   public class LibraryResponse
    {
        public Library ResponseObject { get; set; }
        public int ResponseType { get; set; }
        public string ResponseMessage { get; set; }
    }
}
