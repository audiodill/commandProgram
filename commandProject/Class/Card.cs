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
        
        public bool IsStandard()
        {
            return Color == CandyColor.Red
                || Color == CandyColor.Blue
                || Color == CandyColor.Orange
                || Color == CandyColor.Yellow
                || Color == CandyColor.Green
                || Color == CandyColor.Purple;
        }

        public bool IsSpecialty()
        {
            return Color == CandyColor.Cupcake
                || Color == CandyColor.IcePop
                || Color == CandyColor.Chocolate
                || Color == CandyColor.IceCream
                || Color == CandyColor.Gingerbread
                || Color == CandyColor.Star
                || Color == CandyColor.Lollipop;
        }
    }
}
