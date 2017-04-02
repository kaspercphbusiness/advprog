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

* [kort note om tegning på usercontrol](usercontrol.md). Kildeteksten til projektet der bruges som eksempel er her (**kommer inden torsdag aften**)


## Øvelser på klassen
Lave en UserControl der kan håndtere og huske 3 cirkler. For at få på plads at der er skal være en "model", at graphics genskrives som svar på 
   

## Øvelser til næste gang
Dette er er stor opgave og kan indgå som en del i et samlet projekt om håndtering af labyrinter (altså som del af den endelige projekt).


