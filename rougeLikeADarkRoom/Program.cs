namespace rougeLikeADarkRoom
{
    internal class Program
    {
        static public int size;
        static void Main(string[] args)
        {
            Console.WriteLine("gg");
            /*int rows = 20;
            int cols = rows;*/
            int length = 20;
            size= length;

            ItemClasses itemClasses = new ItemClasses();
            Board boardPrint = new Board();
            Board.PrintBoard(size);



            const float TARGET_FPS = 4f; // Frame rate (ønsket)
            const float TARGET_FRAME_TIME = 1f / TARGET_FPS; // Tid per frame
            DateTime previousFrameTime;
            float elapsedTime = 0f;

            while (true)
            {
                previousFrameTime = DateTime.UtcNow;
                elapsedTime = (float)(DateTime.UtcNow - previousFrameTime).TotalSeconds;
                if (elapsedTime < TARGET_FRAME_TIME)
                {
                    // Hvis en frame tid ikke er forløbet endnu, sov lidt:
                    int sleepTime = (int)((TARGET_FRAME_TIME - elapsedTime) * 1000);
                    System.Threading.Thread.Sleep(sleepTime);
                }
            }
            //new ItemClasses { Catogorie = ItemClasses.Catogory.Healing, heiling = ItemClasses.Healing.bread, durability = 6 };
        }
    }
}