﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JukeBoxMobile.Models
{
   public class BaseModel
    {
        public BaseModel()
        {
        }

        public string Title { get; set; }
        public string Details { get; set; }
        public int Id { get; set; }
    }
}