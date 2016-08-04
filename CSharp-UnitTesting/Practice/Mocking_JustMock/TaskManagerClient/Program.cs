using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager;

namespace TaskManagerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new FileLogger();

            var idProvider = new IDProvider();

            var taskManager = new Tasker(consoleLogger, idProvider);

            var task1 = new Task("Kupi hlqb!");

            var task2 = new Task("Izmii kolata!", DateTime.Now.AddDays(2));

            var task3 = new Task("Kupi bira!", DateTime.Now);

            taskManager.Save(task1);
            taskManager.Save(task2);

            taskManager.Delete(2);

            taskManager.Save(task3);
        }
    }
}
