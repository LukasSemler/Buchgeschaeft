using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Buchgeschaeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(19.99M, 5, "The Malta Exchange", "Steve Berry", "120938120938219038129038219038120938129038", Category.Thriller);
            Newspaper n1 = new Newspaper(0.99M, 500, "Der Standard", new DateTime(2020, 10, 20));
            AudioBook a1 = new AudioBook(14.99M, 10000, "Alea Aquarius 6: Der Fluss des Vergessens", "Tanya Stewner", "091238790128312098390123809", 536, Category.History);
            //Ausgabe
            Console.WriteLine(b1.ToString());
            Console.WriteLine(n1.ToString());
            Console.WriteLine(a1.ToString());
            //Warten
            Console.ReadKey();
        }
    }
}
