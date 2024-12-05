namespace Program3
{
    public class PlanetCatalog
    {
        public delegate string? PlanetValidator(string planetName);
        public List<Planet> Planets = new();

        public PlanetCatalog()
        {
            Planets.Add(new Planet("Венера", 2, 38025));
            Planets.Add(new Planet("Земля", 3, 40075, Planets.Last()));
            Planets.Add(new Planet("Марс", 4, 21344, Planets.Last()));
        }

        public (int orderNumberFromTheSun, int equatorLength, string errorMessage) GetPlanet(string planetName, PlanetValidator planetValidator)
        {
            var validationError = planetValidator(planetName);
            if (validationError is not null)
            {
                return (0, 0, validationError);
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
