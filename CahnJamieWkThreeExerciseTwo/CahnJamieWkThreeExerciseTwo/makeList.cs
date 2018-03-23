using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CahnJamieWkThreeExerciseTwo
{
    class makeList
    {
        enum Suit
        {
            Hearts, Diamond, Clubs, Spades
        }

        public makeList(List<Card> cardList)
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int i = 2; i < 11; i++)
                {
                    cardList.Add(new Card(i, i.ToString(), suit.ToString()));
                }
                cardList.Add(new Card(15, "Ace", suit.ToString()));
                cardList.Add(new Card(12, "King", suit.ToString()));
                cardList.Add(new Card(12, "Queen", suit.ToString()));
                cardList.Add(new Card(12, "Jack", suit.ToString()));

            }
        }


    

    }
}
