using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineRecyclingSystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the OnlineRecyclingSystemUser class
    public class OnlineRecyclingSystemUser : IdentityUser
    {
        [Required]
        [StringLength(30)]
        public string User_Name { get; set; }

        [Required]
        public DateTime User_DOB { get; set; }

        
        [StringLength(100)]
        public string User_Address { get; set; }

        public string User_Role { get; set; }

        


    }
}
