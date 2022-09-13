using System;
using System.Collections.Generic;

namespace GreenField
{
    public class Board
    {

        public List<Player> Players { get; set; }
        private Deck deck;
        public Board()
        {
            //adding the player
            InitializeGame();
            //Initialize a deck of cards
            deck = new Deck();
        }

        public void ShaffleCards()
        {
            deck.Shuffle(2);
        }

        public void DistributeCards()
        {
            List<Card> cards = deck.Repository;
            for (int i = 0; i < cards.Count; i++)
            {
                int playerIndex = i % 4;
                Players[playerIndex].AddCard(cards[i]);
            }
        }

        public void PrintBoard()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine("Player Name", player.Name);
                Console.WriteLine("Card in Hands:");

                for (int i = 0; i < player.Cards.Count; i++)
                {
                    Console.WriteLine("      " + player.Cards[i].ToString());
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }



        private void InitializeGame()
        {
            Players = new List<Player>
            {
                new Player("John"),
                new Player("David"),
                new Player("Bob"),
                new Player("Jenny"),
            };


        }
    }
}