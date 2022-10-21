GameSystem run = new GameSystem();
while (run.wrongGuess != 4 ^ run.correctGuess == 5)
{
    run.Main();
}
if (run.correctGuess == 5)
{
    Console.WriteLine("You Won!");
}
else
{
    parachute chute = new parachute();
    Console.WriteLine(chute.img[4]);
    Console.WriteLine("You Lost!");

}





class GameSystem
{
parachute chute = new parachute();
Compare compare = new Compare();
public int wrongGuess;
public int correctGuess;
public GameSystem()
{
    wrongGuess = 0;
    correctGuess = 0;
    

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
         string? guess = Console.ReadLine();
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
                correctGuess = correctGuess + 1;
            }
    }

    
}