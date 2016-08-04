using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Cars.Contracts;
using Cars.Controllers;
using System.Collections.Generic;
using Cars.Models;

namespace CarsControl.Tests.Moq
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sort_ShouldCallSortByYearList_ifbyYearIsSelected()
        {
            var repoMock = new Mock<ICarsRepository>();
            repoMock.Setup(x => x.SortedByYear());

            var controller = new CarsController(repoMock.Object);

            controller.Sort("year");

            Mock.Verify(repoMock);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_ShouldThrowArgumentException_IfCalledWithIncorrectValues()
        {
            var wrongParameter = "I Am Sooo Wrong";

            var controller = new CarsController();

            controller.Sort(wrongParameter);
        }

        [TestMethod]
        public void Sort_ShouldCallSortByMakeList_IfMakeWasSelected()
        {
            var repoMock = new Mock<ICarsRepository>();
            repoMock.Setup(x => x.SortedByMake());

            var controller = new CarsController(repoMock.Object);

            controller.Sort("make");

            Mock.Verify(repoMock);
        }

        [TestMethod]
        public void Sort_ShouldReturnResultProperly_IfProperlyCalled()
        {
            var expected = new List<Car>();

            var repoMock = new Mock<ICarsRepository>();

            repoMock.Setup(x => x.SortedByMake()).Returns(expected);

            var ctroller = new CarsController(repoMock.Object);

            Mock.ReferenceEquals(expected, ctroller.Sort("make").Model);
        }

        [TestMethod]
        public void Sort_ShouldReturnIView_WhenProperlyCalled()
        {
            var repoMock = new Mock<ICarsRepository>();

            var ctroller = new CarsController(repoMock.Object);

            var tested = ctroller.Sort("make");

            Mock.Equals(tested.GetType(), typeof(IView)); 
        }
    }
}
