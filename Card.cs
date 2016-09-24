using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public enum Suits
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }


    public enum CardNumbers
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {
        public Suits Suit { get; set; }
        public CardNumbers Value { get; set; }
        
    }
}
