using System;
using System.Collections.Generic;
using System.Text;

namespace TheCard
{
    enum CardColor { Red, Green, Blue, Yellow }
    enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Modulo, Caret, Ampersand }
    internal class Card
    {
        public CardRank Rank { get; private set; }

        public CardColor Color { get; private set; }

        public Card(CardColor color, CardRank rank)
        {
            Rank = rank;
            Color = color;
        }

        public bool IsCardNumber()
        {
            return Rank <= CardRank.Ten;
        }

        public override string ToString()
        {
            return $"The {Color} {Rank}";
        }
    }
}
