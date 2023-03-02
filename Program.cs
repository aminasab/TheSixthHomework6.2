namespace TheSixthProgram2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet venus = new("Венера", 2, 38_025);
            Planet earth = new("Земля", 3, 40_075, venus);
            Planet mars = new("Марс", 4, 21_344, earth);
            CatalogOfPlanets catalogOfPlanets = new(venus, earth, mars);

            var a = catalogOfPlanets.ToGetAplanet("Земля");
            var b = catalogOfPlanets.ToGetAplanet("Лимония");
            var c = catalogOfPlanets.ToGetAplanet("Марс");
            Tuple<int, int, string>[] tuples = new Tuple<int, int, string>[] { a, b, c };
            foreach (var tuple in tuples)
            {
                if (tuple.Item1 != 0)
                {
                    Console.WriteLine($"Порядковый номер от Солнца: {tuple.Item1}, Длина экватора: {tuple.Item2}, Название планеты: {tuple.Item3}");
                }
                else
                {
                    Console.WriteLine(tuple.Item3);
                }
            }
        }
    }
}
