// See https://aka.ms/new-console-template for more information

// Inizializzo un array con la classifica dei miei cibi preferiti (minimo 5, massimo 10 elementi).
string[] favorite_foods = { "pizza", "hamburger", "cappelletti", "tagliatelle", "carbonara", "carciofi" };

// stampo a video la lunghezza della classifica
Console.WriteLine($"la lunghezza della mia classifica è {favorite_foods.Length}");

Console.WriteLine();

// stampo a video la mia classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Console.WriteLine("La mia classifica è:");

for (int i = 0; i < favorite_foods.Length; i++)
{
    Console.WriteLine((i + 1) + " - " + favorite_foods[i]);
}

Console.WriteLine();

// stampo a video il mio cibo top
Console.WriteLine($"Il mio cibo top è: {favorite_foods[0]}");

Console.WriteLine();

// stampo a video il mio cibo preferito ma non troppo(ultima posizione in classifica)
Console.WriteLine($"Il mio cibo preferito ma non troppo: {favorite_foods[^1]}");

Console.WriteLine();

// BONUS: stampo a schermo il cibo di mezza classifica
// caso in cui la classifica presenta un numero di elementi pari
if (favorite_foods.Length % 2 == 0)
{
    Console.Write($"Gli elementi mediani della classifica sono: {favorite_foods[(favorite_foods.Length - 1) / 2]}, {favorite_foods[(favorite_foods.Length / 2)]}");

    /*
    OPPURE

    Console.Write("Gli elementi mediani della classifica sono: ");

    Console.Write(favorite_foods[(favorite_foods.Length - 1) / 2]);

    Console.Write(", ");

    Console.Write(favorite_foods[(favorite_foods.Length / 2)]);
    */

    // caso in cui la classifica presenta un numero di elementi pari
}
else
{
    Console.Write($"L'elemento mediano della classifica è: {favorite_foods[favorite_foods.Length / 2]}");

}

Console.WriteLine();