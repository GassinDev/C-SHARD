using System;

namespace cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "patata";

            int i;

            for (i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }


            // s[0] = "P"; //

            string s2 = s;

            s = s + "!";
            s = s + 55;

            Console.WriteLine(s);
            Console.WriteLine(s2);

            string s3 = "P";


            for (i = 1; i < s2.Length; i++)
            {

                s3 = s3 + s2[i];
            }

            Console.WriteLine(s3);

            string s4 = "P" + s2.Substring(1);
            Console.WriteLine(s4);
        }

        //----------------------------------------------------------------------------------//
        string sb;

        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        sb.Append("P");
        
        for (i = 1; i<s2.Length: i++)
        {
                      sb.Append(s2[i]);
        }


         string s5 = sb.ToSring();




    }
}
