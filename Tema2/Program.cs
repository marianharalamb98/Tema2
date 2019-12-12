using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Tema";
            string s2 = "numarul";
            string s3 = "doi";
            string s4 = "tema";
            string s5 = "Tema numarul 2";
            //Console.WriteLine(s1 + " " + s2+ " " + s3);

            string emptyString = string.Empty;

            /*
            if (string.IsNullOrEmpty(emptyString))
            {
                Console.WriteLine("Stringul este gol sau null");
            }
            else
            {
                Console.WriteLine("Stringul nu este gol sau null ");
            }
            if (string.IsNullOrEmpty(s1))
            {
                Console.WriteLine("Stringul este gol sau null");
            }
            else
            {
                Console.WriteLine("Stringul nu este gol sau null ");
            }
            */

            /*
            if (string.Compare(s1,s4) == 0)
            {
                Console.WriteLine("Stringuri identice");
            }
            else
            {
                Console.WriteLine("Stringuri diferite");
            }
            */

            /*
            string replacedString = s5.Replace("Tema", "Sarcina");
            Console.WriteLine(s5);
            Console.WriteLine(replacedString);
            */

            /*
            string concatenatedString = string.Concat(s1," ", s2," ", s3);
            Console.WriteLine(concatenatedString);
            */

            /*
            string upperCaseString = s5.ToUpper();
            string lowerCaseString = s5.ToLower();
            Console.WriteLine("Sirul scris cu litere mari: " + upperCaseString);
            Console.WriteLine("Sirul scris cu litere mici: " + lowerCaseString);
            */

            /*
            string searchString = "numarul";
            if(s5.Contains(searchString))
            {
                Console.WriteLine("Textul contine string ul cautat");
            }
            else
            {
                Console.WriteLine("Textul nu contine string ul cautat");
            }
            */

        }
    }
}
