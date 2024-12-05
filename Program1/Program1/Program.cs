namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var venus1 = new { Name = "Венера", OrderNumberFromTheSun = 2, EquatorialLength = 38025, PreviousPlanet = (object)null };
            var earth = new { Name = "Земля", OrderNumberFromTheSun = 3, EquatorialLength = 40075, PreviousPlanet = venus1 };
            var mars = new { Name = "Марс", OrderNumberFromTheSun = 4, EquatorialLength = 21344, PreviousPlanet = earth };
            var venus2 = new { Name = "Венера", OrderNumberFromTheSun = 2, EquatorialLength = 38025, PreviousPlanet = (object)null };

            Console.WriteLine(
                $"Планета: {venus1.Name}, " +
                $"Порядковый номер от Солнца: {venus1.OrderNumberFromTheSun}" +
                $", Длина экватора: {venus1.EquatorialLength}" +
                $", Эквивалентна Венере: {(venus1.Equals(venus1) ? "Да" : "Нет")}"
            );
            Console.WriteLine(
                $"Планета: {earth.Name}, " +
                $"Порядковый номер от Солнца: {earth.OrderNumberFromTheSun}" +
                $", Длина экватора: {earth.EquatorialLength}" +
                $", Предыдущая планета: {earth.PreviousPlanet.Name}" +
                $", Эквивалентна Венере: {(earth.Equals(venus1) ? "Да" : "Нет")}"
            );
            Console.WriteLine(
                $"Планета: {mars.Name}, " +
                $"Порядковый номер от Солнца: {mars.OrderNumberFromTheSun}" +
                $", Длина экватора: {mars.EquatorialLength}" +
                $", Предыдущая планета: {mars.PreviousPlanet.Name}" +
                $", Эквивалентна Венере: {(mars.Equals(venus1) ? "Да" : "Нет")}"
            );
            Console.WriteLine(
                $"Планета: {venus2.Name}, " +
                $"Порядковый номер от Солнца: {venus2.OrderNumberFromTheSun}" +
                $", Длина экватора: {venus2.EquatorialLength}" +
                $", Эквивалентна Венере: {(venus2.Equals(venus1) ? "Да" : "Нет")}"
            );
        }
    }
}
