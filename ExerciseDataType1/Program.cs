using System.ComponentModel.Design;

namespace Excercise_1_WorkerData
{
    //Data structure declaration

    class Program
    {
        public struct Data
        {
            public string Name;
            public string Surname;
            public int Age;
            public char Sex;
            public int Pesel;
            public int WorkerNo;
        }
        private static void Main(string[] args)
        {
            //Structured variable declaration
            Data WorkerData1 = new Data();
            //Name
            Console.WriteLine("Podaj imię pracownika");
            WorkerData1.Name = Console.ReadLine();
            //Surmane
            Console.WriteLine("Podaj nazwisko pracownika");
            WorkerData1.Surname = Console.ReadLine();
            //Age
            Console.WriteLine("Podaj wiek pracownika");
            Int32.TryParse(Console.ReadLine(), out WorkerData1.Age);
            //Sex
            do
            {
                Console.WriteLine("Podaj płeć pracownika k - kobieta, m - meżczyzna");
                Char.TryParse(Console.ReadLine(), out WorkerData1.Sex);
            }
            while (!WorkerData1.Sex.Equals('m') && !WorkerData1.Sex.Equals('k'));
            //Pesel
            Console.WriteLine("Podaj PESEL pracownika");
            Int32.TryParse(Console.ReadLine(), out WorkerData1.Pesel);
            //WorkerNo
            Console.WriteLine("Podaj numer pracownika");
            Int32.TryParse(Console.ReadLine(), out WorkerData1.WorkerNo);

            //Display data
            Console.WriteLine($"Imię: {WorkerData1.Name}");
            Console.WriteLine($"Nazwisko: {WorkerData1.Surname}");
            Console.WriteLine($"Wiek: {WorkerData1.Age}");
            Console.WriteLine($"Płeć: {WorkerData1.Sex}");
            Console.WriteLine($"PESEL: {WorkerData1.Pesel}");
            Console.WriteLine($"Numer pracownika: {WorkerData1.WorkerNo}");
        }
    }



}