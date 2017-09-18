using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandProject.Class
{
    public static class Extensions
    {
        public static BoardSpace GetMatchingSpace(this List<BoardSpace> spaces, int currentIndex, Card card)
        {

            if (card.IsSpecialty())
            {
                var allMatches = spaces.Where(x => x.Color == card.Color);
                return allMatches.First();   
            }
            else
            {
                var index = spaces.FindIndex(currentIndex + 1, x => x.Color == card.Color);
                if(index == -1)
                {
                    return new BoardSpace()
                    {
                        Color = Card.CandyColor.Rainbow,
                        Location = 133
                    };
                }
                return spaces[index];
            }
        }

    }
}
