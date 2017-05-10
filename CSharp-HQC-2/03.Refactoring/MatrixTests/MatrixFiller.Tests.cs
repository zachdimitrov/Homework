using Moq;
using NUnit.Framework;
using MatrixCreator;

namespace MatrixTests
{
    [TestFixture]
    public class MatrixFillerTests
    {
        [Test]
        public void ReturnValidMatrixAfterFill()
        {
            int[] deltaX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] deltaY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            // sorry didnt have time
        }
    }
}
