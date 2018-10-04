using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ExternalId {get; set; }

        public ICollection<UserTask> UserTasks { get; set; }
    }
}
