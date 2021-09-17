using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactica.Inheritance;

namespace Galactica.Stars_Planets_Moons
{
    class Star : SpaceObject
    {
        public StartType _StartType { get; set; }
        public int _Temperatur { get; set; }
        public override Position _position
        {
            get { return new Position() { X = 0, Y = 0 }; }
        }
        public List<Planet> planets = new List<Planet>();
        //Position _Position
        //{
        //    get { return _Position; }
        //}
    }
}
