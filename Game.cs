GameSystem run = new GameSystem();
run.Main();




class GameSystem
{
parachute chute = new parachute();
Compare compare = new Compare();
int wrongGuess;
public GameSystem()
{
    wrongGuess = 0;
    

}
    public void Main()
    {  
        char[] UpdateStarLine()
            {
            char[] updated = compare.starLine;
            return updated;
            }

         char[] currentLine = UpdateStarLine();
         Console.WriteLine(chute.paraPop(wrongGuess));
         Console.WriteLine($"Here is the guess line {new string(currentLine)}");
         Console.WriteLine("Guess The Letter");
         string? guess = Console.ReadLine();
         char charGuess = char.Parse(guess);
         char[] newStarLine = compare.CompareGuess(charGuess);
         if (newStarLine == currentLine)
            {
                Console.WriteLine("You didn't guess a correct letter!");
                wrongGuess = wrongGuess + 1;
            }
        else
            {
                Console.WriteLine("You guessed correctly!");
                Console.WriteLine($"Here is your new guess line{newStarLine}");
            }
    }

    
}