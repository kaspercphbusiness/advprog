# Design by contract & arv
Vi vil se på nogle mere generelle kriterier for design af klasser og hvordan de arbejder sammen. Det er noget lidt mere teoretisk stof, og der vil ikke som sådan være programmeringsøvelser.

## Læsestof

http://se.ethz.ch/~meyer/publications/computer/contract.pdf

Der er skrevet meget i tidens løb, men dette er den oprindelige artikkel af Bertrand Meyer. Den kommer ind på både pre og post betingelser, klasse invarianter, arv og exceptions. Hvis I forstår **alt** i denne artikel så er I bedre kørende end de fleste.

## Torsdag
Jeg regner med at gennemgå og forklare artiklen i C# termer. Specielt vil jeg forklare nogle noget overraskende konsekvenser for arv.

## Øvelser
### Delopgave A
Opskriv pre og post betingelser for metoderne i `GoodHeap.cs` [i denne kode](https://github.com/cphbusinessAUVidrProg/uge10Debug02).

### Delopgave B
Opstil en klasse invariant for GoodHeap klassen fra opgave A.

### Delopgave C
Prøv at se om du kan finde hvor dette program vil fejle og hvorfor:

```csharp
    class Program    {        static void Main(string[] args)        {            Person p = new Person();            Kunde k = new Kunde();            Person[] parr = new Person[] { p };            Kunde[] karr = new Kunde[] { k };            parr = karr;            parr[0] = new Tyv();            Console.WriteLine(karr[0].GetType().Name);        }    }    class Person { }    class Kunde : Person { }    class Tyv : Person { }
```

Du kan også springe lidt over og prøve at køre det, og så give en forklaring på hvorfor programmet fejler der hvor det sker.
