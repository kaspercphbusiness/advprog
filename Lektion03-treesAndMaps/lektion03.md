# Uge 3 - Hashmap & Søgetræer
Vi skal denne gang kikke på Hashmap & Søgetræer.

Som sidst starter vi begyndelsen af sessionen til at samle op på opgaven fra sidst. 

## Forberedelse
Der er lidt video kikning på programmet, så forbered jer ved at se de nævnte videoer fra Lynda.com. 

**Bemærk, I kan logge på via jeres cph-brugernavn.**
I øverste højre hjørne af Lynda.com trykker man "Sign in". Man skriver derefter sin cph-email. Man bliver så viderestillet til efif (som er it leverandøren for cphbusiness), og derefter er man på Linda.com. De har mange gode video lektioner, og jeg kan kun opfordre jer til at kikke hvis I har tid.

## Læsestof
De to videoer er dagens pensum:

* [Hashing & Hashmaps](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Using-associative-arrays/149042/177125-4.html?org=cphbusiness.dk) Se denne og de to næste sektioner (altså "Using associative arrays", "Understanding hash functions" and "Using hash tables").)


* [Binary tree](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Introduction-tree-data-structures/149042/177132-4.html?org=cphbusiness.dk) og [Binary Search Tree](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Understanding-binary-search-trees-BST/149042/177133-4.html?org=cphbusiness.dk) bliver godt forklaret i disse to sektioner.


## Øvelser på klassen
1. Go to <https://www.cs.usfca.edu/~galles/visualization/BST.html> and play a bit with the animation. 
  Insert a few elements. Find an element, Delete an element.
2. Sketch a binary search tree (on paper) after the insertion of the numbers [ 5,3,2,6,8,9,10 ] in the order shown. 
   Assume that the tree was empty initially.
3. Sketch a (new) binary search tree after insertion of the numbers  [ -1,10,-50,-20,50,4,5,6 ].
4. Sketch a (new) binary search tree after insertion of the numbers [ 1,2,3,4,5,6 ]
5. Order the insertion of the numbers [1,2,3,4,5,6,7 ] into a tree, so that the 
resulting tree will have the minimal height possible.
6. Go to <https://www.khanacademy.org/computer-programming/depth-first-traversals-of-binary-trees/934024358>. Try to figure out what is the difference between traversing the tree in Preorder, Inorder and Postorder.
7. State the order in which the nodes will be visited if the tree from exercise 4 is traversed following the principle inorder, preorder and postorder principle respectively. 
8. Which of the three traversals writes out the elements in sorted order?
   

## Øvelser til næste gang
Vi skal lave en skal lave en hjemmelavet HashMap (kaldet Dictionary i C#).

```csharp
interface IVPDictionary {// VP for videregående programmering
	bool isEmpty();
	bool hasKey(String key);
	int  get(String key);
	int  set(String key, int value);
}
```
Delopgaverne nedenfor er markeret med stjerner. En stjerne er det du bør være i stand til for at bestå, to er en middel løsning, og de trestjernene begynder at være top løsninger.

### Opgave 1. *
Den simpleste løsning er blot at lave et array af key-value par og ikke overveje effektivitet. Sørg for at lave en main der prøver din implementation af med et par eksempler.

### Opgave 2. *
Fortsæt med løsningen fra opgave 1, men udvid nu sådan at arrayet udvides når der ikke længere er plads i arrayet til ny elemenenter. _Bemærk: man kan **ikke** udvide et array, det man gør er at man allokerer et nyt og størrer, og så kopierer alle elementer fra det gamle over i det nye._

Du skal sikrer dig at 

### Opgave 3. **
Lav en løsning der bruger strings indbyggede hash funktion `GetHashCode()` til at få et heltal der kan bruges til at beslutte hvilken kurv (Bucket) key-value pair skal gemmes i. 

Igen, lad være med at håndtere at at arrayet kan løbe fuldt i første omgang.

### Opgave 4. ***
Udvid opgave 3 til også at håndtere at arrayet løber fuldt. Det normale er at man allokerer et nyt array når det gamle er omkring 75% fuld.

### Opageve 5. ***
Når man i opgave 4 skal reallokere skal man beregne alle hash værdierne igen (kalde `GetHashCode()`igen). Kan man lave en løsning hvor dette ikke er nødvendigt?

