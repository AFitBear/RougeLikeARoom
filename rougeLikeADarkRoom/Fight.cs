namespace rougeLikeADarkRoom
{

    internal class Fight
    {
        static public void PrintFight(int size)
        {
            int rowSize = 18;
            int colSize = 8;
            int boxStart = size + 11;
            Console.Write('s');
            for (int row = boxStart; row < rowSize + boxStart - 1; row++)
            {
                for (int col = 0; col < colSize - 1; col++)
                {
                    Console.SetCursorPosition(row, col);
                    if (row == boxStart || col == 0 || row == rowSize + boxStart - 2 || col == colSize - 2)
                    {
                        Console.Write('█');
                    }
                }
            }
            Console.SetCursorPosition(boxStart+3,colSize-1);
            Console.WriteLine("Fight-Box");
        }
        static public void BanditFight()
        {
            Console.SetCursorPosition(50, 27);
            Console.WriteLine("sergfsefeffBBAANNDDIITT");
        }
        static public void BossFight()
        {
            Console.SetCursorPosition(50, 27);
            Console.WriteLine("awdsdesfBOSSS");
        }
    }
}
