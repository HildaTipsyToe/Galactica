using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactica.Inheritance;
using Galactica.Stars_Planets_Moons;

namespace Galactica.Stars_Planets_Moons
{
    class Planet: SpaceObject
    {
        public PlanetType _planetType { get; set; }
        public int Diameter { get; set; }
        public float RotationsPeriode { get; set; }
        public float RevolutionsPeriode { get; set; }

        public List<Moon> _moons = new List<Moon>();
        public float Distance(Star star)
        {
            return (float)Math.Sqrt(Math.Pow(_position.X - star._position.X, 2)+Math.Pow(_position.Y - star._position.Y, 2))*100;
        }
        
    }
}
