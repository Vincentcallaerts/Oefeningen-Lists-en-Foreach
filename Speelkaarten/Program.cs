using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speelkaarten
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Speelkaart> deck = new List<Speelkaart>();
            Suite teken = Suite.Harten;
            Random random = new Random();
            bool running = true;

            for (int i = 0; i < 4; i++)
            {
                
                for (int j = 0; j < 13; j++)
                {
                    
                    deck.Add(new Speelkaart(j+1, teken));
                }
                teken++;
            }

            while (running)
            {
                
                if (deck.Count == 0)
                {
                    Console.WriteLine("Deck is leeg");
                    Console.ReadLine();
                    running = false;
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition((Console.WindowWidth - 33) / 2, 0);

                    int kaart = random.Next(deck.Count);
                    
                    Console.WriteLine("Druk Iets om een kaart te trekken");
                    Console.ReadKey();

                    Console.WriteLine(deck[kaart].Teken + " " + deck[kaart].Waarde);
                    Console.ReadKey();

                    deck.RemoveAt(kaart);
                }
                
            }
            
            Console.ReadLine();
        }
    }
}
