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
            wall,
            chest,
            unexpored,
            explored,
            bandit,
            boss


        }
        public Types theTileType;
        public TileType(Types type)
        {
            theTileType = type;
        }


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
            Console.SetCursorPosition(1, 1);
            Console.Write('B');
            manyPosition[1][1] = TileType.Types.boss;
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
                            switch (random.Next(0, luckyness))
                            {
                                case < 10:
                                    Console.WriteLine("under10");
                                    break;
                                case > 10:
                                    Console.WriteLine("over10");
                                    break;
                                case 10:
                                    Console.WriteLine("is10");
                                    break;
                                default:
                                    break;
                            }


                        }
                        else
                        {
                            Console.WriteLine(".");
                            manyPosition[row][col] = TileType.Types.unexpored;
                        }
                    }
                }
            }
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
                        y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow or ConsoleKey.S:
                    if (y < Program.size - 3)
                    {
                        y += 1;
                    }
                    break;
                case ConsoleKey.RightArrow or ConsoleKey.D:
                    if (x < (Program.size - 3))
                    {
                        x += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow or ConsoleKey.A:
                    if (x > 1)
                    {
                        x -= 1;
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

