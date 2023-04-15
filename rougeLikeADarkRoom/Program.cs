namespace rougeLikeADarkRoom
{

    internal class Program
    {
        static public int level = 0;
        static public int size;
        static public int xPorsition;
        static public int yPorsition;
        static public int difficulty = 1;
        static void Main(string[] args)
        {
            person.Setup(); //Setting things up
            size = 23;
            //makes the board
            Board boardPrint = new Board();
            Board.PrintBoard(size);
            //start position is the middle of the board
            xPorsition = size / 2;
            yPorsition = size / 2;
            //Makes the fights board where you fight enemies
            Fight fight = new Fight();
            Fight.PrintFight(size);
            //game loop
            while (true)
            {
                Console.SetCursorPosition(50, 20);
                Console.WriteLine(xPorsition + " " + yPorsition + "    ");
                Console.SetCursorPosition(50, 21);
                Console.WriteLine(Board.CheckTileType(xPorsition, yPorsition) + "          ");
                person.action(ref xPorsition, ref yPorsition);
                Board.CheckAction(Board.GetTileTypeInfo(Board.CheckTileType(xPorsition, yPorsition)).number);
                if (Fight.ChechIfDed())
                {
                    break; 
                }
                //ConsoleColor thing = ConsoleColor.Red;
                //Console.ForegroundColor = thing;
                //Console.WriteLine(Board.GetTileTypeInfo(Board.CheckTileType(1, 1)));
                //                                                 CheckAction(GetTileTypeInfo(TileType.Types theTile));
                    /*previousFrameTime = DateTime.UtcNow;
                    elapsedTime = (float)(DateTime.UtcNow - previousFrameTime).TotalSeconds;
                    if (elapsedTime < TARGET_FRAME_TIME)
                    {
                        // Hvis en frame tid ikke er forløbet endnu, sov lidt:
                        int sleepTime = (int)((TARGET_FRAME_TIME - elapsedTime) * 1000);
                        System.Threading.Thread.Sleep(sleepTime);
                    }*/
            }
            Console.Clear();
            Console.WriteLine("You Dead");
        }
    }
}
/*const float TARGET_FPS = 24; // Frame rate (ønsket)
const float TARGET_FRAME_TIME = 1f / TARGET_FPS; // Tid per frame
DateTime previousFrameTime;
float elapsedTime = 0f;*/


/*Ekstra code i will maybe/not use
StreamWriter saveFile = new StreamWriter(@"boardSize.csv");
           StreamReader loadFile = new StreamReader(@"boardSize.csv");
           //Saves the file to long term memmery(my ssd methinks) it also closes the file so i cant write to it
           saveFile.Close();
           saveFile.WriteLine(size);
           int tinkk;
           tinkk = int.Parse(loadFile.ReadLine());
//new ItemClasses { Catogorie = ItemClasses.Catogory.Healing, heiling = ItemClasses.Healing.bread, durability = 6 };

internal class ItemClasses
    {
        public enum Catogory
        {
            Healing,
            Weaponing,
            miscing
        }
        public Catogory Catogorie { get; set; }
        public enum Healing
        {
            bread,
            healPotion,
            bandage,
            cocio
        }
        public Healing heiling { get; set; }

        public string name { get; set; }


        public int durability { get; set; }

    }
    
*/