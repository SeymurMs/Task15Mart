using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "hlo orldoiuh";
            Console.WriteLine(check(name));
        }
        static bool check (string name)
        {
           
            var result = name.Split (" ");
            int chk =0;
            if (result.Length==2)
            {

                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsUpper(name[i]))
                    {
                        chk++;
                    }
                    
                       
                }

            }
            if (chk >= 1)
            {
                return true;
            }else
                return false;

            
        }
    }
}
