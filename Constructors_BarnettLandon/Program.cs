namespace Constructors_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates new object known as myGame
            Game myGame = new Game("Apex Legends", "FPS"); 
            //prints my favorite game to console
            Console.WriteLine($"My favorite game is {myGame.title} and it is an {myGame.genre}");
            //prints default params
            Game myOtherGame = new Game();
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} gamed");
        }
    }
}