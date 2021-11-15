using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFDataAccess.Models;

namespace EFDataAccess.DataAccess
{
    public class TimeManagementContext : DbContext
    {
        public TimeManagementContext(DbContextOptions options): base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<WorkTaskList> TaskLists { get; set; }
        public DbSet<WorkTask> Tasks { get; set; }
    }
}
