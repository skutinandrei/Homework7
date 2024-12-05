namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var planetCatalog = new PlanetCatalog();

            var planetNames = new[] { "Земля", "Лимония", "Венера" };

            foreach (var planetName in planetNames)
            {
                var planetSearchResult = planetCatalog.GetPlanet(planetName);
                if (planetSearchResult.errorMessage == "")
                {
                    Console.WriteLine($"{planetName}. Порядковый номер от Солнца: {planetSearchResult.orderNumberFromTheSun}, длина экватора: {planetSearchResult.equatorLength}");
                }
                else
                {
                    Console.WriteLine($"{planetSearchResult.errorMessage}");
                }
            }
        }
    }
}
