# Runtime & debugging
Vi skal i denne lektion se på debugging - med specielt fokus på hvilke værkøj visual studio stiller til rådighed for at finde fejl.

Alle debuggere forudsætter en vist kendskab til hvordan computeren organiserer et kørende program, og derfor skal vi kort se på dette også.

Specielt er det vigtigt at få fat på følgende begreber

* Stackframe
* Heap vs. stack
* this nøgleordet
* returnering fra metoder

Det er disse begreber der er de centrale for at kunne forstå de centrale værktøj i en debugger.

De centrale funktioner i en debugger er

* break-points
* stepping
* inspektion af tilstand

## Læsestof & forberedelse


### Runtime organisering
Som nævnt ovenfor, så er dette et klassisk emne. Jeg finder at denne pdf forklarer de centrale begreber, og (når man springer C++ delene over) er kort og kontant.

* [Object Oriented Memory Management](object-oriented-memory-management-java-c++edited.pdf)

Der findes en meget kompakt fremstilling af hele C#. Det er ikke en lærerbog, men et opslagsværk, og er meget anbefalelsesværdig. _C# precisely ved Peter Sestoft and Henrik I. Hansen. Udgivet på MIT, 2004 og 2011._
Jeg har snuppet [kapitel 11 fra 2004 udgaven (2 sider)](CSharpPreciselyExtract.pdf) som på meget få sider siger næsten det samme som den lange ovenfor.

### Debugging
Der er nogle gode hands-on sider om debuggeren i visual studio.

* [Visual Studio 2015](https://msdn.microsoft.com/en-us/library/mt243867.aspx) forklaringen starter med et simpelt eksempel. 
* [Visual Studio 2017](https://docs.microsoft.com/en-us/visualstudio/debugger/debugger-basics) starter ud med et eksempel der er kompleks nok til at man har brug for en debugger.

Begge sider har en afsnit inddeling i venstre side. Jeg vil foreslå at I kikker på 

* Getting started with the Debugger
* Navigating through Code with the Debugger
* Using Breakpoints

Der er så et underafsnit "Debugger windows" som mere er reference til de enkelte værktøj.

Ud over det basale, så er der en række ting som er mere specialiserede:

* Betingede breakpoints
* Break points ved exceptions
* Immediate værktøjet

## Torsdag
Jeg regner med at jeg kort vil lave en gennemgang af hvordan programmer ser ud på runtime, og så gennemgå et debugging scenarie.

Min plan er at vi prøver at debugge vores heap sort algoritme og vores HashMap klasse. Så får vi genopfrisket dem ved samme lejlighed.

Der er et ret interessant værktøj på hjemmesiden "http://pythontutor.com" (som også har java, men ikke C#). Det viser i animeret udgave det med runtime. Vi vil kikke på det også.

## Opgaver
Vi vil på klassen arbejde med at [debugge dette program](https://github.com/cphbusinessAUVidrProg/uge10Debug01).

Jeg vil foreslå at I øver jeg i debuggeren med at finde den fejl der er sneget sig ind i [dette program](https://github.com/cphbusinessAUVidrProg/uge10Debug02).




