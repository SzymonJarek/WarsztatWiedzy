using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mod_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc kalkulator = new Calc();

            Console.WriteLine("Cześć jestem kalkulator");
            Console.WriteLine("Podaj liczbe A i B ");
            var wynik = kalkulator.Dodaj(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(wynik);
            Debugger.Break();
            

            // utworznie obiektu
            Human John = new Human("CDG234123");
            
            // nadanie wieku przez property (get;set;)
            John.Age = 19;

            //Nadanie imienia poprzez funkcje
            John.SetName("John");

            //Pobranie imienia Johna do zmiennej JohnsName
            var johnsName = John.GetName();

            // dodanie przyjaciol do listy
            John.Friends.Add("Ana");
            John.Friends.Add("Tom");
            John.Friends.Add("Maya");

            //wypisanie wszystkich przyjaciol w konsoli
            foreach (var friend in John.Friends)
            {
                Console.WriteLine(friend);
            }

            //other things we did
            if (John.Age < 18)
                Console.WriteLine("John jest niepelnoletni");

            ////inne typy danych:
            ////https://docs.microsoft.com/pl-pl/dotnet/csharp/language-reference/builtin-types/built-in-types

            //Console.WriteLine($"Johns age {John.Age}");
            //Console.ReadKey();
            Console.ReadLine();

        }

    }


    class Human
    {
        public string Id { get; set; }
        private string _name;
        public int Age { get; set; }
        public List<string> Friends { get; set; }

        // Konstruktor - wywolywany podczas tworzenia obiektu
        public Human(string id)
        {
            Id = id;
            //zainicjowanie listy przyjaciol
            Friends = new List<string>();
        }

        //Ta funkcja nic nie zwraca
        public void SetName(string name)
        {
            _name = name;
        }
        
        //ta funkcja zwraca string
        public string GetName()
        {
            return _name;
        }
    }
}
