﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BnbProject.Models
{
    public class UserResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public UserAccount User { get; set; }
    }
}
