# Uge 2 - Sortering og komplksitet
Vi skal denne gang kikke på sortering og algoritmers kompleksitet.

Men vi skal også bruge lidt tid i begyndelsen af sessionen til at samle op på opgaven fra sidst. Specielt skal vi snakke om hvordan man generelt griber programmeringsopgaver an.

## Forberedelse
### I dag skal vi bruge papir og pen (ud over computer)
Som forberedelse til idag vil jeg foreslå at I kikker på den første af noterne for at prøve at forstå store O notationen før vi mødes. 

Specielt er der et spørgsmål der er nyttigt at have tænkt over - hvorfor er mængden af gange man kan halvere N elementer indtil man kun har et tilbage log<sub>2</sub>(n)?

## Læsestof
- [Store O notation](bigO.md). I stedet for at måle effektivitet i sekunder så har man en matematisk abstraktion som populært kaldes "store O". 

- [Søgning og Sortering](SestoftSortering.pdf) - dette er et meget klassisk emne. Vi kommer til at lægge særlig vægt på algoritmen til Heap sort (kapitel 6). Du kan springe kapitel 5 over i første gennemlæsning. Du burde også finde kapitel 1,3 og 4 nemme at læse.

## Øvelser på klassen
Øvelser på klassen kommer til at blive taget fra øvelserne i Søgning og Sorteringsnoten. Specielt vil vi kikke på:

- 4.10.1-3 - lav den gerne sammen med sidemanden på et papir
- 4.10.4-5 - prøv at lave delopgave 5 med vores timing metode fra sidste gang
- 6.7.1-3

## Øvelser til næste gang
Du skal lave en klasse der kan fungere som heap. I første omgang skal den bare være til heltal, dernæst kikker vi på hvordan den kan fungere med vilkårlige objekter.

**opg 1.**
Antag følgende interface:

```csharp
interface IIntHeap {
	bool isEmpty();
	int size();
	void insert(int element);
	int getTop(); // return and remove top element from heap
}
```
Programmer en klasse der implementerer dette interface ud fra de algoritmer beskrevet i Searching og Sorting noten kapitel 6.5. Du kan godt antage at du får en maks størrelse på heapen med som argument til klassens konstruktør.

**opg 2.**
Lav i stedet et interface og en implementation der bruger `string`istedet for `int`.

**opg 3.**
Benyt dig af teknikkerne fra kapitel 8 til at lave en heap der kan håndtere vilkårlige objekter.
