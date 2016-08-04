using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class TaskManager
    {
        int count;
        ICollection<Task> tasks = new List<Task>();

        public int TasksCount
        {
            get
            {
                return this.count;
            }
        }

        public void AddTask(Task task)
        {
            this.tasks.Add(task);
            count++;
        }
    }
}
