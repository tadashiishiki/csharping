using System;

namespace console6
{
    public class Program5
    {

        public static string Run()
        {

            string[] kudamono = { "apples", "oranges", "chirimoyas" };

            displayer<string>(kudamono, (s) => { Console.WriteLine(s + "(nice!)"); } );


            int[] mynumber = { 90,3436,925};

            displayer<int>(mynumber, (n) => { Console.WriteLine(n); });

            return "done";
        }


        public static void displayer<T>(T[] fruits, Action<T> adisplayer)
        {
            for (int i = 0; i < fruits.Length; i++)
            {
                T f = fruits[i];
                adisplayer(f);
            }
        }

    }
}
