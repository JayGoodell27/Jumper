GameSystem run = new GameSystem();
while (run.wrongGuess != 4)
{
    run.Main();
}
Console.WriteLine("You Lost!");




class GameSystem
{
parachute chute = new parachute();
Compare compare = new Compare();
public int wrongGuess;
public GameSystem()
{
    wrongGuess = 0;
    

}
    public void Main()
    {   
        char[] UpdateStarLine()
            {
            char[] updated = compare.SendLine();
            return updated;
            }

         char[] currentLine = UpdateStarLine();
         Console.WriteLine(chute.paraPop(wrongGuess));
         Console.WriteLine($"Here is the guess line {new string(currentLine)}");
         Console.WriteLine("Guess The Letter");
         string guess = Console.ReadLine();
         char charGuess = char.Parse(guess);
         char[] newStarLine = compare.CompareGuess(charGuess);
         bool boolGuess = compare.BoolGuess(charGuess);
         if (boolGuess == false)
            {
                Console.WriteLine("You didn't guess a correct letter!");
                wrongGuess = wrongGuess + 1;
            }
        else
            {
                Console.WriteLine("You guessed correctly!");
            }
    }


}