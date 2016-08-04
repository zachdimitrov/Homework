using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Task
    {
        public Task(string description, DateTime? deadline = null)
        {
            this.Description = description;
            this.DeadLine = deadline;
            this.IsDone = false;
        }
        

        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime? DeadLine { get; set; }

        public bool IsDone { get; set; }
    }
}
