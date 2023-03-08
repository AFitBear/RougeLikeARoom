namespace rougeLikeADarkRoom
{
    internal class Board
    {
        public static void PrintBoard(int rowAndCol)
        {
            for (int row = 0; row < rowAndCol - 1; row++)
            {
                for (int col = 0; col < rowAndCol - 1; col++)
                {
                    if (row == 0 || col == 0 || row == rowAndCol - 2 || col == rowAndCol - 2)
                    {
                        Console.SetCursorPosition(col, row);
                        Console.Write('-');
                    }
                }
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

