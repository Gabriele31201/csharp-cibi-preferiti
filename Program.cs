



Console.WriteLine("------------------------- IN QUESTA CLASSIFICA TROVIAMO 5 POSIZIONI --------------------------------");



string[] favoriteFood = { "Pizza", "Carne", "Pasta", "Cioccolato", "Sushi", };

for (int i = 0; i < favoriteFood.Length; i++)
{
    Console.WriteLine("-" + (i + 1) + "° " + favoriteFood[i]);
}

Console.WriteLine("----------------------------------------------------------------------------------------------------");