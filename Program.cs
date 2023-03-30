using System;

namespace passwort
{
    class Program
    {
        static void Main(string[] args)
        {
            string pwort;
            bool bedingung = false;
            Console.WriteLine("8 zeichen und mindestens 1 Großenbuchtaben");
        passwort:
            Console.Write("Pasworteingeben :");
            pwort= Console.ReadLine();
            if(pwort.Length<8)
            {
                Console.WriteLine("zu kurz!");
                goto passwort;
            }
            else if (!HatUpperCase(pwort))
            {
                Console.WriteLine("kein großebuchtaben");
                goto passwort;
            }
            else if (!HatDigit(pwort))
            {
                Console.WriteLine("kein zahl");
                goto passwort;
            }
            else
            {
                Console.WriteLine("paswort korrekt");
            }
            Console.ReadLine();
        }
        static bool HatUpperCase(string s)
        {
            bool bedingung=false;
            for(int i = 0; i < s.Length;i++)
            {
                if(char.IsUpper(s[i]))
                    bedingung= true;
            }
            return bedingung;
        }

        static bool HatDigit(string s)
        {
            bool bedingung = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                   bedingung = true;
            }     
         return bedingung;

        
            
        }
    }
}
