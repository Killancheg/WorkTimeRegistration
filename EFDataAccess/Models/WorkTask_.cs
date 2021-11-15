using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class WorkTaskList
    {
        public int Id { get; set; }
        public string Ticket { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
