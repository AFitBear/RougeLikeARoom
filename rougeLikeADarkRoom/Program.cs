﻿namespace rougeLikeADarkRoom
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
            //Make Maze Function, NOT WORKING CURRENTLY
            //zMazeMaker.MakeMazez();
            //Console.ReadLine();

            person.Setup(); //Setting things up like cursor visability
            size = 23;
            //makes the board
            Board boardPrint = new Board();
            Board.PrintBoard(size);
            //start position is the middle of the board and puts the player there
            xPorsition = size / 2;
            yPorsition = size / 2;
            Draww.Paint(xPorsition, yPorsition, "@", ConsoleColor.Green);
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
                Board.CheckAction(Board.CheckTileType(xPorsition, yPorsition));
                if (Fight.hero.playerHP<1)
                {
                    break; 
                }
              
            }
            Console.Clear();
            Console.WriteLine("You Dead? Pathetic");
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