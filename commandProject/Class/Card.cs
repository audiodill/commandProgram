using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using commandProject.Class;

namespace commandProject.Class
{
    public class Card
    {
        
        public enum CandyColor
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Purple,
            Cupcake,
            Star,
            IceCream,
            Gingerbread,
            Chocolate,
            Lollipop,
            IcePop,
            Rainbow
        }

       

        public CandyColor Color { get; set; }
        public int Amount { get; set; }
        
    }
}
