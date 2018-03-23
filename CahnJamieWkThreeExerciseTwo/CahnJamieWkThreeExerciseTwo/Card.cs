using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CahnJamieWkThreeExerciseTwo
{
    class Card
    {
        public int _value;
        public string _name;
        public string _suit;

        public Card(int value, string name, string suit)
        {
            _value = value;
            _name = name;
            _suit = suit;
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }
    }
}
