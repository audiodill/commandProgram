using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static commandProject.Class.Card;

namespace commandProject.Class
{
    public class Player
    {
        private string name;
        private int order;
        private bool isWinner;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int CurrentLocation { get; set; }
        

        public int Order { get; set; }
        public bool IsSkipped { get; set; }
        public bool IsWinner { get; set; }

        public string TakeTurn(Board board, CardDeck deck)
        {
            if (IsSkipped)
            {
                IsSkipped = false;
                return Name + " was skipped!";
            }
            var card = deck.Draw();
            int matchingIndex = CurrentLocation;
            var space = board.Spaces.GetMatchingSpace(CurrentLocation, card);
            CurrentLocation = space.Location;
            string message = Name + " moved to Space " + CurrentLocation.ToString() + " which is a " + space.Color.ToString() + " space. ";
            if (space.IsLicorice)
            {
                IsSkipped = true;
                message += Name + " is stuck by Licorice!";
            }
            if (space.ShortcutDestination.HasValue)
            {
                CurrentLocation = space.ShortcutDestination.Value;
                message += Name + " took a shortcut to Space " + CurrentLocation.ToString() + "!";
            }
            if(CurrentLocation == 133)
            {
                isWinner = true;
                message += Name + " won the game!";
            }
            return message;
        }
    }
}
