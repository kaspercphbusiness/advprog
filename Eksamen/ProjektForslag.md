# Projekt forslag

Denne opgave er beregnet på at bringe dig rundt om to centrale dele af pensum, nemlig algoritmer og lambda udtryk. Det betyder der er andre dele der ikke kommer til udfoldelse i denne opgave, specielt delene omkring design og design mønstre. Der er fokus på algoritme delen da denne ligger længst tilbage og sikkert trænger sig mest på mht. repetition.

Bemærk: Man gerne må lave sit eget projekt. I såfald vil jeg gerne lige have det til godkendelse inden i går alt for meget i gang.

## Delopgave A
Du skal lave en implementation af A* algoritmen der baserer sig på input der læses fra en tekst fil på formen:

```
.B...
xx.xx
.....
.xxxx
...Ex
```

B markerer Begin, E end, et punktum et tomt felt, og x en mur. Løsningen skal skrives ud på samme format, men med et "r" for rute der viser hvilken vej man skal gå:

```
.Br..
xxrxx
rrr..
rxxxx
rrrEx
```

Som del af afleveringen skal du aflevere to labyrint filer på mindst 10 x 10 felter som du har prøvet løsningen på.

## Delopgave B
Der optræder nu en ny type felter, nemlig G for guld. Du skal nu lave det sådan at du finder den vej fra B til E der finder mest guld. Guld brikkerne fungerer ikke som væg i labyrinten.

Lav en algoritme der løser problemet.

## Delopgave C

Dette er en variation over opgaven ovenfor, nemlig at vi denne gang skal finde ruter hvor vi samler præcis 5 guldmønter.

 
