using static Program3.PlanetCatalog;

namespace Program3
{
    public class Program
    {

        private static int _getPlanetCount = 0;

        static void Main(string[] args)
        {
            var planetCatalog = new PlanetCatalog();

            var planetNames = new[] { "Земля", "Лимония", "Венера" };

            Console.WriteLine("Защита от слишком частых вызовов:");
            foreach (var planetName in planetNames)
            {
                ShowPlanet(planetCatalog, planetName, (planetName) => (_getPlanetCount % 3 == 0) ? "Вы спрашиваете слишком часто" : null);
            }

            Console.WriteLine("\nПроверка на запретную планету:");

            foreach (var planetName in planetNames)
            {
                ShowPlanet(planetCatalog, planetName, (planetName) => (planetName == "Лимония") ? "Это запретная планета" : null);
            }
        }

        static void ShowPlanet(PlanetCatalog planetCatalog, string planetName, PlanetValidator validator)
        {
            _getPlanetCount++;
            var (orderNumberFromTheSun, equatorLength, errorMessage) = planetCatalog.GetPlanet(planetName, validator);
            if (errorMessage == "")
            {
                Console.WriteLine($"{planetName}. Порядковый номер от Солнца: {orderNumberFromTheSun}, длина экватора: {equatorLength}");
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
}
