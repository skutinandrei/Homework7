namespace Program3
{
    public class Planet
    {
        public string Name { get; set; }
        public int OrderNumberFromTheSun { get; set; }
        public int EquatorLength { get; set; }
        public Planet? PreviousPlanet { get; set; }

        public Planet(string name, int orderNumberFromTheSun, int equatorLength, Planet? previousPlanet = null)
        {
            Name = name;
            OrderNumberFromTheSun = orderNumberFromTheSun;
            EquatorLength = equatorLength;
            PreviousPlanet = previousPlanet;
        }
    }
}
