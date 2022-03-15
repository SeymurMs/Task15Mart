using System;

namespace Task15Mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "HELLO world";
            int element = 4;
            Console.WriteLine(CheckString(ref str));
            //CutString(ref str);
           
            //Console.WriteLine(Replace(ref str, ref int element));

            //int [] arr = {1, 2, 3};
            //AddElement(ref arr );
            //foreach( int i in arr)
            //{
            //    Console.WriteLine( i );
            //}




        }

        static string CutString(ref string word)
        {
          word = word.Trim();

          var result = word.Split(" ");
            Console.WriteLine(result[0]);
            return word;


        }

        static string Replace(ref string input)
        {
            string str = "";
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] != ' ')
                {
                    str += input[i];
                }
                else if (input[i] == ' ' && input[i + 1] != ' ')
                {
                    str += ' ';
                }
            }
            return str;
        }
        static void AddElement(ref int [] arr, ref int element) 
        {
            int [] newNums = new int[arr.Length+1];
          
           arr.CopyTo(newNums,0);
            newNums[newNums.Length - 1] = element; 
            arr = newNums;
           
        }
        static void AddElementResize(ref int[] arr)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = 4;

        }

        static bool CheckString( ref string name)
        {
            int chk  = 0;
            int chk2 = 0;
            int chk3 = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsUpper(name[i]))
                {
                    chk = 1;
                }else if (char.IsLower(name[i]))
                {
                    chk2 = 1;
                }else if (char.IsDigit(name[i]))
                {
                    chk3 = 1;
                }

                
            }
            if (chk ==1 && chk2 ==1 && chk3 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
            
            
            

        }

    }
}
