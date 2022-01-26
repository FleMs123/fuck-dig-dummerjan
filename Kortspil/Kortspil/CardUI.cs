using System;
using System.Collections.Generic;
using System.Text;

namespace Kortspil
{
    public class CardUI
    {
        public string Card(int CardNum) //Laver kortet til en færdig string som kan printes til console
        {
            Random rnd = new Random();
            int CardID = rnd.Next(1, 5); //Der er ikke valgt kort type 

            string CardPic = CardLogo(CardID);

            if (CardNum < 10) //Da 10 og 11 har et ekstra cifer skal de bruge lidt mere plads at skrive på uden at kortets side er rykket
            {
                string cardPicture = (
                         $"\n┌─────────┐\n│ {CardPic} {CardNum}     │\n│         │\n│         │\n│         │\n│     {CardNum} {CardPic} │\n└─────────┘");
                return cardPicture;
            }
            else // Hvis kortet er større end 10 er det fjernet to mellemrum
            {
                string cardPicture = (
                         $"\n┌─────────┐\n│ {CardPic} {CardNum}    │\n│         │\n│         │\n│         │\n│    {CardNum} {CardPic} │\n└─────────┘");
                return cardPicture;
            }
        }

        string CardLogo(int CardID)
        {
            string CardPic;
            if (CardID == 1)
            {
                CardPic = "♠";
                return CardPic;
            }
            else if (CardID == 2)
            {
                CardPic = "♦";
                return CardPic;
            }
            else if (CardID == 3)
            {
                CardPic = "♥";
                return CardPic;
            }
            else
            {
                CardPic = "♣";
                return CardPic;
            }
        }
    }
}
