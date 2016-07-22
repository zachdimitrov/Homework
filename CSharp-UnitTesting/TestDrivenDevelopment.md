####Zashto da polzvame TDD
- oshte v nachaloto znaem zashto pravim testovete
- ne trqbva da se polzva **NEW**
- nqkoi drug trqbva da instancira obektite i da se pogriji da sa validni

####Code and Test Approach

**Approach steps**
1. Write code
2. Write Unit Test
3. Run and succeed
4. Time flow 

**Steps**

1. Create Test Projects before implementation
 - naprimer class BankTest with empty methods
2. pishem metodite taka kakto shte gi polzvame kato syzdadem bankata
3. opvatqme compilation errors samo kolkoto da se kompilira
4. puskame test i toi garmi zashtoto nqma implementaciq
5. zapochvame da implementirame
6. run tests again - ochakvame  da minat uspeshno
7. ako minat testovete - refaktorirame i optimizirame koda
8. run tests again - final check

*Tova e tehnika, koqto zavisi ot ekipa vkoito se raboti*

**Predimstva**

- avoid rework
- less chance of errors
- pishem coda taka che da zadovoli testa - po fokusirano
- tests will be more comprehencive than when written after code

**Nedostataci**
- otnema vreme
- ne se praktikuva masovo
- ne se skalira dobre, ne znaqt vsichki kak da pishat TDD

####Vidove testove
1. **Clean tests**
- proverqvame pri normalna rabota kak raboti
2. **Dirty tests**
- celta e sami da si scupim koda s nevalidni obekti, null i t.n.

```C#
public class UnitTest1
{
    [TestMethod]
    public void BankToBeInstantiatedProperlyWhenAmmountOfMoneyIsPassed()
    {
        //Arrange
        var capital = 100m;
        var bank = new Bank(initialCapital);
        var expectedValue = initialCapital;
        //Act
        var actualValue = bank.InitialCapital;
        //Assert
        Assert.AreEqual(expectedValue, actualValue);
    }
    [TestMethod]
    public void DepositShouldReturnTheCorrectAmmountOfMoney()
    {
        //Arrange
        var currentCapital = 100m;
        var bank = new Bank(initialCapital)
        var amounToDeposit = 500m;
        var expectedAmmount = currentCapital + amounToDeposit;
        //Act
        bank.Deposit(amounToDeposit);
        //Assert
    }
}
public class Bank
{
    private decimal initialCapital;
    public Bank(decimal initialCapital)
    {
        this.initialCapital = initialCapital;
    }

    private decimal InitialCapital
    {
        get
        {
            return this.initialCapital;
        }
        set
        {

        }
    }
}

```