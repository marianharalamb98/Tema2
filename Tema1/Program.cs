using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {

            int month;
            string nameMonth;
            //  Console.WriteLine("Cititi luna de nastere(intre 1 si 12):");

            do
            {
                Console.WriteLine("Cititi luna de nastere(intre 1 si 12):");
                nameMonth = Console.ReadLine();
                month = Convert.ToInt32(nameMonth);

            } while (month > 12 || month < 1);


            int day;
            string nameDay;
            do
            {
                Console.WriteLine("Cititi ziua de nastere(intre 1 si 31,depinzand de luna):");
                nameDay = Console.ReadLine();
                day = Convert.ToInt32(nameDay);
            } while (day < 1 || day > 31);



            int year;
            string nameYear;
            do
            {
                Console.WriteLine("Cititi anul nasterii(intre 0 si 2019):");
                nameYear = Console.ReadLine();
                year = Convert.ToInt32(nameYear);
            } while (year < 1 || year > 2019);

            string letter;
            do
            {
                Console.WriteLine("Cititi genul");
                letter = Console.ReadLine();
            } while (letter != "M" && letter != "F");
            int ageOfPerson;
            genders? gender = null;

            DateTime now = DateTime.Now;

            DateTime birthday = new DateTime(year, month, day);

            Console.WriteLine(birthday.ToString("dd/MMM/yyyy"));


            if (now.Month <= birthday.Month && now.Day <= birthday.Day)
            {
                ageOfPerson = now.Year - birthday.Year;
            }
            else
            {
                ageOfPerson = now.Year - birthday.Year - 1;
            }
            Console.WriteLine("Persoana are: " + ageOfPerson + " ani.");

            if (letter == "M")
            {
                gender = genders.Male;
                if (ageOfPerson > 65)
                {
                    Console.WriteLine("Barbat pensioant");
                }
                else
                {
                    Console.WriteLine("Barbatul se va pensiona la 65 ani");
                }
            }
            else if (letter == "F")
            {
                gender = genders.Female;
                if (ageOfPerson > 63)
                {
                    Console.WriteLine("Femeie pensioanta");
                }
                else
                {
                    Console.WriteLine("Femeia se va pensiona la 63 ani");
                }
            }
            else
            {
                Console.WriteLine("Gen inexistent");
            }




        }

        public enum genders
        {
            Male,
            Female
        }

    }
}
