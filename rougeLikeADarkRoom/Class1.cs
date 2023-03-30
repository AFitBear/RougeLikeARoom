namespace rougeLikeADarkRoom
{
    internal class Position
    {
        public int row;
        public int col;
        public Position(int r, int c)
        {
            row = r;
            col = c;
        }
    }
    internal class TileType
    {
        public enum Types
        {
            wall = 0,
            chest = 1,
            unexplored = 2,
            explored = 3,
            bandit = 4,
            boss = 5


        }
        public Types theTileType { get; set; }

    }
    /*internal class Tyletype
     {
         public string name;
         public char logo;
         public Tyletype(string nme, char lgo)
         {
             name = nme;
             logo = lgo;
         }
     }*/ //Old code. legacy code if you will...

    internal class Board
    {
        static public int magicnumber = 21;
        static public int luckyness = 20;
        static public TileType.Types[][] manyPosition;

        public static void PrintBoard(int rowsAndCols)
        {
            manyPosition = new TileType.Types[Program.size][];
            for (int i = 0; i < manyPosition.Length; i++)
            {
                manyPosition[i] = new TileType.Types[Program.size];

            }
            Random random = new Random();
            for (int row = 0; row < rowsAndCols - 1; row++)
            {
                for (int col = 0; col < rowsAndCols - 1; col++)
                {
                    Console.SetCursorPosition(col, row);
                    if (row == 0 || col == 0 || row == rowsAndCols - 2 || col == rowsAndCols - 2)
                    {
                        Console.Write('█');
                        manyPosition[row][col] = TileType.Types.wall;
                    }
                    else
                    {
                        if (random.Next(1, magicnumber) == 2)
                        {

                            Console.Write("¤");
                            manyPosition[row][col] = TileType.Types.chest;
                            //laver en chance for at lave en chest eller en bandit osv.
                            switch (random.Next(0, luckyness))
                            {
                                case < 10 when 4 < 5:
                                    manyPosition[row][col] = TileType.Types.chest;
                                    break;
                                case > 9:
                                    manyPosition[row][col] = TileType.Types.chest;
                                    break;
                                default:
                                    manyPosition[row][col] = TileType.Types.unexplored;
                                    break;
                            }


                        }
                        else
                        {
                            Console.WriteLine(".");
                            manyPosition[row][col] = TileType.Types.unexplored;
                        }
                    }
                }
            }
            Console.SetCursorPosition(1, 1);
            Console.Write(GetTileTypeInfo(TileType.Types.boss).logo);
            manyPosition[1][1] = TileType.Types.boss;

        }
        public static (string name, char logo, int number) GetTileTypeInfo(TileType.Types theTile)
        {
            switch (theTile)
            {
                case TileType.Types.wall:
                    return ("wall", '█', 1);

                case TileType.Types.unexplored:
                    return ("une", '.', 2);

                case TileType.Types.explored:
                    return ("exp", '+', 3);

                case TileType.Types.chest:
                    return ("chest", 'c', 4);

                case TileType.Types.bandit:
                    return ("band", 'b', 5);

                case TileType.Types.boss:
                    return ("boss", 'B', 6);
                default:
                    return ("null", '?', 0);
            }
        }
        public static void CheckAction(int actionThing)
        {
            //checks what action need to be done. like if you are on a bandit tile then i does bandit action
            switch (actionThing)
            {
                case 2 or 3:

                break;
                case 4:

                break;
                case 5:

                break;
                case 6:

                break;
                default:
                break;
            }
        }
        public static void BanditAction()
        {

        }
            public static void ChestAction()
        {

        }
            public static void BossAction()
        {

        }

    }

    internal class person
    {
        public static void action(ref int x, ref int y)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);//There need to be "true" so it intercepts the thing i write.AKA it does not wirte the letter I press down.
            Console.SetCursorPosition(x, y);
            Console.Write('+');
            switch (key.Key)
            {
                case ConsoleKey.UpArrow or ConsoleKey.W:
                    if (y > 1)
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.DownArrow or ConsoleKey.S:
                    if (y < Program.size - 3)
                    {
                        y++;
                    }
                    break;
                case ConsoleKey.RightArrow or ConsoleKey.D:
                    if (x < (Program.size - 3))
                    {
                        x++;
                    }
                    break;
                case ConsoleKey.LeftArrow or ConsoleKey.A:
                    if (x > 1)
                    {
                        x--;
                    }
                    break;
                default:
                    break;

            }
            Console.SetCursorPosition(x, y);
            Console.Write('@');

        }
    }

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
}

