﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRecyclingSystem.Models
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
