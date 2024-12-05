namespace Program2
{
    public class PlanetCatalog
    {
        public List<Planet> Planets = new();

        public PlanetCatalog()
        {
            Planets.Add(new Planet("Венера", 2, 38025));
            Planets.Add(new Planet("Земля", 3, 40075, Planets.Last()));
            Planets.Add(new Planet("Марс", 4, 21344, Planets.Last()));
        }

        private int GetPlanetCallCount = 0;

        public (int orderNumberFromTheSun, int equatorLength, string errorMessage) GetPlanet(string planetName)
        {
            GetPlanetCallCount++;

            if (GetPlanetCallCount % 3 == 0)
            {
                return (0, 0, "Вы спрашиваете слишком часто");
            }
            foreach (var planet in Planets)
            {
                if (planet.Name == planetName)
                {
                    return (planet.OrderNumberFromTheSun, planet.EquatorLength, "");
                }
            }

            return (0, 0, "Не удалось найти планету");
        }
    }
}
