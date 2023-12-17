///// System.Console | WriteLine() and Write() method ////
///////////////////// Methods /////////////////////////
//// System Math  | Max() method  ////

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue);
Console.WriteLine();
Console.WriteLine("System Math  | Max() method");
Console.WriteLine($"\nLargerValue:{largerValue}");

//// System.Random / Next() method ////

Console.WriteLine();
Console.WriteLine(" System.Random Methods Next()");

Random dice = new Random();
// la variable dice es una instancia de  System.Random
//metodo next() similar al random, se le puede pasar 2 parametros (desde, hasta -1)
//int roll1 = dice.Next();
//int roll2 = dice.Next(101);
//int roll3 = dice.Next(50, 101);
//var roll4 = dice.Next(1,6);

/* Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
Console.WriteLine($"Fourth roll: {roll4}"); */

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine();
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//si salen dobles se suman al total 2 puntos extras
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
//si salen triples se suman al total 6 puntos extras
if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
//Se gana el juego si la suma es mayor a 15 puntos 
if (total > 15)
{
    Console.WriteLine("You win!");
}
//Se pierde si la suma es menor a 15 puntos
if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}