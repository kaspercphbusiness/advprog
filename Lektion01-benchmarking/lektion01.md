# Uge 1 - velkommen & tidstagning
Vi kommer til at bruge de næste gange på algoritmer og deres performance. 
Normalt i datalogien bruger man et matematisk begreb omkring performance for at kunne sammenligne på tværs af computere og hardware. 

Men vi vil til denne lektion specielt se på hvordan man kan måle hvorlang tid det tager at udføre ting på en computer, og hvilke faldgrupper der er i det.

Planen for denne første gang er:

- Intro til kurset
	- Velkommen og kort præsentationsrunde
	- Hvordan er materialet omkring kurset organiseret
	- Software der bruges på kurset
- Tidsmåling - Microbenchmarking
	- Kombination af gennemgang og øvelser
- Opgave til næste gang 

## Forberedelse
- Du skal gerne møde op med din computer sat op til at kunne oversætte og køre C# programmer. 
- Jeg regner med at du har læst noten nedenfor. Jeg vil gennemgå hovedpointerne på klassen, men for at du kan lave øvelserne på klassen vil det være en fordel. Desuden kan jeg svare på spørgsmål du måtte have.

## Læsestof
Det primære læsestof er noten om tidstagning:

- [Microbenchmarks in Java and C#](SestoftMicrobenchmarking.pdf) af Peter Sestoft. De flese eksempler i selve noten er skrevet i Java, men den [vedlagte zip-fil](benchmarks-csharp.zip) er i C#.  

Der er nogle generelle pointer i slutningen af noten det er godt at nå til (**specielt kapitel 7, 8 og 11**), så i *første gennemlæsning* vil jeg foreslå at du springer følgende over:

- afsn 3.5 og 3.6
- kapitel 4, 5 og 6

## Øvelser på klassen
Disse øvelser er lavet som en række spørgsmål vi gerne vil have svar på.

1. Der er nogle der siger at det er for dyrt (tager tid) at bruge et interface i stedet for bare at kalde en metode direkte. Passer det? Tager det længere tid, og hvor meget?

2. Man skal altid prøve at bruge heltal istedet for komma tal fordi de er hurtigere. Specielt er det dyrt at bruge division sammelignet med multiplikation. Er det rigtigt? 

3. Exception handling koster virkelig meget siger nogle. Er det tilfældet? Er det dyrt også hvis der ikke kastes en exception?

## Øvelser til næste gang
Vi kommer senere i semesteret (lektion 4) til at arbejde med grafer og labyrinter. Opgaven til næste gang er en opgave der går ud på at læse labyrinter ind fra en fil. Opgaven har to formål. Dels forventer jeg at I er på et niveau hvor dette ikke burde være et problem, dels skal vi alligevel bruge det senere. Og så er der muligheder for at måle tid på dette. 

Et labyrint er i denne opgave angivet ved en fil der kan se ud som:

```
21x21
+-+-+-+-+-+-+-+-+-+-+
B |   | |     |     |
+ + + + + +-+ + +-+ +
|   |     | | |   | |
+-+-+-+-+-+ + +-+ + +
|     |   | |   | | |
+ +-+ +-+ + + + + + +
| | |     |   |   | |
+ + + +-+-+-+-+ +-+ +
| | |     |   | |   |
+ + +-+-+ + + + + +-+
|   |   |   |   | | |
+-+-+ + +-+-+-+ + + +
|     |     |   |   |
+-+-+ +-+ +-+ + +-+-+
|     |       |   | |
+ +-+-+-+-+-+-+-+ + +
|         |     |   |
+-+-+-+-+ + +-+-+ +-+
|         |         E
+-+-+-+-+-+-+-+-+-+-+
```

Man kan bevæge sig op,ned, højre, venstre. Et +,- og | markerer en væg, mens mellemrum betyder åben. Man starter i B (begin) og slutter i E (end). 
Den første linje siger hvor mange tegn labyrinten er høj og bred. 
(Denne labyrint er lavet med [DJ Delorie's generator](http://www.delorie.com/game-room/mazes/genmaze.cgi)).

#### Hvilke overvejelser gør du dig når du står over for denne opgave?
Prøv at finde et stykke papir frem og skriv ned hvad du skal gøre for at programmere dette. Jeg vil gerne vi diskuterer denne del på klassen næste gang. Det er nødvendigt at du derfor skriver det ned **før** du går i gang med at løse opgaven.

### Tidstagning
Som led i løsningen på denne opgave skal der som minimum løses følgende (der skal meget mere til dog):

1. tallene i den første linje skal laves om fra tekst til heltal (int)
2. der skal allokeres et to dimentionelt array af tegn i passende størrelse

**opg 1.** Prøv at tage tid på disse to dele (konvertering fra tekst til heltal og oprettelse af array).

**opg 2.** Hvordan afhænger array allokeringen af størrelsen på arrayet? 

**opg 3.** Kommer der nogle bemærkelsesværdige ændringer i tidsforbruget når det bliver meget store arrays (når man begynder at allokere nær din computers interne lager størrelse).
