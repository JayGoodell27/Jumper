// GameSystem run = new GameSystem();
// run.Main();




class GameSystem
{
    public int stage = 1;
    public void Main()
    {
        parachute chute = new parachute();
        while (stage >= 4) {
            Console.Write(chute.img[stage]);
            stage = stage + 1;
        }
    }


}