using System;

namespace rougeLikeADarkRoom
{
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
        static int bossWay = 0;
        static public Random randoms;
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
            randoms = new Random();
            for (int row = 0; row < rowsAndCols - 1; row++)
            {
                for (int col = 0; col < rowsAndCols - 1; col++)
                {
                    Console.SetCursorPosition(row, col);
                    if (row == 0 || col == 0 || row == rowsAndCols - 2 || col == rowsAndCols - 2)
                    {
                        Console.Write(GetTileTypeInfo(TileType.Types.wall).logo);
                        manyPosition[row][col] = TileType.Types.wall;
                    }
                    else
                    {
                        if (randoms.Next(1, magicnumber) == 2)
                        {

                            //Console.Write("¤");
                            //laver en chance for at lave en chest eller en bandit osv.
                            switch (randoms.Next(0, luckyness))
                            {
                                case < 10 when 4 < 5:
                                    Draww.Paint(row,col,GetTileTypeInfo(TileType.Types.chest).logo.ToString(), GetTileTypeInfo(TileType.Types.chest).color);
                                    manyPosition[row][col] = TileType.Types.chest;
                                    break;
                                case > 9:
                                    Draww.Paint(row, col, GetTileTypeInfo(TileType.Types.bandit).logo.ToString(), GetTileTypeInfo(TileType.Types.bandit).color);
                                    manyPosition[row][col] = TileType.Types.bandit;
                                    break;
                                default:
                                    manyPosition[row][col] = TileType.Types.unexplored;
                                    break;
                            }


                        }
                        else
                        {
                            Draww.Paint(row, col, GetTileTypeInfo(TileType.Types.unexplored).logo.ToString(), GetTileTypeInfo(TileType.Types.unexplored).color);
                            manyPosition[row][col] = TileType.Types.unexplored;
                        }
                    }
                }
            }
            
                if (Program.level % 2 == 0)
                {
                Draww.Paint(1, 1, GetTileTypeInfo(TileType.Types.boss).logo.ToString(), GetTileTypeInfo(TileType.Types.boss).color);
                Console.SetCursorPosition(1, 1);
                    Console.Write(GetTileTypeInfo(TileType.Types.boss).logo);
                    manyPosition[1][1] = TileType.Types.boss;
                    //Draww.Paint(rowsAndCols - 3, 1, "@", ConsoleColor.Green);
                }
                else
                {
                Draww.Paint(rowsAndCols-3, 1, GetTileTypeInfo(TileType.Types.boss).logo.ToString(), GetTileTypeInfo(TileType.Types.boss).color);
                    manyPosition[rowsAndCols - 3][1] = TileType.Types.boss;
                    //Draww.Paint(1, 1, "@", ConsoleColor.Green);
                }
            


            manyPosition[2][5] = TileType.Types.wall;
            Console.SetCursorPosition(2, 5);
            Console.Write(GetTileTypeInfo(TileType.Types.wall).logo);


        }
        public static (string name, char logo, ConsoleColor color) GetTileTypeInfo(TileType.Types theTile)
        {
            switch (theTile)
            {
                case TileType.Types.wall:
                    return ("wall", '█', ConsoleColor.White);

                case TileType.Types.unexplored:
                    return ("une", '.', ConsoleColor.White);

                case TileType.Types.explored:
                    return ("exp", '+', ConsoleColor.DarkGreen);

                case TileType.Types.chest:
                    return ("chest", 'c', ConsoleColor.Yellow);

                case TileType.Types.bandit:
                    return ("band", 'b', ConsoleColor.Red); 
                     
                case TileType.Types.boss:
                    return ("boss", 'B', ConsoleColor.DarkRed);
                default:
                    return ("null", '?', ConsoleColor.DarkMagenta);
            }
        }
        public static TileType.Types CheckTileType(int x, int y)
        {
            return manyPosition[x][y];
        }
        public static void CheckAction(TileType.Types typetilswitch)
        {
            //manyPosition(x,y) //check what tile function, with a return. then have that return be the int or something
            //checks what action need to be done. like if you are on a bandit tile then i does bandit action
            switch (typetilswitch)
            {
                case TileType.Types.unexplored://går på en ikke explorede tile
                    if (randoms.Next(0, 10) == 3)
                    {
                        Console.SetCursorPosition(50, 26);
                        Console.WriteLine("BanditAction       ");
                        Fight.setupUpdateFighters(Program.level);//initilysing fighters
                        Fight.BanditFight(randoms.Next(1, Fight.allFighters.Length));
                    }
                    break;
                case TileType.Types.explored://går på en explored tile

                    break;
                case TileType.Types.chest://chest
                    //Fight.ChestAction();
                    Console.SetCursorPosition(50, 26);
                    Console.WriteLine("ChestAction          ");
                    break;
                case TileType.Types.bandit://bandit fight
                    Console.SetCursorPosition(50, 26);
                    Console.WriteLine("BanditAction            ");
                    Fight.setupUpdateFighters(Program.level);//initilysing fighters
                    Fight.BanditFight(randoms.Next(1, Fight.allFighters.Length));
                    break;
                case TileType.Types.boss://Boss fight
                    Console.SetCursorPosition(50, 26);
                    Console.WriteLine("BossAction          ");
                    Fight.setupUpdateFighters(Program.level);//initilysing fighters
                    Fight.BossFight();
                    break;
                default:
                    break;
            }
        }
    }

    internal class person
    {
        public static void action(ref int x, ref int y)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);//There need to be "true" so it intercepts the thing i write.AKA it does not wirte the letter I press down.
            Draww.Paint(x,y, Board.GetTileTypeInfo(TileType.Types.explored).logo.ToString(), Board.GetTileTypeInfo(TileType.Types.explored).color);
            Board.manyPosition[x][y] = TileType.Types.explored;
            switch (key.Key)
            {
                case ConsoleKey.UpArrow or ConsoleKey.W:
                    if (Board.manyPosition[x][y - 1] != TileType.Types.wall)
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.DownArrow or ConsoleKey.S:
                    if (Board.manyPosition[x][y + 1] != TileType.Types.wall)
                    {
                        y++;
                    }
                    break;
                case ConsoleKey.RightArrow or ConsoleKey.D:
                    if (Board.manyPosition[x + 1][y] != TileType.Types.wall)
                    {
                        x++;
                    }
                    break;
                case ConsoleKey.LeftArrow or ConsoleKey.A:
                    if (Board.manyPosition[x - 1][y] != TileType.Types.wall)
                    {
                        x--;
                    }
                    break;
                default:
                    break;

            }
            Draww.Paint(x, y, "@", ConsoleColor.Green);

        }
        public static void Setup()
        {

            //Console.OutputEncoding=System.Text.Encoding.UTF8; //If it ever comes to using more complex text..
            Console.ForegroundColor = Fight.themeColor;
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 60);
            Console.WriteLine("My name is Yoshikage Kira. I'm 33 years old. ");
            Console.WriteLine("My house is in the northeast section of Morioh, where all the villas are, and I am not married.");
            Console.WriteLine("I work as an employee for the Kame Yu department stores, and I get home every day by 8 PM at the latest.");
            Console.WriteLine("I don't smoke, but I occasionally drink.");
            Console.WriteLine("I’m in bed by 11 PM, and make sure I get eight hours of sleep, no matter what.");
            Console.WriteLine("After having a glass of warm milk and doing about twenty minutes of stretches before going to bed, ");
            Console.WriteLine("I usually have no problems sleeping until morning.");
            Console.WriteLine("Just like a baby, I wake up without any fatigue or stress in the morning. ");
            Console.WriteLine("I was told there were no issues at my last check-up.");
            Console.WriteLine("I’m trying to explain that I’m a person who wishes to live a very quiet life.");
            Console.WriteLine("I take care not to trouble myself with any enemies, like winning and losing, that would cause me to lose sleep at night.");
            Console.WriteLine("That is how I deal with society, and I know that is what brings me happiness. ");
            Console.WriteLine("Although, if I were to fight I wouldn’t lose to anyone.");
            Console.WriteLine("This is, The Killer Quuen's Trap.");
        }
    }
    public static class Draww
    {
        public static void Paint(int x, int y, string sym, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            Console.ForegroundColor = Fight.themeColor;
        }
        public static void Paint0(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▄▄▄");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("█ █");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("█▄█");
        }
        public static void Paint1(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ▄ ");
            Console.SetCursorPosition(x, y + 1);
            Console.Write(" █ ");
            Console.SetCursorPosition(x, y + 2);
            Console.Write(" █ ");
        }
        public static void Paint2(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("█▀█");
            Console.SetCursorPosition(x, y + 1);
            Console.Write(" ▄▀");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("█▄▄");
        }
        public static void Paint3(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▄▄▄");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("▄▄█");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("▄▄█");
        }
        public static void Paint4(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▄ ▄");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("█▄█");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("  █");
        }
        public static void Paint5(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▄▄▄");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("█▄▄");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("▄▄█");  //█▄▀
        }
        public static void Paint6(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▄▄▄");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("█▄▄");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("█▄█");
        }
        public static void Paint7(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▄▄▄");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("  █");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("  █");
        }
        public static void Paint8(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▄▄▄");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("█▄█");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("█▄█");
        }
        public static void Paint9(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▄▄▄");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("█▄█");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("  █");
        }
    }

}

