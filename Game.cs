GameSystem run = new GameSystem();
run.Main();




class GameSystem
{
parachute chute = new parachute();
Compare compare = new Compare();
    public void Main()
    {    

         Console.Write(chute.paraPop());
         Console.Write("Guess The Letter");
        string? guess = Console.ReadLine();
        compare.CompareGuess(guess)

        
        
        
        /*int stage = 0;;
        while (stage <= 4) {
            Console.Write(chute.img[stage]);
            stage = stage + 1;
        }*/
    }


}