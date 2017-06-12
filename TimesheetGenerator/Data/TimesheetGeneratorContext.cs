using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TimesheetGenerator.Models
{
    public class TimesheetGeneratorContext : DbContext
    {
        public TimesheetGeneratorContext (DbContextOptions<TimesheetGeneratorContext> options)
            : base(options)
        {
        }

        public DbSet<TimesheetGenerator.Models.Timesheet> Timesheet { get; set; }
    }
}
