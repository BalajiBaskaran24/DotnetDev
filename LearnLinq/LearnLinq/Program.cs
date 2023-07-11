// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Main(new string[] { });
// Program.cs
static void Main(string[] args)
{

    var startingDeck = from s in Suits()
                       from r in Ranks()
                       select new { Suit = s, Rank = r };

    // Display each card that we've generated and placed in startingDeck in the console
    Console.WriteLine("Using query");
    foreach (var card in startingDeck)
    {
        Console.WriteLine(card);
    }


    startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new
    {
        Suit = suit,
        Rank = rank
    }));
    // Display each card that we've generated and placed in startingDeck in the console
    Console.WriteLine("Using select many");
    foreach (var card in startingDeck)
    {
        Console.WriteLine(card);
    }
}
static IEnumerable<string> Ranks()
{
    Console.WriteLine("Enters two");
    yield return "two";
    Console.WriteLine("Enters three");
    yield return "three";
    Console.WriteLine("Enters four");
    yield return "four";
    Console.WriteLine("Enters five");
    yield return "five";
    Console.WriteLine("Enters six");
    yield return "six";
    Console.WriteLine("Enters seven");
    yield return "seven";
    Console.WriteLine("Enters eight");
    yield return "eight";
    Console.WriteLine("Enters nine");
    yield return "nine";
    Console.WriteLine("Enters ten");
    yield return "ten";
    Console.WriteLine("Enters jack");
    yield return "jack";
    Console.WriteLine("Enters queen");
    yield return "queen";
    Console.WriteLine("Enters king");
    yield return "king";
    Console.WriteLine("Enters ace");
    yield return "ace";
}
static IEnumerable<string> Suits()
{
    Console.WriteLine("Enters club");
    yield return "clubs";
    Console.WriteLine("Enters diamonds");
    yield return "diamonds";
    Console.WriteLine("Enters hearts");
    yield return "hearts";
    Console.WriteLine("Enters spade");
    yield return "spades";
}

