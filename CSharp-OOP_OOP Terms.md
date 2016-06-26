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
 - abstract method - takiva sa metodite v Interface
 - virtual method - implementiran metod, koito moje da overridenem
* sealed class - ne moje da byde nasledqvan

##### Encapsulation
* Hides implementation details
* Fields encapsulate properties
 - get or set can be private
 - fields are private
 - properties can be public
 - protected property is visible to child only
* Use validation
