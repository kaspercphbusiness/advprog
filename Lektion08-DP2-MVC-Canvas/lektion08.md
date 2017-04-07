# Uge 8 - MVC & User Control 
En stor del af bruger grænseflader kan laves vha. de indbyggede elementer i visual studio. Men fra tid til anden kommer kan ud for at skulle lave en visualisering af noget specifikt som ikke har en passende understøttelse i de indbyggede brugergrænseflade elementer.

Der er et specielt design mønster der er centralt i denne sammenhæng som kaldes model-view-controller (MVC). Vi skal se på det i sin generelle form, og på hvordan vi bruger det til at lave vores egne brugergrænseflade elementer.

## Forberedelse & læsestof
Som forberedelse til næste gang vil jeg foreslå at læse denne:

* [MDSN Network: Model-View-Controller](Model-View-Controller.pdf)

MVC spiller også en stor rolle i klassisk web programmering, men det er ikke en del af dette kursus.

Som en del af projektet skal vi lave en windows form brugergrænseflade der præsenterer en tegning af et labyrint. Tanken er at dette program skal bringe følgende elementer sammen:

* Indlæsning af labyrinter fra tekst filer 
* Finde løsning af labyrint (depth first algoritmen)
* Events i brugergrænseflader
* Tegning i windows form
* Strukturering af koden med MVC, Observer mv.

Denne [note om "Drawing graphics in C#"](Drawing Graphics in C Sharp - Techotopia.pdf) giver nogle simple eksempler på hvordan man tegner i C#.

Jeg fandt ikke en klar note om hvordan man laver en usercontrol som kan bruges til tegninger. Jeg har derfor lavet en 

* [kort note om tegning på usercontrol](usercontrol.md). Kildeteksten til projektet der bruges som eksempel er her <https://github.com/cphbusinessAUVidrProg/uge8MazeWithGUIDemo>


## Øvelser på klassen
Lave en UserControl der kan håndtere og huske 3 cirkler. For at få på plads at der er skal være en "model", at graphics genskrives som svar på 

[Dette er det program der blev snakket om på klassen.](https://github.com/cphbusinessAUVidrProg/uge8ThreeDots)   

## Øvelser til næste gang (som bliver om 3 uger)
Dette er er stor opgave og kan indgå som en del i et samlet projekt om håndtering af labyrinter (altså som del af den endelige projekt).


Grund ideen er at der skal laves et program der kan læse og skrive labyrinter fra filer. Det skal være muligt at rette labyrinterne i programmet via et grafisk interface (en usercontrol). Endvidere skal man kunne bede programmet om at løse labyrintet og vise løsningen på skærmen.

Rimelige udvidelser kunne være (men ok blot med ovenstående):

- Man kan oprette labyrinter i programmet, altså ikke kun læse dem fra fil. Her skal der evt. være en måde at angive størrelsen.
- Man kan blive bedt om hvilken fil der skal indlæses, og evt også vælge hvilken fil der skal skrives til
- Man kan angive begyndelses og slut sted (altså ikke lade dem være fast i øverste venstre hjørne og nederste højre hjørne)
- Man kan eksperimentere med finde alle veje igennem labyrintet



