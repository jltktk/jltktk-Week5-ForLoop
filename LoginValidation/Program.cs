using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada kasutajuatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on kolm katset

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            int i = 1;


            while (i <= 3)

                if (userName != "admin" || userPassword != "admin1234")
                {
                    Console.WriteLine($"Vale kasutaja tunnus või salasõna. Proovi uuesti, sul on {3 - i} katset.");
                    i++;
                    Console.WriteLine("Sisesta kasutajatunnus:");
                    userName = Console.ReadLine();
                    Console.WriteLine("Sisesta salasõna:");
                    userPassword = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }

        }
            
            
        
    }
}
