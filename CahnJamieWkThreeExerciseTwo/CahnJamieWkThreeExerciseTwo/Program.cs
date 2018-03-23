using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CahnJamieWkThreeExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            List<Card> deckOfCards = new List<Card>();
            List<Card> playerOneHand = new List<Card>();
            List<Card> playerTwoHand = new List<Card>();
            List<Card> playerThreeHand = new List<Card>();
            List<Card> playerFourHand = new List<Card>();
            Program instance = new Program();
            int playerOneValue = 0;
            int playerTwoValue = 0;
            int playerThreeValue = 0;
            int playerFourValue = 0;
            int place = 1;

            //makeLists
            makeList makeNewList = new makeList(deckOfCards);
            //create players
            Player playerOne = new Player("Jeff", playerOneHand);
            Player playerTwo = new Player("Tom", playerTwoHand);
            Player playerThree = new Player("Mary", playerThreeHand);
            Player playerFour = new Player("Annie", playerFourHand);

            //shuffle deck
            instance.RandomList(deckOfCards);

            //give players cards
            Console.Clear();

            for (int i = 0; i < 14; i++)
            {
                playerOne.PlayerHand.Add(deckOfCards[i]);
                deckOfCards.RemoveAt(i);
            }
            for (int i = 0; i < 14; i++)
            {
                playerTwo.PlayerHand.Add(deckOfCards[i]);
                deckOfCards.RemoveAt(i);
            }
            for (int i = 0; i < 14; i++)
            {
                playerThree.PlayerHand.Add(deckOfCards[i]);
                deckOfCards.RemoveAt(i);
            }
            for (int i = 0; i < 14; i++)
            {
                playerFour.PlayerHand.Add(deckOfCards[i]);
                deckOfCards.RemoveAt(i);
            }
            for (int i = 0; i <= playerOne.PlayerHand.Count; i++)
            {
                playerOneValue = playerOne.PlayerHand[i].Value + playerOneValue;
            }
            for (int i = 0; i <= playerOne.PlayerHand.Count; i++)
            {
                playerTwoValue = playerTwo.PlayerHand[i].Value + playerTwoValue;
            }
            for (int i = 0; i <= playerOne.PlayerHand.Count; i++)
            {
                playerThreeValue = playerThree.PlayerHand[i].Value + playerThreeValue;
            }
            for (int i = 0; i <= playerOne.PlayerHand.Count; i++)
            {
                playerFourValue = playerFour.PlayerHand[i].Value + playerFourValue;
            }

            //Create Dictionary of Players with their values
            Dictionary<Player, int> playerValues = new Dictionary<Player, int>();

            playerValues.Add(playerOne, playerOneValue);
            playerValues.Add(playerTwo, playerTwoValue);
            playerValues.Add(playerThree, playerThreeValue);
            playerValues.Add(playerFour, playerFourValue);

            playerValues.OrderByDescending(x => playerValues).ToList();
            
            //Display to Console
            foreach (KeyValuePair<Player, int> p in playerValues)
            {
                Console.WriteLine($"Place {place++}");
                Console.WriteLine($"{playerValues.Keys.ToString()}");
                foreach (KeyValuePair<Player, int> c in playerValues)
                {
                    Console.Write($"Card: {c.Key.Name}");
                    Console.WriteLine();
                }
                Console.WriteLine($"{playerValues.Values}");
            }
        }
        private void RandomList(List<Card> cardList)
        {
            List<Card> cl = new List<Card>();
            var rnd = new Random();
            cl = cardList.OrderBy(x => rnd.Next()).ToList();
            cl = cl.OrderBy(x => rnd.Next()).ToList();
        }
    }
}
