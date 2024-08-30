using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexumChallange.Entities
{
    public class Traveler
    {
        public Guid Id { get; set; }
        public string Tag { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        public string InfoVariables { get; set; }
    }
}
