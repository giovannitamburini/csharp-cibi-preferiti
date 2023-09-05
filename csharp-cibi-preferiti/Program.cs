// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Inizializzo un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
string[] favorite_foods = { "pizza", "hamburger", "cappelletti", "tagliatelle", "carbonara", "carciofi" };

// stampo a schermo la lunghezza della classifica
Console.WriteLine(favorite_foods.Length);

for (int i = 0; i < favorite_foods.Length - 1; i++)
{
    Console.WriteLine(favorite_foods[i]);
}