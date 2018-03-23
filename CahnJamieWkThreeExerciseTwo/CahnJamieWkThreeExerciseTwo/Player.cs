using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CahnJamieWkThreeExerciseTwo
{
    class Player
    {
        //variables
        List<Card> _playerHand;
        string _name;

        public Player(string name, List<Card> playerHand)
        {
           _name = name;
           _playerHand = playerHand;
        }

        public string Name
        {
            get { return _name; } set { _name = value; }
        }

        public List<Card> PlayerHand
        {
            get { return _playerHand; } set { _playerHand = value; }
        }
    }
}
