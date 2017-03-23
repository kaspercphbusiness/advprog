# Regular expression & state machines
After this week, it is the goal that you should be able to:

- write regular expression to accept common structured texts
- implement those regular expressions in C#
- be able to extract sub-strings using regular expressions
- do string replacements based on match-groups
- draw finite state machines based on a regular expression
- implement final state machines in C# using a state variable and switch statement
- give examples of state machines used outside of recognizing text

## Readings
This [set of micro lessons](https://regexone.com/lesson/introduction_abcs) give a pretty good idea of what regular expressions do. The site also have some really good practice problems.

In their reference section, there are language specific information. [C# is one of the languages supported](https://regexone.com/references/csharp).

We will spend some time on the algorithms behind matching regular expressions. Those algorithms are based on two steps:

1. Transforming the regular expression into a _finite state machine_ (FSM).
2. Transforming the FSM into a program.

This [short video](https://www.youtube.com/watch?v=GwsU2LPs85U) gives an excellent idea of the principle of the first step in 7 minutes.

We will look at the second step in class. [This page explains step two](http://www.gamedev.net/page/resources/_/technical/general-programming/finite-state-machines-and-regular-expressions-r3176), but continues to add more and more complications which are interesting, but outside our scope)

## Plan
It is my plan that:

1. You have finished the micro lessons 1-15 as preparation to class.
2. We will discuss and do the practice problems in class
3. We will do the practice problems both on the site, and in C# in visual studio
4. We will watch the video above
5. We will discuss the relationship between the full regular expressions used in the micro lessons and the very simple regualar language used in the video
6. We will convert a few regular expressions into finate state machines and implement them in C#
7. We will look at some other usages of state machines.

## Exercises 
1. Write a pattern that will match dates on the form 25-may-2016. It should accept the month to be capitalized or not, and the date can be with or without a leading zero.
2. Write a pattern that will match dates on the form 2016-05-25.
1. Write a C# program that will do the above two
1. Write a C# program which will replace all occourances of the first format with the last.
<hr>
1. Rewrite the first regular expression above to a state machine.
2. Implement this statemachine in C#.
3. Extend this program to solve task 4 above

## Exercise for next week
Write a regular expression that will recognize email addresses from Denmark.
 
Make a series of test cases. Examine which formats email addresses can have, to cover as broadly as possible.

Rewrite the regular expression to a state machine.

[Shared googlesheet.](https://docs.google.com/document/d/1kKx3C0QdTLDLu-IkZZWWQfkYFaQGHFeAgWpuwRzvbik/edit#heading=h.m9j926nb3xt4)

### Part 1
Implement this state machine using a switch statement in a method that gets a string containg the email address to be matcched as a parameter. The method must return a boolean being true if the parameter did match the regular expression state machine implements.

### Part 2
Expand method so that it returns a text string name of mail provider - `kaj.hansen @ gillelejefisk.dk` must therefore return` gillelejefisk`.

It should return null if there is no match
