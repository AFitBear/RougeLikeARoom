namespace rougeLikeADarkRoom
{

    internal class Fight
    {
        static int playerHP = 60;
        int playerDamage = 2;
        public static Fighters[] allFighters =new Fighters[5];
        static public void PrintFight(int size)
        {
            int rowSize = 28;
            int colSize = 8;
            int boxStart = size + 11;
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
            Console.SetCursorPosition(boxStart + 3, colSize - 1);
            Console.WriteLine("Fight-Box");
            Console.SetCursorPosition(boxStart + 1, 1);
            Console.WriteLine("Your HP");
            Console.SetCursorPosition(boxStart+rowSize - 11, 1);
            Console.WriteLine("Enemy HP");
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
            Fighters bandit = new Fighters("bandit", 1, 60);
            Program.level++;
            setupUpdateFighters(Program.level);
        } 
        static public void setupUpdateFighters(int level)
        {
            allFighters[0] = new Fighters("Boss", ScaleMultiplyInt(30,level), ScaleMultiplyInt(70,level));
            allFighters[1] = new Fighters("bandit", ScaleMultiplyInt(4,level), ScaleMultiplyInt(25,level));
            allFighters[2] = new Fighters("Thief", ScaleMultiplyInt(3,level), ScaleMultiplyInt(18,level));
            allFighters[3] = new Fighters("Corrupt Knight", ScaleMultiplyInt(6,level), ScaleMultiplyInt(20,level));
            allFighters[4] = new Fighters("Archer", ScaleMultiplyInt(8,level), ScaleMultiplyInt(18, level));
        }
        public static int ScaleMultiplyInt(int temp, int level)
        {
            double temp1 = temp * 1+(0.5*level);
            return Convert.ToInt32(temp1);
        }
        /*public static int ScaleDiffMultiInt(int temp, int level)
        {
            double temp1 = temp * 1.5;
            return Convert.ToInt32(temp1);
        }*/

        static public bool ChechIfDed()
        {
            if (playerHP > 0)
            {
                return false;
            }
            return true;
        }

    }
    internal class Fighters
    {
        public string name { get; set; }
        public int damage { get; set; }
        public int HP { get; set; }
        public Fighters(string name, int damage, int HP)
        {
            this.name = name;
            this.damage = damage;
            this.HP = HP;
        }
    }
}
