##Unit Test Basic Principles
- Test all classes
- Test all public methods
- Do not test automatic properties
- All unit tests must pass

##Basic Steps To Test
####Test Validator
1. Check if methods throw
2. Check if methods do-not throw if valid arguments are used
####Test Engine
1. 

##NUnit basics
####To Test Internal Methods
- use this code in tested assembly - Properties - AssemblyInfo.cs
```C#
[assembly: InternalsVisibleTo("TestAssemblyName")]
```
####Basic NUnit Test Structure
```C#
[TestFixture]
public class ClassToTest.Test
{
  [Test]
  public void MethodToTest_ShouldDoSomething_IfSomethingElse()
  {
  // Arrange
  var someObject = new MainObject();
  // Act
  actualResult = someObject.MethodToTest();
  // Assert
  Assert.AreEqual(expectedResult, actualResult);
  }
}
```
####Test For Validation and Exceptions Example
```C#
  [Test]
  public void CheckIfNull_WhenObjParamIsNull_ShouldThrowNullReferenceException()
  {
      // Arrange
      object objectToTest = null;
      // Act && Assert
      Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(objectToTest)); 
      // if message is expected: .Message.Contains("Part of text expected")
  }
  // The opposite case
  [Test]
  public void CheckIfNull_WhenObjParamIsValid_ShouldNotThrow()
  {
      // Arrange
      object objectToTest = new object();

      // Act && Assert
      Assert.DoesNotThrow(() => Validator.CheckIfNull(objectToTest));
  }
```     
####Test With Multiple Cases - Parametric Test
```C#
  [TestCase(25, 20)]
  [TestCase(25, 15)]
  [TestCase(20, 20)]
  [TestCase(20, 0)]
  public void CheckIfStringLengthIsValid_WhenTextParamHasValidlenght_ShouldNotThrow(int maxLenght, int minLenght)
  {
      // Arrange
      var exampleString = "20CharactersLongText";
      // Act && Assert
      Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(exampleString, maxLenght, minLenght));
  }
```
####Different Assert Methods Examples
```C#
Assert.IsTrue(engine.Categories.ContainsKey(categoryName));
Assert.AreSame(mockedCategory.Object, engine.Categories[categoryName]);
mockedCategory.Verify(x => x.AddProduct(mockedShampoo.Object), Times.Once);
Assert.IsInstanceOf<ICategory>(executionResult);
Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateShampoo("example", brandParam, 10.0M, GenderType.Men, 100, UsageType.EveryDay));
```
## Moq Basics
####Basic Usage of Moq
- when we use mocked object allways put ```.object``` behind
```C#
// use Interfaces to mock
var mockedFactory = new Mock<ICosmeticsFactory>(); 
// sumulate getter of property
mockedCommand.SetupGet(x => x.Name).Returns("CreateCategory"); 
// simulate execution of method
mockedCommandParser.Setup(p => p.ReadCommands()).Returns(() => new List<ICommand>() { mockedCommand.Object });
