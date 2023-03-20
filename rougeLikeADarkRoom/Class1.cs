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
   /* internal class TileType
    {
        public enum TileTypes
        {
            wall,
            chest,
            unexpored,
            explored,
            bandit,
            boss = 67

        
        }
        public TileTypes theTileType;
        public TileType(TileTypes type)
        {
            theTileType = type;
        }

    }*/
   internal class Tyletype
    {
        public string name;
        public char logo;
        public Tyletype(string nme, char lgo)
        {
            name = nme;
            logo = lgo;
        }
    }

    internal class Board
    {
        static public Dictionary<Position, int> manyPosition;

        public static void PrintBoard(int rowsAndCols)
        {
            manyPosition = new Dictionary<Position, int>();
            Random random = new Random();
            for (int row = 0; row < rowsAndCols - 1; row++)
            {
                for (int col = 0; col < rowsAndCols - 1; col++)
                {
                    Console.SetCursorPosition(col, row);
                    if (row == 0 || col == 0 || row == rowsAndCols - 2 || col == rowsAndCols - 2)
                    {
                        Console.Write('█');
                        manyPosition.Add(new Position(row, col), 1);
                    }
                    else
                    {
                        if (random.Next(1, 21) == 2)
                        {
                            Console.Write("¤");
                            //manyPosition
                        }
                        else
                        {
                            Console.WriteLine(".");
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
                    if (y < Program.size-3)
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

