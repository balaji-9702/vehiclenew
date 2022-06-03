using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTIWEBAPPDEMO.Models
{
    [Table("VehicleType")]
    public class VehicleType
    {
        [key]
        public int Id { get; set; }
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public String Type { get; set; }

        public Vehicle Vehicle { get; set; }
      



    }
}
