Console.WriteLine("Glosprogram");

// snabb, fast

List<Word> words = [
    /*["snabb", "fast"],
    ["snabb", "fast"],
    ["glad", "glad"],*/
    new Word("swedish", "english", "snabb", "fast"),  // minnesreferens skapas
    new Word("swedish", "english", "snabb", "quick"),
    new Word("swedish", "english", "snabb", "rapid"),
    new Word("swedish", "english", "snabb", "speedy"),
    new Word("swedish", "english", "stor", "large"),
    new Word("swedish", "english", "stor", "big"),
    new Word("swedish", "italian", "snabb", "rapido"),
    new Word("swedish", "english", "stark", "forte"),
    new Word("swedish", "italian", "glad", "felice"),
    new Word("swedish", "italian", "stark", "robusto"),
];

while (true)
{
    Console.WriteLine("Välj vilket språk du vill översätta från");
    string? fromLanguage = Console.ReadLine();

    Console.WriteLine("Välj vilket språk du vill översätta till");
    string? toLanguage = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(fromLanguage) || string.IsNullOrWhiteSpace(toLanguage))
    {
        Console.WriteLine("Du måste ange båda språken.");
        continue;
    }

    Dictionary<string, List<Word>> swedishToEnglish = words
        .Where(word => word.FromLanguage == fromLanguage)
        .Where(word => word.ToLanguage == toLanguage)
        .GroupBy(word => word.FromWord)
        .ToDictionary(
            group => group.Key,
            group => group.ToList()
        );

    Console.WriteLine("Skriv in ett ord att översätta:");
    string? wordToTranslate = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(wordToTranslate))
    {
        Console.WriteLine("Du måste ange ett ord.");
        continue;
    }

    if (swedishToEnglish.TryGetValue(wordToTranslate, out List<Word>? translatedWords))
    {
        foreach (var word in translatedWords)
        {
            Console.WriteLine($"Översättning: {word.ToWord}");
        }
    }
    else
    {
        Console.WriteLine("Det finns ingen översättning för det ordet i det valda språket.");
    }

    Console.WriteLine("Vill du översätta igen? (j/n)");
    if (Console.ReadLine()?.Trim().ToLower() != "j")
    {
        break;
    }
}