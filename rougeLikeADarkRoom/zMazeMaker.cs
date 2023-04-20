namespace rougeLikeADarkRoom
{
    internal class Position
    {
        public int x;
        public int y;
        public bool up;
        public bool down;
        public bool left;
        public bool right;

        public Position(int x, int y, bool up, bool down, bool left, bool right)
        {
            this.x = x;
            this.y = y;
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
        }
    }
    internal class zMazeMaker
    {
        public static void MakeMazez()
        {
            Dictionary<Position, bool> dict = new Dictionary<Position, bool>();

            int colSize = 16;
            int rowSize = 24;
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                    if (i == 0 || i == rowSize - 1 || j == 0 || j == colSize - 1)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write('█');
                        Position vegg = new Position(i, j, false, false, false, false);
                        dict.Add(vegg, true);
                    }
            }
            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("seesf");
            int lang = 20;
            int x = 3;
            int y = 0;
            int xg;
            int yg;
            Console.SetCursorPosition(x, y);
            Console.Write("█");
            while (lang > 1)
            {
                xg = random.Next(1, 2);
                yg = random.Next(1, 2);
                if (x + xg < 0 || x + xg > rowSize - 2)
                { continue; }
                if (y + yg < 0 || y + yg > colSize - 2)
                { continue; }
                x = +xg;
                y = +yg;
                lang=-1;
                Console.SetCursorPosition(x, y);
                Console.Write("█");
            }

        }
    }
}
