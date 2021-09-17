using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica.Stars_Planets_Moons
{
    sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }
        public float Distance(Planet star)
        {
            return (float)Math.Sqrt(Math.Pow(_position.X - star._position.X, 2) + Math.Pow(_position.Y - star._position.Y, 2))*100;
        }
    }
}
