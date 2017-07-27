# SwitchCodeSmell
Project that shows a switch code smell in a small C# class, as well as two potential solutions. See my post Sometimes There Are Simple Solutions To Code Smells (to be published).

There are two projects in this Visual Studio 2017 solution:
- PlayingCards - contains a simple CardSuit class, implemented three different ways:
    - CardSuit.cs contains an initial implementation that contains a switch code smell.
    - CardSuit2.cs contains an implementation using subclasses to replace one of the switch statements in the class.
    - CardSuit3.cs contains a third implementation that provides a simpler solution to the code smell.
    
##Requirements
1. Visual Studio 2017 Update 1 or later.
2. .Net 4.6.1 (loaded with VS 2017).
3. xUnit.Net (should be loaded automatically the first time you build the solution).
