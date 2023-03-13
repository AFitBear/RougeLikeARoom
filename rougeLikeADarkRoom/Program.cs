using System;

namespace rougeLikeADarkRoom
{
    internal class Program
    {
        static public int size;
        static public int xPorsition;
        static public int yPorsition;
            

        static void Main(string[] args)
        {
            Console.WriteLine("gg");
            /*int rows = 20;
            int cols = rows;*/
            int length = 23;
            size= length;
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
            xPorsition %= 2;
            yPorsition %= 2;
            const float TARGET_FPS = 24; // Frame rate (ønsket)
            const float TARGET_FRAME_TIME = 1f / TARGET_FPS; // Tid per frame
            DateTime previousFrameTime;
            float elapsedTime = 0f;
            while (true)
            {
                person.action(ref xPorsition,ref yPorsition);
                previousFrameTime = DateTime.UtcNow;
                elapsedTime = (float)(DateTime.UtcNow - previousFrameTime).TotalSeconds;
                if (elapsedTime < TARGET_FRAME_TIME)
                {
                    // Hvis en frame tid ikke er forløbet endnu, sov lidt:
                    int sleepTime = (int)((TARGET_FRAME_TIME - elapsedTime) * 1000);
                    System.Threading.Thread.Sleep(sleepTime);
                }
            }
            //new ItemClasses { Catogorie = ItemClasses.Catogory.Healing, heiling = ItemClasses.Healing.bread, durability = 6 };
        }
    }
}