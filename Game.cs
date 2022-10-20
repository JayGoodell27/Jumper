//GameSystem run = new GameSystem();
//run.Main();




class GameSystem
{
parachute chute = new parachute();
    public void Main()
    {   
        int stage = 0;;
        while (stage <= 4) {
            Console.Write(chute.img[stage]);
            stage = stage + 1;
        }
    }


}