using System;
namespace console6
{
    public class Program2
    {
        public static string Run()
        {
            int[] values = { 1, 3, 4, 6, 5, 2, 99, 43 };
            Sort1(values);
            return values.ToString();
        }

        public static void Sort1(int[] vals)
        {
            bool swap;

            do {
                swap = false;

                for (int idx = 0; idx < vals.Length - 1; idx++)
                {             
                    var curr = vals[idx];

                    if (curr > vals[idx + 1])
                    {
                        swap = true;
                        vals[idx] = vals[idx + 1];
                        vals[idx + 1] = curr;
                    }
                }
            } while (swap);
        }

    }
}
