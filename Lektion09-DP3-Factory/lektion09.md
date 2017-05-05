# Uge 9 - Creational patterns
Vi har de forrige uger set på design mønstre der omhandler hvordan objekter kommunikerer med hinanden og reagerer på tilstandsændringer. 

Denne uge skal vi se på nogle mønstre der har med objekt skabelse at gøre.

Jeg regner med at vi kommer til at bruge lidt længere tid til at se på den opgave I har arbejdet på de seneste uger.

## Forberedelse & læsestof
The reading for the class is this document which I like because it discusses the tradeoffs of the various patterns, as well as spend some time on why we should use them. 

The examples are in Java, but the key parts in factory patterns is interfaces and plain methods, where C# and Java is rather similar.

http://coding-geek.com/design-pattern-factory-patterns/

(Jeg har lavet en [pdf af den side hvis du er mere til pdf](FactoryPatterns-CodingGeek.pdf))

## Gennemgang på klassen
Jeg har skrevet [en kort note om de tre mønstre](SingletonPrototypeAndFactory.md) jeg regner med at gennemgå på klassen. Jeg regner ikke med at I har læst den inden torsdag (men I skal da være velkomne).

## Øvelser på klassen

### [Vejl. løsninger er lagt op](https://github.com/cphbusinessAUVidrProg/uge9PersonManager).

### Opgave 1
Lad os antage at vi har brug for at lave en klasse der holder øje med hvor mange instanser der er lavet, og som give alle instanser et løbenummer. F.eks. en klasse `Customer`, der har navn, email og telefon, men også et unikt løbenummer. 

Lav en klasse der kan gemme denne information, og som sikrer at alle instanser for deres eget unikke løbenummer. *Hint: der skal bruges en statisk variabel*

Person klassen kan f.eks. bruges fra følgende metode:

```csharp
public void enEllerAndenMetode(){
	Person p = new Person("Hans","hans.jensen@gmail.com", 43109812);
	int idForHans = p.ID; // bør være 1 (da han er første person)
}
```

### Opgave 2 
Udvid med en metode `findFromPhone`der gør at vi kan finde et person med et givet telefon nummer. Dette kræver at vi udvider Person klassen med en *statisk* liste til at gemme alle instanserne i. Her kan brugsscenariet se ud som:

```csharp
public void enEllerAndenMetode(){
	Person p1 = new Person("Hans","hans.jensen@gmail.com", 43109812);
	Person p2 = new Person("Gurli","gurli.ibsen@gmail.com", 72651890);
	Person p3 = new Person("Ali","Ali.Hansen@gmail.com", 21897921);
	
	Person p = Person.findFromPhone(43109812);
}
```

### Opgave 3
Normalt kan man lave mere end en instans af en given klasse. Men nogle gange giver det ikke mening at der er mere end et objekt af en given slags. I opgave 1 og 2 brugte vi statiske metoder og statiske variable til at gemme de aspekter der havde med **alle** objekterne at gøre.

Et sådan klasse kaldes nogle gange for en _manager_ klasse. Og ofte vil det ikke give mening at denne manager klasse har mere end en instans.

Lav en klasse `PersonManager` med en statisk metode `Instance()` der virker som Singleton. 

### Opgave 4
Flyt serienummer og listen fra opgaverne 1 og 2 over som metoder på `PersonManager`. Det vil bla. betyder at hvor man før skrev `new Person()` for at lave et nyt person objekt, så vil man nu skulle skrive `PersonManager.instance().createPerson()` hvor `createPerson()` er metode på PersonManager der skaber en ny Person. Brugsscenariet ændres nu til:

```csharp
public void enEllerAndenMetode(){
	PersonManager pm = PersonManager.instance();
	Person p1 = pm.createPerson("Hans","hans.jensen@gmail.com", 43109812);
	Person p2 = pm.createPerson("Gurli","gurli.ibsen@gmail.com", 72651890);
	Person p3 = pm.createPerson("Ali","Ali.Hansen@gmail.com", 21897921);
	
	Person p = pm.findFromPhone(43109812);
}
```

### Opgave 5
Vores program der arbejder med personer skal nu gøres endnu mere generelt. Vi laver et interface:

```csharp
interface IPersonManager {
	Person createPerson(string name, string email, int phone);
}
```

- Ret brugsscenariet til så det bruger dette interface og ret PersonManager så den implementerer dette interface
- Lav en subklasse af Person - CPHUnderviser, som er en person, men som kun må have emails af formern `navn@cphbusiness.dk`. Lav også en klasse CPHPersonManager der implementerer ovenstående interface, og ret brugsscenariet til.

## Øvelser til næste gang

Færdiggør de opgaver der er ovenfor.



