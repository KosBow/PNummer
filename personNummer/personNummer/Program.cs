using System;
namespace personNummer
{
    internal class Program
    {
        /*
        Group 12
        Oskar Laulajainen
        Khosrat Abobakri
        */
        static bool isValidPNR(string number)
        {
            
            int[] myNum = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 }; // En Array för luhn algorithm.
            int resultat = 0;
            if (number.Length != 10) // Om Personnummret inte är 10 så gör den return på false.
            {
                Console.WriteLine("Ange ett 10 siffrigt personnummer!");
                return false;
            }


            for (int i= 0; i < number.Length; i++) // Tar tal från arryan och number och multiplacerar, om större än 9 gör uträkningen
            {
                int multi = myNum[i] * int.Parse(number[i].ToString());
                if (multi > 9)
                {
                    multi = multi % 10 + multi / 10;
                }
                resultat += multi;
            }
            return (resultat % 10 == 0);


        }
        public static void Main(string[] args) 
        {
            Console.Write("Ange ditt personnummer"); // En Output som frågar om ditt personnummer.
            string personNummer = Console.ReadLine(); // En Input på inmatningen.
            if (isValidPNR(personNummer))
            {
                Console.WriteLine("Giltigt personnummer.");
            }
            else
            {
                Console.WriteLine("Ej giltigt personnummer.");
            }
        }
    }
}