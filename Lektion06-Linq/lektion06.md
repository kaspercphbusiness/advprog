# Lambda & Linq
Emnet denne gang er linq, og dermed også lambda udtryk og delegates.

**Opdateret fredag 24 mar: [link til klasse noter](notes.pdf)**

## Forberedelse
Jeg vil foreslå at I som forberedelse arbejder jer gennem denne tutorial: http://www.tutorialsteacher.com/linq/linq-tutorials. Jeg kan specielt godt lide denne site da der er en del eksempler som kan prøves direkte på siden. Det giver mulighed for at prøve små ændringer i eksemplerne.

Der er en del elementer på den side, og der er en næsten endeløs række af operatorer i linq. Jeg vil foreslå at I fokuserer på:

- [`from`](http://www.tutorialsteacher.com/linq/linq-query-syntax), [`where`](http://www.tutorialsteacher.com/linq/linq-filtering-operators-where), [`select`](http://www.tutorialsteacher.com/linq/linq-projection-operators). Læg specielt mærke til den fleksibilitet der er i select operatoren.
- `Sum`, `Count`, `Average`er alle forholdsvis lige til, du kan nøjes med at kikke på [`Sum`](http://www.tutorialsteacher.com/linq/linq-aggregation-operator-sum).
- Sum, Count og Average er eksempler på en mere generel ting der kaldes [Aggregate](http://www.tutorialsteacher.com/linq/linq-aggregation-operator-aggregate). Den er også god at forstå.
- [`groupby`](http://www.tutorialsteacher.com/linq/linq-grouping-operator-groupby-tolookup) er meget kraffuld, men kan være en smule sær indtil man forstår den.

## Plan
Planen for næste onsdag bliver i grove træk

* Gennemgang af hjemme opgave fra sidst
* Linq bygger på lambda udtryk og extension metoder. Det regner jeg med at gennemgå på klassen.
* Linq bygger på "[Deferred execution](http://www.tutorialsteacher.com/linq/linq-deferred-execution)", også kaldet "Lazy execution". Vi skal kort kikke på det også.
* Opgave til næste uge

## Øvelse til næste gang
For at have noget data at arbejde på har jeg fundet [en fil med hushandler i Sacramento området i Californien](Sacramentorealestatetransactions.csv).
>"The Sacramento real estate transactions file is a list of 985 real estate transactions in the Sacramento area reported over a five-day period, as reported by the [Sacramento Bee](http://www.sacbee.com/)." (taget fra: https://support.spatialkey.com/spatialkey-sample-csv-data/)

Du skal skrive et program der gør følgende:

- Læser filen linje for linje.

- Ved hjælp af et regulært udtryk skal du pille by, størrelse pris og ugedag ud for hver linje.

- Lave en metode der returnerer en collection af objekter med disse data.

-	Lave linq queries på denne collection som:
	- returnerer (by, størrelse)
	- returnerer (by, ugedag) for huse der koster under $100.000
	- returnerer det gennemsnitlige antal rum for huse der koster over $300.000.
	- grupperer gennemsnitlig pris og størrelse for hver by

- Lav en metode der ved hjælp af lazy evaluation og yield returnerer objekterne et ad gangen.

Filen der skal læses er snuppet fra https://support.spatialkey.com/spatialkey-sample-csv-data/. 


