using System;

namespace console6
{

    public class Program3
    {

        public delegate bool comparer(object a, object b);


        public static bool doublecomparer(object a, object b)
        {
            return (Convert.ToDouble(a)) > (Convert.ToDouble(b));              
        }

        public static bool stringcomparer(object a, object b)
        {
            return ( (string) a)[0] > ((string)b)[0];
        }


        public static string Run()
        {
            object[] values = { 1, 3, 4.1, 6.3, 5, 2, 99, 43 };
            Sort1(values,doublecomparer);

            object[] fruits = { "oranges", "apples", "chirimoyas" };
            Sort1(fruits, stringcomparer);

            return "check them debugging";
        }
        

        public static void Sort1(object[] vals, comparer acomparer)
        {
            bool swap;

            do
            {
                swap = false;

                for (int idx = 0; idx < vals.Length - 1; idx++)
                {
                    var curr = vals[idx];

                    if ( acomparer(curr, vals[idx + 1]) )
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
