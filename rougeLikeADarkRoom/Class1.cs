namespace rougeLikeADarkRoom
{
    internal class Board
    {
        public static void PrintBoard(int rowAndCol)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            for (int row = 0; row < rowAndCol - 1; row++)
            {
                for (int col = 0; col < rowAndCol - 1; col++)
                {
                    if (row == 0 || col == 0 || row == rowAndCol - 2 || col == rowAndCol - 2)
                    {
                        Console.SetCursorPosition(col, row);
                        Console.Write('\u25ae');
                    }
                    else
                    {
                        Console.SetCursorPosition(col, row);
                        Console.WriteLine(".");
                    }
                }
            }
        }
    }
    internal class person
    {

        public static void action(ref int x, ref int y)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.UpArrow or ConsoleKey.W:
                    if (y > 2)
                    {
                        y -= 1;
                        Console.SetCursorPosition(x, y);
                        Console.Write('@');
                    }
                    break;
                case ConsoleKey.DownArrow or ConsoleKey.S:
                    if (y < 22)
                    {
                        y += +1;
                        Console.SetCursorPosition(x, y);
                        Console.Write('@');
                    }
                    break;
                case ConsoleKey.RightArrow or ConsoleKey.D:
                    x += +1;
                    if (x < 22)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write('@');
                    }
                    break;
                case ConsoleKey.LeftArrow or ConsoleKey.A:
                    x -= 1;
                    if (x > 1)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write('@');
                    }
                    break;
                default:
                    break;

            }
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

