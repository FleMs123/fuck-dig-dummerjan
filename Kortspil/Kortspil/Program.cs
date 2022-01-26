using System;
using System.Collections.Generic;
using System.Linq; //Se vi har brugt LINQ
using System.Threading;


namespace Kortspil
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pulledCards = new List<int>(); //laver liste


            AI AI = new AI();                       //
            CardUI pic = new CardUI();              //
            Pullcard Pullcard = new Pullcard();     //


        playgame:
            Console.Clear();
            Console.WriteLine("WELCOME TO BLACKJACK \n WHAT DO YOU WANT TO DO \n PLAY(1) . | . LEARN THE RULES(2)"); 
            string playerAction = Console.ReadLine();


            if (playerAction == "1")
            {
                Console.WriteLine($"Dine kort er  {pic.Card(Pullcard.Pull(pulledCards))} {pic.Card(Pullcard.Pull(pulledCards))}."); //giver 2 random kort
                FuckYouTony:
                int my_sum = pulledCards.Sum();
                if (my_sum > 21) //hele if statementet gør at at hvis summen går over 21 så slutter programmet
                {
                    Console.WriteLine("Du tabte hahahahahahahahahahahaha");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine($"I alt har du {my_sum}"); //giver summen af listen
                Console.WriteLine("Vil du have et kort mere Y/N?");
                string extraKort = Console.ReadLine().ToUpper();

                if (extraKort == "Y")
                {
                    Console.Clear();
                    Pullcard.Pull(pulledCards);
                    foreach (int bruh in pulledCards)
                    {
                        Console.WriteLine(pic.Card(bruh));
                    }
                    goto FuckYouTony;
                    //Den her får console til at clear og så trækker den et nyt kort og så viser den alle de nye kort sammen med de gamle
                }
                else
                {
                    int aiSum = AI.AIBrain();
                    Console.WriteLine(aiSum);
                    if (my_sum > aiSum)
                    {
                        Console.Clear();
                        Console.WriteLine("TILLYKKE DU VANDT VORES ULTRA SVÆRE SPIL, SOM VI SELV HAR FUNDET PÅ UDEN HJÆLP FRA NOGEN OVERHOVEDET.");
                    }
                    else if (my_sum < aiSum)
                    {
                        Console.Clear();
                        Console.WriteLine("SOM FORVENTET HAR DU TABT TIL VORES FANTASTISKE AI SOM IKKE HAR NOGEN FEJL OVERHOVEDET    L L L L L L L L L L L");
                    }
                    else
                    {
                        Console.WriteLine("wtf happend hree?");
                    }
                }
            }
            else  //forklare reglerne i spillet
            {
                Console.WriteLine("Hvorfor gør du ikke det? Det skulle du jo have tænkt over inden du startede spillet! \n");
                Thread.Sleep(2000);
                Console.WriteLine("Du får først og fremmest 2 kort. Så får du den samlede værdi af de 2 kort. \n");
                Thread.Sleep(2000);
                Console.WriteLine("målet med spillet er at få 21 eller komme så tæt på som muligt \n");
                Thread.Sleep(2000);
                Console.WriteLine("når du så mener at du er kommet så tæt på som muligt vælger du bare ikke at få flere kort \n");
                Thread.Sleep(2000);
                Console.WriteLine("så spiller computeren også og hvis computeren får under dig så vinder du men hvis den får over dig så taber du. \n");
                Thread.Sleep(2000);
                Console.WriteLine("hvis du får over 21 så taber du automatisk \n");
                Thread.Sleep(2000);
                Console.WriteLine("Held og lykke \n");
                Console.WriteLine(">> TRYK PÅ KEYBOARD FOR AT FORTSÆTTE <<");
                Console.ReadKey();
                goto playgame;
            }
        } 
    }
}

