#### OOP Principles
1. Encapsulation - da ne se razreshava da se polzvat izlishno chasti ot programata, zatova se polzvat access midifiers
2. Abstraction - da razdelqme golemite problemi na po-malki
3. Polymorphism - one name, many forms (overloads)
4. Inheritence - reuse code, never duplicate

##### Defining class
classes have:  
* attributes - fields, constants, properties    
* behavior - methods, operations
* inherit - ```class cat:animal``` pod-klasa nasledqva properties i methods ot bazoviq
vsichki klasove nasledqvat ```object```

##### elements of a class
* fields - pazqt dannite za obekta
* constants - konkretni stoinosti
* methods - deistviq, koito obekta izvyrshva
* properties - systoqniq na obekta
* indexers - dobavqt [index] 
* events - sybitiq, koito se izvikvat s delegati
* operators - izpolzvane na operatorite kato +, - i t.n. za obektite
* constructors - shablon za syzdavane na obekta
* destructors - ne se izpolzvat, po-dobre ```IDisposable, using```
* inner types - inner classes, structures, interfaces, delegates - ```Action```

##### members of classes can have access modifiers (scope)
* public - vijda se ot vsichki
* private - vijdat se samo v clasa
* protected - vijdat se samo v clasa ili negovi naslednici
* internal - vijdat se v klasa i naslednicite no samo v prilojenieto po koeto rabotim
* protected internal - samo v tekushtoto assembly i naslednicite na klasa

##### members of classes can be
* static - statichnite se dostypvat samo prez klasa
* instance - bez da pishem nishto, polzva se po-chesto

##### constructor
* empty - default constructor moje da se vzeme (chain) drug konstruktor s :
* constructor with parameters

##### properties - moje da se validirat dannite predi da se zapishat
* Read-only - get
* Write-only - set
* Read and write - get, set  
``` public string breed { get; set; }``` zamestva i poleto i property-to

##### Enumerations - promenlivata moje da ima samo konkretni stoinosti
* enumeraciqta e sealed class sys static poleta

##### Abstraction
- Otdelqme vajnite svoistva na obektite

* struct - ne moje da byde nasledqvano
* static class - syzdava statichen klas koito ne moje d ase instancira
* abstract class - podobno na interface, no moje da ima implementirani metodi - ne moje da se instancira
 - abstract method - takiva sa metodite v Interface, zadyljitelno trqbva da implementirame, nqma tqlo
 - virtual method - implementiran metod, koito moje da overridenem, moje da ne se implementira
* sealed class - ne moje da byde nasledqvan

##### Encapsulation
* Hides implementation details
* Fields encapsulate properties
 - get or set can be private
 - fields are private
 - properties can be public
 - protected property is visible to child only
* Use validation

##### Polymorphism
* vyzmojnost edin obekt da ima poveche ot edna forma i da byde ot mnogo tipove
* vikame vyzmojno nai bazoviq tip - intreface
* naslednicite mogat da prezapisvat metodi na bazovite klsove - metoda trqbva da e virtual
* kogato v konstruktor vikame metodi, toi ne trqbva da e virtualen

##### Exception
* Nasledqvame : ApplicationException

##### Cohesion (strong is good)
* za kolko neshta se griji edin class - po-malko po-dobre
* class utilities losha coheziq - dobre e dori da ima mnogo metodi te da se grijat za edin tip neshta

##### Coupling (loose is good)
* Promqnata v edin klas da ne pravi problemi v drugi klasove
* law of Demeter
* Primerno ako trqbva da smenqme neshto da ne se nalaga da pipame oshte 5 neshta
* Vseki klas razchita na svoite parametri

### Common Type System
##### idea of CTS
* nqkolko ezika, koito da moje da rabotqt po edin i syshti nachin v .NET
 - koda se kompilira do drug vid ezik - IL- koito e obsht
 - izpolzvat edni i syshti tipove danni koito se razbirat ot CLR
 - ILSpy - dekompilira exe file - moje da vidim krainiq product
 - OS -> CLR -> BCL -> DataTier -> WCF and WWF -> UI (ASP.NET, WF, WPF, Win)
* BCL - osnovni instrumenti
* DataTer - bazi danni, nie gi dostypvame chres bibliotekite ADO.NET, EF, LINQ, XML
* WCF and WWF - komunikaciqta mejdu dannite i usera
* UI - izpolzvat se razlichnite tehnologii da web, mobile, desktop...
 - Unity 3D
 - Xamarin
