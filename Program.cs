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


    
}

//felhantera genom att kolla om språk finns i listan med språk som finns i words]

//foreach (var word in words)
//{
//    Console.WriteLine($"{word.FromLanguage}: {word.FromWord} => {word.ToLanguage}: {word.ToWord} ");

//}

            //key  //value
Dictionary<string, List<Word>> swedishToEnglish = words //.GroupBy(word => word.FromWord)
.Where(word => word.FromLanguage == fromLanguage)
.Where(word => word.ToLanguage == toLanguage)
.GroupBy(word => word.FromWord)
.ToDictionary(
    group => group.Key, // ordet jag vill översätta från
    group => group.ToList() // lista med våra word objekt som matchar nycklen
);

foreach (var word in swedishToEnglish["stark"])
{
    Console.WriteLine($"Översättning: {word.ToWord}");
}