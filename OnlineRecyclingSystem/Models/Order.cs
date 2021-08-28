using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRecyclingSystem.Models
{
    public class Order
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string OrderTime { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Customer Name")]
        public string CusName { get; set; }

        [Required]
        [Phone]
        [StringLength(11)]
        [Display(Name = "Customer Contact")]
        public string CusContact { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Customer Address")]
        public string CusAddress { get; set; }

        [Range(0, 1000, ErrorMessage = "Must be in the range of 0 to 1000")]
        public string BigBottle { get; set; }
        [Range(0, 1000, ErrorMessage = "Must be in the range of 0 to 1000")]
        public string SmallBottle { get; set; }
        [Range(0, 1000, ErrorMessage = "Must be in the range of 0 to 1000")]
        public string Can { get; set; }

        public string DriverName { get; set; }

        public string DriverContact { get; set; }

        public string OrderStatus { get; set; }



    }
}
