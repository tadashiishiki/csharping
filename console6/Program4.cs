using System;
using System.Text; //StringBuilder

namespace console6
{
    //public class Program4
    public static class Program4
    {
        public static string Run()
        {
            string[] hamlet =  {"to", "be", "or", "not", "to", "be"};
            return hamlet.stringjoiner( "-" );
        }

        
    
  
            public static string stringjoiner(this string[] strings, string separator)
            {
                bool first = true;
                var builder = new StringBuilder();
                foreach (var s in strings)
                {
                    if (!first) builder.Append(separator);
                    else
                        first = false;
                    builder.Append(s);
                }
                return builder.ToString();
            }
        
    
}
}
