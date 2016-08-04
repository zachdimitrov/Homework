using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// using NUnit.Framework;

namespace TaskManager.Tests
{
    /*
    [TestFixture]
    public class TaskManagerTests
    {
    */

    [TestClass]
    public class TaskManagerTests
    {
        [TestMethod]
        public void AddingNewTask_ShouldProperly_UpdateCount()
        {
            // Arrange
            var taskManager = new TaskManager();
            // Act
            taskManager.AddTask(new Task());
            // Assert
            Assert.AreEqual(1, taskManager.TasksCount, string.Format("TasksCount is {0} whitch is incorrect!", taskManager.TasksCount));
        }

        /*
    [Test]
        public void AddingNewTaskShouldProperlyUpdateCount()
        {
            // Arrange
            var taskManager = new TaskManager();
            // Act
            taskManager.AddTask(new Task());
            // Assert
            Assert.AreEqual(taskManager.TasksCount, 1);
        }
    }
    */
    }
}
