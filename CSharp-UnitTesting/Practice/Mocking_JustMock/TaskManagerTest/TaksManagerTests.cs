using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager;
using Moq;
using System.Collections.Generic;

namespace TaskManagerTest
{
    [TestClass]
    public class TaksManagerTests
    {
        [TestMethod]
        public void TestTaskManagerWhenAddTaskShouldCallLog()
        {
            var mockedLogger = new MockedConsoleLogger();
            var mockedIDProvider = new MockedIDProvider();
            var taskManager = new Tasker(mockedLogger, mockedIDProvider);

            var task = new Task("");

            taskManager.Save(task);

            Assert.IsTrue(mockedLogger.IsLogCalled);
        }

        [TestMethod]
        public void WithMock_TestTaskManagerWhenAddTaskShouldCallLog()
        {
            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIDProvider>();
            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            mockedLogger.Setup(x => x.Log(It.IsAny<string>()));

            var task = new Task("");

            taskManager.Save(task);

            mockedLogger.Verify();
        }


        [TestMethod]
        public void WithMock_TestTaskManagerWhenAllTasksCalled_ShouldCallLogTasksCount()
        {
            IList<Task> tasks = new List<Task>()
            {
                new Task("task1"),
                new Task("task2"),
                new Task("task3"),
                new Task("task4")
            };

            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIDProvider>();
            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            taskManager.Tasks = tasks;

            var task = new Task("");

            taskManager.AllTasks();

            mockedLogger.Verify(x => x.Log(It.IsAny<string>()), Times.Exactly(taskManager.Tasks.Count));
        }

        [TestMethod]
        public void WithMock_TestTaskManagerWhenNullAdded_ShouldThrow()
        {
            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIDProvider>();

            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            mockedLogger.Setup(x => x.Log(It.IsAny<string>())).Throws<ArgumentNullException>();

            var task = new Task("");

            taskManager.Save(task);

            mockedLogger.Verify();
        }

        [TestMethod]
        public void WithMock_TestTaskManagerWhenSavedShouldCallIDProvider()
        {
            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIDProvider>();
            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            mockedIdProvider.Setup(x => x.Id).Returns(1);

            var task = new Task("");

            taskManager.Save(task);

            mockedIdProvider.Verify();
        }
    }

    public class MockedConsoleLogger : ILogger
    {
        public bool IsLogCalled;

        public void Log(string msg)
        {
            this.IsLogCalled = true;
        }
    }

    public class MockedIDProvider : IIDProvider
    {
        public int Id
        {
            get
            {
                return 1;
            }
        }
    }
}
