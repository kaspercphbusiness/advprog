# Unit testing
Vi skal her til sidst se på unit-test. 

Vi har i løbet af kurset haft mange mindre main metoder der kalder vores klasser og metoder med lidt forskellige parametre for at overbevise os om at de virker. Det er faktisk så almindeligt at man har systematiseret det og udviklet en metodologi omkring det.

Der er direkte støtte for det i visual studio og vi skal se på hvordan det bruges. 

## Læsestof

* [Unit Testing with the Unit Test Framework](professionalvsts_ch14.pdf). Dette afsnit er lånt fra denne side: [Unit Testing: Ch. 14 of Professional Visual Studio 2005 Team System](http://searchwindevelopment.techtarget.com/tip/Unit-Testing-Ch-14-of-Professional-Visual-Studio-2005-Team-System). 

Dette kapitel er ikke op-to-date med hensyn til visual studio, men er helt fyldset gørende omkring hvad unit test er for noget og hvordan man laver dem. 

Unit test er en teknologi der idag er meget moden og støttes på central vis i alle udviklingsværktøj.

## Kode gennemgået på klassen
Det eksempel jeg snakkede om på klassen var heap klassen (grundlæggende uge2 opgaven). Den [udgave der blev lavet på klassen er denne](https://github.com/cphbusinessAUVidrProg/uge2HeapsKoe/tree/tests).

## Øvelser
I forbindelse med opgaven fra debugging lektionen var der "opstået" en del fejl i koden. Vi vil gerne være sikker på at det ikke sker igen. Vi vil derfor lave nogle tests der kan hjælpe os med at overbevise os om at der ikke er fejl i koden.

### Opgave A
Lav en test klasse med to tests - en test der checker at `isEmpty` metoden virker på et tomt hashing dictionary, og en test der viser at den virker på et ikke tomt dictionary. 

Skal der laves en test der tester for dictionary med både 0, 1, 2, 3,... elementer?

### Opgave B
Lav nogle test der tester for om `get`og `set`virker.

Igen, overvej hvor mange tests du mener er fyldest gørende.

### Opgave C
Som det kan ses i de tests der skrives i opgave A og B, så starter alle de tests med at lave en instans af HashingDictionary. Omstrukturer dine tests så der bruges en `TestInitialize` som beskrevet nederst på side 369 i noten.

### Opgave D
I test drevet udvikling (TDD) som beskrevet på side 359 og frem, er ideen at man skriver test metoder før man laver selve metoden. Som `Get` metoden er lavet nu, så kaster `Get` en exception hvis der ikke er en værdi det element man forsøger at finde. Ideen er at man skal checke med `hasKey` inden man forsøger at sige get:

```csharp
if ( dict.hasKey("Jensen") )
	val = dict.Get("Jensen");
else
	val = -1; // eller en anden standardværdi
```

Man har nogle gange en metode `GetOrDefault(string key, int default)` der returnerer `default` hvis nøglen ikke er der.

Skriv nogle test metoder der chekcer om denne (endnu ikke skrevne) metode virker. Bemærk, for at man kan oversætte dette program skal metoden inkluderes i interfacet `IVPDictionary`. Følg cirklen på side 360 omtil men ikke inkl. "Refactoring"




