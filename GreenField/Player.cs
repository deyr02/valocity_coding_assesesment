using System.Collections.Generic;

namespace GreenField
{
    public class Player
    {

        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public Player(string name)
        {
            this.Name = name;
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            List<Card> temp = Cards;
            temp.Add(card);
            Cards = temp;
        }
    }
}