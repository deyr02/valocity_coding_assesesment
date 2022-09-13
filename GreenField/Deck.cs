using System;
using System.Collections.Generic;
using System.Linq;

namespace GreenField
{
    public class Deck
    {

        public List<Card> Repository { get; private set; }
        public Deck()
        {
            this.InitializeSuites();
        }

        private void InitializeSuites()
        {
            List<Card> temp = new List<Card>();
            var hearts = new Suite("Heart");
            var diamond = new Suite("Diamond");
            var spades = new Suite("Spade");
            var clubs = new Suite("Club");

            temp.AddRange(hearts.Cards);
            temp.AddRange(diamond.Cards);
            temp.AddRange(spades.Cards);
            temp.AddRange(clubs.Cards);
            this.Repository = temp;
        }

        public List<Card> Shuffle(int time)
        {
            Random rnd = new Random();
            for (int i = 0; i < time; i++)
            {
                Repository = Repository.OrderBy(r => rnd.Next()).ToList();
            }

            return this.Repository;
        }
    }
}