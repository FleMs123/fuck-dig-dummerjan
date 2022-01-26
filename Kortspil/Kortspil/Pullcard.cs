using System;
using System.Collections.Generic;
using System.Text;

namespace Kortspil
{
    class Pullcard
    {
        public static int Pull(List<int> card)
        {
            Random rnd = new Random();
            int kort = rnd.Next(1, 12); //laver et random kort
            card.Add(kort); //tilføjer det random kort til listen
            int last = card[card.Count - 1]; //finder det sidste kort i listen (altså det kort der lige er blevet lavet)
            return last;
        }
    }
}
