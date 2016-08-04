using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Tasker
    {
        private ILogger logger;

        private IIDProvider idprovider;

        public IList<Task> Tasks { get; set; }

        public Tasker(ILogger logger, IIDProvider idprovider)
        {
            this.Tasks = new List<Task>();
            this.logger = logger;
            this.idprovider = idprovider;
        }

        public void Save(Task task)
        {
            task.Id = idprovider.Id;
            this.Tasks.Add(task);
            try
            {
                this.logger.Log(string.Format("Added task {0}!", task.Id));
            }
            catch (ArgumentNullException)
            {
                // Do nothing?
            }
        }

        public void Delete(int id)
        {
            var taskFound = this.Tasks.SingleOrDefault(x => x.Id == id);
            if (taskFound == null)
            {
                this.logger.Log(string.Format("Task with {0} is not found!", id));
                return;
            }

            this.Tasks.Remove(taskFound);
            this.logger.Log(string.Format("Removed task {0}!", id));
        }

        // markDone(task);

        public void AllTasks()
        {
            foreach (var task in this.Tasks)
            {
                this.logger.Log(string.Format("Task [{0}]", task.Id));
            }
        }
    }
}
