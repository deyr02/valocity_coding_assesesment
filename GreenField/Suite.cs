using System.Collections.Generic;

namespace GreenField
{
    public class Suite
    {
        public string Name { get; set; }
        public List<Card> Cards { get; private set; }


        public Suite(string name)
        {
            this.Name = name;
            this.InitializeCards();
        }

        private string[] Positions => new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        private void InitializeCards()
        {
            List<Card> temp = new List<Card>();
            foreach (var position in Positions)
            {
                temp.Add(new Card(this.Name, position));
            }
            this.Cards = temp;
        }
    }
}