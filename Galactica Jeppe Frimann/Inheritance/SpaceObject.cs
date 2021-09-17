using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica .Inheritance
{
    abstract class SpaceObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Position _position { get ; set; }
        
        public class Position
        {
            public float X { get; set; }
            public float Y { get; set; }

            public override string ToString()
            {
                return $"{X},{Y}";
            }
        }    
    }
}
