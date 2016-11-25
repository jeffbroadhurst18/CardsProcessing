namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProcessCards
    {
        List<Card> cardList = new List<Card>();

        public List<Card> CreateCards()
        {
            for (var j = 0; j < 4; j++)
            {
                for (int i = 0; i < 13; i++)
                {

                    Card card = new Card { Suit = (Suits)j, Value = (CardNumbers)i };
                    cardList.Add(card);
                }
            }

            return cardList;


        }


        public List<Card> SortCards(List<Card> cardList)
        {
            IEnumerable<Card> newList = cardList.ToArray();

            var itemList = from t in cardList.ToArray()
                           orderby t.Suit,t.Value
                           select t;
            return itemList.ToList<Card>(); ;
        }


        public void DisplayList(List<Card> cardList,string title)
        {
            Console.WriteLine();
            Console.WriteLine(title);
            var counter = 1;

            foreach (Card card in cardList)
            {
                Console.WriteLine(counter + " " + card.Value + " of " + card.Suit);
                counter++;
            }
            Console.ReadLine();
        }

        public List<Card> ShuffleCards(List<Card> cardList)
        {
            Random rnd = new Random();
           
            for (var x=0; x < 1000; x++)
            {
                var temp = cardList[0];
                var swappoint = rnd.Next(1, 51);

                for (var y=1; y < swappoint+1; y++ )
                {
                    cardList[y - 1] = cardList[y];
                }
                cardList[swappoint] = temp;
            }

            return cardList;
        }
    }
}
