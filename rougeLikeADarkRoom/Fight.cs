namespace rougeLikeADarkRoom
{

    internal class Fight
    {
        public static int boxStart;
        public static int colSize;
        public static Fighters[] allFighters = new Fighters[5];
        static public void PrintFight(int size)
        {
            int rowSize = 28;
            colSize = 8;
            boxStart = size + 11;
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
            Console.SetCursorPosition(boxStart + rowSize - 11, 1);
            Console.WriteLine("Enemy HP");
        }
        static public void BanditFight()
        {
            Console.SetCursorPosition(50, 27);
            Console.WriteLine("sergfsefeffBBAANNDDIITT");
            Thread.Sleep(188);
            Console.SetCursorPosition(50, 27);
            Console.WriteLine("                         ");
            Console.SetCursorPosition(boxStart+6, colSize/2);
            Console.Write('@');
            Random random = new Random();
            int nowFighter = random.Next(1, 5);
            Console.SetCursorPosition(boxStart + 6+6, colSize / 2);
            Console.WriteLine(allFighters[nowFighter].logo);
        }
        static public void BossFight()
        {
            Console.SetCursorPosition(50, 27);
            Console.WriteLine("awdsdesfBOSSS");
            Program.level++;
            setupUpdateFighters(Program.level);
        }
        static public void setupUpdateFighters(int level)
        {
            allFighters[0] = new Fighters("Boss",'B', ScaleMultiplyInt(30, level), ScaleMultiplyInt(70, level),10);
            allFighters[1] = new Fighters("bandit",'b', ScaleMultiplyInt(4, level), ScaleMultiplyInt(25, level), 10);
            allFighters[2] = new Fighters("Thief",'t', ScaleMultiplyInt(3, level), ScaleMultiplyInt(18, level), 10);
            allFighters[3] = new Fighters("Corrupt Knight",'k', ScaleMultiplyInt(6, level), ScaleMultiplyInt(20, level), 10);
            allFighters[4] = new Fighters("Archer",'a', ScaleMultiplyInt(8, level), ScaleMultiplyInt(18, level), 10);
        }
        public static int ScaleMultiplyInt(int temp, int level)
        {
            double temp1 = temp * 1 + (0.5 * level);
            return Convert.ToInt32(temp1);
        }
        /*public static int ScaleDiffMultiInt(int temp, int level)
        {
            double temp1 = temp * 1.5;
            return Convert.ToInt32(temp1);
        }*/


    }
    internal class Fighters
    {
        public string name { get; set; }
        public char logo { get; set; }
        public int damage { get; set; }
        public int hP { get; set; }
        public int dropTable { get; set; }
        public int coolDown { get; set; }
        public Fighters(string name,char logo, int damage, int HP, int coolDown)
        {
            this.name = name;
            this.logo = logo;
            this.damage = damage;
            this.hP = HP;
            this.coolDown = coolDown;
        }
    }
    internal class Player
    {
        static int playerHP = 60;
        int playerDamage = 2;
        static public List<Item> inventory=new List<Item>();



        static public bool ChechIfDed()
        {
            if (playerHP > 0)
            {
                return false;
            }
            return true;
        }


        static public void setupItems()//im gonna have item scale with level. maybe higher levels grants higher level items, then randomize the level later and the amount. 
        {
            Item bread = new Item("Bread",1,1,true,1);
            bread.amount++;
        }
    }
    
    internal class Item
    {
        public string name { get; set; }
        public int amount { get; set; }
        public int damage { get; set; }
        public bool isArmor { get; set; }
        public int coolDown { get; set; }
        public Item(string name, int amount,int damage, bool isArmor, int coolDown)
        {
            this.name = name;
            this.amount = amount;
            this.damage = damage;
            this.isArmor = isArmor;
            this.coolDown = coolDown;
        }
    }
}
