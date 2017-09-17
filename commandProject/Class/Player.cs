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

        public int CurrentLocation
        {
            { get; set; }
        }

        public int Order { get; set; }
        public bool IsSkipped { get; set; }
        public bool IsWinner { get; set; }


    }
}
