using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace Kortspil
{
    class AI
    {
        public static int AIBrain()
        {
            List<int> aipulledCards = new List<int>();
            Pullcard Pullcard = new Pullcard();
            Program Main = new Program();
            CardUI pic = new CardUI();

            Console.Clear();
            Console.WriteLine(pic.Card(Pullcard.Pull(aipulledCards)) + pic.Card(Pullcard.Pull(aipulledCards)));
            FuckYouEzekiel:
            int mySum = aipulledCards.Sum();
            Thread.Sleep(2000);
            
            if(mySum < 17)
            {
                Console.Clear();
                Pullcard.Pull(aipulledCards);
                foreach (int bruh in aipulledCards)
                {
                    Console.WriteLine(pic.Card(bruh));
                    Thread.Sleep(300);
                }
                goto FuckYouEzekiel;
            }
            else if (mySum > 16)
            {
                Console.WriteLine(mySum);
            }
            else if (mySum > 21)
            {
                Console.WriteLine("FUUUUUCK UMULIGT JEG KAN IKKE TABE");
                Thread.Sleep(2000);
                Console.WriteLine("FUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUCK");
            }

            return mySum;
        }
    }
}
