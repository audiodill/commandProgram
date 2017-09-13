using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandProject.Class
{
    class Yahtzee
    {
        private string name;
        private int onesPlace;
        private int twosPlace;
        private int threesPlace;
        private int foursPlace;
        private int fivesPlace;
        private int sixesPlace;
        private int threeOfAKind;
        private int fourOfAKind;
        private int fullHouse;
        private int smStraight;
        private int lgStraight;
        private int yahtzee;
        private int yahtzeeBonus1;
        private int yahtzeeBonus2;
        private string rollDice;

        private bool ones;
        private bool twos;
        private bool threes;
        private bool fours;
        private bool fives;
        private bool sixes;
        private bool threeOfKind;
        private bool fourOfKind;
        private bool smallStraight;
        private bool largeStraight;
        private bool fiveOfAKind;
        private bool yahtzeeBonusOne;
        private bool yahtzeeBonusTwo;

        private int diceOne;
        private int diceTwo;
        private int diceThree;
        private int diceFour;
        private int diceFive;
        
        public int OnesPlace
        {
            set { this.onesPlace = value; }
        }

        public int TwosPlace
        {
            set { this.twosPlace = value; }
        }

        public int ThreesPlace
        {
            set { this.threesPlace = value; }
        }

        public int FoursPlace
        {
            set { this.foursPlace = value; }
        }

        public int FivesPlace
        {
            set { this.fivesPlace = value; }
        }

        public int SixesPlace
        {
            set { this.sixesPlace = value; }
        }

        public int ThreeOfAKind
        {
            set { this.threeOfAKind = value; }
        }

        public int FourOfAKind
        {
            set { this.fourOfAKind = value; }
        }

        public int SmStraight
        {
            set { this.smStraight = value; }
        }

        public int LgStraight
        {
            set { this.lgStraight = value; }
        }

        public int Yahtzee
        {
            set { this.yahtzee = value; }
        }

        
    }
}
