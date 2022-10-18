



class gameSystem
{
    public int stage = 1;
    public void Main()
    {
        parachute chute = new parachute();
        while (stage >= 4) {
            Console.Write(chute.img[stage]);
        }
    }


}