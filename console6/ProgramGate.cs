using System;
using System.Reflection;

namespace console6
{

    class ProgramGate
    {

        public static void Main(string[] args)
        {
            ReflectMainGate("5");
        }


        public static void ReflectMainGate(string arg)
        {
            Type t = Type.GetType("console6.Program" + arg);
            MethodInfo method = t.GetMethod("Run");  //= t.GetMethod("Run", BindingFlags.Static | BindingFlags.Public);

            //method.Invoke(null,null);

            var returnedfrom = method.Invoke(null, null);

            Console.WriteLine(returnedfrom);
            Console.ReadLine();
        }


        //public static void MainGate(string arg)
        //{
        //    string temp = "";

        //    if (arg == "0")
        //    {
        //        temp = "0";
        //    }
        //    else if (arg == "1")
        //    {

        //    }
        //    else if (arg == "2")
        //    {
        //        temp = Program2.Run();
        //    }
        //    else if (arg == "3")
        //    {
        //        temp = Program3.Run();
        //    }

        //    Console.WriteLine(temp);
        //    Console.ReadLine();
        //}


    }
}
