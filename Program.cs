
using ConsoleApp35;

namespace ConsoleApp35
{
    class BeerSong
    {
        public void Sing()
        {
            for (int Bottles = 99; Bottles > 0; Bottles--) 
            {
                Console.WriteLine($"{Bottles} Bottles{(Bottles > 1 ? "s" : "")} of beer on the wall, {Bottles} Bottles{(Bottles > 1 ? "s" : "")} of beer.");
                Console.WriteLine("Take one down and pass it around,");
                
            }
            Console.WriteLine("No more Bottles of beer on the wall, no more Bottles of beer.");
        }
    }
}
class Program
{
    static void Main() 
    {
        var song = new BeerSong();
        song.Sing();
    }
}
