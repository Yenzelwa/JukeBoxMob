using JukeBoxMobile.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JukeBoxMobile.Models.Response
{
    
        public class BaseResponse<T> where T : class
        {
            public T ResponseObject { get; set; }

            public string ResponseMessage { get; set; }

            public ResponseType ResponseType { get; set; }
        }
    
}
