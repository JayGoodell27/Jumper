Words WordsTest = new Words();
// string word = WordsTest.WordGive();
var wordForGame = WordsTest.LetterSeperate();
List<string> Display = new List<string>();
Display.Add("*");
Display.Add("*");
Display.Add("*");
Display.Add("*");
Display.Add("*");

Console.Write("WORD GAME: Guess letters for a 5 letter word");
string userInput = Console.ReadLine();
var charUserInput = userInput.ToCharArray();
int NumberCounter = -1;
// string StringWord = wordForGame.ToString();
foreach(char[] c in wordForGame)
{
    NumberCounter = NumberCounter + 1;
    if (charUserInput == c)
     {
        bool guess = true;
        var correctGuess = c;
     }
}
if (guess == true)
{
    Display[NumberCounter] = wordForGame[NumberCounter];

    Console.WriteLine("You Guess Correct!");
    Console.WriteLine($"Your guess like is {Display}");
}
else
{
    Console.WriteLine("You Guessed Wrong");
}