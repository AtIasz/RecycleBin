using System;

namespace RecycleTheTrashPpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Garbage[] rottenTomatoes = new Garbage[3];
            for (int i = 0; i < 3; i++)
            {
                rottenTomatoes[i] = new Garbage("rotten tomato nr " + (i + 1));
            }
            PlasticGarbage milkJug = new PlasticGarbage("milkjug", false);
            Dustbin trashcan = new Dustbin("blue");
            trashcan.DisplayContents();
            Console.ReadLine();

            for (int i = 0; i <3; i++)
            {
                trashcan.ThrowOutGarbage(rottenTomatoes[i]);
            }
            if (!milkJug.IsClean())
            {
                milkJug.Clean();
            }
            Console.ReadLine();
            trashcan.ThrowOutGarbage(milkJug);
            
            trashcan.DisplayContents();
            Console.ReadLine();
            trashcan.EmptyContents();
            trashcan.DisplayContents();


        }
    }
}
