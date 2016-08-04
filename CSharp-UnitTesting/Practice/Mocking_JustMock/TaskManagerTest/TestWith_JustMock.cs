
using Telerik.JustMock;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager;
using System.Collections.Generic;

namespace TaskManagerTest
{
    [TestClass]
    public class TestWith_JustMock
    {
        [TestMethod]
        public void With_JustMock_TestTaskManagerWhenAllTasksCalled_ShouldCallLogTasksCount()
        {
            // Arrange
            var mockedLogger = Mock.Create<ILogger>();
            var mockedIdProvider = Mock.Create<IIDProvider>();

            //Mock.Arrange(() => mockedLogger.Log(Arg.AnyString)).Occurs(1);

            var taskManager = new Tasker(mockedLogger, mockedIdProvider);

            var mockedTask = Mock.Create<Task>();
            // Act
            taskManager.Save(mockedTask);

            // Asserd
            Mock.Assert(() => mockedLogger.Log(Arg.AnyString), Occurs.Exactly(1));
        }
    }
}
