using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandProject.Class
{
    public class Player
    {
        private string name;
        private int currentLocation;
        private int order;
        private bool isSkipped;
        private bool isWinner;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int CurrentLocation
        {
            get { return currentLocation; }
        }


    }
}
