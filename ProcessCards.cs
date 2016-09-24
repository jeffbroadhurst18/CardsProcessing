namespace Cards
{
    using System;
    using System.Collections.Generic;

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
            for (var x = 0; x < cardList.Count - 1; x++)
            {
                for (var y = x + 1; y < cardList.Count; y++)
                {
                    if (cardList[x].Suit > cardList[y].Suit || (cardList[x].Suit == cardList[y].Suit) && (cardList[x].Value > cardList[y].Value))
                    {
                        var temp = cardList[x];
                        cardList[x] = cardList[y];
                        cardList[y] = temp;
                    }

                }

            }
            return cardList;
        }


        public void DisplayList(List<Card> cardList,string title)
        {
            Console.WriteLine();
            Console.WriteLine(title);
            var counter = 1;

            foreach (Card card in cardList)
            {
                Console.WriteLine(counter + " " + card.Suit + " " + card.Value);
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
