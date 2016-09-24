namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            ProcessCards process = new ProcessCards();
            var cardList = process.CreateCards();
            process.DisplayList(cardList,"Created");
            var cardListSorted = process.SortCards(cardList);
            process.DisplayList(cardListSorted,"Sorted");
            var cardListShuffled = process.ShuffleCards(cardListSorted);
            process.DisplayList(cardListShuffled, "Shuffled");
            cardListSorted = process.SortCards(cardListShuffled);
            process.DisplayList(cardListSorted, "Sorted Again");
        }
    }
}
