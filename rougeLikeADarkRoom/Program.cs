namespace rougeLikeADarkRoom
{

    internal class Program
    {
        static public int size;
        static public int xPorsition;
        static public int yPorsition;
        static public int difficulty = 1;
        

        static void Main(string[] args)
        {
            Console.SetCursorPosition(0, 50);
            Console.WriteLine("My name is Yoshikage Kira. I'm 33 years old. ");
            Console.WriteLine("My house is in the northeast section of Morioh, where all the villas are, and I am not married.");
            Console.WriteLine("I work as an employee for the Kame Yu department stores, and I get home every day by 8 PM at the latest.");
            Console.WriteLine("I don't smoke, but I occasionally drink. ");
            Console.WriteLine("I’m in bed by 11 PM, and make sure I get eight hours of sleep, no matter what.");
            Console.WriteLine("After having a glass of warm milk and doing about twenty minutes of stretches before going to bed, ");
            Console.WriteLine("I usually have no problems sleeping until morning.");
            Console.WriteLine("Just like a baby, I wake up without any fatigue or stress in the morning. ");
            Console.WriteLine("I was told there were no issues at my last check-up.");
            Console.WriteLine("I’m trying to explain that I’m a person who wishes to live a very quiet life.");
            Console.WriteLine("I take care not to trouble myself with any enemies, like winning and losing, that would cause me to lose sleep at night.");
            Console.WriteLine("That is how I deal with society, and I know that is what brings me happiness. ");
            Console.WriteLine("Although, if I were to fight I wouldn’t lose to anyone.");


            Console.CursorVisible = false;
            //int rows = 20;
            //int cols = rows;
            size = 23;
            //makes the board
            ItemClasses itemClasses = new ItemClasses();
            Board boardPrint = new Board();
            Board.PrintBoard(size);
            /*StreamWriter saveFile = new StreamWriter(@"boardSize.csv");
           StreamReader loadFile = new StreamReader(@"boardSize.csv");
           //Saves the file to long term memmery(my ssd methinks) it also closes the file so i cant write to it
           saveFile.Close();
           saveFile.WriteLine(size);
           int tinkk;
           tinkk = int.Parse(loadFile.ReadLine());
           */
            //start position is the middle of the board
            xPorsition = size / 2;
            yPorsition = size / 2;
            /*const float TARGET_FPS = 24; // Frame rate (ønsket)
            const float TARGET_FRAME_TIME = 1f / TARGET_FPS; // Tid per frame
            DateTime previousFrameTime;
            float elapsedTime = 0f;*/
            //game loop
            while (true)
            {
                person.action(ref xPorsition, ref yPorsition);
                /*previousFrameTime = DateTime.UtcNow;
                elapsedTime = (float)(DateTime.UtcNow - previousFrameTime).TotalSeconds;
                if (elapsedTime < TARGET_FRAME_TIME)
                {
                    // Hvis en frame tid ikke er forløbet endnu, sov lidt:
                    int sleepTime = (int)((TARGET_FRAME_TIME - elapsedTime) * 1000);
                    System.Threading.Thread.Sleep(sleepTime);
                }*/
            }
            //new ItemClasses { Catogorie = ItemClasses.Catogory.Healing, heiling = ItemClasses.Healing.bread, durability = 6 };
        }
    }
}
