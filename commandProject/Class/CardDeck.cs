using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static commandProject.Class.Card;

namespace commandProject.Class
{
    public class CardDeck
    {
        private List<Card> Cards { get; set; }

        public CardDeck()
        {
            CreateDeck();
            Shuffle();
        }

        private void CreateDeck()
        {
            Cards = new List<Card>();
            for (int i = 1; i <= 6; i++)
            {
                if(i <= 1)
                {
                    Cards.Add(new Card() { Color = CandyColor.Cupcake, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.IceCream, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.Chocolate, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.Lollipop, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.IcePop, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.Star, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.Gingerbread, Amount = 1 });
                }
                if(i <= 3)
                {
                    Cards.Add(new Card() { Color = CandyColor.Green, Amount = 2 });
                    Cards.Add(new Card() { Color = CandyColor.Blue, Amount = 2 });
                }
                if(i <= 5)
                {
                    Cards.Add(new Card() { Color = CandyColor.Red, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.Orange, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.Blue, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.Green, Amount = 1 });
                    Cards.Add(new Card() { Color = CandyColor.Purple, Amount = 1 });
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int length = Cards.Count;
            while (length > 1)
            {
                length--;
                int k = rng.Next(length + 1);
                Card value = Cards[k];
                Cards[k] = Cards[length];
                Cards[length] = value;
            }
        }

        public Card Draw()
        {
            if (!Cards.Any())
            {
                CreateDeck();
                Shuffle();
            }
            var card = Cards.First();
            Cards.RemoveAt(0);
            return card;
        }
    }
}
