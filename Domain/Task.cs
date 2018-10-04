using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Domain
{
    public class Task
    {
        public int Id { get; set; }
        public int? ExternalId { get; set; }
        public int? AnotherExternalId { get; set; }

        public ICollection<UserTask> UserTasks { get; set; }
    }
}
