Aprendiendo fundamentos del codigo  C# , anteriormente vi como implementar System Math  | Max() method").
Proyect Dice : Juego de Dados.
- Ahora como crear instancia de System.Random.//  Random dice = new Random();
- Methods Next() se le puede pasar 2 parametros (desde, hasta -1).
- Creamos variables de enteros.
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
- Almacenando dice(instacia de new Random()) con el metodo Next(1,7) del number 1 al 6, para simular una tirada de dados aleatoria.
- Creamos una variable de enteros llamada total, donde almacenara cada uno de los valores de cada roll con el resultado del metodo Next()
   int total = roll1 + roll2 + roll3;
- Ejecuamos el Console.WriteLine() para mostrar cada resultado de cada roll y su total.
  Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
- Uso de condicionales anidados:
- Si salen dobles se suman al total 2 puntos extras
 if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
- Si salen triples se suman al total 6 puntos extras
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
//Se gana el juego si la suma es mayor a 15 puntos 
if (total > 15)
{
    Console.WriteLine("You win!");
}
//Se pierde si la suma es menor a 15 puntos
/* if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
} */
else
{
    Console.WriteLine("Sorry, you lose.");
}
