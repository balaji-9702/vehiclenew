using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LTIWEBAPPDEMO.Models;

namespace LTIWEBAPPDEMO.Data
{
    public class LTIWEBAPPDEMOContext : DbContext
    {
        public LTIWEBAPPDEMOContext (DbContextOptions<LTIWEBAPPDEMOContext> options)
            : base(options)
        {
        }

        public DbSet<LTIWEBAPPDEMO.Models.Vehicle> Vehicles { get; set; }

        public DbSet<LTIWEBAPPDEMO.Models.VehicleType> VehicleTypes { get; set; }
    }
}
