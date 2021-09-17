using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactica.Inheritance;
using Galactica.Stars_Planets_Moons;

namespace Galactica
{
    public class Insert
    {
        static public void Opret()
        {

            Star Sun = new Star()
            {
                ID = 1,
                Name = "Sun",
                _position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                _StartType = StartType.YellowDwarf,
                _Temperatur = 5500,


            };

            Planet Mercury = new Planet()
            {
                ID = 1,
                Name = "Mercury",
                _position = (new SpaceObject.Position() { X = 1, Y = 2 }),
                _planetType = PlanetType.Terrestial,
                Diameter = 4880000,
                RotationsPeriode = 1407,
                RevolutionsPeriode = 88
            };


            Planet Venus = new Planet()
            {
                ID = 2,
                Name = "Venus",
                _position = (new SpaceObject.Position() { X = 3, Y = 4 }),
                _planetType = PlanetType.Terrestial,
                Diameter = 6051800,
                RotationsPeriode = 5832,
                RevolutionsPeriode = 116
            };

            Planet Earth = new Planet()
            {
                ID = 3,
                Name = "Earth",
                _position = (new SpaceObject.Position() { X = 5, Y = 6 }),
                _planetType = PlanetType.Terrestial,
                Diameter = 6371000,
                RotationsPeriode = 24,
                RevolutionsPeriode = 365
            };
            Planet Mars = new Planet()
            {
                ID = 4,
                Name = "Mars",
                _position = (new SpaceObject.Position() { X = 7, Y = 8 }),
                _planetType = PlanetType.Terrestial,
                Diameter = 6779000,
                RotationsPeriode = 24.6f,
                RevolutionsPeriode = 687
            };
            Planet Jupiter = new Planet()
            {
                ID = 5,
                Name = "Jupiter",
                _position = (new SpaceObject.Position() { X = 9f, Y = 10f }),
                _planetType = PlanetType.Gas_Giant,
                Diameter = 139820000,
                RotationsPeriode = 10,
                RevolutionsPeriode = 4380
            };
            Planet Saturn = new Planet()
            {
                ID = 6,
                Name = "Saturn",
                _position = (new SpaceObject.Position() { X = 11f, Y = 12f }),
                _planetType = PlanetType.Gas_Giant,
                Diameter = 116460000,
                RotationsPeriode = 10.2f,
                RevolutionsPeriode = 10752.9f,
            };
            Planet Uranus = new Planet()
            {
                ID = 7,
                Name = "Uranus",
                _position = (new SpaceObject.Position() { X = 13f, Y = 14f }),
                _planetType = PlanetType.Gas_Giant,
                Diameter = 50724000,
                RotationsPeriode = 17,
                RevolutionsPeriode = 30660
            };
            Planet Neptune = new Planet()
            {
                ID = 8,
                Name = "Neptune",
                _position = (new SpaceObject.Position() { X = 15f, Y = 16f }),
                _planetType = PlanetType.Gas_Giant,
                Diameter = 49244000,
                RotationsPeriode = 18,
                RevolutionsPeriode = 60225
            };
            Moon Luna = new Moon()
            {
                ID = 1,
                Name = "Luna",
                _position = (new SpaceObject.Position() { X = 5.5f, Y = 5.5f }),
                Orbiting = Earth,
            };
            Moon Titan = new Moon()
            {
                ID = 2,
                Name = "Titan",
                _position = (new SpaceObject.Position() { X = 11.3f, Y = 11.3f }),
                Orbiting = Saturn,
            };
            Moon Phobos = new Moon()
            {
                ID = 3,
                Name = "Phobos",
                _position = (new SpaceObject.Position() { X = 7.5f, Y = 7.5f }),
                Orbiting = Mars,
            };
            Moon Europa = new Moon()
            {
                ID = 4,
                Name = "Europa",
                _position = (new SpaceObject.Position() { X = 9.5f, Y = 9.5f }),
                Orbiting = Jupiter,
            };
            Moon Deimos = new Moon()
            {
                ID = 5,
                Name = "Deimos",
                _position = (new SpaceObject.Position() { X = 7.5f, Y = 7.3f }),
                Orbiting = Mars,
            };
            Moon Ganymedes = new Moon()
            {
                ID = 6,
                Name = "Ganymedes",
                _position = (new SpaceObject.Position() { X = 9.5f, Y = 9.3f }),
                Orbiting = Jupiter,
            };
            Moon IO = new Moon()
            {
                ID = 7,
                Name = "IO",
                _position = (new SpaceObject.Position() { X = 9.3f, Y = 9.4f }),
                Orbiting = Jupiter,
            };
            Moon Mimas = new Moon()
            {
                ID = 8,
                Name = "Mimas",
                _position = (new SpaceObject.Position() { X = 11.6f, Y = 11.4f }),
                Orbiting = Saturn,
            };
            Sun.planets.AddRange(new List<Planet>() { Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune });
            Earth._moons.Add(Luna);
            Saturn._moons.Add(Titan);
            Mars._moons.Add(Phobos);
            Jupiter._moons.Add(Europa);
            Mars._moons.Add(Deimos);
            Jupiter._moons.Add(Ganymedes);
            Jupiter._moons.Add(IO);
            Saturn._moons.Add(Mimas);

            Console.WriteLine("**** SHOW  ****");

            Console.WriteLine($"ID: {Sun.ID}\nStar: {Sun.Name} \nPosition: {Sun._position} \nStartype: {Sun._StartType} \nTemps: {Sun._Temperatur}\n");
            Console.WriteLine("**** Planets in the solarsystem ****");
            foreach (var Planet in Sun.planets)
            {
                Console.WriteLine($"ID: {Planet.ID} \nPlanet: {Planet.Name} \nPosition: {Planet._position} \nPlanetType: {Planet._planetType} " +
                    $"\nDiameter: {Planet.Diameter} Meters \nRotationsPeriode: {Planet.RotationsPeriode} Hours \nRevolutionsPeriode: {Planet.RevolutionsPeriode} Days" +
                    $"\nDistance: {Planet.Distance(Sun)} Kilometers\n");

                if(Planet._moons.Count >= 1)
                    {
                    Console.WriteLine("**** Moons orbiting this planet **** ");
                    }
                foreach (var Moon in Planet._moons)
                {                    
                    Console.WriteLine($"ID {Moon.ID} \nName: {Moon.Name} \n Position: {Moon._position} \nOrbiting: {Moon.Orbiting.Name} \nDistance: {Moon.Distance(Planet)} Kilometers\n");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("**** END ****");
        }
    }
}
