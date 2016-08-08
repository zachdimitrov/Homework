##Unit Test Basic Principles
- Test all classes
- Test all public methods
- Do not test automatic properties
- All unit tests must pass

##NUnit basics

####Basic NUnit Test Structure
```C#
[TestFixture]
public class ClassToTest.Test
{
  [Test]
  public void MethodToTest_ShouldDoSomething_IfSomethingElse()
  // Arrange
  var someObject = new MainObject();
  // Act
  actualResult = someObject.MethodToTest();
  // Assert
  Assert.AreEqual(expectedResult, actualResult);
}
```
