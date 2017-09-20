using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static commandProject.Class.Card;

namespace commandProject.Class
{
    public class BoardSpace
    {
        
        public CandyColor Color { get; set; }
        public int Position { get; set; }
        public bool IsLicorice { get; set; }
        public int? ShortcutDestination { get; set; }
        public int Location { get; set; }
    }
}
