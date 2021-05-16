//Lab Exercise 5.17.2021
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cardgame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a deck of cards and two players
            DeckOfCards theDeck = new DeckOfCards();
            PlayerHand player1 = new PlayerHand();
            PlayerHand player2 = new PlayerHand();

            //Shuffle the deck
            theDeck.shuffle();

            //Deal the cards
            for (int count = 0; count <= 4; count++)
            {
                player1.addCard(theDeck.deal());
                player2.addCard(theDeck.deal());
            }

            //Show player 1 hand
            Console.WriteLine("Player 1 Hand");
            player1.showHand();
            Console.WriteLine("Player 1 value = " + player1.getValue());

            //Show player 2 hand
            Console.WriteLine(Environment.NewLine+ Environment.NewLine + "Player 2 Hand");
            player2.showHand();
            Console.WriteLine("Player 2 value = " + player2.getValue());

            Console.WriteLine();

            //Determine which player won
            if (player1.getValue() == player2.getValue())
                Console.WriteLine("It's a draw");
            else if (player1.getValue() > player2.getValue())
                Console.WriteLine("Player 1 wins");
            else
                Console.WriteLine("Player 2 wins");
        }
    }
}
